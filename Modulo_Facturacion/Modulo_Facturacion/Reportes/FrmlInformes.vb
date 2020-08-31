Imports Microsoft.Reporting.WinForms

Public Class FrmlInformes
    Private Sub FrmlInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reporte As String
        Dim rds1 As ReportDataSource

        'Colocamos nombre al reporte
        Me.Text = ModuloVariablesAplicacion.InfTituloInforme

        reporte = "Modulo_Facturacion." & ModuloVariablesAplicacion.infNombreInforme & ".rdlc"

        Dim DsInformes1 As DataSet = SQLDataSET(ModuloVariablesAplicacion.InfConsultaReporte)

        rds1 = New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", DsInformes1.Tables(0))


        Me.ReportViewer1.Reset()
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.ReportViewer1.LocalReport.DataSources.Add(rds1)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = reporte
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomMode = 100

    End Sub
End Class