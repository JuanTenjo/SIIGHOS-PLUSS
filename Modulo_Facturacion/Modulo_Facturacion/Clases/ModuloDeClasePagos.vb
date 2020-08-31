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
            ComprobarPago = New SqlCommand With {
                .Connection = cn,
                .CommandText = "select Count(ddp.Numero_factura) from [Datos detalle de pagos] as ddp where ddp.Numero_factura = @Numero_factura and ddp.Anulada = 0"
            }
            ComprobarPago.Parameters.AddWithValue("@Numero_factura", Numero_factura)
            Resultado = ComprobarPago.ExecuteScalar()

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de si existe el pago" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cn.Close()
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
                Finally
                    cn.Close()
                End Try

                If bandera = True Then
                    bandera = ActualizarFacturaFuncion(ValDesFac, ValorDebito, ValorCredito, TolImpApli, TolPagFac, FecUltiPag, Numero_factura, NumRemi)
                End If

                If bandera = True Then
                    MsgBox("El pago se realizo correctamente", MsgBoxStyle.Information, "Control de registro")
                    Return bandera
                End If

            End If
        Else
            If MsgBox("Modificara el pago de esta factura ¿Esta de acuerdo?", vbYesNo) = vbYes Then
                Try
                    cn.Open()
                    Dim ActualizarPago As SqlCommand
                    ActualizarPago = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "UPDATE [Datos detalle de pagos] SET  CodigoContablePago = @CodigoContablePago, Detalle = @Detalle, ValorDebito = @ValorDebito, ValorCredito = @ValorCredito,
                                                fecha_Movimiento = @fecha_Movimiento, Cod_Modi = @Cod_Modi, Fec_Modi = @Fec_Modi WHERE Numero_factura = @Numero_factura "
                    }
                    With ActualizarPago.Parameters
                        .AddWithValue("CodigoContablePago", CodigoContablePago)
                        .AddWithValue("Detalle", Detalle)
                        .AddWithValue("ValorDebito", ValorDebito)
                        .AddWithValue("ValorCredito", ValorCredito)
                        .AddWithValue("fecha_Movimiento", fecha_Movimiento)
                        .AddWithValue("Cod_Modi", Cod_Modi)
                        .AddWithValue("Fec_Modi", Fec_Modi)
                        .AddWithValue("Numero_factura", Numero_factura)
                    End With
                    If ActualizarPago.ExecuteNonQuery() Then
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
                Finally
                    cn.Close()
                End Try

                If bandera Then
                    bandera = ActualizarFacturaFuncion(ValDesFac, ValorDebito, ValorCredito, TolImpApli, TolPagFac, FecUltiPag, Numero_factura, NumRemi)
                End If

                If bandera Then
                    MsgBox("Actualizacion completada", MsgBoxStyle.Information, "Control Actualizar")
                End If

            End If

        End If
        Return bandera
    End Function

    Public Function AnularPago(NumFactura, remision) As Boolean
        Try
            cn.Open()
            Dim AnulacionrPago As SqlCommand
            AnulacionrPago = New SqlCommand With {
                .Connection = cn,
                .CommandText = "UPDATE [Datos detalle de pagos] SET anulada = 1 WHERE  Numero_factura = '" & NumFactura & "'  "
            }
            If AnulacionrPago.ExecuteNonQuery Then
                MsgBox("Anulacion exitosa")
                Return True
            End If
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al anular pago" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cn.Close()
        End Try

    End Function


    Public Function ActualizarFacturaFuncion(ValDesFac, ValorDebito, ValorCredito, TolImpApli, TolPagFac, FecUltiPag, Numero_factura, NumRemi) As Boolean
        Dim bandera As Boolean = False
        Try
            cn.Open()
            Dim ActualizarFactura As SqlCommand
            ActualizarFactura = New SqlCommand With {
                .Connection = cn,
                .CommandText = "UPDATE [Datos facturas realizadas] 
                                            SET ValDesFac = @ValDesFac, ValNotDeFac = @ValNotDeFac, ValNotCreFac = @ValNotCreFac, TolImpApli = @TolImpApli, TolPagFac = @TolPagFac, FecUltiPag = @FecUltiPag 
                                            WHERE NumFact = @NumFact AND NumRemi = @NumRemi"
            }
            With ActualizarFactura.Parameters
                .AddWithValue("ValDesFac", ValDesFac)
                .AddWithValue("ValNotDeFac", Convert.ToDouble(ValorDebito))
                .AddWithValue("ValNotCreFac", Convert.ToDouble(ValorCredito))
                .AddWithValue("TolImpApli", TolImpApli)
                .AddWithValue("TolPagFac", TolPagFac)
                .AddWithValue("FecUltiPag", FecUltiPag)
                .AddWithValue("NumFact", Numero_factura)
                .AddWithValue("NumRemi", NumRemi)
            End With

            If ActualizarFactura.ExecuteNonQuery() Then
                bandera = True
                Return bandera
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al actualizar el pago" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            bandera = False
            Return bandera
        Finally
            cn.Close()
        End Try
        Return bandera
    End Function

End Class
