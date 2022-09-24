Imports datos
Module Fformas
    Public dt As New DataTable
    Dim fg As New Fgeneral
    Dim fpdf As New Fpdf

    ' ELIMINAR VACÍO DE UN CMB
    Public Sub eliminarVacioCmb(ByVal cmb As System.Windows.Forms.ComboBox)
        While cmb.Items.Contains("")
            cmb.Items.Remove("")
        End While
    End Sub

    ' FUNCIONES LIMITANTES DE LA ENTRADA DE TEXTO
    Public Sub soloNumerosPuntos(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar.ToString = "." Or Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumerosYletras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloLetrasYEspacios(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub soloNumerosLetrasYCaracteres(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' LLENA LOS COMBOBOXES
    Public Sub llenarCmb(ByVal cmb As System.Windows.Forms.ComboBox, ByVal campoId As String, ByVal tabla As String)
        cmb.Items.Clear()

        dt = CType(fg.consultarId(campoId, tabla), DataTable)

        If dt.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                cmb.Items.Add(dt(i)(campoId))
            Next
        End If
        fg.desconectar()
    End Sub
    

    ' LLENA UN DATAGRIDVIEW
    Public Sub setDgv(ByVal tabla As String, ByVal dgv As System.Windows.Forms.DataGridView)
        dt = CType(fg.consultar(tabla), DataTable)
        dgv.DataSource = dt
    End Sub


    Public Sub exportardb(ByVal SaveFileDialog1 As System.Windows.Forms.SaveFileDialog)
        SaveFileDialog1.Filter = "Access Files |*.accdb"
        SaveFileDialog1.FileName = "rafnielTechnology.accdb"
        SaveFileDialog1.OverwritePrompt = False
        SaveFileDialog1.AddExtension = True
        Dim guardado As Integer = SaveFileDialog1.ShowDialog()

        Dim path As String = SaveFileDialog1.FileName
        If guardado = 1 Then
            If My.Computer.FileSystem.FileExists(path) And path <> "rafnielTechnology.accdb" Then
                My.Computer.FileSystem.DeleteFile(path)
                My.Computer.FileSystem.CopyFile("rafnielTechnology.accdb", path)
            Else
                My.Computer.FileSystem.CopyFile("rafnielTechnology.accdb", path)
            End If
            MsgBox("Se ha exportado la base de datos correctamente", MsgBoxStyle.Information, "Se exportó con exito")
        End If
        SaveFileDialog1.Reset()
    End Sub

    Public Sub importardb(ByVal SaveFileDialog1 As System.Windows.Forms.SaveFileDialog)
        SaveFileDialog1.Filter = "Access Files |*.accdb"
        SaveFileDialog1.FileName = "archivo.accdb"
        SaveFileDialog1.OverwritePrompt = False
        SaveFileDialog1.AddExtension = True
        Dim guardado As Integer = SaveFileDialog1.ShowDialog()

        Dim path As String = SaveFileDialog1.FileName
        If guardado = 1 Then
            If My.Computer.FileSystem.FileExists(path) Then
                Try
                    My.Computer.FileSystem.DeleteFile("rafnielTechnology.accdb")
                    My.Computer.FileSystem.CopyFile(path, "rafnielTechnology.accdb")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                MsgBox("Se ha importado la base de datos correctamente", MsgBoxStyle.Information, "Se importó con exito")
            End If
        End If
        SaveFileDialog1.Reset()
    End Sub
End Module
