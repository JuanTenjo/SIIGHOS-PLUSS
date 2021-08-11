<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionContabilidad
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionContabilidad))
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridFacturasPendientes = New System.Windows.Forms.DataGridView()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PrefiFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecDocum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipDocTer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocTer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesPercon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoPercon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel17.SuspendLayout()
        CType(Me.DataGridFacturasPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Teal
        Me.Panel17.Controls.Add(Me.Label11)
        Me.Panel17.Location = New System.Drawing.Point(11, 7)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(595, 25)
        Me.Panel17.TabIndex = 115
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(209, 2)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Gestión Contabilidad"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(595, 23)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Facturas pendientes de agregarse a Contabilidad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridFacturasPendientes
        '
        Me.DataGridFacturasPendientes.AllowUserToAddRows = False
        Me.DataGridFacturasPendientes.AllowUserToDeleteRows = False
        Me.DataGridFacturasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFacturasPendientes.BackgroundColor = System.Drawing.Color.White
        Me.DataGridFacturasPendientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridFacturasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturasPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrefiFact, Me.NumFact, Me.FecDocum, Me.TipDocTer, Me.NumDocTer, Me.MesPercon, Me.AñoPercon})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridFacturasPendientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridFacturasPendientes.Location = New System.Drawing.Point(11, 76)
        Me.DataGridFacturasPendientes.MultiSelect = False
        Me.DataGridFacturasPendientes.Name = "DataGridFacturasPendientes"
        Me.DataGridFacturasPendientes.ReadOnly = True
        Me.DataGridFacturasPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridFacturasPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridFacturasPendientes.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridFacturasPendientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridFacturasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFacturasPendientes.Size = New System.Drawing.Size(595, 150)
        Me.DataGridFacturasPendientes.TabIndex = 117
        '
        'BtnEnviar
        '
        Me.BtnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEnviar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_reenviar_mensaje_30
        Me.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnviar.Location = New System.Drawing.Point(214, 229)
        Me.BtnEnviar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEnviar.Size = New System.Drawing.Size(90, 47)
        Me.BtnEnviar.TabIndex = 118
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEnviar.UseMnemonic = False
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(309, 229)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrar.Size = New System.Drawing.Size(90, 47)
        Me.BtnCerrar.TabIndex = 114
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrar.UseMnemonic = False
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PrefiFact
        '
        Me.PrefiFact.HeaderText = "PrefiFact"
        Me.PrefiFact.Name = "PrefiFact"
        Me.PrefiFact.ReadOnly = True
        '
        'NumFact
        '
        Me.NumFact.HeaderText = "NumFact"
        Me.NumFact.Name = "NumFact"
        Me.NumFact.ReadOnly = True
        '
        'FecDocum
        '
        Me.FecDocum.HeaderText = "FecDocum"
        Me.FecDocum.Name = "FecDocum"
        Me.FecDocum.ReadOnly = True
        '
        'TipDocTer
        '
        Me.TipDocTer.HeaderText = "TipDocTer"
        Me.TipDocTer.Name = "TipDocTer"
        Me.TipDocTer.ReadOnly = True
        '
        'NumDocTer
        '
        Me.NumDocTer.HeaderText = "NumDocTer"
        Me.NumDocTer.Name = "NumDocTer"
        Me.NumDocTer.ReadOnly = True
        '
        'MesPercon
        '
        Me.MesPercon.HeaderText = "MesPercon"
        Me.MesPercon.Name = "MesPercon"
        Me.MesPercon.ReadOnly = True
        '
        'AñoPercon
        '
        Me.AñoPercon.HeaderText = "AñoPercon"
        Me.AñoPercon.Name = "AñoPercon"
        Me.AñoPercon.ReadOnly = True
        '
        'GestionContabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 290)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.DataGridFacturasPendientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.BtnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionContabilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionContabilidad"
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.DataGridFacturasPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents DataGridFacturasPendientes As DataGridView
    Friend WithEvents PrefiFact As DataGridViewTextBoxColumn
    Friend WithEvents NumFact As DataGridViewTextBoxColumn
    Friend WithEvents FecDocum As DataGridViewTextBoxColumn
    Friend WithEvents TipDocTer As DataGridViewTextBoxColumn
    Friend WithEvents NumDocTer As DataGridViewTextBoxColumn
    Friend WithEvents MesPercon As DataGridViewTextBoxColumn
    Friend WithEvents AñoPercon As DataGridViewTextBoxColumn
End Class
