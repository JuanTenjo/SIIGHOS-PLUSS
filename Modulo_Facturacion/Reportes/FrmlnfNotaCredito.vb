Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports QRCoder

Public Class FrmlnfNotaCredito
    Private Sub FrmlnfNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ModuloVariablesAplicacion.Data = ""
        ModuloVariablesAplicacion.Data = "SELECT df.CodEstaDian, df.CodCuDe FROM [BDADYSNET].[dbo].[Datos notas creditos facturas] as df 
                                              WHERE df.PrefiNotCre = '" & ModuloVariablesAplicacion.PrefiNotCre & "' AND df.NumNoCre = '" & ModuloVariablesAplicacion.NumNoCre & "' AND df.DocuCredito = '" & ModuloVariablesAplicacion.NumFact & "'"

        Dim reader As SqlDataReader = SQLReader(ModuloVariablesAplicacion.Data)

        If reader.HasRows = False Then
            MsgBox("No se encontro esta nota credito")
            cn.Close()
            Exit Sub
        Else

            reader.Read()



            If reader("CodEstaDian") = "02" Or reader("CodEstaDian") = "03" Or reader("CodEstaDian") = "05" Then
                ModuloVariablesAplicacion.QR = ("https://catalogo-vpfe.dian.gov.co/document/searchqr?documentkey=" + reader("CodCuDe"))
            Else
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero solo se puede realizar copias a documentos Validados" & Chr(13) & Chr(10)
                Informa += " Enviado al cliente o por rebote de correo al enviar." & Chr(13) & Chr(10)
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn.Close()
                Exit Sub
            End If

        End If

        reader.Close()
        cn.Close()



        'Emisor

        Dim InformacionDeLaEmpresa As DataSet = SQLDataSET("SELECT * " +
                                                                 "FROM [BDADMINSIG].[dbo].[Datos informacion de la empresa] " +
                                                                 "WHERE [CodUnico] = 00")

        Dim rdsEmisor As ReportDataSource = New ReportDataSource("dsEmisor", InformacionDeLaEmpresa.Tables(0))




        'Vista Cuerpo

        Dim VistaCuerpoFactura As DataSet = SQLDataSET("SELECT * FROM [BDADYSNET].[dbo].[Vista_Nota_Credito] WHERE (NumNoCre = '" + ModuloVariablesAplicacion.NumNoCre + "') And (PrefiNotCre = '" + ModuloVariablesAplicacion.PrefiNotCre + "') AND (NumFact = '" + ModuloVariablesAplicacion.NumFact + "') AND (PrefiFact = '" + ModuloVariablesAplicacion.PrefiFact + "')")








        Dim rdsDetalle As ReportDataSource = New ReportDataSource("dsDetalle", VistaCuerpoFactura.Tables(0))



        'Genera el Codigo QR

        Dim generator As New QRCodeGenerator
        Dim data = generator.CreateQrCode(ModuloVariablesAplicacion.QR, QRCodeGenerator.ECCLevel.Q)
        Dim qr As New QRCode(data)
        Dim bmp As Bitmap = qr.GetGraphic(7)


        Dim dsInf As dsInfFacturaElec = New dsInfFacturaElec()

        Dim Row As dsInfFacturaElec.QRcodeRow = dsInf.QRcode.NewQRcodeRow()
        Dim rdsQR As ReportDataSource = New ReportDataSource()


        Dim ms As MemoryStream = New MemoryStream()
        Using (ms)
            bmp.Save(ms, ImageFormat.Bmp)
            Row.imagen = ms.ToArray()
            dsInf.QRcode.AddQRcodeRow(Row)
            rdsQR.Name = "dsQR"
            rdsQR.Value = dsInf.QRcode
        End Using


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.ReportViewer1.LocalReport.DataSources.Add(rdsQR)
        Me.ReportViewer1.LocalReport.DataSources.Add(rdsEmisor)
        Me.ReportViewer1.LocalReport.DataSources.Add(rdsDetalle)

        'Me.ReportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(Application.StartupPath + "\Reportes\rdlc", "InfFacturaE.rdlc")



        Dim dr As SqlDataReader
        Dim TotalFac As Double = 0
        Dim ValTotalFac As String = ""



        ModuloVariablesAplicacion.Data = Nothing
        ModuloVariablesAplicacion.Data = "SELECT SUM([TotalDeta] + [ValIvaFac]) TolSuma FROM [BDADYSNET].[dbo].[Vista_Nota_Credito]  WHERE (NumNoCre = '" + ModuloVariablesAplicacion.NumNoCre + "')  AND (PrefiNotCre = '" + ModuloVariablesAplicacion.PrefiNotCre + "')  AND (NumFact = '" + ModuloVariablesAplicacion.NumFact + "')   AND (PrefiFact = '" + ModuloVariablesAplicacion.PrefiFact + "')"



        dr = SQLReader(ModuloVariablesAplicacion.Data)

        If dr.HasRows Then
            dr.Read()
            TotalFac = Convert.ToDouble(dr("TolSuma"))
            cn.Close()

        Else
            MsgBox("No se encontro los valores de esta factura")
            cn.Close()
            Exit Sub
        End If


        ValTotalFac = NumaLetras(TotalFac)

        Dim reporte As String = "Modulo_Facturacion." & ModuloVariablesAplicacion.infNombreInforme & ".rdlc"

        Dim parametros As New List(Of ReportParameter)()

        parametros.Add(New ReportParameter("ValorLetras", ValTotalFac))

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = reporte

        Me.ReportViewer1.LocalReport.SetParameters(parametros)

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

        Me.ReportViewer1.ZoomMode = ZoomMode.Percent

        Me.ReportViewer1.ZoomPercent = 100

        Me.ReportViewer1.RefreshReport()

    End Sub


End Class