Public Class ReporteContratos
    Private Sub ReporteContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDADYSNETDataSet1.Datos_registros_de_contratos' Puede moverla o quitarla según sea necesario.
        Me.Datos_registros_de_contratosTableAdapter.Fill(Me.BDADYSNETDataSet1.Datos_registros_de_contratos)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class