Imports entidad
Imports datos

Public Class baseDatos

    Dim fg As New Fgeneral
    Public dt As New DataTable
    Dim i As Integer

    Dim yaExiste As Boolean = False
    Public tablas() As String = {"TUsuario", "TProducto", "TInventarioCompra", "TFacturaCompra", "TInventarioVenta", "TFacturaVenta", "TInventarioGeneral"}


    ' CUANDO CARGUE LA FORMA
    Private Sub baseDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbUsuario, "NombrUsuario", "TUsuario")
        llenarCmb(Me.cmbFactCompr, "CodFactCompr", "TFacturaCompra")
        llenarCmb(Me.cmbInvVent, "IdInvVent", "TInventarioVenta")
        llenarCmb(Me.cmbFactVent, "CodFactVent", "TFacturaVenta")
        llenarCmb(Me.cmbInvGen, "IdInv", "TInventarioGeneral")
        llenarCmb(Me.cmbProducto, "CodProd", "TProducto")
        llenarCmb(Me.cmbInvCompr, "IdInvCompr", "TInventarioCompra")

        setDgv(tablas(0), Me.dgvUsuario)
        setDgv(tablas(1), Me.dgvProducto)
        setDgv(tablas(2), Me.dgvInvCompr)
        setDgv(tablas(3), Me.dgvFactCompr)
        setDgv(tablas(4), Me.dgvInvVent)
        setDgv(tablas(5), Me.dgvFactVent)
        setDgv(tablas(6), Me.dgvInvGen)

        Me.dgvUsuario.Columns.Remove("Clave")
        Me.pgb.Minimum = 0
    End Sub
    'CUANDO SE CIERRA LA FORMA

    ' CUANDO SE CLIQUEAN LOS BOTONES
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
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
    Private Sub ActualizarInventarioDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeComprasToolStripMenuItem.Click
        inventarioCompra.Show()
        Me.Close()
    End Sub
    Private Sub ActualizarInventarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeVentasToolStripMenuItem.Click
        inventarioVenta.Show()
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

        llenarCmb(Me.cmbUsuario, "NombrUsuario", "TUsuario")
        llenarCmb(Me.cmbFactCompr, "CodFactCompr", "TFacturaCompra")
        llenarCmb(Me.cmbInvVent, "IdInvVent", "TInventarioVenta")
        llenarCmb(Me.cmbFactVent, "CodFactVent", "TFacturaVenta")
        llenarCmb(Me.cmbInvGen, "IdInv", "TInventarioGeneral")
        llenarCmb(Me.cmbProducto, "CodProd", "TProducto")
        llenarCmb(Me.cmbInvCompr, "IdInvCompr", "TInventarioCompra")

        setDgv(tablas(0), Me.dgvUsuario)
        setDgv(tablas(1), Me.dgvProducto)
        setDgv(tablas(2), Me.dgvInvCompr)
        setDgv(tablas(3), Me.dgvFactCompr)
        setDgv(tablas(4), Me.dgvInvVent)
        setDgv(tablas(5), Me.dgvFactVent)
        setDgv(tablas(6), Me.dgvInvGen)

        Me.dgvUsuario.Columns.Remove("Clave")
    End Sub

    ' USUARIO
    Private Sub btnEnviarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarUsuario.Click
        dt = CType(Me.dgvUsuario.DataSource, DataTable)
        If dt.Rows.Count > 0 Then
            Dim eu As New Eusuario
            Dim fu As New Fusuario
            Me.pgb.Visible = True
            Me.pgb.Maximum = dt.Rows.Count
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                eu._users = dt(i)("NombrUsuario").ToString
                eu._nombre = dt(i)("Nombre").ToString
                eu._apellido = dt(i)("Apellido").ToString
                eu._cedula = dt(i)("Cedula").ToString
                eu._estatus = dt(i)("EstatusUsuario").ToString
                eu._nivel = dt(i)("TipoUsuario").ToString
                eu._telefono = dt(i)("TelfUsuario").ToString
                yaExiste = CBool(fg.existe(eu._users, "NombrUsuario", "TUsuario"))
                If yaExiste Then
                    Try
                        fu.modificar(eu._users, eu._cedula, eu._passwords, eu._nombre, eu._apellido, eu._telefono, eu._estatus, eu._nivel, False)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        eu._passwords = "admin"
                        fu.agregar(eu._users, eu._cedula, eu._passwords, eu._nombre, eu._apellido, eu._telefono, eu._estatus, eu._nivel)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            Me.statusLabel.Text = "Los ususarios se ha modificado correctamente."
            setDgv("TUsuario", Me.dgvUsuario)
            Me.dgvUsuario.Columns.Remove("Clave")
            llenarCmb(Me.cmbUsuario, "NombrUsuario", "TUsuario")

            Me.pgb.Visible = False
            eu = Nothing
            fu = Nothing
        End If
    End Sub
    Private Sub EliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarUsuario.Click
        Dim eliminar As Integer

        eliminar = MsgBox("¿Está seguro que desea eliminar este usuario?", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbUsuario.SelectedItem.ToString <> "" Then
                Dim eu As New Eusuario
                Dim fu As New Fusuario
                eu._users = Me.cmbUsuario.SelectedItem.ToString

                Try
                    fu.eliminar(eu._users)
                    Me.statusLabel.Text = "El usuario con el nombre de usuario " & eu._users & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                llenarCmb(Me.cmbUsuario, "NombrUsuario", "TUsuario")
                setDgv("TUsuario", Me.dgvUsuario)
                Me.dgvUsuario.Columns.Remove("Clave")
                eu = Nothing
                fu = Nothing
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub

    ' PRODUCTO
    Private Sub btnEnviarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarProducto.Click
        dt = CType(Me.dgvProducto.DataSource, DataTable)

        If dt.Rows.Count > 0 Then
            Dim ep As New Eproducto
            Dim fp As New Fproducto
            Dim i As Integer
            Me.pgb.Visible = True
            Me.pgb.Maximum = dt.Rows.Count
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                ep._codProd = dt(i)("CodProd").ToString
                ep._nombreProd = dt(i)("NombreProd").ToString
                ep._descProd = dt(i)("DescripProd").ToString
                yaExiste = CBool(fg.existe(ep._codProd, "CodProd", "TProducto"))
                If yaExiste Then
                    Try
                        fp.modificar(ep._codProd, ep._nombreProd, ep._descProd)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        fp.agregar(ep._codProd, ep._nombreProd, ep._descProd)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            llenarCmb(Me.cmbProducto, "CodProd", "TProducto")
            setDgv("TProducto", Me.dgvProducto)
            Me.statusLabel.Text = "Los productos se han modificado correctamente."

            Me.pgb.Visible = False
            ep = Nothing
            fp = Nothing
        End If
    End Sub
    Private Sub btnEliminarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este producto?", MsgBoxStyle.OkCancel, "Eliminar producto")

        If eliminar = 1 Then
            If Me.cmbProducto.Text.ToString <> "" Then
                Dim ep As New Eproducto
                Dim fp As New Fproducto
                ep._codProd = Me.cmbProducto.Text

                Try
                    fp.eliminar(ep._codProd.ToString)
                    Me.statusLabel.Text = "El producto se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                setDgv("TProducto", Me.dgvProducto)
                llenarCmb(Me.cmbProducto, "CodProd", "TProducto")
                ep = Nothing
                fp = Nothing
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub

    ' INVENTARIO DE COMPRA
    Private Sub btnEnviarInvCompr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarInvCompr.Click
        dt = CType(Me.dgvInvCompr.DataSource, DataTable)

        If dt.Rows.Count > 0 Then
            Dim eic As New EinventarioCompra
            Dim fic As New FinventarioCompra
            Dim i As Integer
            Me.pgb.Visible = True
            Me.pgb.Maximum = dt.Rows.Count
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                eic._idInvCompr = dt(i)("IdInvCompr").ToString
                eic._codProd = dt(i)("CodProd").ToString
                eic._precio = dt(i)("PrecioCompr").ToString
                eic._cantidad = dt(i)("CantidadCompr").ToString
                eic._codFactCompr = dt(i)("CodFactCompr").ToString
                yaExiste = CBool(fg.existe(eic._idInvCompr, "IdInvCompr", "TInventarioCompra", True))
                If yaExiste Then
                    Try
                        fic.modificar(eic._idInvCompr, eic._codProd, eic._precio, eic._cantidad, eic._codFactCompr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        fic.agregar(eic._codProd, eic._precio, eic._cantidad, eic._codFactCompr, "")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            llenarCmb(Me.cmbInvCompr, "IdInvCompr", "TInventarioCompra")
            Me.statusLabel.Text = "Los registros del inventario de compras se ha modificado correctamente."
            setDgv("TInventarioCompra", Me.dgvInvCompr)

            Me.pgb.Visible = False
            eic = Nothing
            fic = Nothing
        End If
    End Sub
    Private Sub btnEliminarInvCompr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarInvCompr.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario?", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbInvCompr.SelectedItem.ToString <> "" Then
                Dim eic As New EinventarioCompra
                Dim fic As New FinventarioCompra
                eic._idInvCompr = Me.cmbInvCompr.SelectedItem.ToString

                Try
                    fic.eliminar(eic._idInvCompr.ToString)
                    Me.statusLabel.Text = "El registro con la id " & eic._idInvCompr & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                llenarCmb(Me.cmbInvCompr, "IdInvCompr", "TInventarioCompra")
                setDgv("TInventarioCompra", Me.dgvInvCompr)
                eic = Nothing
                fic = Nothing
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub

    ' FACTURA DE COMPRA
    Private Sub btnEnviarFactCompr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarFactCompr.Click
        dt = CType(Me.dgvFactCompr.DataSource, DataTable)
        Me.pgb.Visible = True
        Me.pgb.Maximum = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            Dim efc As New EfacturaCompra
            Dim ffc As New FfacturaCompra
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                efc._codFactCompr = dt(i)("CodFactCompr").ToString

                If IsDBNull(dt(i)("FechaFact")) Then
                    efc._fechaFact = Date.Today
                Else
                    efc._fechaFact = CDate(CDate(dt(i)("FechaFact")).ToShortDateString())
                End If

                If IsDBNull(dt(i)("EstatusFact")) Then
                    efc._estatus = False
                Else
                    efc._estatus = CBool(dt(i)("EstatusFact"))
                End If
                yaExiste = CBool(fg.existe(efc._codFactCompr, "CodFactCompr", "TFacturaCompra"))
                If yaExiste Then
                    Try
                        ffc.modificar(efc._codFactCompr, efc._fechaFact.ToString, efc._estatus)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        ffc.agregar(efc._codFactCompr, efc._fechaFact.ToString, efc._estatus)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            llenarCmb(Me.cmbFactCompr, "CodFactCompr", "TFacturaCompra")
            setDgv("TFacturaCompra", Me.dgvFactCompr)
            Me.statusLabel.Text = "Las facturas se han modificado correctamente."
            Me.pgb.Visible = False
            efc = Nothing
            ffc = Nothing
        End If
    End Sub
    Private Sub btnEliminarFactCompr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarFactCompr.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario? El balance de los ", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbFactCompr.SelectedItem.ToString <> "" Then
                Dim efc As New EfacturaCompra
                Dim ffc As New FfacturaCompra
                efc._codFactCompr = Me.cmbFactCompr.SelectedItem.ToString

                Try
                    ffc.eliminar(efc._codFactCompr.ToString)
                    Me.statusLabel.Text = "El registro con la id " & efc._codFactCompr.ToString & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbFactCompr, "CodFactCompr", "TFacturaCompra")
                setDgv("TFacturaCompra", Me.dgvFactCompr)
                efc = Nothing
                ffc = Nothing
            Else
                MsgBox("Es necesario elegir un id del registro para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub

    ' INTARIO DE VENTA
    Private Sub btnEnviarInvVent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarInvVent.Click
        dt = CType(Me.dgvInvVent.DataSource, DataTable)
        Me.pgb.Visible = True
        Me.pgb.Maximum = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            Dim eiv As New EinventarioVenta
            Dim fiv As New FinventarioVenta
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                eiv._idInvVent = dt(i)("IdInvVent").ToString
                eiv._codProd = dt(i)("CodProd").ToString
                eiv._precio = dt(i)("PrecioVent").ToString
                eiv._cantidad = dt(i)("CantidadVent").ToString
                eiv._codFactVent = dt(i)("CodFactVent").ToString
                yaExiste = CBool(fg.existe(eiv._idInvVent, "IdInvVent", "TInventarioVenta", True))
                If yaExiste Then
                    Try
                        fiv.modificar(eiv._idInvVent, eiv._codProd, eiv._precio, eiv._cantidad, eiv._codFactVent)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        fiv.agregar(eiv._codProd, eiv._precio, eiv._cantidad, eiv._codFactVent)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            llenarCmb(Me.cmbInvVent, "IdInvVent", "TinventarioVenta")
            setDgv("TInventarioVenta", Me.dgvInvVent)
            Me.statusLabel.Text = "Los registros del inventario se han modificado correctamente."
            Me.pgb.Visible = False

            eiv = Nothing
            fiv = Nothing
        End If
    End Sub
    Private Sub btnEliminarInvVent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarInvVent.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario?", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbInvVent.SelectedItem.ToString <> "" Then
                Dim eiv As New EinventarioVenta
                Dim fiv As New FinventarioVenta
                eiv._idInvVent = Me.cmbInvVent.SelectedItem.ToString

                Try
                    fiv.eliminar(eiv._idInvVent)
                    Me.statusLabel.Text = "El registro con la id " & eiv._idInvVent & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbInvVent, "IdInvVent", "TinventarioVenta")
                setDgv("TInventarioVenta", Me.dgvInvVent)
                eiv = Nothing
                fiv = Nothing
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub

    ' FACTURA DE VENTA
    Private Sub btnEnviarFactVent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarFactVent.Click
        dt = CType(Me.dgvFactVent.DataSource, DataTable)
        Me.pgb.Visible = True
        Me.pgb.Maximum = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            Dim efv As New EfacturaVent
            Dim ffv As New FfacturaVenta
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                efv._codFactVent = dt(i)("CodFactVent").ToString
                If IsDBNull(dt(i)("FechaFact")) Then
                    efv._fechaFact = Date.Today
                Else
                    efv._fechaFact = CDate(CDate(dt(i)("FechaFact")).ToShortDateString())
                End If

                If IsDBNull(dt(i)("EstatusFact")) Then
                    efv._estatus = False
                Else
                    efv._estatus = CBool(dt(i)("EstatusFact"))
                End If
                yaExiste = CBool(fg.existe(efv._codFactVent, "CodFactVent", "TFacturaVenta"))
                If yaExiste Then
                    Try
                        ffv.modificar(efv._codFactVent, efv._fechaFact.ToString, efv._estatus)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        ffv.agregar(efv._codFactVent, efv._fechaFact.ToString, efv._estatus)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            llenarCmb(Me.cmbFactVent, "CodFactVent", "TFacturaVenta")
            setDgv("TFacturaVenta", Me.dgvFactVent)
            Me.statusLabel.Text = "Las facturas se han modificado correctamente."
            Me.pgb.Visible = False
            efv = Nothing
            ffv = Nothing
        End If
    End Sub
    Private Sub btnEliminarFactVent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarFactVent.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario? El balance de los ", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbFactVent.SelectedItem.ToString <> "" Then
                Dim efv As New EfacturaVent
                Dim ffv As New FfacturaVenta
                efv._codFactVent = Me.cmbFactVent.SelectedItem.ToString

                Try
                    ffv.eliminar(efv._codFactVent.ToString)
                    Me.statusLabel.Text = "El registro con la id " & efv._codFactVent.ToString & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbFactVent, "CodFactVent", "TFacturaVenta")
                setDgv("TFacturaVenta", Me.dgvFactVent)
                efv = Nothing
                ffv = Nothing
            Else
                MsgBox("Es necesario elegir un id del registro para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub

    ' INVENTARIO GENERAL
    Private Sub btnEnviarInvGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarInvGen.Click
        dt = CType(Me.dgvInvGen.DataSource, DataTable)
        Me.pgb.Visible = True
        Me.pgb.Maximum = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            Dim eig As New EinventarioGeneral
            Dim fig As New FinventarioGeneral
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                Me.pgb.Value = i
                eig._idInv = dt(i)("IdInv").ToString
                eig._codProd = dt(i)("CodProd").ToString
                eig._balance = dt(i)("BalanceProd").ToString
                yaExiste = CBool(fg.existe(eig._idInv, "IdInv", "TInventarioGeneral", True))
                If yaExiste Then
                    Try
                        fig.modificar(eig._idInv, eig._codProd, eig._balance)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        fig.agregar(eig._idInv, eig._codProd, eig._balance)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Next
            llenarCmb(Me.cmbInvGen, "IdInv", "TInventarioGeneral")
            setDgv("TInventarioGeneral", Me.dgvInvGen)
            Me.statusLabel.Text = "Los registros del inventario se han modificado correctamente."
            Me.pgb.Visible = False

            eig = Nothing
            fig = Nothing
        End If
    End Sub
    Private Sub btnEliminarInvGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarInvGen.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este registro del inventario? El balance de los ", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbInvGen.SelectedItem.ToString <> "" Then
                Dim eig As New EinventarioGeneral
                Dim fig As New FinventarioGeneral
                eig._idInv = Me.cmbInvGen.SelectedItem.ToString

                Try
                    fig.eliminar(eig._idInv.ToString)
                    Me.statusLabel.Text = "El registro con la id " & eig._idInv.ToString & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbInvGen, "IdInv", "TInventarioGeneral")
                setDgv("TInventarioGeneral", Me.dgvInvGen)
                eig = Nothing
                fig = Nothing
            Else
                MsgBox("Es necesario elegir un id del registro para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub


End Class