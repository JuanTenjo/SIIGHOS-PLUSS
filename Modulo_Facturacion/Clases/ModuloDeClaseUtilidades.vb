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
            If MessageBox.Show("Se agregara este producto ¿esta seguro? ", "Control de contabuilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
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
                        MessageBox.Show("Registro exitoso", "Control de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Try

            Dim estado As Boolean

            'Primero se verifica si este codigo ya ha sido usado, si ha sido usado no se puede actualizar

            Dim Resultado As Int32
            cn.Open()
            Dim ValidarCodigo As SqlCommand
            ValidarCodigo = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "SELECT COUNT(CodProSer) FROM [BDADYSNET].[dbo].[Datos detalle de remisiones] WHERE [CodProSer] = '" & Codigo.ToString() & "'"
                }

            Resultado = ValidarCodigo.ExecuteScalar()

            cn.Close()

            If Resultado = 0 Then

                If MessageBox.Show("Se actualizara este producto ¿esta seguro? ", "Control de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then


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
                        MessageBox.Show("Actualizacion exitosa", "Control de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estado = True
                    End If

                    Return estado


                Else

                    Return False

                End If

            Else

                MessageBox.Show("Este codigo no se puede actualizar porque ya ha sido usado", "Control de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False

            End If



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

    End Function
    Public Function EliminarServicio(CodProSer) As Boolean

        Try

            Dim estado As Boolean


            Dim Resultado As Int32
            cn.Open()
            Dim ValidarCodigo As SqlCommand
            ValidarCodigo = New SqlCommand With {
                    .Connection = cn,
                    .CommandText = "SELECT COUNT(CodProSer) FROM [BDADYSNET].[dbo].[Datos detalle de remisiones] WHERE [CodProSer] = '" & CodProSer.ToString() & "'"
                }

            Resultado = ValidarCodigo.ExecuteScalar()

            cn.Close()

            If (Resultado = 0) Then

                If MessageBox.Show("Se eliminara este producto ¿esta seguro? ", "Control de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

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
                        MessageBox.Show("Eliminación Exitosa", "Control de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estado = True
                    End If

                    Return estado

                Else
                    Return False

                End If

            Else

                MessageBox.Show("Este codigo no se puede eliminar porque ya ha sido usado", "Control de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False

            End If
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

    End Function
End Class
