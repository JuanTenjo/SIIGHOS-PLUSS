Imports System.Data.SqlClient
Public Class ModuloDeClasePagos
    Public Function RegistrarPago(PreRePa, ReciPaga, FecRePa, AfeDocu, CardiTer, TipDoc, NitCCPago, SucuPaga, TipPago, DocNum, EntidadBancaria, CodiBanco, NumCuenBancaria, FecDocu, codUser,
                                  TipoDocuBan, DocuBan, DigiBan, SucurBan,
                                  CuentaContablePago, TipoDocuContablePago, DocuContablePago, DigiVeriContablePago, SucurContablePago, ValorContablePago,
                                  CuentaContableReteIVA, TipoDocuContableReteIVA, DocuContableReteIVA, DigiVeriContableReteIVA, SucurContableReteIVA, ValorContableReteIVA,
                                  CuentaContableReteICA, TipoDocuContableReteICA, DocuContableReteICA, DigiVeriContableReteICA, SucurContableReteICA, ValorContableReteICA,
                                  CuentaContableReteFuente, TipoDocuContableReteFuente, DocuContableReteFuente, DigiVeriContableReteFuente, SucurContableReteFuente, ValorContableReteFuente,
                                  CuentaContablePagoOpor, TipoDocuContablePagoOpor, DocuContablePagoOpor, DigiVeriContablePagoOpor, SucurContablePagoOpor, ValorContablePagoOpor,
                                  CuentaContableEstampíllas, TipoDocuContableEstampillas, DocuContableEstampillas, DigiVeriContableEstampillas, SucurContableEstampillas, ValorContableEstampillas,
                                  CuentaContableOtrosDesc, TipoDocuContableOtrosDesc, DocuContableOtrosDesc, DigiVeriContableOtrosDesc, SucurContableOtrosDesc, ValorContableOtrosDesc) As Boolean


        'Public Function RegistrarPago(PreRePa, ReciPaga, FecRePa, AfeDocu, CardiTer, TipDoc, NitCCPago, SucuPaga, TipPago, DocNum, EntidadBancaria, CodiBanco, NumCuenBancaria, FecDocu, codUser,
        '                      TipoDocuBan, DocuBan, DigiBan, SucurBan,
        '                      CuentaContablePago, TipoDocuContablePago, DocuContablePago, DigiVeriContablePago, SucurContablePago, ValorContablePago,
        '                      CuentaContableInteres, TipoDocuContableInteres, DocuContableInteres, DigiVeriContableInteres, SucurContableInteres, ValorContableInteres,
        '                      CuentaContableReteIVA, TipoDocuContableReteIVA, DocuContableReteIVA, DigiVeriContableReteIVA, SucurContableReteIVA, ValorContableReteIVA,
        '                      CuentaContableReteICA, TipoDocuContableReteICA, DocuContableReteICA, DigiVeriContableReteICA, SucurContableReteICA, ValorContableReteICA,
        '                      CuentaContableReteFuente, TipoDocuContableReteFuente, DocuContableReteFuente, DigiVeriContableReteFuente, SucurContableReteFuente, ValorContableReteFuente,
        '                      CuentaContablePagoOpor, TipoDocuContablePagoOpor, DocuContablePagoOpor, DigiVeriContablePagoOpor, SucurContablePagoOpor, ValorContablePagoOpor,
        '                      CuentaContableTramite, TipoDocuContableTramite, DocuContableTramite, DigiVeriContableTramite, SucurContableTramite, ValorContableTramite,
        '                      CuentaContableOtrosDesc, TipoDocuContableOtrosDesc, DocuContableOtrosDesc, DigiVeriContableOtrosDesc, SucurContableOtrosDesc, ValorContableOtrosDesc) As Boolean
        Dim Resultado As Object
        Dim bandera As Boolean = False
        Dim SqlCuenCobrar As String


        If MsgBox("Registrara un pago a esta factura ¿Esta de acuerdo?", vbYesNo) = vbYes Then
            Try


                Dim AfavorC As Double = 0
                Dim MenosC As Double = 0
                Dim SaldoFac As Double = 0
                Dim GranInter As Double = 0
                Dim ValPagTol As Double = 0
                SqlCuenCobrar = "Select * FROM [BDADYSNET].[dbo].[Datos facturas realizadas] " +
                                "WHERE [NumFact]='" + DocNum + "'"

                Dim TabCuenCobrar As SqlDataReader = SQLReader(SqlCuenCobrar)

                If (TabCuenCobrar.HasRows = False) Then

                    Titulo01 = "Control de errores de ejecución"
                    Informa = "El número de factura " & Chr(13) & Chr(10)
                    Informa += "a la cual le desea registrar el pago, no " & Chr(13) & Chr(10)
                    Informa += "se encuentra registrada en este sistema." & Chr(13) & Chr(10)
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Else
                    TabCuenCobrar.Read()

                    AfavorC = Convert.ToDouble(TabCuenCobrar("ValNetoFac")) + Convert.ToDouble(TabCuenCobrar("ValIVAFac")) + Convert.ToDouble(TabCuenCobrar("ValNotDeFac")) 'Total de la factura
                    MenosC = Convert.ToDouble(TabCuenCobrar("ValNotCreFac")) + Convert.ToDouble(TabCuenCobrar("TolImpApli")) + Convert.ToDouble(TabCuenCobrar("TolImpApli")) + Convert.ToDouble(TabCuenCobrar("TolPagFac"))  'Total de pagos a Factura

                    SaldoFac = AfavorC - MenosC


                    TabCuenCobrar.Close()
                    cn.Close()



                    If (SaldoFac <= 0) Then
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero el saldo actual de la factura no le permite registrar ningún tipo de abono a la misma" & Chr(13) & Chr(10)
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                    If (SaldoFac < ValorContablePago) Then
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero el valor total a pagar " & Chr(13) & Chr(10)
                        Informa = "no puede ser mayor al valor total del saldo" & Chr(13) & Chr(10)
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                    ValorContableReteIVA = IIf(String.IsNullOrEmpty(ValorContableReteIVA), 0, ValorContableReteIVA)
                    ValorContableReteICA = IIf(String.IsNullOrEmpty(ValorContableReteICA), 0, ValorContableReteICA)
                    ValorContableReteFuente = IIf(String.IsNullOrEmpty(ValorContableReteFuente), 0, ValorContableReteFuente)
                    ValorContableEstampillas = IIf(String.IsNullOrEmpty(ValorContableEstampillas), 0, ValorContableEstampillas)
                    ValorContableOtrosDesc = IIf(String.IsNullOrEmpty(ValorContableOtrosDesc), 0, ValorContableOtrosDesc)
                    ValorContablePagoOpor = IIf(String.IsNullOrEmpty(ValorContablePagoOpor), 0, ValorContablePagoOpor)
                    ValorContablePago = IIf(String.IsNullOrEmpty(ValorContablePago), 0, ValorContablePago)

                    Dim DesPorFac As Double = Convert.ToDouble(ValorContableReteIVA) + Convert.ToDouble(ValorContableReteICA) + Convert.ToDouble(ValorContableReteFuente) + Convert.ToDouble(ValorContablePagoOpor) + Convert.ToDouble(ValorContableEstampillas) + Convert.ToDouble(ValorContableOtrosDesc)

                    If (SaldoFac >= (ValorContablePago + DesPorFac)) Then
                        'Deje pasar
                    Else
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero la suma del pago más" & Chr(13) & Chr(10)
                        Informa = "los descuentos no puede ser mayor a" & Chr(13) & Chr(10)
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If


                    cn.Open()
                    Dim RegistrarPagoFactura As SqlCommand
                    RegistrarPagoFactura = New SqlCommand With {
                            .Connection = cn,
                            .CommandText = "INSERT INTO [DACARTXPSQL].[dbo].[Datos recibos de pagos]
                                        (PreRePa, ReciPaga, FecRePa, AfeDocu, CardiTer, TipDoc, NitCCPago, SucuPaga, TipPago, DocNum, EntiDocu, FecDocu, CodRegis)
                                        VALUES(@PreRePa, @ReciPaga, @FecRePa, @AfeDocu, @CardiTer, @TipDoc, @NitCCPago, @SucuPaga, @TipPago, @DocNum, @EntiDocu, @FecDocu, @CodRegis)"
                        }


                    With RegistrarPagoFactura.Parameters
                        .AddWithValue("PreRePa", PreRePa)
                        .AddWithValue("ReciPaga", ReciPaga)
                        .AddWithValue("FecRePa", FecRePa)
                        .AddWithValue("AfeDocu", AfeDocu)
                        .AddWithValue("CardiTer", CardiTer)
                        .AddWithValue("TipDoc", TipDoc)
                        .AddWithValue("NitCCPago", NitCCPago)
                        .AddWithValue("SucuPaga", SucuPaga)
                        .AddWithValue("TipPago", TipPago)
                        .AddWithValue("DocNum", DocNum)
                        .AddWithValue("EntiDocu", EntidadBancaria.ToString())
                        .AddWithValue("FecDocu", FecDocu)
                        .AddWithValue("CodRegis", codUser)
                    End With

                    If RegistrarPagoFactura.ExecuteNonQuery() Then
                        bandera = True
                    End If

                    cn.Close()

                    'REGISTRO DETALLE DEL PAGO
                    Dim Nposi As Integer
                    Nposi = 0
                    If bandera = True Then


                        cn.Open()
                        Dim Consulta As String = "INSERT INTO [DACARTXPSQL].[dbo].[Datos detalles recibos de pago]
                                                ([NumItem] ,[PreRePaD] ,[ReciPagaD], [CodServi], [CuenConta], [TipDocConta] ,[NumDocConta],[DigVer] ,[SucurConta] ,[CantiPaga],[ValUnita],[DetaPago],[ValDebito],[ValCredito])
                                        VALUES (@NumItem,@PreRePaD,@ReciPagaD,@CodServi,@CuenConta,@TipDocConta,@NumDocConta, @DigVer,@SucurConta,@CantiPaga,@ValUnita,@DetaPago,@ValDebito,@ValCredito)"

                        Dim RegistrarDetallePagoFactura As SqlCommand
                        RegistrarDetallePagoFactura = New SqlCommand With {
                            .Connection = cn,
                            .CommandText = Consulta
                        }

                        If (String.IsNullOrWhiteSpace(TipoDocuBan)) Then
                            TipoDocuBan = "NIT"
                        End If

                        If (String.IsNullOrWhiteSpace(DocuBan)) Then
                            DocuBan = "00000000000"
                        End If

                        If (String.IsNullOrWhiteSpace(DigiBan)) Then
                            DigiBan = "0"
                        End If

                        If (String.IsNullOrWhiteSpace(SucurBan)) Then
                            SucurBan = "000"
                        End If


                        'Se debe registrar primero los débitos, La cuenta del banco (Valor pagado mas intereses
                        Nposi = Nposi + 1
                        If String.IsNullOrWhiteSpace(CuentaContablePago) = False Then
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", NumCuenBancaria) 'Aqui es donde tengo la incognita
                                .AddWithValue("TipDocConta", TipoDocuBan)
                                .AddWithValue("NumDocConta", DocuBan)
                                .AddWithValue("DigVer", DigiBan)
                                .AddWithValue("SucurConta", SucurBan)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", EntidadBancaria.ToString() + " Cta: " + CodiBanco.ToString())
                                .AddWithValue("ValDebito", Convert.ToDouble(ValorContablePago))
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If
                        End If

                        'Registramos cada uno de los descuentos, debitos

                        If String.IsNullOrWhiteSpace(CuentaContableReteIVA) = False Then

                            RegistrarDetallePagoFactura.Parameters.Clear()
                            Nposi = Nposi + 1
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", CuentaContableReteIVA)
                                .AddWithValue("TipDocConta", TipoDocuContableReteIVA)
                                .AddWithValue("NumDocConta", DocuContableReteIVA)
                                .AddWithValue("DigVer", DigiVeriContableReteIVA)
                                .AddWithValue("SucurConta", SucurContableReteIVA)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", "Descuento por RETE-IVA de la cuenta de cobro ")
                                .AddWithValue("ValDebito", ValorContableReteIVA)
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If
                        End If


                        If String.IsNullOrWhiteSpace(CuentaContableReteICA) = False Then
                            RegistrarDetallePagoFactura.Parameters.Clear()
                            Nposi = Nposi + 1
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", CuentaContableReteICA)
                                .AddWithValue("TipDocConta", TipoDocuContableReteICA)
                                .AddWithValue("NumDocConta", DocuContableReteICA)
                                .AddWithValue("DigVer", DigiVeriContableReteICA)
                                .AddWithValue("SucurConta", SucurContableReteICA)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", "Descuento por RETE-ICA de la cuenta de cobro ")
                                .AddWithValue("ValDebito", ValorContableReteICA)
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If
                        End If

                        If String.IsNullOrWhiteSpace(CuentaContableReteFuente) = False Then


                            RegistrarDetallePagoFactura.Parameters.Clear()
                            Nposi = Nposi + 1
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", CuentaContableReteFuente)
                                .AddWithValue("TipDocConta", TipoDocuContableReteFuente)
                                .AddWithValue("NumDocConta", DocuContableReteFuente)
                                .AddWithValue("DigVer", DigiVeriContableReteFuente)
                                .AddWithValue("SucurConta", SucurContableReteFuente)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", "Descuentos por retención en la fuente de la cuenta de cobro ")
                                .AddWithValue("ValDebito", ValorContableReteFuente)
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If
                        End If


                        If String.IsNullOrWhiteSpace(CuentaContablePagoOpor) = False Then
                            RegistrarDetallePagoFactura.Parameters.Clear()
                            Nposi = Nposi + 1
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", CuentaContablePagoOpor)
                                .AddWithValue("TipDocConta", TipoDocuContablePagoOpor)
                                .AddWithValue("NumDocConta", DocuContablePagoOpor)
                                .AddWithValue("DigVer", DigiVeriContablePagoOpor)
                                .AddWithValue("SucurConta", SucurContablePagoOpor)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", "Descuento por pago oportuno de la cuenta de cobro ")
                                .AddWithValue("ValDebito", ValorContablePagoOpor)
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If
                        End If

                        If String.IsNullOrWhiteSpace(CuentaContableEstampíllas) = False Then
                            RegistrarDetallePagoFactura.Parameters.Clear()
                            Nposi = Nposi + 1
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", CuentaContableEstampíllas)
                                .AddWithValue("TipDocConta", TipoDocuContableEstampillas)
                                .AddWithValue("NumDocConta", DocuContableEstampillas)
                                .AddWithValue("DigVer", DigiVeriContableEstampillas)
                                .AddWithValue("SucurConta", SucurContableEstampillas)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", "Pago de estampillas ")
                                .AddWithValue("ValDebito", ValorContableEstampillas)
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If
                        End If


                        If String.IsNullOrWhiteSpace(CuentaContableOtrosDesc) = False Then
                            RegistrarDetallePagoFactura.Parameters.Clear()
                            Nposi = Nposi + 1
                            With RegistrarDetallePagoFactura.Parameters
                                .AddWithValue("NumItem", Nposi)
                                .AddWithValue("PreRePaD", PreRePa)
                                .AddWithValue("ReciPagaD", ReciPaga)
                                .AddWithValue("CodServi", DocNum)
                                .AddWithValue("CuenConta", CuentaContableOtrosDesc)
                                .AddWithValue("TipDocConta", TipoDocuContableOtrosDesc)
                                .AddWithValue("NumDocConta", DocuContableOtrosDesc)
                                .AddWithValue("DigVer", DigiVeriContableOtrosDesc)
                                .AddWithValue("SucurConta", SucurContableOtrosDesc)
                                .AddWithValue("CantiPaga", 1)
                                .AddWithValue("ValUnita", 0)
                                .AddWithValue("DetaPago", "Otros descuentos de la cuenta de cobro ")
                                .AddWithValue("ValDebito", ValorContableOtrosDesc)
                                .AddWithValue("ValCredito", 0)
                            End With

                            If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                                bandera = True
                            End If

                        End If

                        'Proceda a grabar el detalle de los recibos de pagos, lo créditos, empezando por le valor a pagar


                        'If String.IsNullOrWhiteSpace(CuentaContablePago) = False Then
                        '    RegistrarDetallePagoFactura.Parameters.Clear()
                        '    Nposi = Nposi + 1
                        '    Dim Deta As String
                        '    With RegistrarDetallePagoFactura.Parameters
                        '        .AddWithValue("NumItem", Nposi)
                        '        .AddWithValue("PreRePaD", PreRePa)
                        '        .AddWithValue("ReciPagaD", ReciPaga)
                        '        .AddWithValue("CodServi", DocNum)
                        '        .AddWithValue("CuenConta", CuentaContablePago)
                        '        If ((ValorContablePago + DesPorFac) < SaldoFac) Then
                        '            Deta = "Abono a la factura"
                        '        Else
                        '            Deta = "Cancelacion de la factura"
                        '        End If
                        '        .AddWithValue("TipDocConta", TipoDocuContablePago)
                        '        .AddWithValue("NumDocConta", DocuContablePago)
                        '        .AddWithValue("DigVer", DigiVeriContablePago)
                        '        .AddWithValue("SucurConta", SucurContablePago)
                        '        .AddWithValue("CantiPaga", 1)
                        '        .AddWithValue("ValUnita", ValorContablePago)
                        '        .AddWithValue("DetaPago", Deta)
                        '        .AddWithValue("ValDebito", 0)
                        '        .AddWithValue("ValCredito", ValorContablePago + DesPorFac)
                        '    End With

                        '    If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                        '        bandera = True
                        '    End If
                        'End If

                        'Revisamos si se recibió interesese

                        'If (InterPorFac > 0) Then

                        '    If String.IsNullOrWhiteSpace(CuentaContableInteres) = False Then
                        '        RegistrarDetallePagoFactura.Parameters.Clear()
                        '        Nposi = Nposi + 1
                        '        Dim Deta As String
                        '        With RegistrarDetallePagoFactura.Parameters
                        '            .AddWithValue("NumItem", Nposi)
                        '            .AddWithValue("PreRePaD", PreRePa)
                        '            .AddWithValue("ReciPagaD", ReciPaga)
                        '            .AddWithValue("CodServi", DocNum)
                        '            .AddWithValue("CuenConta", CuentaContableInteres)
                        '            .AddWithValue("TipDocConta", TipoDocuContableInteres)
                        '            .AddWithValue("NumDocConta", DocuContableInteres)
                        '            .AddWithValue("DigVer", DigiVeriContableInteres)
                        '            .AddWithValue("SucurConta", SucurContableInteres)
                        '            .AddWithValue("CantiPaga", 1)
                        '            .AddWithValue("ValUnita", InterPorFac)
                        '            If (InterPorFac > 0) Then
                        '                Deta = "Pago de intereses corrientes de la factura "
                        '            Else
                        '                Deta = "Pago de intereses de mora de la factura  "
                        '            End If
                        '            .AddWithValue("DetaPago", Deta)
                        '            .AddWithValue("ValDebito", 0)
                        '            .AddWithValue("ValCredito", InterPorFac)
                        '        End With

                        '        If RegistrarDetallePagoFactura.ExecuteNonQuery() Then
                        '            bandera = True
                        '        End If
                        '    End If

                        'End If

                        'Cerramos la conexion 

                        If (cn.State = ConnectionState.Open) Then cn.Close()

                        Dim ValFacEnti As Double = 0

                        Dim ValdesFac As Double = 0

                        Dim SaldofacEnti As Double = 0

                        Dim PagFacNet As Double = 0

                        Dim PagoActualFacturea As Double = 0

                        SqlCuenCobrar = "Select * FROM [BDADYSNET].[dbo].[Datos facturas realizadas] " +
                                        "WHERE [NumFact]='" + DocNum + "'"

                        Dim TabFacturas As SqlDataReader = SQLReader(SqlCuenCobrar)

                        If (TabFacturas.HasRows) Then

                            TabFacturas.Read()

                            ValFacEnti = (Convert.ToDouble(TabFacturas("ValNetoFac")) + Convert.ToDouble(TabFacturas("ValNotDeFac"))) + Convert.ToDouble(TabFacturas("ValIVAFac"))

                            ValdesFac = Convert.ToDouble(TabFacturas("TolPagFac")) + Convert.ToDouble(TabFacturas("ValNotCreFac")) + Convert.ToDouble(TabFacturas("ValDesFac"))

                            PagoActualFacturea = Convert.ToDouble(TabFacturas("TolPagFac"))

                            ValPagTol = ValorContablePago

                            SaldofacEnti = ValFacEnti - ValdesFac

                            If (SaldofacEnti > 0) Then
                                'Haga el pago a la factura
                                If (ValPagTol < SaldofacEnti) Then
                                    PagFacNet = ValPagTol
                                Else
                                    PagFacNet = SaldofacEnti
                                End If
                            End If

                            cn.Close()
                        Else
                            Titulo01 = "Control de errores de ejecución"
                            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                            Informa += "No se encontro la factura" & Chr(13) & Chr(10)
                            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cn.Close()
                            Return False
                        End If


                        TabFacturas.Close()

                        Dim ActFacturra As Boolean = ConexionBaseDeDatos.SQLUpdate("UPDATE [BDADYSNET].[dbo].[Datos facturas realizadas] SET [TolPagFac] = '" & PagoActualFacturea + PagFacNet & "' WHERE  [NumFact]='" + DocNum + "' ")


                    End If
                End If

                Return bandera

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "al registrar el pago" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                If (cn.State = ConnectionState.Open) Then cn.Close()
            End Try

        End If

    End Function





End Class
