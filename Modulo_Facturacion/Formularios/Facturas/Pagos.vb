Imports System.Data.SqlClient
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

    Private Sub txtCuentasInteres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentasInteres.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentasInteres.Clear()
                    txtCuentasInteres.Text = ModuloVariablesAplicacion.CuentasContables

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

    Private Sub txtCuentasTramite_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentasTramite.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.F5

                    CuentasContables.ShowDialog()
                    txtCuentasTramite.Clear()
                    txtCuentasTramite.Text = ModuloVariablesAplicacion.CuentasContables

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

    Private Sub txtValorSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtValorSaldo.TextChanged
        txtValorContablePago.Text = txtValorSaldo.Text
    End Sub
    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click

        Me.Dispose()
    End Sub

#End Region

#Region "Funciones"

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
            cboNumCuenta.DisplayMember = "NumCuenta"
            cboNumCuenta.ValueMember = "NumCuenta"
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

            'FALTA EL CAMPO INTERES

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

        If bandera = 1 Then
            Dim reader As SqlDataReader = SQLReader("SELECT df.TipDocTer, df.NumDocTer, dp.DigVeri, dp.SucurProv, dp.RazonSol, df.NumRemi, df.ValNetoFac, df.ValIVAFac, 
                                        df.FecExpFac, df.FecVenFac, df.FecUltiPag, df.TolImpApli, df.ValDesFac, df.ValNotDeFac,
                                        df.ValNotCreFac, df.TolPagFac,  (df.ValNetoFac + df.ValIVAFac) as TotalFactura
                                        FROM [Datos facturas realizadas] as df, [GEOGRAXPSQL].[dbo].[Datos proveedores] as dp
                                        WHERE df.NumDocTer = dp.IdenProve AND   df.NumFact = '" & cboFacturas.SelectedValue & "'")
            If reader.HasRows Then
                reader.Read()
                txtValorTotal.Text = reader("TotalFactura")
                txtValorCreditos.Text = reader("ValNotCreFac")
                txtValorGlosado.Text = 0
                txtValorDebitos.Text = reader("ValNotDeFac")
                txtValorImpuestos.Text = reader("TolImpApli")
                txtValorDescuentos.Text = reader("ValDesFac")
                txtValorInteres.Text = 0
                txtValorTotalAbonos.Text = 0
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

            cn.Close()


        End If

        If bandera = 1 Then



        End If

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

            If String.IsNullOrWhiteSpace(txtCuentasInteres.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableInteres.Text) Or cboTipoDocuInteres.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableIntereses.Text) Or String.IsNullOrWhiteSpace(txtDigiContableInteres.Text) Or String.IsNullOrWhiteSpace(txtSucurInteres.Text) Then
                    MsgBox("Has elegido una cuenta contable de Interes pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentasInteres.Select()
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


            If String.IsNullOrWhiteSpace(txtCuentasTramite.Text) = False Then
                If String.IsNullOrWhiteSpace(txtValorContableTramite.Text) Or cboTipoDocuTramite.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtDocuContableTramite.Text) Or String.IsNullOrWhiteSpace(txtDigiContableTramite.Text) Or String.IsNullOrWhiteSpace(txtSucurTramite.Text) Then
                    MsgBox("Has elegido una cuenta contable de Tramite pero no rellenaste alguno de los otros campos requeridos para este pago.")
                    txtCuentasTramite.Select()
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






                        ModuloDeClasePagos.RegistrarPago(PrefijoFacturas, NumPago, fecha, RadioButton, "0001", txtTipoDocTer.Text, txtDocuTer.Text, txtSucursal.Text, TipoPago, cboFacturas.SelectedValue, cboBancos.Text, cboBancos.SelectedValue, cboNumCuenta.SelectedValue, FechaPago.Value, lblCodigoUsuario2.Text,
                                                         TipoDocuBan.Text, DocuBan.Text, DigiBan.Text, SucurBan.Text,
                                                         txtCuentaContablePago.Text, cboContablePagoTipoDocu.Text, txtDocuContablePago.Text, txtDigiContablePago.Text, txtSucurContablePago.Text, txtValorContablePago.Text,
                                                         txtCuentasInteres.Text, cboTipoDocuInteres.Text, txtDocuContableIntereses.Text, txtDigiContableInteres.Text, txtSucurInteres.Text, txtValorContableInteres.Text,
                                                         txtCuentaReteIVA.Text, cboTipoDocuIVA.Text, txtDocuContableReteIva.Text, txtDigiContableReteIva.Text, txtSucurIVA.Text, txtValorContableReteIVA.Text,
                                                         txtCuentasReteIca.Text, cboTipoDocuICA.Text, txtDocuContableReteIca.Text, txtDigiContableReteIca.Text, txtSucurICA.Text, txtValorContableReteICA.Text,
                                                         txtCuentasReteFuente.Text, cboTipoDocuFuente.Text, txtDocuContableReteFuente.Text, txtDigiContableReteFuente.Text, txtSucurFuente.Text, txtValorContableReteFuente.Text,
                                                         txtCuentasPagoOpor.Text, cboTipoDocuPagoOpor.Text, txtDocuContablePagoOpor.Text, txtDigiContablePagoOpor.Text, txtSucurPagoPor.Text, txtCuentasPagoOpor.Text,
                                                         txtCuentasTramite.Text, cboTipoDocuTramite.Text, txtDocuContableTramite.Text, txtDigiContableTramite.Text, txtSucurTramite.Text, txtValorContableTramite.Text,
                                                         txtCuentaOtrosDesc.Text, cboTIpoDocuDesc.Text, txtDocuContableOtroDesc.Text, txtDigiContableOtrosDesc.Text, txtSucurOtrosDesc.Text, txtValorContableOtrosDesc.Text)



                    End If
                    End If
                End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el registro del pago." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbSiCuentasBancarias_CheckedChanged(sender As Object, e As EventArgs) Handles rbSiCuentasBancarias.CheckedChanged
        RadioButton = 1
    End Sub

    Private Sub rbNoCuentasBancarias_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoCuentasBancarias.CheckedChanged
        RadioButton = 2
    End Sub
End Class