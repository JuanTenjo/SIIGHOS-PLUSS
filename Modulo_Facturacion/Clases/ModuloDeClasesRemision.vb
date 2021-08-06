Imports System.Data.SqlClient
Imports System.Globalization

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

    Public Function RegistraCuentaConta(PrefiFact, NumFact, TipDocTer, NumDocTer, SucDocTer, FecDoc, CodRegis, FecRegis) As Boolean

        Dim RegistraCuenConta As Boolean = False

        Try

            'Consulta para traerme el digito de verificacion del prooovedor

            Dim DigVeri As String = ""
            Dim CuenNumProve As String = ""
            Dim TipoEntidad As String = ""
            Dim IdTipoCuenta As Int16 = 0
            Dim NumFacFormado As String = NumFact.ToString()

            NumFacFormado = NumFacFormado.PadLeft(15, "0") 'Agregue cuantos ceros falten a la izquierda para completar el tamaño



            Dim ci As CultureInfo = New CultureInfo("es-ES")

            Dim fecha As DateTime = Convert.ToDateTime(FecDoc)

            Dim mes As String = fecha.ToString("MM")
            Dim año As String = fecha.ToString("yyyy")


            Dim TraerDigiVeri = "SELECT Prove.DigVeri, Prove.IdenProve, Prove.CuenNum as IdTipoCuenta, TipoCuen.CuenNum
                                FROM GEOGRAXPSQL.dbo.[Datos proveedores] AS Prove INNER JOIN
                                [BDADYSNET].[dbo].[Datos tipo cuenta contable] AS TipoCuen ON Prove.CuenNum = TipoCuen.idTipoCuenta WHERE Prove.TipoDocu = '" & TipDocTer & "' AND Prove.IdenProve = '" & NumDocTer & "'"


            Dim readerDigiVeri As SqlDataReader = ConexionBaseDeDatos.SQLReader(TraerDigiVeri)

            If readerDigiVeri.HasRows Then

                readerDigiVeri.Read()

                DigVeri = readerDigiVeri("DigVeri").ToString()
                CuenNumProve = readerDigiVeri("CuenNum").ToString()
                IdTipoCuenta = Convert.ToInt16(readerDigiVeri("IdTipoCuenta").ToString())

                If IdTipoCuenta = 1 Then
                    TipoEntidad = "Entidad Publica"
                Else
                    TipoEntidad = "Entidad Privada"
                End If

            End If

            cn.Close()


            'Consulkta para traer eel total de base y el total de iva

            Dim TolBASE As Double = 0
            Dim TolIVA As Double = 0
            Dim TotalFactur As Double = 0

            Dim TrArTotales = "SELECT [BDADYSNET].[dbo].[Datos facturas realizadas].ValIVAFac, [BDADYSNET].[dbo].[Datos facturas realizadas].ValNetoFac
                            FROM [BDADYSNET].[dbo].[Datos facturas realizadas] WHERE NumFact = '" & NumFact & "'"



            Dim readerTraerTotales As SqlDataReader = ConexionBaseDeDatos.SQLReader(TrArTotales)

            If readerTraerTotales.HasRows Then

                readerTraerTotales.Read()

                TolBASE = Convert.ToDouble(readerTraerTotales("ValNetoFac").ToString())
                TolIVA = Convert.ToDouble(readerTraerTotales("ValIVAFac").ToString())

                TotalFactur = (TolBASE + TolIVA)

            End If

            cn.Close()



            'Consulta para traerme el detalle de la factura


            Dim consulta As String = "SELECT [Datos detalle de remisiones].ItemNum, [Datos detalle de remisiones].NumRemi, [Datos detalle de remisiones].CodProSer, [Datos detalle de remisiones].Concepto, [Datos detalle de remisiones].CantDeta, 
                                    [Datos detalle de remisiones].ValUniDeta, [Datos detalle de remisiones].ValIVADeta, [Datos detalle de remisiones].CodRegis, [Datos detalle de remisiones].FecRegis, [Datos detalle de remisiones].CodModi, 
                                    [Datos detalle de remisiones].FecModi, [Datos facturas realizadas].NumFact, [Datos facturas realizadas].PrefiFact, [Datos clasificacion producservicios].CuenNum
                                    FROM [Datos facturas realizadas] INNER JOIN
                                    [Datos remisiones de facturas] ON [Datos facturas realizadas].NumRemi = [Datos remisiones de facturas].NumRemi INNER JOIN
                                    [Datos detalle de remisiones] ON [Datos remisiones de facturas].NumRemi = [Datos detalle de remisiones].NumRemi INNER JOIN
                                    [Datos catalogo de producservicios] ON [Datos detalle de remisiones].CodProSer = [Datos catalogo de producservicios].CodProSer INNER JOIN
                                    [Datos clasificacion producservicios] ON [Datos catalogo de producservicios].ClasiProSer = [Datos clasificacion producservicios].CodClasPS where NumFact = '" & NumFact & "'"


            Dim reader As SqlDataReader = ConexionBaseDeDatos.SQLReader(consulta)


            Dim InsertCuenta As String = "INSERT  INTO [BDADYSNET].[dbo].[Datos contabilizacion factura] ([PrefiFact],[NumFact],[TipDocTer],[NumDocTer],[DigVeri],[SucDocTer],[CuenNum],[Natura],[DescriMovi],[BaseMovi],[ValMovi],[FecDoc],[MesPerCon],[AnoPerCon],[CodRegis],[FecRegis]) 
                                                VALUES (@PrefiFact, @NumFact, @TipDocTer, @NumDocTer, @DigVeri, @SucDocTer,@CuenNum, @Natura, @DescriMovi, @BaseMovi, @ValMovi, @FecDoc, @MesPerCon, @AnoPerCon, @CodRegis, @FecRegis)"


            If reader.HasRows Then
                '-------------------------------------------------------------------- Registra detallde factura ----------------------------------------------------------------------------------------------------------

                cn2.Open()

                While reader.Read()



                    Dim RegistrarCuenConta As SqlCommand
                    RegistrarCuenConta = New SqlCommand With {
                        .Connection = cn2,
                        .CommandText = InsertCuenta
                    }

                    With RegistrarCuenConta.Parameters

                        .AddWithValue("PrefiFact", PrefiFact)
                        .AddWithValue("NumFact", NumFact)
                        .AddWithValue("TipDocTer", TipDocTer)
                        .AddWithValue("NumDocTer", NumDocTer)
                        .AddWithValue("DigVeri", DigVeri)
                        .AddWithValue("SucDocTer", SucDocTer)
                        .AddWithValue("CuenNum", reader("CuenNum"))
                        .AddWithValue("Natura", "C")
                        .AddWithValue("DescriMovi", reader("Concepto"))
                        .AddWithValue("BaseMovi", 0)
                        .AddWithValue("ValMovi", Convert.ToDouble(reader("ValUniDeta")))
                        .AddWithValue("FecDoc", Convert.ToDateTime(FecDoc))
                        .AddWithValue("MesPerCon", mes)
                        .AddWithValue("AnoPerCon", año)
                        .AddWithValue("CodRegis", CodRegis)
                        .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))

                    End With

                    If RegistrarCuenConta.ExecuteNonQuery() Then
                        RegistraCuenConta = True
                    End If

                End While

                cn2.Close()


            Else
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero no se encontro detalle de la factura, por lo tanto no se puedo registrar la cuenta contable" & Chr(13) & Chr(10)
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                RegistraCuenConta = False
                Return RegistraCuenConta
            End If

            cn.Close()

            '-------------------------------------------------------------------- Finn Registra detallde factura ----------------------------------------------------------------------------------------------------------

            '-------------------------------------------------------------------- Registra Iva detalle factura ----------------------------------------------------------------------------------------------------------


            If RegistraCuenConta Then

                cn.Open()

                Dim RegistrarCuenContaIVA As SqlCommand

                RegistrarCuenContaIVA = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = InsertCuenta
                }

                With RegistrarCuenContaIVA.Parameters

                    .AddWithValue("PrefiFact", PrefiFact)
                    .AddWithValue("NumFact", NumFact)
                    .AddWithValue("TipDocTer", TipDocTer)
                    .AddWithValue("NumDocTer", NumDocTer)
                    .AddWithValue("DigVeri", DigVeri)
                    .AddWithValue("SucDocTer", SucDocTer)
                    .AddWithValue("CuenNum", "24080502")
                    .AddWithValue("Natura", "C")
                    .AddWithValue("DescriMovi", "IVA")
                    .AddWithValue("BaseMovi", Convert.ToDouble(TolBASE))
                    .AddWithValue("ValMovi", Convert.ToDouble(TolIVA))
                    .AddWithValue("FecDoc", Convert.ToDateTime(FecDoc))
                    .AddWithValue("MesPerCon", mes)
                    .AddWithValue("AnoPerCon", año)
                    .AddWithValue("CodRegis", CodRegis)
                    .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))

                End With

                If RegistrarCuenContaIVA.ExecuteNonQuery() Then
                    RegistraCuenConta = True
                End If

                cn.Close()

            End If

            '------------------------------------------------------------------- Fin Registra Iva detalle factura ----------------------------------------------------------------------------------------------------------

            '------------------------------------------------------------------- Registro Entidad Publica ----------------------------------------------------------------------------------------------------------


            If RegistraCuenConta Then

                cn.Open()

                Dim RegistrarEntidad As SqlCommand

                RegistrarEntidad = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = InsertCuenta
                }

                With RegistrarEntidad.Parameters

                    .AddWithValue("PrefiFact", PrefiFact)
                    .AddWithValue("NumFact", NumFact)
                    .AddWithValue("TipDocTer", TipDocTer)
                    .AddWithValue("NumDocTer", NumDocTer)
                    .AddWithValue("DigVeri", DigVeri)
                    .AddWithValue("SucDocTer", SucDocTer)
                    .AddWithValue("CuenNum", CuenNumProve)
                    .AddWithValue("Natura", "D")
                    .AddWithValue("DescriMovi", TipoEntidad)
                    .AddWithValue("BaseMovi", 0)
                    .AddWithValue("ValMovi", Convert.ToDouble(TotalFactur))
                    .AddWithValue("FecDoc", Convert.ToDateTime(FecDoc))
                    .AddWithValue("MesPerCon", mes)
                    .AddWithValue("AnoPerCon", año)
                    .AddWithValue("CodRegis", CodRegis)
                    .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))

                End With

                If RegistrarEntidad.ExecuteNonQuery() Then
                    RegistraCuenConta = True
                End If

                cn.Close()

            End If

            '------------------------------------------------------------------- Fin Entidad Publica ----------------------------------------------------------------------------------------------------------


            '------------------------------------------------------------------- Registra Contabilidad ----------------------------------------------------------------------------------------------------------

            If RegistraCuenConta Then


                'ANTES DE HACER ESTO SE DEBE VALIDAR QUE EL PERIODO EXISTA Y EL TERCERO, SI NO EXITE Y SALE ERROR, SE DEBE CREAR UN NUEVO FORMULARIO DONDE PUEDA ENVIAR LA INFORMACION DE LA TABLA DE CONTABILIDAD A CONTABILIDAD GENERAL. SE DEBE CREAR UN FORMULARIO. PARA QUE CUANDO PASE ALGUN ERROR SE PUEDE VOVLER A ENVIAR LA FACTURA

                Dim ConsultaDatosContabilidad As String = "Select * From [BDADYSNET].[dbo].[Datos contabilizacion factura] Where NumFact = '" & NumFact & "'"


                Dim DatosContabilidad As SqlDataReader = ConexionBaseDeDatos.SQLReader(ConsultaDatosContabilidad)


                If DatosContabilidad.HasRows Then

                    Dim InserContabilidad As String = "INSERT INTO [ADYSNET].[dbo].[CMDMOVIMIENTO] 
                    (
                    [CMDAnoMovimiento],
                    [CMDPeriodoMovimiento],
                    [CMDComprobanteMovimiento],
                    [CMDPrefijoMovimiento],
                    [CMDDocumentoMovimiento],
                    [CMDFechaMovimiento],
                    [CMDItemMovimiento],
                    [CMDCodigoCuentaMovimiento],
                    [CMDCodCentroCostosMovimiento],
                    [CMDCodigoMonedaMovimiento],
                    [CMDIdentificadorUnoMovimiento],
                    [CMDSucursalMovimiento],
                    [CMDIdentificadorDosMovimiento],
                    [CMDPrefijoRefmovimiento],
                    [CMDDocumentoRefMovimiento],
                    [CMDComentariosMovimiento],
                    [CMDValorMovimiento],
                    [CMDValorBaseMovimiento],
                    [CMDValorMonedaMovimiento],
                    [CMDNaturalezaMovimiento],
                    [CMDOrigenMovimiento],
                    [CMDTipoAsientoMovimiento]
                    )
                    VALUES 
                    (
                    @CMDAnoMovimiento,
                    @CMDPeriodoMovimiento,
                    @CMDComprobanteMovimiento,
                    @CMDPrefijoMovimiento,
                    @CMDDocumentoMovimiento,
                    @CMDFechaMovimiento,
                    @CMDItemMovimiento,
                    @CMDCodigoCuentaMovimiento,
                    @CMDCodCentroCostosMovimiento,
                    @CMDCodigoMonedaMovimiento,
                    @CMDIdentificadorUnoMovimiento,
                    @CMDSucursalMovimiento,
                    @CMDIdentificadorDosMovimiento,
                    @CMDPrefijoRefmovimiento,
                    @CMDDocumentoRefMovimiento,
                    @CMDComentariosMovimiento,
                    @CMDValorMovimiento,
                    @CMDValorBaseMovimiento,
                    @CMDValorMonedaMovimiento,
                    @CMDNaturalezaMovimiento,
                    @CMDOrigenMovimiento,
                    @CMDTipoAsientoMovimiento
                    )
                    "
                    Dim ItemMovimiento As Int32 = 0
                    Dim ItemMovimientoFormado As String = ""
                    Dim ItemProveDos As String = ""
                    Dim CMDNaturalezaMovimiento As String = ""

                    cn2.Open()

                    While DatosContabilidad.Read()

                        ItemMovimiento += 1

                        ItemMovimientoFormado = ItemMovimiento.ToString()

                        ItemMovimientoFormado = ItemMovimientoFormado.PadLeft(5, "0")

                        If DatosContabilidad("Natura").ToString() = "C" Then
                            CMDNaturalezaMovimiento = "CNO"
                        ElseIf DatosContabilidad("Natura").ToString() = "D" Then
                            CMDNaturalezaMovimiento = "DNO"
                        Else
                            CMDNaturalezaMovimiento = "CNO"
                        End If


                        ItemProveDos = DatosContabilidad("NumDocTer").ToString() + "-" + DatosContabilidad("DigVeri").ToString()





                        Dim RegistrarContabilidad As SqlCommand

                        RegistrarContabilidad = New SqlCommand With {
                        .Connection = cn2,
                        .CommandText = InserContabilidad
                    }

                        With RegistrarContabilidad.Parameters


                            .AddWithValue("CMDAnoMovimiento", DatosContabilidad("AnoPerCon").ToString())
                            .AddWithValue("CMDPeriodoMovimiento", DatosContabilidad("MesPerCon").ToString())
                            .AddWithValue("CMDComprobanteMovimiento", "00001")
                            .AddWithValue("CMDPrefijoMovimiento", DatosContabilidad("PrefiFact").ToString())
                            .AddWithValue("CMDDocumentoMovimiento", NumFacFormado)
                            .AddWithValue("CMDFechaMovimiento", Convert.ToDateTime(DatosContabilidad("FecDoc")))
                            .AddWithValue("CMDItemMovimiento", ItemMovimientoFormado)
                            .AddWithValue("CMDCodigoCuentaMovimiento", DatosContabilidad("CuenNum"))
                            .AddWithValue("CMDCodCentroCostosMovimiento", "000")
                            .AddWithValue("CMDCodigoMonedaMovimiento", "000")
                            .AddWithValue("CMDIdentificadorUnoMovimiento", DatosContabilidad("NumDocTer"))
                            .AddWithValue("CMDSucursalMovimiento", DatosContabilidad("SucDocTer"))
                            .AddWithValue("CMDIdentificadorDosMovimiento", ItemProveDos)
                            .AddWithValue("CMDPrefijoRefmovimiento", "00000")
                            .AddWithValue("CMDDocumentoRefMovimiento", NumFacFormado)
                            .AddWithValue("CMDComentariosMovimiento", DatosContabilidad("DescriMovi").ToString())
                            .AddWithValue("CMDValorMovimiento", Convert.ToDouble(DatosContabilidad("ValMovi")))
                            .AddWithValue("CMDValorBaseMovimiento", Convert.ToDouble(DatosContabilidad("BaseMovi")))
                            .AddWithValue("CMDValorMonedaMovimiento", 0)
                            .AddWithValue("CMDNaturalezaMovimiento", CMDNaturalezaMovimiento)
                            .AddWithValue("CMDOrigenMovimiento", "DIG")
                            '.AddWithValue("CMDConsecutivoCruceExtractoMovimiento", "0")
                            '.AddWithValue("CMDAnoCruceExtractoMovimiento", DatosContabilidad(""))
                            '.AddWithValue("CMDPeriodoCruceExtractoMovimiento", DatosContabilidad(""))
                            .AddWithValue("CMDTipoAsientoMovimiento", "F")
                            '.AddWithValue("CMDValorOtraMonedaMovimiento", DatosContabilidad(""))

                        End With

                        If RegistrarContabilidad.ExecuteNonQuery() Then
                            RegistraCuenConta = True
                        End If

                    End While

                    cn2.Close()


                End If


                Return RegistraCuenConta


            Else
                Titulo01 = "Control de errores de ejecución"
                Informa = "OJO: La cuenta contable quedo registrar en borrador pero no se guardo correctamente la contabilidad" & Chr(13) & Chr(10)
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                RegistraCuenConta = False
                Return RegistraCuenConta
            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Al Registrar la cuenta contable " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            RegistraCuenConta = False
            Return RegistraCuenConta
        Finally
            cn.Close()
        End Try  'Registra la cuenta contable



    End Function

    Public Function RegistrarContabilidad()
        Try


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "Al Registrar la cuenta contable " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
