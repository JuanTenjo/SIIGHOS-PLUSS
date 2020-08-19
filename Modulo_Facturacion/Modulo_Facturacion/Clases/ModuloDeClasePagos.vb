Imports System.Data.SqlClient
Public Class ModuloDeClasePagos
    Public Function RegistrarPago(Numero_factura,
                                  CodigoContablePago, Detalle, ValorDebito, ValorCredito,
                                  fecha_Movimiento, Anulada, Fec_Anulada, Cod_Regis, Fec_Regis,
                                  Cod_Modi, Fec_Modi, ValDesFac, TolImpApli, TolPagFac, FecUltiPag, NumRemi) As Boolean
        Dim Resultado As Object
        Dim bandera As Boolean = False
        Try
            Call conectarGeogebra()
            cn.Open()
            Dim ComprobarPago As SqlCommand
            ComprobarPago = New SqlCommand With {  'ESTAS ACTIALIZANDO LA TABLA FACURA REALIZADAS
                .Connection = cn,
                .CommandText = "select Count(ddp.Numero_factura) from [Datos detalle de pagos] as ddp where ddp.Numero_factura = @Numero_factura and ddp.Anulada = 0"
            }
            ComprobarPago.Parameters.AddWithValue("@Numero_factura", Numero_factura)
            Resultado = ComprobarPago.ExecuteScalar()
            cn.Close()
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de si existe el pago" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If Resultado = 0 Then
            If MsgBox("Registrara el pago de esta factura ¿Esta de acuerdo?", vbYesNo) = vbYes Then
                Try
                    cn.Open()
                    Dim RegistrarPagoFactura As SqlCommand
                    RegistrarPagoFactura = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO [Datos detalle de pagos](Numero_factura, CodigoContablePago, Detalle, ValorDebito, ValorCredito, fecha_Movimiento, Cod_Regis, Fec_Regis)
                                                                         VALUES(@Numero_factura, @CodigoContablePago, @Detalle, @ValorDebito, @ValorCredito, @fecha_Movimiento, @Cod_Regis, @Fec_Regis)"
                    }
                    With RegistrarPagoFactura.Parameters
                        .AddWithValue("Numero_factura", Numero_factura)
                        .AddWithValue("CodigoContablePago", CodigoContablePago)
                        .AddWithValue("Detalle", Detalle)
                        .AddWithValue("ValorDebito", Convert.ToDouble(ValorDebito))
                        .AddWithValue("ValorCredito", Convert.ToDouble(ValorCredito))
                        .AddWithValue("fecha_Movimiento", fecha_Movimiento)
                        .AddWithValue("Cod_Regis", Cod_Regis)
                        .AddWithValue("Fec_Regis", Fec_Regis)
                    End With

                    If RegistrarPagoFactura.ExecuteNonQuery() Then
                        bandera = True
                    End If
                Catch ex As Exception
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += "al registrar el pago" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    bandera = False
                    Return bandera
                End Try

                If bandera = True Then
                    Try
                        cn.Open()
                        Dim RegistrarPagoFactura As SqlCommand
                        RegistrarPagoFactura = New SqlCommand With {
                            .Connection = cn,
                            .CommandText = "UPDATE [Datos facturas realizadas] 
                                            SET ValDesFac = @ValDesFac, ValNotDeFac = @ValNotDeFac, ValNotCreFac = @ValNotCreFac, TolImpApli = @TolImpApli, TolPagFac = @TolPagFac, FecUltiPag = @FecUltiPag 
                                            WHERE NumFact = @NumFact AND NumRemi = @NumRemi"
                        }
                        With RegistrarPagoFactura.Parameters
                            .AddWithValue("ValDesFac", ValDesFac)
                            .AddWithValue("ValNotDeFac", ValorDebito)
                            .AddWithValue("ValNotCreFac", ValorCredito)
                            .AddWithValue("TolImpApli", TolImpApli)
                            .AddWithValue("TolPagFac", TolPagFac)
                            .AddWithValue("FecUltiPag", FecUltiPag)
                            .AddWithValue("NumFact", Numero_factura)
                            .AddWithValue("NumRemi", NumRemi)
                        End With

                        If RegistrarPagoFactura.ExecuteNonQuery() Then
                            bandera = True
                        End If
                    Catch ex As Exception
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                        Informa += "al registrar el pago" & Chr(13) & Chr(10)
                        Informa += "Mensaje del error: " & ex.Message
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        bandera = False
                        Return bandera
                    End Try
                End If


            End If

        Else
            If MsgBox("Modificara el pago de esta factura ¿Esta de acuerdo?", vbYesNo) = vbYes Then

            End If

        End If



    End Function

End Class
