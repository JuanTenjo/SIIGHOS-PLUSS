<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteContratos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BDADYSNETDataSet1 = New Modulo_Facturacion.BDADYSNETDataSet1()
        Me.Datos_registros_de_contratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datos_registros_de_contratosTableAdapter = New Modulo_Facturacion.BDADYSNETDataSet1TableAdapters.Datos_registros_de_contratosTableAdapter()
        CType(Me.BDADYSNETDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos_registros_de_contratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetContratos"
        ReportDataSource1.Value = Me.Datos_registros_de_contratosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Modulo_Facturacion.ReportContratos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1235, 662)
        Me.ReportViewer1.TabIndex = 0
        '
        'BDADYSNETDataSet1
        '
        Me.BDADYSNETDataSet1.DataSetName = "BDADYSNETDataSet1"
        Me.BDADYSNETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Datos_registros_de_contratosBindingSource
        '
        Me.Datos_registros_de_contratosBindingSource.DataMember = "Datos registros de contratos"
        Me.Datos_registros_de_contratosBindingSource.DataSource = Me.BDADYSNETDataSet1
        '
        'Datos_registros_de_contratosTableAdapter
        '
        Me.Datos_registros_de_contratosTableAdapter.ClearBeforeFill = True
        '
        'ReporteContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 662)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteContratos"
        Me.Text = "ReporteContratos"
        CType(Me.BDADYSNETDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos_registros_de_contratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Datos_registros_de_contratosBindingSource As BindingSource
    Friend WithEvents BDADYSNETDataSet1 As BDADYSNETDataSet1
    Friend WithEvents Datos_registros_de_contratosTableAdapter As BDADYSNETDataSet1TableAdapters.Datos_registros_de_contratosTableAdapter
End Class
