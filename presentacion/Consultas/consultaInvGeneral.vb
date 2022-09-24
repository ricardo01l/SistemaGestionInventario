Public Class consultaInvGeneral

    Private Sub consultaInvGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub consultaInvGeneral_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inventarioGeneral.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub


    Private Sub dgvInv_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvInv.DataSourceChanged
        Me.dgvInv.Columns(0).HeaderText = "Id"
        Me.dgvInv.Columns(1).HeaderText = "Código del Producto"
        Me.dgvInv.Columns(2).HeaderText = "Cantidad Total"
    End Sub
End Class