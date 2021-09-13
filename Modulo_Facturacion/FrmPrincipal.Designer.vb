<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemisionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionCuentasContablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.NotaCreditoToolStripMenuItem, Me.NotaDebitoToolStripMenuItem, Me.ParametrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemisionesToolStripMenuItem1, Me.FacturasToolStripMenuItem1, Me.PagosToolStripMenuItem1})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'RemisionesToolStripMenuItem1
        '
        Me.RemisionesToolStripMenuItem1.Name = "RemisionesToolStripMenuItem1"
        Me.RemisionesToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.RemisionesToolStripMenuItem1.Text = "Remisiones"
        '
        'FacturasToolStripMenuItem1
        '
        Me.FacturasToolStripMenuItem1.Name = "FacturasToolStripMenuItem1"
        Me.FacturasToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.FacturasToolStripMenuItem1.Text = "Facturas"
        '
        'PagosToolStripMenuItem1
        '
        Me.PagosToolStripMenuItem1.Name = "PagosToolStripMenuItem1"
        Me.PagosToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.PagosToolStripMenuItem1.Text = "Pagos"
        '
        'NotaCreditoToolStripMenuItem
        '
        Me.NotaCreditoToolStripMenuItem.Name = "NotaCreditoToolStripMenuItem"
        Me.NotaCreditoToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.NotaCreditoToolStripMenuItem.Text = "Nota Credito"
        '
        'NotaDebitoToolStripMenuItem
        '
        Me.NotaDebitoToolStripMenuItem.Name = "NotaDebitoToolStripMenuItem"
        Me.NotaDebitoToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.NotaDebitoToolStripMenuItem.Text = "Nota Debito"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvedoresToolStripMenuItem, Me.ContratosToolStripMenuItem1, Me.ProducServiciosToolStripMenuItem, Me.GestionCuentasContablesToolStripMenuItem})
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ParametrosToolStripMenuItem.Text = "Parametros"
        '
        'ProvedoresToolStripMenuItem
        '
        Me.ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        Me.ProvedoresToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ProvedoresToolStripMenuItem.Text = "Provedores"
        '
        'ContratosToolStripMenuItem1
        '
        Me.ContratosToolStripMenuItem1.Name = "ContratosToolStripMenuItem1"
        Me.ContratosToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.ContratosToolStripMenuItem1.Text = "Contratos"
        '
        'ProducServiciosToolStripMenuItem
        '
        Me.ProducServiciosToolStripMenuItem.Name = "ProducServiciosToolStripMenuItem"
        Me.ProducServiciosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ProducServiciosToolStripMenuItem.Text = "ProducServicios"
        '
        'GestionCuentasContablesToolStripMenuItem
        '
        Me.GestionCuentasContablesToolStripMenuItem.Name = "GestionCuentasContablesToolStripMenuItem"
        Me.GestionCuentasContablesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GestionCuentasContablesToolStripMenuItem.Text = "Gestion Cuentas Contables"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 427)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACION  0.0.4 (13/09/2021)  *** ADYSNET ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NotaCreditoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotaDebitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemisionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProducServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionCuentasContablesToolStripMenuItem As ToolStripMenuItem
End Class
