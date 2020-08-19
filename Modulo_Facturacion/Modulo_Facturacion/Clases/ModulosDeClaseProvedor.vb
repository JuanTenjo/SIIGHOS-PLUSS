Imports System.Data.SqlClient

Public Class ModulosDeClaseProvedor
    Public Function AgregarProvedor(TipoDocu, IdenProve, DigVeri, SucurProv, IdenProveDos, RazonSol, RegiTri,
                                    TipoProvee, PaisProve, DptoProve, CityProve, DireProve, DirElectro, DirElectro1, PagWebPro,
                                    IndiTel, TelProve1,
                                    TelProve2, TelProve3, NomConta, CarConta, CelConta, HabilPro, AutoReteCree, ApliRete, ApliRetICA, ApliRetIVA, PorRetIVA, CodActi01,
                                    CodActi02, CodActi03, NomReLegal, ObserProvee, CodRegis, FecRegis, nombre1, nombre2, apellido1, apellido2) As Boolean
        Dim bandera As Integer
        Try
            Dim cn As SqlConnection
            Dim comandosVeri As SqlCommand
            cn = New SqlConnection("Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True")
            cn.Open()
            If Not IsDBNull(TipoDocu) Then
                comandosVeri = New SqlCommand
                comandosVeri.Connection = cn
                comandosVeri.CommandText = "select Count(IdenProve) from [Datos proveedores] where IdenProve = @IdenProve"
                comandosVeri.Parameters.AddWithValue("@IdenProve", IdenProve)
                Dim Resultado As Object = comandosVeri.ExecuteScalar()
                If Not IsDBNull(Resultado) Then
                    If Resultado <> 0 Then
                        MsgBox("Este numero de documento ya existe en la base de datos")
                    Else
                        Try
                            Dim comandos As SqlCommand
                            comandos = New SqlCommand
                            comandos.Connection = cn
                            comandos.CommandText = "INSERT INTO [Datos proveedores] (TipoDocu, IdenProve, DigVeri, SucurProv, IdenProveDos, RazonSol, RegiTri, TipoProvee,
                            PaisProve, DptoProve, CityProve, DireProve, DirElectro, DirElectro1, PagWebPro, IndiTel, TelProve1, TelProve2, TelProve3, NomConta, CarConta, CelConta, HabilPro,
                            AutoReteCree, ApliRete, ApliRetICA, ApliRetIVA, PorRetIVA, CodActi01, CodActi02, CodActi03, NomReLegal, ObserProvee, CodRegis, FecRegis )
                            Values (@TipoDocu, @IdenProve, @DigVeri, @SucurProv, @IdenProveDos, @RazonSol, @RegiTri, @TipoProvee, @PaisProve, @DptoProve, @CityProve,
                            @DireProve, @DirElectro, @DirElectro1, @PagWebPro, @IndiTel, @TelProve1, @TelProve2, @TelProve3, @NomConta, @CarConta, @CelConta, @HabilPro, @AutoReteCree, @ApliRete,
                            @ApliRetICA, @ApliRetIVA, @PorRetIVA, @CodActi01, @CodActi02, @CodActi03, @NomReLegal, @ObserProvee, @CodRegis, @FecRegis)"
                            comandos.CommandType = CommandType.Text
                            With comandos.Parameters
                                .AddWithValue("@TipoDocu", TipoDocu)
                                .AddWithValue("@IdenProve", IdenProve)
                                .AddWithValue("@DigVeri", DigVeri)
                                .AddWithValue("@SucurProv", SucurProv)
                                .AddWithValue("@IdenProveDos", IdenProveDos)
                                .AddWithValue("@RazonSol", RazonSol)
                                .AddWithValue("@RegiTri", RegiTri)
                                .AddWithValue("@TipoProvee", TipoProvee)
                                .AddWithValue("@PaisProve", PaisProve)
                                .AddWithValue("@DptoProve", DptoProve)
                                .AddWithValue("@CityProve", CityProve)
                                .AddWithValue("@DireProve", DireProve)
                                .AddWithValue("@DirElectro", DirElectro)
                                .AddWithValue("@DirElectro1", DirElectro1)
                                .AddWithValue("@PagWebPro", PagWebPro)
                                .AddWithValue("@IndiTel", IndiTel)
                                .AddWithValue("@TelProve1", TelProve1)
                                .AddWithValue("@TelProve2", TelProve2)
                                .AddWithValue("@TelProve3", TelProve3)
                                .AddWithValue("@NomConta", NomConta)
                                .AddWithValue("@CarConta", CarConta)
                                .AddWithValue("@CelConta", CelConta)
                                .AddWithValue("@HabilPro", HabilPro)
                                .AddWithValue("@AutoReteCree", AutoReteCree)
                                .AddWithValue("@ApliRete", ApliRete)
                                .AddWithValue("@ApliRetICA", ApliRetICA)
                                .AddWithValue("@ApliRetIVA", ApliRetIVA)
                                .AddWithValue("@PorRetIVA", PorRetIVA)
                                .AddWithValue("@CodActi01", CodActi01)
                                .AddWithValue("@CodActi02", CodActi02)
                                .AddWithValue("@CodActi03", CodActi03)
                                .AddWithValue("@NomReLegal", NomReLegal)
                                .AddWithValue("@ObserProvee", ObserProvee)
                                .AddWithValue("@CodRegis", CodRegis)
                                .AddWithValue("@FecRegis", FecRegis)

                            End With
                            If comandos.ExecuteNonQuery() Then
                                MsgBox("Registro Completo")
                                bandera = 1
                            End If

                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                Else
                    MsgBox("lA CONSULTA VALIDACION DE USUARIO VIENE NULA")
                End If
            End If
            If (TipoDocu <> "NIT") Then
                If bandera = 1 Then
                    Try
                        Dim cmn = New SqlCommand
                        cmn.Connection = cn
                        cmn.CommandText = "select Count(IdenProve) from [Datos proveedores] where IdenProve = @IdenProve"
                        cmn.Parameters.AddWithValue("@IdenProve", IdenProve)
                        Dim ResultadoConsultaNatural As Object = cmn.ExecuteScalar()
                        If Not IsDBNull(ResultadoConsultaNatural) Then
                            If ResultadoConsultaNatural <> 0 Then
                                Dim cipn = New SqlCommand
                                cipn.Connection = cn
                                cipn.CommandText = "INSERT INTO [Datos personas naturales] (TipoDoc,NumDoc,SucuDoc,Nombre01,Nombre02,Apellido01,Apellido02,CodRegis,FecRegis)
                                                Values(@TipoDocu,@IdenProve,@SucurProv,@nombre1,@nombre2,@apellido1,@apellido2,@CodRegis,@FecRegis)"
                                cipn.CommandType = CommandType.Text
                                With cipn.Parameters
                                    .AddWithValue("@TipoDocu", TipoDocu)
                                    .AddWithValue("@IdenProve", IdenProve)
                                    .AddWithValue("@SucurProv", SucurProv)
                                    .AddWithValue("@nombre1", nombre1)
                                    .AddWithValue("@nombre2", nombre2)
                                    .AddWithValue("@apellido1", apellido1)
                                    .AddWithValue("@apellido2", apellido2)
                                    .AddWithValue("@CodRegis", CodRegis)
                                    .AddWithValue("@FecRegis", FecRegis)
                                End With
                                If cipn.ExecuteNonQuery() Then
                                    Return True
                                    bandera = 0
                                End If
                                cn.Close()
                            Else
                                MsgBox("Este usuario no se encuentra registrado como provedor actualmente")
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
    Public Function ActualizarProvedor(TipoDocu, IdenProve, DigVeri, SucurProv, IdenProveDos, RazonSol, RegiTri,
                                    TipoProvee, PaisProve, DptoProve, CityProve, DireProve, DirElectro, DirElectro1, PagWebPro,
                                    IndiTel, TelProve1,
                                    TelProve2, TelProve3, NomConta, CarConta, CelConta, HabilPro, AutoReteCree, ApliRete, ApliRetICA, ApliRetIVA, PorRetIVA, CodActi01,
                                    CodActi02, CodActi03, NomReLegal, ObserProvee, CodModi, FecModi, nombre1, nombre2, apellido1, apellido2) As Boolean
        Dim bandera As Integer
        ' If (TipoPersona = "Juridica") Then
        Dim cn As SqlConnection
        cn = New SqlConnection("Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True")
        cn.Open()
        If Not IsDBNull(TipoDocu) Then
            Try
                Dim comandos As SqlCommand
                comandos = New SqlCommand
                comandos.Connection = cn
                comandos.CommandText = "UPDATE [Datos proveedores] SET SucurProv = @SucurProv, IdenProveDos = @IdenProveDos, RazonSol = @RazonSol, RegiTri = @RegiTri,
                                TipoProvee = @TipoProvee, PaisProve = @PaisProve, DptoProve = @DptoProve, CityProve = @CityProve, DireProve = @DireProve, DirElectro = @DirElectro, DirElectro1 = @DirElectro1, PagWebPro = @PagWebPro,
                                IndiTel = @IndiTel, TelProve1 = @TelProve1,
                                TelProve2 = @TelProve2, TelProve3 = @TelProve3, NomConta = @NomConta, CarConta = @CarConta, CelConta = @CelConta, HabilPro = @HabilPro, AutoReteCree = @AutoReteCree, ApliRete = @ApliRete, ApliRetICA = @ApliRetICA, ApliRetIVA = @ApliRetIVA, PorRetIVA = @PorRetIVA, CodActi01 = @CodActi01,
                                CodActi02 = @CodActi02, CodActi03 = @CodActi03, NomReLegal = @NomReLegal, ObserProvee = @ObserProvee, CodModi = @CodModi, FecModi = @FecModi WHERE IdenProve = @IdenProve"
                comandos.CommandType = CommandType.Text
                With comandos.Parameters
                    .AddWithValue("@IdenProve", IdenProve)
                    .AddWithValue("@DigVeri", DigVeri)
                    .AddWithValue("@SucurProv", SucurProv)
                    .AddWithValue("@IdenProveDos", IdenProveDos)
                    .AddWithValue("@RazonSol", RazonSol)
                    .AddWithValue("@RegiTri", RegiTri)
                    .AddWithValue("@TipoProvee", TipoProvee)
                    .AddWithValue("@PaisProve", PaisProve)
                    .AddWithValue("@DptoProve", DptoProve)
                    .AddWithValue("@CityProve", CityProve)
                    .AddWithValue("@DireProve", DireProve)
                    .AddWithValue("@DirElectro", DirElectro)
                    .AddWithValue("@DirElectro1", DirElectro1)
                    .AddWithValue("@PagWebPro", PagWebPro)
                    .AddWithValue("@IndiTel", IndiTel)
                    .AddWithValue("@TelProve1", TelProve1)
                    .AddWithValue("@TelProve2", TelProve2)
                    .AddWithValue("@TelProve3", TelProve3)
                    .AddWithValue("@NomConta", NomConta)
                    .AddWithValue("@CarConta", CarConta)
                    .AddWithValue("@CelConta", CelConta)
                    .AddWithValue("@HabilPro", HabilPro)
                    .AddWithValue("@AutoReteCree", AutoReteCree)
                    .AddWithValue("@ApliRete", ApliRete)
                    .AddWithValue("@ApliRetICA", ApliRetICA)
                    .AddWithValue("@ApliRetIVA", ApliRetIVA)
                    .AddWithValue("@PorRetIVA", PorRetIVA)
                    .AddWithValue("@CodActi01", CodActi01)
                    .AddWithValue("@CodActi02", CodActi02)
                    .AddWithValue("@CodActi03", CodActi03)
                    .AddWithValue("@NomReLegal", NomReLegal)
                    .AddWithValue("@ObserProvee", ObserProvee)
                    .AddWithValue("@CodModi", CodModi)
                    .AddWithValue("@FecModi", FecModi)
                End With
                If comandos.ExecuteNonQuery() Then
                    MsgBox("Actualización Completada")
                    bandera = 1
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        If (TipoDocu <> "NIT") Then
            Try
                Dim capn = New SqlCommand
                capn.Connection = cn
                capn.CommandText = "UPDATE [Datos personas naturales] SET Nombre01 = @nombre1, Nombre02 = @nombre2, Apellido01 = @apellido1, Apellido02 = @apellido2, CodModi = @CodModi, FecModi = @FecModi WHERE NumDoc = @IdenProve "
                capn.CommandType = CommandType.Text
                With capn.Parameters
                    .AddWithValue("@IdenProve", IdenProve)
                    .AddWithValue("@nombre1", nombre1)
                    .AddWithValue("@nombre2", nombre2)
                    .AddWithValue("@apellido1", apellido1)
                    .AddWithValue("@apellido2", apellido2)
                    .AddWithValue("@CodModi", CodModi)
                    .AddWithValue("@FecModi", FecModi)
                End With
                If capn.ExecuteNonQuery() Then

                    bandera = 0
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
        End If
        Return Nothing
    End Function
    Public Function EliminarProve(TipoDocu, Identidad)
        Dim bandera As Integer
        Dim cn As SqlConnection
        cn = New SqlConnection("Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True")
        cn.Open()
        If TipoDocu <> "NIT" Then
            Try
                bandera = 0
                Dim comandos As SqlCommand
                comandos = New SqlCommand
                comandos.Connection = cn
                comandos.CommandText = "DELETE FROM [Datos personas naturales] WHERE NumDoc = @Identidad"
                comandos.Parameters.AddWithValue("@Identidad", Identidad)
                comandos.CommandType = CommandType.Text
                If comandos.ExecuteNonQuery() Then
                    bandera = 1
                Else
                    Return MsgBox("Error")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        If bandera = 1 Or TipoDocu = "NIT" Then  'Si ya elimino en la tabla naturales o si es nit hazlo de una vez
            Try
                Dim comandos As SqlCommand
                comandos = New SqlCommand
                comandos.Connection = cn
                comandos.CommandText = "DELETE FROM [Datos proveedores] WHERE IdenProve = @Identidad"
                comandos.Parameters.AddWithValue("@Identidad", Identidad)
                comandos.CommandType = CommandType.Text
                If comandos.ExecuteNonQuery() Then
                    MsgBox("Eliminacion Completada")
                    bandera = 0
                Else
                    Return MsgBox("Error")
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


        Return Nothing
    End Function
    Public Function AgregarCuentaBancaria(TipoDocu, IdenProveCB, SucurProvCB, CodiBancoCB, NumCuenCB, TipoCuenCB, ObservaCB, CodRegis, FecRegis) As Boolean
        Dim cn As SqlConnection
        cn = New SqlConnection("Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True")
        cn.Open()
        Try
            Dim comandos1 As SqlCommand
            comandos1 = New SqlCommand
            comandos1.Connection = cn
            comandos1.CommandText = "INSERT INTO [Datos cuentas bancarias proveedores] (TipoDocuCB, IdenProveCB, SucurProvCB, CodiBancoCB, NumCuenCB, TipoCuenCB, ObservaCB, CodRegis, FecRegis)
                            Values (@TipoDocu, @IdenProveCB, @SucurProvCB, @CodiBancoCB, @NumCuenCB, @TipoCuenCB, @ObservaCB, @CodRegis, @FecRegis)"
            comandos1.CommandType = CommandType.Text
            With comandos1.Parameters
                .AddWithValue("@TipoDocu", TipoDocu)
                .AddWithValue("@IdenProveCB", IdenProveCB)
                .AddWithValue("@SucurProvCB", SucurProvCB)
                .AddWithValue("@CodiBancoCB", CodiBancoCB)
                .AddWithValue("@NumCuenCB", NumCuenCB)
                .AddWithValue("@TipoCuenCB", TipoCuenCB)
                .AddWithValue("@ObservaCB", ObservaCB)
                .AddWithValue("@CodRegis", CodRegis)
                .AddWithValue("@FecRegis", FecRegis)
            End With
            If comandos1.ExecuteNonQuery() Then
                MsgBox("Registro Completo")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function
    Public Function EliminarCuentaBancaria(IdenProveCB, CodiBancoCB, NumCuenCB) As Boolean
        Dim cn As SqlConnection
        cn = New SqlConnection("Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True")
        cn.Open()
        Try
            Dim comandos1 As SqlCommand
            comandos1 = New SqlCommand
            comandos1.Connection = cn
            comandos1.CommandText = "DELETE FROM [Datos cuentas bancarias proveedores]  WHERE IdenProveCB = @IdenProveCB and CodiBancoCB = @CodiBancoCB and NumCuenCB = @NumCuenCB "
            comandos1.CommandType = CommandType.Text
            With comandos1.Parameters
                .AddWithValue("@IdenProveCB", IdenProveCB)
                .AddWithValue("@CodiBancoCB", CodiBancoCB)
                .AddWithValue("@NumCuenCB", NumCuenCB)
            End With
            If comandos1.ExecuteNonQuery() Then
                MsgBox("Eliminacion Completada")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function

End Class
