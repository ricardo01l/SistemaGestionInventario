Public Class FinventarioVenta


    Inherits Fgeneral

    Public Sub agregar(ByVal codProd As String, ByVal precio As String, ByVal cantidad As String, ByVal codFact As String, Optional ByVal fechaFact As String = "")
        Dim yaExiste As New Boolean


        yaExiste = CBool(existe(codFact, "CodFactVent", "TFacturaVenta"))

        If Not yaExiste Then
            'Crea la Factura si no existe --------------------------------
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "INSERT INTO TFacturaVenta (CodFactVent, FechaFact) "
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

        'Añade un nuevo registro al Inventario de ventas --------------------
        conectar()

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "INSERT INTO TInventarioVenta (CantidadVent, CodProd, CodFactVent, PrecioVent) "
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

        ' MODIFICA LA TABLA INVENTARIO VENTA
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "UPDATE TInventarioVenta "
        sql += "SET CodProd='" & codProd & "', "
        sql += "PrecioVent=" & precio & ", "
        sql += "CantidadVent=" & cantidad & ", "
        sql += "codFactVent='" & codFact & "' "
        sql += "WHERE IdInvVent=" & idInv & ";"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' ------------------------------------------------------------------
        If fechaFact <> "Sin Fecha" Then
            ' MODIFICA LA TABLA FACTURA VENTA
            sql = "UPDATE TFacturaVenta "
            sql += "SET FechaFact='" & fechaFact & "' "
            sql += "WHERE CodFactVent='" & codFact & "'"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        desconectar()
        añadirBalance(codProd)
    End Sub
    Public Sub eliminar(ByVal idInv As String)
        Dim yaExiste As New Boolean
        yaExiste = CBool(existe(idInv, "IdInvVent", "TInventarioVenta", True))

        If yaExiste Then
            Dim dtVent As DataTable = consultarRegistro("IdInvVent", idInv, "TInventarioVenta", False)
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TInventarioVenta WHERE IdInvVent=" & idInv & ""
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
            'Añade un nuevo registro al Inventario General --------------------
            Dim dt As New DataTable
            dt = consultarRegistro("CodProd", dtVent(0)("CodProd").ToString, "TInventarioGeneral", True)
            conectar()
            If dt.Rows.Count > 0 Then

                Dim balance As Integer = CInt(dt(0)("BalanceProd")) + CInt(dtVent(0)("CantidadVent"))
                sql = "UPDATE TInventarioGeneral "
                sql += "SET "
                sql += "BalanceProd=" & balance & " "
                sql += "WHERE CodProd='" & dtVent(0)("CodProd").ToString & "';"
                cmd.CommandText = sql
            End If
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            desconectar()
            añadirBalance(dtVent(0)("CodProd").ToString)

            '----------------------------------------------------------------
        Else
            MsgBox("El registro con el id ingresado no existe")
        End If
    End Sub

    Private Sub añadirBalance(ByVal CodProd As String)
        Dim dtVent As New DataTable
        Dim dt As New DataTable

        dtVent = consultarRegistro("CodProd", CodProd, "TInventarioVenta", True)
        dt = consultarRegistro("CodProd", CodProd, "TInventarioGeneral", True)

        Dim balance As Integer = 0
        For i As Integer = 0 To (dtVent.Rows.Count - 1)
            balance += CInt(dtVent(i)("CantidadVent"))
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
        End If

    End Sub
End Class
