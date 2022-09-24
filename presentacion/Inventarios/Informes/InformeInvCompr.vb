Imports entidad
Imports datos
Public Class InformeInvCompr
    Dim fpdf As New Fpdf
    Private Sub btnInfInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfInv.Click
        If Me.rbtnUno.Checked Then
            fpdf.iniciarPdf(True, "SoloFull", Me.cmbIdInv.Text.ToString)
        End If

        If Me.rbtnTodos.Checked Then
            If Me.cmbInforme.SelectedItem.ToString = "Toda la información del inventario" Then
                fpdf.iniciarPdf(True, "Full", Me.cmbIdInv.Text.ToString)
            ElseIf Me.cmbInforme.SelectedItem.ToString = "La información del inventario sin las facturas" Then
                fpdf.iniciarPdf(True, "SinFact", Me.cmbIdInv.Text.ToString)
            ElseIf Me.cmbInforme.SelectedItem.ToString = "La información del inventario sin los productos" Then
                fpdf.iniciarPdf(True, "SinProd", Me.cmbIdInv.Text.ToString)
            ElseIf Me.cmbInforme.SelectedItem.ToString = "Toda la información de un elemento" Then
                MsgBox("Seleccione la opción 'Solo un registro' para consultar un elemento")
            End If
        End If

        If Me.rbtnFechas.Checked Then
            fpdf.iniciarPdf(True, "InterFechas", fechaInicio:=Me.dtInicio.Value.Month.ToString & "/" & Me.dtInicio.Value.Day.ToString & "/" & Me.dtInicio.Value.Year.ToString, fechaFinal:=Me.dtFinal.Value.Month.ToString & "/" & Me.dtFinal.Value.Day.ToString & "/" & Me.dtFinal.Value.Year.ToString)
        End If

        If Me.rbtnProd.Checked Then
            fpdf.iniciarPdf(True, "NombreProd", Me.cmbNombrProd.Text.ToString)
        End If

        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'. Cuidado, si desea realizar otro informe, mueva el archivo 'informe.pdf' o cámbiele el nombre.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub

    Private Sub InformeInvCompr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbInforme.SelectedItem = "Toda la información de un elemento"
        llenarCmb(Me.cmbNombrProd, "NombreProd", "TProducto")
        llenarCmb(Me.cmbIdInv, "IdInvCompr", "TInventarioCompra")
    End Sub
    Private Sub rbtnUno_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnUno.CheckedChanged
        If Me.rbtnUno.Checked Then
            Me.cmbIdInv.Enabled = True

            Me.cmbInforme.Enabled = False
            Me.dtInicio.Enabled = False
            Me.dtFinal.Enabled = False
            Me.cmbNombrProd.Enabled = False
            Me.cmbInforme.SelectedItem = "Toda la información de un elemento"
        End If
        Me.statusLabel.Text = ""
    End Sub

    Private Sub rbtnTodos_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnTodos.CheckedChanged
        If Me.rbtnTodos.Checked Then
            Me.cmbIdInv.Enabled = False
            Me.dtInicio.Enabled = False
            Me.dtFinal.Enabled = False
            Me.cmbNombrProd.Enabled = False

            Me.cmbInforme.Enabled = True
            Me.cmbInforme.SelectedItem = ""
        End If
        Me.statusLabel.Text = ""
    End Sub
    Private Sub rbtnFechas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnFechas.CheckedChanged
        If Me.rbtnFechas.Checked Then
            Me.cmbIdInv.Enabled = False
            Me.cmbInforme.Enabled = False

            Me.dtInicio.Enabled = True
            Me.dtFinal.Enabled = True

            Me.cmbNombrProd.Enabled = False

            Me.cmbInforme.SelectedItem = ""
        End If
    End Sub
    Private Sub rbtnProd_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnProd.CheckedChanged
        If Me.rbtnProd.Checked Then
            Me.cmbIdInv.Enabled = False
            Me.cmbInforme.Enabled = False
            Me.dtInicio.Enabled = False
            Me.dtFinal.Enabled = False

            Me.cmbNombrProd.Enabled = True

            Me.cmbInforme.SelectedItem = ""
        End If
    End Sub

    Private Sub cmbIdInv_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.statusLabel.Text = ""
    End Sub

    Private Sub cmbInforme_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.statusLabel.Text = ""
    End Sub

    ' CUANDO SE CLIQUEAN LAS OPCIONES DEL TOOLSTRIP
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        usuario.Show()
        Me.Close()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        producto.Show()
        Me.Close()

    End Sub
    Private Sub ActualizarInventarioDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeComprasToolStripMenuItem.Click
        inventarioCompra.Show()
        Me.Close()
    End Sub
    Private Sub InventarioGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        inventarioGeneral.Show()
        Me.Close()
    End Sub
    Private Sub InventarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioDeVentasToolStripMenuItem.Click
        InformeInvVent.Show()
        Me.Close()
    End Sub
    Private Sub BaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        baseDatos.Show()
        Me.Close()
    End Sub
    Private Sub ActualizarInventarioDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarInventarioDeVentasToolStripMenuItem.Click
        inventarioVenta.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        Process.Start("Manual de Usuario.pdf")
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub
    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        exportardb(SaveFileDialog1)
    End Sub
    Private Sub ImportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarToolStripMenuItem.Click
        importardb(SaveFileDialog1)
    End Sub
    Private Sub ManejarBaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManejarBaseDeDatosToolStripMenuItem.Click
        baseDatos.Show()
        Me.Close()
    End Sub

End Class