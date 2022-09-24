<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baseDatos))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabCtrl = New System.Windows.Forms.TabControl()
        Me.tabUsuario = New System.Windows.Forms.TabPage()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.EliminarUsuario = New System.Windows.Forms.Button()
        Me.btnEnviarUsuario = New System.Windows.Forms.Button()
        Me.dgvUsuario = New System.Windows.Forms.DataGridView()
        Me.tabProducto = New System.Windows.Forms.TabPage()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnEnviarProducto = New System.Windows.Forms.Button()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.tabInvCompr = New System.Windows.Forms.TabPage()
        Me.cmbInvCompr = New System.Windows.Forms.ComboBox()
        Me.btnEliminarInvCompr = New System.Windows.Forms.Button()
        Me.btnEnviarInvCompr = New System.Windows.Forms.Button()
        Me.dgvInvCompr = New System.Windows.Forms.DataGridView()
        Me.tabFactCompr = New System.Windows.Forms.TabPage()
        Me.cmbFactCompr = New System.Windows.Forms.ComboBox()
        Me.btnEliminarFactCompr = New System.Windows.Forms.Button()
        Me.btnEnviarFactCompr = New System.Windows.Forms.Button()
        Me.dgvFactCompr = New System.Windows.Forms.DataGridView()
        Me.tabInvVent = New System.Windows.Forms.TabPage()
        Me.cmbInvVent = New System.Windows.Forms.ComboBox()
        Me.btnEliminarInvVent = New System.Windows.Forms.Button()
        Me.btnEnviarInvVent = New System.Windows.Forms.Button()
        Me.dgvInvVent = New System.Windows.Forms.DataGridView()
        Me.tabFactVent = New System.Windows.Forms.TabPage()
        Me.cmbFactVent = New System.Windows.Forms.ComboBox()
        Me.btnEliminarFactVent = New System.Windows.Forms.Button()
        Me.btnEnviarFactVent = New System.Windows.Forms.Button()
        Me.dgvFactVent = New System.Windows.Forms.DataGridView()
        Me.tabInvGen = New System.Windows.Forms.TabPage()
        Me.cmbInvGen = New System.Windows.Forms.ComboBox()
        Me.btnEliminarInvGen = New System.Windows.Forms.Button()
        Me.btnEnviarInvGen = New System.Windows.Forms.Button()
        Me.dgvInvGen = New System.Windows.Forms.DataGridView()
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
        Me.pgb = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabCtrl.SuspendLayout()
        Me.tabUsuario.SuspendLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProducto.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInvCompr.SuspendLayout()
        CType(Me.dgvInvCompr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFactCompr.SuspendLayout()
        CType(Me.dgvFactCompr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInvVent.SuspendLayout()
        CType(Me.dgvInvVent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFactVent.SuspendLayout()
        CType(Me.dgvFactVent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInvGen.SuspendLayout()
        CType(Me.dgvInvGen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(687, 481)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(134, 31)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Sistema de gestión de inventarios"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "RAFNIEL TECHNOLOGY, F.P."
        '
        'TabCtrl
        '
        Me.TabCtrl.Controls.Add(Me.tabUsuario)
        Me.TabCtrl.Controls.Add(Me.tabProducto)
        Me.TabCtrl.Controls.Add(Me.tabInvCompr)
        Me.TabCtrl.Controls.Add(Me.tabFactCompr)
        Me.TabCtrl.Controls.Add(Me.tabInvVent)
        Me.TabCtrl.Controls.Add(Me.tabFactVent)
        Me.TabCtrl.Controls.Add(Me.tabInvGen)
        Me.TabCtrl.Location = New System.Drawing.Point(0, 85)
        Me.TabCtrl.Name = "TabCtrl"
        Me.TabCtrl.SelectedIndex = 0
        Me.TabCtrl.Size = New System.Drawing.Size(867, 384)
        Me.TabCtrl.TabIndex = 36
        '
        'tabUsuario
        '
        Me.tabUsuario.Controls.Add(Me.cmbUsuario)
        Me.tabUsuario.Controls.Add(Me.EliminarUsuario)
        Me.tabUsuario.Controls.Add(Me.btnEnviarUsuario)
        Me.tabUsuario.Controls.Add(Me.dgvUsuario)
        Me.tabUsuario.Location = New System.Drawing.Point(4, 23)
        Me.tabUsuario.Name = "tabUsuario"
        Me.tabUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUsuario.Size = New System.Drawing.Size(859, 357)
        Me.tabUsuario.TabIndex = 0
        Me.tabUsuario.Text = "TUsuario"
        Me.tabUsuario.UseVisualStyleBackColor = True
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(529, 325)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(168, 22)
        Me.cmbUsuario.TabIndex = 39
        '
        'EliminarUsuario
        '
        Me.EliminarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarUsuario.Location = New System.Drawing.Point(714, 320)
        Me.EliminarUsuario.Name = "EliminarUsuario"
        Me.EliminarUsuario.Size = New System.Drawing.Size(134, 31)
        Me.EliminarUsuario.TabIndex = 38
        Me.EliminarUsuario.Text = "Eliminar"
        Me.EliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnEnviarUsuario
        '
        Me.btnEnviarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarUsuario.Location = New System.Drawing.Point(8, 320)
        Me.btnEnviarUsuario.Name = "btnEnviarUsuario"
        Me.btnEnviarUsuario.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarUsuario.TabIndex = 37
        Me.btnEnviarUsuario.Text = "Enviar Modificaciones"
        Me.btnEnviarUsuario.UseVisualStyleBackColor = True
        '
        'dgvUsuario
        '
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.Location = New System.Drawing.Point(0, 0)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.Size = New System.Drawing.Size(859, 314)
        Me.dgvUsuario.TabIndex = 0
        '
        'tabProducto
        '
        Me.tabProducto.Controls.Add(Me.cmbProducto)
        Me.tabProducto.Controls.Add(Me.btnEliminarProducto)
        Me.tabProducto.Controls.Add(Me.btnEnviarProducto)
        Me.tabProducto.Controls.Add(Me.dgvProducto)
        Me.tabProducto.Location = New System.Drawing.Point(4, 23)
        Me.tabProducto.Name = "tabProducto"
        Me.tabProducto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProducto.Size = New System.Drawing.Size(859, 357)
        Me.tabProducto.TabIndex = 1
        Me.tabProducto.Text = "TProducto"
        Me.tabProducto.UseVisualStyleBackColor = True
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(530, 320)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(168, 22)
        Me.cmbProducto.TabIndex = 43
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.Location = New System.Drawing.Point(714, 315)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(134, 31)
        Me.btnEliminarProducto.TabIndex = 42
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnEnviarProducto
        '
        Me.btnEnviarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarProducto.Location = New System.Drawing.Point(8, 315)
        Me.btnEnviarProducto.Name = "btnEnviarProducto"
        Me.btnEnviarProducto.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarProducto.TabIndex = 41
        Me.btnEnviarProducto.Text = "Enviar Modificaciones"
        Me.btnEnviarProducto.UseVisualStyleBackColor = True
        '
        'dgvProducto
        '
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Size = New System.Drawing.Size(859, 309)
        Me.dgvProducto.TabIndex = 40
        '
        'tabInvCompr
        '
        Me.tabInvCompr.Controls.Add(Me.cmbInvCompr)
        Me.tabInvCompr.Controls.Add(Me.btnEliminarInvCompr)
        Me.tabInvCompr.Controls.Add(Me.btnEnviarInvCompr)
        Me.tabInvCompr.Controls.Add(Me.dgvInvCompr)
        Me.tabInvCompr.Location = New System.Drawing.Point(4, 23)
        Me.tabInvCompr.Name = "tabInvCompr"
        Me.tabInvCompr.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInvCompr.Size = New System.Drawing.Size(859, 357)
        Me.tabInvCompr.TabIndex = 2
        Me.tabInvCompr.Text = "TInventarioCompra"
        Me.tabInvCompr.UseVisualStyleBackColor = True
        '
        'cmbInvCompr
        '
        Me.cmbInvCompr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvCompr.FormattingEnabled = True
        Me.cmbInvCompr.Location = New System.Drawing.Point(529, 325)
        Me.cmbInvCompr.Name = "cmbInvCompr"
        Me.cmbInvCompr.Size = New System.Drawing.Size(168, 22)
        Me.cmbInvCompr.TabIndex = 47
        '
        'btnEliminarInvCompr
        '
        Me.btnEliminarInvCompr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarInvCompr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarInvCompr.Location = New System.Drawing.Point(714, 320)
        Me.btnEliminarInvCompr.Name = "btnEliminarInvCompr"
        Me.btnEliminarInvCompr.Size = New System.Drawing.Size(134, 31)
        Me.btnEliminarInvCompr.TabIndex = 46
        Me.btnEliminarInvCompr.Text = "Eliminar"
        Me.btnEliminarInvCompr.UseVisualStyleBackColor = True
        '
        'btnEnviarInvCompr
        '
        Me.btnEnviarInvCompr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarInvCompr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarInvCompr.Location = New System.Drawing.Point(8, 320)
        Me.btnEnviarInvCompr.Name = "btnEnviarInvCompr"
        Me.btnEnviarInvCompr.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarInvCompr.TabIndex = 45
        Me.btnEnviarInvCompr.Text = "Enviar Modificaciones"
        Me.btnEnviarInvCompr.UseVisualStyleBackColor = True
        '
        'dgvInvCompr
        '
        Me.dgvInvCompr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvCompr.Location = New System.Drawing.Point(0, 0)
        Me.dgvInvCompr.Name = "dgvInvCompr"
        Me.dgvInvCompr.Size = New System.Drawing.Size(859, 314)
        Me.dgvInvCompr.TabIndex = 44
        '
        'tabFactCompr
        '
        Me.tabFactCompr.Controls.Add(Me.cmbFactCompr)
        Me.tabFactCompr.Controls.Add(Me.btnEliminarFactCompr)
        Me.tabFactCompr.Controls.Add(Me.btnEnviarFactCompr)
        Me.tabFactCompr.Controls.Add(Me.dgvFactCompr)
        Me.tabFactCompr.Location = New System.Drawing.Point(4, 23)
        Me.tabFactCompr.Name = "tabFactCompr"
        Me.tabFactCompr.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFactCompr.Size = New System.Drawing.Size(859, 357)
        Me.tabFactCompr.TabIndex = 3
        Me.tabFactCompr.Text = "TFacturaCompra"
        Me.tabFactCompr.UseVisualStyleBackColor = True
        '
        'cmbFactCompr
        '
        Me.cmbFactCompr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFactCompr.FormattingEnabled = True
        Me.cmbFactCompr.Location = New System.Drawing.Point(530, 325)
        Me.cmbFactCompr.Name = "cmbFactCompr"
        Me.cmbFactCompr.Size = New System.Drawing.Size(168, 22)
        Me.cmbFactCompr.TabIndex = 47
        '
        'btnEliminarFactCompr
        '
        Me.btnEliminarFactCompr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarFactCompr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarFactCompr.Location = New System.Drawing.Point(714, 320)
        Me.btnEliminarFactCompr.Name = "btnEliminarFactCompr"
        Me.btnEliminarFactCompr.Size = New System.Drawing.Size(134, 31)
        Me.btnEliminarFactCompr.TabIndex = 46
        Me.btnEliminarFactCompr.Text = "Eliminar"
        Me.btnEliminarFactCompr.UseVisualStyleBackColor = True
        '
        'btnEnviarFactCompr
        '
        Me.btnEnviarFactCompr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarFactCompr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarFactCompr.Location = New System.Drawing.Point(8, 320)
        Me.btnEnviarFactCompr.Name = "btnEnviarFactCompr"
        Me.btnEnviarFactCompr.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarFactCompr.TabIndex = 45
        Me.btnEnviarFactCompr.Text = "Enviar Modificaciones"
        Me.btnEnviarFactCompr.UseVisualStyleBackColor = True
        '
        'dgvFactCompr
        '
        Me.dgvFactCompr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactCompr.Location = New System.Drawing.Point(0, 0)
        Me.dgvFactCompr.Name = "dgvFactCompr"
        Me.dgvFactCompr.Size = New System.Drawing.Size(859, 314)
        Me.dgvFactCompr.TabIndex = 44
        '
        'tabInvVent
        '
        Me.tabInvVent.Controls.Add(Me.cmbInvVent)
        Me.tabInvVent.Controls.Add(Me.btnEliminarInvVent)
        Me.tabInvVent.Controls.Add(Me.btnEnviarInvVent)
        Me.tabInvVent.Controls.Add(Me.dgvInvVent)
        Me.tabInvVent.Location = New System.Drawing.Point(4, 23)
        Me.tabInvVent.Name = "tabInvVent"
        Me.tabInvVent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInvVent.Size = New System.Drawing.Size(859, 357)
        Me.tabInvVent.TabIndex = 4
        Me.tabInvVent.Text = "TInventarioVenta"
        Me.tabInvVent.UseVisualStyleBackColor = True
        '
        'cmbInvVent
        '
        Me.cmbInvVent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvVent.FormattingEnabled = True
        Me.cmbInvVent.Location = New System.Drawing.Point(535, 325)
        Me.cmbInvVent.Name = "cmbInvVent"
        Me.cmbInvVent.Size = New System.Drawing.Size(168, 22)
        Me.cmbInvVent.TabIndex = 47
        '
        'btnEliminarInvVent
        '
        Me.btnEliminarInvVent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarInvVent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarInvVent.Location = New System.Drawing.Point(719, 320)
        Me.btnEliminarInvVent.Name = "btnEliminarInvVent"
        Me.btnEliminarInvVent.Size = New System.Drawing.Size(134, 31)
        Me.btnEliminarInvVent.TabIndex = 46
        Me.btnEliminarInvVent.Text = "Eliminar"
        Me.btnEliminarInvVent.UseVisualStyleBackColor = True
        '
        'btnEnviarInvVent
        '
        Me.btnEnviarInvVent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarInvVent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarInvVent.Location = New System.Drawing.Point(13, 320)
        Me.btnEnviarInvVent.Name = "btnEnviarInvVent"
        Me.btnEnviarInvVent.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarInvVent.TabIndex = 45
        Me.btnEnviarInvVent.Text = "Enviar Modificaciones"
        Me.btnEnviarInvVent.UseVisualStyleBackColor = True
        '
        'dgvInvVent
        '
        Me.dgvInvVent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvVent.Location = New System.Drawing.Point(-3, 0)
        Me.dgvInvVent.Name = "dgvInvVent"
        Me.dgvInvVent.Size = New System.Drawing.Size(859, 314)
        Me.dgvInvVent.TabIndex = 44
        '
        'tabFactVent
        '
        Me.tabFactVent.Controls.Add(Me.cmbFactVent)
        Me.tabFactVent.Controls.Add(Me.btnEliminarFactVent)
        Me.tabFactVent.Controls.Add(Me.btnEnviarFactVent)
        Me.tabFactVent.Controls.Add(Me.dgvFactVent)
        Me.tabFactVent.Location = New System.Drawing.Point(4, 23)
        Me.tabFactVent.Name = "tabFactVent"
        Me.tabFactVent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFactVent.Size = New System.Drawing.Size(859, 357)
        Me.tabFactVent.TabIndex = 5
        Me.tabFactVent.Text = "TFacturaVenta"
        Me.tabFactVent.UseVisualStyleBackColor = True
        '
        'cmbFactVent
        '
        Me.cmbFactVent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFactVent.FormattingEnabled = True
        Me.cmbFactVent.Location = New System.Drawing.Point(529, 325)
        Me.cmbFactVent.Name = "cmbFactVent"
        Me.cmbFactVent.Size = New System.Drawing.Size(168, 22)
        Me.cmbFactVent.TabIndex = 47
        '
        'btnEliminarFactVent
        '
        Me.btnEliminarFactVent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarFactVent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarFactVent.Location = New System.Drawing.Point(714, 320)
        Me.btnEliminarFactVent.Name = "btnEliminarFactVent"
        Me.btnEliminarFactVent.Size = New System.Drawing.Size(134, 31)
        Me.btnEliminarFactVent.TabIndex = 46
        Me.btnEliminarFactVent.Text = "Eliminar"
        Me.btnEliminarFactVent.UseVisualStyleBackColor = True
        '
        'btnEnviarFactVent
        '
        Me.btnEnviarFactVent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarFactVent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarFactVent.Location = New System.Drawing.Point(8, 320)
        Me.btnEnviarFactVent.Name = "btnEnviarFactVent"
        Me.btnEnviarFactVent.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarFactVent.TabIndex = 45
        Me.btnEnviarFactVent.Text = "Enviar Modificaciones"
        Me.btnEnviarFactVent.UseVisualStyleBackColor = True
        '
        'dgvFactVent
        '
        Me.dgvFactVent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactVent.Location = New System.Drawing.Point(0, 0)
        Me.dgvFactVent.Name = "dgvFactVent"
        Me.dgvFactVent.Size = New System.Drawing.Size(859, 314)
        Me.dgvFactVent.TabIndex = 44
        '
        'tabInvGen
        '
        Me.tabInvGen.Controls.Add(Me.cmbInvGen)
        Me.tabInvGen.Controls.Add(Me.btnEliminarInvGen)
        Me.tabInvGen.Controls.Add(Me.btnEnviarInvGen)
        Me.tabInvGen.Controls.Add(Me.dgvInvGen)
        Me.tabInvGen.Location = New System.Drawing.Point(4, 23)
        Me.tabInvGen.Name = "tabInvGen"
        Me.tabInvGen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInvGen.Size = New System.Drawing.Size(859, 357)
        Me.tabInvGen.TabIndex = 6
        Me.tabInvGen.Text = "TInventarioGeneral"
        Me.tabInvGen.UseVisualStyleBackColor = True
        '
        'cmbInvGen
        '
        Me.cmbInvGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvGen.FormattingEnabled = True
        Me.cmbInvGen.Location = New System.Drawing.Point(529, 325)
        Me.cmbInvGen.Name = "cmbInvGen"
        Me.cmbInvGen.Size = New System.Drawing.Size(168, 22)
        Me.cmbInvGen.TabIndex = 51
        '
        'btnEliminarInvGen
        '
        Me.btnEliminarInvGen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarInvGen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarInvGen.Location = New System.Drawing.Point(714, 320)
        Me.btnEliminarInvGen.Name = "btnEliminarInvGen"
        Me.btnEliminarInvGen.Size = New System.Drawing.Size(134, 31)
        Me.btnEliminarInvGen.TabIndex = 50
        Me.btnEliminarInvGen.Text = "Eliminar"
        Me.btnEliminarInvGen.UseVisualStyleBackColor = True
        '
        'btnEnviarInvGen
        '
        Me.btnEnviarInvGen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarInvGen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarInvGen.Location = New System.Drawing.Point(8, 320)
        Me.btnEnviarInvGen.Name = "btnEnviarInvGen"
        Me.btnEnviarInvGen.Size = New System.Drawing.Size(134, 31)
        Me.btnEnviarInvGen.TabIndex = 49
        Me.btnEnviarInvGen.Text = "Enviar Modificaciones"
        Me.btnEnviarInvGen.UseVisualStyleBackColor = True
        '
        'dgvInvGen
        '
        Me.dgvInvGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvGen.Location = New System.Drawing.Point(0, 0)
        Me.dgvInvGen.Name = "dgvInvGen"
        Me.dgvInvGen.Size = New System.Drawing.Size(859, 314)
        Me.dgvInvGen.TabIndex = 48
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.BaseDeDatosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 37
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
        Me.Status.Location = New System.Drawing.Point(0, 519)
        Me.Status.Name = "Status"
        Me.Status.ShowItemToolTips = True
        Me.Status.Size = New System.Drawing.Size(864, 22)
        Me.Status.TabIndex = 38
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
        'pgb
        '
        Me.pgb.Location = New System.Drawing.Point(12, 485)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(648, 18)
        Me.pgb.TabIndex = 39
        Me.pgb.Visible = False
        '
        'baseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(864, 541)
        Me.Controls.Add(Me.pgb)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabCtrl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "baseDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base de Datos"
        Me.TabCtrl.ResumeLayout(False)
        Me.tabUsuario.ResumeLayout(False)
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProducto.ResumeLayout(False)
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInvCompr.ResumeLayout(False)
        CType(Me.dgvInvCompr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFactCompr.ResumeLayout(False)
        CType(Me.dgvFactCompr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInvVent.ResumeLayout(False)
        CType(Me.dgvInvVent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFactVent.ResumeLayout(False)
        CType(Me.dgvFactVent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInvGen.ResumeLayout(False)
        CType(Me.dgvInvGen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabCtrl As System.Windows.Forms.TabControl
    Friend WithEvents tabUsuario As System.Windows.Forms.TabPage
    Friend WithEvents tabProducto As System.Windows.Forms.TabPage
    Friend WithEvents btnEnviarUsuario As System.Windows.Forms.Button
    Friend WithEvents dgvUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents EliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarProducto As System.Windows.Forms.Button
    Friend WithEvents btnEnviarProducto As System.Windows.Forms.Button
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents tabInvCompr As System.Windows.Forms.TabPage
    Friend WithEvents cmbInvCompr As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarInvCompr As System.Windows.Forms.Button
    Friend WithEvents btnEnviarInvCompr As System.Windows.Forms.Button
    Friend WithEvents dgvInvCompr As System.Windows.Forms.DataGridView
    Friend WithEvents tabFactCompr As System.Windows.Forms.TabPage
    Friend WithEvents cmbFactCompr As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarFactCompr As System.Windows.Forms.Button
    Friend WithEvents btnEnviarFactCompr As System.Windows.Forms.Button
    Friend WithEvents dgvFactCompr As System.Windows.Forms.DataGridView
    Friend WithEvents tabInvVent As System.Windows.Forms.TabPage
    Friend WithEvents cmbInvVent As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarInvVent As System.Windows.Forms.Button
    Friend WithEvents btnEnviarInvVent As System.Windows.Forms.Button
    Friend WithEvents dgvInvVent As System.Windows.Forms.DataGridView
    Friend WithEvents tabFactVent As System.Windows.Forms.TabPage
    Friend WithEvents cmbFactVent As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarFactVent As System.Windows.Forms.Button
    Friend WithEvents btnEnviarFactVent As System.Windows.Forms.Button
    Friend WithEvents dgvFactVent As System.Windows.Forms.DataGridView
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
    Friend WithEvents tabInvGen As System.Windows.Forms.TabPage
    Friend WithEvents cmbInvGen As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarInvGen As System.Windows.Forms.Button
    Friend WithEvents btnEnviarInvGen As System.Windows.Forms.Button
    Friend WithEvents dgvInvGen As System.Windows.Forms.DataGridView
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslab As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pgb As System.Windows.Forms.ProgressBar
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManejarBaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
