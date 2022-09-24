Imports entidad
Imports datos


Public Class login

    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Dim fpdf As New Fpdf

    ' -------------------- EVENTOS -------------------------------
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    ' CUANDO SE CLIQUEAN LOS BOTONES
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            If ((Me.txtUser.Text <> "") And (Me.txtPassword.Text <> "")) Then

                Static intento As Integer = 0
                Dim dt As New DataTable


                eu._users = Me.txtUser.Text
                eu._passwords = Me.txtPassword.Text
                dt = fu.validarUsuario(eu)

                If dt.Rows.Count > 0 Then
                    If dt(0)("EstatusUsuario").ToString = "Activo" Then
                        If fu.comprobarClave(dt(0)("Clave").ToString, eu._passwords) Then
                            Timer1.Start()
                            Dim nivel As String

                            nivel = dt.Rows(0)("TipoUsuario").ToString

                            If nivel = "Usuario" Then
                                producto.UsuariosToolStripMenuItem.Visible = False
                                usuario.UsuariosToolStripMenuItem.Visible = False
                                baseDatos.UsuariosToolStripMenuItem.Visible = False
                                inventarioCompra.UsuariosToolStripMenuItem.Visible = False
                                inventarioGeneral.UsuariosToolStripMenuItem.Visible = False
                                inventarioVenta.UsuariosToolStripMenuItem.Visible = False
                                InformeInvCompr.UsuariosToolStripMenuItem.Visible = False
                                InformeInvVent.UsuariosToolStripMenuItem.Visible = False

                                producto.BaseDeDatosToolStripMenuItem.Visible = False
                                usuario.BaseDeDatosToolStripMenuItem.Visible = False
                                baseDatos.BaseDeDatosToolStripMenuItem.Visible = False
                                inventarioCompra.BaseDeDatosToolStripMenuItem.Visible = False
                                inventarioGeneral.BaseDeDatosToolStripMenuItem.Visible = False
                                inventarioVenta.BaseDeDatosToolStripMenuItem.Visible = False
                                InformeInvCompr.BaseDeDatosToolStripMenuItem.Visible = False
                                InformeInvVent.BaseDeDatosToolStripMenuItem.Visible = False
                            ElseIf nivel = "Administrador" Then
                                producto.UsuariosToolStripMenuItem.Visible = True
                                usuario.UsuariosToolStripMenuItem.Visible = True
                                baseDatos.UsuariosToolStripMenuItem.Visible = True
                                inventarioCompra.UsuariosToolStripMenuItem.Visible = True
                                inventarioGeneral.UsuariosToolStripMenuItem.Visible = True
                                inventarioVenta.UsuariosToolStripMenuItem.Visible = True
                                InformeInvCompr.UsuariosToolStripMenuItem.Visible = True
                                InformeInvVent.UsuariosToolStripMenuItem.Visible = True

                                producto.BaseDeDatosToolStripMenuItem.Visible = True
                                usuario.BaseDeDatosToolStripMenuItem.Visible = True
                                baseDatos.BaseDeDatosToolStripMenuItem.Visible = True
                                inventarioCompra.BaseDeDatosToolStripMenuItem.Visible = True
                                inventarioGeneral.BaseDeDatosToolStripMenuItem.Visible = True
                                inventarioVenta.BaseDeDatosToolStripMenuItem.Visible = True
                                InformeInvCompr.BaseDeDatosToolStripMenuItem.Visible = True
                                InformeInvVent.BaseDeDatosToolStripMenuItem.Visible = True
                            End If
                        Else
                            intento += 1

                            If intento = 4 Then
                                MsgBox("El sistema se apagará, gracias.", MsgBoxStyle.Critical, "SISTEMA")
                                'Para apagar la pc

                                Me.Close()
                            Else
                                MsgBox("Usuario o Contraseña erroneos. Le quedan " & 4 - intento & " intento(s).", MsgBoxStyle.Information, "Cuidado")
                            End If
                        End If
                    Else
                        MsgBox("El usuario está suspendido. Inicie sesión con otro o pida ayuda a un administrador", MsgBoxStyle.Information, "Usuario suspendido")
                    End If
                    fu.desconectar()
                Else
                    intento += 1

                    If intento = 4 Then
                        MsgBox("El sistema se apagará, gracias.", MsgBoxStyle.Critical, "SISTEMA")
                        'Para apagar la pc

                        Process.Start("shutdown.exe", "-s -t 00")
                    Else
                        MsgBox("Usuario o Contraseña erroneos. Le quedan " & 4 - intento & " intento(s).", MsgBoxStyle.Information, "Cuidado")
                    End If
                End If
            Else
                MsgBox("Ingrese los datos requeridos en los campos.", MsgBoxStyle.Information, "No se pueden enviar datos vacíos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ' CUANDO COMIENZA A CONTAR EL TIMER DEL PROGRESSBAR
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.pgbar.Increment(40)

        If Me.pgbar.Value = 100 Then
            Timer1.Enabled = False
            producto.Show()
            Me.Close()
        End If
    End Sub
End Class
