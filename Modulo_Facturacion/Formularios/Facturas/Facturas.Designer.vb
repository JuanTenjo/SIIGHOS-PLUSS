<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboProvedores = New System.Windows.Forms.ComboBox()
        Me.checkFiltroProve = New System.Windows.Forms.CheckBox()
        Me.cboContratos = New System.Windows.Forms.ComboBox()
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.ftHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ftDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscarFactura = New System.Windows.Forms.TextBox()
        Me.btnImprimeTodas = New System.Windows.Forms.Button()
        Me.btnImpFactura = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChekTodasFacturas = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalFact = New System.Windows.Forms.TextBox()
        Me.TxtTolIva = New System.Windows.Forms.TextBox()
        Me.TxtTolNetoFac = New System.Windows.Forms.TextBox()
        Me.Prefi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumRemi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDContrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecExpFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValNetoFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValIVAFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel17.SuspendLayout()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Teal
        Me.Panel17.Controls.Add(Me.btnCerrar)
        Me.Panel17.Controls.Add(Me.Label11)
        Me.Panel17.Location = New System.Drawing.Point(0, 2)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(542, 41)
        Me.Panel17.TabIndex = 33
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_salida_30
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(2, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(42, 41)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(176, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Reportes de Facturas"
        '
        'cboProvedores
        '
        Me.cboProvedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProvedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProvedores.BackColor = System.Drawing.Color.White
        Me.cboProvedores.DropDownWidth = 400
        Me.cboProvedores.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvedores.FormattingEnabled = True
        Me.cboProvedores.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboProvedores.Location = New System.Drawing.Point(5, 120)
        Me.cboProvedores.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProvedores.Name = "cboProvedores"
        Me.cboProvedores.Size = New System.Drawing.Size(532, 22)
        Me.cboProvedores.TabIndex = 86
        '
        'checkFiltroProve
        '
        Me.checkFiltroProve.AutoSize = True
        Me.checkFiltroProve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkFiltroProve.Location = New System.Drawing.Point(149, 95)
        Me.checkFiltroProve.Margin = New System.Windows.Forms.Padding(2)
        Me.checkFiltroProve.Name = "checkFiltroProve"
        Me.checkFiltroProve.Size = New System.Drawing.Size(125, 17)
        Me.checkFiltroProve.TabIndex = 87
        Me.checkFiltroProve.Text = "Todas por proveedor"
        Me.checkFiltroProve.UseVisualStyleBackColor = True
        '
        'cboContratos
        '
        Me.cboContratos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboContratos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContratos.BackColor = System.Drawing.Color.White
        Me.cboContratos.DropDownWidth = 400
        Me.cboContratos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContratos.FormattingEnabled = True
        Me.cboContratos.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboContratos.Location = New System.Drawing.Point(5, 195)
        Me.cboContratos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboContratos.Name = "cboContratos"
        Me.cboContratos.Size = New System.Drawing.Size(532, 22)
        Me.cboContratos.TabIndex = 88
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.AllowUserToAddRows = False
        Me.DataGridFacturas.AllowUserToDeleteRows = False
        Me.DataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFacturas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Prefi, Me.NumFact, Me.NumRemi, Me.IDContrato, Me.FecExpFac, Me.ValNetoFac, Me.ValIVAFac})
        Me.DataGridFacturas.Location = New System.Drawing.Point(5, 312)
        Me.DataGridFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridFacturas.MultiSelect = False
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridFacturas.RowHeadersVisible = False
        Me.DataGridFacturas.RowHeadersWidth = 51
        Me.DataGridFacturas.RowTemplate.Height = 24
        Me.DataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFacturas.Size = New System.Drawing.Size(532, 271)
        Me.DataGridFacturas.TabIndex = 89
        '
        'ftHasta
        '
        Me.ftHasta.CustomFormat = "yyyy-MM-dd"
        Me.ftHasta.Location = New System.Drawing.Point(337, 263)
        Me.ftHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.ftHasta.Name = "ftHasta"
        Me.ftHasta.Size = New System.Drawing.Size(194, 20)
        Me.ftHasta.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(293, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Hasta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ftDesde
        '
        Me.ftDesde.CustomFormat = "yyyy-MM-dd"
        Me.ftDesde.Location = New System.Drawing.Point(90, 263)
        Me.ftDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.ftDesde.Name = "ftDesde"
        Me.ftDesde.Size = New System.Drawing.Size(199, 20)
        Me.ftDesde.TabIndex = 118
        Me.ftDesde.Value = New Date(2020, 10, 29, 17, 21, 33, 0)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(61, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 18)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Desde"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscarFactura
        '
        Me.txtBuscarFactura.Location = New System.Drawing.Point(42, 287)
        Me.txtBuscarFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscarFactura.Name = "txtBuscarFactura"
        Me.txtBuscarFactura.Size = New System.Drawing.Size(495, 20)
        Me.txtBuscarFactura.TabIndex = 124
        '
        'btnImprimeTodas
        '
        Me.btnImprimeTodas.BackColor = System.Drawing.Color.LightGray
        Me.btnImprimeTodas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimeTodas.FlatAppearance.BorderSize = 0
        Me.btnImprimeTodas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnImprimeTodas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnImprimeTodas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnImprimeTodas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimeTodas.ForeColor = System.Drawing.Color.Black
        Me.btnImprimeTodas.Location = New System.Drawing.Point(5, 614)
        Me.btnImprimeTodas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImprimeTodas.Name = "btnImprimeTodas"
        Me.btnImprimeTodas.Size = New System.Drawing.Size(280, 35)
        Me.btnImprimeTodas.TabIndex = 127
        Me.btnImprimeTodas.Text = "TODAS"
        Me.btnImprimeTodas.UseVisualStyleBackColor = False
        '
        'btnImpFactura
        '
        Me.btnImpFactura.BackColor = System.Drawing.Color.Gray
        Me.btnImpFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImpFactura.FlatAppearance.BorderSize = 0
        Me.btnImpFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnImpFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnImpFactura.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnImpFactura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpFactura.ForeColor = System.Drawing.Color.Black
        Me.btnImpFactura.Location = New System.Drawing.Point(285, 614)
        Me.btnImpFactura.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImpFactura.Name = "btnImpFactura"
        Me.btnImpFactura.Size = New System.Drawing.Size(252, 35)
        Me.btnImpFactura.TabIndex = 128
        Me.btnImpFactura.Text = "SELECCIONADA"
        Me.btnImpFactura.UseVisualStyleBackColor = False
        '
        'Panel15
        '
        Me.Panel15.BackgroundImage = CType(resources.GetObject("Panel15.BackgroundImage"), System.Drawing.Image)
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel15.Location = New System.Drawing.Point(5, 287)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(36, 20)
        Me.Panel15.TabIndex = 125
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 225)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(542, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Facturas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(542, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contratos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChekTodasFacturas
        '
        Me.ChekTodasFacturas.AutoSize = True
        Me.ChekTodasFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChekTodasFacturas.Location = New System.Drawing.Point(293, 95)
        Me.ChekTodasFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.ChekTodasFacturas.Name = "ChekTodasFacturas"
        Me.ChekTodasFacturas.Size = New System.Drawing.Size(113, 17)
        Me.ChekTodasFacturas.TabIndex = 129
        Me.ChekTodasFacturas.Text = "Todas las facturas"
        Me.ChekTodasFacturas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 589)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Total Fact:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotalFact
        '
        Me.TxtTotalFact.Location = New System.Drawing.Point(86, 589)
        Me.TxtTotalFact.Name = "TxtTotalFact"
        Me.TxtTotalFact.ReadOnly = True
        Me.TxtTotalFact.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalFact.TabIndex = 131
        '
        'TxtTolIva
        '
        Me.TxtTolIva.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTolIva.Location = New System.Drawing.Point(442, 590)
        Me.TxtTolIva.Name = "TxtTolIva"
        Me.TxtTolIva.ReadOnly = True
        Me.TxtTolIva.Size = New System.Drawing.Size(93, 21)
        Me.TxtTolIva.TabIndex = 132
        Me.TxtTolIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTolNetoFac
        '
        Me.TxtTolNetoFac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTolNetoFac.Location = New System.Drawing.Point(351, 590)
        Me.TxtTolNetoFac.Name = "TxtTolNetoFac"
        Me.TxtTolNetoFac.ReadOnly = True
        Me.TxtTolNetoFac.Size = New System.Drawing.Size(92, 21)
        Me.TxtTolNetoFac.TabIndex = 133
        Me.TxtTolNetoFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Prefi
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Prefi.DefaultCellStyle = DataGridViewCellStyle17
        Me.Prefi.FillWeight = 51.99229!
        Me.Prefi.HeaderText = "Prefi"
        Me.Prefi.MaxInputLength = 2
        Me.Prefi.MinimumWidth = 6
        Me.Prefi.Name = "Prefi"
        Me.Prefi.ReadOnly = True
        '
        'NumFact
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumFact.DefaultCellStyle = DataGridViewCellStyle18
        Me.NumFact.HeaderText = "NumFact"
        Me.NumFact.MinimumWidth = 6
        Me.NumFact.Name = "NumFact"
        Me.NumFact.ReadOnly = True
        '
        'NumRemi
        '
        DataGridViewCellStyle19.Format = "d"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.NumRemi.DefaultCellStyle = DataGridViewCellStyle19
        Me.NumRemi.FillWeight = 98.93101!
        Me.NumRemi.HeaderText = "NumRemi"
        Me.NumRemi.MinimumWidth = 6
        Me.NumRemi.Name = "NumRemi"
        Me.NumRemi.ReadOnly = True
        '
        'IDContrato
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IDContrato.DefaultCellStyle = DataGridViewCellStyle20
        Me.IDContrato.FillWeight = 98.93101!
        Me.IDContrato.HeaderText = "IDContrato"
        Me.IDContrato.MaxInputLength = 15
        Me.IDContrato.MinimumWidth = 6
        Me.IDContrato.Name = "IDContrato"
        Me.IDContrato.ReadOnly = True
        '
        'FecExpFac
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Format = "d"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.FecExpFac.DefaultCellStyle = DataGridViewCellStyle21
        Me.FecExpFac.FillWeight = 98.93101!
        Me.FecExpFac.HeaderText = "FecExpFac"
        Me.FecExpFac.MaxInputLength = 10
        Me.FecExpFac.MinimumWidth = 6
        Me.FecExpFac.Name = "FecExpFac"
        Me.FecExpFac.ReadOnly = True
        '
        'ValNetoFac
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "C0"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.ValNetoFac.DefaultCellStyle = DataGridViewCellStyle22
        Me.ValNetoFac.FillWeight = 98.93101!
        Me.ValNetoFac.HeaderText = "ValNetoFac"
        Me.ValNetoFac.MinimumWidth = 6
        Me.ValNetoFac.Name = "ValNetoFac"
        Me.ValNetoFac.ReadOnly = True
        Me.ValNetoFac.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ValIVAFac
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "C0"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.ValIVAFac.DefaultCellStyle = DataGridViewCellStyle23
        Me.ValIVAFac.HeaderText = "ValIVAFac"
        Me.ValIVAFac.MinimumWidth = 6
        Me.ValIVAFac.Name = "ValIVAFac"
        Me.ValIVAFac.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(290, 593)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Totales:"
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 654)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTolNetoFac)
        Me.Controls.Add(Me.TxtTolIva)
        Me.Controls.Add(Me.TxtTotalFact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChekTodasFacturas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImpFactura)
        Me.Controls.Add(Me.btnImprimeTodas)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.txtBuscarFactura)
        Me.Controls.Add(Me.ftHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ftDesde)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.Controls.Add(Me.cboContratos)
        Me.Controls.Add(Me.checkFiltroProve)
        Me.Controls.Add(Me.cboProvedores)
        Me.Controls.Add(Me.Panel17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cboProvedores As ComboBox
    Friend WithEvents checkFiltroProve As CheckBox
    Friend WithEvents cboContratos As ComboBox
    Friend WithEvents DataGridFacturas As DataGridView
    Friend WithEvents ftHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ftDesde As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtBuscarFactura As TextBox
    Friend WithEvents btnImprimeTodas As Button
    Friend WithEvents btnImpFactura As Button
    Public WithEvents btnCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChekTodasFacturas As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalFact As TextBox
    Friend WithEvents TxtTolIva As TextBox
    Friend WithEvents TxtTolNetoFac As TextBox
    Friend WithEvents Prefi As DataGridViewTextBoxColumn
    Friend WithEvents NumFact As DataGridViewTextBoxColumn
    Friend WithEvents NumRemi As DataGridViewTextBoxColumn
    Friend WithEvents IDContrato As DataGridViewTextBoxColumn
    Friend WithEvents FecExpFac As DataGridViewTextBoxColumn
    Friend WithEvents ValNetoFac As DataGridViewTextBoxColumn
    Friend WithEvents ValIVAFac As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
