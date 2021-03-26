Imports System.Data.SqlClient
Public Class ModuloDeClaseNotasCreditoDebito




    Public Function NotaCredito(PrefiNotCre, NumNoCre, PrefiFacCre, DocuCredito, DocuCreditoDos, TipoNota, ConcepCre, CodCorre, ValNoCre, ValCopaNC, CodRegis, DetalleNotaDebito) As Boolean
        Dim estadoRegistro As Boolean
        Dim Resultado As Object

        Try
            'Call conectarGeogebra()
            cn.Open()
            Dim ComprobarPago As SqlCommand
            ComprobarPago = New SqlCommand With {
                .Connection = cn,
                .CommandText = "select Count(DocuCredito) from [Datos notas creditos facturas] where DocuCredito = @Numero_factura and AnulCredi = 0"
            }
            ComprobarPago.Parameters.AddWithValue("@Numero_factura", DocuCredito)
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

                cn.Open()

                Dim RegistoNotaCredito As SqlCommand
                RegistoNotaCredito = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "INSERT INTO [BDADYSNET].[dbo].[Datos notas creditos facturas] (PrefiNotCre, NumNoCre, PrefiFacCre, DocuCredito, DocuCreditoDos, TipoNota, ConcepCre, CodCorre, ValNoCre, ValCopaNC, CodRegis)
                                    VALUES(@PrefiNotCre, @NumNoCre, @PrefiFacCre, @DocuCredito, @DocuCreditoDos, @TipoNota, @ConcepCre, @CodCorre, @ValNoCre, @ValCopaNC, @CodRegis)"
               }
                With RegistoNotaCredito.Parameters
                    .AddWithValue("PrefiNotCre", PrefiNotCre)
                    .AddWithValue("NumNoCre", NumNoCre)
                    .AddWithValue("PrefiFacCre", PrefiFacCre)
                    .AddWithValue("DocuCredito", DocuCredito)
                    .AddWithValue("DocuCreditoDos", DocuCreditoDos)
                    .AddWithValue("TipoNota", TipoNota)
                    .AddWithValue("ConcepCre", ConcepCre)
                    .AddWithValue("CodCorre", CodCorre)
                    .AddWithValue("ValNoCre", Convert.ToDouble(ValNoCre))
                    .AddWithValue("ValCopaNC", Convert.ToDouble(ValCopaNC))
                    .AddWithValue("CodRegis", CodRegis)
                End With

                If RegistoNotaCredito.ExecuteNonQuery() Then
                    estadoRegistro = True
                Else
                    estadoRegistro = False
                End If

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en el registro de la nota credito" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                estadoRegistro = False
            Finally
                cn.Close()
            End Try

            If estadoRegistro = True Then
                Try
                    cn.Open()
                    Dim RegistoDetalleNotaCredi As SqlCommand
                    RegistoDetalleNotaCredi = New SqlCommand With {
                .Connection = cn,
                .CommandText = "INSERT INTO [BDADYSNET].[dbo].[Datos detalle notas creditos] (PrefiNotCreD,NumNoCreD,CodSerNoCre,CodFacNoCre,CantiServi,ValUnitaSer,ValIvaFac,CodRegis)
                                VALUES(@PrefiNotCreD,@NumNoCreD,@CodSerNoCre,@CodFacNoCre,@CantiServi,@ValUnitaSer,@ValIvaFac,@CodRegis)"
            }
                    Dim Fila As DataGridViewRow = New DataGridViewRow()
                    For Each Fila In DetalleNotaDebito.Rows
                        RegistoDetalleNotaCredi.Parameters.Clear()
                        With RegistoDetalleNotaCredi.Parameters
                            .AddWithValue("PrefiNotCreD", PrefiNotCre)
                            .AddWithValue("NumNoCreD", NumNoCre)
                            .AddWithValue("CodSerNoCre", Convert.ToString(Fila.Cells("CodProduc").Value))
                            .AddWithValue("CodFacNoCre", "0")
                            .AddWithValue("CantiServi", Convert.ToDouble(Fila.Cells("Cantidad").Value))
                            .AddWithValue("ValUnitaSer", Convert.ToDouble(Fila.Cells("ValUnitario").Value))
                            .AddWithValue("ValIvaFac", Convert.ToDouble(Fila.Cells("ValIVADeta").Value))
                            .AddWithValue("CodRegis", CodRegis)
                        End With
                        If RegistoDetalleNotaCredi.ExecuteNonQuery() Then
                            estadoRegistro = True
                        Else
                            estadoRegistro = False
                        End If
                    Next

                Catch ex As Exception
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += "en el registro del detalle de la nota credito" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    estadoRegistro = False
                Finally
                    cn.Close()
                End Try
            End If


            If estadoRegistro = True Then
                estadoRegistro = ActualizarFacturaCreditoFuncion(ValNoCre, DocuCredito)
            End If

        Else
            MsgBox("Ya existe una nota credito a esta factura")
            estadoRegistro = False
        End If

        Return estadoRegistro

    End Function


    Public Function ActualizarFacturaCreditoFuncion(ValNotCreFac, NumFact) As Boolean
        Dim bandera As Boolean
        Try
            'Call conectarGeogebra()
            cn.Open()
            Dim ActualizarFactura As SqlCommand
            ActualizarFactura = New SqlCommand With {
                .Connection = cn,
                .CommandText = "UPDATE [Datos facturas realizadas] 
                                            SET ValNotCreFac = @ValNotCreFac
                                            WHERE NumFact = @NumFact"
            }
            With ActualizarFactura.Parameters
                .AddWithValue("NumFact", NumFact)
                .AddWithValue("ValNotCreFac", Convert.ToDouble(ValNotCreFac))
            End With

            If ActualizarFactura.ExecuteNonQuery() Then
                bandera = True
            Else
                bandera = False
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al actualizar el campo de valor Credito de la factura" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            bandera = False
        Finally
            cn.Close()
        End Try


        Return bandera
    End Function

    Public Function ActualizarFacturaDebitoFuncion(ValNotDeFac, NumFact) As Boolean
        Dim bandera As Boolean
        Try
            Dim ActualizarFactura As SqlCommand
            ActualizarFactura = New SqlCommand With {
                .Connection = cn,
                .CommandText = "UPDATE [Datos facturas realizadas] 
                                            SET ValNotDeFac = @ValNotDeFac
                                            WHERE NumFact = @NumFact"
            }
            With ActualizarFactura.Parameters
                .AddWithValue("NumFact", NumFact)
                .AddWithValue("ValNotDeFac", Convert.ToDouble(ValNotDeFac))
            End With

            If ActualizarFactura.ExecuteNonQuery() Then
                bandera = True
            Else
                bandera = False
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al actualizar el campo de valor debito de la factura" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            bandera = False
        Finally
            cn.Close()
        End Try


        Return bandera
    End Function


    Public Function AnularNotaCredito(NumNotaCredito, CodRegis) As Boolean
        Dim bandera As Boolean
        Try
            'Call conectarGeogebra()
            cn.Open()
            Dim AnularDetalleFactura As SqlCommand
            AnularDetalleFactura = New SqlCommand With {
                .Connection = cn,
                .CommandText = "UPDATE [Datos notas creditos facturas] SET AnulCredi = 1, CodAnul = '" & CodRegis & "' WHERE NumNoCre = '" & NumNotaCredito & "'   "
            }

            If AnularDetalleFactura.ExecuteNonQuery() Then
                bandera = True
                MsgBox("Anulacion Exitosa")
            Else
                bandera = False
            End If

            Return bandera

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al anular  nota credito" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            bandera = False
        Finally
            cn.Close()
        End Try

    End Function

    'Public Function AnularNotaFactura(NumFac) As Boolean
    '    Dim bandera As Boolean
    '    Try
    '        'Call conectarGeogebra()
    '        cn.Open()
    '        Dim AnularDetalleFactura As SqlCommand
    '        AnularDetalleFactura = New SqlCommand With {
    '            .Connection = cn,
    '            .CommandText = "UPDATE [Datos notas creditos facturas] SET AnulCredi = 1, CodAnul = '" & CodRegis & "' WHERE NumNoCre = '" & NumNotaCredito & "'   "
    '        }

    '        If AnularDetalleFactura.ExecuteNonQuery() Then
    '            bandera = True
    '            MsgBox("Anulacion Exitosa")
    '        Else
    '            bandera = False
    '        End If

    '        Return bandera

    '    Catch ex As Exception
    '        Titulo01 = "Control de errores de ejecución"
    '        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
    '        Informa += "al anular  nota credito" & Chr(13) & Chr(10)
    '        Informa += "Mensaje del error: " & ex.Message
    '        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        bandera = False
    '    Finally
    '        cn.Close()
    '    End Try

    'End Function




    Public Function NotaDebito(PrefiNotDeb, NumNoDe, PrefiFacDeb, DocuDebito, DocuDebitoDos, TipoNota, ConceDebi, CodCorre, ValNoDebi, CodRegis, detallenotadebito) As Boolean

        Dim estadoRegistro As Boolean
        Dim Resultado As Object


        'Call conectarGeogebra()
        cn.Open()
        Dim ComprobarPago As SqlCommand
        ComprobarPago = New SqlCommand With {
                .Connection = cn,
                .CommandText = "select Count(DocuDebito) from[BDADYSNET].[dbo].[Datos notas debitos facturas] where DocuDebito = @Numero_factura and AnulDebi = 0"
            }
        ComprobarPago.Parameters.AddWithValue("@Numero_factura", DocuDebito)
        Resultado = ComprobarPago.ExecuteScalar()
        cn.Close()

        If Resultado = 0 Then
            Try
                'Call conectarGeogebra()
                cn.Open()

                Dim RegistoNotaCredito As SqlCommand
                RegistoNotaCredito = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "INSERT INTO [BDADYSNET].[dbo].[Datos notas debitos facturas] (PrefiNotDeb, NumNoDe, PrefiFacDeb, DocuDebito, DocuDebitoDos, TipoNota, ConceDebi, CodCorre, ValNoDebi, CodRegis)
                                    VALUES(@PrefiNotDeb, @NumNoDe, @PrefiFacDeb, @DocuDebito, @DocuDebitoDos, @TipoNota, @ConceDebi, @CodCorre, @ValNoDebi, @CodRegis)"
               }
                With RegistoNotaCredito.Parameters
                    .AddWithValue("PrefiNotDeb", PrefiNotDeb)
                    .AddWithValue("NumNoDe", NumNoDe)
                    .AddWithValue("PrefiFacDeb", PrefiFacDeb)
                    .AddWithValue("DocuDebito", DocuDebito)
                    .AddWithValue("DocuDebitoDos", DocuDebitoDos)
                    .AddWithValue("TipoNota", TipoNota)
                    .AddWithValue("ConceDebi", ConceDebi)
                    .AddWithValue("CodCorre", CodCorre)
                    .AddWithValue("ValNoDebi", Convert.ToDouble(ValNoDebi))
                    .AddWithValue("CodRegis", CodRegis)
                End With

                If RegistoNotaCredito.ExecuteNonQuery() Then
                    estadoRegistro = True
                Else
                    estadoRegistro = False
                End If


                If estadoRegistro = True Then
                    Dim RegistoDetalleNotaCredito As SqlCommand
                    RegistoDetalleNotaCredito = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO  [BDADYSNET].[dbo].[Datos detalle notas debitos] (PrefiNotDebD,NumNoDebD,CodSerNoDeb,CodFacNoDeb,CodCenCos,CantiServi,SubValUnita,ValUnitaSer,ValIvaFac,CodRegis)
                                    VALUES(@PrefiNotDebD,@NumNoDebD,@CodSerNoDeb,@CodFacNoDeb,@CodCenCos,@CantiServi,@SubValUnita,@ValUnitaSer,@ValIvaFac,@CodRegis)"
                   }


                    Dim Fila As DataGridViewRow = New DataGridViewRow()
                    For Each Fila In detallenotadebito.Rows
                        RegistoDetalleNotaCredito.Parameters.Clear()
                        With RegistoDetalleNotaCredito.Parameters
                            .AddWithValue("PrefiNotDebD", PrefiNotDeb)
                            .AddWithValue("NumNoDebD", NumNoDe)
                            .AddWithValue("CodSerNoDeb", Convert.ToString(Fila.Cells("CodProduc").Value))
                            .AddWithValue("CodFacNoDeb", DocuDebito)
                            .AddWithValue("CodCenCos", "0")
                            .AddWithValue("CantiServi", Convert.ToDouble(Fila.Cells("Cantidad").Value))
                            .AddWithValue("SubValUnita", Convert.ToDouble(Fila.Cells("ValUnitario").Value))
                            .AddWithValue("ValUnitaSer", Convert.ToDouble(Fila.Cells("ValUnitario").Value))
                            .AddWithValue("ValIvaFac", Convert.ToDouble(Fila.Cells("ValIVADeta").Value))
                            .AddWithValue("CodRegis", CodRegis)
                        End With

                        If RegistoDetalleNotaCredito.ExecuteNonQuery() Then
                            estadoRegistro = True
                        Else
                            estadoRegistro = False
                        End If
                    Next

                    If estadoRegistro Then
                        estadoRegistro = ActualizarFacturaDebitoFuncion(ValNoDebi, DocuDebito)
                    End If

                End If

                Return estadoRegistro

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en el registro de la nota credito" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return estadoRegistro = False
            Finally
                cn.Close()
            End Try



        Else
            MsgBox("No puede")
            Return False
        End If

    End Function


End Class
