Imports entidad
Imports datos

Public Class usuario

    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Public dt As New DataTable
    Dim mostrar As Boolean = True

    ' -------------------- EVENTOS -------------------------------
    ' CUANDO CARGUE LA FORMA
    Private Sub usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbUsername, "NombrUsuario", "TUsuario")
        llenarCmbTipoUsuario(Me.cmbTipoUser)
    End Sub

    ' CUANDO CAMBIA EL COMBOBOX USERNAME
    Private Sub cmbUsername_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUsername.SelectedValueChanged
        If Me.cmbUsername.SelectedItem.ToString <> "" Then
            dt = fu.consultarRegistro("NombrUsuario", Me.cmbUsername.SelectedItem.ToString, "TUsuario", True)

            If dt.Rows.Count > 0 Then

                eu._users = dt(0)("NombrUsuario").ToString
                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._cedula = dt(0)("Cedula").ToString
                eu._estatus = dt(0)("EstatusUsuario").ToString
                eu._nivel = dt(0)("TipoUsuario").ToString
                eu._telefono = dt(0)("TelfUsuario").ToString

                Me.txtUsername.Text = eu._users
                Me.txtNombreUser.Text = eu._nombre
                Me.txtApellidoUser.Text = eu._apellido
                Me.txtCedula.Text = eu._cedula
                Me.cmbTipoUser.SelectedItem = eu._nivel
                Me.txtTelefono.Text = eu._telefono

                If eu._estatus = "Activo" Then
                    Me.rbActivo.Checked = True
                    Me.rbDeshabilitado.Checked = False
                Else
                    Me.rbActivo.Checked = False
                    Me.rbDeshabilitado.Checked = True
                End If

                eliminarVacioCmb(Me.cmbUsername)
                enableControles(True)
            Else
                enableControles(False)
                MsgBox("No se encontró el registro en la base de datos", MsgBoxStyle.Exclamation, "Ingrese otro identificador")
            End If
            fu.desconectar()
        End If
    End Sub

    ' CUANDO SE PRECIONEN LAS TECLAS EN LOS CAMPOS LIMITADOS
    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        soloNumerosYletras(e)
    End Sub
    Private Sub txtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub txtNombreUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreUser.KeyPress
        soloLetrasYEspacios(e)
    End Sub
    Private Sub txtApellidoUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoUser.KeyPress
        soloLetrasYEspacios(e)
    End Sub
    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        soloNumerosletrasYCaracteres(e)
    End Sub
    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        soloNumeros(e)
    End Sub

    ' CUANDO SE DEJA EL CAMPO USERNAME
    Private Sub txtUsername_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        If Me.txtUsername.Text.ToString <> "" Then
            dt = fu.consultarRegistro("CodProd", Me.txtUsername.Text.ToString, "TProducto", True)


            If dt.Rows.Count > 0 Then

                eu._users = dt(0)("NombrUsuario").ToString
                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._cedula = dt(0)("Cedula").ToString
                eu._estatus = dt(0)("EstatusUsuario").ToString
                eu._nivel = dt(0)("TipoUsuario").ToString
                eu._telefono = dt(0)("TelfUsuario").ToString

                Me.txtUsername.Text = eu._users
                Me.txtNombreUser.Text = eu._nombre
                Me.txtApellidoUser.Text = eu._apellido
                Me.txtCedula.Text = eu._cedula
                Me.cmbTipoUser.SelectedItem = eu._nivel
                Me.txtTelefono.Text = eu._telefono


                If eu._estatus = "Activo" Then
                    Me.rbActivo.Checked = True
                Else
                    Me.rbActivo.Checked = False
                End If

                eliminarVacioCmb(Me.cmbUsername)
                enableControles(True)
            Else
                limpiarControles(False)
                enableControles(False)
            End If

        Else
            enableControles(False)
        End If
    End Sub

    ' CUANDO SE CLIQUEAN LOS BOTONES
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarControles()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If ((Me.txtUsername.Text <> "") And (Me.txtPass.Text <> "") And (Me.txtCedula.Text <> "")) Then
            If (Me.txtUsername.TextLength >= 6) Then
                If (Me.txtPass.TextLength >= 10) Then
                    eu._users = Me.txtUsername.Text
                    eu._nombre = Me.txtNombreUser.Text
                    eu._apellido = Me.txtApellidoUser.Text
                    eu._cedula = Me.txtCedula.Text
                    eu._estatus = Me.txtCedula.Text
                    eu._nivel = Me.cmbTipoUser.Text
                    eu._telefono = Me.txtCedula.Text
                    eu._passwords = Me.txtPass.Text

                    If Me.rbActivo.Checked Then
                        eu._estatus = "True"
                    Else
                        eu._estatus = "False"
                    End If

                    Try
                        fu.agregar(eu._users, eu._cedula, eu._passwords, eu._nombre, eu._apellido, eu._telefono, eu._estatus, eu._nivel)

                        llenarCmb(Me.cmbUsername, "NombrUsuario", "TUsuario")
                        llenarCmbTipoUsuario(Me.cmbTipoUser)
                        limpiarControles()
                        Me.statusLabel.Text = "El registro se ha agregado correctamente."
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("La contraseña no puede ser menor a 10 caracteres", MsgBoxStyle.Information, "Error")
                End If

            Else
                MsgBox("El Nombre de usuario no puede ser menor a 6 caracteres", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un registro al inventario", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.txtNombreUser.Text.ToString <> "" And Me.txtPass.Text.ToString <> "" And Me.txtCedula.Text <> "" Then
            If (Me.txtUsername.TextLength >= 6) Then
                If (Me.txtPass.TextLength >= 10) Then
                    eu._users = Me.txtUsername.Text
                    eu._nombre = Me.txtNombreUser.Text
                    eu._apellido = Me.txtApellidoUser.Text
                    eu._cedula = Me.txtCedula.Text
                    eu._estatus = Me.txtCedula.Text
                    eu._nivel = Me.cmbTipoUser.Text
                    eu._telefono = Me.txtCedula.Text
                    eu._passwords = Me.txtPass.Text

                    If Me.rbActivo.Checked Then
                        eu._estatus = "True"
                    Else
                        eu._estatus = "False"
                    End If
                    Try
                        Me.statusLabel.Text = "El usuario " & eu._users & " se ha modificado correctamente."
                        fu.modificar(eu._users, eu._cedula, eu._passwords, eu._nombre, eu._apellido, eu._telefono, eu._estatus, eu._nivel, True)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("La contraseña no puede ser menor a 10 caracteres", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El Nombre de usuario no puede ser menor a 6 caracteres", MsgBoxStyle.Information, "Error")
            End If


        Else
            MsgBox("Es necesario elegir un nombre de usuario, contraseña y cédula para modificar sus datos", MsgBoxStyle.Information, "No eligió el código o nombre del producto")
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este usuario?", MsgBoxStyle.OkCancel, "Eliminar registro")

        If eliminar = 1 Then
            If Me.cmbUsername.SelectedItem.ToString <> "" Then
                eu._users = Me.cmbUsername.SelectedItem.ToString

                Try
                    fu.eliminar(eu._users)
                    Me.statusLabel.Text = "El usuario con el nombre de usuario " & eu._users & " se ha eliminado correctamente."

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                llenarCmb(Me.cmbUsername, "NombrUsuario", "TUsuario")
                limpiarControles()
            Else
                MsgBox("Es necesario elegir un código del producto para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del producto")
            End If
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        consultaUsuario.Show()

        dt = fu.consultar("TUsuario")
        consultaUsuario.dgvUsuario.DataSource = dt
        consultaUsuario.dgvUsuario.Columns.Remove("Clave")

        Me.Close()
    End Sub
    Private Sub btnMostrarPass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMostrarPass.Click
        Me.txtPass.UseSystemPasswordChar = mostrar
        mostrar = Not mostrar
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
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub
    ' ---------------------------------------------------------------------------------


    ' --------------------- FUNCIONES GENÉRICAS-----------------------------------------------
    ' LIMPIA LOS CONTROLES
    Private Sub limpiarControles(Optional ByVal limpiarNombrUsuario As Boolean = True)
        If limpiarNombrUsuario Then
            eu._users = ""
            Me.txtUsername.Text = eu._users
        End If

        eu._nombre = ""
        eu._apellido = ""
        eu._cedula = ""
        eu._nivel = ""
        eu._passwords = ""
        eu._telefono = ""

        Me.txtNombreUser.Text = eu._nombre
        Me.txtPass.Text = eu._passwords
        Me.txtApellidoUser.Text = eu._apellido
        Me.txtCedula.Text = eu._cedula
        Me.txtTelefono.Text = eu._telefono
        Me.rbActivo.Checked = False
        Me.rbDeshabilitado.Checked = False

        enableControles(False)
    End Sub
    ' ACTIVA Y DESACTIVA LOS CONTROLES
    Private Sub enableControles(ByVal valor As Boolean)
        Me.btnModificar.Enabled = valor
        Me.btnEliminar.Enabled = valor
        If Not valor Then
            ' REINICIAR COMBO USERNAME 
            If Me.cmbUsername.Items.Contains("") Then
                Me.cmbUsername.SelectedItem = ""
            Else
                Me.cmbUsername.Items.Add("")
                Me.cmbUsername.SelectedItem = ""
            End If

            ' REINICIAR COMBO TIPOUSER 
            If Me.cmbTipoUser.Items.Contains("") Then
                Me.cmbTipoUser.SelectedItem = ""
            Else
                Me.cmbTipoUser.Items.Add("")
                Me.cmbTipoUser.SelectedItem = ""
            End If
        End If
    End Sub

    ' LLENAR CMB TIPOUSUARIO
    Private Sub llenarCmbTipoUsuario(ByVal cmb As System.Windows.Forms.ComboBox)
        cmb.Items.Clear()

        cmb.Items.Add("Usuario")
        cmb.Items.Add("Administrador")
    End Sub
    ' ---------------------------------------------------------------------------------


    Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        Process.Start("Manual de Usuario.pdf")
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
End Class