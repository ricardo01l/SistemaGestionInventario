Public Class FinventarioCompra

    Inherits Fgeneral
    Dim fig As New FinventarioGeneral

    Public Sub agregar(ByVal codProd As String, ByVal precio As String, ByVal cantidad As String, ByVal codFact As String, ByVal fechaFact As String)
        Dim yaExiste As New Boolean


        yaExiste = CBool(existe(codFact, "CodFactCompr", "TFacturaCompra"))
        
        If Not yaExiste Then
            'Crea la Factura si no existe --------------------------------
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO TFacturaCompra (CodFactCompr, FechaFact) "
            sql += "VALUES ('" & codFact & "','" & fechaFact & "');"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
            '----------------------------------------------------------------
        End If

        'Añade un nuevo registro al Inventario de compras --------------------
        conectar()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        sql = "INSERT INTO TInventarioCompra (CantidadCompr, CodProd, CodFactCompr, PrecioCompr) "
        sql += "VALUES (" & cantidad & ",'" & codProd & "','" & codFact & "'," & precio & ");"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()
        '----------------------------------------------------------------

        añadirBalance(codProd)
    End Sub
    Public Sub modificar(ByVal idInv As String, ByVal codProd As String, ByVal precio As String, ByVal cantidad As String, ByVal codFact As String, Optional ByVal fechaFact As String = "Sin Fecha")

        conectar()
        ' MODIFICA LA TABLA INVENTARIO COMPRA
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "UPDATE TInventarioCompra "
        sql += "SET CodProd='" & codProd & "', "
        sql += "PrecioCompr=" & precio & ", "
        sql += "CantidadCompr=" & cantidad & ", "
        sql += "codFactCompr='" & codFact & "' "
        sql += "WHERE IdInvCompr=" & idInv & ";"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        desconectar()

        ' ------------------------------------------------------------------
        If fechaFact <> "Sin Fecha" Then
            conectar()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            ' MODIFICA LA TABLA FACTURA COMPRA
            sql = "UPDATE TFacturaCompra "
            sql += "SET FechaFact='" & fechaFact & "' "
            sql += "WHERE CodFactCompr='" & codFact & "'"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()

        End If
        añadirBalance(codProd)
    End Sub
    Public Sub eliminar(ByVal idInv As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(idInv, "IdInvCompr", "TInventarioCompra", True))

        Dim dtCompr As DataTable = consultarRegistro("IdInvCompr", idInv, "TInventarioCompra", False)


        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TInventarioCompra WHERE IdInvCompr=" & idInv & ""
            cmd.CommandText = sql


            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
        Else
            MsgBox("El registro con el id ingresado no existe")
        End If
        añadirBalance(dtCompr(0)("CodProd").ToString)
    End Sub


    Private Sub añadirBalance(ByVal CodProd As String)
        Dim dtCompr As New DataTable
        Dim dt As New DataTable

        dtCompr = consultarRegistro("CodProd", CodProd, "TInventarioCompra", True)
        dt = consultarRegistro("CodProd", CodProd, "TInventarioGeneral", True)

        Dim balance As Integer = 0
        For i As Integer = 0 To (dtCompr.Rows.Count - 1)
            balance += CInt(dtCompr(i)("CantidadCompr"))
        Next
        If dt.Rows.Count > 0 Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE TInventarioGeneral "
            sql += "SET "
            sql += "BalanceProd=" & balance & " "
            sql += "WHERE CodProd='" & CodProd & "';"

            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
        Else
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sql = "INSERT INTO TInventarioGeneral (CodProd, balanceProd) "
            sql += "VALUES ('" & CodProd & "'," & balance & ");"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
        End If
    End Sub
End Class
