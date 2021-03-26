<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaDebito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaDebito))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtNumNotaCredito = New System.Windows.Forms.TextBox()
        Me.btnAnularNotaCredito = New System.Windows.Forms.Button()
        Me.lblCodigoUsuario2 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cboTipoNotaCredito = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txtBuscarFactura = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNotaCredito = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboConceptoDeCorrección = New System.Windows.Forms.ComboBox()
        Me.txtTotalGrillaDetalle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ftHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ftDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridVirewDetalleDeFactura = New System.Windows.Forms.DataGridView()
        Me.ItemNum1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValIVADeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.BtnCerrarContratos = New System.Windows.Forms.Button()
        Me.cboProovedores = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAgregarDetalleNotaDebito = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Observaciones = New System.Windows.Forms.Label()
        Me.Prefi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumRemi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecExpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridVirewDetalleDeFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_imprimir_40
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(588, 366)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnImprimir.Size = New System.Drawing.Size(98, 47)
        Me.btnImprimir.TabIndex = 160
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseMnemonic = False
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtNumNotaCredito
        '
        Me.txtNumNotaCredito.Location = New System.Drawing.Point(735, 65)
        Me.txtNumNotaCredito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumNotaCredito.Name = "txtNumNotaCredito"
        Me.txtNumNotaCredito.ReadOnly = True
        Me.txtNumNotaCredito.Size = New System.Drawing.Size(118, 20)
        Me.txtNumNotaCredito.TabIndex = 159
        Me.txtNumNotaCredito.Visible = False
        '
        'btnAnularNotaCredito
        '
        Me.btnAnularNotaCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnularNotaCredito.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularNotaCredito.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_eliminar_40
        Me.btnAnularNotaCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnularNotaCredito.Location = New System.Drawing.Point(693, 366)
        Me.btnAnularNotaCredito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAnularNotaCredito.Name = "btnAnularNotaCredito"
        Me.btnAnularNotaCredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnularNotaCredito.Size = New System.Drawing.Size(98, 47)
        Me.btnAnularNotaCredito.TabIndex = 158
        Me.btnAnularNotaCredito.Text = "Anular"
        Me.btnAnularNotaCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAnularNotaCredito.UseMnemonic = False
        Me.btnAnularNotaCredito.UseVisualStyleBackColor = True
        Me.btnAnularNotaCredito.Visible = False
        '
        'lblCodigoUsuario2
        '
        Me.lblCodigoUsuario2.AutoSize = True
        Me.lblCodigoUsuario2.Location = New System.Drawing.Point(894, 419)
        Me.lblCodigoUsuario2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoUsuario2.Name = "lblCodigoUsuario2"
        Me.lblCodigoUsuario2.Size = New System.Drawing.Size(49, 13)
        Me.lblCodigoUsuario2.TabIndex = 157
        Me.lblCodigoUsuario2.Text = "CODIGO"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(655, 419)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(124, 13)
        Me.lblNombreUsuario.TabIndex = 156
        Me.lblNombreUsuario.Text = "NOMBRE DE USUARIO"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(849, 419)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 13)
        Me.Label42.TabIndex = 155
        Me.Label42.Text = "Codigo:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(603, 419)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 13)
        Me.Label43.TabIndex = 154
        Me.Label43.Text = "Usuario:"
        '
        'cboTipoNotaCredito
        '
        Me.cboTipoNotaCredito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboTipoNotaCredito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoNotaCredito.BackColor = System.Drawing.Color.White
        Me.cboTipoNotaCredito.DropDownWidth = 250
        Me.cboTipoNotaCredito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoNotaCredito.FormattingEnabled = True
        Me.cboTipoNotaCredito.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboTipoNotaCredito.Location = New System.Drawing.Point(571, 64)
        Me.cboTipoNotaCredito.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoNotaCredito.Name = "cboTipoNotaCredito"
        Me.cboTipoNotaCredito.Size = New System.Drawing.Size(140, 22)
        Me.cboTipoNotaCredito.TabIndex = 153
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoGuardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(483, 366)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGuardar.Size = New System.Drawing.Size(98, 47)
        Me.btnGuardar.TabIndex = 152
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseMnemonic = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackgroundImage = CType(resources.GetObject("Panel15.BackgroundImage"), System.Drawing.Image)
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel15.Location = New System.Drawing.Point(4, 120)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(26, 18)
        Me.Panel15.TabIndex = 151
        '
        'txtBuscarFactura
        '
        Me.txtBuscarFactura.Location = New System.Drawing.Point(34, 120)
        Me.txtBuscarFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscarFactura.Name = "txtBuscarFactura"
        Me.txtBuscarFactura.Size = New System.Drawing.Size(323, 20)
        Me.txtBuscarFactura.TabIndex = 150
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.lblNotaCredito)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(378, 33)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 25)
        Me.Panel2.TabIndex = 137
        '
        'lblNotaCredito
        '
        Me.lblNotaCredito.AutoSize = True
        Me.lblNotaCredito.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaCredito.ForeColor = System.Drawing.Color.White
        Me.lblNotaCredito.Location = New System.Drawing.Point(361, 4)
        Me.lblNotaCredito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotaCredito.Name = "lblNotaCredito"
        Me.lblNotaCredito.Size = New System.Drawing.Size(96, 16)
        Me.lblNotaCredito.TabIndex = 10
        Me.lblNotaCredito.Text = "NumNotaDebito"
        Me.lblNotaCredito.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(209, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo Nota Debito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Concepto de Corrección"
        '
        'cboConceptoDeCorrección
        '
        Me.cboConceptoDeCorrección.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboConceptoDeCorrección.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConceptoDeCorrección.BackColor = System.Drawing.Color.White
        Me.cboConceptoDeCorrección.DropDownWidth = 370
        Me.cboConceptoDeCorrección.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptoDeCorrección.FormattingEnabled = True
        Me.cboConceptoDeCorrección.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboConceptoDeCorrección.Location = New System.Drawing.Point(378, 64)
        Me.cboConceptoDeCorrección.Margin = New System.Windows.Forms.Padding(2)
        Me.cboConceptoDeCorrección.Name = "cboConceptoDeCorrección"
        Me.cboConceptoDeCorrección.Size = New System.Drawing.Size(182, 22)
        Me.cboConceptoDeCorrección.TabIndex = 149
        '
        'txtTotalGrillaDetalle
        '
        Me.txtTotalGrillaDetalle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGrillaDetalle.Location = New System.Drawing.Point(852, 320)
        Me.txtTotalGrillaDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalGrillaDetalle.MaxLength = 3
        Me.txtTotalGrillaDetalle.Multiline = True
        Me.txtTotalGrillaDetalle.Name = "txtTotalGrillaDetalle"
        Me.txtTotalGrillaDetalle.ReadOnly = True
        Me.txtTotalGrillaDetalle.Size = New System.Drawing.Size(86, 24)
        Me.txtTotalGrillaDetalle.TabIndex = 145
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(809, 324)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 14)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "Total:"
        '
        'ftHasta
        '
        Me.ftHasta.CustomFormat = "yyyy-MM-dd"
        Me.ftHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ftHasta.Location = New System.Drawing.Point(248, 94)
        Me.ftHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.ftHasta.Name = "ftHasta"
        Me.ftHasta.Size = New System.Drawing.Size(101, 20)
        Me.ftHasta.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Hasta"
        '
        'ftDesde
        '
        Me.ftDesde.CustomFormat = "yyyy-MM-dd"
        Me.ftDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ftDesde.Location = New System.Drawing.Point(44, 94)
        Me.ftDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.ftDesde.Name = "ftDesde"
        Me.ftDesde.Size = New System.Drawing.Size(101, 20)
        Me.ftDesde.TabIndex = 142
        Me.ftDesde.Value = New Date(2020, 10, 29, 17, 21, 33, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "De"
        '
        'DataGridVirewDetalleDeFactura
        '
        Me.DataGridVirewDetalleDeFactura.AllowUserToAddRows = False
        Me.DataGridVirewDetalleDeFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridVirewDetalleDeFactura.BackgroundColor = System.Drawing.Color.White
        Me.DataGridVirewDetalleDeFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridVirewDetalleDeFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridVirewDetalleDeFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVirewDetalleDeFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNum1, Me.CodProduc, Me.Concepto, Me.Cantidad, Me.ValUnitario, Me.ValIVADeta})
        Me.DataGridVirewDetalleDeFactura.Location = New System.Drawing.Point(378, 94)
        Me.DataGridVirewDetalleDeFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridVirewDetalleDeFactura.Name = "DataGridVirewDetalleDeFactura"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVirewDetalleDeFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridVirewDetalleDeFactura.RowHeadersVisible = False
        Me.DataGridVirewDetalleDeFactura.RowHeadersWidth = 51
        Me.DataGridVirewDetalleDeFactura.RowTemplate.Height = 24
        Me.DataGridVirewDetalleDeFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridVirewDetalleDeFactura.Size = New System.Drawing.Size(560, 188)
        Me.DataGridVirewDetalleDeFactura.TabIndex = 140
        '
        'ItemNum1
        '
        Me.ItemNum1.FillWeight = 51.99229!
        Me.ItemNum1.HeaderText = "ItemNum"
        Me.ItemNum1.MaxInputLength = 5
        Me.ItemNum1.MinimumWidth = 6
        Me.ItemNum1.Name = "ItemNum1"
        '
        'CodProduc
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CodProduc.DefaultCellStyle = DataGridViewCellStyle1
        Me.CodProduc.FillWeight = 98.93101!
        Me.CodProduc.HeaderText = "CodProduc"
        Me.CodProduc.MaxInputLength = 15
        Me.CodProduc.MinimumWidth = 6
        Me.CodProduc.Name = "CodProduc"
        '
        'Concepto
        '
        Me.Concepto.FillWeight = 98.93101!
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.MaxInputLength = 15
        Me.Concepto.MinimumWidth = 6
        Me.Concepto.Name = "Concepto"
        '
        'Cantidad
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.FillWeight = 98.93101!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MaxInputLength = 10
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        '
        'ValUnitario
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValUnitario.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValUnitario.FillWeight = 98.93101!
        Me.ValUnitario.HeaderText = "ValUnitario"
        Me.ValUnitario.MaxInputLength = 50
        Me.ValUnitario.MinimumWidth = 6
        Me.ValUnitario.Name = "ValUnitario"
        Me.ValUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ValIVADeta
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ValIVADeta.DefaultCellStyle = DataGridViewCellStyle4
        Me.ValIVADeta.HeaderText = "ValIVADeta"
        Me.ValIVADeta.MinimumWidth = 6
        Me.ValIVADeta.Name = "ValIVADeta"
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.AllowUserToAddRows = False
        Me.DataGridFacturas.AllowUserToDeleteRows = False
        Me.DataGridFacturas.AllowUserToResizeRows = False
        Me.DataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFacturas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Prefi, Me.NumFac, Me.NumRemi, Me.Contrato, Me.FecExpe, Me.Total})
        Me.DataGridFacturas.Location = New System.Drawing.Point(2, 142)
        Me.DataGridFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridFacturas.MultiSelect = False
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridFacturas.RowHeadersVisible = False
        Me.DataGridFacturas.RowHeadersWidth = 51
        Me.DataGridFacturas.RowTemplate.Height = 24
        Me.DataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFacturas.Size = New System.Drawing.Size(354, 271)
        Me.DataGridFacturas.TabIndex = 139
        '
        'BtnCerrarContratos
        '
        Me.BtnCerrarContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrarContratos.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarContratos.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrarContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarContratos.Location = New System.Drawing.Point(378, 366)
        Me.BtnCerrarContratos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarContratos.Name = "BtnCerrarContratos"
        Me.BtnCerrarContratos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarContratos.Size = New System.Drawing.Size(99, 47)
        Me.BtnCerrarContratos.TabIndex = 138
        Me.BtnCerrarContratos.Text = "Cerrar"
        Me.BtnCerrarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarContratos.UseMnemonic = False
        Me.BtnCerrarContratos.UseVisualStyleBackColor = True
        '
        'cboProovedores
        '
        Me.cboProovedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProovedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProovedores.BackColor = System.Drawing.Color.White
        Me.cboProovedores.DropDownWidth = 300
        Me.cboProovedores.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProovedores.FormattingEnabled = True
        Me.cboProovedores.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboProovedores.Location = New System.Drawing.Point(2, 64)
        Me.cboProovedores.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProovedores.Name = "cboProovedores"
        Me.cboProovedores.Size = New System.Drawing.Size(353, 22)
        Me.cboProovedores.TabIndex = 136
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Location = New System.Drawing.Point(2, 33)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(354, 25)
        Me.Panel6.TabIndex = 135
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(154, 4)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Proovedor"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Teal
        Me.Panel17.Controls.Add(Me.Label11)
        Me.Panel17.Location = New System.Drawing.Point(0, 1)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(948, 25)
        Me.Panel17.TabIndex = 134
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(428, 3)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Nota Debito"
        '
        'btnAgregarDetalleNotaDebito
        '
        Me.btnAgregarDetalleNotaDebito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAgregarDetalleNotaDebito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAgregarDetalleNotaDebito.Location = New System.Drawing.Point(378, 283)
        Me.btnAgregarDetalleNotaDebito.Name = "btnAgregarDetalleNotaDebito"
        Me.btnAgregarDetalleNotaDebito.Size = New System.Drawing.Size(560, 23)
        Me.btnAgregarDetalleNotaDebito.TabIndex = 161
        Me.btnAgregarDetalleNotaDebito.Text = "Agregar Fila"
        Me.btnAgregarDetalleNotaDebito.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(477, 312)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(331, 37)
        Me.txtObservaciones.TabIndex = 163
        '
        'Observaciones
        '
        Me.Observaciones.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Observaciones.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observaciones.ForeColor = System.Drawing.Color.White
        Me.Observaciones.Location = New System.Drawing.Point(378, 312)
        Me.Observaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Size = New System.Drawing.Size(99, 37)
        Me.Observaciones.TabIndex = 162
        Me.Observaciones.Text = "Observaciones"
        Me.Observaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prefi
        '
        Me.Prefi.FillWeight = 52.67251!
        Me.Prefi.HeaderText = "Prefi"
        Me.Prefi.MaxInputLength = 5
        Me.Prefi.MinimumWidth = 6
        Me.Prefi.Name = "Prefi"
        Me.Prefi.ReadOnly = True
        '
        'NumFac
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.NumFac.DefaultCellStyle = DataGridViewCellStyle6
        Me.NumFac.FillWeight = 98.76096!
        Me.NumFac.HeaderText = "NumFac"
        Me.NumFac.MaxInputLength = 15
        Me.NumFac.MinimumWidth = 6
        Me.NumFac.Name = "NumFac"
        Me.NumFac.ReadOnly = True
        '
        'NumRemi
        '
        Me.NumRemi.FillWeight = 98.76096!
        Me.NumRemi.HeaderText = "NumRemi"
        Me.NumRemi.MaxInputLength = 15
        Me.NumRemi.MinimumWidth = 6
        Me.NumRemi.Name = "NumRemi"
        Me.NumRemi.ReadOnly = True
        '
        'Contrato
        '
        Me.Contrato.HeaderText = "Contrato"
        Me.Contrato.MaxInputLength = 15
        Me.Contrato.MinimumWidth = 6
        Me.Contrato.Name = "Contrato"
        Me.Contrato.ReadOnly = True
        '
        'FecExpe
        '
        DataGridViewCellStyle7.NullValue = Nothing
        Me.FecExpe.DefaultCellStyle = DataGridViewCellStyle7
        Me.FecExpe.FillWeight = 98.76096!
        Me.FecExpe.HeaderText = "FecExpe"
        Me.FecExpe.MaxInputLength = 10
        Me.FecExpe.MinimumWidth = 6
        Me.FecExpe.Name = "FecExpe"
        Me.FecExpe.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle8
        Me.Total.FillWeight = 98.76096!
        Me.Total.HeaderText = "Total"
        Me.Total.MaxInputLength = 50
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'NotaDebito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 437)
        Me.Controls.Add(Me.Observaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.btnAgregarDetalleNotaDebito)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtNumNotaCredito)
        Me.Controls.Add(Me.btnAnularNotaCredito)
        Me.Controls.Add(Me.lblCodigoUsuario2)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.cboTipoNotaCredito)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.txtBuscarFactura)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cboConceptoDeCorrección)
        Me.Controls.Add(Me.txtTotalGrillaDetalle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ftHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ftDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridVirewDetalleDeFactura)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.Controls.Add(Me.BtnCerrarContratos)
        Me.Controls.Add(Me.cboProovedores)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotaDebito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotaDebito"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridVirewDetalleDeFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtNumNotaCredito As TextBox
    Friend WithEvents btnAnularNotaCredito As Button
    Friend WithEvents lblCodigoUsuario2 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents cboTipoNotaCredito As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtBuscarFactura As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNotaCredito As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboConceptoDeCorrección As ComboBox
    Friend WithEvents txtTotalGrillaDetalle As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ftHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ftDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridVirewDetalleDeFactura As DataGridView
    Friend WithEvents DataGridFacturas As DataGridView
    Friend WithEvents BtnCerrarContratos As Button
    Friend WithEvents cboProovedores As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAgregarDetalleNotaDebito As Button
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Observaciones As Label
    Friend WithEvents ItemNum1 As DataGridViewTextBoxColumn
    Friend WithEvents CodProduc As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents ValUnitario As DataGridViewTextBoxColumn
    Friend WithEvents ValIVADeta As DataGridViewTextBoxColumn
    Friend WithEvents Prefi As DataGridViewTextBoxColumn
    Friend WithEvents NumFac As DataGridViewTextBoxColumn
    Friend WithEvents NumRemi As DataGridViewTextBoxColumn
    Friend WithEvents Contrato As DataGridViewTextBoxColumn
    Friend WithEvents FecExpe As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
