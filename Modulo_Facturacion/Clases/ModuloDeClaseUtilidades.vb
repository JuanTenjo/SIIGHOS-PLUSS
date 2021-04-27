Imports System.Data.SqlClient

Public Class ModuloDeClaseUtilidades
    Public Function RegistrarCodigo(CodProSer, NomProSer, ClasiProSer, ValTarifa, PorcIVA, CodUsuario) As Boolean
        Dim estado As Boolean
        Dim Resultado As Int32
        cn.Open()
        Dim ValidarCodigo As SqlCommand
        ValidarCodigo = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "SELECT COUNT(CodProSer) FROM [BDADYSNET].[dbo].[Datos catalogo de producservicios] WHERE CodProSer = '" & CodProSer.ToString() & "'"
                }

        Resultado = ValidarCodigo.ExecuteScalar()

        cn.Close()


        If Resultado = 0 Then
            If MsgBox("Registrara este servicio", vbYesNo) = vbYes Then
                Try
                    cn.Open()
                    Dim RegistrarProducto As SqlCommand
                    RegistrarProducto = New SqlCommand With {
                        .Connection = cn,
                        .CommandText = "INSERT INTO [BDADYSNET].[dbo].[Datos catalogo de producservicios]
                                        ([CodProSer], [NomProSer],[ClasiProSer],[ValTarifa],[PorcIVA],[CodRegis]) VALUES(@CodProSer, @NomProSer,@ClasiProSer,@ValTarifa,@PorcIVA,@CodRegis)"
                    }
                    With RegistrarProducto.Parameters
                        .AddWithValue("CodProSer", CodProSer)
                        .AddWithValue("NomProSer", NomProSer)
                        .AddWithValue("ClasiProSer", ClasiProSer)
                        .AddWithValue("ValTarifa", Convert.ToDouble(ValTarifa))
                        .AddWithValue("PorcIVA", Convert.ToDouble(PorcIVA))
                        .AddWithValue("CodRegis", (CodUsuario))
                    End With

                    If RegistrarProducto.ExecuteNonQuery() Then
                        MsgBox("Registro Exitoso")
                        estado = True
                    End If

                    Return estado

                Catch ex As Exception
                    Titulo01 = "Control de errores de ejecución"
                    Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                    Informa += "al registrar el producto" & Chr(13) & Chr(10)
                    Informa += "Mensaje del error: " & ex.Message
                    MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Finally
                    cn.Close()
                End Try

            End If
        Else
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "el codigo del producto ya existe" & Chr(13) & Chr(10)
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Function

    Public Function ActualizarCodigo(Codigo, NomProSer, ClasiProSer, ValTarifa, PorcIVA, CodUsuario) As Boolean
        Dim estado As Boolean
        If MsgBox("Actualizara este servicio", vbYesNo) = vbYes Then
            Try
                cn.Open()
                Dim ActualizarSer As SqlCommand
                ActualizarSer = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "UPDATE [BDADYSNET].[dbo].[Datos catalogo de producservicios] SET  [CodProSer] = @Codigo, [NomProSer] = @NomProSer,  [ClasiProSer] = @ClasiProSer,  [ValTarifa] = @ValTarifa, [PorcIVA] = @PorcIVA, [CodModi] = @CodModi WHERE [CodProSer] = @Codigo"
                }
                With ActualizarSer.Parameters
                    .AddWithValue("Codigo", Codigo)
                    .AddWithValue("NomProSer", NomProSer)
                    .AddWithValue("ClasiProSer", ClasiProSer)
                    .AddWithValue("ValTarifa", Convert.ToDouble(ValTarifa))
                    .AddWithValue("PorcIVA", Convert.ToDouble(PorcIVA))
                    .AddWithValue("CodModi", (CodUsuario))
                End With

                If ActualizarSer.ExecuteNonQuery() Then
                    MsgBox("Actualizacion Exitosa")
                    estado = True
                End If

                Return estado

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "al registrar el producto" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                cn.Close()
            End Try

        End If
    End Function
    Public Function EliminarServicio(CodProSer) As Boolean
        Dim estado As Boolean
        If MsgBox("Eliminara este servicio, esta seguro?", vbYesNo) = vbYes Then
            Try
                cn.Open()
                Dim EliminarSer As SqlCommand
                EliminarSer = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "DELETE FROM [BDADYSNET].[dbo].[Datos catalogo de producservicios] WHERE [CodProSer] = @CodProSer"
                }
                With EliminarSer.Parameters
                    .AddWithValue("CodProSer", CodProSer)
                End With

                If EliminarSer.ExecuteNonQuery() Then
                    MsgBox("Eliminacion Exitosa")
                    estado = True
                End If

                Return estado

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "al eliminar el producto" & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                cn.Close()
            End Try

        End If
    End Function
End Class
