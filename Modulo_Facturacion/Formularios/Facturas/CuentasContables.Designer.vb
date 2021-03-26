<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CuentasContables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentasContables))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridCuentasContables = New System.Windows.Forms.DataGridView()
        Me.NumCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(9, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 21)
        Me.Panel1.TabIndex = 143
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(125, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(233, 19)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Cuentas contables del pago"
        '
        'Panel15
        '
        Me.Panel15.BackgroundImage = CType(resources.GetObject("Panel15.BackgroundImage"), System.Drawing.Image)
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel15.Location = New System.Drawing.Point(9, 36)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(16, 21)
        Me.Panel15.TabIndex = 164
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(26, 35)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(441, 22)
        Me.txtBuscar.TabIndex = 163
        '
        'DataGridCuentasContables
        '
        Me.DataGridCuentasContables.AllowUserToAddRows = False
        Me.DataGridCuentasContables.AllowUserToDeleteRows = False
        Me.DataGridCuentasContables.AllowUserToResizeRows = False
        Me.DataGridCuentasContables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCuentasContables.BackgroundColor = System.Drawing.Color.White
        Me.DataGridCuentasContables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridCuentasContables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridCuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCuentasContables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCuenta, Me.NombreCuenta})
        Me.DataGridCuentasContables.Location = New System.Drawing.Point(27, 61)
        Me.DataGridCuentasContables.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridCuentasContables.MultiSelect = False
        Me.DataGridCuentasContables.Name = "DataGridCuentasContables"
        Me.DataGridCuentasContables.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCuentasContables.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCuentasContables.RowHeadersVisible = False
        Me.DataGridCuentasContables.RowHeadersWidth = 51
        Me.DataGridCuentasContables.RowTemplate.Height = 24
        Me.DataGridCuentasContables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCuentasContables.Size = New System.Drawing.Size(440, 303)
        Me.DataGridCuentasContables.TabIndex = 165
        '
        'NumCuenta
        '
        Me.NumCuenta.FillWeight = 50.76142!
        Me.NumCuenta.HeaderText = "NumCuenta"
        Me.NumCuenta.Name = "NumCuenta"
        Me.NumCuenta.ReadOnly = True
        '
        'NombreCuenta
        '
        Me.NombreCuenta.FillWeight = 149.2386!
        Me.NombreCuenta.HeaderText = "Nombre Cuenta"
        Me.NombreCuenta.Name = "NombreCuenta"
        Me.NombreCuenta.ReadOnly = True
        '
        'CuentasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 375)
        Me.Controls.Add(Me.DataGridCuentasContables)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CuentasContables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "-"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DataGridCuentasContables As DataGridView
    Friend WithEvents NumCuenta As DataGridViewTextBoxColumn
    Friend WithEvents NombreCuenta As DataGridViewTextBoxColumn
End Class
