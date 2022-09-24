Imports entidad
Imports datos

Public Class inventarioVenta

    Dim fiv As New FinventarioVenta
    Dim eiv As New EinventarioVenta
    Dim efv As New EfacturaVent

    Dim ep As New Eproducto
    Public dt As New DataTable


    ' FALTA HACER QUE CUANDO SE AGREGE, MODIFIQUE O ELIMINE UN ELEMENTO AL INVENTARIO DE VENTAS, SE LE RESTE
    ' AL BALANCE DEL INVENTARIO GENERAL LA CANTIDAD VENDIDA

    ' -------------------- EVENTOS --------------------------------
    ' CUANDO CARGUE LA FORMA
    Private Sub inventarioVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
        llenarCmb(Me.cmbCodFact, "CodFactVent", "TFacturaVenta")
        llenarCmb(Me.cmbIdInv, "IdInvVent", "TInventarioVenta")
    End Sub

    ' CUANDO CAMBIA EL COMBOBOX CODPROD
    Private Sub cmbCodProd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodProd.SelectedValueChanged
        If Me.cmbCodProd.SelectedItem.ToString <> "" Then
            dt = CType(fiv.consultarRegistro("CodProd", Me.cmbCodProd.SelectedItem.ToString, "TProducto", True), DataTable)

            If dt.Rows.Count > 0 Then


                'Cuando cambie el comboBox es importante también asignar la factura correspondiente
                ep._nombreProd = dt(0)("NombreProd").ToString

                Me.txtNombrProd.Text = ep._nombreProd

                eliminarVacioCmb(Me.cmbCodProd)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fiv.desconectar()
        End If
    End Sub
    ' CUANDO CAMBIA EL COMBOBOX CODFACT
    Private Sub cmbCodFact_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodFact.SelectedValueChanged
        If Me.cmbCodFact.SelectedItem.ToString <> "" Then
            dt = CType(fiv.consultarRegistro("CodFactVent", Me.cmbCodFact.SelectedItem.ToString, "TFacturaVenta", True), DataTable)

            If dt.Rows.Count > 0 Then


                'Cuando cambie el comboBox es importante también asignar la factura correspondiente
                efv._codFactVent = dt(0)("CodFactVent").ToString
                efv._fechaFact = CDate(dt(0)("FechaFact"))


                Me.txtCodFact.Text = efv._codFactVent
                Me.dateFact.Text = efv._fechaFact.ToString

                eliminarVacioCmb(Me.cmbCodFact)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fiv.desconectar()
        End If
    End Sub
    ' CUANDO CAMBIA EL COMBOX IDINV
    Private Sub cmbIdInv_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdInv.SelectedValueChanged
        If Me.cmbIdInv.SelectedItem.ToString <> "" Then
            dt = fiv.consultarRegistro("IdInvVent", Me.cmbIdInv.SelectedItem.ToString, "TInventarioVenta", False)

            If dt.Rows.Count > 0 Then


                'Cuando cambie el comboBox es importante también asignar la factura correspondiente
                eiv._idInvVent = dt(0)("IdInvVent").ToString
                eiv._codProd = dt(0)("CodProd").ToString
                eiv._precio = dt(0)("PrecioVent").ToString
                eiv._cantidad = dt(0)("CantidadVent").ToString
                eiv._codFactVent = dt(0)("CodFactVent").ToString


                Me.cmbCodProd.SelectedItem = eiv._codProd
                Me.cmbCodFact.SelectedItem = eiv._codFactVent
                Me.txtPrecioProd.Text = eiv._precio
                Me.txtCantProd.Text = eiv._cantidad

                enableControles(True)

                eliminarVacioCmb(cmbIdInv)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fiv.desconectar()
        End If
    End Sub

    ' CUANDO SE PRECIONEN LAS TECLAS EN LOS CAMPOS LIMITADOS
    Private Sub txtPrecioProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioProd.KeyPress
        soloNumerosPuntos(e)
    End Sub
    Private Sub txtCantProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantProd.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub txtCodFact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodFact.KeyPress
        soloNumerosYletras(e)
    End Sub

    ' CUANDO SE CLIQUEAN LOS BOTONES
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarControles()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If ((Me.txtCodFact.Text <> "") And (Me.txtPrecioProd.Text <> "") And (Me.txtCantProd.Text <> "") And (Me.cmbCodProd.Text <> "")) Then
            If Me.txtCodFact.TextLength >= 4 Then
                If CLng(Me.txtCantProd.Text) >= 0 Then
                    If CDbl(Me.txtPrecioProd.Text) >= 0 Then
                        eiv._codProd = Me.cmbCodProd.Text
                        eiv._precio = Me.txtPrecioProd.Text
                        eiv._cantidad = Me.txtCantProd.Text

                        efv._codFactVent = Me.txtCodFact.Text
                        efv._fechaFact = CDate(Me.dateFact.Text)


                        Try
                            fiv.agregar(eiv._codProd, eiv._precio, eiv._cantidad, efv._codFactVent, efv._fechaFact.ToString)


                            llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
                            llenarCmb(Me.cmbCodFact, "CodFactVent", "TFacturaVenta")
                            llenarCmb(Me.cmbIdInv, "IdInvVent", "TInventarioVenta")

                            limpiarControles()
                            Me.statusLabel.Text = "El registro se ha agregado correctamente."
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Else
                        MsgBox("El precio no puede ser menor que cero", MsgBoxStyle.Information, "error")
                    End If
                Else
                    MsgBox("La cantidad de los productos no puede ser menor que cero", MsgBoxStyle.Information, "error")
                End If
            Else
                MsgBox("El código de la factura no puede tener menos de 4 caracteres", MsgBoxStyle.Information, "error")
            End If

        Else
            MsgBox("Tiene que llenar todos los campos para añadir un registro al inventario", MsgBoxStyle.Critical, "Le falta un campo por llenar")

        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbIdInv.SelectedItem.ToString <> "" Then
            If Me.txtCodFact.TextLength >= 4 Then
                If CLng(Me.txtCantProd.Text) >= 0 Then
                    If CDbl(Me.txtPrecioProd.Text) >= 0 Then
                        eiv._idInvVent = Me.cmbIdInv.SelectedItem.ToString
                        eiv._codFactVent = Me.cmbCodFact.SelectedItem.ToString
                        eiv._codProd = Me.cmbCodProd.SelectedItem.ToString
                        eiv._cantidad = Me.txtCantProd.Text
                        eiv._precio = Me.txtPrecioProd.Text
                        efv._codFactVent = eiv._codFactVent
                        efv._fechaFact = CDate(Me.dateFact.Text)

                        Try
                            fiv.modificar(eiv._idInvVent, eiv._codProd, eiv._precio, eiv._cantidad, eiv._codFactVent, efv._fechaFact.ToString)
                            Me.statusLabel.Text = "El producto " & ep._nombreProd & " se ha modificado correctamente."
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Else
                        MsgBox("El precio no puede ser menor que cero", MsgBoxStyle.Information, "error")
                    End If
                Else
                    MsgBox("La cantidad de los productos no puede ser menor que cero", MsgBoxStyle.Information, "error")
                End If
            Else
                MsgBox("El código de la factura no puede tener menos de 4 caracteres", MsgBoxStyle.Information, "error")
            End If
        Else
            MsgBox("Es necesario elegir un código del producto y nombre para modificar sus datos", MsgBoxStyle.Information, "No eligió el código o nombre del producto")
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario?", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbIdInv.SelectedItem.ToString <> "" Then
                eiv._idInvVent = Me.cmbIdInv.SelectedItem.ToString

                Try
                    fiv.eliminar(eiv._idInvVent)
                    Me.statusLabel.Text = "El registro con la id " & eiv._idInvVent & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbIdInv, "IdInvVent", "TinventarioVenta")
                limpiarControles()
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Me.Hide()
        consultaInvVent.Show()

        dt = fiv.consultar("TInventarioVenta")

        consultaInvVent.dgvInvVent.DataSource = dt
    End Sub

    ' CUANDO SE CLIQUEAN LAS OPCIONES DEL TOOLSTRIP
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        usuario.Show()
        Me.Close()
    End Sub
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
    Private Sub InventarioGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        inventarioGeneral.Show()
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
        eiv._codProd = ""
        ep._codProd = eiv._codProd
        eiv._idInvVent = ""
        ep._nombreProd = ""
        eiv._precio = ""
        efv._codFactVent = ""
        eiv._cantidad = ""


        Me.txtCodFact.Text = eiv._codProd
        Me.cmbIdInv.Text = eiv._idInvVent
        Me.txtNombrProd.Text = ep._nombreProd
        Me.txtPrecioProd.Text = eiv._precio
        Me.txtCantProd.Text = eiv._cantidad
        Me.txtCodFact.Text = efv._codFactVent
        Me.dateFact.Text = Date.Today.ToString


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

            ' REINICIAR COMBO CODFACT 
            If Me.cmbCodFact.Items.Contains("") Then
                Me.cmbCodFact.SelectedItem = ""
            Else
                Me.cmbCodFact.Items.Add("")
                Me.cmbCodFact.SelectedItem = ""
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