Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class Contratos

    Dim ClaseModeloContratos As New ModuloDeClaseContrato 'Instancia clase ModuloDeClaseContrato
    Dim bandera As Int32 = 0

#Region "Botones y texbox"

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try

            ModuloVariablesAplicacion.InfConsultaReporte = "select dr.ID_Contratos, dr.ContraNo, dr.VigAnContra, (dr.TipDocContra + ' ' + dr.NumDocContra) as Identificacion, dp.RazonSol, dt.NomTipCon, dr.FecIniCon,
                                                            dr.FecFinCon, dr.ValSinIVa, dr.ValIvaCon, dr.NumPagos from 
                                                            [Datos registros de contratos] as dr, [Datos tipos de contratos] as dt, [Datos proveedores] as dp
                                                            where dr.ID_Contratos = dr.ID_Contratos and dp.IdenProve = dr.NumDocContra"
            ModuloVariablesAplicacion.InfCabecera = "Contratos"
            ModuloVariablesAplicacion.InfTituloInforme = "Reporte de Contratos"
            ModuloVariablesAplicacion.infNombreInforme = "ReportContratos"
            Dim FrmsInformes As New FrmlInformes
            FrmlInformes.ShowDialog()
        Catch ex As Exception
            MsgBox("Error al exportar contratos " & ex.Message)
        End Try

    End Sub  'Genera Reporte

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click 'Anula el contrato
        Try
            If cboVigente.SelectedIndex = 0 Then
                MsgBox("Este contrato ya se encuentra Anulado")
            Else
                cboVigente.SelectedIndex = 0
                MsgBox("Por favor presiona el boton guardar")
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error al anular contrato" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'Elimina Contrato

    Private Sub txtNumeroPolizas_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroPolizas.TextChanged
        If txtNumeroPolizas.Text > "5" Then
            MsgBox("No puedes añadir mas de 5 polizas porque no puedes repetir el tipo de poliza")
        End If
    End Sub ' No deja añadir mas de 5 polizas

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If MsgBox("Exportaras a excel", vbYesNo) = vbYes Then
                Dim Datos As DataTable = New DataTable
                Datos = DataTable("Select dgc.ID_Contratos, dp.RazonSol ,dtc.NomTipCon, dgc.ContraNo, dgc.VigAnContra, dgc.TipDocContra, dgc.NumDocContra,
                                dgc.CodSucContra, dgc.FecIniCon, dgc.FecFinCon, dgc.ObjeContra, dgc.ValSinIVa, dgc.ValIvaCon, dgc.ValCerPazSal, dgc.ValPagLegal,
                                dgc.NumPagos, dgc.ExigePoli, dgc.NomEntiPoli, dgc.FecExpPoli, dgc.EstaVigCon, dgc.NumVisMes, dgc.FecCotiza, dgc.TipDocRe, dgc.NumDocRe,
                                dgc.CodRegis, dgc.FecRegis, dgc.CodModi, dgc.FecModi
                                FROM [Datos registros de contratos] as dgc, [Datos proveedores] as dp,  [Datos tipos de contratos] as dtc
                                WHERE dgc.NumDocContra = dp.IdenProve and dgc.TipoContra = dtc.CodTipCon")
                Dim SaveFileDialog As New SaveFileDialog
                Dim RutaName As String = ""
                SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                SaveFileDialog.Filter = "Text Files | *.xlsx"
                SaveFileDialog.DefaultExt = "xlsx"
                SaveFileDialog.Title = "Libro 1"

                If (SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    RutaName = SaveFileDialog.FileName
                End If

                GenerarExcel(Datos, RutaName)
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error al generar ecxel" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Exportar a excel

    Private Sub txtIdContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVisitasMes.KeyPress, txtValorSinIva.KeyPress, txtValorPazYSalvo.KeyPress, txtValorLegalizacion.KeyPress, txtValorIva.KeyPress, txtSucursal.KeyPress, txtNumeroDocumento.KeyPress, txtNumeroDePagos.KeyPress, txtIdContrato.KeyPress, txtDocumentoRepresentante.KeyPress, cboVigencia.KeyPress, txtValorTotal.KeyPress, txtNumeroPolizas.KeyPress, txtCodPoliza.KeyPress, txtBuscarContratos.KeyPress
        soloNumeros(e)
    End Sub  'Valida solo numero en estos campos

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If ValidarCamposLLenos() Then
                If txtIdContrato.Text = "" Then
                    If MsgBox("Se generara un consecutivo de contrato unico, estas de acuerdo", vbYesNo) = vbYes Then

                        Dim Consecutivo As String = ConsecutivoDocumen("01", True, 1)

                        Select Case Consecutivo
                            Case "0"
                                Informa = "Lo siento pero en esta base de datos no" & Chr(13) & Chr(10)
                                Informa = Informa & "se encontro el registro consecutivo," & Chr(13) & Chr(10)
                                MsgBox(Informa, vbExclamation, Titulo01)
                                Consecutivo = 0
                            Case "-3"
                                Informa = "Lo siento pero en esta base de datos no" & Chr(13) & Chr(10)
                                Informa = Informa & "se pueden registrar más facturas de ventas," & Chr(13) & Chr(10)
                                Informa = Informa & "porque pasó la longitud permitida del código."
                                MsgBox(Informa, vbExclamation, Titulo01)
                                Consecutivo = 0

                            Case "-2"
                                Informa = "Lo siento pero en esta base de datos no se" & Chr(13) & Chr(10)
                                Informa = Informa & "pueden registrar más más facturas de ventas, porque" & Chr(13) & Chr(10)
                                Informa = Informa & "la fecha del último generado es mayor a la del sistema."
                                MsgBox(Informa, vbExclamation, Titulo01)
                                Consecutivo = 0
                        End Select
                        txtIdContrato.Text = Consecutivo

                    End If
                End If
                txtIdContrato.Enabled = False
                btnGuardar.Enabled = True
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error al grabar el concecutivo" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub  'Graba concecutivo, habilita boton guardar

    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click
        Me.Dispose()
    End Sub  'Cerrar

    Private Sub txtBuscarContratos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarContratos.TextChanged
        Try
            If Len(txtBuscarContratos.Text) >= 1 Then
                BuscarDataGridContratos()
            Else
                CargarDataGridContratos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 'Busca contratos

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            GroupRegis.Visible = False
            GroupRegis.Visible = True
            txtValorIva.ReadOnly = False
            txtNumeroDocumento.Clear()
            txtNumeroPolizas.Clear()
            cboVezPoliza.SelectedIndex = 0
            txtCodPoliza.Clear()
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnGuardar.Visible = True
            btnGuardar.Enabled = False
            txtIdContrato.Clear()
            cboNombreContratante.SelectedValue = 0
            txtNumeroContrato.Clear()
            txtValorTotal.Clear()
            txtSucursal.Clear()
            cboVigencia.Text = Year(Now)
            cboTipoContrato.SelectedValue = 0
            DtFechaInicial.Value = Now.ToLongDateString
            DtFechaFinal.Value = Now.ToLongDateString
            txtNumeroDePagos.Clear()
            cboVigente.SelectedIndex = 1
            cboExigePoliza.SelectedIndex = 0
            cboTipoDocuRepresentante.SelectedValue = 0
            cboNombreRepresentanteLegal.SelectedValue = 0
            txtDocumentoRepresentante.Clear()
            txt0bjetoContrato.Clear()
            txtValorSinIva.Clear()
            txtValorIva.Clear()
            txtValorPazYSalvo.Clear()
            txtValorLegalizacion.Clear()
            txtVisitasMes.Clear()
            DtFechaCotizacion.Value = Now.ToLongDateString
            txtNombreEntidadPoliza.Clear()
            DtFechaExpedicionPoliza.Value = Now.ToLongDateString
            DataGridDetalleCuotas.DataSource = Nothing
            DataGridDetalleCuotas.Rows.Clear()
            GroupModi.Enabled = False
            GroupRegis.Enabled = True
            ' DataGridDetallePolizas.DataSource = Nothing
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error al limpiar campos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Limpia Campos

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If ValidarCamposLLenos() Then
                If CalcularTotales() Then
                    Dim fechaActual As Date = Date.Now
                    ClaseModeloContratos.RegistrarContrato(txtIdContrato.Text, txtNumeroContrato.Text, cboVigencia.Text, cboTipoDocuContrato.Text, txtNumeroDocumento.Text, txtSucursal.Text,
                                                                       cboTipoContrato.SelectedValue, Format(DtFechaInicial.Value, "MM/dd/yyyy"), Format(DtFechaFinal.Value, "MM/dd/yyyy"), txt0bjetoContrato.Text, txtValorSinIva.Text, txtValorIva.Text, txtValorPazYSalvo.Text,
                                                                       txtValorLegalizacion.Text, txtNumeroDePagos.Text, cboExigePoliza.SelectedIndex, txtNombreEntidadPoliza.Text, Format(DtFechaExpedicionPoliza.Value, "MM/dd/yyyy"), cboVigente.SelectedIndex, txtVisitasMes.Text, Format(DtFechaCotizacion.Value, "MM/dd/yyyy"),
                                                                        cboTipoDocuRepresentante.Text, cboNombreRepresentanteLegal.SelectedValue, txtCodRegis.Text, ftRegis.Value, txtCodModi.Text, ftModi.Value, DataGridDetalleCuotas, DataGridDetallePolizas, txtCodPoliza.Text, cboVezPoliza.SelectedIndex + 1)
                    CargarDataGridContratos()
                End If
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error al guardar" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub 'Guarda contrato

    Private Sub txtValorTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorTotal.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If txtValorSinIva.Text = "" Then
                        MsgBox("Llena el campo ValorIVA")
                        txtValorTotal.Text = ""
                    Else
                        Dim ValorSinIva As Double = txtValorSinIva.Text
                        Dim ValorIva As Double = txtValorIva.Text
                        Dim IvaCantidad As Double
                        Dim ValorTotal As Double
                        IvaCantidad = (ValorSinIva * txtPorceIVA.Text) / 100
                        ValorTotal = ValorSinIva + IvaCantidad
                        ValorTotal = Math.Round((ValorTotal), 2)
                        txtValorTotal.Text = ValorTotal
                        txtValorIva.Text = IvaCantidad
                    End If
            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error evento de calcular total" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub ''Calcula el valor total cuando se presiona la tecla enter

    Private Sub txtNumeroDePagos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroDePagos.KeyDown
        Try

            Select Case e.KeyData
                Case Keys.Enter
                    If String.IsNullOrWhiteSpace(txtNumeroDePagos.Text) Then
                        MsgBox("El campo se encuentra vacio")
                    Else
                        If btnGrabar.Enabled = True Then
                            CargarDataGridDetalleCoutas()
                        ElseIf btnGrabar.Enabled = False Then
                            If DataGridContratos.Rows.Count > 0 Then
                                Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
                                ModificarDataGridDetalle(codigo)
                            Else
                                CargarDataGridDetalleCoutas()
                            End If
                        End If
                    End If
            End Select


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Error evento generar pagos." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'Evento Enter para generar detalles de dataGrid detalle cuotas

    Private Sub txtNumeroPolizas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroPolizas.KeyDown 'FALTA TERMINAR
        Try
            If bandera = 1 Then
                Select Case e.KeyData
                    Case Keys.Enter
                        If btnGrabar.Enabled = True Then
                            CargarDataGridDetallePolizas()
                        ElseIf btnGrabar.Enabled = False Then
                            If DataGridContratos.Rows.Count > 0 Then
                                Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
                                ModificarDataGridDetallePolizas(codigo)
                            Else
                                CargarDataGridDetallePolizas()
                            End If
                        End If
                End Select
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el campo numero polizas." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Evento Enter para generar detalles de dataGrid detalle polizas

#End Region

#Region "Combobox"

    Public Sub Cargarcombobox()
        Dim BanderaComboBoxPrincipales As Int16 = 0
        Try
            CargaDocumentosIdentidad(cboTipoDocuContrato)

            CargaDocumentosIdentidad(cboTipoDocuRepresentante)

            Dim TipoContrato As DataSet = SQLDataSET("SELECT CodTipCon, NomTipCon FROM [Datos tipos de contratos]")
            cboTipoContrato.DataSource = TipoContrato.Tables(0)
            cboTipoContrato.DisplayMember = "NomTipCon"
            cboTipoContrato.ValueMember = "CodTipCon"

            Dim NombreContratante As DataSet = SQLDataSET("SELECT IdenProve, IdenProve + ' ' + RazonSol as nombrecedula FROM [Datos proveedores] WHERE HabilPro = 1")
            cboNombreContratante.DataSource = NombreContratante.Tables(0)
            cboNombreContratante.DisplayMember = "nombrecedula"
            cboNombreContratante.ValueMember = "IdenProve"

            Dim RepresentanteLegal As DataSet = SQLDataSET("SELECT TipDocRe, NumDocRe, Nom01Re + ' ' +  Nom02Re + ' ' +  Apelli01Re as nombre FROM [Datos del representante legal] WHERE ActiRep = 1")
            cboNombreRepresentanteLegal.DataSource = RepresentanteLegal.Tables(0)
            cboNombreRepresentanteLegal.DisplayMember = "nombre"
            cboNombreRepresentanteLegal.ValueMember = "NumDocRe"

            Dim TipoPolizaDatos As DataSet = SQLDataSET("SELECT CodTipPoli, NomTipPoli FROM [Datos tipos de polizas]") 'llena combox Tipo Poliza de la grilla detalle poiza
            TipoPoliza.DataSource = TipoPolizaDatos.Tables(0)
            TipoPoliza.DisplayMember = "NomTipPoli"
            TipoPoliza.ValueMember = "CodTipPoli"

            Dim items = New String(2) {"Unica", "Ampliacion 1", "Ampliacion 2"}
            cboVezPoliza.DataSource = items

            Dim AñosActual As Int32 'Llena combobox Vigencia
            Dim i As Int32
            AñosActual = Year(Now)
            For i = AñosActual To 2099
                cboVigencia.Items.Add(i)
            Next

            BanderaComboBoxPrincipales = 1

        Catch ex As Exception
            BanderaComboBoxPrincipales = 0
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion CargarComboBox primarios" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub 'Carga combox Primarios

    Public Sub CargaDatosCombobox()

        Try
            If bandera = 1 Then
                Dim TipoDocuContrato As DataSet = SQLDataSET("SELECT  TipoDocu, SucurProv  FROM [Datos proveedores] WHERE IdenProve = '" & cboNombreContratante.SelectedValue & "'")
                cboTipoDocuContrato.DataSource = TipoDocuContrato.Tables(0)
                cboTipoDocuContrato.DisplayMember = "TipoDocu"
                cboTipoDocuContrato.ValueMember = "SucurProv"
                If cboTipoDocuContrato.SelectedValue = "" Then
                Else
                    txtNumeroDocumento.Text = cboNombreContratante.SelectedValue
                    txtSucursal.Text = cboTipoDocuContrato.SelectedValue
                End If

                Dim TipoRepresentante As DataSet = SQLDataSET("SELECT TipDocRe FROM [Datos del representante legal] WHERE NumDocRe = '" & cboNombreRepresentanteLegal.SelectedValue & "'")
                cboTipoDocuRepresentante.DataSource = TipoRepresentante.Tables(0)
                cboTipoDocuRepresentante.DisplayMember = "TipDocRe"
                cboTipoDocuRepresentante.ValueMember = "TipDocRe"
                If cboTipoDocuRepresentante.SelectedValue = "" Then
                Else
                    txtDocumentoRepresentante.Text = cboNombreRepresentanteLegal.SelectedValue
                End If

            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion CargarComboBox primarios" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'Carga combobox secundarios

    Private Sub cboExigePoliza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExigePoliza.SelectedIndexChanged
        If cboExigePoliza.SelectedIndex = 0 Then
            PanelPoliza.Visible = False
            DtFechaExpedicionPoliza.Visible = False
            txtNumeroPolizas.Visible = False
            txtNombreEntidadPoliza.Visible = False
            cboVezPoliza.Visible = False
            txtCodPoliza.Visible = False
        ElseIf (cboExigePoliza.SelectedIndex = 1) Then
            PanelPoliza.Visible = True
            DtFechaExpedicionPoliza.Visible = True
            txtNumeroPolizas.Visible = True
            txtNombreEntidadPoliza.Visible = True
            cboVezPoliza.Visible = True
            txtCodPoliza.Visible = True
        End If

    End Sub

    Private Sub cboNombreContratante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreContratante.SelectedIndexChanged
        CargaDatosCombobox()
    End Sub

    Private Sub cboNombreRepresentanteLegal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreRepresentanteLegal.SelectedIndexChanged
        CargaDatosCombobox()
    End Sub

    Private Sub cboTipoContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoContrato.SelectedIndexChanged

        If cboTipoContrato.Text = "Actualización y/o mantenimiento" Then
            txtVisitasMes.Enabled = True
            PanelVisitasMes.Visible = True
            txtVisitasMes.Visible = True
        Else
            PanelVisitasMes.Visible = False
            txtVisitasMes.Visible = False
            txtVisitasMes.Text = ""
        End If


    End Sub 'Se activa el campo visias mes si el tipo de contrato es actualizacion

#End Region

#Region "Funciones"

    Private Sub ComprobarContratos()
        Try
            If DataGridContratos.Rows.Count > 0 Then
                Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
                MostrarTexbox(codigo)
            Else
                MsgBox("Por el momento no existe ningun contrato, crea uno")
                btnGrabar.Enabled = True
                btnGuardar.Enabled = False
                btnEliminar.Enabled = False
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en comprobar si existen contratos " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Valida si existen datos en la tabla registro de contratos


    Private Function ComprobarDatos() As Boolean
        Try
            Dim reader As SqlDataReader
            reader = SQLReader("SELECT * FROM [Datos registros de contratos]")
            If reader.HasRows = False Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error en comprobar datos ")
            Return False
        Finally
            cn.Close()
        End Try

    End Function 'Comprueba si existen contratos

    Private Function ComprobarNoRepeTipoPolizas() As Boolean
        Try

            Dim Uno As Int16 = 0
            Dim Dos As Int16 = 0
            Dim Tres As Int16 = 0
            Dim Cuatro As Int16 = 0
            Dim Cinco As Int16 = 0
            Dim Estado As Boolean

            For Each Fila In DataGridDetallePolizas.Rows
                If Fila.Cells("TipoPoliza").Value = 1 Then
                    Uno += 1
                    If Uno > 1 Then
                        MsgBox("Esta repitiendo el tipo de poliza Cumplimiento", MsgBoxStyle.Critical, "Erro detalle polizas")
                        Estado = False
                        Return False
                    Else
                        Estado = True
                    End If
                End If
                If Fila.Cells("TipoPoliza").Value = 2 Then
                    Dos += 1
                    If Dos > 1 Then
                        MsgBox("Esta repitiendo el tipo de poliza CALIDAD DEL SERVICIO", MsgBoxStyle.Critical, "Erro detalle polizas")
                        Estado = False
                        Return False
                    Else
                        Estado = True
                    End If
                End If
                If Fila.Cells("TipoPoliza").Value = 3 Then
                    Tres += 1
                    If Tres > 1 Then
                        MsgBox("Esta repitiendo el tipo de poliza CALIDAD ELEMENTOS", MsgBoxStyle.Critical, "Erro detalle polizas")
                        Estado = False
                        Return False
                    Else
                        Estado = True
                    End If
                End If
                If Fila.Cells("TipoPoliza").Value = 4 Then
                    Cuatro += 1
                    If Cuatro > 1 Then
                        MsgBox("Esta repitiendo el tipo de poliza PRESTACIONES SOCIALES", MsgBoxStyle.Critical, "Erro detalle polizas")
                        Estado = False
                        Return False
                    Else
                        Estado = True
                    End If
                End If
                If Fila.Cells("TipoPoliza").Value = 5 Then
                    Cinco += 1
                    If Cinco > 1 Then
                        MsgBox("Esta repitiendo el tipo de poliza BUEN MANEJO ANTICIPO", MsgBoxStyle.Critical, "Erro detalle polizas")
                        Estado = False
                        Return False
                    Else
                        Estado = True
                    End If
                End If
            Next
            Return Estado
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion ComprobarNoRepeTipoPolizas." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function 'Valida que no se repitan los tipos de poliza en la grilla

    Public Function ValidarCamposDataGrid() As Boolean  ' Valida para el datagrid
        Dim estado As Boolean
        If String.IsNullOrWhiteSpace(Me.txtNumeroDePagos.Text) Then
            MsgBox("El campo Numero De Pagos esta vacio", MsgBoxStyle.Information, "Control de datos")
            Me.txtNumeroDePagos.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrWhiteSpace(Me.txtValorSinIva.Text) Then
            MsgBox("El campo valor Sin IVA no esta vacio", MsgBoxStyle.Information, "Control de datos")
            Me.txtValorSinIva.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrWhiteSpace(Me.txtValorIva.Text) Then
            MsgBox("El campo valor IVA contrato no esta vacio", MsgBoxStyle.Information, "Control de datos")
            Me.txtValorIva.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrWhiteSpace(Me.txtValorTotal.Text) Then
            MsgBox("El campo valor total esta vacio", MsgBoxStyle.Information, "Control de datos")
            Me.txtValorTotal.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        Return estado
    End Function 'Valida datos para el dataGrid 'Modificar

    Public Function ValidarCamposLLenos() As Boolean

        Try
            Dim estado As Boolean
            If cboNombreContratante.SelectedIndex < 0 Then
                MsgBox("El campo Nombre Del Contratante esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboNombreContratante.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If


            If String.IsNullOrWhiteSpace(Me.txtNumeroContrato.Text) Then
                MsgBox("El campo Numero de contrato esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtNumeroContrato.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            If String.IsNullOrWhiteSpace(Me.txtNumeroDePagos.Text) Then
                MsgBox("El campo Numero De Pagos esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtNumeroDePagos.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboVigencia.SelectedIndex < 0 Then
                MsgBox("El campo Vigencia esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboVigencia.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboVigencia.SelectedIndex < 0 Then
                MsgBox("El campo Vigencia esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboVigencia.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboTipoContrato.SelectedIndex = -1 Then
                MsgBox("El campo Tipo Contrato esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboTipoContrato.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If DtFechaFinal.Value.Date < DtFechaInicial.Value.Date Then
                MsgBox("La fecha final no puede ser menor a la inicial ", MsgBoxStyle.Information, "Control de datos")
                Me.DtFechaFinal.Select()
                estado = False
                Return estado
            End If
            If String.IsNullOrWhiteSpace(Me.txtNumeroDePagos.Text) Then
                MsgBox("El campo Numero de pagos solo acepta valores numericos y no puede estar vacio.", MsgBoxStyle.Information, "Control de datos")
                Me.txtNumeroDePagos.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboVigente.SelectedIndex < 0 Then
                MsgBox("El campo vigente esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboVigente.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(Me.txt0bjetoContrato.Text) Then
                MsgBox("El campo Objeto contrato  esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txt0bjetoContrato.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(Me.txtValorSinIva.Text) Then
                MsgBox("El campo valor Sin IVA no esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtValorSinIva.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(Me.txtValorIva.Text) Then
                MsgBox("El campo valor IVA contrato no esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtValorIva.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(Me.txtValorPazYSalvo.Text) Then
                MsgBox("El campo valor paz y salvo contrato no esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtValorPazYSalvo.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            If String.IsNullOrWhiteSpace(Me.txtValorLegalizacion.Text) Then
                MsgBox("El campo legalizacion contrato no esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtValorLegalizacion.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(Me.txtValorTotal.Text.Trim) Then
                MsgBox("El campo valor total esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtValorTotal.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboExigePoliza.SelectedIndex < 0 Then
                MsgBox("El campo exige poliza esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboExigePoliza.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboNombreRepresentanteLegal.SelectedIndex < 0 Then
                MsgBox("El campo Representante legal esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.cboExigePoliza.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboExigePoliza.SelectedIndex = 1 Then
                If String.IsNullOrWhiteSpace(Me.txtNombreEntidadPoliza.Text) Then
                    MsgBox("El campo entidad poliza no puede estar vacio", MsgBoxStyle.Information, "Control de datos")
                    Me.txtNombreEntidadPoliza.Select()
                    estado = False
                    Return estado
                End If
                If String.IsNullOrWhiteSpace(Me.txtCodPoliza.Text) Then
                    MsgBox("El campo Cod Poliza no puede estar vacio", MsgBoxStyle.Information, "Control de datos")
                    Me.txtCodPoliza.Select()
                    estado = False
                    Return estado
                End If
                If cboVezPoliza.SelectedIndex < 0 Then
                    MsgBox("El campo Vez Poliza esta vacio", MsgBoxStyle.Information, "Control de datos")
                    Me.cboVezPoliza.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If

                If ComprobarNoRepeTipoPolizas() = True Then
                    estado = True
                Else
                    estado = False
                End If


                Dim Fila As DataGridViewRow = New DataGridViewRow()
                Dim strFecha As String
                Dim datFecha As Date
                For Each Fila In DataGridDetallePolizas.Rows
                    If Fila.Cells("TipoPoliza").Value = Nothing Or Fila.Cells("PorcePoli").Value = Nothing Or Fila.Cells("ValCubre").Value = Nothing Or Fila.Cells("Fecha_Inicio").Value = Nothing Or Fila.Cells("Fecha_Final").Value = Nothing Then
                        MessageBox.Show("Tienes un valor en blanco en la tabla detalles de poliza")
                        Me.DataGridDetallePolizas.Select()
                        estado = False
                        Return estado
                    Else
                        estado = True
                    End If
                    strFecha = Trim(Fila.Cells("Fecha_Inicio").Value)
                    If IsDate(strFecha) Then
                        datFecha = CDate(strFecha)
                        estado = True
                    Else
                        MsgBox("Formato de fecha incorrecta en Fecha_Inicio")
                        estado = False
                        Return estado
                    End If
                    strFecha = Trim(Fila.Cells("Fecha_Final").Value)
                    If IsDate(strFecha) Then
                        datFecha = CDate(strFecha)
                        estado = True
                    Else
                        MsgBox("Formato de fecha incorrecta en Fecha_Final")
                        estado = False
                        Return estado
                    End If
                    strFecha = Trim(Fila.Cells("Fecha_Anulacion").Value)
                    If IsDate(strFecha) Then
                        datFecha = CDate(strFecha)
                        estado = True
                    Else
                        MsgBox("Formato de fecha incorrecta en Fecha_Anulacion")
                        estado = False
                        Return estado
                    End If
                    strFecha = Trim(Fila.Cells("Fec_Registro").Value)
                    If IsDate(strFecha) Then
                        datFecha = CDate(strFecha)
                        estado = True
                    Else
                        MsgBox("Formato de fecha incorrecta en Fecha_Registro")
                        estado = False
                        Return estado
                    End If
                    strFecha = Trim(Fila.Cells("Fech_Modi").Value)
                    If IsDate(strFecha) Then
                        datFecha = CDate(strFecha)
                        estado = True
                    Else
                        MsgBox("Formato de fecha incorrecta en Fecha_Modi")
                        estado = False
                        Return estado
                    End If


                Next 'Validaciones para dtagridview detalle de polizas
                If (DataGridDetallePolizas.Rows.Count = 0) Then
                    MsgBox("La tabla detalle polizas no puede estar vacia", MsgBoxStyle.Information, "Control de datos")
                    Me.DataGridDetallePolizas.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If

            End If
            If (DataGridDetalleCuotas.Rows.Count = 0) Then
                MsgBox("La tabla detalle cuotas no puede estar vacia", MsgBoxStyle.Information, "Control de datos")
                Me.DataGridDetalleCuotas.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            Dim Fila2 As DataGridViewRow = New DataGridViewRow()
            Dim strFecha2 As String
            Dim datFecha2 As Date
            For Each Fila2 In DataGridDetalleCuotas.Rows
                If Fila2.Cells("FechaDePago").Value = Nothing Or Fila2.Cells("Porcentage").Value = Nothing Or Fila2.Cells("ValorTotalCouta").Value = Nothing Then
                    MsgBox("La tabla detalles de cuotas no puede tener espacios en blanco", MsgBoxStyle.Critical)
                End If
                strFecha2 = Trim(Fila2.Cells("FechaDePago").Value)
                If IsDate(strFecha2) Then
                    datFecha2 = CDate(strFecha2)
                    estado = True
                Else
                    MsgBox("Formato de fecha incorrecta en la tabla detalles de cuentas, en la columna FechaDePago")
                    estado = False
                    Return estado
                End If
            Next 'Validaciones para dtagridview detalle de cuentas contratos
            Return estado
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de datos." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function 'Valida que todos los campos esten lleno

    Private Function Buscar(id As String) As DataRow

        Try

            If (String.IsNullOrEmpty(id)) Then
                Throw New ArgumentNullException("id")
            End If

            ' Declaramos la variable que devolverá la función, que
            ' en principio indica que no existe ningún registro
            ' que coincida con el ID especificado.
            '
            Dim returnValue As DataRow = Nothing


            ' Creamos un objeto Command.
            Dim cmd As SqlCommand

            cmd = New SqlCommand("SELECT * FROM [Datos registros de contratos] WHERE ID_Contratos = @id", cn)

            ' Añadimos el único parámetro de entrada existente en la consulta
            cmd.Parameters.AddWithValue("@id", id)

            ' Creamos el adaptador de datos al que le pasamos el objeto Command.
            Dim da As New SqlDataAdapter(cmd)

            ' Intentamos rellenar un objeto DataTable como resultado
            ' de ejecutar la consulta SQL de selección especificada.
            '
            Using dt As New DataTable()

                da.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    ' Nos quedamos con la primera fila u objeto DataRow.
                    '
                    returnValue = dt.Rows(0)
                End If

            End Using

            cn.Close()

            ' Devolvemos el objeto DataRow obtenido.
            '
            Return returnValue
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function  'Funcion que va ay busca los datos del id requerido en la funcion Mostrar Texbox

    Public Sub CargarDataGridContratos()
        Try
            Dim consulta As String
            consulta = "Select dgc.ID_Contratos, dgc.TipDocContra, dgc.NumDocContra,  dp.RazonSol, dtc.NomTipCon
                        FROM [Datos registros de contratos] as dgc, [Datos proveedores] as dp,  [Datos tipos de contratos] as dtc
                        WHERE dgc.NumDocContra = dp.IdenProve and dgc.TipoContra = dtc.CodTipCon  ORDER BY (dgc.ID_Contratos)"
            bandera = 0
            DataGridContratos.DataSource = DataTable(consulta)
            bandera = 1
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        End Try

    End Sub 'Funcion que envia a listar

    Public Sub BuscarDataGridContratos()
        Try
            Dim consulta As String
            consulta = "Select dgc.ID_Contratos, dgc.TipDocContra, dgc.NumDocContra,  dp.RazonSol, dtc.NomTipCon FROM [Datos registros de contratos] as dgc, [Datos proveedores] as dp,  [Datos tipos de contratos] as dtc WHERE dgc.NumDocContra = dp.IdenProve and dgc.TipoContra = dtc.CodTipCon and (dgc.ID_Contratos like '%' + '" & Convert.ToInt64(txtBuscarContratos.Text) & "' + '%'  OR dgc.NumDocContra like '" & Convert.ToInt64(txtBuscarContratos.Text) & "' + '%') "
            bandera = 0

            Dim dt As DataTable = DataTable(consulta)

            If dt.Rows.Count = 0 Then
                Informa = "Lo siento pero el contrato" & Chr(13) & Chr(10)
                Informa = Informa & "digitado no existe" & Chr(13) & Chr(10)
                Titulo01 = "Control para validar datos"
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DataGridContratos.DataSource = dt
                Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
                MostrarTexbox(codigo)
                bandera = 1
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la busquedad del contrato." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub 'Funcion que envia a buscar

    Private Sub MostrarTexbox(identificador)
        txtValorIva.ReadOnly = False
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False
        btnGuardar.Enabled = True
        GroupModi.Enabled = True
        GroupRegis.Enabled = False
        Try
            ' Obtenemos un objeto DataRow correspondiente con
            ' el ID escrito en un control TextBox
            '
            Dim row As DataRow = Buscar(identificador)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")
                ' Abandonamos el procedimiento
                Return
            End If

            ' Rellenamos los correspondientes controles TextBox
            ' con los datos existentes en el objeto DataRow
            ' obtenido.
            '
            txtIdContrato.Text = Convert.ToString(row("ID_Contratos"))
            cboNombreContratante.SelectedValue = Convert.ToString(row("NumDocContra"))
            txtNumeroContrato.Text = Convert.ToString(row("ContraNo"))
            cboVigencia.Text = Convert.ToString(row("VigAnContra"))
            cboTipoContrato.SelectedValue = Convert.ToString(row("TipoContra"))
            DtFechaInicial.Value = Convert.ToString(row("FecIniCon"))
            DtFechaFinal.Value = Convert.ToString(row("FecFinCon"))
            txtNumeroDePagos.Text = Convert.ToString(row("NumPagos"))
            txt0bjetoContrato.Text = Convert.ToString(row("ObjeContra"))
            txtValorSinIva.Text = Convert.ToString(row("ValSinIVa"))
            txtValorIva.Text = Convert.ToString(row("ValIvaCon"))
            txtValorPazYSalvo.Text = Convert.ToString(row("ValCerPazSal"))
            txtValorLegalizacion.Text = Convert.ToString(row("ValPagLegal"))
            txtVisitasMes.Text = Convert.ToString(row("NumVisMes"))
            DtFechaCotizacion.Value = Convert.ToString(row("FecCotiza"))
            txtNombreEntidadPoliza.Text = Convert.ToString(row("NomEntiPoli"))
            DtFechaExpedicionPoliza.Value = Convert.ToString(row("FecExpPoli"))
            cboNombreRepresentanteLegal.SelectedValue = Convert.ToString(row("NumDocRe"))



            txtCodRegis.Text = Convert.ToString(row("CodRegis"))
            ftRegis.Value = Convert.ToDateTime(row("FecRegis"))
            txtCodModi.Text = Convert.ToString(row("CodRegis"))
            ftModi.Value = Convert.ToDateTime(row("FecModi"))




            Dim ValorSinIva As Double = txtValorSinIva.Text
            Dim ValorIva As Double = txtValorIva.Text
            Dim ValorTotal As Double
            ValorTotal = ValorSinIva + ValorIva
            txtValorTotal.Text = ValorTotal

            If Convert.ToString(row("EstaVigCon")) = True Then 'CBO VIGENCIA SIN MOSTRAR
                cboVigente.SelectedIndex = 1
            Else
                cboVigente.SelectedIndex = 0
            End If
            If Convert.ToString(row("ExigePoli")) = True Then
                cboExigePoliza.SelectedIndex = 1
            Else
                cboExigePoliza.SelectedIndex = 0
            End If
            CagarDetallesCuotas(identificador)
            CargarDetallesPolizas(identificador)
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion MostrarTexbox." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub  'Funcion que recibe un identificador de contrato y muestra todos los datos

    Private Sub ColorDisabled()
        txtSucursal.BackColor = Color.White
        txtNumeroDocumento.BackColor = Color.White
        txtIdContrato.BackColor = Color.White
        txtDocumentoRepresentante.BackColor = Color.White
    End Sub 'Coloca el fondo de los texbox disable en blanco

    Public Function CalcularTotales() As Boolean
        Dim sumaValorTotal As Double
        Dim sumaPorcentaje As Double
        Dim estado As Boolean
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridDetalleCuotas.Rows
            sumaPorcentaje += Convert.ToDouble(fila.Cells("Porcentage").Value)
            sumaValorTotal += Convert.ToDouble(fila.Cells("ValorTotalCouta").Value)
            If Convert.ToDateTime(fila.Cells("FechaDePago").Value) > DtFechaFinal.Value Then
                MsgBox("Estas registrando una fecha mayor a la Fecha Final del contrato" & DtFechaFinal.Value & "")
                estado = False
                Return estado
            Else
                estado = True
            End If
        Next

        sumaPorcentaje = Math.Round((sumaPorcentaje), 1)
        sumaValorTotal = Math.Round((sumaValorTotal), 2)

        If sumaPorcentaje <> 100 Then
            MsgBox("La suma de los porcentajes no da 100%", MsgBoxStyle.Information, "Control de detalles de cuotas")
            estado = False
            Return estado
        Else
            estado = True
        End If

        If sumaValorTotal <> txtValorTotal.Text Then
            MsgBox("La suma de las cuotas no da el total: " & txtValorTotal.Text & " ", MsgBoxStyle.Information, "Control de detalles de cuotas")
            estado = False
            Return estado
        Else
            estado = True
        End If
        Return estado
    End Function 'Calcula las columnas del dataGridView Detalles de Contratos para que den lo totales requeridos

#End Region

#Region "DataGrid"

    Public Sub CargarDataGridDetallePolizas()
        If String.IsNullOrEmpty(txtNumeroPolizas.Text) Then
            MsgBox("Digita el numero de polizas que llevara este contrato")
        Else
            DataGridDetallePolizas.Rows.Clear()
            DataGridDetallePolizas.DataSource = Nothing
            For indice As Integer = 1 To txtNumeroPolizas.Text
                DataGridDetallePolizas.Rows.Add(New String() {indice, "", "", "", DtFechaExpedicionPoliza.Value.Date, DtFechaExpedicionPoliza.Value.Date, False, "", "", DtFechaExpedicionPoliza.Value.Date, "", DtFechaExpedicionPoliza.Value.Date, "", DtFechaExpedicionPoliza.Value.Date, "", DtFechaExpedicionPoliza.Value.Date})
            Next
        End If
    End Sub  'Cargar Datgrid Detalles Polizas

    Public Sub ModificarDataGridDetalle(codigo)
        Try
            cn.Open()
            Dim CuotasFacturadas As SqlCommand
            CuotasFacturadas = New SqlCommand
            CuotasFacturadas.Connection = cn
            CuotasFacturadas.CommandText = "select count(FacturCuota) 
                                        from [Datos detalles de cuotas contratos] 
                                        where FacturCuota = 1 
                                        and ID_Contratos = @ID_Contratos"
            CuotasFacturadas.Parameters.AddWithValue("@ID_Contratos", codigo)
            Dim Resultado As Object = CuotasFacturadas.ExecuteScalar()

            If Resultado = Nothing Or Resultado = 0 Then  'Evalua si la consulta no viene null
                CargarDataGridDetalleCoutas()
                Exit Sub
            End If
            cn.Close()

            If txtNumeroDePagos.Text > Resultado Then
                DataGridDetalleCuotas.DataSource = Nothing
                DataGridDetalleCuotas.Rows.Clear()
                Dim sumaValorTotal As Double
                Dim SumaPorcentaje As Double

                Dim reader As SqlDataReader

                reader = SQLReader("Select * From [Datos detalles de cuotas contratos] WHERE ID_Contratos = '" & txtIdContrato.Text & "' and FacturCuota = 1 ")

                Dim AddFilas As Int16 = txtNumeroDePagos.Text - Resultado 'Diferencia de numero de filas

                If reader.HasRows Then

                    While reader.Read()
                        Me.DataGridDetalleCuotas.Rows.Add(reader("CuotaNoPac"), reader("FecPacPag"), reader("PorCuoPac"), reader("ValTolCuota"), reader("FacturCuota"))
                        sumaValorTotal += reader("ValTolCuota")
                        SumaPorcentaje += reader("PorCuoPac")
                    End While

                    Dim Fecha As Date = (DtFechaInicial.Value.Date)
                    Dim TtlPorcentajeCuotas As Double = 100 - SumaPorcentaje
                    Dim TtlCuotasPagadas As Double = txtValorTotal.Text - sumaValorTotal
                    Dim ValorCuota As Double = (TtlCuotasPagadas / AddFilas)
                    Dim PorcentageDeCouta As Double = (ValorCuota * TtlPorcentajeCuotas) / TtlCuotasPagadas
                    Dim IndiceDeCuota As Int16 = Resultado
                    ValorCuota = Math.Round((ValorCuota), 3)
                    PorcentageDeCouta = Math.Round((PorcentageDeCouta), 4)

                    For i As Integer = 1 To AddFilas
                        IndiceDeCuota += 1
                        Me.DataGridDetalleCuotas.Rows.Add(New String() {IndiceDeCuota, Fecha, PorcentageDeCouta, ValorCuota, False})
                    Next
                End If

                cn.Close()
            ElseIf txtNumeroDePagos.Text < Resultado Then
                MsgBox("El numero de pagos no puede ser menor o igual a las cuotas ya facturadas")
            ElseIf txtNumeroDePagos.Text = Resultado Then
                DataGridDetalleCuotas.DataSource = Nothing
                DataGridDetalleCuotas.Rows.Clear()
                Dim reader As SqlDataReader
                reader = SQLReader("Select * From [Datos detalles de cuotas contratos] WHERE ID_Contratos = '" & txtIdContrato.Text & "' and FacturCuota = 1 ")
                While reader.Read()
                    Me.DataGridDetalleCuotas.Rows.Add(reader("CuotaNoPac"), reader("FecPacPag"), reader("PorCuoPac"), reader("ValTolCuota"), reader("FacturCuota"))
                End While
                cn.Close()
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error al modificar la tabla detalles cuotas" & Chr(13) & Chr(10)
            Informa += "al tratar de modificar cuotas." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub  'Modifica el numero de cuotas de un contrato, teniendo en cuenta las coutas ya facturafas y re calculando los pagos

    Public Sub ModificarDataGridDetallePolizas(codigo)
        Try

            cn.Open()
            Dim FilasOcupadas As SqlCommand
            FilasOcupadas = New SqlCommand
            FilasOcupadas.Connection = cn
            FilasOcupadas.CommandText = "select count(ID_Contratos) 
                                        from [Datos detalles polizas contrato] 
                                        where ID_Contratos = @ID_Contratos"
            FilasOcupadas.Parameters.AddWithValue("@ID_Contratos", codigo)
            Dim Resultado As Object = FilasOcupadas.ExecuteScalar()
            If Resultado = Nothing Or Resultado = 0 Then
                CargarDataGridDetallePolizas()
            Else
                If txtNumeroPolizas.Text > Resultado Then
                    DataGridDetallePolizas.DataSource = Nothing
                    DataGridDetallePolizas.Rows.Clear()
                    Dim comando As SqlCommand
                    Dim reader As SqlDataReader
                    comando = New SqlCommand("Select * 
                                        from [Datos detalles polizas contrato] 
                                        where ID_Contratos = @ID_Contratos", cn)
                    comando.Parameters.AddWithValue("@ID_Contratos", codigo)
                    reader = comando.ExecuteReader()


                    Dim AddFilas As Int16 = txtNumeroPolizas.Text - Resultado 'Diferencia de numero de filas
                    Dim IndiceDeCuota As Int16 = Resultado
                    Dim IndiceDeCuota2 As Int16 = 0


                    If reader.HasRows Then

                        While reader.Read()

                            IndiceDeCuota2 += 1

                            Me.DataGridDetallePolizas.Rows.Add(IndiceDeCuota2, reader("TipPoliza"), reader("PorcePoli"), reader("ValCubre"), reader("FecIniPol"), reader("FecFinPol"), reader("AnulPoli"), reader("RazAnulPol"), reader("CodAnulPol"), reader("FecAnulPol"), reader("CodRegis"), reader("FecRegis"), reader("CodModi"), reader("FecModi"))
                        End While
                        For indice As Integer = 1 To AddFilas
                            IndiceDeCuota += 1
                            DataGridDetallePolizas.Rows.Add(New String() {IndiceDeCuota, "", "", "", DtFechaExpedicionPoliza.Value.Date, DtFechaExpedicionPoliza.Value.Date, False, "", "", DtFechaExpedicionPoliza.Value.Date, "", DtFechaExpedicionPoliza.Value.Date, "", DtFechaExpedicionPoliza.Value.Date, "", DtFechaExpedicionPoliza.Value.Date})
                        Next
                    End If


                ElseIf txtNumeroPolizas.Text < Resultado Then

                    MsgBox("No puedes modificar las polizas ya añadidas, el numero de polizas que quiere introducir es menor al que se propuso inicialmente")


                ElseIf txtNumeroPolizas.Text = Resultado Then
                    cn.Close()
                    CargarDetallesPolizas(codigo)

                End If


            End If  'Evalua si la consulta no viene null

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error al modificar la tabla detalles polizas" & Chr(13) & Chr(10)
            Informa += "en el campo numero polizas." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DataGridContratos_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridContratos.CurrentCellChanged
        If bandera = 1 Then
            Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
            MostrarTexbox(codigo)
        End If
    End Sub

    Private Sub CargarDataGridDetalleCoutas()
        DataGridDetalleCuotas.Rows.Clear()
        DataGridDetalleCuotas.DataSource = Nothing
        If ValidarCamposDataGrid() Then
            Dim Fecha As Date = (DtFechaInicial.Value.Date)
            Dim ValorSinIva As Double = txtValorSinIva.Text
            '   Dim ValorIva As Double = txtPorceIVA.Text NO CALCULARA EL IVA SOLO COGERA LOS DATOS DIGITADOS EN LOS CAMPOS DE PAGOS
            Dim IvaCantidad As Double = Convert.ToDouble(txtValorIva.Text)
            Dim ValorTotal As Double
            '   IvaCantidad = (ValorSinIva * ValorIva) / 100
            ValorTotal = ValorSinIva + IvaCantidad
            Dim ValorCuota As Double = (ValorTotal / txtNumeroDePagos.Text)
            Dim PorcentageDeCouta = (ValorCuota * 100) / ValorTotal
            ValorCuota = Math.Round((ValorCuota), 3)
            PorcentageDeCouta = Math.Round((PorcentageDeCouta), 4)
            For indice As Integer = 1 To txtNumeroDePagos.Text
                DataGridDetalleCuotas.Rows.Add(New String() {indice, Fecha, PorcentageDeCouta, ValorCuota, False})
            Next
        Else
        End If
    End Sub 'Carga Detalles del dataGrid cuando se va hacer un registro nuevo

    Private Sub DataGridDetalleCuotas_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridDetalleCuotas.CellBeginEdit
        Try
            Dim value As Object = DataGridDetalleCuotas.Rows(e.RowIndex).Cells(4).Value
            If value = True Then
                MsgBox("No puedes modificar una fila ya facturada")
                e.Cancel = True
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 'No deja modificar las filas ya facturadas

    Private Function CagarDetallesCuotas(ID_Contratos) As Boolean
        DataGridDetalleCuotas.AutoGenerateColumns = False
        DataGridDetalleCuotas.DataSource = Nothing
        DataGridDetalleCuotas.Rows.Clear()
        Try
            Dim reader As SqlDataReader
            reader = SQLReader("Select CuotaNoPac,PorCuoPac, ValTolCuota, FecPacPag, FacturCuota From [Datos detalles de cuotas contratos] WHERE ID_Contratos = '" & txtIdContrato.Text & "' ")

            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridDetalleCuotas.Rows.Add(reader("CuotaNoPac"), reader("FecPacPag"), reader("PorCuoPac"), reader("ValTolCuota"), reader("FacturCuota"))
                    If reader("FacturCuota") = True Then 'REVISARRRRRRRRR
                        txtValorIva.ReadOnly = True
                    End If
                End While
            Else
                Me.DataGridDetalleCuotas.Rows.Clear()
            End If
            reader.Close()
            reader = Nothing
            cn.Close()
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion SQLReader." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function 'Carga detalles de cuotas desde la base de datos

    Private Function CargarDetallesPolizas(ID_Contratos) As Boolean
        DataGridDetallePolizas.AutoGenerateColumns = False
        DataGridDetallePolizas.DataSource = Nothing


        Try
            cn.Open()
            Dim comando As SqlCommand
            Dim reader As SqlDataReader
            Dim ContadorPolizas As Int16 = 0
            comando = New SqlCommand
            comando.Connection = cn
            comando.CommandType = CommandType.Text
            comando.CommandText = "Select * From [Datos detalles polizas contrato] WHERE ID_Contratos = @ID_Contratos"
            comando.Parameters.AddWithValue("@ID_Contratos", ID_Contratos)
            reader = comando.ExecuteReader()
            DataGridDetallePolizas.Rows.Clear()
            If reader.HasRows Then
                While reader.Read()
                    ContadorPolizas += 1
                    Dim Str As String = reader("VezPoliza").ToString
                    Dim Vezpol As String = Nothing
                    Select Case Str
                        Case "1"
                            Vezpol = "Unica"
                        Case "2"
                            Vezpol = "Ampliacion 1"
                        Case "3"
                            Vezpol = "Ampliacion 2"
                        Case Else
                    End Select
                    cboVezPoliza.Text = Vezpol
                    txtCodPoliza.Text = reader("CodPoliza").ToString
                    Me.DataGridDetallePolizas.Rows.Add(ContadorPolizas, reader("TipPoliza"), reader("PorcePoli"), reader("ValCubre"), reader("FecIniPol"), reader("FecFinPol"),
                                                       reader("AnulPoli"), reader("RazAnulPol"), reader("CodAnulPol"), reader("FecAnulPol"), reader("CodRegis"), reader("FecRegis"), reader("CodModi"), reader("FecModi"))
                End While
            Else
                Me.DataGridDetallePolizas.Rows.Clear()
            End If

            cn.Close()
            Return True
        Catch ex As Exception
            MsgBox("Erro al cargar datagrid contratos" + ex.ToString)
            Return False
        End Try
    End Function  'Carga el data Grid Detalles Polizas

#End Region

    Private Sub Contratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Call conectarGeogebra()
            Cargarcombobox()
            CargarDataGridContratos()
            For Each col As DataGridViewColumn In DataGridContratos.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next  'Desactiva que no pueda seleccionar las cabeceras del datagridview DataGridContratos 
            ComprobarContratos()
            ColorDisabled()
            bandera = 1
            CargaDatosCombobox()
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en alguna funcion del load " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


End Class