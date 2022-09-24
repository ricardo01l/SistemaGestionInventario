<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventarioGeneral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventarioGeneral))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarInventarioDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarInventarioDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManejarBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.tsslab = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbIdInv = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCodProd = New System.Windows.Forms.ComboBox()
        Me.txtCantProd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombrProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.BaseDeDatosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioDeComprasToolStripMenuItem, Me.InventarioDeVentasToolStripMenuItem})
        Me.InformesToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.InformesToolStripMenuItem.Text = "I&nformes"
        '
        'InventarioDeComprasToolStripMenuItem
        '
        Me.InventarioDeComprasToolStripMenuItem.Name = "InventarioDeComprasToolStripMenuItem"
        Me.InventarioDeComprasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.InventarioDeComprasToolStripMenuItem.Text = "Inventario de Compras"
        '
        'InventarioDeVentasToolStripMenuItem
        '
        Me.InventarioDeVentasToolStripMenuItem.Name = "InventarioDeVentasToolStripMenuItem"
        Me.InventarioDeVentasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.InventarioDeVentasToolStripMenuItem.Text = "Inventario de Ventas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarInventarioDeComprasToolStripMenuItem, Me.ActualizarInventarioDeVentasToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "&Inventario"
        '
        'ActualizarInventarioDeComprasToolStripMenuItem
        '
        Me.ActualizarInventarioDeComprasToolStripMenuItem.Name = "ActualizarInventarioDeComprasToolStripMenuItem"
        Me.ActualizarInventarioDeComprasToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.ActualizarInventarioDeComprasToolStripMenuItem.Text = "Actualizar Inventario de Compras"
        '
        'ActualizarInventarioDeVentasToolStripMenuItem
        '
        Me.ActualizarInventarioDeVentasToolStripMenuItem.Name = "ActualizarInventarioDeVentasToolStripMenuItem"
        Me.ActualizarInventarioDeVentasToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.ActualizarInventarioDeVentasToolStripMenuItem.Text = "Actualizar Inventario de Ventas"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'BaseDeDatosToolStripMenuItem
        '
        Me.BaseDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.ManejarBaseDeDatosToolStripMenuItem})
        Me.BaseDeDatosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        Me.BaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.BaseDeDatosToolStripMenuItem.Text = "&Base de Datos"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'ManejarBaseDeDatosToolStripMenuItem
        '
        Me.ManejarBaseDeDatosToolStripMenuItem.Name = "ManejarBaseDeDatosToolStripMenuItem"
        Me.ManejarBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ManejarBaseDeDatosToolStripMenuItem.Text = "Manejar Base de Datos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "&Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslab, Me.statusLabel})
        Me.Status.Location = New System.Drawing.Point(0, 402)
        Me.Status.Name = "Status"
        Me.Status.ShowItemToolTips = True
        Me.Status.Size = New System.Drawing.Size(874, 22)
        Me.Status.TabIndex = 37
        '
        'tsslab
        '
        Me.tsslab.Name = "tsslab"
        Me.tsslab.Size = New System.Drawing.Size(0, 17)
        '
        'statusLabel
        '
        Me.statusLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(182, 291)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(108, 35)
        Me.btnConsultar.TabIndex = 49
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(738, 353)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 35)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(184, 353)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 35)
        Me.btnEliminar.TabIndex = 47
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(26, 291)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(108, 35)
        Me.btnModificar.TabIndex = 46
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(26, 353)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(108, 35)
        Me.btnLimpiar.TabIndex = 44
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 15)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Sistema de gestión de inventarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 24)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "RAFNIEL TECHNOLOGY, F.P."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIdInv)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbCodProd)
        Me.GroupBox1.Controls.Add(Me.txtCantProd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombrProd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 176)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del inventario"
        '
        'cmbIdInv
        '
        Me.cmbIdInv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdInv.FormattingEnabled = True
        Me.cmbIdInv.Location = New System.Drawing.Point(26, 58)
        Me.cmbIdInv.Name = "cmbIdInv"
        Me.cmbIdInv.Size = New System.Drawing.Size(319, 22)
        Me.cmbIdInv.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(197, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Id de los registros del inventario"
        '
        'cmbCodProd
        '
        Me.cmbCodProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodProd.FormattingEnabled = True
        Me.cmbCodProd.Location = New System.Drawing.Point(165, 113)
        Me.cmbCodProd.Name = "cmbCodProd"
        Me.cmbCodProd.Size = New System.Drawing.Size(180, 22)
        Me.cmbCodProd.TabIndex = 17
        '
        'txtCantProd
        '
        Me.txtCantProd.Location = New System.Drawing.Point(470, 58)
        Me.txtCantProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCantProd.Name = "txtCantProd"
        Me.txtCantProd.Size = New System.Drawing.Size(316, 20)
        Me.txtCantProd.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(467, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cantidad total del producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(467, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre del producto"
        '
        'txtNombrProd
        '
        Me.txtNombrProd.Enabled = False
        Me.txtNombrProd.Location = New System.Drawing.Point(607, 115)
        Me.txtNombrProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNombrProd.Name = "txtNombrProd"
        Me.txtNombrProd.Size = New System.Drawing.Size(180, 20)
        Me.txtNombrProd.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Productos existentes"
        '
        'inventarioGeneral
        '
        Me.AcceptButton = Me.btnModificar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(874, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inventarioGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Inventario General"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarInventarioDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarInventarioDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslab As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbIdInv As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbCodProd As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantProd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombrProd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManejarBaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
