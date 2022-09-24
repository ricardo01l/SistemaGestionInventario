Imports entidad
Imports datos

Public Class inventarioCompra

    Dim fic As New FinventarioCompra
    Dim eic As New EinventarioCompra
    Dim efc As New EfacturaCompra

    Dim ep As New Eproducto
    Public dt As New DataTable

    ' FALTA HACER QUE CUANDO SE AGREGE, MODIFIQUE O ELIMINE UN ELEMENTO AL INVENTARIO DE VENTAS, SE LE SUME
    ' AL BALANCE DEL INVENTARIO GENERAL LA CANTIDAD COMPRADA


    ' -------------------- EVENTOS --------------------------------
    ' CUANDO CARGUE LA FORMA
    Private Sub inventarioCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
        llenarCmb(Me.cmbCodFact, "CodFactCompr", "TFacturaCompra")
        llenarCmb(Me.cmbIdInv, "IdInvCompr", "TInventarioCompra")
    End Sub


    ' CUANDO CAMBIA EL COMBOBOX CODPROD
    Private Sub cmbCodProd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodProd.SelectedValueChanged
        If Me.cmbCodProd.SelectedItem.ToString <> "" Then
            dt = CType(fic.consultarRegistro("CodProd", Me.cmbCodProd.SelectedItem.ToString, "TProducto", True), DataTable)

            If dt.Rows.Count > 0 Then

                ep._nombreProd = dt(0)("NombreProd").ToString
                Me.txtNombrProd.Text = ep._nombreProd.ToString

                eliminarVacioCmb(Me.cmbCodProd)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fic.desconectar()
        End If
    End Sub
    ' CUANDO CAMBIA EL COMBOBOX CODFACT
    Private Sub cmbCodFact_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodFact.SelectedValueChanged
        If Me.cmbCodFact.SelectedItem.ToString <> "" Then
            dt = CType(fic.consultarRegistro("CodFactCompr", Me.cmbCodFact.SelectedItem.ToString, "TFacturaCompra", True), DataTable)

            If dt.Rows.Count > 0 Then
                efc._codFactCompr = dt(0)("CodFactCompr").ToString
                efc._fechaFact = CDate(dt(0)("FechaFact"))
                Me.txtCodFact.Text = efc._codFactCompr.ToString
                Me.dateFact.Text = efc._fechaFact.ToString

                eliminarVacioCmb(Me.cmbCodFact)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fic.desconectar()
        End If
    End Sub
    ' CUANDO CAMBIA EL COMBOX IDINV
    Private Sub cmbIdInv_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdInv.SelectedValueChanged
        If Me.cmbIdInv.SelectedItem.ToString <> "" Then
            dt = CType(fic.consultarRegistro("IdInvCompr", Me.cmbIdInv.SelectedItem.ToString, "TInventarioCompra", False), DataTable)

            If dt.Rows.Count > 0 Then
                eic._idInvCompr = dt(0)("IdInvCompr").ToString
                eic._codProd = dt(0)("CodProd").ToString
                eic._precio = dt(0)("PrecioCompr").ToString
                eic._cantidad = dt(0)("CantidadCompr").ToString
                eic._codFactCompr = dt(0)("CodFactCompr").ToString
                Me.cmbCodProd.SelectedItem = eic._codProd
                Me.cmbCodFact.SelectedItem = eic._codFactCompr
                Me.txtPrecioProd.Text = eic._precio
                Me.txtCantProd.Text = eic._cantidad

                enableControles(True)
                eliminarVacioCmb(Me.cmbIdInv)
            Else
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fic.desconectar()
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
                If CLng(Me.txtCantProd.Text.ToString) >= 0 Then
                    If CDbl(Me.txtPrecioProd.Text.ToString) >= 0 Then
                        eic._codProd = Me.cmbCodProd.Text
                        eic._precio = Me.txtPrecioProd.Text
                        eic._cantidad = Me.txtCantProd.Text
                        efc._codFactCompr = Me.txtCodFact.Text
                        efc._fechaFact = CDate(Me.dateFact.Text)

                        Try
                            fic.agregar(eic._codProd, eic._precio, eic._cantidad, efc._codFactCompr.ToString, efc._fechaFact.ToString)

                            llenarCmb(Me.cmbCodProd, "CodProd", "TProducto")
                            llenarCmb(Me.cmbCodFact, "CodFactCompr", "TFacturaCompra")
                            llenarCmb(Me.cmbIdInv, "IdInvCompr", "TInventarioCompra")

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
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If (Me.cmbIdInv.SelectedItem.ToString <> "") And (Me.txtPrecioProd.Text <> "") And (Me.txtCantProd.Text <> "") And (Me.cmbCodProd.Text <> "") Then
            If Me.txtCodFact.TextLength >= 4 Then
                If CLng(Me.txtCantProd.Text.ToString) >= 0 Then
                    If CDbl(Me.txtPrecioProd.Text.ToString) >= 0 Then
                        eic._idInvCompr = Me.cmbIdInv.SelectedItem.ToString
                        eic._codFactCompr = Me.cmbCodFact.SelectedItem.ToString
                        eic._codProd = Me.cmbCodProd.SelectedItem.ToString
                        eic._cantidad = Me.txtCantProd.Text
                        eic._precio = Me.txtPrecioProd.Text
                        efc._codFactCompr = eic._codFactCompr
                        efc._fechaFact = CDate(Me.dateFact.Text)

                        Try
                            fic.modificar(eic._idInvCompr, eic._codProd, eic._precio, eic._cantidad, eic._codFactCompr, efc._fechaFact.ToString)

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
        fic.desconectar()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario?", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbIdInv.SelectedItem.ToString <> "" Then
                eic._idInvCompr = Me.cmbIdInv.SelectedItem.ToString

                Try
                    fic.eliminar(eic._idInvCompr.ToString)
                    Me.statusLabel.Text = "El registro con la id " & eic._idInvCompr & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbIdInv, "IdInvCompr", "TInventarioCompra")
                limpiarControles()
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        consultaInvCompr.Show()

        setDgv("TInventarioCompra", consultaInvCompr.dgvInvCompr)
        Me.Close()
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
    Private Sub ActualizarInventarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeVentasToolStripMenuItem.Click

        inventarioVenta.Show()
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
    Private Sub BaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        baseDatos.Show()
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
        eic._codProd = ""
        ep._codProd = eic._codProd
        eic._idInvCompr = ""
        ep._nombreProd = ""
        eic._precio = ""
        efc._codFactCompr = ""
        eic._cantidad = ""


        Me.txtCodFact.Text = eic._codProd
        Me.cmbIdInv.Text = eic._idInvCompr
        Me.txtNombrProd.Text = ep._nombreProd
        Me.txtPrecioProd.Text = eic._precio
        Me.txtCantProd.Text = eic._cantidad
        Me.txtCodFact.Text = efc._codFactCompr
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