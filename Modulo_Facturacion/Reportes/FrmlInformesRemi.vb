Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports QRCoder


Public Class FrmlInformesRemi
    Private Sub FrmlInformesRemi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Emisor

        Dim InformacionDeLaEmpresa As DataSet = SQLDataSET("SELECT * " +
                                                                 "FROM [BDADMINSIG].[dbo].[Datos informacion de la empresa] " +
                                                                 "WHERE [CodUnico] = 00")

        Dim rdsEmisor As ReportDataSource = New ReportDataSource("dsEmisor", InformacionDeLaEmpresa.Tables(0))




        'Vista Cuerpo

        Dim VistaCuerpoFactura As DataSet = SQLDataSET("SELECT [Datos detalle de remisiones].ItemNum, [Datos catalogo de producservicios].CodProSer, [Datos catalogo de producservicios].NomProSer, [Datos detalle de remisiones].Concepto, [Datos detalle de remisiones].CantDeta, 
                         [Datos detalle de remisiones].ValUniDeta, [Datos detalle de remisiones].CantDeta * [Datos detalle de remisiones].ValUniDeta AS TotalLinea, [Datos detalle de remisiones].ValIVADeta, 
                         GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, GEOGRAXPSQL.dbo.[Datos proveedores].DigVeri, GEOGRAXPSQL.dbo.[Datos proveedores].RazonSol, 
                         GEOGRAXPSQL.dbo.[Datos proveedores].DireProve, GEOGRAXPSQL.dbo.[Datos proveedores].DirElectro, GEOGRAXPSQL.dbo.[Datos proveedores].TelProve1, GEOGRAXPSQL.dbo.[Datos ciudades del dpto].NombreCiudad, 
                         GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados].NombreDpto, GEOGRAXPSQL.dbo.[Datos de paises].NomPais, [Datos remisiones de facturas].ObserGene, [Datos remisiones de facturas].HorAperRemi, 
                         [Datos remisiones de facturas].NumRemi, [Datos remisiones de facturas].FecAperRemi, [Datos remisiones de facturas].FecCieRemi, [Datos registros de contratos].ContraNo
                         FROM            [Datos catalogo de producservicios] INNER JOIN
                         [Datos detalle de remisiones] ON [Datos catalogo de producservicios].CodProSer = [Datos detalle de remisiones].CodProSer INNER JOIN
                         [Datos remisiones de facturas] ON [Datos detalle de remisiones].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                         [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                         GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados] INNER JOIN
                         GEOGRAXPSQL.dbo.[Datos de paises] ON GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados].CodigoPais = GEOGRAXPSQL.dbo.[Datos de paises].CodiPais INNER JOIN
                         GEOGRAXPSQL.dbo.[Datos ciudades del dpto] ON GEOGRAXPSQL.dbo.[Datos de los Dpto o Estados].CodigoDpto = GEOGRAXPSQL.dbo.[Datos ciudades del dpto].CodigoDpto INNER JOIN
                         GEOGRAXPSQL.dbo.[Datos proveedores] ON GEOGRAXPSQL.dbo.[Datos ciudades del dpto].CodDptoCity = GEOGRAXPSQL.dbo.[Datos proveedores].CodCity ON 
                         [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND 
                         [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
						 WHERE [Datos remisiones de facturas].NumRemi = '" & ModuloVariablesAplicacion.NumRemi & "'")

        Dim rdsDetalle As ReportDataSource = New ReportDataSource("dsDetalle", VistaCuerpoFactura.Tables(0))



        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.ReportViewer1.LocalReport.DataSources.Add(rdsEmisor)
        Me.ReportViewer1.LocalReport.DataSources.Add(rdsDetalle)

        'Me.ReportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(Application.StartupPath + "\Reportes\rdlc", "InfFacturaE.rdlc")



        Dim dr As SqlDataReader
        Dim TotalFac As Double = 0
        Dim ValTotalFac As String = ""



        ModuloVariablesAplicacion.Data = Nothing
        ModuloVariablesAplicacion.Data = "SELECT (SUM([CantDeta] * [ValUniDeta]) + SUM([ValIVADeta])) AS TolSuma  FROM [BDADYSNET].[dbo].[Datos detalle de remisiones] where NumRemi = '" & ModuloVariablesAplicacion.NumRemi & "'"
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