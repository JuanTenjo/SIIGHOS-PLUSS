<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos))
        Me.cboFacturas = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DtFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaVencimeinto = New System.Windows.Forms.DateTimePicker()
        Me.txtTipoDocTer = New System.Windows.Forms.TextBox()
        Me.txtDocuTer = New System.Windows.Forms.TextBox()
        Me.txtRazonSolTer = New System.Windows.Forms.TextBox()
        Me.DtUltimoPago = New System.Windows.Forms.DateTimePicker()
        Me.lblCodigoUsuario2 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtValorGlosado = New System.Windows.Forms.TextBox()
        Me.txtValorCreditos = New System.Windows.Forms.TextBox()
        Me.txtValorDebitos = New System.Windows.Forms.TextBox()
        Me.txtValorImpuestos = New System.Windows.Forms.TextBox()
        Me.txtValorDescuentos = New System.Windows.Forms.TextBox()
        Me.txtValorInteres = New System.Windows.Forms.TextBox()
        Me.txtValorTotalAbonos = New System.Windows.Forms.TextBox()
        Me.txtValorSaldo = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.rbNoCuentasBancarias = New System.Windows.Forms.RadioButton()
        Me.rbSiCuentasBancarias = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SucurBan = New System.Windows.Forms.TextBox()
        Me.DocuBan = New System.Windows.Forms.TextBox()
        Me.TipoDocuBan = New System.Windows.Forms.TextBox()
        Me.cboNumCuenta = New System.Windows.Forms.ComboBox()
        Me.cboBancos = New System.Windows.Forms.ComboBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.FechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DigiBan = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtValorContablePago = New System.Windows.Forms.TextBox()
        Me.txtValorContableInteres = New System.Windows.Forms.TextBox()
        Me.txtValorContableReteIVA = New System.Windows.Forms.TextBox()
        Me.txtValorContableReteICA = New System.Windows.Forms.TextBox()
        Me.txtValorContableReteFuente = New System.Windows.Forms.TextBox()
        Me.txtValorContableRetePagoPor = New System.Windows.Forms.TextBox()
        Me.txtValorContableTramite = New System.Windows.Forms.TextBox()
        Me.txtValorContableOtrosDesc = New System.Windows.Forms.TextBox()
        Me.txtDocuContableOtroDesc = New System.Windows.Forms.TextBox()
        Me.txtDocuContableTramite = New System.Windows.Forms.TextBox()
        Me.txtDocuContablePagoOpor = New System.Windows.Forms.TextBox()
        Me.txtDocuContableReteFuente = New System.Windows.Forms.TextBox()
        Me.txtDocuContableReteIca = New System.Windows.Forms.TextBox()
        Me.txtDocuContableReteIva = New System.Windows.Forms.TextBox()
        Me.txtDocuContableIntereses = New System.Windows.Forms.TextBox()
        Me.txtDocuContablePago = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtDigiContablePago = New System.Windows.Forms.TextBox()
        Me.txtDigiContableInteres = New System.Windows.Forms.TextBox()
        Me.txtDigiContableReteIva = New System.Windows.Forms.TextBox()
        Me.txtDigiContableReteIca = New System.Windows.Forms.TextBox()
        Me.txtDigiContableReteFuente = New System.Windows.Forms.TextBox()
        Me.txtDigiContablePagoOpor = New System.Windows.Forms.TextBox()
        Me.txtDigiContableTramite = New System.Windows.Forms.TextBox()
        Me.txtDigiContableOtrosDesc = New System.Windows.Forms.TextBox()
        Me.cboTipoPago = New System.Windows.Forms.ComboBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.txtCuentaContablePago = New System.Windows.Forms.TextBox()
        Me.txtCuentasInteres = New System.Windows.Forms.TextBox()
        Me.txtCuentaReteIVA = New System.Windows.Forms.TextBox()
        Me.txtCuentasReteIca = New System.Windows.Forms.TextBox()
        Me.txtCuentasReteFuente = New System.Windows.Forms.TextBox()
        Me.txtCuentasPagoOpor = New System.Windows.Forms.TextBox()
        Me.txtCuentasTramite = New System.Windows.Forms.TextBox()
        Me.txtCuentaOtrosDesc = New System.Windows.Forms.TextBox()
        Me.cboContablePagoTipoDocu = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocuInteres = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocuIVA = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocuICA = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocuFuente = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocuPagoOpor = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocuTramite = New System.Windows.Forms.ComboBox()
        Me.cboTIpoDocuDesc = New System.Windows.Forms.ComboBox()
        Me.txtSucurOtrosDesc = New System.Windows.Forms.TextBox()
        Me.txtSucurTramite = New System.Windows.Forms.TextBox()
        Me.txtSucurPagoPor = New System.Windows.Forms.TextBox()
        Me.txtSucurFuente = New System.Windows.Forms.TextBox()
        Me.txtSucurICA = New System.Windows.Forms.TextBox()
        Me.txtSucurIVA = New System.Windows.Forms.TextBox()
        Me.txtSucurInteres = New System.Windows.Forms.TextBox()
        Me.txtSucurContablePago = New System.Windows.Forms.TextBox()
        Me.txtTotalConsignado = New System.Windows.Forms.TextBox()
        Me.txtRemision = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.BtnCerrarContratos = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFacturas
        '
        Me.cboFacturas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboFacturas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFacturas.BackColor = System.Drawing.Color.White
        Me.cboFacturas.DropDownWidth = 100
        Me.cboFacturas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFacturas.FormattingEnabled = True
        Me.cboFacturas.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboFacturas.Location = New System.Drawing.Point(20, 40)
        Me.cboFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFacturas.Name = "cboFacturas"
        Me.cboFacturas.Size = New System.Drawing.Size(101, 22)
        Me.cboFacturas.TabIndex = 86
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel6.Controls.Add(Me.Label45)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Location = New System.Drawing.Point(9, 10)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(855, 25)
        Me.Panel6.TabIndex = 89
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(267, 0)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(57, 25)
        Me.Label45.TabIndex = 19
        Me.Label45.Text = "Sucursal"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(11, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 25)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Factura"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(328, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(341, 25)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Razon Social"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(123, -2)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "TipDocu"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(676, -1)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Remision"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(184, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Documento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(362, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha_Movimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtFechaMovimiento
        '
        Me.DtFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaMovimiento.Location = New System.Drawing.Point(371, 105)
        Me.DtFechaMovimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaMovimiento.Name = "DtFechaMovimiento"
        Me.DtFechaMovimiento.Size = New System.Drawing.Size(121, 20)
        Me.DtFechaMovimiento.TabIndex = 100
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel5.Controls.Add(Me.Label44)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(9, 72)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(855, 25)
        Me.Panel5.TabIndex = 90
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(487, 0)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(117, 25)
        Me.Label44.TabIndex = 19
        Me.Label44.Text = "Tipo de pago"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(257, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 25)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Ultimo Pago"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(132, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 25)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fecha Vencimiento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 25)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Fecha Expedicion"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtFechaExpedicion
        '
        Me.DtFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaExpedicion.Location = New System.Drawing.Point(20, 105)
        Me.DtFechaExpedicion.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaExpedicion.Name = "DtFechaExpedicion"
        Me.DtFechaExpedicion.Size = New System.Drawing.Size(107, 20)
        Me.DtFechaExpedicion.TabIndex = 123
        '
        'DtFechaVencimeinto
        '
        Me.DtFechaVencimeinto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaVencimeinto.Location = New System.Drawing.Point(141, 105)
        Me.DtFechaVencimeinto.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaVencimeinto.Name = "DtFechaVencimeinto"
        Me.DtFechaVencimeinto.Size = New System.Drawing.Size(120, 20)
        Me.DtFechaVencimeinto.TabIndex = 124
        '
        'txtTipoDocTer
        '
        Me.txtTipoDocTer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocTer.Location = New System.Drawing.Point(135, 40)
        Me.txtTipoDocTer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipoDocTer.MaxLength = 15
        Me.txtTipoDocTer.Multiline = True
        Me.txtTipoDocTer.Name = "txtTipoDocTer"
        Me.txtTipoDocTer.Size = New System.Drawing.Size(54, 22)
        Me.txtTipoDocTer.TabIndex = 125
        '
        'txtDocuTer
        '
        Me.txtDocuTer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuTer.Location = New System.Drawing.Point(193, 40)
        Me.txtDocuTer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuTer.MaxLength = 15
        Me.txtDocuTer.Multiline = True
        Me.txtDocuTer.Name = "txtDocuTer"
        Me.txtDocuTer.Size = New System.Drawing.Size(79, 22)
        Me.txtDocuTer.TabIndex = 126
        '
        'txtRazonSolTer
        '
        Me.txtRazonSolTer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSolTer.Location = New System.Drawing.Point(337, 40)
        Me.txtRazonSolTer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRazonSolTer.MaxLength = 15
        Me.txtRazonSolTer.Multiline = True
        Me.txtRazonSolTer.Name = "txtRazonSolTer"
        Me.txtRazonSolTer.Size = New System.Drawing.Size(341, 22)
        Me.txtRazonSolTer.TabIndex = 127
        '
        'DtUltimoPago
        '
        Me.DtUltimoPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtUltimoPago.Location = New System.Drawing.Point(266, 105)
        Me.DtUltimoPago.Margin = New System.Windows.Forms.Padding(2)
        Me.DtUltimoPago.Name = "DtUltimoPago"
        Me.DtUltimoPago.Size = New System.Drawing.Size(97, 20)
        Me.DtUltimoPago.TabIndex = 128
        '
        'lblCodigoUsuario2
        '
        Me.lblCodigoUsuario2.AutoSize = True
        Me.lblCodigoUsuario2.Location = New System.Drawing.Point(237, 509)
        Me.lblCodigoUsuario2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoUsuario2.Name = "lblCodigoUsuario2"
        Me.lblCodigoUsuario2.Size = New System.Drawing.Size(49, 13)
        Me.lblCodigoUsuario2.TabIndex = 137
        Me.lblCodigoUsuario2.Text = "CODIGO"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(58, 509)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(124, 13)
        Me.lblNombreUsuario.TabIndex = 136
        Me.lblNombreUsuario.Text = "NOMBRE DE USUARIO"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(189, 509)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 13)
        Me.Label42.TabIndex = 135
        Me.Label42.Text = "Codigo:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 509)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 13)
        Me.Label43.TabIndex = 134
        Me.Label43.Text = "Usuario:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(11, 138)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 21)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Valores Actuales"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.Label12)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Controls.Add(Me.Label5)
        Me.Panel11.Controls.Add(Me.Label3)
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Controls.Add(Me.Label24)
        Me.Panel11.Location = New System.Drawing.Point(10, 161)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(110, 220)
        Me.Panel11.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(7, 199)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Saldo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 176)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Total Abonos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 151)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Interes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 127)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descuentos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Impuestos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total Debitos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total Creditos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total Glosado:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(7, 5)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 16)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Valor Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(124, 164)
        Me.txtValorTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorTotal.MaxLength = 15
        Me.txtValorTotal.Multiline = True
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(98, 22)
        Me.txtValorTotal.TabIndex = 142
        '
        'txtValorGlosado
        '
        Me.txtValorGlosado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorGlosado.Location = New System.Drawing.Point(124, 188)
        Me.txtValorGlosado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorGlosado.MaxLength = 15
        Me.txtValorGlosado.Multiline = True
        Me.txtValorGlosado.Name = "txtValorGlosado"
        Me.txtValorGlosado.ReadOnly = True
        Me.txtValorGlosado.Size = New System.Drawing.Size(98, 22)
        Me.txtValorGlosado.TabIndex = 143
        '
        'txtValorCreditos
        '
        Me.txtValorCreditos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCreditos.Location = New System.Drawing.Point(124, 213)
        Me.txtValorCreditos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorCreditos.MaxLength = 15
        Me.txtValorCreditos.Multiline = True
        Me.txtValorCreditos.Name = "txtValorCreditos"
        Me.txtValorCreditos.ReadOnly = True
        Me.txtValorCreditos.Size = New System.Drawing.Size(98, 22)
        Me.txtValorCreditos.TabIndex = 144
        '
        'txtValorDebitos
        '
        Me.txtValorDebitos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDebitos.Location = New System.Drawing.Point(124, 237)
        Me.txtValorDebitos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorDebitos.MaxLength = 15
        Me.txtValorDebitos.Multiline = True
        Me.txtValorDebitos.Name = "txtValorDebitos"
        Me.txtValorDebitos.ReadOnly = True
        Me.txtValorDebitos.Size = New System.Drawing.Size(98, 22)
        Me.txtValorDebitos.TabIndex = 145
        '
        'txtValorImpuestos
        '
        Me.txtValorImpuestos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorImpuestos.Location = New System.Drawing.Point(124, 261)
        Me.txtValorImpuestos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorImpuestos.MaxLength = 15
        Me.txtValorImpuestos.Multiline = True
        Me.txtValorImpuestos.Name = "txtValorImpuestos"
        Me.txtValorImpuestos.ReadOnly = True
        Me.txtValorImpuestos.Size = New System.Drawing.Size(98, 22)
        Me.txtValorImpuestos.TabIndex = 146
        '
        'txtValorDescuentos
        '
        Me.txtValorDescuentos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDescuentos.Location = New System.Drawing.Point(124, 286)
        Me.txtValorDescuentos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorDescuentos.MaxLength = 15
        Me.txtValorDescuentos.Multiline = True
        Me.txtValorDescuentos.Name = "txtValorDescuentos"
        Me.txtValorDescuentos.ReadOnly = True
        Me.txtValorDescuentos.Size = New System.Drawing.Size(98, 22)
        Me.txtValorDescuentos.TabIndex = 147
        '
        'txtValorInteres
        '
        Me.txtValorInteres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorInteres.Location = New System.Drawing.Point(124, 310)
        Me.txtValorInteres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorInteres.MaxLength = 15
        Me.txtValorInteres.Multiline = True
        Me.txtValorInteres.Name = "txtValorInteres"
        Me.txtValorInteres.ReadOnly = True
        Me.txtValorInteres.Size = New System.Drawing.Size(98, 22)
        Me.txtValorInteres.TabIndex = 148
        '
        'txtValorTotalAbonos
        '
        Me.txtValorTotalAbonos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotalAbonos.Location = New System.Drawing.Point(124, 335)
        Me.txtValorTotalAbonos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorTotalAbonos.MaxLength = 15
        Me.txtValorTotalAbonos.Multiline = True
        Me.txtValorTotalAbonos.Name = "txtValorTotalAbonos"
        Me.txtValorTotalAbonos.ReadOnly = True
        Me.txtValorTotalAbonos.Size = New System.Drawing.Size(98, 22)
        Me.txtValorTotalAbonos.TabIndex = 149
        '
        'txtValorSaldo
        '
        Me.txtValorSaldo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorSaldo.Location = New System.Drawing.Point(124, 359)
        Me.txtValorSaldo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorSaldo.MaxLength = 15
        Me.txtValorSaldo.Multiline = True
        Me.txtValorSaldo.Name = "txtValorSaldo"
        Me.txtValorSaldo.ReadOnly = True
        Me.txtValorSaldo.Size = New System.Drawing.Size(98, 22)
        Me.txtValorSaldo.TabIndex = 150
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(812, 138)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(46, 21)
        Me.Label46.TabIndex = 5
        Me.Label46.Text = "Sucur"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(630, 138)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 21)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "TipDoc"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(529, 138)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 21)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Valores"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(235, 138)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(293, 21)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Cuentas contables del pago"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.rbNoCuentasBancarias)
        Me.GroupBox1.Controls.Add(Me.rbSiCuentasBancarias)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 388)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(213, 112)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(2, 7)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(208, 25)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Tipo Afectacion Contable"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbNoCuentasBancarias
        '
        Me.rbNoCuentasBancarias.AutoSize = True
        Me.rbNoCuentasBancarias.Location = New System.Drawing.Point(20, 62)
        Me.rbNoCuentasBancarias.Margin = New System.Windows.Forms.Padding(2)
        Me.rbNoCuentasBancarias.Name = "rbNoCuentasBancarias"
        Me.rbNoCuentasBancarias.Size = New System.Drawing.Size(129, 17)
        Me.rbNoCuentasBancarias.TabIndex = 144
        Me.rbNoCuentasBancarias.TabStop = True
        Me.rbNoCuentasBancarias.Text = "No cuentas bancarias"
        Me.rbNoCuentasBancarias.UseVisualStyleBackColor = True
        '
        'rbSiCuentasBancarias
        '
        Me.rbSiCuentasBancarias.AutoSize = True
        Me.rbSiCuentasBancarias.Location = New System.Drawing.Point(20, 39)
        Me.rbSiCuentasBancarias.Margin = New System.Windows.Forms.Padding(2)
        Me.rbSiCuentasBancarias.Name = "rbSiCuentasBancarias"
        Me.rbSiCuentasBancarias.Size = New System.Drawing.Size(124, 17)
        Me.rbSiCuentasBancarias.TabIndex = 143
        Me.rbSiCuentasBancarias.TabStop = True
        Me.rbSiCuentasBancarias.Text = "Si cuentas bancarias"
        Me.rbSiCuentasBancarias.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.SucurBan)
        Me.GroupBox2.Controls.Add(Me.DocuBan)
        Me.GroupBox2.Controls.Add(Me.TipoDocuBan)
        Me.GroupBox2.Controls.Add(Me.cboNumCuenta)
        Me.GroupBox2.Controls.Add(Me.cboBancos)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.FechaPago)
        Me.GroupBox2.Controls.Add(Me.Panel7)
        Me.GroupBox2.Controls.Add(Me.DigiBan)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 387)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(394, 113)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(193, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cons No:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SucurBan
        '
        Me.SucurBan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SucurBan.Location = New System.Drawing.Point(348, 87)
        Me.SucurBan.Margin = New System.Windows.Forms.Padding(2)
        Me.SucurBan.MaxLength = 15
        Me.SucurBan.Multiline = True
        Me.SucurBan.Name = "SucurBan"
        Me.SucurBan.Size = New System.Drawing.Size(42, 22)
        Me.SucurBan.TabIndex = 160
        '
        'DocuBan
        '
        Me.DocuBan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocuBan.Location = New System.Drawing.Point(140, 87)
        Me.DocuBan.Margin = New System.Windows.Forms.Padding(2)
        Me.DocuBan.MaxLength = 15
        Me.DocuBan.Multiline = True
        Me.DocuBan.Name = "DocuBan"
        Me.DocuBan.Size = New System.Drawing.Size(170, 22)
        Me.DocuBan.TabIndex = 158
        '
        'TipoDocuBan
        '
        Me.TipoDocuBan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoDocuBan.Location = New System.Drawing.Point(87, 87)
        Me.TipoDocuBan.Margin = New System.Windows.Forms.Padding(2)
        Me.TipoDocuBan.MaxLength = 15
        Me.TipoDocuBan.Multiline = True
        Me.TipoDocuBan.Name = "TipoDocuBan"
        Me.TipoDocuBan.Size = New System.Drawing.Size(53, 22)
        Me.TipoDocuBan.TabIndex = 157
        '
        'cboNumCuenta
        '
        Me.cboNumCuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNumCuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNumCuenta.BackColor = System.Drawing.Color.White
        Me.cboNumCuenta.DropDownWidth = 50
        Me.cboNumCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNumCuenta.FormattingEnabled = True
        Me.cboNumCuenta.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboNumCuenta.Location = New System.Drawing.Point(87, 62)
        Me.cboNumCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNumCuenta.Name = "cboNumCuenta"
        Me.cboNumCuenta.Size = New System.Drawing.Size(303, 22)
        Me.cboNumCuenta.TabIndex = 156
        '
        'cboBancos
        '
        Me.cboBancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboBancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBancos.BackColor = System.Drawing.Color.White
        Me.cboBancos.DropDownWidth = 300
        Me.cboBancos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBancos.FormattingEnabled = True
        Me.cboBancos.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboBancos.Location = New System.Drawing.Point(87, 38)
        Me.cboBancos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.Size = New System.Drawing.Size(303, 22)
        Me.cboBancos.TabIndex = 155
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(281, 11)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox11.MaxLength = 15
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(109, 22)
        Me.TextBox11.TabIndex = 155
        '
        'FechaPago
        '
        Me.FechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPago.Location = New System.Drawing.Point(87, 12)
        Me.FechaPago.Margin = New System.Windows.Forms.Padding(2)
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Size = New System.Drawing.Size(102, 20)
        Me.FechaPago.TabIndex = 94
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel7.Controls.Add(Me.Label28)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Controls.Add(Me.Label25)
        Me.Panel7.Controls.Add(Me.Label27)
        Me.Panel7.Location = New System.Drawing.Point(0, 8)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(86, 105)
        Me.Panel7.TabIndex = 93
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(6, 76)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 17)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "Identifica"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(6, 52)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(78, 17)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Cuenta No:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 29)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Banco:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(4, 4)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 17)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Fecha Pago:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DigiBan
        '
        Me.DigiBan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigiBan.Location = New System.Drawing.Point(310, 87)
        Me.DigiBan.Margin = New System.Windows.Forms.Padding(2)
        Me.DigiBan.MaxLength = 15
        Me.DigiBan.Multiline = True
        Me.DigiBan.Name = "DigiBan"
        Me.DigiBan.Size = New System.Drawing.Size(38, 22)
        Me.DigiBan.TabIndex = 159
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel10.Controls.Add(Me.Label31)
        Me.Panel10.Controls.Add(Me.Label32)
        Me.Panel10.Controls.Add(Me.Label33)
        Me.Panel10.Controls.Add(Me.Label34)
        Me.Panel10.Controls.Add(Me.Label35)
        Me.Panel10.Controls.Add(Me.Label36)
        Me.Panel10.Controls.Add(Me.Label37)
        Me.Panel10.Controls.Add(Me.Label38)
        Me.Panel10.Location = New System.Drawing.Point(237, 161)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(188, 198)
        Me.Panel10.TabIndex = 92
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(5, 175)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(175, 16)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = " Cta Contable Otros Desc:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(5, 151)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(153, 16)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = " Cta Contable Tramite:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(5, 126)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(171, 16)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = " Cta Contable Pago Opor:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(5, 102)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(185, 16)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = " Cta Contable Rete-Fuente:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(5, 77)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(164, 16)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = " Cta Contable Rete-ICA:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(5, 53)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(165, 16)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = " Cta Contable Rete-IVA:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(5, 28)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(152, 16)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = " Cta Contable Interes:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(5, 4)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(136, 16)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = " Cta Contable Pago:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel9.Controls.Add(Me.Label39)
        Me.Panel9.Location = New System.Drawing.Point(238, 358)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(290, 25)
        Me.Panel9.TabIndex = 93
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(8, 4)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(134, 17)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "Total Consignado:"
        '
        'txtValorContablePago
        '
        Me.txtValorContablePago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContablePago.Location = New System.Drawing.Point(530, 164)
        Me.txtValorContablePago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContablePago.MaxLength = 15
        Me.txtValorContablePago.Multiline = True
        Me.txtValorContablePago.Name = "txtValorContablePago"
        Me.txtValorContablePago.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContablePago.TabIndex = 168
        '
        'txtValorContableInteres
        '
        Me.txtValorContableInteres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableInteres.Location = New System.Drawing.Point(530, 188)
        Me.txtValorContableInteres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableInteres.MaxLength = 15
        Me.txtValorContableInteres.Multiline = True
        Me.txtValorContableInteres.Name = "txtValorContableInteres"
        Me.txtValorContableInteres.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableInteres.TabIndex = 169
        '
        'txtValorContableReteIVA
        '
        Me.txtValorContableReteIVA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableReteIVA.Location = New System.Drawing.Point(530, 214)
        Me.txtValorContableReteIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableReteIVA.MaxLength = 15
        Me.txtValorContableReteIVA.Multiline = True
        Me.txtValorContableReteIVA.Name = "txtValorContableReteIVA"
        Me.txtValorContableReteIVA.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableReteIVA.TabIndex = 170
        '
        'txtValorContableReteICA
        '
        Me.txtValorContableReteICA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableReteICA.Location = New System.Drawing.Point(530, 238)
        Me.txtValorContableReteICA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableReteICA.MaxLength = 15
        Me.txtValorContableReteICA.Multiline = True
        Me.txtValorContableReteICA.Name = "txtValorContableReteICA"
        Me.txtValorContableReteICA.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableReteICA.TabIndex = 171
        '
        'txtValorContableReteFuente
        '
        Me.txtValorContableReteFuente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableReteFuente.Location = New System.Drawing.Point(530, 262)
        Me.txtValorContableReteFuente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableReteFuente.MaxLength = 15
        Me.txtValorContableReteFuente.Multiline = True
        Me.txtValorContableReteFuente.Name = "txtValorContableReteFuente"
        Me.txtValorContableReteFuente.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableReteFuente.TabIndex = 172
        '
        'txtValorContableRetePagoPor
        '
        Me.txtValorContableRetePagoPor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableRetePagoPor.Location = New System.Drawing.Point(530, 287)
        Me.txtValorContableRetePagoPor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableRetePagoPor.MaxLength = 15
        Me.txtValorContableRetePagoPor.Multiline = True
        Me.txtValorContableRetePagoPor.Name = "txtValorContableRetePagoPor"
        Me.txtValorContableRetePagoPor.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableRetePagoPor.TabIndex = 173
        '
        'txtValorContableTramite
        '
        Me.txtValorContableTramite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableTramite.Location = New System.Drawing.Point(530, 311)
        Me.txtValorContableTramite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableTramite.MaxLength = 15
        Me.txtValorContableTramite.Multiline = True
        Me.txtValorContableTramite.Name = "txtValorContableTramite"
        Me.txtValorContableTramite.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableTramite.TabIndex = 174
        '
        'txtValorContableOtrosDesc
        '
        Me.txtValorContableOtrosDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContableOtrosDesc.Location = New System.Drawing.Point(530, 336)
        Me.txtValorContableOtrosDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorContableOtrosDesc.MaxLength = 15
        Me.txtValorContableOtrosDesc.Multiline = True
        Me.txtValorContableOtrosDesc.Name = "txtValorContableOtrosDesc"
        Me.txtValorContableOtrosDesc.Size = New System.Drawing.Size(102, 22)
        Me.txtValorContableOtrosDesc.TabIndex = 175
        '
        'txtDocuContableOtroDesc
        '
        Me.txtDocuContableOtroDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContableOtroDesc.Location = New System.Drawing.Point(687, 336)
        Me.txtDocuContableOtroDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContableOtroDesc.MaxLength = 15
        Me.txtDocuContableOtroDesc.Multiline = True
        Me.txtDocuContableOtroDesc.Name = "txtDocuContableOtroDesc"
        Me.txtDocuContableOtroDesc.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContableOtroDesc.TabIndex = 183
        '
        'txtDocuContableTramite
        '
        Me.txtDocuContableTramite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContableTramite.Location = New System.Drawing.Point(687, 311)
        Me.txtDocuContableTramite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContableTramite.MaxLength = 15
        Me.txtDocuContableTramite.Multiline = True
        Me.txtDocuContableTramite.Name = "txtDocuContableTramite"
        Me.txtDocuContableTramite.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContableTramite.TabIndex = 182
        '
        'txtDocuContablePagoOpor
        '
        Me.txtDocuContablePagoOpor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContablePagoOpor.Location = New System.Drawing.Point(687, 287)
        Me.txtDocuContablePagoOpor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContablePagoOpor.MaxLength = 15
        Me.txtDocuContablePagoOpor.Multiline = True
        Me.txtDocuContablePagoOpor.Name = "txtDocuContablePagoOpor"
        Me.txtDocuContablePagoOpor.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContablePagoOpor.TabIndex = 181
        '
        'txtDocuContableReteFuente
        '
        Me.txtDocuContableReteFuente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContableReteFuente.Location = New System.Drawing.Point(687, 262)
        Me.txtDocuContableReteFuente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContableReteFuente.MaxLength = 15
        Me.txtDocuContableReteFuente.Multiline = True
        Me.txtDocuContableReteFuente.Name = "txtDocuContableReteFuente"
        Me.txtDocuContableReteFuente.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContableReteFuente.TabIndex = 180
        '
        'txtDocuContableReteIca
        '
        Me.txtDocuContableReteIca.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContableReteIca.Location = New System.Drawing.Point(687, 238)
        Me.txtDocuContableReteIca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContableReteIca.MaxLength = 15
        Me.txtDocuContableReteIca.Multiline = True
        Me.txtDocuContableReteIca.Name = "txtDocuContableReteIca"
        Me.txtDocuContableReteIca.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContableReteIca.TabIndex = 179
        '
        'txtDocuContableReteIva
        '
        Me.txtDocuContableReteIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContableReteIva.Location = New System.Drawing.Point(687, 214)
        Me.txtDocuContableReteIva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContableReteIva.MaxLength = 15
        Me.txtDocuContableReteIva.Multiline = True
        Me.txtDocuContableReteIva.Name = "txtDocuContableReteIva"
        Me.txtDocuContableReteIva.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContableReteIva.TabIndex = 178
        '
        'txtDocuContableIntereses
        '
        Me.txtDocuContableIntereses.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContableIntereses.Location = New System.Drawing.Point(687, 188)
        Me.txtDocuContableIntereses.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContableIntereses.MaxLength = 15
        Me.txtDocuContableIntereses.Multiline = True
        Me.txtDocuContableIntereses.Name = "txtDocuContableIntereses"
        Me.txtDocuContableIntereses.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContableIntereses.TabIndex = 177
        '
        'txtDocuContablePago
        '
        Me.txtDocuContablePago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuContablePago.Location = New System.Drawing.Point(687, 164)
        Me.txtDocuContablePago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocuContablePago.MaxLength = 15
        Me.txtDocuContablePago.Multiline = True
        Me.txtDocuContablePago.Name = "txtDocuContablePago"
        Me.txtDocuContablePago.Size = New System.Drawing.Size(93, 22)
        Me.txtDocuContablePago.TabIndex = 176
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(652, 442)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 184
        Me.Label18.Text = "Cerrar"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(725, 442)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 185
        Me.Label22.Text = "Imprimir"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(799, 442)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(45, 13)
        Me.Label41.TabIndex = 186
        Me.Label41.Text = "Guardar"
        '
        'txtDigiContablePago
        '
        Me.txtDigiContablePago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContablePago.Location = New System.Drawing.Point(782, 164)
        Me.txtDigiContablePago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContablePago.MaxLength = 15
        Me.txtDigiContablePago.Multiline = True
        Me.txtDigiContablePago.Name = "txtDigiContablePago"
        Me.txtDigiContablePago.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContablePago.TabIndex = 187
        '
        'txtDigiContableInteres
        '
        Me.txtDigiContableInteres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContableInteres.Location = New System.Drawing.Point(782, 188)
        Me.txtDigiContableInteres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContableInteres.MaxLength = 15
        Me.txtDigiContableInteres.Multiline = True
        Me.txtDigiContableInteres.Name = "txtDigiContableInteres"
        Me.txtDigiContableInteres.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContableInteres.TabIndex = 188
        '
        'txtDigiContableReteIva
        '
        Me.txtDigiContableReteIva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContableReteIva.Location = New System.Drawing.Point(782, 214)
        Me.txtDigiContableReteIva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContableReteIva.MaxLength = 15
        Me.txtDigiContableReteIva.Multiline = True
        Me.txtDigiContableReteIva.Name = "txtDigiContableReteIva"
        Me.txtDigiContableReteIva.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContableReteIva.TabIndex = 189
        '
        'txtDigiContableReteIca
        '
        Me.txtDigiContableReteIca.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContableReteIca.Location = New System.Drawing.Point(782, 238)
        Me.txtDigiContableReteIca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContableReteIca.MaxLength = 15
        Me.txtDigiContableReteIca.Multiline = True
        Me.txtDigiContableReteIca.Name = "txtDigiContableReteIca"
        Me.txtDigiContableReteIca.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContableReteIca.TabIndex = 190
        '
        'txtDigiContableReteFuente
        '
        Me.txtDigiContableReteFuente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContableReteFuente.Location = New System.Drawing.Point(782, 262)
        Me.txtDigiContableReteFuente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContableReteFuente.MaxLength = 15
        Me.txtDigiContableReteFuente.Multiline = True
        Me.txtDigiContableReteFuente.Name = "txtDigiContableReteFuente"
        Me.txtDigiContableReteFuente.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContableReteFuente.TabIndex = 191
        '
        'txtDigiContablePagoOpor
        '
        Me.txtDigiContablePagoOpor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContablePagoOpor.Location = New System.Drawing.Point(782, 287)
        Me.txtDigiContablePagoOpor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContablePagoOpor.MaxLength = 15
        Me.txtDigiContablePagoOpor.Multiline = True
        Me.txtDigiContablePagoOpor.Name = "txtDigiContablePagoOpor"
        Me.txtDigiContablePagoOpor.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContablePagoOpor.TabIndex = 192
        '
        'txtDigiContableTramite
        '
        Me.txtDigiContableTramite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContableTramite.Location = New System.Drawing.Point(782, 311)
        Me.txtDigiContableTramite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContableTramite.MaxLength = 15
        Me.txtDigiContableTramite.Multiline = True
        Me.txtDigiContableTramite.Name = "txtDigiContableTramite"
        Me.txtDigiContableTramite.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContableTramite.TabIndex = 193
        '
        'txtDigiContableOtrosDesc
        '
        Me.txtDigiContableOtrosDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigiContableOtrosDesc.Location = New System.Drawing.Point(782, 336)
        Me.txtDigiContableOtrosDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigiContableOtrosDesc.MaxLength = 15
        Me.txtDigiContableOtrosDesc.Multiline = True
        Me.txtDigiContableOtrosDesc.Name = "txtDigiContableOtrosDesc"
        Me.txtDigiContableOtrosDesc.Size = New System.Drawing.Size(32, 22)
        Me.txtDigiContableOtrosDesc.TabIndex = 194
        '
        'cboTipoPago
        '
        Me.cboTipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboTipoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoPago.BackColor = System.Drawing.Color.White
        Me.cboTipoPago.DropDownWidth = 300
        Me.cboTipoPago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.FormattingEnabled = True
        Me.cboTipoPago.Items.AddRange(New Object() {"Consignacion", "Efectivo", "Cheque", "Tarjeta de credito", "Letras", "Pagares"})
        Me.cboTipoPago.Location = New System.Drawing.Point(496, 105)
        Me.cboTipoPago.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(117, 22)
        Me.cboTipoPago.TabIndex = 195
        '
        'txtSucursal
        '
        Me.txtSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Location = New System.Drawing.Point(276, 40)
        Me.txtSucursal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucursal.MaxLength = 15
        Me.txtSucursal.Multiline = True
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(57, 22)
        Me.txtSucursal.TabIndex = 196
        '
        'txtCuentaContablePago
        '
        Me.txtCuentaContablePago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaContablePago.Location = New System.Drawing.Point(426, 164)
        Me.txtCuentaContablePago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentaContablePago.MaxLength = 15
        Me.txtCuentaContablePago.Multiline = True
        Me.txtCuentaContablePago.Name = "txtCuentaContablePago"
        Me.txtCuentaContablePago.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentaContablePago.TabIndex = 197
        '
        'txtCuentasInteres
        '
        Me.txtCuentasInteres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentasInteres.Location = New System.Drawing.Point(426, 189)
        Me.txtCuentasInteres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentasInteres.MaxLength = 15
        Me.txtCuentasInteres.Multiline = True
        Me.txtCuentasInteres.Name = "txtCuentasInteres"
        Me.txtCuentasInteres.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentasInteres.TabIndex = 198
        '
        'txtCuentaReteIVA
        '
        Me.txtCuentaReteIVA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaReteIVA.Location = New System.Drawing.Point(427, 214)
        Me.txtCuentaReteIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentaReteIVA.MaxLength = 15
        Me.txtCuentaReteIVA.Multiline = True
        Me.txtCuentaReteIVA.Name = "txtCuentaReteIVA"
        Me.txtCuentaReteIVA.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentaReteIVA.TabIndex = 199
        '
        'txtCuentasReteIca
        '
        Me.txtCuentasReteIca.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentasReteIca.Location = New System.Drawing.Point(427, 238)
        Me.txtCuentasReteIca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentasReteIca.MaxLength = 15
        Me.txtCuentasReteIca.Multiline = True
        Me.txtCuentasReteIca.Name = "txtCuentasReteIca"
        Me.txtCuentasReteIca.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentasReteIca.TabIndex = 200
        '
        'txtCuentasReteFuente
        '
        Me.txtCuentasReteFuente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentasReteFuente.Location = New System.Drawing.Point(427, 262)
        Me.txtCuentasReteFuente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentasReteFuente.MaxLength = 15
        Me.txtCuentasReteFuente.Multiline = True
        Me.txtCuentasReteFuente.Name = "txtCuentasReteFuente"
        Me.txtCuentasReteFuente.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentasReteFuente.TabIndex = 201
        '
        'txtCuentasPagoOpor
        '
        Me.txtCuentasPagoOpor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentasPagoOpor.Location = New System.Drawing.Point(427, 286)
        Me.txtCuentasPagoOpor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentasPagoOpor.MaxLength = 15
        Me.txtCuentasPagoOpor.Multiline = True
        Me.txtCuentasPagoOpor.Name = "txtCuentasPagoOpor"
        Me.txtCuentasPagoOpor.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentasPagoOpor.TabIndex = 202
        '
        'txtCuentasTramite
        '
        Me.txtCuentasTramite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentasTramite.Location = New System.Drawing.Point(427, 311)
        Me.txtCuentasTramite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentasTramite.MaxLength = 15
        Me.txtCuentasTramite.Multiline = True
        Me.txtCuentasTramite.Name = "txtCuentasTramite"
        Me.txtCuentasTramite.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentasTramite.TabIndex = 203
        '
        'txtCuentaOtrosDesc
        '
        Me.txtCuentaOtrosDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaOtrosDesc.Location = New System.Drawing.Point(427, 336)
        Me.txtCuentaOtrosDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuentaOtrosDesc.MaxLength = 15
        Me.txtCuentaOtrosDesc.Multiline = True
        Me.txtCuentaOtrosDesc.Name = "txtCuentaOtrosDesc"
        Me.txtCuentaOtrosDesc.Size = New System.Drawing.Size(102, 22)
        Me.txtCuentaOtrosDesc.TabIndex = 204
        '
        'cboContablePagoTipoDocu
        '
        Me.cboContablePagoTipoDocu.FormattingEnabled = True
        Me.cboContablePagoTipoDocu.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboContablePagoTipoDocu.Location = New System.Drawing.Point(633, 165)
        Me.cboContablePagoTipoDocu.Name = "cboContablePagoTipoDocu"
        Me.cboContablePagoTipoDocu.Size = New System.Drawing.Size(52, 21)
        Me.cboContablePagoTipoDocu.TabIndex = 205
        '
        'cboTipoDocuInteres
        '
        Me.cboTipoDocuInteres.FormattingEnabled = True
        Me.cboTipoDocuInteres.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTipoDocuInteres.Location = New System.Drawing.Point(633, 189)
        Me.cboTipoDocuInteres.Name = "cboTipoDocuInteres"
        Me.cboTipoDocuInteres.Size = New System.Drawing.Size(52, 21)
        Me.cboTipoDocuInteres.TabIndex = 206
        '
        'cboTipoDocuIVA
        '
        Me.cboTipoDocuIVA.FormattingEnabled = True
        Me.cboTipoDocuIVA.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTipoDocuIVA.Location = New System.Drawing.Point(633, 214)
        Me.cboTipoDocuIVA.Name = "cboTipoDocuIVA"
        Me.cboTipoDocuIVA.Size = New System.Drawing.Size(52, 21)
        Me.cboTipoDocuIVA.TabIndex = 207
        '
        'cboTipoDocuICA
        '
        Me.cboTipoDocuICA.FormattingEnabled = True
        Me.cboTipoDocuICA.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTipoDocuICA.Location = New System.Drawing.Point(633, 239)
        Me.cboTipoDocuICA.Name = "cboTipoDocuICA"
        Me.cboTipoDocuICA.Size = New System.Drawing.Size(52, 21)
        Me.cboTipoDocuICA.TabIndex = 208
        '
        'cboTipoDocuFuente
        '
        Me.cboTipoDocuFuente.FormattingEnabled = True
        Me.cboTipoDocuFuente.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTipoDocuFuente.Location = New System.Drawing.Point(633, 263)
        Me.cboTipoDocuFuente.Name = "cboTipoDocuFuente"
        Me.cboTipoDocuFuente.Size = New System.Drawing.Size(52, 21)
        Me.cboTipoDocuFuente.TabIndex = 209
        '
        'cboTipoDocuPagoOpor
        '
        Me.cboTipoDocuPagoOpor.FormattingEnabled = True
        Me.cboTipoDocuPagoOpor.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTipoDocuPagoOpor.Location = New System.Drawing.Point(633, 288)
        Me.cboTipoDocuPagoOpor.Name = "cboTipoDocuPagoOpor"
        Me.cboTipoDocuPagoOpor.Size = New System.Drawing.Size(52, 21)
        Me.cboTipoDocuPagoOpor.TabIndex = 210
        '
        'cboTipoDocuTramite
        '
        Me.cboTipoDocuTramite.FormattingEnabled = True
        Me.cboTipoDocuTramite.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTipoDocuTramite.Location = New System.Drawing.Point(633, 312)
        Me.cboTipoDocuTramite.Name = "cboTipoDocuTramite"
        Me.cboTipoDocuTramite.Size = New System.Drawing.Size(52, 21)
        Me.cboTipoDocuTramite.TabIndex = 211
        '
        'cboTIpoDocuDesc
        '
        Me.cboTIpoDocuDesc.FormattingEnabled = True
        Me.cboTIpoDocuDesc.Items.AddRange(New Object() {"NIT", "CC"})
        Me.cboTIpoDocuDesc.Location = New System.Drawing.Point(633, 337)
        Me.cboTIpoDocuDesc.Name = "cboTIpoDocuDesc"
        Me.cboTIpoDocuDesc.Size = New System.Drawing.Size(52, 21)
        Me.cboTIpoDocuDesc.TabIndex = 212
        '
        'txtSucurOtrosDesc
        '
        Me.txtSucurOtrosDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurOtrosDesc.Location = New System.Drawing.Point(815, 336)
        Me.txtSucurOtrosDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurOtrosDesc.MaxLength = 15
        Me.txtSucurOtrosDesc.Multiline = True
        Me.txtSucurOtrosDesc.Name = "txtSucurOtrosDesc"
        Me.txtSucurOtrosDesc.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurOtrosDesc.TabIndex = 220
        '
        'txtSucurTramite
        '
        Me.txtSucurTramite.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurTramite.Location = New System.Drawing.Point(815, 311)
        Me.txtSucurTramite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurTramite.MaxLength = 15
        Me.txtSucurTramite.Multiline = True
        Me.txtSucurTramite.Name = "txtSucurTramite"
        Me.txtSucurTramite.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurTramite.TabIndex = 219
        '
        'txtSucurPagoPor
        '
        Me.txtSucurPagoPor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurPagoPor.Location = New System.Drawing.Point(815, 287)
        Me.txtSucurPagoPor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurPagoPor.MaxLength = 15
        Me.txtSucurPagoPor.Multiline = True
        Me.txtSucurPagoPor.Name = "txtSucurPagoPor"
        Me.txtSucurPagoPor.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurPagoPor.TabIndex = 218
        '
        'txtSucurFuente
        '
        Me.txtSucurFuente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurFuente.Location = New System.Drawing.Point(815, 262)
        Me.txtSucurFuente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurFuente.MaxLength = 15
        Me.txtSucurFuente.Multiline = True
        Me.txtSucurFuente.Name = "txtSucurFuente"
        Me.txtSucurFuente.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurFuente.TabIndex = 217
        '
        'txtSucurICA
        '
        Me.txtSucurICA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurICA.Location = New System.Drawing.Point(815, 238)
        Me.txtSucurICA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurICA.MaxLength = 15
        Me.txtSucurICA.Multiline = True
        Me.txtSucurICA.Name = "txtSucurICA"
        Me.txtSucurICA.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurICA.TabIndex = 216
        '
        'txtSucurIVA
        '
        Me.txtSucurIVA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurIVA.Location = New System.Drawing.Point(815, 214)
        Me.txtSucurIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurIVA.MaxLength = 15
        Me.txtSucurIVA.Multiline = True
        Me.txtSucurIVA.Name = "txtSucurIVA"
        Me.txtSucurIVA.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurIVA.TabIndex = 215
        '
        'txtSucurInteres
        '
        Me.txtSucurInteres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurInteres.Location = New System.Drawing.Point(815, 188)
        Me.txtSucurInteres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurInteres.MaxLength = 15
        Me.txtSucurInteres.Multiline = True
        Me.txtSucurInteres.Name = "txtSucurInteres"
        Me.txtSucurInteres.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurInteres.TabIndex = 214
        '
        'txtSucurContablePago
        '
        Me.txtSucurContablePago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucurContablePago.Location = New System.Drawing.Point(815, 164)
        Me.txtSucurContablePago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSucurContablePago.MaxLength = 15
        Me.txtSucurContablePago.Multiline = True
        Me.txtSucurContablePago.Name = "txtSucurContablePago"
        Me.txtSucurContablePago.Size = New System.Drawing.Size(43, 22)
        Me.txtSucurContablePago.TabIndex = 213
        '
        'txtTotalConsignado
        '
        Me.txtTotalConsignado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConsignado.Location = New System.Drawing.Point(530, 360)
        Me.txtTotalConsignado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalConsignado.MaxLength = 15
        Me.txtTotalConsignado.Multiline = True
        Me.txtTotalConsignado.Name = "txtTotalConsignado"
        Me.txtTotalConsignado.Size = New System.Drawing.Size(102, 22)
        Me.txtTotalConsignado.TabIndex = 221
        '
        'txtRemision
        '
        Me.txtRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemision.Location = New System.Drawing.Point(685, 40)
        Me.txtRemision.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemision.MaxLength = 15
        Me.txtRemision.Multiline = True
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.ReadOnly = True
        Me.txtRemision.Size = New System.Drawing.Size(98, 22)
        Me.txtRemision.TabIndex = 112
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(684, 138)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(98, 21)
        Me.Label47.TabIndex = 222
        Me.Label47.Text = "Documento"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(782, 138)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(32, 21)
        Me.Label48.TabIndex = 223
        Me.Label48.Text = "DV"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCerrarContratos
        '
        Me.BtnCerrarContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrarContratos.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarContratos.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrarContratos.Location = New System.Drawing.Point(644, 461)
        Me.BtnCerrarContratos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarContratos.Name = "BtnCerrarContratos"
        Me.BtnCerrarContratos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarContratos.Size = New System.Drawing.Size(62, 39)
        Me.BtnCerrarContratos.TabIndex = 108
        Me.BtnCerrarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarContratos.UseMnemonic = False
        Me.BtnCerrarContratos.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPagar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoGuardar
        Me.btnPagar.Location = New System.Drawing.Point(790, 461)
        Me.btnPagar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPagar.Size = New System.Drawing.Size(64, 39)
        Me.btnPagar.TabIndex = 109
        Me.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagar.UseMnemonic = False
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Enabled = False
        Me.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReporte.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.Black
        Me.btnReporte.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_imprimir_40
        Me.btnReporte.Location = New System.Drawing.Point(710, 461)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporte.Size = New System.Drawing.Size(73, 39)
        Me.btnReporte.TabIndex = 110
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseMnemonic = False
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(877, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtTotalConsignado)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtSucurOtrosDesc)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtSucurTramite)
        Me.Controls.Add(Me.txtSucurPagoPor)
        Me.Controls.Add(Me.txtSucurFuente)
        Me.Controls.Add(Me.txtSucurICA)
        Me.Controls.Add(Me.txtSucurIVA)
        Me.Controls.Add(Me.txtSucurInteres)
        Me.Controls.Add(Me.txtSucurContablePago)
        Me.Controls.Add(Me.cboTIpoDocuDesc)
        Me.Controls.Add(Me.cboTipoDocuTramite)
        Me.Controls.Add(Me.cboTipoDocuPagoOpor)
        Me.Controls.Add(Me.cboTipoDocuFuente)
        Me.Controls.Add(Me.cboTipoDocuICA)
        Me.Controls.Add(Me.cboTipoDocuIVA)
        Me.Controls.Add(Me.cboTipoDocuInteres)
        Me.Controls.Add(Me.cboContablePagoTipoDocu)
        Me.Controls.Add(Me.txtCuentaOtrosDesc)
        Me.Controls.Add(Me.txtCuentasTramite)
        Me.Controls.Add(Me.txtCuentasPagoOpor)
        Me.Controls.Add(Me.txtCuentasReteFuente)
        Me.Controls.Add(Me.txtCuentasReteIca)
        Me.Controls.Add(Me.txtCuentaReteIVA)
        Me.Controls.Add(Me.txtCuentasInteres)
        Me.Controls.Add(Me.txtCuentaContablePago)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.cboTipoPago)
        Me.Controls.Add(Me.txtDigiContableOtrosDesc)
        Me.Controls.Add(Me.txtDigiContableTramite)
        Me.Controls.Add(Me.txtDigiContablePagoOpor)
        Me.Controls.Add(Me.txtDigiContableReteFuente)
        Me.Controls.Add(Me.txtDigiContableReteIca)
        Me.Controls.Add(Me.txtDigiContableReteIva)
        Me.Controls.Add(Me.txtDigiContableInteres)
        Me.Controls.Add(Me.txtDigiContablePago)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDocuContableOtroDesc)
        Me.Controls.Add(Me.txtDocuContableTramite)
        Me.Controls.Add(Me.txtDocuContablePagoOpor)
        Me.Controls.Add(Me.txtDocuContableReteFuente)
        Me.Controls.Add(Me.txtDocuContableReteIca)
        Me.Controls.Add(Me.txtDocuContableReteIva)
        Me.Controls.Add(Me.txtDocuContableIntereses)
        Me.Controls.Add(Me.txtDocuContablePago)
        Me.Controls.Add(Me.txtValorContableOtrosDesc)
        Me.Controls.Add(Me.txtValorContableTramite)
        Me.Controls.Add(Me.txtValorContableRetePagoPor)
        Me.Controls.Add(Me.txtValorContableReteFuente)
        Me.Controls.Add(Me.txtValorContableReteICA)
        Me.Controls.Add(Me.txtValorContableReteIVA)
        Me.Controls.Add(Me.txtValorContableInteres)
        Me.Controls.Add(Me.txtValorContablePago)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtValorSaldo)
        Me.Controls.Add(Me.txtValorTotalAbonos)
        Me.Controls.Add(Me.txtValorInteres)
        Me.Controls.Add(Me.txtValorDescuentos)
        Me.Controls.Add(Me.txtValorImpuestos)
        Me.Controls.Add(Me.txtValorDebitos)
        Me.Controls.Add(Me.txtValorCreditos)
        Me.Controls.Add(Me.txtValorGlosado)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.lblCodigoUsuario2)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.DtUltimoPago)
        Me.Controls.Add(Me.txtRazonSolTer)
        Me.Controls.Add(Me.txtDocuTer)
        Me.Controls.Add(Me.txtTipoDocTer)
        Me.Controls.Add(Me.DtFechaVencimeinto)
        Me.Controls.Add(Me.DtFechaExpedicion)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtRemision)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.BtnCerrarContratos)
        Me.Controls.Add(Me.DtFechaMovimiento)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.cboFacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFacturas As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DtFechaMovimiento As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DtFechaExpedicion As DateTimePicker
    Friend WithEvents DtFechaVencimeinto As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoDocTer As TextBox
    Friend WithEvents txtDocuTer As TextBox
    Friend WithEvents txtRazonSolTer As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents DtUltimoPago As DateTimePicker
    Friend WithEvents lblCodigoUsuario2 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents txtValorGlosado As TextBox
    Friend WithEvents txtValorCreditos As TextBox
    Friend WithEvents txtValorDebitos As TextBox
    Friend WithEvents txtValorImpuestos As TextBox
    Friend WithEvents txtValorDescuentos As TextBox
    Friend WithEvents txtValorInteres As TextBox
    Friend WithEvents txtValorTotalAbonos As TextBox
    Friend WithEvents txtValorSaldo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSiCuentasBancarias As RadioButton
    Friend WithEvents Label23 As Label
    Friend WithEvents rbNoCuentasBancarias As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DocuBan As TextBox
    Friend WithEvents TipoDocuBan As TextBox
    Friend WithEvents cboNumCuenta As ComboBox
    Friend WithEvents cboBancos As ComboBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents FechaPago As DateTimePicker
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents DigiBan As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents txtValorContablePago As TextBox
    Friend WithEvents txtValorContableInteres As TextBox
    Friend WithEvents txtValorContableReteIVA As TextBox
    Friend WithEvents txtValorContableReteICA As TextBox
    Friend WithEvents txtValorContableReteFuente As TextBox
    Friend WithEvents txtValorContableRetePagoPor As TextBox
    Friend WithEvents txtValorContableTramite As TextBox
    Friend WithEvents txtValorContableOtrosDesc As TextBox
    Friend WithEvents txtDocuContableOtroDesc As TextBox
    Friend WithEvents txtDocuContableTramite As TextBox
    Friend WithEvents txtDocuContablePagoOpor As TextBox
    Friend WithEvents txtDocuContableReteFuente As TextBox
    Friend WithEvents txtDocuContableReteIca As TextBox
    Friend WithEvents txtDocuContableReteIva As TextBox
    Friend WithEvents txtDocuContableIntereses As TextBox
    Friend WithEvents txtDocuContablePago As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents txtDigiContablePago As TextBox
    Friend WithEvents txtDigiContableInteres As TextBox
    Friend WithEvents txtDigiContableReteIva As TextBox
    Friend WithEvents txtDigiContableReteIca As TextBox
    Friend WithEvents txtDigiContableReteFuente As TextBox
    Friend WithEvents txtDigiContablePagoOpor As TextBox
    Friend WithEvents txtDigiContableTramite As TextBox
    Friend WithEvents txtDigiContableOtrosDesc As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents cboTipoPago As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents txtCuentaContablePago As TextBox
    Friend WithEvents txtCuentasInteres As TextBox
    Friend WithEvents txtCuentaReteIVA As TextBox
    Friend WithEvents txtCuentasReteIca As TextBox
    Friend WithEvents txtCuentasReteFuente As TextBox
    Friend WithEvents txtCuentasPagoOpor As TextBox
    Friend WithEvents txtCuentasTramite As TextBox
    Friend WithEvents txtCuentaOtrosDesc As TextBox
    Friend WithEvents cboContablePagoTipoDocu As ComboBox
    Friend WithEvents cboTipoDocuInteres As ComboBox
    Friend WithEvents cboTipoDocuIVA As ComboBox
    Friend WithEvents cboTipoDocuICA As ComboBox
    Friend WithEvents cboTipoDocuFuente As ComboBox
    Friend WithEvents cboTipoDocuPagoOpor As ComboBox
    Friend WithEvents cboTipoDocuTramite As ComboBox
    Friend WithEvents cboTIpoDocuDesc As ComboBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtSucurOtrosDesc As TextBox
    Friend WithEvents txtSucurTramite As TextBox
    Friend WithEvents txtSucurPagoPor As TextBox
    Friend WithEvents txtSucurFuente As TextBox
    Friend WithEvents txtSucurICA As TextBox
    Friend WithEvents txtSucurIVA As TextBox
    Friend WithEvents txtSucurInteres As TextBox
    Friend WithEvents txtSucurContablePago As TextBox
    Friend WithEvents SucurBan As TextBox
    Friend WithEvents txtTotalConsignado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRemision As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents BtnCerrarContratos As Button
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnReporte As Button
End Class
