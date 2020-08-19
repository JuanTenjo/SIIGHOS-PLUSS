Imports System.Data.SqlClient
Public Class ModuloDeClasesRemision
    Public Function ModuloRemision(NumRemi, ID_Contratos, FecAperRemi, HorAperRemi, RemiActiva, CuotNum, FecCieRemi, CodRegis, FecRegis, CodModi, FecModi, DataGridDetalleRemision) As Boolean
        Dim estadoRegistro As Boolean = False
        Dim estadoActualizar As Boolean = False
        Call conectarGeogebra()
        Dim Resultado As Int16
        Dim BanderaRegisrarDetalle As Int16 = 0
        Dim BanderaActualizarDetalle As Int16 = 0
        Try
            cn.Open()
            Dim VerificarExisRemi As SqlCommand
            VerificarExisRemi = New SqlCommand With {
                .Connection = cn,
                .CommandText = "select Count(NumRemi) from [Datos remisiones de facturas] where NumRemi = @NumRemi"
            }
            VerificarExisRemi.Parameters.AddWithValue("@NumRemi", NumRemi)
            Resultado = VerificarExisRemi.ExecuteScalar()
            cn.Close()
            estadoRegistro = True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la consulta verifiacion de existencia de remision" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cn.Close()
        End Try  'Evalua si hay o no hay registros con este numero de remision

        If Resultado > 0 Then
            If MsgBox("Se Actualizara esta remision. ¿Estas de acuerdo?", vbYesNo) = vbYes Then

                Try
                    cn.Open()
                    Dim ActuRemi As SqlCommand
                    ActuRemi = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "UPDATE [Datos remisiones de facturas] SET  FecAperRemi = @FecAperRemi, HorAperRemi = @HorAperRemi, RemiActiva = @RemiActiva,
                                        FecCieRemi = @FecCieRemi, CodModi = @CodModi, FecModi = @FecModi  
                                        Where NumRemi = @NumRemi and ID_Contratos = @ID_Contratos and CuotNum = @CuotNum"
                    }
                    With ActuRemi.Parameters
                        .AddWithValue("NumRemi", NumRemi)
                        .AddWithValue("ID_Contratos", ID_Contratos)
                        .AddWithValue("FecAperRemi", FecAperRemi)
                        .AddWithValue("HorAperRemi", HorAperRemi)
                        .AddWithValue("RemiActiva", RemiActiva)
                        .AddWithValue("CuotNum", CuotNum)
                        .AddWithValue("FecCieRemi", FecCieRemi)
                        .AddWithValue("CodModi", CodModi)
                        .AddWithValue("FecModi", FecModi)
                    End With

                    If ActuRemi.ExecuteNonQuery() Then
                        estadoActualizar = True
                        BanderaRegisrarDetalle = 1
                    End If

                Catch ex As Exception
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += "en la consulta actualizacion de Remision" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BanderaRegisrarDetalle = 0
                    estadoActualizar = False
                    Return estadoActualizar
                Finally
                    cn.Close()
                End Try  'Actualiza datos basicos remision

                Try
                    cn.Open()
                    Dim EliDetalleRemi As SqlCommand
                    EliDetalleRemi = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "DELETE FROM [Datos detalle de remisiones] where NumRemi = '" & NumRemi.ToString & "'"
                    }
                    If EliDetalleRemi.ExecuteNonQuery() Then
                        estadoActualizar = True
                        BanderaRegisrarDetalle = 1
                    End If
                Catch ex As Exception
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += "en la consulta actualizacion de Remision" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BanderaRegisrarDetalle = 0
                    estadoActualizar = False
                    Return estadoActualizar
                Finally
                    cn.Close()
                End Try  'Elimina datos detalle de remision

                If BanderaRegisrarDetalle = 1 Then
                    Try
                        cn.Open()
                        Dim RegistoDetalleRemi As SqlCommand
                        RegistoDetalleRemi = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO [Datos detalle de remisiones] (ItemNum,NumRemi,CodProSer,Concepto,CantDeta,ValUniDeta,ValIVADeta,CodRegis,FecRegis)
                                    VALUES(@ItemNum, @NumRemi, @CodProSer, @Concepto, @CantDeta, @ValUniDeta, @ValIVADeta, @CodModi, @FecModi)"
                    }
                        Dim Fila As DataGridViewRow = New DataGridViewRow()
                        For Each Fila In DataGridDetalleRemision.Rows
                            RegistoDetalleRemi.Parameters.Clear()
                            With RegistoDetalleRemi.Parameters
                                .AddWithValue("ItemNum", Convert.ToInt16(Fila.Cells("Item").Value))
                                .AddWithValue("NumRemi", NumRemi)
                                .AddWithValue("CodProSer", Convert.ToString(Fila.Cells("CodigoP").Value))
                                .AddWithValue("Concepto", Convert.ToString(Fila.Cells("Concepto").Value))
                                .AddWithValue("CantDeta", Convert.ToDouble(Fila.Cells("Cantidad").Value))
                                .AddWithValue("ValUniDeta", Convert.ToDouble(Fila.Cells("ValorUni").Value))
                                .AddWithValue("ValIVADeta", Convert.ToDouble(Fila.Cells("ValorUniIVA").Value))
                                .AddWithValue("CodModi", CodModi)
                                .AddWithValue("FecModi", FecModi)
                            End With
                            RegistoDetalleRemi.ExecuteNonQuery()
                        Next
                        BanderaRegisrarDetalle = 1
                        estadoActualizar = True
                    Catch ex As Exception
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                        Informa += "en el registro de Remision" & Chr(13) & Chr(10)
                        Informa += "Mensaje del error: " & ex.Message
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BanderaRegisrarDetalle = 0
                        estadoActualizar = False
                        Return estadoActualizar
                    Finally
                        cn.Close()
                    End Try
                End If  'REGISTRA DETALLES DE REMISION

                If estadoActualizar Then
                    MsgBox("Actualizacion completada")
                End If

            End If  'Actualiza  Remision
        Else
            If MsgBox("Registrar nueva remisión", vbYesNo) = vbYes Then

                Try
                    cn.Open()
                    Dim RegistoRemi As SqlCommand
                    RegistoRemi = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO [Datos remisiones de facturas] (NumRemi, ID_Contratos, FecAperRemi, HorAperRemi, RemiActiva, CuotNum, FecCieRemi, CodRegis, FecRegis)
                                    VALUES(@NumRemi, @ID_Contratos, @FecAperRemi, @HorAperRemi, @RemiActiva, @CuotNum, @FecCieRemi, @CodRegis, @FecRegis)"
                    }
                    With RegistoRemi.Parameters
                        .AddWithValue("NumRemi", NumRemi)
                        .AddWithValue("ID_Contratos", ID_Contratos)
                        .AddWithValue("FecAperRemi", FecAperRemi)
                        .AddWithValue("HorAperRemi", HorAperRemi)
                        .AddWithValue("RemiActiva", Convert.ToInt16(RemiActiva))
                        .AddWithValue("CuotNum", CuotNum)
                        .AddWithValue("FecCieRemi", FecCieRemi)
                        .AddWithValue("CodRegis", CodRegis)
                        .AddWithValue("FecRegis", FecRegis)
                    End With

                    If RegistoRemi.ExecuteNonQuery() Then
                        estadoRegistro = True
                        BanderaRegisrarDetalle = 1
                    End If

                Catch ex As Exception
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += "en el registro de Remision" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    estadoRegistro = False
                    Return estadoRegistro
                Finally
                    cn.Close()
                End Try

                If BanderaRegisrarDetalle = 1 Then 'REGISTRA DETALLES DE REMISION
                    Try
                        cn.Open()
                        Dim RegistoDetalleRemi As SqlCommand
                        RegistoDetalleRemi = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO [Datos detalle de remisiones] (ItemNum,NumRemi,CodProSer,Concepto,CantDeta,ValUniDeta,ValIVADeta,CodRegis,FecRegis)
                                    VALUES(@ItemNum, @NumRemi, @CodProSer, @Concepto, @CantDeta, @ValUniDeta, @ValIVADeta, @CodRegis, @FecRegis)"
                    }
                        Dim Fila As DataGridViewRow = New DataGridViewRow()
                        For Each Fila In DataGridDetalleRemision.Rows
                            RegistoDetalleRemi.Parameters.Clear()
                            With RegistoDetalleRemi.Parameters
                                .AddWithValue("ItemNum", Convert.ToInt16(Fila.Cells("Item").Value))
                                .AddWithValue("NumRemi", NumRemi)
                                .AddWithValue("CodProSer", Convert.ToString(Fila.Cells("CodigoP").Value))
                                .AddWithValue("Concepto", Convert.ToString(Fila.Cells("Concepto").Value))
                                .AddWithValue("CantDeta", Convert.ToDouble(Fila.Cells("Cantidad").Value))
                                .AddWithValue("ValUniDeta", Convert.ToDouble(Fila.Cells("ValorUni").Value))
                                .AddWithValue("ValIVADeta", Convert.ToDouble(Fila.Cells("ValorUniIVA").Value))
                                .AddWithValue("CodRegis", CodRegis)
                                .AddWithValue("FecRegis", FecRegis)
                            End With
                            RegistoDetalleRemi.ExecuteNonQuery()
                        Next
                        estadoRegistro = True
                    Catch ex As Exception
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                        Informa += "en el registro de Remision" & Chr(13) & Chr(10)
                        Informa += "Mensaje del error: " & ex.Message
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)

                        estadoRegistro = False
                        Return estadoRegistro
                    Finally
                        cn.Close()
                    End Try
                End If
                If estadoRegistro = True Then
                    MsgBox("Registro Existoso")
                    Return estadoRegistro
                Else
                    MsgBox("Fallo en el registro")
                End If
            End If 'Registra Remision
        End If
        Return True
    End Function


    Public Function EliminarRemision(NumRemisiom, NumeroDeCuota, IDContrato) As Boolean
        Dim BanderaEliminarRemi As Boolean = False
        Try
            cn.Open()
            Dim EliDetalleRemi As SqlCommand
            EliDetalleRemi = New SqlCommand With {
                .Connection = cn,
                .CommandText = "DELETE FROM [Datos detalle de remisiones] where NumRemi = '" & NumRemisiom.ToString & "'"
            }
            If EliDetalleRemi.ExecuteNonQuery() Then
                BanderaEliminarRemi = True
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en eliminacion de Datos detalle de remisiones" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BanderaEliminarRemi = False
            Return BanderaEliminarRemi
        Finally
            cn.Close()
        End Try  'Elimina datos detalle de remision

        If BanderaEliminarRemi = True Then
            Try
                cn.Open()
                Dim EliminarRemi As SqlCommand
                EliminarRemi = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "DELETE FROM [Datos remisiones de facturas] where NumRemi = '" & NumRemisiom.ToString & "' and ID_Contratos ='" & IDContrato.ToString & "' and CuotNum = '" & NumeroDeCuota.ToString & "' "
                }
                If EliminarRemi.ExecuteNonQuery() Then
                    BanderaEliminarRemi = True
                End If
            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en eliminacion de Datos de remisiones" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                BanderaEliminarRemi = False
                Return BanderaEliminarRemi
            Finally
                cn.Close()
            End Try  'Elimina datos detalle de remision
        End If

        If BanderaEliminarRemi = True Then
            MsgBox("Eliminacion Exitosa")
        End If
        Return BanderaEliminarRemi
    End Function

    Public Function FacturarRemision(PrefiFact, NumFact, NumRemi, FecExpFac, FecVenFac, TipDocTer, NumDocTer, SucDocTer, ValNetoFac, ValDesFac, ValIVAFac, ValNotDeFac, ValNotCreFac,
                                      TolImpApli, TolPagFac, FecUltiPag, TextResol, CodRegis, FecRegis, ID_Contrato, CuotaNoPac) As Boolean
        Dim FacturarRemiestado As Boolean = False
        Try
            cn.Open()
            Dim FacturarRemi As SqlCommand
            FacturarRemi = New SqlCommand With {
                .Connection = cn,
                .CommandText = "INSERT  INTO [Datos facturas realizadas] (PrefiFact, NumFact, NumRemi, FecExpFac, FecVenFac, TipDocTer, NumDocTer, SucDocTer, ValNetoFac, ValDesFac, ValIVAFac, ValNotDeFac, ValNotCreFac,
                                      TolImpApli, TolPagFac, FecUltiPag, TextResol, CodRegis, FecRegis) VALUES (@PrefiFact, @NumFact, @NumRemi, @FecExpFac, @FecVenFac, @TipDocTer, @NumDocTer, @SucDocTer, @ValNetoFac, @ValDesFac, @ValIVAFac, @ValNotDeFac, @ValNotCreFac,
                                      @TolImpApli, @TolPagFac, @FecUltiPag, @TextResol, @CodRegis, @FecRegis)"
            }

            With FacturarRemi.Parameters
                .AddWithValue("PrefiFact", PrefiFact)
                .AddWithValue("NumFact", NumFact)
                .AddWithValue("NumRemi", NumRemi)
                .AddWithValue("FecExpFac", FecExpFac)
                .AddWithValue("FecVenFac", FecVenFac)
                .AddWithValue("TipDocTer", TipDocTer)
                .AddWithValue("NumDocTer", NumDocTer)
                .AddWithValue("SucDocTer", SucDocTer)
                .AddWithValue("ValNetoFac", Convert.ToDouble(ValNetoFac))
                .AddWithValue("ValDesFac", Convert.ToDouble(ValDesFac))
                .AddWithValue("ValIVAFac", Convert.ToDouble(ValIVAFac))
                .AddWithValue("ValNotDeFac", Convert.ToDouble(ValNotDeFac))
                .AddWithValue("ValNotCreFac", Convert.ToDouble(ValNotCreFac))
                .AddWithValue("TolImpApli", Convert.ToDouble(TolImpApli))
                .AddWithValue("TolPagFac", Convert.ToDouble(TolPagFac))
                .AddWithValue("FecUltiPag", FecUltiPag)
                .AddWithValue("TextResol", TextResol)
                .AddWithValue("CodRegis", CodRegis)
                .AddWithValue("FecRegis", FecRegis)

            End With
            If FacturarRemi.ExecuteNonQuery() Then
                FacturarRemiestado = True
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en eliminacion de Datos detalle de remisiones" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            FacturarRemiestado = False
            Return FacturarRemiestado
        Finally
            cn.Close()
        End Try  'Elimina datos detalle de remision



        If FacturarRemiestado Then
            Try
                cn.Open()
                Dim ActualizaFacturaRealizada As SqlCommand
                ActualizaFacturaRealizada = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = ("UPDATE [Datos detalles de cuotas contratos]
                                        SET FacturCuota = 1 WHERE ID_Contratos = '" & ID_Contrato.ToString & "'
                                        and CuotaNoPac = " & CuotaNoPac & "")
                }
                If ActualizaFacturaRealizada.ExecuteNonQuery() Then
                    FacturarRemiestado = True
                End If


            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en eliminacion de Datos detalle de remisiones" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                FacturarRemiestado = False
                Return FacturarRemiestado
            Finally
                cn.Close()
            End Try
        End If

        If FacturarRemiestado Then
            MsgBox("La factura de realizo exitosamente", MsgBoxStyle.Information, "Facturar")
            Return FacturarRemiestado
        Else
            MsgBox("Error al realizar factura")
        End If
        Return FacturarRemiestado
    End Function

End Class
