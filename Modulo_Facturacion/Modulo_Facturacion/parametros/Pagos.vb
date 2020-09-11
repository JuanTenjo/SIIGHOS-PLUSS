Imports System.Data.SqlClient
Public Class Pagos
    Dim bandera As Int16 = 0
    Dim ModuloDeClasePagos As New ModuloDeClasePagos 'Instancia

#Region "ComboBox"

    Private Sub CargarCombobox()
        Try
            Dim Facturas As DataSet = SQLDataSET("SELECT df.NumFact FROM [Datos facturas realizadas] as df WHERE FactAnula = 0")
            cboFacturas.DataSource = Facturas.Tables(0)
            cboFacturas.DisplayMember = "NumFact"
            cboFacturas.ValueMember = "NumFact"

            Dim CodigoContables As DataSet = SQLDataSET("SELECT CueContaIPS, CueContaIPS + ' ' + NomCConIPS as CodigoContable FROM [Datos ctas contables IPS]")
            cboCodigoContable.DataSource = CodigoContables.Tables(0)
            cboCodigoContable.DisplayMember = "CodigoContable"
            cboCodigoContable.ValueMember = "CueContaIPS"

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de cargar combobox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cboFacturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFacturas.SelectedIndexChanged
        CargarDatosFactura()
    End Sub

#End Region

#Region "Botones y Texbox"
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try

            If ValidarDatos() Then
                Dim Consulta As Boolean = ModuloDeClasePagos.RegistrarPago(cboFacturas.SelectedValue, cboCodigoContable.SelectedValue, txtDetallePago.Text, txtValorDebito.Text,
                                             txtValorCredito.Text, DtFechaMovimiento.Value, 0, Date.Now, txtCodRegis.Text, ftRegis.Value, txtCodModi.Text,
                                             ftModi.Value, txtValorDescuento.Text, txtImpuestos.Text, txtPagoRealizados.Text, DtUltimoPago.Value, txtRemision.Text)
                If Consulta Then
                    CargarDatosFactura()
                End If

            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion pagar " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If ValidarDatos() Then
                Dim fecha As Date = Date.Now
                If MsgBox("¿Desea anular este pago?", vbYesNo) = vbYes Then
                    ModuloDeClasePagos.AnularPago(cboFacturas.SelectedValue, txtRemision.Text)
                    CargarDatosFactura()
                End If
            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion eliminar pago " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            If bandera = 1 Then

                ModuloVariablesAplicacion.InfConsultaReporte = "SELECT * FROM [Datos detalle de pagos] WHERE Numero_factura = '" & cboFacturas.SelectedValue & "'"
                ModuloVariablesAplicacion.InfCabecera = "Pagos"
                ModuloVariablesAplicacion.InfTituloInforme = "Reporte de Pagos"
                ModuloVariablesAplicacion.infNombreInforme = "ReportPagos"

                Dim FrmsInformes As New FrmlInformes
                FrmlInformes.ShowDialog()

            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la boton generar reporte  " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDocuTer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorIVAFactura.KeyPress, txtValorFactura.KeyPress, txtValorDescuento.KeyPress, txtValorDebito.KeyPress, txtValorCredito.KeyPress, txtRemision.KeyPress, txtImpuestos.KeyPress, txtDocuTer.KeyPress, cboCodigoContable.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click
        Me.Dispose()
    End Sub

    Private Sub cboFacturas_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFacturas.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If bandera = 1 Then
                    CargarDatosFactura()
                End If
        End Select
    End Sub

#End Region

#Region "Funciones"

    Private Function ValidarDatos() As Boolean
        Try
            Dim estado As Boolean = False

            If cboFacturas.SelectedIndex = -1 Then
                MsgBox("No escogio una factura existente")
                cboFacturas.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(txtValorDebito.Text) Then
                MsgBox("Digite un valor debito")
                txtValorDebito.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(txtValorCredito.Text) Then
                MsgBox("Digite un valor credito")
                txtValorCredito.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboCodigoContable.SelectedIndex = -1 Then
                MsgBox("No escogio una cuenta contable existente")
                cboCodigoContable.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            Return estado
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de datos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Private Sub CargarDetalleFactura()
        Try
            DataGridViewDetalleRemision.Rows.Clear()
            Dim readerdetalle As SqlDataReader
            readerdetalle = SQLReader("SELECT dtr.* FROM [Datos facturas realizadas] as df, [Datos detalle de remisiones] as dtr where
                                df.NumRemi = dtr.NumRemi and df.NumFact = '" & cboFacturas.SelectedValue & "'")
            While readerdetalle.Read()
                Dim TotalItems As Double = ((readerdetalle("ValUniDeta") * readerdetalle("CantDeta")) + readerdetalle("ValIVADeta"))
                DataGridViewDetalleRemision.Rows.Add(New String() {readerdetalle("ItemNum"), readerdetalle("CodProSer"), readerdetalle("Concepto"), readerdetalle("CantDeta"), readerdetalle("ValUniDeta"), readerdetalle("ValIVADeta"), TotalItems})
            End While
            readerdetalle.Close()
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al cargos los detalles de la factura" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarDatosFactura()

        If bandera = 1 Then

            Dim Resultado As Object = 0

            Try
                cn.Open()
                Dim VerificarPago As SqlCommand
                VerificarPago = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "select Count(ddp.Numero_factura) from [Datos detalle de pagos] as ddp where ddp.Numero_factura = '" & cboFacturas.SelectedValue & "' and ddp.Anulada = 0"
                }
                Resultado = VerificarPago.ExecuteScalar()

                cn.Close()

                If Resultado = 0 Then 'Si esta en significa que no existe ningun pago aun

                    Dim reader As SqlDataReader
                    reader = SQLReader("SELECT df.TipDocTer, df.NumDocTer, dp.RazonSol, df.NumRemi, df.ValNetoFac, df.ValIVAFac, 
                                    df.FecExpFac, df.FecVenFac, df.FecUltiPag, df.TolImpApli, df.ValDesFac, df.ValNotDeFac,
                                    df.ValNotCreFac, df.TolPagFac
                                    FROM [Datos facturas realizadas] as df, [Datos proveedores] as dp
                                    WHERE df.NumDocTer = dp.IdenProve AND   df.NumFact = '" & cboFacturas.SelectedValue & "'")

                    If reader.HasRows = False Then
                        MsgBox("Factura no existe en la base de datos")
                        Exit Sub
                    Else
                        reader.Read()
                        txtTipoDocTer.Text = reader("TipDocTer")
                        txtDocuTer.Text = reader("NumDocTer")
                        txtRazonSolTer.Text = reader("RazonSol")
                        txtRemision.Text = reader("NumRemi")
                        txtImpuestos.Text = reader("TolImpApli")
                        txtValorDescuento.Text = reader("ValDesFac")
                        txtPagoRealizados.Text = reader("TolPagFac")
                        txtValorDebito.Text = reader("ValNotDeFac")
                        txtValorCredito.Text = reader("ValNotCreFac")
                        txtValorFactura.Text = reader("ValNetoFac")
                        txtValorIVAFactura.Text = reader("ValIVAFac")
                        DtFechaExpedicion.Value = Convert.ToDateTime(reader("FecExpFac"))
                        DtFechaVencimeinto.Value = Convert.ToDateTime(reader("FecVenFac"))
                        DtUltimoPago.Value = Convert.ToDateTime(reader("FecUltiPag"))
                        reader.Close()
                        cn.Close()
                        CargarDetalleFactura()
                        btnEliminar.Enabled = False
                        txtPagoRealizados.Text = Resultado.ToString
                        LabelPagado.Visible = False
                        LabelPendiente.Visible = True
                        btnReporte.Enabled = False
                        GroupModi.Enabled = False
                        GroupRegis.Enabled = True
                    End If


                ElseIf Resultado > 0 Then  'Si es mayor a 0 si existe al menos un pago a esta factura


                    Dim reader2 As SqlDataReader
                    reader2 = SQLReader("SELECT df.TipDocTer,df.NumDocTer, dp.RazonSol, df.NumRemi, df.ValNetoFac, df.ValIVAFac, df.FecExpFac, df.FecVenFac, df.FecUltiPag, df.TolImpApli,
                                        df.ValDesFac, df.ValNotDeFac, df.ValNotCreFac, df.TolPagFac, ddp.Detalle, ddp.anulada, ddp.Cod_Regis, ddp.Fec_Regis, ddp.Cod_Modi, ddp.Fec_Modi
                                FROM [Datos facturas realizadas] as df, [Datos proveedores] as dp, [Datos detalle de pagos] as ddp
                                where df.NumDocTer = dp.IdenProve AND ddp.Numero_factura = df.NumFact AND df.NumFact = '" & cboFacturas.SelectedValue & "'")

                    If reader2.HasRows = False Then
                        MsgBox("No se efectuaron detalle de pagos")
                        Exit Sub
                    Else
                        reader2.Read()
                        CheckAnulada.Checked = reader2("anulada")
                        txtDocuTer.Text = reader2("NumDocTer")
                        txtTipoDocTer.Text = reader2("TipDocTer")
                        txtRazonSolTer.Text = reader2("RazonSol")
                        txtRemision.Text = reader2("NumRemi")
                        txtImpuestos.Text = reader2("TolImpApli")
                        txtValorDescuento.Text = reader2("ValDesFac")
                        txtPagoRealizados.Text = reader2("TolPagFac")
                        txtValorDebito.Text = reader2("ValNotDeFac")
                        txtDetallePago.Text = reader2("Detalle")
                        txtValorCredito.Text = reader2("ValNotCreFac")
                        txtValorFactura.Text = reader2("ValNetoFac")
                        txtValorIVAFactura.Text = reader2("ValIVAFac")
                        DtFechaExpedicion.Value = Convert.ToDateTime(reader2("FecExpFac"))
                        DtFechaVencimeinto.Value = Convert.ToDateTime(reader2("FecVenFac"))
                        DtUltimoPago.Value = Convert.ToDateTime(reader2("FecUltiPag"))
                        txtCodRegis.Text = reader2("Cod_Regis")
                        ftRegis.Value = Convert.ToDateTime(reader2("Fec_Regis"))
                        txtCodModi.Text = reader2("Cod_Modi")
                        ftModi.Value = Convert.ToDateTime(reader2("Fec_Modi"))
                        reader2.Close()
                        cn.Close()
                        CargarDetalleFactura()
                        GroupRegis.Enabled = False
                        GroupModi.Enabled = True
                        btnReporte.Enabled = True
                        btnEliminar.Enabled = True
                        txtPagoRealizados.Text = Resultado.ToString
                        LabelPagado.Visible = True
                        LabelPendiente.Visible = False

                    End If

                Else
                    MsgBox("Ni idea")
                End If

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en la validacion de si existe pago" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                cn.Close()
            End Try   'Actualiza Estado de factura y actualiza los pagos

        End If

    End Sub
#End Region

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call conectarGeogebra()
            CargarCombobox()
            bandera = 1
            CargarDatosFactura()
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la carga del programa pagos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class