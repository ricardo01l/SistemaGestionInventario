Public Class Fproducto

    Inherits Fgeneral


    Public Sub agregar(ByVal codProd As String, ByVal nombreProd As String, ByVal descProd As String)
        Dim yaExiste As New Boolean


        yaExiste = CBool(existe(codProd, "CodProd", "TProducto"))

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sql = "INSERT INTO TProducto (CodProd, NombreProd, DescripProd)"
            sql += "VALUES ('" & codProd & "','" & nombreProd & "','" & descProd & "');"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("El código del producto ya está en la base de datos.", MsgBoxStyle.Critical, "Código repetido")
        End If
        desconectar()
    End Sub

    Public Sub modificar(ByVal codProd As String, ByVal nombreProd As String, ByVal descProd As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(codProd, "CodProd", "TProducto"))

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE TProducto "
            sql += "SET NombreProd='" & nombreProd & "', "
            sql += "DescripProd='" & descProd & "' "
            sql += "WHERE CodProd='" & codProd & "'"

            cmd.CommandText = sql


            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("El producto con el código ingresado no existe")
        End If
        desconectar()
    End Sub

    Public Sub eliminar(ByVal codProd As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(codProd, "CodProd", "TProducto"))

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TProducto WHERE CodProd='" & codProd & "'"
            cmd.CommandText = sql


            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("El producto con el código ingresado no existe")
        End If
        desconectar()

    End Sub
End Class
