Imports System.Data.SqlClient
Public Class ModuloDeClasesRemision
    Public Function ModuloRemision(NumRemi, ID_Contratos, FecAperRemi, HorAperRemi, RemiActiva, CuotNum, ObserGene, FecCieRemi, CodRegis, FecRegis, CodModi, FecModi, DataGridDetalleRemision) As Boolean
        Dim estadoRegistro As Boolean = False
        Dim estadoActualizar As Boolean = False
        'Call conectarGeogebra()
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
            Try
                cn.Open()
                Dim ActuRemi As SqlCommand
                ActuRemi = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "UPDATE [Datos remisiones de facturas] SET  FecAperRemi = @FecAperRemi, HorAperRemi = @HorAperRemi, RemiActiva = @RemiActiva, ObserGene = @ObserGene,
                                        FecCieRemi = @FecCieRemi, CodModi = @CodModi, FecModi = @FecModi  
                                        Where NumRemi = @NumRemi and ID_Contratos = @ID_Contratos and CuotNum = @CuotNum"
                }
                With ActuRemi.Parameters
                    .AddWithValue("NumRemi", NumRemi)
                    .AddWithValue("ID_Contratos", ID_Contratos)
                    .AddWithValue("FecAperRemi", Convert.ToDateTime(FecAperRemi))
                    .AddWithValue("HorAperRemi", HorAperRemi)
                    .AddWithValue("RemiActiva", RemiActiva)
                    .AddWithValue("CuotNum", CuotNum)
                    .AddWithValue("ObserGene", ObserGene)
                    .AddWithValue("FecCieRemi", Convert.ToDateTime(FecCieRemi))
                    .AddWithValue("CodModi", CodModi)
                    .AddWithValue("FecModi", Convert.ToDateTime(FecModi))
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
                            .AddWithValue("FecModi", Convert.ToDateTime(FecModi))
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

        Else
            Try
                cn.Open()
                Dim RegistoRemi As SqlCommand
                RegistoRemi = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO [Datos remisiones de facturas] (NumRemi, ID_Contratos, FecAperRemi, HorAperRemi, RemiActiva, CuotNum, ObserGene, FecCieRemi, CodRegis, FecRegis, CodModi)
                                    VALUES(@NumRemi, @ID_Contratos, @FecAperRemi, @HorAperRemi, @RemiActiva, @CuotNum, @ObserGene, @FecCieRemi, @CodRegis, @FecRegis, @CodModi)"
                    }
                With RegistoRemi.Parameters
                    .AddWithValue("NumRemi", NumRemi)
                    .AddWithValue("ID_Contratos", ID_Contratos)
                    .AddWithValue("FecAperRemi", Convert.ToDateTime(FecAperRemi))
                    .AddWithValue("HorAperRemi", HorAperRemi)
                    .AddWithValue("RemiActiva", Convert.ToInt16(RemiActiva))
                    .AddWithValue("CuotNum", CuotNum)
                    .AddWithValue("ObserGene", ObserGene)
                    .AddWithValue("FecCieRemi", Convert.ToDateTime(FecCieRemi))
                    .AddWithValue("CodRegis", CodRegis)
                    .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))
                    .AddWithValue("CodModi", CodRegis)
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
                            .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))
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
        End If
        Return True
    End Function


    Public Function AnularRemision(IDRemision, User, RazonAnul) As Boolean

        Dim BanderaEliminarRemi As Boolean = False

        Try

            cn.Open()

            Dim data As String = "UPDATE [BDADYSNET].[dbo].[Datos remisiones de facturas] SET [RemiAnula] = 1, [RazAnulRemi] = '" & RazonAnul.ToString & "', [CodAnul] ='" & User.ToString & "' WHERE [NumRemi] = '" & IDRemision.ToString & "'"

            Dim AnularRemi As SqlCommand
            AnularRemi = New SqlCommand With {
                .Connection = cn,
                .CommandText = data
            }
            If AnularRemi.ExecuteNonQuery() Then
                BanderaEliminarRemi = True
            End If

            Return BanderaEliminarRemi

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en anulacion de la remision" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BanderaEliminarRemi = False
            Return BanderaEliminarRemi
        Finally
            cn.Close()
        End Try  'Anula remision

    End Function

    Public Function FacturarRemision(PrefiFact, NumFact, NumRemi, FecExpFac, FecVenFac, TipDocTer, NumDocTer, SucDocTer, ValNetoFac, ValDesFac, ValIVAFac, ValNotDeFac, ValNotCreFac,
                                      TolImpApli, TolPagFac, FecUltiPag, TextResol, ObserGene, CodRegis, FecRegis, ID_Contrato, CuotaNoPac) As Boolean
        Dim FacturarRemiestado As Boolean = False
        Try
            cn.Open()
            Dim FacturarRemi As SqlCommand
            FacturarRemi = New SqlCommand With {
                .Connection = cn,
                .CommandText = "INSERT  INTO [Datos facturas realizadas] (PrefiFact, NumFact, NumRemi, FecExpFac, FecVenFac, TipDocTer, NumDocTer, SucDocTer, ValNetoFac, ValDesFac, ValIVAFac, ValNotDeFac, ValNotCreFac,
                                      TolImpApli, TolPagFac, FecUltiPag, TextResol, ObserGene, CodRegis, FecRegis) VALUES (@PrefiFact, @NumFact, @NumRemi, @FecExpFac, @FecVenFac, @TipDocTer, @NumDocTer, @SucDocTer, @ValNetoFac, @ValDesFac, @ValIVAFac, @ValNotDeFac, @ValNotCreFac,
                                      @TolImpApli, @TolPagFac, @FecUltiPag, @TextResol, @ObserGene, @CodRegis, @FecRegis)"
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
                .AddWithValue("FecUltiPag", Convert.ToDateTime(FecUltiPag))
                .AddWithValue("TextResol", TextResol)
                .AddWithValue("ObserGene", ObserGene)
                .AddWithValue("CodRegis", CodRegis)
                .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))

            End With
            If FacturarRemi.ExecuteNonQuery() Then
                FacturarRemiestado = True
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el registro de la factura " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            FacturarRemiestado = False
            Return FacturarRemiestado
        Finally
            cn.Close()
        End Try  'Registra la factura



        If FacturarRemiestado Then
            ActualizarEstadoDeLaCuota(ID_Contrato, CuotaNoPac)
        End If

        If FacturarRemiestado Then
            Return FacturarRemiestado
        Else
            MsgBox("Error al registrar la factura en el sistema")
        End If

        Return FacturarRemiestado
    End Function

    Public Function ActualizarEstadoDeLaCuota(ID_Contrato, CuotaNoPac)
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
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al actualizar el estado de pago de la cuota del contrato" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cn.Close()
        End Try
    End Function

    Public Function ActualizarEstadoFactura(PrefiFac, NumFac, NumRemi) As Boolean
        Try
            cn.Open()
            Dim ActualizaEstadoFactura As SqlCommand
            ActualizaEstadoFactura = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = ("UPDATE [BDADYSNET].[dbo].[Datos facturas realizadas]
                                        SET [CodEstaDian] = 01 WHERE [PrefiFact] = '" & PrefiFac.ToString & "'
                                        and [NumFact] = '" & NumFac.ToString & "' and [NumRemi] = '" & NumRemi.ToString & "' ")
                }

            If ActualizaEstadoFactura.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al actualizar el estado de la factura" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cn.Close()
        End Try
    End Function

End Class
