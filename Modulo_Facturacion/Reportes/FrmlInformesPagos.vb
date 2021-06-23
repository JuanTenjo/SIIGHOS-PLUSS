Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class FrmlInformesPagos
    Private Sub FrmlInformesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Emisor

        Dim InformacionDeLaEmpresa As DataSet = SQLDataSET("SELECT * " +
                                                                 "FROM [BDADMINSIG].[dbo].[Datos informacion de la empresa] " +
                                                                 "WHERE [CodUnico] = 00")

        Dim rdsEmisor As ReportDataSource = New ReportDataSource("dsEmisor", InformacionDeLaEmpresa.Tables(0))


        'Vista Cuerpo

        Dim VistaCuerpoFactura As DataSet = SQLDataSET("SELECT [Datos detalles recibos de pago].NumItem, [Datos recibos de pagos].PreRePa, [Datos recibos de pagos].ReciPaga,
                                                        [Datos recibos de pagos].FecRePa, [Datos recibos de pagos].AfeDocu, [Datos recibos de pagos].CardiTer, Trim([Datos proveedores].RazonSol) AS Empresa, 
                                                        [Datos recibos de pagos].TipDoc, [Datos recibos de pagos].NitCCPago, [Datos recibos de pagos].TipPago, [Datos recibos de pagos].DocNum, [Datos recibos de pagos].EntiDocu,
                                                        [Datos recibos de pagos].FecDocu, [Datos recibos de pagos].AnulRePa,
                                                         [Datos recibos de pagos].RazAnula, [Datos recibos de pagos].FecAnul, [Datos recibos de pagos].CodAnul,
                                                         [Datos detalles recibos de pago].CodServi, [Datos detalles recibos de pago].NumDocConta, [Datos detalles recibos de pago].CuenConta,
                                                         [Datos detalles recibos de pago].CantiPaga, [Datos detalles recibos de pago].ValUnita, [Datos detalles recibos de pago].DetaPago,
                                                         [Datos detalles recibos de pago].ValDebito, [Datos detalles recibos de pago].ValCredito
                                                        FROM  (([GEOGRAXPSQL].[dbo].[Datos proveedores] INNER JOIN [DACARTXPSQL].[dbo].[Datos recibos de pagos] ON [Datos proveedores].[IdenProve] = [Datos recibos de pagos].[NitCCPago]) INNER JOIN [DACARTXPSQL].[dbo].[Datos detalles recibos de pago] ON ([Datos recibos de pagos].PreRePa = [Datos detalles recibos de pago].PreRePaD) AND ([Datos recibos de pagos].ReciPaga = [Datos detalles recibos de pago].ReciPagaD))
                                                        WHERE [Datos recibos de pagos].PreRePa + [Datos recibos de pagos].ReciPaga = '" & ModuloVariablesAplicacion.IDpago & "'
                                                        ORDER BY [Datos detalles recibos de pago].NumItem, [Datos recibos de pagos].PreRePa, [Datos recibos de pagos].ReciPaga;")

        Dim rdsDetalle As ReportDataSource = New ReportDataSource("dsDetalle", VistaCuerpoFactura.Tables(0))



        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.ReportViewer1.LocalReport.DataSources.Add(rdsEmisor)
        Me.ReportViewer1.LocalReport.DataSources.Add(rdsDetalle)

        Dim reporte As String = "Modulo_Facturacion." & ModuloVariablesAplicacion.infNombreInforme & ".rdlc"

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = reporte

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

        Me.ReportViewer1.ZoomMode = ZoomMode.Percent

        Me.ReportViewer1.ZoomPercent = 100

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class