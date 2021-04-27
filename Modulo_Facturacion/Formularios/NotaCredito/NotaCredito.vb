Imports System.Data.SqlClient
Public Class NotaCredito
    Dim ClaseModuloNotaCredito As New ModuloDeClaseNotasCreditoDebito 'Instancia clase ModuloDeClaseNotasCreditoDebito

#Region "Combobox"
    Private Sub CargarCombobox()


        Dim ProovedorConFacturas As DataSet = SQLDataSET("SELECT        PR.TipoDocu + PR.IdenProve + PR.SucurProv AS IdTercero, PR.RazonSol
                                                        FROM            BDADYSNET.dbo.[Datos facturas realizadas] AS FR INNER JOIN
                                                        GEOGRAXPSQL.dbo.[Datos proveedores] AS PR ON FR.TipDocTer = PR.TipoDocu AND FR.NumDocTer = PR.IdenProve AND FR.SucDocTer = PR.SucurProv                                                  
                                                        GROUP BY PR.TipoDocu + PR.IdenProve + PR.SucurProv, PR.RazonSol")
        cboProovedores.DataSource = ProovedorConFacturas.Tables(0)
        cboProovedores.DisplayMember = "RazonSol"
        cboProovedores.ValueMember = "IdTercero"


        Dim ConceptoDeCorreccion As DataSet = SQLDataSET("SELECT CO.[CodCorNCon] ,CO.[NomConCor]     
                                                          FROM [GEOGRAXPSQL].[dbo].[Datos conceptos correccion notas DIAN] CO
                                                          WHERE CO.ApliConce = 'C' AND CO.HabilConce = 1")
        cboConceptoDeCorrección.DataSource = ConceptoDeCorreccion.Tables(0)
        cboConceptoDeCorrección.DisplayMember = "NomConCor"
        cboConceptoDeCorrección.ValueMember = "CodCorNCon"



        Dim TipoNotaCredito As DataSet = SQLDataSET("SELECT    TNC.[NomTipo], TNC.[CodTipo]  
                                                          FROM [BDADYSNET].[dbo].[Datos tipos de notas creditos] as TNC")
        cboTipoNotaCredito.DataSource = TipoNotaCredito.Tables(0)
        cboTipoNotaCredito.DisplayMember = "NomTipo"
        cboTipoNotaCredito.ValueMember = "CodTipo"

    End Sub
    Private Sub cboProovedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProovedores.SelectedIndexChanged
        If bandera = 1 Then
            CargaFacturas(cboProovedores.SelectedValue)
        End If
    End Sub

#End Region

#Region "Funciones"

    Private Sub CargarFechas()
        Try
            Dim fecha As Date = Date.Now
            ftDesde.Value = fecha.AddDays(-30)
            ftHasta.Value = fecha
        Catch ex As Exception
            MsgBox("Error al cargar fechas")
        End Try
    End Sub

    Private Function GenerarConcecutivo(CodDocu As String, ActConse As Boolean, CodUsua As String)
        Try
            Dim Consecutivo As String = ConsecutivoDocumen(CodDocu, ActConse, CodUsua)
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

            cn.Close()

            If Consecutivo = "0" Or Consecutivo = "-3" Or Consecutivo = "-2" Then
                Return False
            Else
                Return Consecutivo
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la creacion del concecutivo " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message

        End Try
    End Function

    Private Sub CargarUsuarioLogeado() 'Trae el usuario logeado
        Try
            lblNombreUsuario.Text = ModuloVariablesAplicacion.NombreUsuarioLogeado
            lblCodigoUsuario2.Text = ModuloVariablesAplicacion.CodigUsar
        Catch ex As Exception
            MsgBox("Hubo un error al cargar el usuario: ERRROR: " + ex.Message)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        Try
            Dim estado As Boolean = False





            If DataGridFacturas.Rows.Count <= 0 Then
                MsgBox("Escoge una factura primero")
                DataGridFacturas.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If


            If cboTipoNotaCredito.SelectedIndex < 0 Then
                MsgBox("Selecciona una opcion de tipo de nota credito")
                cboTipoNotaCredito.Select()
                estado = False
                Return False
            Else
                estado = True
            End If

            If cboConceptoDeCorrección.SelectedIndex = -1 Then
                MsgBox("Escoge una ConceptoDeCorrección")
                cboConceptoDeCorrección.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            If DataGridVirewDetalleDeFactura.Rows.Count <= 0 Then
                MsgBox("No puedes hacer una nota credito sin detalle")
                DataGridVirewDetalleDeFactura.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            If String.IsNullOrWhiteSpace(txtObservaciones.Text) Then
                MsgBox("El campo observaciones esta vacio")
                txtObservaciones.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If


            If estado = True Then

                Dim TotalFac As Double = Convert.ToDouble(DataGridFacturas.SelectedCells(5).Value)
                TotalFac = Math.Round((TotalFac), 0)

                If Convert.ToDouble(txtTotalGrillaDetalle.Text) > TotalFac Then
                    MsgBox("El total de la grilla no puede ser mayor al total de la factura")
                    txtTotalGrillaDetalle.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If

            End If

            If Convert.ToDouble(txtTotalGrillaDetalle.Text) <= 0 Then
                MsgBox("El total de la grilla de nota credito no puede menor o igual a 0")
                txtTotalGrillaDetalle.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            Return estado
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al cargar el la validacion de campos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub CalculatTotalGrillaDetalleFactura()
        Dim TotalDetalle As Double = 0
        Try
            Dim Filas As DataGridViewRow = New DataGridViewRow()
            For Each Filas In DataGridVirewDetalleDeFactura.Rows
                Dim ValorUnitario As Double = Filas.Cells("ValUnitario").Value
                Dim ValIVADeta As Double = Filas.Cells("ValIVADeta").Value
                '  Dim Total As Double = (ValorUnitario + ValIVADeta) * Filas.Cells("Cantidad").Value
                Dim Total As Double = Math.Round(((ValorUnitario + ValIVADeta) * Filas.Cells("Cantidad").Value), 0)
                TotalDetalle += Total
            Next
            txtTotalGrillaDetalle.Text = TotalDetalle
        Catch ex As Exception
            MsgBox("Error al calcular el total de las grillas" + ex.Message)
        End Try
    End Sub

    Private Function CargaFacturasConFiltroFecha(Identificador As String, fechainicial As Date, fechafinal As Date) As Boolean
        DataGridFacturas.AutoGenerateColumns = False
        DataGridFacturas.DataSource = Nothing
        DataGridFacturas.Rows.Clear()
        Try
            Dim reader As SqlDataReader
            Dim consulta As String = "SELECT FR.PrefiFact, FR.NumFact, FR.NumRemi, DR.ID_Contratos, FR.FecExpFac, FR.ValNetoFac + FR.ValIVAFac AS TolFact
                                        FROM BDADYSNET.dbo.[Datos facturas realizadas] AS FR INNER JOIN BDADYSNET.dbo.[Datos remisiones de facturas] AS DR ON FR.NumRemi = DR.NumRemi
                                        WHERE (CodEstaDian NOT IN ('00', '01', '04')) AND (ValNetoFac + ValIVAFac > 0) AND (TipDocTer + NumDocTer + SucDocTer = '" & Identificador & "') 
                                        AND (FecExpFac BETWEEN  '" & Format(fechainicial, "yyyy-MM-dd") & "' AND  '" & Format(fechafinal, "yyyy-MM-dd") & "')"
            reader = SQLReader(consulta)

            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridFacturas.Rows.Add(reader("PrefiFact"), reader("NumFact"), reader("NumRemi"), reader("ID_Contratos"), reader("FecExpFac"), reader("TolFact"))
                End While
            End If
            reader.Close()
            reader = Nothing
            cn.Close()
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion cargar las facturas de este proovedor." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CargaFacturas(Identificador As String) As Boolean
        DataGridFacturas.AutoGenerateColumns = False
        DataGridFacturas.DataSource = Nothing
        DataGridFacturas.Rows.Clear()
        Try
            Dim reader As SqlDataReader
            Dim consulta As String = "SELECT FR.PrefiFact, FR.NumFact, FR.NumRemi, DR.ID_Contratos, FR.FecExpFac, FR.ValNetoFac + FR.ValIVAFac AS TolFact
                                        FROM BDADYSNET.dbo.[Datos facturas realizadas] AS FR INNER JOIN BDADYSNET.dbo.[Datos remisiones de facturas] AS DR ON FR.NumRemi = DR.NumRemi
                                        WHERE (CodEstaDian NOT IN ('00', '01', '04')) AND (ValNetoFac + ValIVAFac > 0) AND (TipDocTer + NumDocTer + SucDocTer = '" & Identificador & "')"
            reader = SQLReader(consulta)

            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridFacturas.Rows.Add(reader("PrefiFact"), reader("NumFact"), reader("NumRemi"), reader("ID_Contratos"), reader("FecExpFac"), reader("TolFact"))
                End While
            Else
                MsgBox("No se encontraron facturas a este proveedor")
            End If
            reader.Close()
            reader = Nothing
            cn.Close()
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion cargar las facturas de este proovedor." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CargaFacturasConFiltroDeNumFactura(Identificador As String, NumFactura As String) As Boolean
        DataGridFacturas.AutoGenerateColumns = False
        DataGridFacturas.DataSource = Nothing
        DataGridFacturas.Rows.Clear()
        Try
            Dim reader As SqlDataReader
            Dim consulta As String = "SELECT FR.PrefiFact, FR.NumFact, FR.NumRemi, DR.ID_Contratos, FR.FecExpFac, FR.ValNetoFac + FR.ValIVAFac AS TolFact
                                        FROM BDADYSNET.dbo.[Datos facturas realizadas] AS FR INNER JOIN BDADYSNET.dbo.[Datos remisiones de facturas] AS DR ON FR.NumRemi = DR.NumRemi
                                        WHERE (CodEstaDian NOT IN ('00', '01', '04')) AND (ValNetoFac + ValIVAFac > 0) AND (TipDocTer + NumDocTer + SucDocTer = '" & Identificador & "' AND  fr.NumFact like '%'+'" & NumFactura & "'+'%')"
            reader = SQLReader(consulta)

            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridFacturas.Rows.Add(reader("PrefiFact"), reader("NumFact"), reader("NumRemi"), reader("ID_Contratos"), reader("FecExpFac"), reader("TolFact"))
                End While
            End If
            reader.Close()
            reader = Nothing
            cn.Close()
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion cargar las facturas de este proovedor." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CargarDetalleFactura(Identificador, numFactura)

        Dim Resultado As Object

        Try
            cn.Open()
            Dim ComprobarPago As SqlCommand
            ComprobarPago = New SqlCommand With {
                .Connection = cn,
                .CommandText = "select Count(DocuCredito) from [Datos notas creditos facturas] where DocuCredito = @Numero_factura and AnulCredi = 0"
            }
            ComprobarPago.Parameters.AddWithValue("@Numero_factura", numFactura)
            Resultado = ComprobarPago.ExecuteScalar()

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de si existe la nota credito" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cn.Close()
        End Try

        If Resultado = 0 Then
            Try
                btnAnularNotaCredito.Visible = False
                lblNotaCredito.Visible = False
                txtNumNotaCredito.Visible = False
                btnImprimir.Enabled = False
                DataGridVirewDetalleDeFactura.AutoGenerateColumns = False
                DataGridVirewDetalleDeFactura.DataSource = Nothing
                DataGridVirewDetalleDeFactura.Rows.Clear()
                Dim consulta As String = "SELECT DE.ItemNum, DE.CodProSer, DE.Concepto, DE.CantDeta, DE.ValUniDeta, DE.ValIVADeta
                                            FROM BDADYSNET.dbo.[Datos detalle de remisiones] AS DE INNER JOIN
                                            BDADYSNET.dbo.[Datos remisiones de facturas] AS RE ON DE.NumRemi = RE.NumRemi INNER JOIN
                                            BDADYSNET.dbo.[Datos catalogo de producservicios] AS CA ON DE.CodProSer = CA.CodProSer INNER JOIN
                                            BDADYSNET.dbo.[Datos facturas realizadas] AS FR ON RE.NumRemi = FR.NumRemi
                                            WHERE  (FR.FactAnula = 0) AND (FR.CodEstaDian NOT IN ('00', '01', '04')) 
                                            AND (FR.ValNetoFac + FR.ValIVAFac > 0) 
                                            AND (FR.TipDocTer + FR.NumDocTer + FR.SucDocTer = '" & Identificador.ToString & "')
                                            AND FR.NumFact = '" & numFactura.ToString & "'"

                Dim reader As SqlDataReader = SQLReader(consulta)

                If reader.HasRows Then
                    While reader.Read()
                        Me.DataGridVirewDetalleDeFactura.Rows.Add(reader("ItemNum"), reader("CodProSer"), reader("Concepto"), reader("CantDeta"), reader("ValUniDeta"), reader("ValIVADeta"))
                    End While
                    CalculatTotalGrillaDetalleFactura()
                Else
                    MsgBox("No se encontro detalle de esta factura")
                End If
                reader.Close()
                reader = Nothing
                cn.Close()
                Return True
            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en la funcion cargar detalle de las facturas de este proovedor." & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        Else
            MsgBox("Esta factura ya tiene una nota credito")
            btnAnularNotaCredito.Visible = True
            lblNotaCredito.Visible = True
            txtNumNotaCredito.Visible = True
            btnImprimir.Enabled = True
            DataGridVirewDetalleDeFactura.AutoGenerateColumns = False
            DataGridVirewDetalleDeFactura.DataSource = Nothing
            DataGridVirewDetalleDeFactura.Rows.Clear()

            Try
                Dim consulta As String = "SELECT DNC.PrefiNotCre, DNC.TipoNota, DNC.NumNoCre, DNC.ConcepCre, DDNC.CodSerNoCre, DNC.CodCorre, DDNC.CantiServi, DDNC.ValUnitaSer, DDNC.ValIvaFac FROM [Datos notas creditos facturas] AS DNC, [Datos detalle notas creditos] AS DDNC
                                           WHERE   DNC.DocuCredito = '" & numFactura.ToString & "' AND DNC.NumNoCre = DDNC.NumNoCreD"

                Dim reader2 As SqlDataReader = SQLReader(consulta)
                Dim Contador As Int16 = 0
                If reader2.HasRows Then

                    While reader2.Read()
                        cboTipoNotaCredito.SelectedValue = reader2("TipoNota")
                        txtNumNotaCredito.Text = reader2("NumNoCre")
                        txtObservaciones.Text = reader2("ConcepCre")
                        cboConceptoDeCorrección.SelectedValue = reader2("CodCorre")
                        cboTipoNotaCredito.SelectedValue = reader2("TipoNota")

                        ModuloVariablesAplicacion.NumNoCre = reader2("NumNoCre")
                        ModuloVariablesAplicacion.PrefiNotCre = reader2("PrefiNotCre")

                        Contador += 1
                        Me.DataGridVirewDetalleDeFactura.Rows.Add(Contador, reader2("CodSerNoCre"), "", reader2("CantiServi"), reader2("ValUnitaSer"), reader2("ValIvaFac"))
                    End While
                    CalculatTotalGrillaDetalleFactura()
                Else
                    MsgBox("No se encontro detalle de esta nota credito")
                End If
                reader2.Close()
                reader2 = Nothing
                cn.Close()
                Return True

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en la funcion cargar la nota credito a esta factura" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try

        End If


    End Function



#End Region

#Region "Botones, texbox y datepicker"


    Private Sub btnAnularNotaCredito_Click(sender As Object, e As EventArgs) Handles btnAnularNotaCredito.Click
        Try

            ClaseModuloNotaCredito.AnularNotaCredito(txtNumNotaCredito.Text, lblCodigoUsuario2.Text)

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al anular la nota credito" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If ValidarCampos() Then
                'FALTA LA VALIDACION DE LOS PAGOS
                If MsgBox("Se le hara una nota credito a esta factura ¿Esta seguro?", vbYesNo) = vbYes Then

                    Dim Concecutivo As String = GenerarConcecutivo("04", True, lblCodigoUsuario2.Text)

                    If String.IsNullOrWhiteSpace(Concecutivo) = False Then

                        Dim PrefijoNotaCredito As String
                        Dim NumNotaCredito As Integer
                        Dim codEstado As String
                        Dim prefijo As SqlDataReader

                        prefijo = SQLReader("select PrefiConse from [Datos consecutivos SIIGHOSPLUS] WHERE CodConse = 04")

                        If prefijo.HasRows = False Then
                            MsgBox("No se encontro el concecutivo")
                            Exit Sub
                        Else
                            prefijo.Read()
                            PrefijoNotaCredito = prefijo("PrefiConse")
                            Dim LargoPrefijo As Integer = Len(PrefijoNotaCredito)
                            Dim LargoNumFactura As Integer = (Len(Concecutivo) - LargoPrefijo)
                            NumNotaCredito = Concecutivo.Substring(LargoPrefijo, LargoNumFactura)
                            cn.Close()
                        End If

                        Dim fecha As Date = Date.Now
                        Dim PrefiFac As String = DataGridFacturas.SelectedCells(0).Value.ToString
                        Dim NumFac As String = DataGridFacturas.SelectedCells(1).Value.ToString
                        Dim TotalFac As Double = Convert.ToDouble(DataGridFacturas.SelectedCells(5).Value)
                        TotalFac = Math.Round((TotalFac), 0)

                        Dim EstadoRegistro As Boolean = ClaseModuloNotaCredito.NotaCredito(PrefijoNotaCredito, NumNotaCredito, PrefiFac, NumFac, "0", cboTipoNotaCredito.SelectedValue, txtObservaciones.Text, cboConceptoDeCorrección.SelectedValue, txtTotalGrillaDetalle.Text, 0, lblCodigoUsuario2.Text, DataGridVirewDetalleDeFactura)

                        If EstadoRegistro = True Then

                            Dim Proc As New System.Diagnostics.Process
                            Proc.StartInfo = New ProcessStartInfo("C:\SIIGHOSPLUS\OBFACELEC\APIFACTELEC\ApiFactElec.exe")
                            Proc.StartInfo.Arguments = "notacredito " + NumNotaCredito.ToString + " " + NumFac + " " + PrefijoNotaCredito + " " + PrefiFac


                            Proc.StartInfo.UseShellExecute = False

                            Proc.Start()
                            Proc.WaitForExit()


                            Dim dr1 As Object


                            'dr1 = SQLReader("SELECT CodEstaDian FROM [BDADYSNET].[dbo].[Datos facturas realizadas] WHERE PrefiFact = '" + PrefijoFacturas + "' AND NumFact = '" + NumFactura.ToString + "' AND NumRemi = '" + txtNumRemision.Text + "'")

                            cn.Open()

                            Dim EstadoFacturaDiam As SqlCommand
                            EstadoFacturaDiam = New SqlCommand With {
                                   .Connection = cn,
                                   .CommandText = "SELECT CodEstaDian FROM [BDADYSNET].[dbo].[Datos notas creditos facturas] WHERE [PrefiNotCre] = '" + PrefijoNotaCredito + "' AND [NumNoCre] = '" + NumNotaCredito.ToString + "' AND [DocuCredito] = '" + NumFac + "'"
                                }
                            dr1 = EstadoFacturaDiam.ExecuteScalar()


                            If dr1 = Nothing Then
                                MsgBox("No se encontro información de la factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString)
                                Exit Sub
                                cn.Close()

                            Else

                                codEstado = dr1.ToString

                                Select Case codEstado
                                    Case "01"
                                        MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 01 Documento preparado para envia a la DIAN.")
                                    Case "02"
                                        MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 02 Documento validado por la DIAN.")
                                    Case "03"
                                        MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 03 Documento enviado al cliente.")
                                    Case "04"
                                        MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 04 Documento NO validado por la DIAN.")
                                    Case "05"
                                        MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 05 Documento rebota correo del cliente.")
                                    Case "06"
                                        MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 06 Documento validado por la DIAN CON Notificaciones.")
                                    Case Else
                                        Dim estado As Boolean = SQLUpdate("Update [BDADYSNET].[dbo].[Datos notas creditos facturas]
                                                                                SET [CodEstaDian] = '01' WHERE [PrefijoNotaCredito] = '" & PrefijoNotaCredito & "'
                                                                                And [NumNoCre] = '" & NumNotaCredito & "")
                                        If estado Then
                                            MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " se registró en estado 01 Documento preparado para envia a la DIAN.")
                                        Else
                                            MessageBox.Show("La factura: " + PrefijoNotaCredito + " " + NumNotaCredito.ToString + " no se registro en ninguno de los estados del documento validado")
                                        End If

                                End Select
                                cn.Close()
                            End If

                            If codEstado = "01" Or codEstado = "00" Or codEstado = "04" Then

                                MessageBox.Show("No se pudo anular la factura ya que el documento no se envio a la Dian")

                            ElseIf (Convert.ToDouble(txtTotalGrillaDetalle.Text) = TotalFac) Then

                                Dim EstadoFac As Boolean = SQLUpdate("UPDATE [BDADYSNET].[dbo].[Datos facturas realizadas] SET FactAnula = 1, RazAnulFac = 'LA FACTURA DE ANULO POR NOTA CREDITO', FecAnula = '" & Format(fecha, "yyyy/MM/dd") & "' " +
                                                                    "WHERE NumFact = '" & NumFac & "'")

                                Dim Factura As SqlDataReader = SQLReader("SELECT DF.NumRemi, [Datos registros de contratos].ID_Contratos, DR.CuotNum
                                                                    FROM  [Datos facturas realizadas] AS DF INNER JOIN
                                                                    [Datos remisiones de facturas] AS DR ON DF.NumRemi = DR.NumRemi INNER JOIN
                                                                    [Datos registros de contratos] ON DR.ID_Contratos = [Datos registros de contratos].ID_Contratos
                                                                    WHERE (DF.NumFact = '" & NumFac & "')")

                                If Factura.HasRows = False Then
                                    MessageBox.Show("No se encontro la el numero de Remision para anular la Factura")
                                    Exit Sub

                                End If

                                Factura.Read()

                                Dim NumRemi As String = Factura("NumRemi")
                                Dim ID_Contratos As String = Factura("ID_Contratos")
                                Dim CuotNum As String = Factura("CuotNum")

                                cn.Close()
                                Factura.Close()


                                Dim EstadoCuota As Boolean = SQLUpdate("UPDATE [BDADYSNET].[dbo].[Datos detalles de cuotas contratos] SET FacturCuota = 0 WHERE ID_Contratos = '" & ID_Contratos & "' AND CuotaNoPac = '" & CuotNum & "'")

                                If EstadoCuota = True Then
                                    MessageBox.Show("La factura: " & NumFac & " se anulo correctamente")
                                End If
                            End If
                        End If

                    Else
                        MsgBox("Hubo un error al generar el concecutivo")
                    End If

                End If
            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al guardar la nota credito" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ftDesde_ValueChanged(sender As Object, e As EventArgs) Handles ftDesde.ValueChanged
        Try
            If bandera = 1 Then
                CargaFacturasConFiltroFecha(cboProovedores.SelectedValue, ftDesde.Value.Date, ftHasta.Value.Date)
            End If
        Catch ex As Exception
            MsgBox("Error en el evento value Chaged de dtpicker Desde" + ex.Message)
        End Try

    End Sub

    Private Sub ftHasta_ValueChanged(sender As Object, e As EventArgs) Handles ftHasta.ValueChanged
        Try
            If bandera = 1 Then
                CargaFacturasConFiltroFecha(cboProovedores.SelectedValue, ftDesde.Value.Date, ftHasta.Value.Date)
            End If
        Catch ex As Exception
            MsgBox("Error en el evento value Chaged de dtpicker Hastta" + ex.Message)
        End Try

    End Sub

    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click
        Me.Dispose()
    End Sub

    Private Sub txtBuscarFactura_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarFactura.TextChanged
        Try
            If String.IsNullOrWhiteSpace(txtBuscarFactura.Text) Then
                CargaFacturas(cboProovedores.SelectedValue)
            Else
                CargaFacturasConFiltroDeNumFactura(cboProovedores.SelectedValue, txtBuscarFactura.Text)
            End If
        Catch ex As Exception
            MsgBox("Error en el texbox de busqueda de factura" + ex.Message)
        End Try
    End Sub


#End Region

#Region "Dataagridview"
    Private Sub DataGridFacturas_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridFacturas.CurrentCellChanged
        Try
            If DataGridFacturas.SelectedCells.Count <> 0 Then
                Dim NumFac As String = DataGridFacturas.SelectedCells(1).Value.ToString()

                ModuloVariablesAplicacion.NumFact = NumFac
                ModuloVariablesAplicacion.PrefiFact = DataGridFacturas.SelectedCells(0).Value.ToString()
                CargarDetalleFactura(cboProovedores.SelectedValue, NumFac)


            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el evento DataGridFacturas_CurrentCellChanged " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridVirewDetalleDeFactura_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridVirewDetalleDeFactura.CurrentCellChanged
        Try
            CalculatTotalGrillaDetalleFactura()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridVirewDetalleDeFactura_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridVirewDetalleDeFactura.RowsRemoved
        Try
            CalculatTotalGrillaDetalleFactura()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region

    Dim fechaActual As Date = Date.Now
    Dim bandera As Integer = 0
    Private Sub NotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Call conectarGeogebra()
            CargarUsuarioLogeado()
            CargarFechas()
            CargarCombobox()
            bandera = 1
            If bandera = 1 Then
                CargaFacturasConFiltroFecha(cboProovedores.SelectedValue, ftDesde.Value.Date, ftHasta.Value.Date)
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al cargar el formulario" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try



            ModuloVariablesAplicacion.infNombreInforme = "InfNotaCredito"

            Dim FrmlnfNotaCredito As New FrmlnfNotaCredito
            FrmlnfNotaCredito.ShowDialog()


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al imprimir la nota credito " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class