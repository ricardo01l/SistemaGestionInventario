Imports entidad
Imports datos

Public Class inventarioGeneral

    Dim fig As New FinventarioGeneral
    Dim eig As New EinventarioGeneral

    Dim ep As New Eproducto
    Public dt As New DataTable

    ' -------------------- EVENTOS --------------------------------
    ' CUANDO CARGUE LA FORMA
    Private Sub inventarioGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbIdInv, "IdInv", "TInventarioGeneral")
        llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
    End Sub

    ' CUANDO CAMBIA EL COMBOBOX CODPROD
    Private Sub cmbCodProd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodProd.SelectedValueChanged
        If Me.cmbCodProd.SelectedItem.ToString <> "" Then
            dt = CType(fig.consultarRegistro("CodProd", Me.cmbCodProd.SelectedItem.ToString, "TProducto", True), DataTable)

            If dt.Rows.Count > 0 Then


                'Cuando cambie el comboBox es importante también asignar la factura correspondiente
                ep._nombreProd = dt(0)("NombreProd").ToString

                Me.txtNombrProd.Text = ep._nombreProd

                eliminarVacioCmb(Me.cmbCodProd)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fig.desconectar()
        End If
    End Sub
    ' CUANDO CAMBIA EL COMBOX IDINV
    Private Sub cmbIdInv_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdInv.SelectedValueChanged
        If Me.cmbIdInv.SelectedItem.ToString <> "" Then
            dt = CType(fig.consultarRegistro("IdInv", Me.cmbIdInv.SelectedItem.ToString, "TInventarioGeneral", False), DataTable)

            If dt.Rows.Count > 0 Then


                'Cuando cambie el comboBox es importante también asignar la factura correspondiente
                eig._idInv = dt(0)("IdInv").ToString
                eig._codProd = dt(0)("CodProd").ToString
                eig._balance = dt(0)("BalanceProd").ToString


                Me.cmbCodProd.SelectedItem = eig._codProd
                Me.txtCantProd.Text = eig._balance

                enableControles(True)

                eliminarVacioCmb(Me.cmbIdInv)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fig.desconectar()
        End If
    End Sub

    ' CUANDO SE PRECIONEN LAS TECLAS EN LOS CAMPOS LIMITADOS
    Private Sub txtCantProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantProd.KeyPress
        soloNumeros(e)
    End Sub

    ' CUANDO SE CLIQUEAN LOS BOTONES
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarControles()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If ((Me.txtCantProd.Text <> "") And (Me.cmbCodProd.Text <> "")) Then
            If CLng(Me.txtCantProd.Text) >= 0 Then
                eig._idInv = Me.cmbIdInv.Text
                eig._codProd = Me.cmbCodProd.Text
                eig._balance = Me.txtCantProd.Text


                Try

                    fig.modificar(eig._idInv, eig._codProd, eig._balance)
                    Me.statusLabel.Text = "El producto " & ep._nombreProd & " se ha modificado correctamente."
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Es necesario elegir un id del registro y un código de producto para modificar sus datos", MsgBoxStyle.Information, "No eligió el código o nombre del producto")
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario? El balance de los ", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbIdInv.SelectedItem.ToString <> "" Then
                eig._idInv = Me.cmbIdInv.SelectedItem.ToString

                Try
                    fig.eliminar(eig._idInv.ToString)
                    Me.statusLabel.Text = "El registro con la id " & eig._idInv.ToString & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbIdInv, "IdInv", "TInventarioGeneral")
                limpiarControles()
            Else
                MsgBox("Es necesario elegir un id del registro para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        consultaInvGeneral.Show()

        dt = CType(fig.consultar("TInventarioGeneral"), DataTable)

        consultaInvGeneral.dgvInv.DataSource = dt
        Me.Close()
    End Sub

    ' CUANDO SE CLIQUEAN LAS OPCIONES DEL TOOLSTRIP
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        producto.Show()
        Me.Close()

    End Sub
    Private Sub ActualizarInventarioDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeComprasToolStripMenuItem.Click
        inventarioCompra.Show()
        Me.Close()
    End Sub
    Private Sub ActualizarInventarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeVentasToolStripMenuItem.Click
        inventarioVenta.Show()
        Me.Close()
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        usuario.Show()
        Me.Close()
    End Sub
    Private Sub InventarioDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioDeComprasToolStripMenuItem.Click
        InformeInvCompr.Show()
        Me.Close()
    End Sub
    Private Sub InventarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioDeVentasToolStripMenuItem.Click
        InformeInvVent.Show()
        Me.Close()
    End Sub
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        Process.Start("Manual de Usuario.pdf")
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub
    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        exportardb(SaveFileDialog1)
    End Sub
    Private Sub ImportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarToolStripMenuItem.Click
        importardb(SaveFileDialog1)
    End Sub
    Private Sub ManejarBaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManejarBaseDeDatosToolStripMenuItem.Click
        baseDatos.Show()
        Me.Close()
    End Sub

    ' ---------------------------------------------------------------------------------


    ' --------------------- FUNCIONES GENÉRICAS-----------------------------------------------
    ' LIMPIA LOS CONTROLES
    Private Sub limpiarControles()
        eig._codProd = ""
        ep._codProd = eig._codProd
        eig._idInv = ""
        ep._nombreProd = ""
        eig._balance = ""


        Me.cmbIdInv.Text = eig._idInv
        Me.cmbCodProd.Text = eig._codProd
        Me.txtCantProd.Text = eig._balance
        Me.txtNombrProd.Text = ep._nombreProd


        enableControles(False)
    End Sub
    ' ACTIVA Y DESACTIVA LOS CONTROLES
    Private Sub enableControles(ByVal valor As Boolean)
        Me.btnModificar.Enabled = valor
        Me.btnEliminar.Enabled = valor
        If Not valor Then

            ' REINICIAR COMBO CODPROD 
            If Me.cmbCodProd.Items.Contains("") Then
                Me.cmbCodProd.SelectedItem = ""
            Else
                Me.cmbCodProd.Items.Add("")
                Me.cmbCodProd.SelectedItem = ""
            End If

            ' REINICIAR COMBO IDINV 
            If Me.cmbIdInv.Items.Contains("") Then
                Me.cmbIdInv.SelectedItem = ""
            Else
                Me.cmbIdInv.Items.Add("")
                Me.cmbIdInv.SelectedItem = ""
            End If
        End If
    End Sub
    ' ---------------------------------------------------------------------------------

End Class