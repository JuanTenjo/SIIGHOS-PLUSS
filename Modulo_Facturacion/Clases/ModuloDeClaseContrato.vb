Imports System.Data.SqlClient
Public Class ModuloDeClaseContrato

    Public Function RegistrarContrato(ID_Contratos, ContraNo, VigAnContra, TipDocContra, NumDocContra, CodSucContra, TipoContra, FecIniCon,
                                      FecFinCon, ObjeContra, ValSinIVa, ValIvaCon, ValCerPazSal, ValPagLegal, NumPagos, ExigePoli, NomEntiPoli,
                                      FecExpPoli, EstaVigCon, NumVisMes, FecCotiza, TipDocRe, NumDocRe, CodRegis, FecRegis, CodModi, FecModi, DataGridDetallesCoutas, DataGridDetallePolizas, CodPoliza, VezPoliza) As Boolean
        Dim EstadoActualizacion As Boolean = False
        Dim EstadoRegistro As Boolean = False
        Dim banderaActualizado As Int16 = 0
        Dim LibreParaModificar As Int16 = 0
        Dim bandera As Int16 = 0
        Dim Resultado As Object = 0
        Try
            'Call conectarGeogebra()
            cn.Open()
            Dim ComandoveriContrato As SqlCommand
            ComandoveriContrato = New SqlCommand With {
                .Connection = cn,
                .CommandText = "select Count(ID_Contratos) from [Datos registros de contratos] where ID_Contratos = @ID_Contratos"
            }
            ComandoveriContrato.Parameters.AddWithValue("@ID_Contratos", ID_Contratos)
            Resultado = ComandoveriContrato.ExecuteScalar()
            cn.Close()
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de si existe el contrato" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If Resultado <> 0 Then

            Try
                cn.Open()
                Dim comando As SqlCommand
                comando = New SqlCommand
                comando.Connection = cn
                comando.CommandText = "UPDATE [Datos registros de contratos] SET ContraNo = @ContraNo , VigAnContra = @VigAnContra , TipDocContra = @TipDocContra, NumDocContra = @NumDocContra, CodSucContra = @CodSucContra , TipoContra = @TipoContra , FecIniCon = @FecIniCon ,
                                                  FecFinCon = @FecFinCon , ObjeContra = @ObjeContra , ValSinIVa = @ValSinIVa , ValIvaCon = @ValIvaCon , ValCerPazSal = @ValCerPazSal, ValPagLegal = @ValPagLegal, NumPagos = @NumPagos, ExigePoli = @ExigePoli, NomEntiPoli = @NomEntiPoli ,
                                                  FecExpPoli = @FecExpPoli , EstaVigCon = @EstaVigCon, NumVisMes = @NumVisMes , FecCotiza = @FecCotiza , TipDocRe = @TipDocRe , NumDocRe = @NumDocRe , CodModi = @CodModi , FecModi = @FecModi WHERE ID_Contratos = @ID_Contratos "
                comando.CommandType = CommandType.Text
                With comando.Parameters
                    .AddWithValue("@ID_Contratos", ID_Contratos)
                    .AddWithValue("@ContraNo", ContraNo)
                    .AddWithValue("@VigAnContra", VigAnContra)
                    .AddWithValue("@TipDocContra", TipDocContra)
                    .AddWithValue("@NumDocContra", NumDocContra)
                    .AddWithValue("@CodSucContra", CodSucContra)
                    .AddWithValue("@TipoContra", TipoContra)
                    .AddWithValue("@FecIniCon", Convert.ToDateTime(FecIniCon))
                    .AddWithValue("@FecFinCon", Convert.ToDateTime(FecFinCon))
                    .AddWithValue("@ObjeContra", ObjeContra)
                    .AddWithValue("@ValSinIVa", Convert.ToDouble(ValSinIVa))
                    .AddWithValue("@ValIvaCon", Convert.ToDouble(ValIvaCon))
                    .AddWithValue("@ValCerPazSal", Convert.ToDouble(ValCerPazSal))
                    .AddWithValue("@ValPagLegal", Convert.ToDouble(ValPagLegal))
                    .AddWithValue("@NumPagos", NumPagos)
                    .AddWithValue("@ExigePoli", ExigePoli)
                    .AddWithValue("@NomEntiPoli", NomEntiPoli)
                    .AddWithValue("@FecExpPoli", Convert.ToDateTime(FecExpPoli))
                    .AddWithValue("@EstaVigCon", EstaVigCon)
                    .AddWithValue("@NumVisMes", NumVisMes)
                    .AddWithValue("@FecCotiza", Convert.ToDateTime(FecCotiza))
                    .AddWithValue("@TipDocRe", TipDocRe)
                    .AddWithValue("@NumDocRe", NumDocRe)
                    .AddWithValue("@CodModi", CodModi)
                    .AddWithValue("@FecModi", Convert.ToDateTime(FecModi))
                End With
                If comando.ExecuteNonQuery() Then
                    banderaActualizado = 1
                    EstadoActualizacion = True
                End If
            Catch ex As Exception
                EstadoActualizacion = False
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "al actualizar el contrato" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                cn.Close()
            End Try
            If banderaActualizado = 1 Then
                Try
                    cn.Open()
                    Dim EliminarCuotasNoPagas As SqlCommand
                    EliminarCuotasNoPagas = New SqlCommand
                    EliminarCuotasNoPagas.Connection = cn
                    EliminarCuotasNoPagas.CommandType = CommandType.Text
                    EliminarCuotasNoPagas.CommandText = "DELETE from [Datos detalles de cuotas contratos] where ID_Contratos = @ID_Contratos and FacturCuota = 0"
                    EliminarCuotasNoPagas.Parameters.AddWithValue("ID_Contratos", ID_Contratos)
                    If EliminarCuotasNoPagas.ExecuteNonQuery() Then
                        LibreParaModificar = 1
                    End If
                    LibreParaModificar = 1
                    EstadoActualizacion = True
                Catch ex As Exception
                    EstadoActualizacion = False
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += " al eliminar las cuotas no pagas" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Finally
                    cn.Close()
                End Try
                If ExigePoli = 1 Or ExigePoli = True Then
                    Try
                        cn.Open()
                        Dim EliminarCuotasNoPagas As SqlCommand
                        EliminarCuotasNoPagas = New SqlCommand
                        EliminarCuotasNoPagas.Connection = cn
                        EliminarCuotasNoPagas.CommandType = CommandType.Text
                        EliminarCuotasNoPagas.CommandText = "DELETE from [Datos detalles polizas contrato] where ID_Contratos = @ID_Contratos AND CodPoliza = @CodPoliza"
                        EliminarCuotasNoPagas.Parameters.AddWithValue("CodPoliza", CodPoliza)
                        EliminarCuotasNoPagas.Parameters.AddWithValue("ID_Contratos", ID_Contratos)
                        If EliminarCuotasNoPagas.ExecuteNonQuery() Then
                            LibreParaModificar = 1
                        End If
                        LibreParaModificar = 1
                        EstadoActualizacion = True
                    Catch ex As Exception
                        EstadoActualizacion = False
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                        Informa += " al eliminar las polizas" & Chr(13) & Chr(10)
                        Informa += "Mensaje del error: " & ex.Message
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    Finally
                        cn.Close()
                    End Try
                End If
            End If



            If LibreParaModificar = 1 Then
                Try
                    cn.Open()
                    Dim ModificaDataGridDetalleCuotas As SqlCommand
                    ModificaDataGridDetalleCuotas = New SqlCommand With {
                        .Connection = cn,
                        .CommandType = CommandType.Text,
                        .CommandText = "INSERT INTO [Datos detalles de cuotas contratos](CuotaNoPac,ID_Contratos,PorCuoPac,ValTolCuota,FecPacPag,FacturCuota) 
                                                       VALUES(@CuotaNoPac,@ID_Contratos,@PorCuoPac,@ValTolCuota,@FecPacPag,@FacturCuota)"
                    }
                    ModificaDataGridDetalleCuotas.Parameters.AddWithValue("ID_Contratos", ID_Contratos)
                    For Each Fila2 In DataGridDetallesCoutas.Rows
                        ModificaDataGridDetalleCuotas.Parameters.Clear()
                        With ModificaDataGridDetalleCuotas.Parameters
                            If Convert.ToString(Fila2.Cells("EstadoPagado").Value = False) Then
                                .AddWithValue("CuotaNoPac", Convert.ToInt32(Fila2.Cells("NumeroDeCouta").Value))
                                .AddWithValue("ID_Contratos", ID_Contratos)
                                .AddWithValue("PorCuoPac", Convert.ToDouble(Fila2.Cells("Porcentage").Value))
                                .AddWithValue("ValTolCuota", Convert.ToDouble(Fila2.Cells("ValorTotalCouta").Value))
                                .AddWithValue("FecPacPag", Convert.ToDateTime(Fila2.Cells("FechaDePago").Value))
                                .AddWithValue("FacturCuota", Convert.ToString(Fila2.Cells("EstadoPagado").Value))
                                ModificaDataGridDetalleCuotas.ExecuteNonQuery()
                            Else

                            End If
                        End With
                    Next
                    LibreParaModificar = 0
                    EstadoActualizacion = True
                Catch ex As Exception
                    EstadoActualizacion = False
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += " al insertar las nuevas cuotas del contrato" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Finally
                    cn.Close()
                End Try


                If ExigePoli = 1 Or ExigePoli = True Then


                    Try
                        cn.Open()
                        Dim ModificaDataGridDetallePolizas As SqlCommand = New SqlCommand With {
                            .Connection = cn,
                            .CommandType = CommandType.Text,
                            .CommandText = "INSERT INTO [Datos detalles polizas contrato](CodPoliza,TipPoliza,VezPoliza,ID_Contratos,PorcePoli,ValCubre,FecIniPol,FecFinPol,AnulPoli,RazAnulPol,CodAnulPol,FecAnulPol,CodModi,FecModi) 
                                        VALUES (@CodPoliza,@TipPoliza,@VezPoliza,@ID_Contratos,@PorcePoli,@ValCubre,@FecIniPol,@FecFinPol,@AnulPoli,@RazAnulPol,@CodAnulPol,@FecAnulPol,@CodModi,@FecModi)"
                        }
                        ModificaDataGridDetallePolizas.Parameters.AddWithValue("ID_Contratos", ID_Contratos)

                        For Each Fila2 In DataGridDetallePolizas.Rows
                            ModificaDataGridDetallePolizas.Parameters.Clear()
                            With ModificaDataGridDetallePolizas.Parameters

                                ModificaDataGridDetallePolizas.Parameters.Clear()
                                With ModificaDataGridDetallePolizas.Parameters
                                    .AddWithValue("CodPoliza", CodPoliza)
                                    .AddWithValue("TipPoliza", Convert.ToString(Fila2.Cells("TipoPoliza").Value))
                                    .AddWithValue("VezPoliza", VezPoliza)
                                    .AddWithValue("ID_Contratos", ID_Contratos)
                                    .AddWithValue("PorcePoli", Convert.ToDouble(Fila2.Cells("PorcePoli").Value))
                                    .AddWithValue("ValCubre", Convert.ToDouble(Fila2.Cells("ValCubre").Value))
                                    .AddWithValue("FecIniPol", Convert.ToDateTime(Fila2.Cells("Fecha_Inicio").Value))
                                    .AddWithValue("FecFinPol", Convert.ToDateTime(Fila2.Cells("Fecha_Final").Value))
                                    .AddWithValue("AnulPoli", Convert.ToString(Fila2.Cells("Anular_Poliza").Value))
                                    .AddWithValue("RazAnulPol", Convert.ToString(Fila2.Cells("Razon_Anulamiento").Value))
                                    .AddWithValue("CodAnulPol", CodModi)
                                    .AddWithValue("FecAnulPol", Convert.ToDateTime(FecModi))
                                    .AddWithValue("CodModi", CodModi)
                                    .AddWithValue("FecModi", Convert.ToDateTime(FecModi))
                                End With
                                ModificaDataGridDetallePolizas.ExecuteNonQuery()
                            End With
                        Next
                        EstadoActualizacion = True
                        LibreParaModificar = 0
                    Catch ex As Exception
                        EstadoActualizacion = False
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                        Informa += " al insertar las nuevas polizas" & Chr(13) & Chr(10)
                        Informa += "Mensaje del error: " & ex.Message
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    Finally
                        cn.Close()
                    End Try
                End If
            End If
            If EstadoActualizacion = True Then
                MsgBox("Actualizacion Exitosa")
            Else
                EstadoActualizacion = False
            End If
            Return EstadoActualizacion
        Else
            Try
                cn.Open()
                Dim comando As SqlCommand
                comando = New SqlCommand
                comando.Connection = cn
                comando.CommandText = "INSERT INTO [Datos registros de contratos](ID_Contratos, ContraNo, VigAnContra, TipDocContra, NumDocContra, CodSucContra, TipoContra, FecIniCon, FecFinCon, ObjeContra, ValSinIVa, ValIvaCon, ValCerPazSal, ValPagLegal, NumPagos, ExigePoli, NomEntiPoli, FecExpPoli,EstaVigCon, NumVisMes, FecCotiza, TipDocRe, NumDocRe, CodRegis, FecRegis, CodModi) 
                                        VALUES (@ID_Contratos,@ContraNo,@VigAnContra,@TipDocContra,@NumDocContra,@CodSucContra,@TipoContra,@FecIniCon,@FecFinCon,@ObjeContra,@ValSinIVa,@ValIvaCon,@ValCerPazSal,@ValPagLegal, @NumPagos,@ExigePoli,@NomEntiPoli,@FecExpPoli,@EstaVigCon,@NumVisMes, @FecCotiza,@TipDocRe,@NumDocRe,@CodRegis,@FecRegis, @CodModi)"
                comando.CommandType = CommandType.Text
                With comando.Parameters
                    .AddWithValue("@ID_Contratos", ID_Contratos)
                    .AddWithValue("@ContraNo", ContraNo)
                    .AddWithValue("@VigAnContra", VigAnContra)
                    .AddWithValue("@TipDocContra", TipDocContra)
                    .AddWithValue("@NumDocContra", NumDocContra)
                    .AddWithValue("@CodSucContra", CodSucContra)
                    .AddWithValue("@TipoContra", TipoContra)
                    .AddWithValue("@FecIniCon", Convert.ToDateTime(FecIniCon))
                    .AddWithValue("@FecFinCon", Convert.ToDateTime(FecFinCon))
                    .AddWithValue("@ObjeContra", ObjeContra)
                    .AddWithValue("@ValSinIVa", Convert.ToDouble(ValSinIVa))
                    .AddWithValue("@ValIvaCon", Convert.ToDouble(ValIvaCon))
                    .AddWithValue("@ValCerPazSal", Convert.ToDouble(ValCerPazSal))
                    .AddWithValue("@ValPagLegal", Convert.ToDouble(ValPagLegal))
                    .AddWithValue("@NumPagos", NumPagos)
                    .AddWithValue("@ExigePoli", ExigePoli)
                    .AddWithValue("@NomEntiPoli", NomEntiPoli)
                    .AddWithValue("@FecExpPoli", Convert.ToDateTime(FecExpPoli))
                    .AddWithValue("@EstaVigCon", EstaVigCon)
                    .AddWithValue("@NumVisMes", NumVisMes)
                    .AddWithValue("@FecCotiza", Convert.ToDateTime(FecCotiza))
                    .AddWithValue("@TipDocRe", TipDocRe)
                    .AddWithValue("@NumDocRe", NumDocRe)
                    .AddWithValue("@CodRegis", CodRegis)
                    .AddWithValue("@FecRegis", Convert.ToDateTime(FecRegis))
                    .AddWithValue("@CodModi", CodRegis)
                End With

                If comando.ExecuteNonQuery() Then
                    EstadoRegistro = True
                    '  MsgBox("Registro Completo")
                    bandera = 1
                End If
            Catch ex As Exception
                EstadoRegistro = False
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += " al registrar contrato" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                cn.Close()
            End Try

            If bandera = 1 Then
                Try
                    cn.Open()
                    Dim comando1 As SqlCommand
                    comando1 = New SqlCommand
                    comando1.Connection = cn
                    comando1.CommandText = "INSERT INTO [Datos detalles de cuotas contratos](CuotaNoPac,ID_Contratos,PorCuoPac,ValTolCuota,FecPacPag,FacturCuota) 
                                    VALUES (@CuotaNoPac,@ID_Contratos,@PorCuoPac,@ValTolCuota,@FecPacPag,@FacturCuota)"
                    comando1.CommandType = CommandType.Text
                    Dim Fila As DataGridViewRow = New DataGridViewRow()
                    For Each Fila In DataGridDetallesCoutas.Rows
                        comando1.Parameters.Clear()
                        With comando1.Parameters
                            .AddWithValue("CuotaNoPac", Convert.ToInt32(Fila.Cells("NumeroDeCouta").Value))
                            .AddWithValue("ID_Contratos", ID_Contratos)
                            .AddWithValue("PorCuoPac", Convert.ToDouble(Fila.Cells("Porcentage").Value))
                            .AddWithValue("ValTolCuota", Convert.ToDouble(Fila.Cells("ValorTotalCouta").Value))
                            .AddWithValue("FecPacPag", Convert.ToDateTime(Fila.Cells("FechaDePago").Value))
                            .AddWithValue("FacturCuota", Convert.ToString(Fila.Cells("EstadoPagado").Value))
                        End With
                        comando1.ExecuteNonQuery()
                    Next
                    EstadoRegistro = True
                    '  MsgBox("Registro Completo")
                Catch ex As Exception
                    EstadoRegistro = False
                    Return False
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += " al insertar las nuevas cuotas del contrato" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cn.Close()
                End Try
                If ExigePoli = 1 Or ExigePoli = True Then
                    Try
                        cn.Open()
                        Dim comando1 As SqlCommand
                        comando1 = New SqlCommand
                        comando1.Connection = cn
                        comando1.CommandText = "INSERT INTO [Datos detalles polizas contrato](CodPoliza,TipPoliza,VezPoliza,ID_Contratos,PorcePoli,ValCubre,FecIniPol,FecFinPol,AnulPoli,RazAnulPol,CodAnulPol,FecAnulPol,CodRegis,FecRegis) 
                                        VALUES (@CodPoliza,@TipPoliza,@VezPoliza,@ID_Contratos,@PorcePoli,@ValCubre,@FecIniPol,@FecFinPol,@AnulPoli,@RazAnulPol,@CodAnulPol,@FecAnulPol,@CodRegis,@FecRegis)"
                        comando1.CommandType = CommandType.Text
                        Dim Fila As DataGridViewRow = New DataGridViewRow()
                        For Each Fila In DataGridDetallePolizas.Rows
                            comando1.Parameters.Clear()

                            With comando1.Parameters
                                .AddWithValue("CodPoliza", CodPoliza)
                                .AddWithValue("TipPoliza", Convert.ToString(Fila.Cells("TipoPoliza").Value))
                                .AddWithValue("VezPoliza", VezPoliza)
                                .AddWithValue("ID_Contratos", ID_Contratos)
                                .AddWithValue("PorcePoli", Convert.ToDouble(Fila.Cells("PorcePoli").Value))
                                .AddWithValue("ValCubre", Convert.ToDouble(Fila.Cells("ValCubre").Value))
                                .AddWithValue("FecIniPol", Convert.ToDateTime(Fila.Cells("Fecha_Inicio").Value))
                                .AddWithValue("FecFinPol", Convert.ToDateTime(Fila.Cells("Fecha_Final").Value))
                                .AddWithValue("AnulPoli", Convert.ToString(Fila.Cells("Anular_Poliza").Value))
                                .AddWithValue("RazAnulPol", Convert.ToString(Fila.Cells("Razon_Anulamiento").Value))
                                .AddWithValue("CodAnulPol", Convert.ToString(Fila.Cells("CodAnuPol").Value))
                                .AddWithValue("FecAnulPol", Convert.ToDateTime(Fila.Cells("Fecha_Anulacion").Value))
                                .AddWithValue("CodRegis", CodRegis)
                                .AddWithValue("FecRegis", Convert.ToDateTime(FecRegis))
                            End With
                            comando1.ExecuteNonQuery()
                        Next
                        EstadoRegistro = True
                    Catch ex As Exception
                        EstadoRegistro = False
                        Titulo01 = "Control de errores de ejecución"
                        Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                        Informa += " al insertar las polizas del contrato" & Chr(13) & Chr(10)
                        Informa += "Mensaje del error: " & ex.Message
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    Finally
                        cn.Close()
                    End Try
                End If
            End If
            If EstadoRegistro = True Then
                MsgBox("Registro Exitoso")
            Else
                EstadoRegistro = False
            End If
        End If

        Return Nothing
    End Function


    Public Function EliminarContrato(IDContrato) As Boolean
        Try
            cn.Open()
            Dim estado As Boolean
            Dim DeleteDetalleContrato As SqlCommand
            DeleteDetalleContrato = New SqlCommand With {
                .Connection = cn,
                .CommandType = CommandType.Text,
                .CommandText = "DELETE FROM [BDADYSNET].[dbo].[Datos detalles de cuotas contratos] WHERE [ID_Contratos] = '" & IDContrato.ToString & "'"
            }
            If DeleteDetalleContrato.ExecuteNonQuery Then
                estado = True
            Else
                estado = False
            End If

            If estado Then
                Dim DeleteContrato As SqlCommand
                DeleteContrato = New SqlCommand With {
                    .Connection = cn,
                    .CommandType = CommandType.Text,
                    .CommandText = "DELETE FROM [BDADYSNET].[dbo].[Datos registros de contratos] WHERE [ID_Contratos] = '" & IDContrato.ToString & "'"
                }
                If DeleteContrato.ExecuteNonQuery Then
                    estado = True
                    MsgBox("Eliminacion Exitosa")
                Else
                    estado = False
                End If
            End If

            Return estado
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al eliminar Contrato" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try

    End Function
End Class


