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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Panel5 = New System.Windows.Forms.Panel()
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
        Me.PanelVisitasMes = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtNumeroPolizas = New System.Windows.Forms.TextBox()
        Me.cboVezPoliza = New System.Windows.Forms.ComboBox()
        Me.txtCodPoliza = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPorceIVA = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PanelModiFecha = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.PanelModificar = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtCodRegis = New System.Windows.Forms.TextBox()
        Me.ftRegis = New System.Windows.Forms.DateTimePicker()
        Me.PanelRegisrarFecha = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ftModi = New System.Windows.Forms.DateTimePicker()
        Me.txtCodModi = New System.Windows.Forms.TextBox()
        Me.PanelRegistrar = New System.Windows.Forms.Panel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupModi = New System.Windows.Forms.GroupBox()
        Me.GroupRegis = New System.Windows.Forms.GroupBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.BtnCerrarContratos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelPoliza.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridDetallePolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDetalleCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVisitasMes.SuspendLayout()
        Me.PanelModiFecha.SuspendLayout()
        Me.PanelModificar.SuspendLayout()
        Me.PanelRegisrarFecha.SuspendLayout()
        Me.PanelRegistrar.SuspendLayout()
        Me.GroupModi.SuspendLayout()
        Me.GroupRegis.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdContrato
        '
        Me.txtIdContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdContrato.Location = New System.Drawing.Point(6, 37)
        Me.txtIdContrato.Multiline = True
        Me.txtIdContrato.Name = "txtIdContrato"
        Me.txtIdContrato.ReadOnly = True
        Me.txtIdContrato.Size = New System.Drawing.Size(82, 26)
        Me.txtIdContrato.TabIndex = 0
        '
        'cboNombreContratante
        '
        Me.cboNombreContratante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNombreContratante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNombreContratante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNombreContratante.FormattingEnabled = True
        Me.cboNombreContratante.Location = New System.Drawing.Point(103, 37)
        Me.cboNombreContratante.Name = "cboNombreContratante"
        Me.cboNombreContratante.Size = New System.Drawing.Size(281, 26)
        Me.cboNombreContratante.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID-Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(150, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Del Contratante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(409, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TipoDocu"
        '
        'cboTipoDocuContrato
        '
        Me.cboTipoDocuContrato.BackColor = System.Drawing.Color.White
        Me.cboTipoDocuContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocuContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocuContrato.FormattingEnabled = True
        Me.cboTipoDocuContrato.Location = New System.Drawing.Point(411, 36)
        Me.cboTipoDocuContrato.Name = "cboTipoDocuContrato"
        Me.cboTipoDocuContrato.Size = New System.Drawing.Size(75, 26)
        Me.cboTipoDocuContrato.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1424, 31)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1064, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Lista Contratos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(712, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(517, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero Documento"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(517, 36)
        Me.txtNumeroDocumento.MaxLength = 13
        Me.txtNumeroDocumento.Multiline = True
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(154, 26)
        Me.txtNumeroDocumento.TabIndex = 6
        '
        'txtSucursal
        '
        Me.txtSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Location = New System.Drawing.Point(715, 36)
        Me.txtSucursal.MaxLength = 3
        Me.txtSucursal.Multiline = True
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(58, 26)
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
        Me.Panel2.Location = New System.Drawing.Point(1, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 31)
        Me.Panel2.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(795, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 21)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Vigente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(523, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 21)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Fecha Final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(634, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Numero de pagos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(118, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 21)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Vigencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(392, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Fecha Inicial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(219, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tipo De Contrato"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(5, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Contrato N°"
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroContrato.Location = New System.Drawing.Point(6, 111)
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.Size = New System.Drawing.Size(93, 26)
        Me.txtNumeroContrato.TabIndex = 9
        '
        'cboVigencia
        '
        Me.cboVigencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVigencia.FormattingEnabled = True
        Me.cboVigencia.Location = New System.Drawing.Point(111, 111)
        Me.cboVigencia.Name = "cboVigencia"
        Me.cboVigencia.Size = New System.Drawing.Size(83, 26)
        Me.cboVigencia.TabIndex = 10
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoContrato.FormattingEnabled = True
        Me.cboTipoContrato.Location = New System.Drawing.Point(202, 111)
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Size = New System.Drawing.Size(175, 26)
        Me.cboTipoContrato.TabIndex = 11
        '
        'txtNumeroDePagos
        '
        Me.txtNumeroDePagos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDePagos.Location = New System.Drawing.Point(643, 111)
        Me.txtNumeroDePagos.Name = "txtNumeroDePagos"
        Me.txtNumeroDePagos.Size = New System.Drawing.Size(131, 26)
        Me.txtNumeroDePagos.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtNumeroDePagos, "Presiona enter para generar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "las cuotas.")
        '
        'cboVigente
        '
        Me.cboVigente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVigente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVigente.FormattingEnabled = True
        Me.cboVigente.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboVigente.Location = New System.Drawing.Point(789, 111)
        Me.cboVigente.Name = "cboVigente"
        Me.cboVigente.Size = New System.Drawing.Size(79, 26)
        Me.cboVigente.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(1, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 31)
        Me.Panel3.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(5, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 21)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Objeto del contrato"
        '
        'txt0bjetoContrato
        '
        Me.txt0bjetoContrato.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt0bjetoContrato.Location = New System.Drawing.Point(185, 150)
        Me.txt0bjetoContrato.Multiline = True
        Me.txt0bjetoContrato.Name = "txt0bjetoContrato"
        Me.txt0bjetoContrato.Size = New System.Drawing.Size(486, 31)
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
        Me.Panel4.Location = New System.Drawing.Point(1, 194)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(878, 31)
        Me.Panel4.TabIndex = 15
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(127, 6)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 21)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "%IVA"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(731, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(135, 21)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Fecha Cotización"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(622, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 21)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Valor Total"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(206, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 21)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Valor IVA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(484, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 21)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Estampillas"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(306, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 21)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Valor Paz y Salvo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(5, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 21)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Valor Sin IVA"
        '
        'txtValorSinIva
        '
        Me.txtValorSinIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorSinIva.Location = New System.Drawing.Point(6, 231)
        Me.txtValorSinIva.Name = "txtValorSinIva"
        Me.txtValorSinIva.Size = New System.Drawing.Size(98, 26)
        Me.txtValorSinIva.TabIndex = 18
        '
        'txtValorIva
        '
        Me.txtValorIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorIva.Location = New System.Drawing.Point(205, 231)
        Me.txtValorIva.MaxLength = 2
        Me.txtValorIva.Name = "txtValorIva"
        Me.txtValorIva.Size = New System.Drawing.Size(83, 26)
        Me.txtValorIva.TabIndex = 19
        '
        'txtValorPazYSalvo
        '
        Me.txtValorPazYSalvo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPazYSalvo.Location = New System.Drawing.Point(310, 231)
        Me.txtValorPazYSalvo.Name = "txtValorPazYSalvo"
        Me.txtValorPazYSalvo.Size = New System.Drawing.Size(126, 26)
        Me.txtValorPazYSalvo.TabIndex = 20
        '
        'txtValorLegalizacion
        '
        Me.txtValorLegalizacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLegalizacion.Location = New System.Drawing.Point(463, 231)
        Me.txtValorLegalizacion.Name = "txtValorLegalizacion"
        Me.txtValorLegalizacion.Size = New System.Drawing.Size(136, 26)
        Me.txtValorLegalizacion.TabIndex = 21
        '
        'txtVisitasMes
        '
        Me.txtVisitasMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitasMes.Location = New System.Drawing.Point(788, 156)
        Me.txtVisitasMes.Name = "txtVisitasMes"
        Me.txtVisitasMes.Size = New System.Drawing.Size(90, 26)
        Me.txtVisitasMes.TabIndex = 22
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Location = New System.Drawing.Point(1, 267)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(127, 31)
        Me.Panel5.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(5, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 21)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "¿Exige Poliza?"
        '
        'cboExigePoliza
        '
        Me.cboExigePoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExigePoliza.FormattingEnabled = True
        Me.cboExigePoliza.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboExigePoliza.Location = New System.Drawing.Point(6, 304)
        Me.cboExigePoliza.Name = "cboExigePoliza"
        Me.cboExigePoliza.Size = New System.Drawing.Size(107, 26)
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
        Me.PanelPoliza.Location = New System.Drawing.Point(138, 267)
        Me.PanelPoliza.Name = "PanelPoliza"
        Me.PanelPoliza.Size = New System.Drawing.Size(741, 31)
        Me.PanelPoliza.TabIndex = 17
        Me.PanelPoliza.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(639, 6)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 21)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Cod Poliza"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(513, 6)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(85, 21)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Vez Poliza"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(202, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(186, 21)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Fecha Expedicion Poliza"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(407, 6)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 21)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Amparos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(13, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 21)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Nombre Entidad Poliza"
        '
        'txtNombreEntidadPoliza
        '
        Me.txtNombreEntidadPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEntidadPoliza.Location = New System.Drawing.Point(155, 304)
        Me.txtNombreEntidadPoliza.Name = "txtNombreEntidadPoliza"
        Me.txtNombreEntidadPoliza.Size = New System.Drawing.Size(161, 26)
        Me.txtNombreEntidadPoliza.TabIndex = 24
        Me.txtNombreEntidadPoliza.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.Label25)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Location = New System.Drawing.Point(1, 339)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(878, 31)
        Me.Panel7.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(313, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(163, 21)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Representante Legal"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(101, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(158, 21)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Numero Documento"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(5, 6)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 21)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "TipoDocu"
        '
        'cboTipoDocuRepresentante
        '
        Me.cboTipoDocuRepresentante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocuRepresentante.Enabled = False
        Me.cboTipoDocuRepresentante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocuRepresentante.FormattingEnabled = True
        Me.cboTipoDocuRepresentante.Location = New System.Drawing.Point(6, 376)
        Me.cboTipoDocuRepresentante.Name = "cboTipoDocuRepresentante"
        Me.cboTipoDocuRepresentante.Size = New System.Drawing.Size(82, 26)
        Me.cboTipoDocuRepresentante.TabIndex = 27
        '
        'txtDocumentoRepresentante
        '
        Me.txtDocumentoRepresentante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoRepresentante.Location = New System.Drawing.Point(107, 376)
        Me.txtDocumentoRepresentante.Multiline = True
        Me.txtDocumentoRepresentante.Name = "txtDocumentoRepresentante"
        Me.txtDocumentoRepresentante.ReadOnly = True
        Me.txtDocumentoRepresentante.Size = New System.Drawing.Size(137, 26)
        Me.txtDocumentoRepresentante.TabIndex = 28
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel8.Controls.Add(Me.Label29)
        Me.Panel8.Location = New System.Drawing.Point(14, 417)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(411, 31)
        Me.Panel8.TabIndex = 19
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(98, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(197, 18)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Detalle Polizas Contratos"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Location = New System.Drawing.Point(431, 417)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(448, 31)
        Me.Panel9.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(138, 7)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(194, 18)
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
        Me.DataGridDetallePolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetallePolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDePoliza, Me.TipoPoliza, Me.PorcePoli, Me.ValCubre, Me.Fecha_Inicio, Me.Fecha_Final, Me.Anular_Poliza, Me.Razon_Anulamiento, Me.CodAnuPol, Me.Fecha_Anulacion, Me.CodRegistro, Me.Fec_Registro, Me.CodModi, Me.Fech_Modi})
        Me.DataGridDetallePolizas.GridColor = System.Drawing.Color.Black
        Me.DataGridDetallePolizas.Location = New System.Drawing.Point(14, 454)
        Me.DataGridDetallePolizas.Name = "DataGridDetallePolizas"
        Me.DataGridDetallePolizas.RowTemplate.Height = 24
        Me.DataGridDetallePolizas.Size = New System.Drawing.Size(411, 275)
        Me.DataGridDetallePolizas.TabIndex = 30
        '
        'NumeroDePoliza
        '
        Me.NumeroDePoliza.HeaderText = "#"
        Me.NumeroDePoliza.Name = "NumeroDePoliza"
        Me.NumeroDePoliza.ReadOnly = True
        Me.NumeroDePoliza.Width = 45
        '
        'TipoPoliza
        '
        Me.TipoPoliza.HeaderText = "TipoPoliza"
        Me.TipoPoliza.Name = "TipoPoliza"
        Me.TipoPoliza.Width = 80
        '
        'PorcePoli
        '
        Me.PorcePoli.HeaderText = "PorcePoli"
        Me.PorcePoli.MaxInputLength = 4
        Me.PorcePoli.Name = "PorcePoli"
        Me.PorcePoli.Width = 97
        '
        'ValCubre
        '
        Me.ValCubre.HeaderText = "ValCubre"
        Me.ValCubre.Name = "ValCubre"
        Me.ValCubre.Width = 95
        '
        'Fecha_Inicio
        '
        Me.Fecha_Inicio.HeaderText = "Fecha_Inicio"
        Me.Fecha_Inicio.Name = "Fecha_Inicio"
        Me.Fecha_Inicio.Width = 116
        '
        'Fecha_Final
        '
        Me.Fecha_Final.HeaderText = "Fecha_Final"
        Me.Fecha_Final.Name = "Fecha_Final"
        Me.Fecha_Final.Width = 114
        '
        'Anular_Poliza
        '
        Me.Anular_Poliza.HeaderText = "Anular_Poliza"
        Me.Anular_Poliza.Name = "Anular_Poliza"
        Me.Anular_Poliza.Width = 101
        '
        'Razon_Anulamiento
        '
        Me.Razon_Anulamiento.HeaderText = "Razon_Anulamiento"
        Me.Razon_Anulamiento.Name = "Razon_Anulamiento"
        Me.Razon_Anulamiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Razon_Anulamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Razon_Anulamiento.Width = 141
        '
        'CodAnuPol
        '
        Me.CodAnuPol.HeaderText = "CodAnuPol"
        Me.CodAnuPol.MaxInputLength = 3
        Me.CodAnuPol.Name = "CodAnuPol"
        Me.CodAnuPol.Width = 107
        '
        'Fecha_Anulacion
        '
        Me.Fecha_Anulacion.HeaderText = "Fecha_Anulacion"
        Me.Fecha_Anulacion.Name = "Fecha_Anulacion"
        Me.Fecha_Anulacion.Width = 146
        '
        'CodRegistro
        '
        Me.CodRegistro.HeaderText = "CodRegistro"
        Me.CodRegistro.MaxInputLength = 3
        Me.CodRegistro.Name = "CodRegistro"
        Me.CodRegistro.Width = 115
        '
        'Fec_Registro
        '
        Me.Fec_Registro.HeaderText = "Fec_Registro"
        Me.Fec_Registro.Name = "Fec_Registro"
        Me.Fec_Registro.Width = 121
        '
        'CodModi
        '
        Me.CodModi.HeaderText = "CodModi"
        Me.CodModi.MaxInputLength = 3
        Me.CodModi.Name = "CodModi"
        Me.CodModi.Width = 92
        '
        'Fech_Modi
        '
        Me.Fech_Modi.HeaderText = "Fech_Modi"
        Me.Fech_Modi.Name = "Fech_Modi"
        Me.Fech_Modi.Width = 106
        '
        'DataGridDetalleCuotas
        '
        Me.DataGridDetalleCuotas.AllowUserToAddRows = False
        Me.DataGridDetalleCuotas.AllowUserToDeleteRows = False
        Me.DataGridDetalleCuotas.AllowUserToResizeColumns = False
        Me.DataGridDetalleCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridDetalleCuotas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridDetalleCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridDetalleCuotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridDetalleCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetalleCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDeCouta, Me.FechaDePago, Me.Porcentage, Me.ValorTotalCouta, Me.EstadoPagado})
        Me.DataGridDetalleCuotas.Location = New System.Drawing.Point(431, 454)
        Me.DataGridDetalleCuotas.Name = "DataGridDetalleCuotas"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDetalleCuotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridDetalleCuotas.RowHeadersVisible = False
        Me.DataGridDetalleCuotas.RowTemplate.Height = 24
        Me.DataGridDetalleCuotas.Size = New System.Drawing.Size(454, 278)
        Me.DataGridDetalleCuotas.TabIndex = 31
        '
        'NumeroDeCouta
        '
        Me.NumeroDeCouta.HeaderText = "#"
        Me.NumeroDeCouta.MaxInputLength = 2
        Me.NumeroDeCouta.Name = "NumeroDeCouta"
        Me.NumeroDeCouta.ReadOnly = True
        '
        'FechaDePago
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.FechaDePago.DefaultCellStyle = DataGridViewCellStyle6
        Me.FechaDePago.HeaderText = "Fecha"
        Me.FechaDePago.Name = "FechaDePago"
        '
        'Porcentage
        '
        Me.Porcentage.HeaderText = "%"
        Me.Porcentage.MaxInputLength = 7
        Me.Porcentage.Name = "Porcentage"
        '
        'ValorTotalCouta
        '
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ValorTotalCouta.DefaultCellStyle = DataGridViewCellStyle7
        Me.ValorTotalCouta.HeaderText = "Cuota"
        Me.ValorTotalCouta.MaxInputLength = 10
        Me.ValorTotalCouta.Name = "ValorTotalCouta"
        '
        'EstadoPagado
        '
        Me.EstadoPagado.HeaderText = "Pagado"
        Me.EstadoPagado.Name = "EstadoPagado"
        Me.EstadoPagado.ReadOnly = True
        Me.EstadoPagado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EstadoPagado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DtFechaInicial
        '
        Me.DtFechaInicial.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaInicial.Location = New System.Drawing.Point(387, 111)
        Me.DtFechaInicial.Name = "DtFechaInicial"
        Me.DtFechaInicial.Size = New System.Drawing.Size(111, 22)
        Me.DtFechaInicial.TabIndex = 44
        '
        'DtFechaFinal
        '
        Me.DtFechaFinal.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaFinal.Location = New System.Drawing.Point(517, 111)
        Me.DtFechaFinal.Name = "DtFechaFinal"
        Me.DtFechaFinal.Size = New System.Drawing.Size(111, 22)
        Me.DtFechaFinal.TabIndex = 45
        '
        'DtFechaExpedicionPoliza
        '
        Me.DtFechaExpedicionPoliza.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaExpedicionPoliza.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaExpedicionPoliza.Location = New System.Drawing.Point(345, 304)
        Me.DtFechaExpedicionPoliza.Name = "DtFechaExpedicionPoliza"
        Me.DtFechaExpedicionPoliza.Size = New System.Drawing.Size(169, 22)
        Me.DtFechaExpedicionPoliza.TabIndex = 46
        Me.DtFechaExpedicionPoliza.Visible = False
        '
        'DtFechaCotizacion
        '
        Me.DtFechaCotizacion.CustomFormat = "dd-MM-yyyy"
        Me.DtFechaCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFechaCotizacion.Location = New System.Drawing.Point(739, 231)
        Me.DtFechaCotizacion.Name = "DtFechaCotizacion"
        Me.DtFechaCotizacion.Size = New System.Drawing.Size(120, 22)
        Me.DtFechaCotizacion.TabIndex = 48
        '
        'txtBuscarContratos
        '
        Me.txtBuscarContratos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarContratos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarContratos.Location = New System.Drawing.Point(959, 37)
        Me.txtBuscarContratos.Multiline = True
        Me.txtBuscarContratos.Name = "txtBuscarContratos"
        Me.txtBuscarContratos.Size = New System.Drawing.Size(356, 31)
        Me.txtBuscarContratos.TabIndex = 50
        '
        'cboNombreRepresentanteLegal
        '
        Me.cboNombreRepresentanteLegal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNombreRepresentanteLegal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNombreRepresentanteLegal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNombreRepresentanteLegal.FormattingEnabled = True
        Me.cboNombreRepresentanteLegal.Location = New System.Drawing.Point(273, 376)
        Me.cboNombreRepresentanteLegal.Name = "cboNombreRepresentanteLegal"
        Me.cboNombreRepresentanteLegal.Size = New System.Drawing.Size(249, 26)
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridContratos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridContratos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridContratos.EnableHeadersVisualStyles = False
        Me.DataGridContratos.GridColor = System.Drawing.Color.Maroon
        Me.DataGridContratos.Location = New System.Drawing.Point(919, 74)
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
        Me.DataGridContratos.RowTemplate.Height = 24
        Me.DataGridContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridContratos.Size = New System.Drawing.Size(395, 669)
        Me.DataGridContratos.TabIndex = 54
        '
        'PanelVisitasMes
        '
        Me.PanelVisitasMes.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelVisitasMes.Controls.Add(Me.Label27)
        Me.PanelVisitasMes.Location = New System.Drawing.Point(683, 151)
        Me.PanelVisitasMes.Name = "PanelVisitasMes"
        Me.PanelVisitasMes.Size = New System.Drawing.Size(100, 31)
        Me.PanelVisitasMes.TabIndex = 17
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(5, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(94, 21)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Visitas Mes"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(618, 231)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(102, 26)
        Me.txtValorTotal.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.txtValorTotal, "Preciona Enter dentro de este campo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para generar el valor total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automaticamente" &
        "")
        '
        'txtNumeroPolizas
        '
        Me.txtNumeroPolizas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPolizas.Location = New System.Drawing.Point(549, 304)
        Me.txtNumeroPolizas.MaxLength = 1
        Me.txtNumeroPolizas.Name = "txtNumeroPolizas"
        Me.txtNumeroPolizas.Size = New System.Drawing.Size(58, 26)
        Me.txtNumeroPolizas.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtNumeroPolizas, "Digita un numero menor o igual a 5 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y presiona enter para generar polizas")
        '
        'cboVezPoliza
        '
        Me.cboVezPoliza.FormattingEnabled = True
        Me.cboVezPoliza.Location = New System.Drawing.Point(635, 304)
        Me.cboVezPoliza.Name = "cboVezPoliza"
        Me.cboVezPoliza.Size = New System.Drawing.Size(117, 24)
        Me.cboVezPoliza.TabIndex = 59
        '
        'txtCodPoliza
        '
        Me.txtCodPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPoliza.Location = New System.Drawing.Point(776, 304)
        Me.txtCodPoliza.Name = "txtCodPoliza"
        Me.txtCodPoliza.Size = New System.Drawing.Size(87, 26)
        Me.txtCodPoliza.TabIndex = 60
        '
        'txtPorceIVA
        '
        Me.txtPorceIVA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorceIVA.Location = New System.Drawing.Point(131, 231)
        Me.txtPorceIVA.Name = "txtPorceIVA"
        Me.txtPorceIVA.Size = New System.Drawing.Size(29, 26)
        Me.txtPorceIVA.TabIndex = 61
        Me.txtPorceIVA.Text = "19"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(161, 233)
        Me.Label34.Margin = New System.Windows.Forms.Padding(0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(27, 21)
        Me.Label34.TabIndex = 15
        Me.Label34.Text = "%"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(1279, 847)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 17)
        Me.Label44.TabIndex = 65
        Me.Label44.Text = "xxxx"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(1217, 847)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(56, 17)
        Me.Label45.TabIndex = 64
        Me.Label45.Text = "Codigo:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(1179, 847)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 17)
        Me.Label35.TabIndex = 63
        Me.Label35.Text = "xxxx"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(1112, 847)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(61, 17)
        Me.Label36.TabIndex = 62
        Me.Label36.Text = "Usuario:"
        '
        'PanelModiFecha
        '
        Me.PanelModiFecha.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelModiFecha.Controls.Add(Me.Label37)
        Me.PanelModiFecha.Location = New System.Drawing.Point(229, 13)
        Me.PanelModiFecha.Name = "PanelModiFecha"
        Me.PanelModiFecha.Size = New System.Drawing.Size(113, 31)
        Me.PanelModiFecha.TabIndex = 94
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(6, 5)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(94, 21)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "Fecha Modi"
        '
        'PanelModificar
        '
        Me.PanelModificar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelModificar.Controls.Add(Me.Label38)
        Me.PanelModificar.Location = New System.Drawing.Point(6, 13)
        Me.PanelModificar.Name = "PanelModificar"
        Me.PanelModificar.Size = New System.Drawing.Size(113, 31)
        Me.PanelModificar.TabIndex = 91
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(15, 5)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 21)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "Modi. Por"
        '
        'txtCodRegis
        '
        Me.txtCodRegis.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodRegis.Location = New System.Drawing.Point(125, 13)
        Me.txtCodRegis.Multiline = True
        Me.txtCodRegis.Name = "txtCodRegis"
        Me.txtCodRegis.Size = New System.Drawing.Size(88, 31)
        Me.txtCodRegis.TabIndex = 87
        '
        'ftRegis
        '
        Me.ftRegis.CalendarFont = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftRegis.Location = New System.Drawing.Point(348, 17)
        Me.ftRegis.Name = "ftRegis"
        Me.ftRegis.Size = New System.Drawing.Size(131, 22)
        Me.ftRegis.TabIndex = 88
        '
        'PanelRegisrarFecha
        '
        Me.PanelRegisrarFecha.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelRegisrarFecha.Controls.Add(Me.Label39)
        Me.PanelRegisrarFecha.Location = New System.Drawing.Point(229, 13)
        Me.PanelRegisrarFecha.Name = "PanelRegisrarFecha"
        Me.PanelRegisrarFecha.Size = New System.Drawing.Size(113, 31)
        Me.PanelRegisrarFecha.TabIndex = 93
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(6, 5)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(100, 21)
        Me.Label39.TabIndex = 85
        Me.Label39.Text = "Fecha Regis"
        '
        'ftModi
        '
        Me.ftModi.CalendarFont = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftModi.Location = New System.Drawing.Point(348, 18)
        Me.ftModi.Name = "ftModi"
        Me.ftModi.Size = New System.Drawing.Size(131, 22)
        Me.ftModi.TabIndex = 92
        '
        'txtCodModi
        '
        Me.txtCodModi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodModi.Location = New System.Drawing.Point(125, 13)
        Me.txtCodModi.Multiline = True
        Me.txtCodModi.Name = "txtCodModi"
        Me.txtCodModi.Size = New System.Drawing.Size(88, 31)
        Me.txtCodModi.TabIndex = 89
        '
        'PanelRegistrar
        '
        Me.PanelRegistrar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelRegistrar.Controls.Add(Me.Label40)
        Me.PanelRegistrar.Controls.Add(Me.Label41)
        Me.PanelRegistrar.Location = New System.Drawing.Point(6, 13)
        Me.PanelRegistrar.Name = "PanelRegistrar"
        Me.PanelRegistrar.Size = New System.Drawing.Size(113, 31)
        Me.PanelRegistrar.TabIndex = 90
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(14, 5)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(85, 21)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Regis. Por"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(15, 5)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(78, 21)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "Cod Modi"
        Me.Label41.Visible = False
        '
        'GroupModi
        '
        Me.GroupModi.Controls.Add(Me.PanelModificar)
        Me.GroupModi.Controls.Add(Me.PanelModiFecha)
        Me.GroupModi.Controls.Add(Me.txtCodModi)
        Me.GroupModi.Controls.Add(Me.ftModi)
        Me.GroupModi.Location = New System.Drawing.Point(10, 738)
        Me.GroupModi.Name = "GroupModi"
        Me.GroupModi.Size = New System.Drawing.Size(498, 50)
        Me.GroupModi.TabIndex = 95
        Me.GroupModi.TabStop = False
        '
        'GroupRegis
        '
        Me.GroupRegis.Controls.Add(Me.PanelRegistrar)
        Me.GroupRegis.Controls.Add(Me.PanelRegisrarFecha)
        Me.GroupRegis.Controls.Add(Me.txtCodRegis)
        Me.GroupRegis.Controls.Add(Me.ftRegis)
        Me.GroupRegis.Location = New System.Drawing.Point(10, 738)
        Me.GroupRegis.Name = "GroupRegis"
        Me.GroupRegis.Size = New System.Drawing.Size(498, 50)
        Me.GroupRegis.TabIndex = 96
        Me.GroupRegis.TabStop = False
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReporte.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.Black
        Me.btnReporte.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_imprimir_40
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(866, 802)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporte.Size = New System.Drawing.Size(139, 65)
        Me.btnReporte.TabIndex = 97
        Me.btnReporte.Text = "Imprimir"
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseMnemonic = False
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_grabar_40
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(257, 799)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGrabar.Size = New System.Drawing.Size(133, 67)
        Me.btnGrabar.TabIndex = 53
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrabar.UseMnemonic = False
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackgroundImage = CType(resources.GetObject("Panel15.BackgroundImage"), System.Drawing.Image)
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel15.Location = New System.Drawing.Point(919, 37)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(40, 31)
        Me.Panel15.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.Panel15, "Busca por el numero de documento del tercero o " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para ser mas espefico por el num" &
        "ero de contrato")
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(401, 801)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGuardar.Size = New System.Drawing.Size(146, 66)
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
        Me.btnExportar.Location = New System.Drawing.Point(705, 802)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportar.Size = New System.Drawing.Size(151, 65)
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
        Me.btnNuevo.Location = New System.Drawing.Point(129, 799)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNuevo.Size = New System.Drawing.Size(117, 67)
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
        Me.btnEliminar.Location = New System.Drawing.Point(556, 802)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEliminar.Size = New System.Drawing.Size(139, 65)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "Anular"
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
        Me.BtnCerrarContratos.Location = New System.Drawing.Point(2, 799)
        Me.BtnCerrarContratos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarContratos.Name = "BtnCerrarContratos"
        Me.BtnCerrarContratos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarContratos.Size = New System.Drawing.Size(118, 67)
        Me.BtnCerrarContratos.TabIndex = 36
        Me.BtnCerrarContratos.Text = "Cerrar"
        Me.BtnCerrarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarContratos.UseMnemonic = False
        Me.BtnCerrarContratos.UseVisualStyleBackColor = True
        '
        'Contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 882)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.GroupRegis)
        Me.Controls.Add(Me.GroupModi)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtPorceIVA)
        Me.Controls.Add(Me.txtCodPoliza)
        Me.Controls.Add(Me.cboVezPoliza)
        Me.Controls.Add(Me.txtNumeroPolizas)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.PanelVisitasMes)
        Me.Controls.Add(Me.DataGridContratos)
        Me.Controls.Add(Me.btnGrabar)
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
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtVisitasMes)
        Me.Controls.Add(Me.txtValorLegalizacion)
        Me.Controls.Add(Me.txtValorPazYSalvo)
        Me.Controls.Add(Me.txtValorIva)
        Me.Controls.Add(Me.txtValorSinIva)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt0bjetoContrato)
        Me.Controls.Add(Me.Panel3)
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
        Me.Name = "Contratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "'"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelPoliza.ResumeLayout(False)
        Me.PanelPoliza.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.DataGridDetallePolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDetalleCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVisitasMes.ResumeLayout(False)
        Me.PanelVisitasMes.PerformLayout()
        Me.PanelModiFecha.ResumeLayout(False)
        Me.PanelModiFecha.PerformLayout()
        Me.PanelModificar.ResumeLayout(False)
        Me.PanelModificar.PerformLayout()
        Me.PanelRegisrarFecha.ResumeLayout(False)
        Me.PanelRegisrarFecha.PerformLayout()
        Me.PanelRegistrar.ResumeLayout(False)
        Me.PanelRegistrar.PerformLayout()
        Me.GroupModi.ResumeLayout(False)
        Me.GroupModi.PerformLayout()
        Me.GroupRegis.ResumeLayout(False)
        Me.GroupRegis.PerformLayout()
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
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents Panel5 As Panel
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
    Friend WithEvents btnGrabar As Button
    Friend WithEvents cboNombreRepresentanteLegal As ComboBox
    Friend WithEvents DataGridContratos As DataGridView
    Friend WithEvents PanelVisitasMes As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtNumeroPolizas As TextBox
    Friend WithEvents NumeroDeCouta As DataGridViewTextBoxColumn
    Friend WithEvents FechaDePago As DataGridViewTextBoxColumn
    Friend WithEvents Porcentage As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotalCouta As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPagado As DataGridViewCheckBoxColumn
    Friend WithEvents cboVezPoliza As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtCodPoliza As TextBox
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label33 As Label
    Friend WithEvents txtPorceIVA As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents PanelModiFecha As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents PanelModificar As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents txtCodRegis As TextBox
    Friend WithEvents ftRegis As DateTimePicker
    Friend WithEvents PanelRegisrarFecha As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents ftModi As DateTimePicker
    Friend WithEvents txtCodModi As TextBox
    Friend WithEvents PanelRegistrar As Panel
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents GroupModi As GroupBox
    Friend WithEvents GroupRegis As GroupBox
    Friend WithEvents btnReporte As Button
End Class
