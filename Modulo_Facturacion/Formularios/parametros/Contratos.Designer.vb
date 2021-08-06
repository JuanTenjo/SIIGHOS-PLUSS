<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contratos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contratos))
        Me.txtIdContrato = New System.Windows.Forms.TextBox()
        Me.cboNombreContratante = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoDocuContrato = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumeroContrato = New System.Windows.Forms.TextBox()
        Me.cboVigencia = New System.Windows.Forms.ComboBox()
        Me.cboTipoContrato = New System.Windows.Forms.ComboBox()
        Me.txtNumeroDePagos = New System.Windows.Forms.TextBox()
        Me.cboVigente = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt0bjetoContrato = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtValorSinIva = New System.Windows.Forms.TextBox()
        Me.txtValorIva = New System.Windows.Forms.TextBox()
        Me.txtValorPazYSalvo = New System.Windows.Forms.TextBox()
        Me.txtValorLegalizacion = New System.Windows.Forms.TextBox()
        Me.txtVisitasMes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboExigePoliza = New System.Windows.Forms.ComboBox()
        Me.PanelPoliza = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNombreEntidadPoliza = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cboTipoDocuRepresentante = New System.Windows.Forms.ComboBox()
        Me.txtDocumentoRepresentante = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DataGridDetallePolizas = New System.Windows.Forms.DataGridView()
        Me.NumeroDePoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPoliza = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PorcePoli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValCubre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anular_Poliza = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Razon_Anulamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodAnuPol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Anulacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fec_Registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodModi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fech_Modi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridDetalleCuotas = New System.Windows.Forms.DataGridView()
        Me.NumeroDeCouta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotalCouta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPagado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaExpedicionPoliza = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaCotizacion = New System.Windows.Forms.DateTimePicker()
        Me.txtBuscarContratos = New System.Windows.Forms.TextBox()
        Me.cboNombreRepresentanteLegal = New System.Windows.Forms.ComboBox()
        Me.DataGridContratos = New System.Windows.Forms.DataGridView()
        Me.NoContra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipCont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtNumeroPolizas = New System.Windows.Forms.TextBox()
        Me.cboVezPoliza = New System.Windows.Forms.ComboBox()
        Me.txtCodPoliza = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txtPorceIVA = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.ftRegis = New System.Windows.Forms.DateTimePicker()
        Me.ftModi = New System.Windows.Forms.DateTimePicker()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupModi = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblNameRegisPor = New System.Windows.Forms.Label()
        Me.lblCodiRegisPor = New System.Windows.Forms.Label()
        Me.lblNameModiPor = New System.Windows.Forms.Label()
        Me.lblCodiModiPor = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BtnCerrarContratos = New System.Windows.Forms.Button()
        Me.lblCodigoUsuario2 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtDigiVeriContra = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelPoliza.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridDetallePolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDetalleCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupModi.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdContrato
        '
        Me.txtIdContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdContrato.Location = New System.Drawing.Point(4, 30)
        Me.txtIdContrato.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdContrato.Multiline = True
        Me.txtIdContrato.Name = "txtIdContrato"
        Me.txtIdContrato.ReadOnly = True
        Me.txtIdContrato.Size = New System.Drawing.Size(68, 22)
        Me.txtIdContrato.TabIndex = 0
        '
        'cboNombreContratante
        '
        Me.cboNombreContratante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNombreContratante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNombreContratante.DropDownWidth = 500
        Me.cboNombreContratante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNombreContratante.FormattingEnabled = True
        Me.cboNombreContratante.Location = New System.Drawing.Point(77, 30)
        Me.cboNombreContratante.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNombreContratante.Name = "cboNombreContratante"
        Me.cboNombreContratante.Size = New System.Drawing.Size(316, 22)
        Me.cboNombreContratante.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Contra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(76, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Del Contratante"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(402, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TipDoc"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTipoDocuContrato
        '
        Me.cboTipoDocuContrato.BackColor = System.Drawing.Color.White
        Me.cboTipoDocuContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocuContrato.FormattingEnabled = True
        Me.cboTipoDocuContrato.Location = New System.Drawing.Point(403, 29)
        Me.cboTipoDocuContrato.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoDocuContrato.Name = "cboTipoDocuContrato"
        Me.cboTipoDocuContrato.Size = New System.Drawing.Size(57, 22)
        Me.cboTipoDocuContrato.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 25)
        Me.Panel1.TabIndex = 5
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(559, 0)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(34, 25)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "DV"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(667, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Lista Contratos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(598, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sucur"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(463, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Documento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(464, 29)
        Me.txtNumeroDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDocumento.MaxLength = 13
        Me.txtNumeroDocumento.Multiline = True
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(89, 22)
        Me.txtNumeroDocumento.TabIndex = 6
        '
        'txtSucursal
        '
        Me.txtSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Location = New System.Drawing.Point(600, 29)
        Me.txtSucursal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucursal.MaxLength = 3
        Me.txtSucursal.Multiline = True
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(50, 22)
        Me.txtSucursal.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(1, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(658, 25)
        Me.Panel2.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(590, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 25)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Vigente"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(387, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Fecha Final"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(481, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cuotas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(82, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 25)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Vigencia"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(289, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Fecha Inicial"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(151, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tipo De Contrato"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Contrato N°"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroContrato.Location = New System.Drawing.Point(4, 90)
        Me.txtNumeroContrato.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.Size = New System.Drawing.Size(76, 22)
        Me.txtNumeroContrato.TabIndex = 9
        '
        'cboVigencia
        '
        Me.cboVigencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVigencia.FormattingEnabled = True
        Me.cboVigencia.Location = New System.Drawing.Point(83, 90)
        Me.cboVigencia.Margin = New System.Windows.Forms.Padding(2)
        Me.cboVigencia.Name = "cboVigencia"
        Me.cboVigencia.Size = New System.Drawing.Size(63, 22)
        Me.cboVigencia.TabIndex = 10
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.DropDownWidth = 200
        Me.cboTipoContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoContrato.FormattingEnabled = True
        Me.cboTipoContrato.Location = New System.Drawing.Point(152, 90)
        Me.cboTipoContrato.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Size = New System.Drawing.Size(132, 22)
        Me.cboTipoContrato.TabIndex = 11
        '
        'txtNumeroDePagos
        '
        Me.txtNumeroDePagos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDePagos.Location = New System.Drawing.Point(482, 90)
        Me.txtNumeroDePagos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDePagos.Name = "txtNumeroDePagos"
        Me.txtNumeroDePagos.Size = New System.Drawing.Size(99, 22)
        Me.txtNumeroDePagos.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtNumeroDePagos, "Presiona enter para generar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "las cuotas.")
        '
        'cboVigente
        '
        Me.cboVigente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVigente.FormattingEnabled = True
        Me.cboVigente.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboVigente.Location = New System.Drawing.Point(592, 90)
        Me.cboVigente.Margin = New System.Windows.Forms.Padding(2)
        Me.cboVigente.Name = "cboVigente"
        Me.cboVigente.Size = New System.Drawing.Size(60, 22)
        Me.cboVigente.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1, 122)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 41)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Objeto del contrato"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt0bjetoContrato
        '
        Me.txt0bjetoContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt0bjetoContrato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt0bjetoContrato.Location = New System.Drawing.Point(122, 122)
        Me.txt0bjetoContrato.Margin = New System.Windows.Forms.Padding(2)
        Me.txt0bjetoContrato.Multiline = True
        Me.txt0bjetoContrato.Name = "txt0bjetoContrato"
        Me.txt0bjetoContrato.Size = New System.Drawing.Size(537, 41)
        Me.txt0bjetoContrato.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Location = New System.Drawing.Point(1, 167)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(658, 25)
        Me.Panel4.TabIndex = 15
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(95, 0)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 25)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "%IVA"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(548, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 25)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Fecha Cotización"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(463, 0)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 25)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Valor Total"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(153, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 25)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Valor IVA"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(346, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 25)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Estampillas"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(231, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 25)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Paz y Salvo"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(4, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 25)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Valor Sin IVA"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtValorSinIva
        '
        Me.txtValorSinIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorSinIva.Location = New System.Drawing.Point(4, 197)
        Me.txtValorSinIva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorSinIva.Name = "txtValorSinIva"
        Me.txtValorSinIva.Size = New System.Drawing.Size(88, 22)
        Me.txtValorSinIva.TabIndex = 18
        Me.txtValorSinIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorIva
        '
        Me.txtValorIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorIva.Location = New System.Drawing.Point(154, 197)
        Me.txtValorIva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorIva.MaxLength = 2
        Me.txtValorIva.Name = "txtValorIva"
        Me.txtValorIva.ReadOnly = True
        Me.txtValorIva.Size = New System.Drawing.Size(63, 22)
        Me.txtValorIva.TabIndex = 19
        Me.txtValorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorPazYSalvo
        '
        Me.txtValorPazYSalvo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPazYSalvo.Location = New System.Drawing.Point(232, 197)
        Me.txtValorPazYSalvo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorPazYSalvo.Name = "txtValorPazYSalvo"
        Me.txtValorPazYSalvo.Size = New System.Drawing.Size(96, 22)
        Me.txtValorPazYSalvo.TabIndex = 20
        Me.txtValorPazYSalvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorLegalizacion
        '
        Me.txtValorLegalizacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLegalizacion.Location = New System.Drawing.Point(347, 197)
        Me.txtValorLegalizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorLegalizacion.Name = "txtValorLegalizacion"
        Me.txtValorLegalizacion.Size = New System.Drawing.Size(103, 22)
        Me.txtValorLegalizacion.TabIndex = 21
        Me.txtValorLegalizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVisitasMes
        '
        Me.txtVisitasMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitasMes.Location = New System.Drawing.Point(400, 315)
        Me.txtVisitasMes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVisitasMes.Name = "txtVisitasMes"
        Me.txtVisitasMes.Size = New System.Drawing.Size(85, 22)
        Me.txtVisitasMes.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(1, 226)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 25)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "¿Exige Poliza?"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboExigePoliza
        '
        Me.cboExigePoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExigePoliza.FormattingEnabled = True
        Me.cboExigePoliza.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboExigePoliza.Location = New System.Drawing.Point(4, 256)
        Me.cboExigePoliza.Margin = New System.Windows.Forms.Padding(2)
        Me.cboExigePoliza.Name = "cboExigePoliza"
        Me.cboExigePoliza.Size = New System.Drawing.Size(88, 22)
        Me.cboExigePoliza.TabIndex = 23
        '
        'PanelPoliza
        '
        Me.PanelPoliza.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelPoliza.Controls.Add(Me.Label32)
        Me.PanelPoliza.Controls.Add(Me.Label31)
        Me.PanelPoliza.Controls.Add(Me.Label17)
        Me.PanelPoliza.Controls.Add(Me.Label30)
        Me.PanelPoliza.Controls.Add(Me.Label15)
        Me.PanelPoliza.Location = New System.Drawing.Point(104, 226)
        Me.PanelPoliza.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPoliza.Name = "PanelPoliza"
        Me.PanelPoliza.Size = New System.Drawing.Size(556, 25)
        Me.PanelPoliza.TabIndex = 17
        Me.PanelPoliza.Visible = False
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(472, 1)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 25)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Cod Poliza"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(372, 0)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 25)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Vez Poliza"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(155, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 25)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Expedicion Poliza"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(297, 0)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(62, 25)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Amparos"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(13, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 25)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Entidad Poliza"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreEntidadPoliza
        '
        Me.txtNombreEntidadPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEntidadPoliza.Location = New System.Drawing.Point(116, 256)
        Me.txtNombreEntidadPoliza.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEntidadPoliza.Name = "txtNombreEntidadPoliza"
        Me.txtNombreEntidadPoliza.Size = New System.Drawing.Size(122, 22)
        Me.txtNombreEntidadPoliza.TabIndex = 24
        Me.txtNombreEntidadPoliza.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.Label27)
        Me.Panel7.Controls.Add(Me.Label25)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Location = New System.Drawing.Point(1, 284)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(658, 25)
        Me.Panel7.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(199, 0)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(188, 25)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Representante Legal"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(399, 1)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 22)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Visitas Mes"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(79, 0)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 25)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Documento"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(3, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 25)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "TipDocu"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTipoDocuRepresentante
        '
        Me.cboTipoDocuRepresentante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocuRepresentante.Enabled = False
        Me.cboTipoDocuRepresentante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocuRepresentante.FormattingEnabled = True
        Me.cboTipoDocuRepresentante.Location = New System.Drawing.Point(4, 315)
        Me.cboTipoDocuRepresentante.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoDocuRepresentante.Name = "cboTipoDocuRepresentante"
        Me.cboTipoDocuRepresentante.Size = New System.Drawing.Size(62, 22)
        Me.cboTipoDocuRepresentante.TabIndex = 27
        '
        'txtDocumentoRepresentante
        '
        Me.txtDocumentoRepresentante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoRepresentante.Location = New System.Drawing.Point(80, 315)
        Me.txtDocumentoRepresentante.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumentoRepresentante.Multiline = True
        Me.txtDocumentoRepresentante.Name = "txtDocumentoRepresentante"
        Me.txtDocumentoRepresentante.ReadOnly = True
        Me.txtDocumentoRepresentante.Size = New System.Drawing.Size(104, 22)
        Me.txtDocumentoRepresentante.TabIndex = 28
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel8.Controls.Add(Me.Label29)
        Me.Panel8.Location = New System.Drawing.Point(10, 348)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(308, 25)
        Me.Panel8.TabIndex = 19
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(74, 6)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(160, 14)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Detalle Polizas Contratos"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Location = New System.Drawing.Point(323, 348)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(336, 25)
        Me.Panel9.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(104, 6)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(162, 14)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "Detalle Cuotas Contratos"
        '
        'DataGridDetallePolizas
        '
        Me.DataGridDetallePolizas.AllowUserToAddRows = False
        Me.DataGridDetallePolizas.AllowUserToResizeRows = False
        Me.DataGridDetallePolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridDetallePolizas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridDetallePolizas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridDetallePolizas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDetallePolizas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridDetallePolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetallePolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDePoliza, Me.TipoPoliza, Me.PorcePoli, Me.ValCubre, Me.Fecha_Inicio, Me.Fecha_Final, Me.Anular_Poliza, Me.Razon_Anulamiento, Me.CodAnuPol, Me.Fecha_Anulacion, Me.CodRegistro, Me.Fec_Registro, Me.CodModi, Me.Fech_Modi})
        Me.DataGridDetallePolizas.GridColor = System.Drawing.Color.Black
        Me.DataGridDetallePolizas.Location = New System.Drawing.Point(10, 378)
        Me.DataGridDetallePolizas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridDetallePolizas.Name = "DataGridDetallePolizas"
        Me.DataGridDetallePolizas.RowHeadersWidth = 51
        Me.DataGridDetallePolizas.RowTemplate.Height = 24
        Me.DataGridDetallePolizas.Size = New System.Drawing.Size(308, 157)
        Me.DataGridDetallePolizas.TabIndex = 30
        '
        'NumeroDePoliza
        '
        Me.NumeroDePoliza.HeaderText = "#"
        Me.NumeroDePoliza.MinimumWidth = 6
        Me.NumeroDePoliza.Name = "NumeroDePoliza"
        Me.NumeroDePoliza.ReadOnly = True
        Me.NumeroDePoliza.Width = 39
        '
        'TipoPoliza
        '
        Me.TipoPoliza.HeaderText = "TipoPoliza"
        Me.TipoPoliza.MinimumWidth = 6
        Me.TipoPoliza.Name = "TipoPoliza"
        Me.TipoPoliza.Width = 62
        '
        'PorcePoli
        '
        Me.PorcePoli.HeaderText = "PorcePoli"
        Me.PorcePoli.MaxInputLength = 4
        Me.PorcePoli.MinimumWidth = 6
        Me.PorcePoli.Name = "PorcePoli"
        Me.PorcePoli.Width = 77
        '
        'ValCubre
        '
        Me.ValCubre.HeaderText = "ValCubre"
        Me.ValCubre.MinimumWidth = 6
        Me.ValCubre.Name = "ValCubre"
        Me.ValCubre.Width = 75
        '
        'Fecha_Inicio
        '
        Me.Fecha_Inicio.HeaderText = "Fecha_Inicio"
        Me.Fecha_Inicio.MinimumWidth = 6
        Me.Fecha_Inicio.Name = "Fecha_Inicio"
        Me.Fecha_Inicio.Width = 93
        '
        'Fecha_Final
        '
        Me.Fecha_Final.HeaderText = "Fecha_Final"
        Me.Fecha_Final.MinimumWidth = 6
        Me.Fecha_Final.Name = "Fecha_Final"
        Me.Fecha_Final.Width = 90
        '
        'Anular_Poliza
        '
        Me.Anular_Poliza.HeaderText = "Anular_Poliza"
        Me.Anular_Poliza.MinimumWidth = 6
        Me.Anular_Poliza.Name = "Anular_Poliza"
        Me.Anular_Poliza.Width = 77
        '
        'Razon_Anulamiento
        '
        Me.Razon_Anulamiento.HeaderText = "Razon_Anulamiento"
        Me.Razon_Anulamiento.MinimumWidth = 6
        Me.Razon_Anulamiento.Name = "Razon_Anulamiento"
        Me.Razon_Anulamiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Razon_Anulamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Razon_Anulamiento.Width = 108
        '
        'CodAnuPol
        '
        Me.CodAnuPol.HeaderText = "CodAnuPol"
        Me.CodAnuPol.MaxInputLength = 3
        Me.CodAnuPol.MinimumWidth = 6
        Me.CodAnuPol.Name = "CodAnuPol"
        Me.CodAnuPol.ReadOnly = True
        Me.CodAnuPol.Width = 85
        '
        'Fecha_Anulacion
        '
        Me.Fecha_Anulacion.HeaderText = "Fecha_Anulacion"
        Me.Fecha_Anulacion.MinimumWidth = 6
        Me.Fecha_Anulacion.Name = "Fecha_Anulacion"
        Me.Fecha_Anulacion.ReadOnly = True
        Me.Fecha_Anulacion.Width = 115
        '
        'CodRegistro
        '
        Me.CodRegistro.HeaderText = "CodRegistro"
        Me.CodRegistro.MaxInputLength = 3
        Me.CodRegistro.MinimumWidth = 6
        Me.CodRegistro.Name = "CodRegistro"
        Me.CodRegistro.ReadOnly = True
        Me.CodRegistro.Width = 90
        '
        'Fec_Registro
        '
        Me.Fec_Registro.HeaderText = "Fec_Registro"
        Me.Fec_Registro.MinimumWidth = 6
        Me.Fec_Registro.Name = "Fec_Registro"
        Me.Fec_Registro.ReadOnly = True
        Me.Fec_Registro.Width = 95
        '
        'CodModi
        '
        Me.CodModi.HeaderText = "CodModi"
        Me.CodModi.MaxInputLength = 3
        Me.CodModi.MinimumWidth = 6
        Me.CodModi.Name = "CodModi"
        Me.CodModi.ReadOnly = True
        Me.CodModi.Width = 74
        '
        'Fech_Modi
        '
        Me.Fech_Modi.HeaderText = "Fech_Modi"
        Me.Fech_Modi.MinimumWidth = 6
        Me.Fech_Modi.Name = "Fech_Modi"
        Me.Fech_Modi.ReadOnly = True
        Me.Fech_Modi.Width = 85
        '
        'DataGridDetalleCuotas
        '
        Me.DataGridDetalleCuotas.AllowUserToAddRows = False
        Me.DataGridDetalleCuotas.AllowUserToDeleteRows = False
        Me.DataGridDetalleCuotas.AllowUserToResizeRows = False
        Me.DataGridDetalleCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridDetalleCuotas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridDetalleCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridDetalleCuotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDetalleCuotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridDetalleCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetalleCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDeCouta, Me.FechaDePago, Me.Porcentage, Me.ValorTotalCouta, Me.EstadoPagado})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridDetalleCuotas.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridDetalleCuotas.Location = New System.Drawing.Point(323, 378)
        Me.DataGridDetalleCuotas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridDetalleCuotas.Name = "DataGridDetalleCuotas"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDetalleCuotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridDetalleCuotas.RowHeadersVisible = False
        Me.DataGridDetalleCuotas.RowHeadersWidth = 51
        Me.DataGridDetalleCuotas.RowTemplate.Height = 24
        Me.DataGridDetalleCuotas.Size = New System.Drawing.Size(340, 157)
        Me.DataGridDetalleCuotas.TabIndex = 31
        '
        'NumeroDeCouta
        '
        Me.NumeroDeCouta.FillWeight = 47.10574!
        Me.NumeroDeCouta.HeaderText = "#"
        Me.NumeroDeCouta.MaxInputLength = 2
        Me.NumeroDeCouta.MinimumWidth = 6
        Me.NumeroDeCouta.Name = "NumeroDeCouta"
        Me.NumeroDeCouta.ReadOnly = True
        '
        'FechaDePago
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaDePago.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDePago.FillWeight = 134.0443!
        Me.FechaDePago.HeaderText = "Fecha"
        Me.FechaDePago.MinimumWidth = 6
        Me.FechaDePago.Name = "FechaDePago"
        '
        'Porcentage
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Porcentage.DefaultCellStyle = DataGridViewCellStyle4
        Me.Porcentage.FillWeight = 50.76142!
        Me.Porcentage.HeaderText = "%"
        Me.Porcentage.MaxInputLength = 7
        Me.Porcentage.MinimumWidth = 6
        Me.Porcentage.Name = "Porcentage"
        '
        'ValorTotalCouta
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ValorTotalCouta.DefaultCellStyle = DataGridViewCellStyle5
        Me.ValorTotalCouta.FillWeight = 134.0443!
        Me.ValorTotalCouta.HeaderText = "Cuota"
        Me.ValorTotalCouta.MaxInputLength = 10
        Me.ValorTotalCouta.MinimumWidth = 6
        Me.ValorTotalCouta.Name = "ValorTotalCouta"
        '
        'EstadoPagado
        '
        Me.EstadoPagado.FillWeight = 134.0443!
        Me.EstadoPagado.HeaderText = "Pagado"
        Me.EstadoPagado.MinimumWidth = 6
        Me.EstadoPagado.Name = "EstadoPagado"
        Me.EstadoPagado.ReadOnly = True
        Me.EstadoPagado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EstadoPagado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DtFechaInicial
        '
        Me.DtFechaInicial.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaInicial.Location = New System.Drawing.Point(290, 90)
        Me.DtFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaInicial.Name = "DtFechaInicial"
        Me.DtFechaInicial.Size = New System.Drawing.Size(84, 20)
        Me.DtFechaInicial.TabIndex = 44
        '
        'DtFechaFinal
        '
        Me.DtFechaFinal.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaFinal.Location = New System.Drawing.Point(388, 90)
        Me.DtFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaFinal.Name = "DtFechaFinal"
        Me.DtFechaFinal.Size = New System.Drawing.Size(84, 20)
        Me.DtFechaFinal.TabIndex = 45
        '
        'DtFechaExpedicionPoliza
        '
        Me.DtFechaExpedicionPoliza.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaExpedicionPoliza.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaExpedicionPoliza.Location = New System.Drawing.Point(259, 256)
        Me.DtFechaExpedicionPoliza.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaExpedicionPoliza.Name = "DtFechaExpedicionPoliza"
        Me.DtFechaExpedicionPoliza.Size = New System.Drawing.Size(128, 20)
        Me.DtFechaExpedicionPoliza.TabIndex = 46
        Me.DtFechaExpedicionPoliza.Visible = False
        '
        'DtFechaCotizacion
        '
        Me.DtFechaCotizacion.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaCotizacion.Location = New System.Drawing.Point(549, 197)
        Me.DtFechaCotizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaCotizacion.Name = "DtFechaCotizacion"
        Me.DtFechaCotizacion.Size = New System.Drawing.Size(105, 20)
        Me.DtFechaCotizacion.TabIndex = 48
        '
        'txtBuscarContratos
        '
        Me.txtBuscarContratos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarContratos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarContratos.Location = New System.Drawing.Point(687, 30)
        Me.txtBuscarContratos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscarContratos.Multiline = True
        Me.txtBuscarContratos.Name = "txtBuscarContratos"
        Me.txtBuscarContratos.Size = New System.Drawing.Size(235, 26)
        Me.txtBuscarContratos.TabIndex = 50
        '
        'cboNombreRepresentanteLegal
        '
        Me.cboNombreRepresentanteLegal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNombreRepresentanteLegal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNombreRepresentanteLegal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNombreRepresentanteLegal.FormattingEnabled = True
        Me.cboNombreRepresentanteLegal.Location = New System.Drawing.Point(200, 315)
        Me.cboNombreRepresentanteLegal.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNombreRepresentanteLegal.Name = "cboNombreRepresentanteLegal"
        Me.cboNombreRepresentanteLegal.Size = New System.Drawing.Size(188, 22)
        Me.cboNombreRepresentanteLegal.TabIndex = 27
        '
        'DataGridContratos
        '
        Me.DataGridContratos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.DataGridContratos.AllowUserToAddRows = False
        Me.DataGridContratos.AllowUserToDeleteRows = False
        Me.DataGridContratos.AllowUserToOrderColumns = True
        Me.DataGridContratos.AllowUserToResizeRows = False
        Me.DataGridContratos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridContratos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridContratos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridContratos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoContra, Me.TipoDoc, Me.NoDoc, Me.RazonSocial, Me.TipCont})
        Me.DataGridContratos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridContratos.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridContratos.EnableHeadersVisualStyles = False
        Me.DataGridContratos.GridColor = System.Drawing.Color.Maroon
        Me.DataGridContratos.Location = New System.Drawing.Point(667, 65)
        Me.DataGridContratos.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridContratos.MultiSelect = False
        Me.DataGridContratos.Name = "DataGridContratos"
        Me.DataGridContratos.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridContratos.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridContratos.RowHeadersVisible = False
        Me.DataGridContratos.RowHeadersWidth = 51
        Me.DataGridContratos.RowTemplate.Height = 24
        Me.DataGridContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridContratos.Size = New System.Drawing.Size(254, 470)
        Me.DataGridContratos.TabIndex = 54
        '
        'NoContra
        '
        Me.NoContra.HeaderText = "No Contra"
        Me.NoContra.Name = "NoContra"
        Me.NoContra.ReadOnly = True
        Me.NoContra.Width = 80
        '
        'TipoDoc
        '
        Me.TipoDoc.HeaderText = "TipoDoc"
        Me.TipoDoc.Name = "TipoDoc"
        Me.TipoDoc.ReadOnly = True
        Me.TipoDoc.Width = 50
        '
        'NoDoc
        '
        Me.NoDoc.HeaderText = "NoDoc"
        Me.NoDoc.Name = "NoDoc"
        Me.NoDoc.ReadOnly = True
        '
        'RazonSocial
        '
        Me.RazonSocial.HeaderText = "Razon Social"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        Me.RazonSocial.Width = 200
        '
        'TipCont
        '
        Me.TipCont.HeaderText = "Tip Contra"
        Me.TipCont.Name = "TipCont"
        Me.TipCont.ReadOnly = True
        Me.TipCont.Width = 150
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(464, 197)
        Me.txtValorTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(78, 22)
        Me.txtValorTotal.TabIndex = 55
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtValorTotal, "Preciona Enter dentro de este campo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para generar el valor total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automaticamente" &
        "")
        '
        'txtNumeroPolizas
        '
        Me.txtNumeroPolizas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPolizas.Location = New System.Drawing.Point(398, 256)
        Me.txtNumeroPolizas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroPolizas.MaxLength = 1
        Me.txtNumeroPolizas.Name = "txtNumeroPolizas"
        Me.txtNumeroPolizas.Size = New System.Drawing.Size(65, 22)
        Me.txtNumeroPolizas.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtNumeroPolizas, "Digita un numero menor o igual a 5 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y presiona enter para generar polizas")
        Me.txtNumeroPolizas.Visible = False
        '
        'cboVezPoliza
        '
        Me.cboVezPoliza.FormattingEnabled = True
        Me.cboVezPoliza.Location = New System.Drawing.Point(476, 256)
        Me.cboVezPoliza.Margin = New System.Windows.Forms.Padding(2)
        Me.cboVezPoliza.Name = "cboVezPoliza"
        Me.cboVezPoliza.Size = New System.Drawing.Size(89, 21)
        Me.cboVezPoliza.TabIndex = 59
        Me.cboVezPoliza.Visible = False
        '
        'txtCodPoliza
        '
        Me.txtCodPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPoliza.Location = New System.Drawing.Point(575, 257)
        Me.txtCodPoliza.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodPoliza.Name = "txtCodPoliza"
        Me.txtCodPoliza.Size = New System.Drawing.Size(72, 22)
        Me.txtCodPoliza.TabIndex = 60
        Me.txtCodPoliza.Visible = False
        '
        'Panel15
        '
        Me.Panel15.BackgroundImage = CType(resources.GetObject("Panel15.BackgroundImage"), System.Drawing.Image)
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel15.Location = New System.Drawing.Point(667, 30)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(20, 25)
        Me.Panel15.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.Panel15, "Busca por el numero de documento del tercero o " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para ser mas espefico por el num" &
        "ero de contrato")
        '
        'txtPorceIVA
        '
        Me.txtPorceIVA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorceIVA.Location = New System.Drawing.Point(98, 197)
        Me.txtPorceIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPorceIVA.MaxLength = 2
        Me.txtPorceIVA.Name = "txtPorceIVA"
        Me.txtPorceIVA.Size = New System.Drawing.Size(23, 22)
        Me.txtPorceIVA.TabIndex = 61
        Me.txtPorceIVA.Text = "19"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(121, 198)
        Me.Label34.Margin = New System.Windows.Forms.Padding(0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(22, 17)
        Me.Label34.TabIndex = 15
        Me.Label34.Text = "%"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(313, 9)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(77, 24)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "Fec Modi"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(4, 9)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(69, 24)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "Modi. Por"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ftRegis
        '
        Me.ftRegis.CalendarFont = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftRegis.Enabled = False
        Me.ftRegis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftRegis.Location = New System.Drawing.Point(393, 40)
        Me.ftRegis.Margin = New System.Windows.Forms.Padding(2)
        Me.ftRegis.Name = "ftRegis"
        Me.ftRegis.Size = New System.Drawing.Size(88, 20)
        Me.ftRegis.TabIndex = 88
        '
        'ftModi
        '
        Me.ftModi.CalendarFont = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftModi.Enabled = False
        Me.ftModi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftModi.Location = New System.Drawing.Point(393, 13)
        Me.ftModi.Margin = New System.Windows.Forms.Padding(2)
        Me.ftModi.Name = "ftModi"
        Me.ftModi.Size = New System.Drawing.Size(88, 20)
        Me.ftModi.TabIndex = 92
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(3, 37)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(69, 25)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Regis. Por"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupModi
        '
        Me.GroupModi.Controls.Add(Me.Label38)
        Me.GroupModi.Controls.Add(Me.Label37)
        Me.GroupModi.Controls.Add(Me.Label35)
        Me.GroupModi.Controls.Add(Me.lblNameRegisPor)
        Me.GroupModi.Controls.Add(Me.ftRegis)
        Me.GroupModi.Controls.Add(Me.Label40)
        Me.GroupModi.Controls.Add(Me.lblCodiRegisPor)
        Me.GroupModi.Controls.Add(Me.lblNameModiPor)
        Me.GroupModi.Controls.Add(Me.lblCodiModiPor)
        Me.GroupModi.Controls.Add(Me.ftModi)
        Me.GroupModi.Location = New System.Drawing.Point(8, 539)
        Me.GroupModi.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupModi.Name = "GroupModi"
        Me.GroupModi.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupModi.Size = New System.Drawing.Size(498, 69)
        Me.GroupModi.TabIndex = 95
        Me.GroupModi.TabStop = False
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(314, 36)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(76, 25)
        Me.Label35.TabIndex = 98
        Me.Label35.Text = "Fec Regis"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNameRegisPor
        '
        Me.lblNameRegisPor.AutoSize = True
        Me.lblNameRegisPor.BackColor = System.Drawing.Color.White
        Me.lblNameRegisPor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRegisPor.ForeColor = System.Drawing.Color.Black
        Me.lblNameRegisPor.Location = New System.Drawing.Point(113, 42)
        Me.lblNameRegisPor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameRegisPor.Name = "lblNameRegisPor"
        Me.lblNameRegisPor.Size = New System.Drawing.Size(32, 17)
        Me.lblNameRegisPor.TabIndex = 97
        Me.lblNameRegisPor.Text = "xxx"
        '
        'lblCodiRegisPor
        '
        Me.lblCodiRegisPor.AutoSize = True
        Me.lblCodiRegisPor.BackColor = System.Drawing.Color.White
        Me.lblCodiRegisPor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiRegisPor.ForeColor = System.Drawing.Color.Black
        Me.lblCodiRegisPor.Location = New System.Drawing.Point(77, 42)
        Me.lblCodiRegisPor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodiRegisPor.Name = "lblCodiRegisPor"
        Me.lblCodiRegisPor.Size = New System.Drawing.Size(32, 17)
        Me.lblCodiRegisPor.TabIndex = 96
        Me.lblCodiRegisPor.Text = "xxx"
        '
        'lblNameModiPor
        '
        Me.lblNameModiPor.AutoSize = True
        Me.lblNameModiPor.BackColor = System.Drawing.Color.White
        Me.lblNameModiPor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameModiPor.ForeColor = System.Drawing.Color.Black
        Me.lblNameModiPor.Location = New System.Drawing.Point(114, 15)
        Me.lblNameModiPor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameModiPor.Name = "lblNameModiPor"
        Me.lblNameModiPor.Size = New System.Drawing.Size(32, 17)
        Me.lblNameModiPor.TabIndex = 96
        Me.lblNameModiPor.Text = "xxx"
        '
        'lblCodiModiPor
        '
        Me.lblCodiModiPor.AutoSize = True
        Me.lblCodiModiPor.BackColor = System.Drawing.Color.White
        Me.lblCodiModiPor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiModiPor.ForeColor = System.Drawing.Color.Black
        Me.lblCodiModiPor.Location = New System.Drawing.Point(77, 15)
        Me.lblCodiModiPor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodiModiPor.Name = "lblCodiModiPor"
        Me.lblCodiModiPor.Size = New System.Drawing.Size(32, 17)
        Me.lblCodiModiPor.TabIndex = 9
        Me.lblCodiModiPor.Text = "xxx"
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReporte.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.Black
        Me.btnReporte.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_imprimir_40
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(545, 611)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporte.Size = New System.Drawing.Size(104, 51)
        Me.btnReporte.TabIndex = 97
        Me.btnReporte.Text = "Imprimir"
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseMnemonic = False
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(196, 610)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGuardar.Size = New System.Drawing.Size(110, 52)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseMnemonic = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExportar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoExportar
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(424, 611)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportar.Size = New System.Drawing.Size(113, 51)
        Me.btnExportar.TabIndex = 41
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseMnemonic = False
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Modulo_Facturacion.My.Resources.Resources.Icon_aÑADIR
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(100, 610)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNuevo.Size = New System.Drawing.Size(88, 53)
        Me.btnNuevo.TabIndex = 38
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseMnemonic = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Modulo_Facturacion.My.Resources.Resources.iconoEliminar
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(312, 611)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEliminar.Size = New System.Drawing.Size(104, 51)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseMnemonic = False
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCerrarContratos
        '
        Me.BtnCerrarContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrarContratos.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarContratos.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrarContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarContratos.Location = New System.Drawing.Point(5, 610)
        Me.BtnCerrarContratos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarContratos.Name = "BtnCerrarContratos"
        Me.BtnCerrarContratos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarContratos.Size = New System.Drawing.Size(88, 53)
        Me.BtnCerrarContratos.TabIndex = 36
        Me.BtnCerrarContratos.Text = "Cerrar"
        Me.BtnCerrarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarContratos.UseMnemonic = False
        Me.BtnCerrarContratos.UseVisualStyleBackColor = True
        '
        'lblCodigoUsuario2
        '
        Me.lblCodigoUsuario2.AutoSize = True
        Me.lblCodigoUsuario2.Location = New System.Drawing.Point(719, 647)
        Me.lblCodigoUsuario2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoUsuario2.Name = "lblCodigoUsuario2"
        Me.lblCodigoUsuario2.Size = New System.Drawing.Size(49, 13)
        Me.lblCodigoUsuario2.TabIndex = 101
        Me.lblCodigoUsuario2.Text = "CODIGO"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(719, 629)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(124, 13)
        Me.lblNombreUsuario.TabIndex = 100
        Me.lblNombreUsuario.Text = "NOMBRE DE USUARIO"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(669, 647)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 13)
        Me.Label42.TabIndex = 99
        Me.Label42.Text = "Codigo:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(667, 629)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 13)
        Me.Label43.TabIndex = 98
        Me.Label43.Text = "Usuario:"
        '
        'txtDigiVeriContra
        '
        Me.txtDigiVeriContra.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiVeriContra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDigiVeriContra.Location = New System.Drawing.Point(560, 29)
        Me.txtDigiVeriContra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiVeriContra.MaxLength = 13
        Me.txtDigiVeriContra.Multiline = True
        Me.txtDigiVeriContra.Name = "txtDigiVeriContra"
        Me.txtDigiVeriContra.ReadOnly = True
        Me.txtDigiVeriContra.Size = New System.Drawing.Size(35, 22)
        Me.txtDigiVeriContra.TabIndex = 102
        '
        'Contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 668)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDigiVeriContra)
        Me.Controls.Add(Me.lblCodigoUsuario2)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.GroupModi)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtPorceIVA)
        Me.Controls.Add(Me.txtCodPoliza)
        Me.Controls.Add(Me.cboVezPoliza)
        Me.Controls.Add(Me.txtNumeroPolizas)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.DataGridContratos)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.txtBuscarContratos)
        Me.Controls.Add(Me.DtFechaCotizacion)
        Me.Controls.Add(Me.DtFechaExpedicionPoliza)
        Me.Controls.Add(Me.DtFechaFinal)
        Me.Controls.Add(Me.DtFechaInicial)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnCerrarContratos)
        Me.Controls.Add(Me.DataGridDetalleCuotas)
        Me.Controls.Add(Me.DataGridDetallePolizas)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.txtDocumentoRepresentante)
        Me.Controls.Add(Me.cboNombreRepresentanteLegal)
        Me.Controls.Add(Me.cboTipoDocuRepresentante)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.txtNombreEntidadPoliza)
        Me.Controls.Add(Me.PanelPoliza)
        Me.Controls.Add(Me.cboExigePoliza)
        Me.Controls.Add(Me.txtVisitasMes)
        Me.Controls.Add(Me.txtValorLegalizacion)
        Me.Controls.Add(Me.txtValorPazYSalvo)
        Me.Controls.Add(Me.txtValorIva)
        Me.Controls.Add(Me.txtValorSinIva)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt0bjetoContrato)
        Me.Controls.Add(Me.cboVigente)
        Me.Controls.Add(Me.txtNumeroDePagos)
        Me.Controls.Add(Me.cboTipoContrato)
        Me.Controls.Add(Me.cboVigencia)
        Me.Controls.Add(Me.txtNumeroContrato)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.txtNumeroDocumento)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboTipoDocuContrato)
        Me.Controls.Add(Me.cboNombreContratante)
        Me.Controls.Add(Me.txtIdContrato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Contratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "'"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelPoliza.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.DataGridDetallePolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDetalleCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupModi.ResumeLayout(False)
        Me.GroupModi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdContrato As TextBox
    Friend WithEvents cboNombreContratante As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTipoDocuContrato As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumeroDocumento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNumeroContrato As TextBox
    Friend WithEvents cboVigencia As ComboBox
    Friend WithEvents cboTipoContrato As ComboBox
    Friend WithEvents txtNumeroDePagos As TextBox
    Friend WithEvents cboVigente As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt0bjetoContrato As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtValorSinIva As TextBox
    Friend WithEvents txtValorIva As TextBox
    Friend WithEvents txtValorPazYSalvo As TextBox
    Friend WithEvents txtValorLegalizacion As TextBox
    Friend WithEvents txtVisitasMes As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cboExigePoliza As ComboBox
    Friend WithEvents PanelPoliza As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNombreEntidadPoliza As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cboTipoDocuRepresentante As ComboBox
    Friend WithEvents txtDocumentoRepresentante As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents DataGridDetallePolizas As DataGridView
    Friend WithEvents DataGridDetalleCuotas As DataGridView
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents BtnCerrarContratos As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents DtFechaInicial As DateTimePicker
    Friend WithEvents DtFechaFinal As DateTimePicker
    Friend WithEvents DtFechaExpedicionPoliza As DateTimePicker
    Friend WithEvents DtFechaCotizacion As DateTimePicker
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtBuscarContratos As TextBox
    Friend WithEvents cboNombreRepresentanteLegal As ComboBox
    Friend WithEvents DataGridContratos As DataGridView
    Friend WithEvents Label27 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtNumeroPolizas As TextBox
    Friend WithEvents cboVezPoliza As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtCodPoliza As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label33 As Label
    Friend WithEvents txtPorceIVA As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents ftRegis As DateTimePicker
    Friend WithEvents ftModi As DateTimePicker
    Friend WithEvents Label40 As Label
    Friend WithEvents GroupModi As GroupBox
    Friend WithEvents btnReporte As Button
    Friend WithEvents lblCodigoUsuario2 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents NumeroDePoliza As DataGridViewTextBoxColumn
    Friend WithEvents TipoPoliza As DataGridViewComboBoxColumn
    Friend WithEvents PorcePoli As DataGridViewTextBoxColumn
    Friend WithEvents ValCubre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Inicio As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Final As DataGridViewTextBoxColumn
    Friend WithEvents Anular_Poliza As DataGridViewCheckBoxColumn
    Friend WithEvents Razon_Anulamiento As DataGridViewTextBoxColumn
    Friend WithEvents CodAnuPol As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Anulacion As DataGridViewTextBoxColumn
    Friend WithEvents CodRegistro As DataGridViewTextBoxColumn
    Friend WithEvents Fec_Registro As DataGridViewTextBoxColumn
    Friend WithEvents CodModi As DataGridViewTextBoxColumn
    Friend WithEvents Fech_Modi As DataGridViewTextBoxColumn
    Friend WithEvents lblCodiModiPor As Label
    Friend WithEvents lblCodiRegisPor As Label
    Friend WithEvents lblNameModiPor As Label
    Friend WithEvents lblNameRegisPor As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtDigiVeriContra As TextBox
    Friend WithEvents NoContra As DataGridViewTextBoxColumn
    Friend WithEvents TipoDoc As DataGridViewTextBoxColumn
    Friend WithEvents NoDoc As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents TipCont As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDeCouta As DataGridViewTextBoxColumn
    Friend WithEvents FechaDePago As DataGridViewTextBoxColumn
    Friend WithEvents Porcentage As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotalCouta As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPagado As DataGridViewCheckBoxColumn
End Class
