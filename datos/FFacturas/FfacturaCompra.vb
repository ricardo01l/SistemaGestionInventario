Public Class FfacturaCompra

    Inherits Fgeneral

    Public Sub agregar(ByVal codFact As String, ByVal fechaFact As String, ByVal estatus As Boolean)
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text


        sql = "INSERT INTO TFacturaCompra (CodFactCompr, FechaFact, EstatusFact)"
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
        ' MODIFICA LA TABLA FACTURA COMPRA
        sql = "UPDATE TFacturaCompra "
        sql += "SET FechaFact='" & fechaFact & "', "
        sql += " EstatusFact=" & estatus.ToString & " "
        sql += "WHERE CodFactCompr='" & codFact & "'"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
    End Sub

    Public Sub eliminar(ByVal codFactCompr As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(codFactCompr, "CodFactCompr", "TFacturaCompra"))

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TFacturaCompra WHERE CodFactCompr='" & codFactCompr & "'"
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
