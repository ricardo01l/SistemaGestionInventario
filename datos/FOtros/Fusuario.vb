Imports entidad
Imports System.Security.Cryptography


Imports System.Text
Public Class Fusuario

    Inherits Fgeneral


    Private Function generarClaveSHA1(ByVal nombre As String) As String
        ' Crear una clave SHA1 como la generada por
        ' FormsAuthentication.HashPasswordForStoringInConfigFile
        ' Adaptada del ejemplo de la ayuda en la descripción de SHA1 (Clase)
        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(nombre)
        Dim result() As Byte

        Dim sha As New SHA1CryptoServiceProvider
        ' This is one implementation of the abstract class SHA1.
        result = sha.ComputeHash(data)
        '
        ' Convertir los valores en hexadecimal
        ' cuando tiene una cifra hay que rellenarlo con cero
        ' para que siempre ocupen dos dígitos.
        Dim sb As New StringBuilder
        For i As Integer = 0 To result.Length - 1
            If result(i) < 16 Then
                sb.Append("0")
            End If
            sb.Append(result(i).ToString("x"))
        Next
        '
        Return sb.ToString.ToUpper
    End Function

    Public Function validarUsuario(ByVal dts As Eusuario) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM TUsuario WHERE NombrUsuario='" & dts._users & "';"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function comprobarClave(ByVal EncriptClave As String, ByVal txtClave As String) As Boolean
        Dim deCriptClave As String
        deCriptClave = generarClaveSHA1(txtClave)
        Return deCriptClave = EncriptClave
    End Function
    Public Sub incluir()

    End Sub

    Public Sub agregar(ByVal username As String, ByVal cedula As String, ByVal clave As String, ByVal nombre As String, ByVal apellido As String, ByVal telf As String, ByVal estatus As String, ByVal tipo As String)
        Dim yaExiste As New Boolean


        yaExiste = CBool(existe(username, "NombrUsuario", "TUsuario"))
        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If estatus = "True" Or estatus = "Activo" Then
                estatus = "Activo"
            ElseIf estatus = "False" Or estatus = "Deshabilitado" Then
                estatus = "Deshabilitado"
            End If
            Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO TUsuario (NombrUsuario, Cedula, Clave, Nombre, Apellido, TelfUsuario, EstatusUsuario, TipoUsuario)"
            sql += "VALUES ('" & username & "','" & cedula & "','" & Eclave & "','" & nombre & "','" & apellido & "','" & telf & "','" & estatus & "','" & tipo & "');"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
        Else
            MsgBox("El nombre de usuario ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
    Public Sub modificar(ByVal username As String, ByVal cedula As String, ByVal clave As String, ByVal nombre As String, ByVal apellido As String, ByVal telf As String, ByVal estatus As String, ByVal tipo As String, ByVal modificarClave As Boolean)
        conectar()

        ' MODIFICA LA TABLA INVENTARIO COMPRA
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If estatus = "True" Or estatus = "Activo" Then
            estatus = "Activo"
        ElseIf estatus = "False" Or estatus = "Deshabilitado" Then
            estatus = "Deshabilitado"
        End If
        sql = "UPDATE TUsuario "
        sql += "SET Cedula='" & cedula & "', "
        sql += "Nombre='" & nombre & "', "
        sql += "Apellido='" & apellido & "', "
        If modificarClave Then
            Dim Eclave As String = generarClaveSHA1(clave)
            sql += "Clave='" & Eclave & "', "
        End If
        sql += "TelfUsuario='" & telf & "', "
        sql += "EstatusUsuario='" & estatus & "', "
        sql += "TipoUsuario='" & tipo & "' "
        sql += "WHERE NombrUsuario='" & username & "';"
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        desconectar()
        ' ------------------------------------------------------------------
    End Sub
    Public Sub eliminar(ByVal username As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(username, "NombrUsuario", "TUsuario"))



        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TUsuario WHERE NombrUsuario='" & username & "';"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("El registro con el id ingresado no existe")
        End If
        desconectar()

    End Sub
End Class
