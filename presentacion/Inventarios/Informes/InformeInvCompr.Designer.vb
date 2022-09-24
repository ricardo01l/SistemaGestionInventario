<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeInvCompr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeInvCompr))
        Me.btnInfInv = New System.Windows.Forms.Button()
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbIdInv = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbInforme = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtnProd = New System.Windows.Forms.RadioButton()
        Me.rbtnFechas = New System.Windows.Forms.RadioButton()
        Me.rbtnUno = New System.Windows.Forms.RadioButton()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbNombrProd = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInfInv
        '
        Me.btnInfInv.Location = New System.Drawing.Point(30, 360)
        Me.btnInfInv.Name = "btnInfInv"
        Me.btnInfInv.Size = New System.Drawing.Size(108, 38)
        Me.btnInfInv.TabIndex = 0
        Me.btnInfInv.Text = "Generar Informe"
        Me.btnInfInv.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.BaseDeDatosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
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
        Me.Status.Location = New System.Drawing.Point(0, 421)
        Me.Status.Name = "Status"
        Me.Status.ShowItemToolTips = True
        Me.Status.Size = New System.Drawing.Size(864, 22)
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
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(732, 360)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 38)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 15)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Sistema de gestión de inventarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "RAFNIEL TECHNOLOGY, F.P."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbtnProd)
        Me.GroupBox1.Controls.Add(Me.rbtnFechas)
        Me.GroupBox1.Controls.Add(Me.rbtnUno)
        Me.GroupBox1.Controls.Add(Me.rbtnTodos)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 262)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbIdInv)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(219, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 262)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtInicio)
        Me.GroupBox3.Controls.Add(Me.dtFinal)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 262)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Fecha Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Fecha de Inicio"
        '
        'dtInicio
        '
        Me.dtInicio.Enabled = False
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(80, 72)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(125, 20)
        Me.dtInicio.TabIndex = 52
        '
        'dtFinal
        '
        Me.dtFinal.Enabled = False
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(80, 162)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(125, 20)
        Me.dtFinal.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 16)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Id de los registros del inventario"
        '
        'cmbIdInv
        '
        Me.cmbIdInv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdInv.FormattingEnabled = True
        Me.cmbIdInv.Location = New System.Drawing.Point(40, 73)
        Me.cmbIdInv.Name = "cmbIdInv"
        Me.cmbIdInv.Size = New System.Drawing.Size(234, 22)
        Me.cmbIdInv.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cmbInforme)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 141)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Tipo de Informe"
        '
        'cmbInforme
        '
        Me.cmbInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInforme.Enabled = False
        Me.cmbInforme.FormattingEnabled = True
        Me.cmbInforme.Items.AddRange(New Object() {"Toda la información de un elemento", "Toda la información del inventario", "La información del inventario sin las facturas", "La información del inventario sin los productos"})
        Me.cmbInforme.Location = New System.Drawing.Point(40, 78)
        Me.cmbInforme.Name = "cmbInforme"
        Me.cmbInforme.Size = New System.Drawing.Size(234, 22)
        Me.cmbInforme.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 14)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Metodo de Selección del Informe"
        '
        'rbtnProd
        '
        Me.rbtnProd.AutoSize = True
        Me.rbtnProd.Location = New System.Drawing.Point(42, 206)
        Me.rbtnProd.Name = "rbtnProd"
        Me.rbtnProd.Size = New System.Drawing.Size(125, 18)
        Me.rbtnProd.TabIndex = 61
        Me.rbtnProd.Text = "Nombre del Producto"
        Me.rbtnProd.UseVisualStyleBackColor = True
        '
        'rbtnFechas
        '
        Me.rbtnFechas.AutoSize = True
        Me.rbtnFechas.Location = New System.Drawing.Point(42, 152)
        Me.rbtnFechas.Name = "rbtnFechas"
        Me.rbtnFechas.Size = New System.Drawing.Size(120, 18)
        Me.rbtnFechas.TabIndex = 60
        Me.rbtnFechas.Text = "Intervalo de Fechas"
        Me.rbtnFechas.UseVisualStyleBackColor = True
        '
        'rbtnUno
        '
        Me.rbtnUno.AutoSize = True
        Me.rbtnUno.Checked = True
        Me.rbtnUno.Location = New System.Drawing.Point(42, 49)
        Me.rbtnUno.Name = "rbtnUno"
        Me.rbtnUno.Size = New System.Drawing.Size(101, 18)
        Me.rbtnUno.TabIndex = 59
        Me.rbtnUno.TabStop = True
        Me.rbtnUno.Text = "Solo un registro"
        Me.rbtnUno.UseVisualStyleBackColor = True
        '
        'rbtnTodos
        '
        Me.rbtnTodos.AutoSize = True
        Me.rbtnTodos.Location = New System.Drawing.Point(42, 103)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(117, 18)
        Me.rbtnTodos.TabIndex = 58
        Me.rbtnTodos.Text = "Todos los registros"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 14)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Nombre del Producto"
        '
        'cmbNombrProd
        '
        Me.cmbNombrProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombrProd.Enabled = False
        Me.cmbNombrProd.FormattingEnabled = True
        Me.cmbNombrProd.Location = New System.Drawing.Point(178, 376)
        Me.cmbNombrProd.Name = "cmbNombrProd"
        Me.cmbNombrProd.Size = New System.Drawing.Size(180, 22)
        Me.cmbNombrProd.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Sistema de gestión de inventarios"
        '
        'InformeInvCompr
        '
        Me.AcceptButton = Me.btnInfInv
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(864, 443)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbNombrProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnInfInv)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformeInvCompr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Informe del inventario de Compras"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInfInv As System.Windows.Forms.Button
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
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbNombrProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtnProd As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFechas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUno As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbIdInv As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbInforme As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManejarBaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
