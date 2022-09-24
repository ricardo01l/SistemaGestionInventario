Public Class FfacturaVenta
    Inherits Fgeneral

    Public Sub agregar(ByVal codFact As String, ByVal fechaFact As String, ByVal estatus As Boolean)
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "INSERT INTO TFacturaVenta (CodFactVent, FechaFact, EstatusFact)"
        sql += "VALUES ('" & codFact & "','" & fechaFact & "'," & estatus.ToString & ");"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub
    Public Sub modificar(ByVal codFact As String, ByVal fechaFact As String, ByVal estatus As Boolean)
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        ' MODIFICA LA TABLA FACTURA VENTA
        sql = "UPDATE TFacturaVenta "
        sql += "SET FechaFact='" & fechaFact & "', "
        sql += "EstatusFact=" & estatus.ToString & " "
        sql += "WHERE CodFactVent='" & codFact & "'"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub eliminar(ByVal codFactVent As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(codFactVent, "CodFactVent", "TFacturaVenta"))

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TFacturaVenta WHERE CodFactVent='" & codFactVent & "'"
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
