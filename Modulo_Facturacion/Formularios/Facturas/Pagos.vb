﻿Imports System.Data.SqlClient
Public Class Pagos
    Dim bandera As Int16 = 0
    Dim ModuloDeClasePagos As New ModuloDeClasePagos 'Instancia
    Dim RadioButton As Int16 = 1
#Region "ComboBox"

    Private Sub CargarCombobox()
        Try
            Dim Facturas As DataSet = SQLDataSET("SELECT df.NumFact FROM [Datos facturas realizadas] as df, [GEOGRAXPSQL].[dbo].[Datos proveedores] as dp 
                                                    WHERE df.NumDocTer = dp.IdenProve and df.FactAnula = 0")
            cboFacturas.DataSource = Facturas.Tables(0)
            cboFacturas.DisplayMember = "NumFact"
            cboFacturas.ValueMember = "NumFact"


            Dim ComboBancos As DataSet = SQLDataSET("SELECT        [Datos de los bancos].CodiBanco, [Datos de los bancos].NomBanco, [Datos de los bancos].TipoBanco
                                                        FROM       [Datos de los bancos] INNER JOIN [Datos cuentas bancarias] ON [Datos de los bancos].CodiBanco = [Datos cuentas bancarias].CodiBanco
                                                        WHERE [Datos cuentas bancarias].CtaActiva = 1
						                                Group By [Datos de los bancos].CodiBanco,[Datos de los bancos].NomBanco,[Datos de los bancos].TipoBanco")
            cboBancos.DataSource = ComboBancos.Tables(0)
            cboBancos.DisplayMember = "NomBanco"
            cboBancos.ValueMember = "CodiBanco"




        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de cargar combobox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboBancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBancos.SelectedIndexChanged
        Try
            If bandera = 1 Then
                CargarCuentasBancarias(cboBancos.SelectedValue)

            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la carga el nombre de los bancos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboFacturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFacturas.SelectedIndexChanged

        CargarDatosFactura()
        If bandera = 1 Then
            CalcularSaldo()
        End If

    End Sub

#End Region

#Region "Botones y Texbox"
    Private Sub txtValorContablePago_TextChanged(sender As Object, e As EventArgs) Handles txtValorContablePago.TextChanged
        CalcularTotalConsignador()
    End Sub
    Private Sub txtValorContableInteres_TextChanged(sender As Object, e As EventArgs)
        CalcularTotalConsignador()
    End Sub
    Private Sub txtCuentaContablePago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContablePago.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentaContablePago.Clear()
                    txtCuentaContablePago.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub txtCuentaEstampillas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaEstampillas.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentaEstampillas.Clear()
                    txtCuentaEstampillas.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCuentaReteIVA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaReteIVA.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentaReteIVA.Clear()
                    txtCuentaReteIVA.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCuentasReteIca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentasReteIca.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentasReteIca.Clear()
                    txtCuentasReteIca.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCuentasReteFuente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentasReteFuente.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentasReteFuente.Clear()
                    txtCuentasReteFuente.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCuentasPagoOpor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentasPagoOpor.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentasPagoOpor.Clear()
                    txtCuentasPagoOpor.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCuentaOtrosDesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaOtrosDesc.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentaOtrosDesc.Clear()
                    txtCuentaOtrosDesc.Text = ModuloVariablesAplicacion.CuentasContables

            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown al cargar las cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click

        Me.Dispose()
    End Sub

#End Region

#Region "Funciones"

    Private Sub CalcularTotalConsignador()

        Dim Pago As Double = 0
        Dim Interes As Double = 0

        If (String.IsNullOrWhiteSpace(txtValorContablePago.Text)) Then
            Pago = 0
        Else
            Pago = Convert.ToDouble(txtValorContablePago.Text)
        End If

        Dim Total As Double = Pago + Interes

        txtTotalConsignado.Text = String.Format("{0:C2}", Total)

    End Sub

    Private Function CreaConsecutivo(CodDocu As String, ActConse As Boolean, CodUsua As String) As String
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
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function 'Crea el concecutivo


    Private Sub CargarCuentasBancarias(codigoBanco)
        Try
            cboNumCuenta.DataSource = Nothing

            Dim ComboCuentasBancarias As DataSet = SQLDataSET("SELECT [Datos cuentas bancarias].NumCuenta, [Datos cuentas bancarias].CuenConta, [Datos cuentas bancarias].TipoNit, [Datos cuentas bancarias].NitBanco, [Datos cuentas bancarias].SucurNitBanco, 
                                                             [Datos cuentas bancarias].ItemCuenta
                                                               FROM            [Datos cuentas bancarias] INNER JOIN
                                                           [Datos de los bancos] ON [Datos cuentas bancarias].CodiBanco = [Datos de los bancos].CodiBanco WHERE [Datos cuentas bancarias].CtaActiva = 1 and [Datos de los bancos].CodiBanco = '" & codigoBanco.ToString & "'")

            cboNumCuenta.DataSource = ComboCuentasBancarias.Tables(0)
            cboNumCuenta.DisplayMember = "CuenConta"
            cboNumCuenta.ValueMember = "CuenConta"
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la cargar las cuentas bancarias" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function CalcularSaldo() As Boolean
        Try


            txtValorSaldo.Clear()

            Dim SaldoTotal As Double = Convert.ToDouble(txtValorTotal.Text) + Convert.ToDouble(txtValorDebitos.Text)

            Dim SaldoResta As Double = (Convert.ToDouble(txtValorCreditos.Text) + Convert.ToDouble(txtValorDescuentos.Text) + Convert.ToDouble(txtValorTotalAbonos.Text) + Convert.ToDouble(txtValorImpuestos.Text) + Convert.ToDouble(txtValorGlosado.Text))

            SaldoTotal = SaldoTotal - SaldoResta


            If SaldoTotal <= 0 Then
                MsgBox("Lo siento pero el saldo actual de la factura no le permite registrar ningún tipo de abono a la misma")
                Return False
            Else
                Dim PagoFac As Double = Convert.ToDouble(txtValorTotal.Text)
                If SaldoTotal > PagoFac Then
                    MsgBox("Lo siento pero el valor total a pagar, no puede ser mayor al valor total del saldo de la factura ")
                    Return False
                Else

                    txtValorSaldo.Text = SaldoTotal


                    Return True
                End If

            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al calcular Saldo" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
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

    Private Sub CargarDatosFactura()
        Try

            If bandera = 1 Then
                Dim reader As SqlDataReader = SQLReader("SELECT df.TipDocTer, df.NumDocTer, dp.DigVeri, dp.SucurProv, dp.RazonSol, df.NumRemi, df.ValNetoFac, df.ValIVAFac, 
                                        df.FecExpFac, df.FecVenFac, df.FecUltiPag, df.TolImpApli, df.ValDesFac, df.ValNotDeFac,
                                        df.ValNotCreFac, df.TolPagFac,  (df.ValNetoFac + df.ValIVAFac) as TotalFactura
                                        FROM [Datos facturas realizadas] as df, [GEOGRAXPSQL].[dbo].[Datos proveedores] as dp
                                        WHERE df.NumDocTer = dp.IdenProve AND   df.NumFact = '" & cboFacturas.SelectedValue & "'")



                Dim TotalDetallePago As String = ""

                If reader.HasRows Then
                    reader.Read()

                    txtValorTotal.Text = reader("TotalFactura")
                    txtValorCreditos.Text = reader("ValNotCreFac")
                    txtValorGlosado.Text = 0
                    txtValorDebitos.Text = reader("ValNotDeFac")
                    txtValorImpuestos.Text = reader("TolImpApli")
                    txtValorDescuentos.Text = reader("ValDesFac")
                    txtValorInteres.Text = 0
                    txtValorTotalAbonos.Text = reader("TolPagFac")
                    txtTipoDocTer.Text = reader("TipDocTer")
                    txtDocuTer.Text = reader("NumDocTer")
                    txtDocuContablePago.Text = reader("NumDocTer")
                    txtDigiContablePago.Text = reader("DigVeri")
                    txtRazonSolTer.Text = reader("RazonSol")
                    txtSucursal.Text = reader("SucurProv")
                    txtRemision.Text = reader("NumRemi")
                    DtFechaExpedicion.Value = Convert.ToDateTime(reader("FecExpFac"))
                    DtFechaVencimeinto.Value = Convert.ToDateTime(reader("FecVenFac"))
                    DtUltimoPago.Value = Convert.ToDateTime(reader("FecUltiPag"))

                End If

                If (cn.State = ConnectionState.Open) Then cn.Close()

                Dim Reader2 As SqlDataReader = SQLReader("SELECT ISNULL(SUM(ValDebito),0) AS TolValDebito
                                                FROM [DACARTXPSQL].[dbo].[Datos detalles recibos de pago] 
                                                WHERE CodServi = '" & cboFacturas.SelectedValue & "'")

                If Reader2.HasRows Then

                    Reader2.Read()


                    txtValorTotalAbonos.Text = Reader2("TolValDebito")


                Else
                    txtValorTotalAbonos.Text = 0

                End If

                If (cn.State = ConnectionState.Open) Then cn.Close()


            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion CargarDatos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (cn.State = ConnectionState.Open) Then cn.Close()
        End Try
    End Sub
#End Region

#Region "DataGridView"

#End Region

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarUsuarioLogeado()
            CargarCombobox()
            bandera = 1
            CargarDatosFactura()
            If bandera = 1 Then
                CalcularSaldo()

            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la carga del programa pagos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = False
        Try
            If String.IsNullOrWhiteSpace(txtCuentaContablePago.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContablePago.Text) Or cboContablePagoTipoDocu.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContablePago.Text) Or String.IsNullOrWhiteSpace(txtDigiContablePago.Text) Or String.IsNullOrWhiteSpace(txtSucurContablePago.Text) Then
                    MsgBox("Has elegido una cuenta contable de pago pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentaContablePago.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If

            If String.IsNullOrWhiteSpace(txtCuentaEstampillas.Text) = False Then
                If String.IsNullOrWhiteSpace(txtCuentaEstampillas.Text) Or cboTIpoDocuEstampillas.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableEstampillas.Text) Or String.IsNullOrWhiteSpace(txtDigiContableEstampillas.Text) Or String.IsNullOrWhiteSpace(txtSucurEstampillas.Text) Then
                    MsgBox("Has elegido una cuenta contable de Interes pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentaEstampillas.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If

            If String.IsNullOrWhiteSpace(txtCuentaReteIVA.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableReteIVA.Text) Or cboTipoDocuIVA.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableReteIva.Text) Or String.IsNullOrWhiteSpace(txtDigiContableReteIva.Text) Or String.IsNullOrWhiteSpace(txtSucurIVA.Text) Then
                    MsgBox("Has elegido una cuenta contable de IVA pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentaReteIVA.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If


            If String.IsNullOrWhiteSpace(txtCuentasReteIca.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableReteICA.Text) Or cboTipoDocuICA.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableReteIca.Text) Or String.IsNullOrWhiteSpace(txtDigiContableReteIca.Text) Or String.IsNullOrWhiteSpace(txtSucurICA.Text) Then
                    MsgBox("Has elegido una cuenta contable de ICA pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentasReteIca.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If

            If String.IsNullOrWhiteSpace(txtCuentasReteFuente.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableReteFuente.Text) Or cboTipoDocuFuente.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableReteFuente.Text) Or String.IsNullOrWhiteSpace(txtDigiContableReteFuente.Text) Or String.IsNullOrWhiteSpace(txtSucurFuente.Text) Then
                    MsgBox("Has elegido una cuenta contable de Rete Fuente pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentasReteFuente.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If

            If String.IsNullOrWhiteSpace(txtCuentasPagoOpor.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableRetePagoPor.Text) Or cboTipoDocuPagoOpor.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContablePagoOpor.Text) Or String.IsNullOrWhiteSpace(txtDigiContablePagoOpor.Text) Or String.IsNullOrWhiteSpace(txtSucurPagoPor.Text) Then
                    MsgBox("Has elegido una cuenta contable de Pago Opor pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentasPagoOpor.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If




            If String.IsNullOrWhiteSpace(txtCuentaOtrosDesc.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableOtrosDesc.Text) Or cboTIpoDocuDesc.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableOtroDesc.Text) Or String.IsNullOrWhiteSpace(txtDigiContableOtrosDesc.Text) Or String.IsNullOrWhiteSpace(txtSucurOtrosDesc.Text) Then
                    MsgBox("Has elegido una cuenta contable de otros Descuentos pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentaOtrosDesc.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
            End If


            If cboBancos.SelectedIndex = -1 Then
                MsgBox("Seleccione un banco ", MsgBoxStyle.Information, "Control de datos")
                Me.cboBancos.Select()
                estado = False
                Return False
            Else
                estado = True
            End If

            If cboNumCuenta.SelectedIndex = -1 Then
                MsgBox("Seleccione una cuenta bancaria ", MsgBoxStyle.Information, "Control de datos")
                Me.cboNumCuenta.Select()
                estado = False
                Return False
            Else
                estado = True
            End If

            If cboTipoPago.SelectedIndex = -1 Then
                MsgBox("Seleccione una tipo de pago ", MsgBoxStyle.Information, "Control de datos")
                Me.cboTipoPago.Select()
                estado = False
                Return False
            Else
                estado = True
            End If

            If cboFacturas.SelectedIndex = -1 Or cboFacturas.Text = "" Then
                MsgBox("Seleccione una factura ", MsgBoxStyle.Information, "Control de datos")
                Me.cboFacturas.Select()
                estado = False
                Return False
            Else
                estado = True
            End If




            Return estado

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en las validaciones " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If (cn.State = ConnectionState.Open) Then cn.Close()
        End Try

    End Function

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try
            If CalcularSaldo() Then
                If Validaciones() Then

                    Dim Concecutivo As String = CreaConsecutivo("06", True, lblCodigoUsuario2.Text)

                    Dim PrefijoFacturas As String
                    Dim NumPago As Integer
                    Dim R As Integer

                    R = 0 'Controla si se graba o no el detalle de movimientos de cobro

                    If String.IsNullOrWhiteSpace(Concecutivo) Then

                        Exit Sub

                    Else
                        Dim prefijo As SqlDataReader

                        prefijo = SQLReader("select PrefiConse from [Datos consecutivos SIIGHOSPLUS] WHERE CodConse = 06")

                        If prefijo.HasRows = False Then
                            MsgBox("No se encontro el concecutivo")
                            Exit Sub
                        Else

                            prefijo.Read()
                            PrefijoFacturas = prefijo("PrefiConse")
                            Dim LargoPrefijo As Integer = Len(PrefijoFacturas)
                            Dim LargoNumFactura As Integer = (Len(Concecutivo) - LargoPrefijo)
                            NumPago = Concecutivo.Substring(LargoPrefijo, LargoNumFactura)
                            cn.Close()

                        End If

                        Dim fecha As Date = Date.Now

                        Dim TipoPago As String

                        Select Case cboTipoPago.Text

                            Case "Consignacion"
                                TipoPago = "CS"
                            Case "Efectivo"
                                TipoPago = "EF"
                            Case "Cheque"
                                TipoPago = "CH"
                            Case "Tarjeta de credito"
                                TipoPago = "TC"
                            Case "Letras"
                                TipoPago = "LE"
                            Case "Pagares"
                                TipoPago = "PA"
                            Case Else
                                TipoPago = "CS"

                        End Select

                        Dim EstaRegisto As Boolean
                        EstaRegisto = ModuloDeClasePagos.RegistrarPago(PrefijoFacturas, NumPago, fecha, RadioButton, "0001", txtTipoDocTer.Text, txtDocuTer.Text, txtSucursal.Text, TipoPago, cboFacturas.SelectedValue, cboBancos.Text, cboBancos.SelectedValue, cboNumCuenta.SelectedValue, FechaPago.Value, lblCodigoUsuario2.Text,
                                                         TipoDocuBan.Text, DocuBan.Text, DigiBan.Text, SucurBan.Text,
                                                         txtCuentaContablePago.Text, cboContablePagoTipoDocu.Text, txtDocuContablePago.Text, txtDigiContablePago.Text, txtSucurContablePago.Text, txtValorContablePago.Text,
                                                         txtCuentaReteIVA.Text, cboTipoDocuIVA.Text, txtDocuContableReteIva.Text, txtDigiContableReteIva.Text, txtSucurIVA.Text, txtValorContableReteIVA.Text,
                                                         txtCuentasReteIca.Text, cboTipoDocuICA.Text, txtDocuContableReteIca.Text, txtDigiContableReteIca.Text, txtSucurICA.Text, txtValorContableReteICA.Text,
                                                         txtCuentasReteFuente.Text, cboTipoDocuFuente.Text, txtDocuContableReteFuente.Text, txtDigiContableReteFuente.Text, txtSucurFuente.Text, txtValorContableReteFuente.Text,
                                                         txtCuentasPagoOpor.Text, cboTipoDocuPagoOpor.Text, txtDocuContablePagoOpor.Text, txtDigiContablePagoOpor.Text, txtSucurPagoPor.Text, txtValorContableRetePagoPor.Text,
                                                         txtCuentaEstampillas.Text, cboTIpoDocuEstampillas.Text, txtDocuContableEstampillas.Text, txtDigiContableEstampillas.Text, txtSucurEstampillas.Text, txtValorContableEstampillas.Text,
                                                         txtCuentaOtrosDesc.Text, cboTIpoDocuDesc.Text, txtDocuContableOtroDesc.Text, txtDigiContableOtrosDesc.Text, txtSucurOtrosDesc.Text, txtValorContableOtrosDesc.Text)

                        'EstaRegisto = ModuloDeClasePagos.RegistrarPago(PrefijoFacturas, NumPago, fecha, RadioButton, "0001", txtTipoDocTer.Text, txtDocuTer.Text, txtSucursal.Text, TipoPago, cboFacturas.SelectedValue, cboBancos.Text, cboBancos.SelectedValue, cboNumCuenta.SelectedValue, FechaPago.Value, lblCodigoUsuario2.Text,
                        '                                 TipoDocuBan.Text, DocuBan.Text, DigiBan.Text, SucurBan.Text,
                        '                                 txtCuentaContablePago.Text, cboContablePagoTipoDocu.Text, txtDocuContablePago.Text, txtDigiContablePago.Text, txtSucurContablePago.Text, txtValorContablePago.Text,
                        '                                 txtCuentasInteres.Text, cboTipoDocuInteres.Text, txtDocuContableIntereses.Text, txtDigiContableInteres.Text, txtSucurInteres.Text, txtValorContableInteres.Text,
                        '                                 txtCuentaReteIVA.Text, cboTipoDocuIVA.Text, txtDocuContableReteIva.Text, txtDigiContableReteIva.Text, txtSucurIVA.Text, txtValorContableReteIVA.Text,
                        '                                 txtCuentasReteIca.Text, cboTipoDocuICA.Text, txtDocuContableReteIca.Text, txtDigiContableReteIca.Text, txtSucurICA.Text, txtValorContableReteICA.Text,
                        '                                 txtCuentasReteFuente.Text, cboTipoDocuFuente.Text, txtDocuContableReteFuente.Text, txtDigiContableReteFuente.Text, txtSucurFuente.Text, txtValorContableReteFuente.Text,
                        '                                 txtCuentasPagoOpor.Text, cboTipoDocuPagoOpor.Text, txtDocuContablePagoOpor.Text, txtDigiContablePagoOpor.Text, txtSucurPagoPor.Text, txtValorContableRetePagoPor.Text,
                        '                                 txtCuentasTramite.Text, cboTipoDocuTramite.Text, txtDocuContableTramite.Text, txtDigiContableTramite.Text, txtSucurTramite.Text, txtValorContableTramite.Text,
                        '                                 txtCuentaOtrosDesc.Text, cboTIpoDocuDesc.Text, txtDocuContableOtroDesc.Text, txtDigiContableOtrosDesc.Text, txtSucurOtrosDesc.Text, txtValorContableOtrosDesc.Text)

                        If (EstaRegisto) Then

                            ModuloVariablesAplicacion.IDpago = Convert.ToString(PrefijoFacturas) + Convert.ToString(NumPago)
                            ModuloVariablesAplicacion.infNombreInforme = "ReportPagos"

                            Dim FrmlInformesPagos As New FrmlInformesPagos
                            FrmlInformesPagos.ShowDialog()

                        End If


                    End If

                End If
            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el registro del pago." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (cn.State = ConnectionState.Open) Then cn.Close()
        End Try
    End Sub

    Private Sub rbSiCuentasBancarias_CheckedChanged(sender As Object, e As EventArgs) Handles rbSiCuentasBancarias.CheckedChanged
        RadioButton = 1
    End Sub

    Private Sub rbNoCuentasBancarias_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoCuentasBancarias.CheckedChanged
        RadioButton = 2
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            Dim CUalMes As Int16
            Dim NP As String
            NP = InputBox("Por favor digite el número completo del recibo de pago")
            If String.IsNullOrWhiteSpace(NP) Then
                MsgBox("Operacion Cancelada")
            Else

                Dim SqlRecPagos As String = "SELECT * FROM [DACARTXPSQL].[dbo].[Datos recibos de pagos] " +
                                            "WHERE (PreRePa + ReciPaga) = '" & NP & "' " +
                                            "ORDER BY PreRePa, ReciPaga"

                Dim TabRecPagos As SqlDataReader = ConexionBaseDeDatos.SQLReader(SqlRecPagos)

                If (TabRecPagos.HasRows = False) Then
                    Informa = "Lo siento pero el número de recibo" & Chr(13) & Chr(10)
                    Informa += "de pago digitado, no existe en la" & Chr(13) & Chr(10)
                    Informa += "base de datos de este sistema." & Chr(13) & Chr(10)
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CUalMes = 0
                Else
                    CUalMes = 1
                End If

                cn.Close()

                If (CUalMes = 1) Then

                    ModuloVariablesAplicacion.IDpago = NP

                    Informa = "¿La copia del recibo de caja No. " & NP & Chr(13) & Chr(10)
                    Informa += "la quiere ver en detalle o un resumen contable.? " & Chr(13) & Chr(10)
                    Informa += "Sí = Muestra en detalle el comprobante " & Chr(13) & Chr(10)
                    Informa += "No = Muestra en resumen el comprobante " & Chr(13) & Chr(10)
                    Informa += "Cancel = Cancela el proceso. " & Chr(13) & Chr(10)

                    Dim Reso As Object = MsgBox(Informa, vbYesNoCancel) = vbYes


                    If Reso = True Then
                        ModuloVariablesAplicacion.IDpago = NP
                        ModuloVariablesAplicacion.infNombreInforme = "ReportPagos"

                        Dim FrmlInformesPagos As New FrmlInformesPagos
                        FrmlInformesPagos.ShowDialog()

                    Else
                        If Reso = False Then

                            ModuloVariablesAplicacion.infNombreInforme = "ReportPagos"

                            Dim FrmlInformesPagos As New FrmlInformesPagos
                            FrmlInformesPagos.ShowDialog()

                        End If
                    End If

                End If


            End If






        Catch ex As Exception
            Titulo01 = "Control para expedir copias de recibos"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al sacar una copia del recibo de pago" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboNumCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumCuenta.SelectedIndexChanged
        Try



            If (cboBancos.SelectedIndex = -1) Then
                'No gana nada
                Return
            End If

            If (cboNumCuenta.SelectedIndex = -1) Then
                'No gana nada
                Return
            End If

            TipoDocuBan.Clear()
            DocuBan.Clear()
            SucurBan.Clear()


            Dim reader As SqlDataReader = ConexionBaseDeDatos.SQLReader("SELECT TipNit, NitBanco, SucurNit, NomBanco FROM [Datos de los bancos] WHERE CodiBanco = '" & cboBancos.SelectedValue & "'")

            If reader.HasRows Then
                reader.Read()
                TipoDocuBan.Text = reader("TipNit")
                DocuBan.Text = reader("NitBanco")
                SucurBan.Text = reader("SucurNit")
                cn.Close()
            Else
                cn.Close()
            End If

        Catch ex As Exception
            Titulo01 = "Control para expedir copias de recibos"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el evento cboNumCuenta_SelectedIndexChanged" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class