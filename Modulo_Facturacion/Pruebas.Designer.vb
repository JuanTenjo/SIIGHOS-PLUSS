<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pruebas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGenerarQR = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.Prefi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumRemi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDContrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecExpFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValNetoFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValIVAFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.NumeroTexto = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 258)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 78)
        Me.TextBox1.TabIndex = 0
        '
        'btnGenerarQR
        '
        Me.btnGenerarQR.BackColor = System.Drawing.Color.White
        Me.btnGenerarQR.Location = New System.Drawing.Point(21, 340)
        Me.btnGenerarQR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerarQR.Name = "btnGenerarQR"
        Me.btnGenerarQR.Size = New System.Drawing.Size(169, 38)
        Me.btnGenerarQR.TabIndex = 2
        Me.btnGenerarQR.Text = "Generar"
        Me.btnGenerarQR.UseVisualStyleBackColor = False
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.White
        Me.pic.Location = New System.Drawing.Point(21, 10)
        Me.pic.Margin = New System.Windows.Forms.Padding(2)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(356, 244)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic.TabIndex = 3
        Me.pic.TabStop = False
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.White
        Me.Imprimir.Location = New System.Drawing.Point(208, 340)
        Me.Imprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(169, 38)
        Me.Imprimir.TabIndex = 4
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.UseVisualStyleBackColor = False
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFacturas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Prefi, Me.NumFact, Me.NumRemi, Me.IDContrato, Me.FecExpFac, Me.ValNetoFac, Me.ValIVAFac})
        Me.DataGridFacturas.Location = New System.Drawing.Point(381, 11)
        Me.DataGridFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridFacturas.MultiSelect = False
        Me.DataGridFacturas.Name = "DataGridFacturas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridFacturas.RowHeadersVisible = False
        Me.DataGridFacturas.RowHeadersWidth = 51
        Me.DataGridFacturas.RowTemplate.Height = 24
        Me.DataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFacturas.Size = New System.Drawing.Size(453, 72)
        Me.DataGridFacturas.TabIndex = 90
        '
        'Prefi
        '
        Me.Prefi.FillWeight = 51.99229!
        Me.Prefi.HeaderText = "Prefi"
        Me.Prefi.MaxInputLength = 2
        Me.Prefi.MinimumWidth = 6
        Me.Prefi.Name = "Prefi"
        '
        'NumFact
        '
        Me.NumFact.HeaderText = "NumFact"
        Me.NumFact.MinimumWidth = 6
        Me.NumFact.Name = "NumFact"
        '
        'NumRemi
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.NumRemi.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumRemi.FillWeight = 98.93101!
        Me.NumRemi.HeaderText = "NumRemi"
        Me.NumRemi.MinimumWidth = 6
        Me.NumRemi.Name = "NumRemi"
        '
        'IDContrato
        '
        Me.IDContrato.FillWeight = 98.93101!
        Me.IDContrato.HeaderText = "IDContrato"
        Me.IDContrato.MaxInputLength = 15
        Me.IDContrato.MinimumWidth = 6
        Me.IDContrato.Name = "IDContrato"
        '
        'FecExpFac
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FecExpFac.DefaultCellStyle = DataGridViewCellStyle2
        Me.FecExpFac.FillWeight = 98.93101!
        Me.FecExpFac.HeaderText = "FecExpFac"
        Me.FecExpFac.MaxInputLength = 10
        Me.FecExpFac.MinimumWidth = 6
        Me.FecExpFac.Name = "FecExpFac"
        '
        'ValNetoFac
        '
        Me.ValNetoFac.FillWeight = 98.93101!
        Me.ValNetoFac.HeaderText = "ValNetoFac"
        Me.ValNetoFac.MinimumWidth = 6
        Me.ValNetoFac.Name = "ValNetoFac"
        Me.ValNetoFac.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ValIVAFac
        '
        Me.ValIVAFac.HeaderText = "ValIVAFac"
        Me.ValIVAFac.MinimumWidth = 6
        Me.ValIVAFac.Name = "ValIVAFac"
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(767, 144)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertir.TabIndex = 91
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(615, 144)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(146, 20)
        Me.txtNumero.TabIndex = 92
        '
        'NumeroTexto
        '
        Me.NumeroTexto.AutoSize = True
        Me.NumeroTexto.Location = New System.Drawing.Point(397, 196)
        Me.NumeroTexto.Name = "NumeroTexto"
        Me.NumeroTexto.Size = New System.Drawing.Size(39, 13)
        Me.NumeroTexto.TabIndex = 93
        Me.NumeroTexto.Text = "Label1"
        '
        'Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 421)
        Me.Controls.Add(Me.NumeroTexto)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.btnGenerarQR)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pruebas"
        Me.Text = "Pruebas"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnGenerarQR As Button
    Friend WithEvents pic As PictureBox
    Friend WithEvents Imprimir As Button
    Friend WithEvents DataGridFacturas As DataGridView
    Friend WithEvents Prefi As DataGridViewTextBoxColumn
    Friend WithEvents NumFact As DataGridViewTextBoxColumn
    Friend WithEvents NumRemi As DataGridViewTextBoxColumn
    Friend WithEvents IDContrato As DataGridViewTextBoxColumn
    Friend WithEvents FecExpFac As DataGridViewTextBoxColumn
    Friend WithEvents ValNetoFac As DataGridViewTextBoxColumn
    Friend WithEvents ValIVAFac As DataGridViewTextBoxColumn
    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents NumeroTexto As Label
End Class
