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
        Me.cboFacturas = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetallePago = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupRegis = New System.Windows.Forms.GroupBox()
        Me.txtCodRegis = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ftRegis = New System.Windows.Forms.DateTimePicker()
        Me.txtCodModi = New System.Windows.Forms.TextBox()
        Me.ftModi = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtValorCredito = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemision = New System.Windows.Forms.TextBox()
        Me.txtValorDebito = New System.Windows.Forms.TextBox()
        Me.txtImpuestos = New System.Windows.Forms.TextBox()
        Me.txtPagoRealizados = New System.Windows.Forms.TextBox()
        Me.txtValorDescuento = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtValorFactura = New System.Windows.Forms.TextBox()
        Me.txtValorIVAFactura = New System.Windows.Forms.TextBox()
        Me.DtFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaVencimeinto = New System.Windows.Forms.DateTimePicker()
        Me.txtTipoDocTer = New System.Windows.Forms.TextBox()
        Me.txtDocuTer = New System.Windows.Forms.TextBox()
        Me.txtRazonSolTer = New System.Windows.Forms.TextBox()
        Me.DtUltimoPago = New System.Windows.Forms.DateTimePicker()
        Me.LabelPendiente = New System.Windows.Forms.Label()
        Me.LabelPagado = New System.Windows.Forms.Label()
        Me.cboCodigoContable = New System.Windows.Forms.ComboBox()
        Me.CheckAnulada = New System.Windows.Forms.CheckBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.BtnCerrarContratos = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupModi = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupRegis.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupModi.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFacturas
        '
        Me.cboFacturas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboFacturas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFacturas.BackColor = System.Drawing.Color.White
        Me.cboFacturas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFacturas.FormattingEnabled = True
        Me.cboFacturas.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboFacturas.Location = New System.Drawing.Point(21, 52)
        Me.cboFacturas.Name = "cboFacturas"
        Me.cboFacturas.Size = New System.Drawing.Size(128, 26)
        Me.cboFacturas.TabIndex = 86
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Location = New System.Drawing.Point(12, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(762, 31)
        Me.Panel6.TabIndex = 89
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(680, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 21)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Estado"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(395, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 21)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Razon Social"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(151, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "TipoDocu"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(566, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Remision"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(244, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Documento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(11, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 21)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Numero Factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(244, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha_Movimiento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(9, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 21)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "CodigoContablePago"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 39)
        Me.Panel1.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Detalle "
        '
        'txtDetallePago
        '
        Me.txtDetallePago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetallePago.Location = New System.Drawing.Point(139, 318)
        Me.txtDetallePago.MaxLength = 15
        Me.txtDetallePago.Multiline = True
        Me.txtDetallePago.Name = "txtDetallePago"
        Me.txtDetallePago.Size = New System.Drawing.Size(635, 39)
        Me.txtDetallePago.TabIndex = 92
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 31)
        Me.Panel2.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(420, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Valor Debito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(548, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Valor Credito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Valor Descuento"
        '
        'GroupRegis
        '
        Me.GroupRegis.Controls.Add(Me.txtCodRegis)
        Me.GroupRegis.Controls.Add(Me.Panel4)
        Me.GroupRegis.Controls.Add(Me.Panel7)
        Me.GroupRegis.Controls.Add(Me.ftRegis)
        Me.GroupRegis.Location = New System.Drawing.Point(103, 376)
        Me.GroupRegis.Name = "GroupRegis"
        Me.GroupRegis.Size = New System.Drawing.Size(490, 50)
        Me.GroupRegis.TabIndex = 99
        Me.GroupRegis.TabStop = False
        '
        'txtCodRegis
        '
        Me.txtCodRegis.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodRegis.Location = New System.Drawing.Point(135, 14)
        Me.txtCodRegis.Multiline = True
        Me.txtCodRegis.Name = "txtCodRegis"
        Me.txtCodRegis.Size = New System.Drawing.Size(88, 31)
        Me.txtCodRegis.TabIndex = 87
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Location = New System.Drawing.Point(11, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(113, 31)
        Me.Panel4.TabIndex = 90
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel10.Controls.Add(Me.Label23)
        Me.Panel10.Location = New System.Drawing.Point(99, 27)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(113, 31)
        Me.Panel10.TabIndex = 91
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(14, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 21)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Regis. Por"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(14, 6)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(85, 21)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Regis. Por"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel7.Controls.Add(Me.Label39)
        Me.Panel7.Location = New System.Drawing.Point(229, 14)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(113, 31)
        Me.Panel7.TabIndex = 93
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
        'ftRegis
        '
        Me.ftRegis.CalendarFont = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftRegis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftRegis.Location = New System.Drawing.Point(348, 19)
        Me.ftRegis.Name = "ftRegis"
        Me.ftRegis.Size = New System.Drawing.Size(131, 22)
        Me.ftRegis.TabIndex = 88
        '
        'txtCodModi
        '
        Me.txtCodModi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodModi.Location = New System.Drawing.Point(127, 14)
        Me.txtCodModi.Multiline = True
        Me.txtCodModi.Name = "txtCodModi"
        Me.txtCodModi.Size = New System.Drawing.Size(88, 31)
        Me.txtCodModi.TabIndex = 94
        '
        'ftModi
        '
        Me.ftModi.CalendarFont = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftModi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftModi.Location = New System.Drawing.Point(345, 19)
        Me.ftModi.Name = "ftModi"
        Me.ftModi.Size = New System.Drawing.Size(131, 22)
        Me.ftModi.TabIndex = 95
        '
        'DtFechaMovimiento
        '
        Me.DtFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaMovimiento.Location = New System.Drawing.Point(251, 204)
        Me.DtFechaMovimiento.Name = "DtFechaMovimiento"
        Me.DtFechaMovimiento.Size = New System.Drawing.Size(160, 22)
        Me.DtFechaMovimiento.TabIndex = 100
        '
        'txtValorCredito
        '
        Me.txtValorCredito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCredito.Location = New System.Drawing.Point(558, 204)
        Me.txtValorCredito.MaxLength = 15
        Me.txtValorCredito.Multiline = True
        Me.txtValorCredito.Name = "txtValorCredito"
        Me.txtValorCredito.Size = New System.Drawing.Size(117, 26)
        Me.txtValorCredito.TabIndex = 105
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(161, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 21)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Impuestos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(11, 239)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(763, 31)
        Me.Panel3.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(432, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Anulada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(274, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pagos Realizados"
        '
        'txtRemision
        '
        Me.txtRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemision.Location = New System.Drawing.Point(565, 53)
        Me.txtRemision.MaxLength = 15
        Me.txtRemision.Multiline = True
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.ReadOnly = True
        Me.txtRemision.Size = New System.Drawing.Size(103, 26)
        Me.txtRemision.TabIndex = 112
        '
        'txtValorDebito
        '
        Me.txtValorDebito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDebito.Location = New System.Drawing.Point(425, 204)
        Me.txtValorDebito.MaxLength = 15
        Me.txtValorDebito.Multiline = True
        Me.txtValorDebito.Name = "txtValorDebito"
        Me.txtValorDebito.Size = New System.Drawing.Size(117, 26)
        Me.txtValorDebito.TabIndex = 115
        '
        'txtImpuestos
        '
        Me.txtImpuestos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestos.Location = New System.Drawing.Point(157, 280)
        Me.txtImpuestos.MaxLength = 15
        Me.txtImpuestos.Multiline = True
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.Size = New System.Drawing.Size(117, 26)
        Me.txtImpuestos.TabIndex = 118
        '
        'txtPagoRealizados
        '
        Me.txtPagoRealizados.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagoRealizados.Location = New System.Drawing.Point(320, 280)
        Me.txtPagoRealizados.MaxLength = 15
        Me.txtPagoRealizados.Multiline = True
        Me.txtPagoRealizados.Name = "txtPagoRealizados"
        Me.txtPagoRealizados.ReadOnly = True
        Me.txtPagoRealizados.Size = New System.Drawing.Size(54, 26)
        Me.txtPagoRealizados.TabIndex = 119
        '
        'txtValorDescuento
        '
        Me.txtValorDescuento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDescuento.Location = New System.Drawing.Point(21, 280)
        Me.txtValorDescuento.MaxLength = 15
        Me.txtValorDescuento.Multiline = True
        Me.txtValorDescuento.Name = "txtValorDescuento"
        Me.txtValorDescuento.Size = New System.Drawing.Size(117, 26)
        Me.txtValorDescuento.TabIndex = 120
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Location = New System.Drawing.Point(12, 87)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(762, 31)
        Me.Panel5.TabIndex = 90
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(644, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 21)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Ultimo Pago"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(461, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 21)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fecha Vencimiento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(307, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 21)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Fecha Expedicion"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(150, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 21)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Valor IVA Factura"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(11, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 21)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Valor Factura"
        '
        'txtValorFactura
        '
        Me.txtValorFactura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFactura.Location = New System.Drawing.Point(21, 128)
        Me.txtValorFactura.MaxLength = 15
        Me.txtValorFactura.Multiline = True
        Me.txtValorFactura.Name = "txtValorFactura"
        Me.txtValorFactura.Size = New System.Drawing.Size(121, 26)
        Me.txtValorFactura.TabIndex = 121
        '
        'txtValorIVAFactura
        '
        Me.txtValorIVAFactura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorIVAFactura.Location = New System.Drawing.Point(170, 128)
        Me.txtValorIVAFactura.MaxLength = 15
        Me.txtValorIVAFactura.Multiline = True
        Me.txtValorIVAFactura.Name = "txtValorIVAFactura"
        Me.txtValorIVAFactura.Size = New System.Drawing.Size(121, 26)
        Me.txtValorIVAFactura.TabIndex = 122
        '
        'DtFechaExpedicion
        '
        Me.DtFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaExpedicion.Location = New System.Drawing.Point(317, 128)
        Me.DtFechaExpedicion.Name = "DtFechaExpedicion"
        Me.DtFechaExpedicion.Size = New System.Drawing.Size(139, 22)
        Me.DtFechaExpedicion.TabIndex = 123
        '
        'DtFechaVencimeinto
        '
        Me.DtFechaVencimeinto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaVencimeinto.Location = New System.Drawing.Point(479, 128)
        Me.DtFechaVencimeinto.Name = "DtFechaVencimeinto"
        Me.DtFechaVencimeinto.Size = New System.Drawing.Size(139, 22)
        Me.DtFechaVencimeinto.TabIndex = 124
        '
        'txtTipoDocTer
        '
        Me.txtTipoDocTer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocTer.Location = New System.Drawing.Point(175, 53)
        Me.txtTipoDocTer.MaxLength = 15
        Me.txtTipoDocTer.Multiline = True
        Me.txtTipoDocTer.Name = "txtTipoDocTer"
        Me.txtTipoDocTer.Size = New System.Drawing.Size(51, 26)
        Me.txtTipoDocTer.TabIndex = 125
        '
        'txtDocuTer
        '
        Me.txtDocuTer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocuTer.Location = New System.Drawing.Point(250, 53)
        Me.txtDocuTer.MaxLength = 15
        Me.txtDocuTer.Multiline = True
        Me.txtDocuTer.Name = "txtDocuTer"
        Me.txtDocuTer.Size = New System.Drawing.Size(104, 26)
        Me.txtDocuTer.TabIndex = 126
        '
        'txtRazonSolTer
        '
        Me.txtRazonSolTer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSolTer.Location = New System.Drawing.Point(368, 53)
        Me.txtRazonSolTer.MaxLength = 15
        Me.txtRazonSolTer.Multiline = True
        Me.txtRazonSolTer.Name = "txtRazonSolTer"
        Me.txtRazonSolTer.Size = New System.Drawing.Size(185, 26)
        Me.txtRazonSolTer.TabIndex = 127
        '
        'DtUltimoPago
        '
        Me.DtUltimoPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtUltimoPago.Location = New System.Drawing.Point(635, 128)
        Me.DtUltimoPago.Name = "DtUltimoPago"
        Me.DtUltimoPago.Size = New System.Drawing.Size(139, 22)
        Me.DtUltimoPago.TabIndex = 128
        '
        'LabelPendiente
        '
        Me.LabelPendiente.AutoSize = True
        Me.LabelPendiente.BackColor = System.Drawing.Color.Yellow
        Me.LabelPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPendiente.Location = New System.Drawing.Point(682, 58)
        Me.LabelPendiente.Name = "LabelPendiente"
        Me.LabelPendiente.Size = New System.Drawing.Size(81, 17)
        Me.LabelPendiente.TabIndex = 0
        Me.LabelPendiente.Text = "Pendiente"
        '
        'LabelPagado
        '
        Me.LabelPagado.AutoSize = True
        Me.LabelPagado.BackColor = System.Drawing.Color.YellowGreen
        Me.LabelPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPagado.Location = New System.Drawing.Point(690, 58)
        Me.LabelPagado.Name = "LabelPagado"
        Me.LabelPagado.Size = New System.Drawing.Size(63, 17)
        Me.LabelPagado.TabIndex = 0
        Me.LabelPagado.Text = "Pagado"
        '
        'cboCodigoContable
        '
        Me.cboCodigoContable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCodigoContable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCodigoContable.BackColor = System.Drawing.Color.White
        Me.cboCodigoContable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodigoContable.FormattingEnabled = True
        Me.cboCodigoContable.Items.AddRange(New Object() {"No ", "Si"})
        Me.cboCodigoContable.Location = New System.Drawing.Point(21, 204)
        Me.cboCodigoContable.Name = "cboCodigoContable"
        Me.cboCodigoContable.Size = New System.Drawing.Size(222, 26)
        Me.cboCodigoContable.TabIndex = 130
        '
        'CheckAnulada
        '
        Me.CheckAnulada.AutoSize = True
        Me.CheckAnulada.Enabled = False
        Me.CheckAnulada.Location = New System.Drawing.Point(465, 286)
        Me.CheckAnulada.Name = "CheckAnulada"
        Me.CheckAnulada.Size = New System.Drawing.Size(18, 17)
        Me.CheckAnulada.TabIndex = 132
        Me.CheckAnulada.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Modulo_Facturacion.My.Resources.Resources.iconoEliminar
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(503, 449)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEliminar.Size = New System.Drawing.Size(153, 65)
        Me.btnEliminar.TabIndex = 131
        Me.btnEliminar.Text = "Anular Pago"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseMnemonic = False
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Enabled = False
        Me.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReporte.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.Black
        Me.btnReporte.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_imprimir_40
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(351, 451)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporte.Size = New System.Drawing.Size(139, 65)
        Me.btnReporte.TabIndex = 110
        Me.btnReporte.Text = "Imprimir"
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseMnemonic = False
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPagar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_payroll_40
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(223, 449)
        Me.btnPagar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPagar.Size = New System.Drawing.Size(118, 67)
        Me.btnPagar.TabIndex = 109
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagar.UseMnemonic = False
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'BtnCerrarContratos
        '
        Me.BtnCerrarContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrarContratos.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarContratos.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrarContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarContratos.Location = New System.Drawing.Point(91, 449)
        Me.BtnCerrarContratos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarContratos.Name = "BtnCerrarContratos"
        Me.BtnCerrarContratos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarContratos.Size = New System.Drawing.Size(118, 67)
        Me.BtnCerrarContratos.TabIndex = 108
        Me.BtnCerrarContratos.Text = "Cerrar"
        Me.BtnCerrarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarContratos.UseMnemonic = False
        Me.BtnCerrarContratos.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel8.Controls.Add(Me.Label22)
        Me.Panel8.Location = New System.Drawing.Point(8, 14)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(113, 31)
        Me.Panel8.TabIndex = 90
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(15, 5)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 21)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Cod Modi"
        '
        'GroupModi
        '
        Me.GroupModi.Controls.Add(Me.Panel9)
        Me.GroupModi.Controls.Add(Me.Panel8)
        Me.GroupModi.Controls.Add(Me.txtCodModi)
        Me.GroupModi.Controls.Add(Me.ftModi)
        Me.GroupModi.Location = New System.Drawing.Point(104, 376)
        Me.GroupModi.Name = "GroupModi"
        Me.GroupModi.Size = New System.Drawing.Size(489, 50)
        Me.GroupModi.TabIndex = 100
        Me.GroupModi.TabStop = False
        Me.GroupModi.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Location = New System.Drawing.Point(221, 14)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(113, 31)
        Me.Panel9.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 21)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Fecha Modi"
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupRegis)
        Me.Controls.Add(Me.CheckAnulada)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cboCodigoContable)
        Me.Controls.Add(Me.LabelPendiente)
        Me.Controls.Add(Me.LabelPagado)
        Me.Controls.Add(Me.DtUltimoPago)
        Me.Controls.Add(Me.txtRazonSolTer)
        Me.Controls.Add(Me.txtDocuTer)
        Me.Controls.Add(Me.txtTipoDocTer)
        Me.Controls.Add(Me.DtFechaVencimeinto)
        Me.Controls.Add(Me.DtFechaExpedicion)
        Me.Controls.Add(Me.txtValorIVAFactura)
        Me.Controls.Add(Me.txtValorFactura)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtValorDescuento)
        Me.Controls.Add(Me.txtPagoRealizados)
        Me.Controls.Add(Me.txtImpuestos)
        Me.Controls.Add(Me.txtValorDebito)
        Me.Controls.Add(Me.txtRemision)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.BtnCerrarContratos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtValorCredito)
        Me.Controls.Add(Me.DtFechaMovimiento)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtDetallePago)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.cboFacturas)
        Me.Controls.Add(Me.GroupModi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupRegis.ResumeLayout(False)
        Me.GroupRegis.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupModi.ResumeLayout(False)
        Me.GroupModi.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFacturas As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDetallePago As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupRegis As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents txtCodRegis As TextBox
    Friend WithEvents ftRegis As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DtFechaMovimiento As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorCredito As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCerrarContratos As Button
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRemision As TextBox
    Friend WithEvents txtValorDebito As TextBox
    Friend WithEvents txtImpuestos As TextBox
    Friend WithEvents txtPagoRealizados As TextBox
    Friend WithEvents txtValorDescuento As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtValorFactura As TextBox
    Friend WithEvents txtValorIVAFactura As TextBox
    Friend WithEvents DtFechaExpedicion As DateTimePicker
    Friend WithEvents DtFechaVencimeinto As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoDocTer As TextBox
    Friend WithEvents txtDocuTer As TextBox
    Friend WithEvents txtRazonSolTer As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents DtUltimoPago As DateTimePicker
    Friend WithEvents LabelPendiente As Label
    Friend WithEvents LabelPagado As Label
    Friend WithEvents cboCodigoContable As ComboBox
    Friend WithEvents txtCodModi As TextBox
    Friend WithEvents ftModi As DateTimePicker
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckAnulada As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupModi As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label23 As Label
End Class
