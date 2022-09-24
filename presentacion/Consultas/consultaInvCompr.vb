Public Class consultaInvCompr


    Private Sub consultaInvCompr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
    Private Sub consultaInvCompr_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inventarioCompra.Show()
    End Sub

    Private Sub dgvInvCompr_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvInvCompr.DataSourceChanged
        Me.dgvInvCompr.Columns(0).HeaderText = "Id"
        Me.dgvInvCompr.Columns(1).HeaderText = "Cantidad Comprada"
        Me.dgvInvCompr.Columns(2).HeaderText = "Código del Producto"
        Me.dgvInvCompr.Columns(3).HeaderText = "Código de la Factura"
        Me.dgvInvCompr.Columns(4).HeaderText = "Precio de Compra"
    End Sub
End Class