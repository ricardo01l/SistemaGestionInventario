Public Class Fgeneral
    Inherits conexion


    Public Function existe(ByVal valor As String, ByVal campo As String, ByVal tabla As String, Optional ByVal isId As Boolean = False) As Boolean
        Dim yaExiste As Boolean
        yaExiste = False

        yaExiste = consultarElemento(valor, campo, tabla, isId)
        desconectar()

        Return yaExiste
    End Function

    Public Function consultarElemento(ByVal valor As String, ByVal campo As String, ByVal tabla As String, ByVal isId As Boolean) As Boolean
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isId Then
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "=" & valor & ""
        Else
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "='" & valor & "'"
        End If
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function consultarId(ByVal id As String, ByVal tabla As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT " & id & " FROM " & tabla & ";"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function consultar(ByVal tabla As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM " & tabla

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
    Public Function consultarRegistro(ByVal campo As String, ByVal valorCampo As String, ByVal tabla As String, ByVal isString As Boolean) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "='" & valorCampo & "'"
        Else
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "=" & valorCampo & ""
        End If
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


    Public Function unionFullCompr() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvCompr, CantidadCompr, TInventarioCompra.CodProd, TInventarioCompra.CodFactCompr, PrecioCompr, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioCompra LEFT JOIN TProducto ON TInventarioCompra.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaCompra ON TInventarioCompra.CodFactCompr=TFacturaCompra.CodFactCompr);"
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
    Public Function unionSinFactCompr() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvCompr, CantidadCompr, TInventarioCompra.CodProd, PrecioCompr, NombreProd, DescripProd, TInventarioCompra.CodFactCompr "
        sql += "FROM (TInventarioCompra LEFT JOIN TProducto ON TInventarioCompra.CodProd=TProducto.CodProd) "
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
    Public Function unionSinProdCompr() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvCompr, CantidadCompr, TInventarioCompra.CodProd, TInventarioCompra.CodFactCompr, PrecioCompr, FechaFact, EstatusFact "
        sql += "FROM (TInventarioCompra LEFT JOIN TFacturaCompra ON TInventarioCompra.CodFactCompr=TFacturaCompra.CodFactCompr);"
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
    Public Function unionSoloFullCompr(ByVal idInvCompr As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvCompr, CantidadCompr, TInventarioCompra.CodProd, TInventarioCompra.CodFactCompr, PrecioCompr, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioCompra LEFT JOIN TProducto ON TInventarioCompra.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaCompra ON TInventarioCompra.CodFactCompr=TFacturaCompra.CodFactCompr) WHERE IdInvCompr=" & idInvCompr & ";"
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
    Public Function unionInterFechasCompr(ByVal fechaIncio As String, ByVal fechaFinal As String) As DataTable


        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvCompr, CantidadCompr, TInventarioCompra.CodProd, TInventarioCompra.CodFactCompr, PrecioCompr, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioCompra LEFT JOIN TProducto ON TInventarioCompra.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaCompra ON TInventarioCompra.CodFactCompr=TFacturaCompra.CodFactCompr) WHERE TFacturaCompra.FechaFact >= #" & fechaIncio & "# AND TFacturaCompra.FechaFact <= #" & fechaFinal & "#;"

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
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function unionNombreProdCompr(ByVal nombreProd As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvCompr, CantidadCompr, TInventarioCompra.CodProd, TInventarioCompra.CodFactCompr, PrecioCompr, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioCompra LEFT JOIN TProducto ON TInventarioCompra.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaCompra ON TInventarioCompra.CodFactCompr=TFacturaCompra.CodFactCompr) WHERE NombreProd='" & nombreProd & "';"
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


    Public Function unionFullVent() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvVent, CantidadVent, TInventarioVenta.CodProd, TInventarioVenta.CodFactVent, PrecioVent, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioVenta LEFT JOIN TProducto ON TInventarioVenta.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaVenta ON TInventarioVenta.CodFactVent=TFacturaVenta.CodFactVent);"
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
    Public Function unionSinFactVent() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvVent, CantidadVent, TInventarioVenta.CodProd, PrecioVent, NombreProd, DescripProd, CodFactVent "
        sql += "FROM (TInventarioVenta LEFT JOIN TProducto ON TInventarioVenta.CodProd=TProducto.CodProd) "
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
    Public Function unionSinProdVent() As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvVent, CantidadVent, TInventarioVenta.CodProd, TInventarioVenta.CodFactVent, PrecioVent, FechaFact, EstatusFact "
        sql += "FROM (TInventarioVenta LEFT JOIN TFacturaVenta ON TInventarioVenta.CodFactVent=TFacturaVenta.CodFactVent);"
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
    Public Function unionSoloFullVent(ByVal idInvVent As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvVent, CantidadVent, TInventarioVenta.CodProd, TInventarioVenta.CodFactVent, PrecioVent, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioVenta LEFT JOIN TProducto ON TInventarioVenta.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaVenta ON TInventarioVenta.CodFactVent=TFacturaVenta.CodFactVent) WHERE IdInvVent=" & idInvVent & ";"
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
    Public Function unionInterFechasVent(ByVal fechaIncio As String, ByVal fechaFinal As String) As DataTable
        

        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvVent, CantidadVent, TInventarioVenta.CodProd, TInventarioVenta.CodFactVent, PrecioVent, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioVenta LEFT JOIN TProducto ON TInventarioVenta.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaVenta ON TInventarioVenta.CodFactVent=TFacturaVenta.CodFactVent) WHERE TFacturaVenta.FechaFact >= #" & fechaIncio & "# AND TFacturaVenta.FechaFact <= #" & fechaFinal & "#;"

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
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function unionNombreProdVent(ByVal nombreProd As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdInvVent, CantidadVent, TInventarioVenta.CodProd, TInventarioVenta.CodFactVent, PrecioVent, NombreProd, DescripProd, FechaFact, EstatusFact "
        sql += "FROM ((TInventarioVenta LEFT JOIN TProducto ON TInventarioVenta.CodProd=TProducto.CodProd) "
        sql += "LEFT JOIN TFacturaVenta ON TInventarioVenta.CodFactVent=TFacturaVenta.CodFactVent) WHERE NombreProd='" & nombreProd & "';"
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
End Class
