Public Class FinventarioGeneral
    Inherits Fgeneral


    Public Sub agregar(ByVal idInv As String, ByVal codProd As String, ByVal balance As String)
        conectar()

        ' AGREGA REGISTRO LA TABLA INVENTARIO GENERAL
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "INSERT INTO TInventarioGeneral (IdInv, CodProd, balanceProd) "
        sql += "VALUES (" & idInv & ",'" & codProd & "'," & balance & ");"
        MsgBox(sql)
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' ------------------------------------------------------------------
        desconectar()
    End Sub

    Public Sub modificar(ByVal idInv As String, ByVal codProd As String, ByVal balance As String)
        conectar()

        ' MODIFICA LA TABLA INVENTARIO GENERAL
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "UPDATE TInventarioGeneral "
        sql += "SET CodProd='" & codProd & "', "
        sql += "balanceProd=" & balance & " "
        sql += "WHERE IdInv=" & idInv & ";"
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' ------------------------------------------------------------------
        desconectar()
    End Sub
    Public Sub eliminar(ByVal idInv As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(idInv, "IdInv", "TInventarioGeneral", True))

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TInventarioGeneral WHERE IdInv=" & idInv & ""
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
