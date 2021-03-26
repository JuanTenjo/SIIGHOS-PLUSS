<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CuentasBancariasProve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentasBancariasProve))
        Me.lblCuentasProvedor = New System.Windows.Forms.ListBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBancos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservacionesBanco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumeroDeCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBorrarCuenta = New System.Windows.Forms.Button()
        Me.btnGuardarCue = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnCerrarProvedores = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel17.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCuentasProvedor
        '
        Me.lblCuentasProvedor.ColumnWidth = 1
        Me.lblCuentasProvedor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentasProvedor.FormattingEnabled = True
        Me.lblCuentasProvedor.ItemHeight = 21
        Me.lblCuentasProvedor.Location = New System.Drawing.Point(320, 123)
        Me.lblCuentasProvedor.Name = "lblCuentasProvedor"
        Me.lblCuentasProvedor.Size = New System.Drawing.Size(444, 298)
        Me.lblCuentasProvedor.TabIndex = 0
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Teal
        Me.Panel17.Controls.Add(Me.Label6)
        Me.Panel17.Location = New System.Drawing.Point(320, 58)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(444, 26)
        Me.Panel17.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(160, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Lista Cuentas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.cboTipoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboBancos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtObservacionesBanco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumeroDeCuenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(41, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 320)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.Location = New System.Drawing.Point(6, 186)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(199, 26)
        Me.cboTipoCuenta.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "TipoCuenta"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(-3, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 26)
        Me.Label9.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Observaciones"
        '
        'cboBancos
        '
        Me.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBancos.DropDownWidth = 300
        Me.cboBancos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBancos.FormattingEnabled = True
        Me.cboBancos.Location = New System.Drawing.Point(6, 119)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.Size = New System.Drawing.Size(199, 26)
        Me.cboBancos.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Bancos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Numero De Cuenta"
        '
        'txtObservacionesBanco
        '
        Me.txtObservacionesBanco.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesBanco.Location = New System.Drawing.Point(6, 248)
        Me.txtObservacionesBanco.MaxLength = 250
        Me.txtObservacionesBanco.Multiline = True
        Me.txtObservacionesBanco.Name = "txtObservacionesBanco"
        Me.txtObservacionesBanco.Size = New System.Drawing.Size(199, 44)
        Me.txtObservacionesBanco.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(0, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 44)
        Me.Label3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(-3, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 2
        '
        'txtNumeroDeCuenta
        '
        Me.txtNumeroDeCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeCuenta.Location = New System.Drawing.Point(6, 57)
        Me.txtNumeroDeCuenta.MaxLength = 15
        Me.txtNumeroDeCuenta.Multiline = True
        Me.txtNumeroDeCuenta.Name = "txtNumeroDeCuenta"
        Me.txtNumeroDeCuenta.Size = New System.Drawing.Size(199, 26)
        Me.txtNumeroDeCuenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(-3, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 26)
        Me.Label1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(41, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 26)
        Me.Panel1.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(61, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 24)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Datos Cuenta"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 38)
        Me.Panel2.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(301, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 24)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Cuentas Bancarias"
        '
        'btnBorrarCuenta
        '
        Me.btnBorrarCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBorrarCuenta.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarCuenta.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_eliminar_40
        Me.btnBorrarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarCuenta.Location = New System.Drawing.Point(151, 436)
        Me.btnBorrarCuenta.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBorrarCuenta.Name = "btnBorrarCuenta"
        Me.btnBorrarCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBorrarCuenta.Size = New System.Drawing.Size(146, 67)
        Me.btnBorrarCuenta.TabIndex = 39
        Me.btnBorrarCuenta.Text = "Borrar"
        Me.btnBorrarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrarCuenta.UseMnemonic = False
        Me.btnBorrarCuenta.UseVisualStyleBackColor = True
        '
        'btnGuardarCue
        '
        Me.btnGuardarCue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardarCue.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCue.Image = CType(resources.GetObject("btnGuardarCue.Image"), System.Drawing.Image)
        Me.btnGuardarCue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarCue.Location = New System.Drawing.Point(151, 436)
        Me.btnGuardarCue.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardarCue.Name = "btnGuardarCue"
        Me.btnGuardarCue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGuardarCue.Size = New System.Drawing.Size(146, 67)
        Me.btnGuardarCue.TabIndex = 36
        Me.btnGuardarCue.Text = "Guardar"
        Me.btnGuardarCue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarCue.UseMnemonic = False
        Me.btnGuardarCue.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_banco_40
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(23, 436)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNuevo.Size = New System.Drawing.Size(117, 67)
        Me.btnNuevo.TabIndex = 35
        Me.btnNuevo.Text = "Nueva"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseMnemonic = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCerrarProvedores
        '
        Me.BtnCerrarProvedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrarProvedores.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarProvedores.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrarProvedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarProvedores.Location = New System.Drawing.Point(653, 427)
        Me.BtnCerrarProvedores.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarProvedores.Name = "BtnCerrarProvedores"
        Me.BtnCerrarProvedores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarProvedores.Size = New System.Drawing.Size(118, 67)
        Me.BtnCerrarProvedores.TabIndex = 33
        Me.BtnCerrarProvedores.Text = "Cerrar"
        Me.BtnCerrarProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarProvedores.UseMnemonic = False
        Me.BtnCerrarProvedores.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel12.Controls.Add(Me.Label22)
        Me.Panel12.Controls.Add(Me.Label25)
        Me.Panel12.Controls.Add(Me.Label24)
        Me.Panel12.Location = New System.Drawing.Point(320, 84)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(446, 39)
        Me.Panel12.TabIndex = 40
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(3, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 21)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "TipoCuenta"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(306, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 21)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Banco"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(160, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 21)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Num Cuenta"
        '
        'CuentasBancariasProve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(780, 530)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.btnBorrarCuenta)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardarCue)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.BtnCerrarProvedores)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.lblCuentasProvedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CuentasBancariasProve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuentasBancariasProve"
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCuentasProvedor As ListBox
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BtnCerrarProvedores As Button
    Friend WithEvents btnGuardarCue As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtObservacionesBanco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumeroDeCuenta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBancos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboTipoCuenta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBorrarCuenta As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
End Class
