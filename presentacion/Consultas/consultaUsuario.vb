Public Class consultaUsuario

    Private Sub consultaUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
    Private Sub consultaUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        usuario.Show()
    End Sub
    Private Sub dgvUsuario_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUsuario.DataSourceChanged
        Me.dgvUsuario.Columns(0).HeaderText = "Nombre de Usuario"
        Me.dgvUsuario.Columns(5).HeaderText = "Teléfono"
        Me.dgvUsuario.Columns(6).HeaderText = "Estatus"
        Me.dgvUsuario.Columns(7).HeaderText = "Tipo de Usuario"
    End Sub
End Class