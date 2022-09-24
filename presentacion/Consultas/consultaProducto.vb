Public Class consultaProducto



    Private Sub consultaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
    Private Sub consultaProductos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        producto.Show()
    End Sub

    Private Sub dgvProd_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProd.DataSourceChanged

        Me.dgvProd.Columns(0).HeaderText = "Código del Producto"
        Me.dgvProd.Columns(1).HeaderText = "Nombre del Producto"
        Me.dgvProd.Columns(2).HeaderText = "Descripción del Producto"
    End Sub
End Class