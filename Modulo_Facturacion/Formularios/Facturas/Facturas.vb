
Imports System.Data.SqlClient


Public Class Facturas
    Dim Bandera As Int16 = 0
#Region "ComboBox"
    Private Sub CargarComboBox()
        Dim Provedores As DataSet = SQLDataSET("SELECT p.TipoDocu + p.IdenProve + p.SucurProv as identificador, p.IdenProve + '  ' + p.RazonSol as DatosProve
                                                from [GEOGRAXPSQL].[dbo].[Datos proveedores] p inner join [Datos registros de contratos] r
                                                on p.IdenProve = r.NumDocContra
                                                and p.TipoDocu = r.TipDocContra
                                                and p.SucurProv = r.CodSucContra
                                                where p.HabilPro = 1
                                                group by p.TipoDocu + p.IdenProve + p.SucurProv, p.IdenProve + '  ' + p.RazonSol")
        cboProvedores.DataSource = Provedores.Tables(0)
        cboProvedores.DisplayMember = "DatosProve"
        cboProvedores.ValueMember = "identificador"
    End Sub
    Private Sub cboProvedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvedores.SelectedIndexChanged
        If Bandera = 1 Then
            DataGridFacturas.Rows.Clear()
            BuscarContratos(cboProvedores.SelectedValue)
        End If

    End Sub
    Private Sub cboContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContratos.SelectedIndexChanged
        If Bandera = 1 Then
            If checkFiltroProve.Checked = True Then
                MsgBox("Desmarca la casilla de todas para filtrar por contrato")
            Else
                Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                      FROM     [Datos facturas realizadas] INNER JOIN
                                      [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                      [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                      GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                      [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                      WHERE ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND ([Datos registros de contratos].ID_Contratos = '" & cboContratos.SelectedValue & "') AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                CargarFacturas(consulta)
            End If
        End If

    End Sub

#End Region

#Region "Botones tex, datepicker, checbox"
    Private Sub btnImprimeTodas_Click(sender As Object, e As EventArgs) Handles btnImprimeTodas.Click
        Try
            If Bandera = 1 Then
                If checkFiltroProve.Checked = True Then
                    Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, GEOGRAXPSQL.dbo.[Datos proveedores].[CityProve], [Datos facturas realizadas].NumRemi,
                                                 [Datos facturas realizadas].FecExpFac, [Datos registros de contratos].ID_Contratos,
                                                 [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac,
                                                 [Datos facturas realizadas].ValNetoFac + [Datos facturas realizadas].ValIVAFac as Total, [Datos facturas realizadas].FactAnula
                                                FROM     [Datos facturas realizadas] INNER JOIN
                                                [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                                [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                                GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                                [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                                WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND  ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"

                    ModuloVariablesAplicacion.InfConsultaReporte = consulta
                    ModuloVariablesAplicacion.InfCabecera = "Facturas Por Tercero"
                    ModuloVariablesAplicacion.InfTituloInforme = "Reporte de Facturas"
                    ModuloVariablesAplicacion.infNombreInforme = "ReportFacturasAgrupadas"
                    Dim FrmsInformes As New FrmlInformes
                    FrmlInformes.ShowDialog()
                Else
                    Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, GEOGRAXPSQL.dbo.[Datos proveedores].[CityProve], [Datos facturas realizadas].NumRemi,
                                                 [Datos facturas realizadas].FecExpFac, [Datos registros de contratos].ID_Contratos,
                                                 [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac,
                                                 [Datos facturas realizadas].ValNetoFac + [Datos facturas realizadas].ValIVAFac as Total, [Datos facturas realizadas].FactAnula
                                                FROM     [Datos facturas realizadas] INNER JOIN
                                                [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                                [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                                GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                                [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                                WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND  ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND
                                                ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND ([Datos registros de contratos].ID_Contratos = '" & cboContratos.SelectedValue & "') AND
                                                (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"

                    ModuloVariablesAplicacion.InfConsultaReporte = consulta
                    ModuloVariablesAplicacion.InfCabecera = "Facturas Por Tercero"
                    ModuloVariablesAplicacion.InfTituloInforme = "Reporte de Facturas"
                    ModuloVariablesAplicacion.infNombreInforme = "ReportFacturasAgrupadas"
                    Dim FrmsInformes As New FrmlInformes
                    FrmlInformes.ShowDialog()
                End If
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += " Al crear el reporte de todas las facturas de la grilla" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ftDesde_ValueChanged(sender As Object, e As EventArgs) Handles ftDesde.ValueChanged
        If Bandera = 1 Then
            If checkFiltroProve.Checked = True Then
                Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                              FROM     [Datos facturas realizadas] INNER JOIN
                                              [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                              [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                              GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                              [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                              WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND  ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                CargarFacturas(consulta)
            Else
                Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                      FROM     [Datos facturas realizadas] INNER JOIN
                                      [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                      [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                      GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                      [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                      WHERE ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND ([Datos registros de contratos].ID_Contratos = '" & cboContratos.SelectedValue & "') AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                CargarFacturas(consulta)
            End If
        End If '
    End Sub
    Private Sub ftHasta_ValueChanged(sender As Object, e As EventArgs) Handles ftHasta.ValueChanged
        If Bandera = 1 Then
            If checkFiltroProve.Checked = True Then
                Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                              FROM     [Datos facturas realizadas] INNER JOIN
                                              [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                              [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                              GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                              [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                              WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND  ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                CargarFacturas(consulta)
            Else
                Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                      FROM     [Datos facturas realizadas] INNER JOIN
                                      [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                      [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                      GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                      [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                      WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND ([Datos registros de contratos].ID_Contratos = '" & cboContratos.SelectedValue & "') AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                CargarFacturas(consulta)
            End If
        End If
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
    Private Sub txtBuscarFactura_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarFactura.TextChanged
        Try
            If String.IsNullOrWhiteSpace(txtBuscarFactura.Text) = False And Bandera = 1 Then
                If checkFiltroProve.Checked = True Then
                    Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                              FROM     [Datos facturas realizadas] INNER JOIN
                                              [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                              [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                              GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                              [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                              WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND  ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                    CargarFacturas(consulta)
                Else
                    Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                      FROM     [Datos facturas realizadas] INNER JOIN
                                      [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                      [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                      GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                      [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                      WHERE ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND ([Datos registros de contratos].ID_Contratos = '" & cboContratos.SelectedValue & "') AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                    CargarFacturas(consulta)
                End If

            End If
        Catch ex As Exception
            MsgBox("Error el filtro de factura")
        End Try
    End Sub
    Private Sub checkFiltroProve_CheckedChanged(sender As Object, e As EventArgs) Handles checkFiltroProve.CheckedChanged
        Try
            If cboProvedores.SelectedIndex >= 0 Then
                If checkFiltroProve.Checked = True Then
                    Dim consulta As String = "SELECT [Datos facturas realizadas].PrefiFact, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].NumRemi, [Datos facturas realizadas].FecExpFac, [Datos facturas realizadas].ValNetoFac, [Datos facturas realizadas].ValIVAFac, GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve, [Datos registros de contratos].ID_Contratos
                                              FROM     [Datos facturas realizadas] INNER JOIN
                                              [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                              [Datos registros de contratos] ON [Datos remisiones de facturas].ID_Contratos = [Datos registros de contratos].ID_Contratos INNER JOIN
                                              GEOGRAXPSQL.dbo.[Datos proveedores] ON [Datos registros de contratos].TipDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu AND 
                                              [Datos registros de contratos].NumDocContra = GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve AND [Datos registros de contratos].CodSucContra = GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv
                                              WHERE ([Datos facturas realizadas].CodEstaDian NOT IN ('00', '01', '04')) AND ([Datos facturas realizadas].FactAnula = 0) AND ([Datos facturas realizadas].FecExpFac BETWEEN  '" & Format(ftDesde.Value.Date, "yyyy-MM-dd") & "' AND  '" & Format(ftHasta.Value.Date, "yyyy-MM-dd") & "') AND ([Datos facturas realizadas].NumFact like '%'+'" & txtBuscarFactura.Text & "'+'%') AND ([Datos remisiones de facturas].RemiActiva = 1) AND ([Datos registros de contratos].EstaVigCon = 1) AND (GEOGRAXPSQL.dbo.[Datos proveedores].TipoDocu + GEOGRAXPSQL.dbo.[Datos proveedores].IdenProve + GEOGRAXPSQL.dbo.[Datos proveedores].SucurProv = '" & cboProvedores.SelectedValue & "')"
                    CargarFacturas(consulta)
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImpFactura_Click(sender As Object, e As EventArgs) Handles btnImpFactura.Click
        Try
            If DataGridFacturas.SelectedCells.Count <> 0 Then
                ModuloVariablesAplicacion.Prefi = DataGridFacturas.SelectedCells(0).Value.ToString()
                ModuloVariablesAplicacion.NumFac = DataGridFacturas.SelectedCells(1).Value.ToString()
                ModuloVariablesAplicacion.Remi = DataGridFacturas.SelectedCells(2).Value.ToString()
                ModuloVariablesAplicacion.infNombreInforme = "InfFacturaE"
                Dim FrmInfFacturaE As New FrmInfFacturaE
                FrmInfFacturaE.ShowDialog()
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += " Al imprimir factura" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Funciones"

    Public Function CargarFacturas(stringConsulta)
        DataGridFacturas.AutoGenerateColumns = False
        DataGridFacturas.DataSource = Nothing
        DataGridFacturas.Rows.Clear()
        Try
            Dim reader As SqlDataReader
            Dim consulta As String = stringConsulta

            reader = SQLReader(consulta)

            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridFacturas.Rows.Add(reader("PrefiFact"), reader("NumFact"), reader("NumRemi"), reader("ID_Contratos"), reader("FecExpFac"), reader("ValNetoFac"), reader("ValIVAFac"))
                End While
            End If
            reader.Close()
            reader = Nothing
            cn.Close()
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion cargar las facturas de este proovedor." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub BuscarContratos(documento)
        Bandera = 0
        Try
            Dim Contratos As DataSet = SQLDataSET("SELECT  c.ID_Contratos, c.ID_Contratos + ' ' + t.NomTipCon As Mostrar
                                                    FROM [Datos registros de contratos] as c, [Datos tipos de contratos] as t 
                                                    WHERE c.EstaVigCon = 1 and c.TipoContra = t.CodTipCon and c.TipDocContra + c.NumDocContra + c.CodSucContra = '" & documento.ToString & "' ")
            cboContratos.DataSource = Contratos.Tables(0)
            cboContratos.DisplayMember = "Mostrar"
            cboContratos.ValueMember = "ID_Contratos"
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En el proceso de BuscarContratos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Bandera = 1
    End Sub

    Private Sub CargarFechasActuales()
        Try
            Dim fecha As Date = Date.Now
            ftDesde.Value = fecha.AddDays(-30)
            ftHasta.Value = fecha
        Catch ex As Exception
            MsgBox("Error al cargar fechas actuales")
        End Try
    End Sub

#End Region

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFechasActuales()
        CargarComboBox()
        Bandera = 1
    End Sub




End Class