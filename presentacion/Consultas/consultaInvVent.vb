Public Class consultaInvVent

    Private Sub consultaInvVent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub consultaInvCompr_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        inventarioVenta.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
    

    Private Sub dgvInvCompr_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvInvVent.DataSourceChanged
        Me.dgvInvVent.Columns(0).HeaderText = "Id"
        Me.dgvInvVent.Columns(1).HeaderText = "Cantidad Vendida"
        Me.dgvInvVent.Columns(2).HeaderText = "Código del Producto"
        Me.dgvInvVent.Columns(3).HeaderText = "Código de la Factura"
        Me.dgvInvVent.Columns(4).HeaderText = "Precio de Venta"
    End Sub
End Class