Imports System.Data.OleDb

Public Class conexion

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rafnielTechnology.accdb;Persist Security Info=False;Jet OLEDB:Database Password=admin;")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String

    Public Sub conectar()
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub desconectar()
        Try
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
