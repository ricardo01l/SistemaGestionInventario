Imports entidad
Imports datos

Public Class producto



    Dim fp As New Fproducto
    Dim ep As New Eproducto
    Public dt As New DataTable


    ' -------------------- EVENTOS -------------------------------
    ' CUANDO CARGUE LA FORMA
    Private Sub formProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
    End Sub


    ' CUANDO CAMBIA EL COMBOBOX CODPROD
    Private Sub combCodProd_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodProd.SelectedValueChanged
        If Me.cmbCodProd.SelectedItem.ToString <> "" Then
            dt = fp.consultarRegistro("CodProd", Me.cmbCodProd.SelectedItem.ToString, "TProducto", True)
            Try
                If dt.Rows.Count > 0 Then

                    ep._codProd = dt(0)("CodProd").ToString
                    ep._nombreProd = dt(0)("NombreProd").ToString
                    ep._descProd = dt(0)("DescripProd").ToString


                    Me.txtCodProd.Text = ep._codProd
                    Me.txtNombrProd.Text = ep._nombreProd
                    Me.txtDescProd.Text = ep._descProd
                    eliminarVacioCmb(Me.cmbCodProd)


                    enableControles(True)
                Else
                    enableControles(False)

                    MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
                End If
                fp.desconectar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    ' CUANDO SE PRECIONEN LAS TECLAS EN LOS CAMPOS LIMITADOS
    Private Sub txtCodProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodProd.KeyPress
        soloNumerosYletras(e)
    End Sub
    Private Sub txtNombrProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombrProd.KeyPress
        soloLetrasYEspacios(e)
    End Sub


    ' CUANDO SE DEJA EL CAMPO CODPROD
    Private Sub txtCodProd_Leave1(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtCodProd.Text.ToString <> "" Then
            dt = fp.consultarRegistro("CodProd", Me.txtCodProd.Text.ToString, "TProducto", True)


            If dt.Rows.Count > 0 Then

                ep._codProd = dt(0)("CodProd").ToString
                ep._nombreProd = dt(0)("NombreProd").ToString
                ep._descProd = dt(0)("DescripProd").ToString

                Me.txtCodProd.Text = ep._codProd
                Me.txtNombrProd.Text = ep._nombreProd
                Me.txtDescProd.Text = ep._descProd
                Me.cmbCodProd.SelectedItem = ep._codProd
                eliminarVacioCmb(Me.cmbCodProd)



                enableControles(True)
            Else
                enableControles(False)
            End If

        Else
            limpiarControles()
        End If

    End Sub

    ' CUANDO SE CLIQUEAN LOS BOTONES
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If ((Me.txtCodProd.Text <> "") And (Me.txtDescProd.Text <> "")) Then
            If Me.txtCodProd.TextLength = 15 Then
                If Me.txtNombrProd.TextLength >= 6 Then
                    ep._codProd = Me.txtCodProd.Text
                    ep._nombreProd = Me.txtNombrProd.Text
                    ep._descProd = Me.txtDescProd.Text

                    Try
                        Me.statusLabel.Text = "El producto " & ep._nombreProd & " se ha agregado correctamente."
                        fp.agregar(ep._codProd, ep._nombreProd, ep._descProd)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
                    limpiarControles()
                Else
                    MsgBox("El nombre del producto no puede ser menor a 6 caracteres", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El código del producto tiene que estar totalmente lleno", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Es necesario elegir un código del producto y nombre para modificar sus datos", MsgBoxStyle.Information, "No eligió el código o nombre del producto")
        End If
    End Sub
    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.txtCodProd.Text.ToString <> "" And Me.txtNombrProd.Text.ToString <> "" Then
            If Me.txtCodProd.TextLength = 15 Then
                ep._codProd = Me.txtCodProd.Text
                ep._nombreProd = Me.txtNombrProd.Text
                ep._descProd = Me.txtDescProd.Text

                Try
                    Me.statusLabel.Text = "El producto " & ep._nombreProd & " se ha modificado correctamente."
                    fp.modificar(ep._codProd, ep._nombreProd, ep._descProd)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MsgBox("El código del producto tiene que estar totalmente lleno", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Es necesario elegir un código del producto y nombre para modificar sus datos", MsgBoxStyle.Information, "No eligió el código o nombre del producto")
        End If
    End Sub
    Private Sub btnLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarControles()
    End Sub
    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este producto?", MsgBoxStyle.OkCancel, "Eliminar producto")

        If eliminar = 1 Then
            If Me.txtCodProd.Text.ToString <> "" Then
                ep._codProd = Me.txtCodProd.Text

                Try
                    fp.eliminar(ep._codProd.ToString)
                    Me.statusLabel.Text = "El producto " & ep._nombreProd.ToString & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
                limpiarControles()
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub
    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        consultaProducto.Show()

        dt = fp.consultar("TProducto")


        consultaProducto.dgvProd.DataSource = dt
        Me.Close()
    End Sub

    ' CUANDO SE CLIQUEAN LAS OPCIONES DEL TOOLSTRIP
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        usuario.Show()
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
    Private Sub InventarioGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        inventarioGeneral.Show()
        Me.Close()
    End Sub
    Private Sub BaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseDeDatosToolStripMenuItem.Click
        
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
        ep._codProd = ""
        ep._nombreProd = ""
        ep._descProd = ""

        Me.txtCodProd.Text = ep._codProd
        Me.txtNombrProd.Text = ep._nombreProd
        Me.txtDescProd.Text = ep._descProd

        enableControles(False)
    End Sub

    ' ACTIVA Y DESACTIVA LOS CONTROLES
    Private Sub enableControles(ByVal valor As Boolean)
        If valor Then
            Me.btnModificar.Enabled = valor
            Me.btnEliminar.Enabled = valor
        Else
            Me.btnModificar.Enabled = valor
            Me.btnEliminar.Enabled = valor
            If Me.cmbCodProd.Items.Contains("") Then
                Me.cmbCodProd.SelectedItem = ""
            Else
                Me.cmbCodProd.Items.Add("")
                Me.cmbCodProd.SelectedItem = ""
            End If
        End If
    End Sub
    ' ---------------------------------------------------------------------------------

End Class