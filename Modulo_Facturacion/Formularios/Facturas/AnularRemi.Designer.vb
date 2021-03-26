<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnularRemi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnularRemi))
        Me.txtRazonAnulRemi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.BtnCancelarAnulRemi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRazonAnulRemi
        '
        Me.txtRazonAnulRemi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonAnulRemi.Location = New System.Drawing.Point(12, 43)
        Me.txtRazonAnulRemi.Multiline = True
        Me.txtRazonAnulRemi.Name = "txtRazonAnulRemi"
        Me.txtRazonAnulRemi.Size = New System.Drawing.Size(373, 45)
        Me.txtRazonAnulRemi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Razon de anulacion."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnular
        '
        Me.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnular.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Image = Global.Modulo_Facturacion.My.Resources.Resources.iconoEliminar
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnular.Location = New System.Drawing.Point(80, 97)
        Me.btnAnular.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnular.Size = New System.Drawing.Size(94, 50)
        Me.btnAnular.TabIndex = 90
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAnular.UseCompatibleTextRendering = True
        Me.btnAnular.UseMnemonic = False
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'BtnCancelarAnulRemi
        '
        Me.BtnCancelarAnulRemi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelarAnulRemi.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarAnulRemi.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCancelarAnulRemi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarAnulRemi.Location = New System.Drawing.Point(201, 97)
        Me.BtnCancelarAnulRemi.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCancelarAnulRemi.Name = "BtnCancelarAnulRemi"
        Me.BtnCancelarAnulRemi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCancelarAnulRemi.Size = New System.Drawing.Size(100, 51)
        Me.BtnCancelarAnulRemi.TabIndex = 91
        Me.BtnCancelarAnulRemi.Text = "Cancelar"
        Me.BtnCancelarAnulRemi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelarAnulRemi.UseMnemonic = False
        Me.BtnCancelarAnulRemi.UseVisualStyleBackColor = True
        '
        'AnularRemi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelarAnulRemi)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRazonAnulRemi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnularRemi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnularRemi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRazonAnulRemi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnular As Button
    Friend WithEvents BtnCancelarAnulRemi As Button
End Class
