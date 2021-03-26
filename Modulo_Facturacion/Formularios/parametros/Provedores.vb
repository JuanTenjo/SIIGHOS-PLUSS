Imports System.Data.SqlClient

Public Class Provedores
    Dim ClaseModelo As New ModulosDeClaseProvedor  'Instancia clase Modulos de clase
    'Dim EscalaPantalla As New EscalaPantalla

#Region "ComboBox"

    Private Sub cboTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDocumento.SelectedIndexChanged
        If btnGuardar.Visible = True Then 'Si el boton de guardar esta visible adveritira cada vez que presione cc en cboTipo que registrara una persona natural y mostrara los campos correspondientes
            If ingreso = 1 Then
                If cboTipoDocumento.Text <> "NIT" Then
                    MsgBox("Ingresara una persona Natural")
                    TipoDePersona()
                Else
                    TipoDePersona()
                End If
            End If
        End If


    End Sub

    Private Sub ComboPais()
        CargaPaises(cboPais)
    End Sub

    Private Sub ComboDocumentosDeIdentidad()
        CargaDocumentosIdentidad(cboTipoDocumento)
        cboTipoDocumento.SelectedIndex = 2

    End Sub

    Private Sub ComboRegimenesTributarios()
        Try
            Dim DatosRegimenesTributarios As DataSet = SQLDataSET("SELECT NomRegim, CodRegim FROM [GEOGRAXPSQL].[dbo].[Datos regimenes tributarios]")
            cboRegimenTributario.DataSource = DatosRegimenesTributarios.Tables(0)
            cboRegimenTributario.DisplayMember = "NomRegim"
            cboRegimenTributario.ValueMember = "CodRegim"
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar combobox DatosRegimenesTributarios" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboDepartamentos()
        CargaDepartamentos(cboDpto, cboPais)
    End Sub

    Private Sub ComboCiudad()
        CargaCiudad(cboMunicipios, cboDpto)
    End Sub

    'Private Sub ComboCuentasContables()
    '    Try
    '        Dim TipoContrato As DataSet = SQLDataSET("SELECT NomCConIPS FROM [Datos ctas contables IPS] WHERE CueContaIPS Like '14%'")
    '        cboCuentasContables.DataSource = TipoContrato.Tables(0)
    '        cboCuentasContables.DisplayMember = "NomCConIPS"
    '    Catch ex As Exception
    '        Titulo01 = "Control de errores de ejecución"
    '        Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
    '        Informa += "Al cargar combobox cuentas contables" & Chr(13) & Chr(10)
    '        Informa += "Mensaje del error: " & ex.Message
    '        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub cboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPais.SelectedIndexChanged
        Try
            If ingreso = 1 Then
                ComboDepartamentos()
                ComboCiudad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboDpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDpto.SelectedIndexChanged
        Try
            If ingreso = 1 Then

                ComboCiudad()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboTipoProovedor()
        Try

            cboTipoProvedor.DataSource = Nothing
            cboTipoProvedor.Items.Clear()

            Dim TipoContrato As DataSet = SQLDataSET("SELECT NomRelComer, CodRelComer FROM [GEOGRAXPSQL].[dbo].[Datos relaciones comerciales] order by 1")
            cboTipoProvedor.DataSource = TipoContrato.Tables(0)
            cboTipoProvedor.DisplayMember = "NomRelComer"
            cboTipoProvedor.ValueMember = "CodRelComer"
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar combobox Tipo Provedor" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ObligacionesFiscales()
        Try

            cboObliFiscal1.DataSource = Nothing
            cboObliFiscal2.DataSource = Nothing


            Dim ObliFiscal1 As DataSet = SQLDataSET("SELECT [CodObliFiscal],[NomObliFiscal], NomObliFiscal + ' ' + CodObliFiscal as Display
                                                        FROM [GEOGRAXPSQL].[dbo].[Datos codificacion obligacion fiscal]
                                                        where TipoOblifiscal = 1 and HabilObliFiscal = 1 order by Display asc")
            cboObliFiscal1.DataSource = ObliFiscal1.Tables(0)
            cboObliFiscal1.DisplayMember = "Display"
            cboObliFiscal1.ValueMember = "CodObliFiscal"

            Dim ObliFiscal2 As DataSet = SQLDataSET("SELECT [CodObliFiscal],[NomObliFiscal], NomObliFiscal + ' ' + CodObliFiscal as Display
                                                        FROM [GEOGRAXPSQL].[dbo].[Datos codificacion obligacion fiscal]
                                                        where TipoOblifiscal = 2 and HabilObliFiscal = 1 order by Display asc")
            cboObliFiscal2.DataSource = ObliFiscal2.Tables(0)
            cboObliFiscal2.DisplayMember = "Display"
            cboObliFiscal2.ValueMember = "CodObliFiscal"


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar combobox de las obligaciones Fiscales" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




#End Region
#Region "Texbox"



    'Private Sub txtBuscarObliFiscal2_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        If String.IsNullOrWhiteSpace(txtBuscarObliFiscal2.Text) = False Then
    '            DataGridCodObliFiscal2.Rows.Clear()

    '            Dim reader As SqlDataReader

    '            reader = SQLReader("SELECT [CodObliFiscal],[NomObliFiscal]
    '                          FROM [GEOGRAXPSQL].[dbo].[Datos codificacion obligacion fiscal]
    '                          where TipoOblifiscal = 2 and HabilObliFiscal = 1 AND [CodObliFiscal] LIKE '%' +  '" & txtBuscarObliFiscal2.Text & "' + '%' OR [NomObliFiscal] LIKE '%' + '" & txtBuscarObliFiscal2.Text & "' + '%'  order by CodObliFiscal asc")

    '            If reader.HasRows = False Then
    '                cn.Close()
    '                Exit Sub
    '            Else
    '                While reader.Read()
    '                    DataGridCodObliFiscal2.Rows.Add(New String() {reader("CodObliFiscal"), reader("NomObliFiscal")})
    '                End While
    '                reader.Close()
    '                cn.Close()
    '            End If

    '        Else
    '            ObligacionFiscal2()
    '        End If
    '    Catch ex As Exception
    '        Titulo01 = "Control de errores de ejecución"
    '        Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
    '        Informa += "Al buscar obligacion fiscal" & Chr(13) & Chr(10)
    '        Informa += "Mensaje del error: " & ex.Message
    '        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub 'Buscar Obligaciones Fiscales tipo 2
    Private Sub txtNumeroDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroDocumento.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                txtDV.Text = digito_verificacion(txtNumeroDocumento.Text)
        End Select
    End Sub
    Private Sub txtNumeroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono3.KeyPress, txtTelefono2.KeyPress, txtTelefono.KeyPress, txtSucursal.KeyPress, txtPrefijo.KeyPress, txtPorcentageIva.KeyPress, txtNumeroDocumento.KeyPress, txtIdentidadDos.KeyPress, txtDV.KeyPress, txtCodigo3.KeyPress, txtCodigo2.KeyPress, txtCodigo1.KeyPress, txtCelularContacto.KeyPress, txtCelular.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub txtNombreModiPor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoNombre.KeyPress, txtSegundoApellido.KeyPress, txtRepresentanteLegal.KeyPress, txtPrimerNombre.KeyPress, txtPrimerApellido.KeyPress, txtNombreContacto.KeyPress, txtCargoContacto.KeyPress
        sololetras(e)

    End Sub
    Public Function ValidarRellenoDeCampos() As Boolean
        Try
            Dim estado As Boolean

            If cboTipoDocumento.SelectedIndex < 0 Then
                MsgBox("Seleccion un tipo de documento", MsgBoxStyle.Information, "Control de datos")
                Me.cboTipoDocumento.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtNumeroDocumento.Text) Then
                MsgBox("El campo de numero de identificacion esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtNumeroDocumento.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtDV.Text) Then
                MsgBox("El campo digito de verificacion esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtDV.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtSucursal.Text) Then
                MsgBox("El campo sucursal esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtSucursal.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtRazonSocial.Text) Then
                MsgBox("El campo razon social esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtRazonSocial.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(cboPais.Text) Then
                MsgBox("Seleccione un pais", MsgBoxStyle.Information, "Control de datos")
                Me.cboPais.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(cboDpto.Text) Then
                MsgBox("Seleccione un departamento", MsgBoxStyle.Information, "Control de datos")
                Me.cboDpto.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(cboMunicipios.Text) Then
                MsgBox("Seleccione un municipio", MsgBoxStyle.Information, "Control de datos")
                Me.cboMunicipios.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboTipoProvedor.SelectedIndex < 0 Then
                MsgBox("Seleccione el tipo de provedor", MsgBoxStyle.Information, "Control de datos")
                Me.cboTipoProvedor.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboReteiva.SelectedIndex < 0 Then
                MsgBox("Seleccione si aplica reteiva o no", MsgBoxStyle.Information, "Control de datos")
                Me.cboReteiva.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboReteica.SelectedIndex < 0 Then
                MsgBox("Seleccione si aplica reteica o no", MsgBoxStyle.Information, "Control de datos")
                Me.cboReteica.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtTelefono.Text) Or String.IsNullOrEmpty(Me.txtTelefono2.Text) Then
                MsgBox("Algun campo de los telefonos 1 0 2 esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtTelefono.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtCelular.Text) Then
                MsgBox("El campo celular esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtCelular.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboAutoRete.SelectedIndex < 0 Then
                MsgBox("Seleccione si aplica AutoReteCre o no", MsgBoxStyle.Information, "Control de datos")
                Me.cboAutoRete.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtDireccion.Text) Then
                MsgBox("El campo dirección esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtDireccion.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtEmail1.Text) Then
                MsgBox("El campo Email 1 no puede quedar vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtEmail1.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtRepresentanteLegal.Text) Then
                MsgBox("Algun campo representante legal esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtRepresentanteLegal.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboReteica.SelectedIndex < 0 Then
                MsgBox("Seleccione si un regimen tributario", MsgBoxStyle.Information, "Control de datos")
                Me.cboAutoRete.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            If String.IsNullOrEmpty(Me.txtNombreContacto.Text) Then
                MsgBox("El campo Nombre Contacto esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtNombreContacto.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrEmpty(Me.txtCargoContacto.Text) Then
                MsgBox("El campo Nombre Contacto esta vacio", MsgBoxStyle.Information, "Control de datos")
                Me.txtCargoContacto.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboTipoDocumento.Text <> "NIT" Then
                If String.IsNullOrEmpty(Me.txtPrimerNombre.Text) Then
                    MsgBox("El campo primer nombre esta vacio", MsgBoxStyle.Information, "Control de datos")
                    Me.txtPrimerNombre.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
                If String.IsNullOrEmpty(Me.txtSegundoNombre.Text) Then
                    MsgBox("El campo segundo nombre esta vacio", MsgBoxStyle.Information, "Control de datos")
                    Me.txtSegundoApellido.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If
                If String.IsNullOrEmpty(Me.txtPrimerApellido.Text) Then
                    MsgBox("El campo primer apellido esta vacio", MsgBoxStyle.Information, "Control de datos")
                    Me.txtPrimerApellido.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If

                Dim ContadorObliFiscal1 As Int32 = 0

                Dim ContadorObliFiscal2 As Int32 = 0

                For Each Fila2 In DataGridCodObliFiscal1.Rows

                    ContadorObliFiscal1 += 1

                Next

                For Each Fila In DataGridCodObliFiscal2.Rows

                    ContadorObliFiscal2 += 1

                Next


                If ContadorObliFiscal1 = 0 Then
                    MsgBox("No seleccionaste ninguna obligacion fiscal tipo 1 para este proveedor. Selecciona al menos una", MsgBoxStyle.Information, "Control de datos")
                    Me.DataGridCodObliFiscal1.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If

                If ContadorObliFiscal2 = 0 Then
                    MsgBox("No seleccionaste ninguna obligacion fiscal tipo 2 para este proveedor. Selecciona al menos una", MsgBoxStyle.Information, "Control de datos")
                    Me.DataGridCodObliFiscal2.Select()
                    estado = False
                    Return estado
                Else
                    estado = True
                End If

            End If
            Return estado
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton guardar de proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Private Sub txtPrimerNombre_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerNombre.TextChanged
        NombreAutomatico()
    End Sub

    Private Sub txtSegundoNombre_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoNombre.TextChanged
        NombreAutomatico()
    End Sub

    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged
        NombreAutomatico()
    End Sub

    Private Sub txtSegundoApellido_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoApellido.TextChanged
        NombreAutomatico()
    End Sub

#End Region
#Region "DataGridVIew y ListBox"

    Private Sub DataGridProveedores_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridProveedores.CurrentCellChanged
        Try
            MostrarDatosProveedor()
        Catch ex As Exception
            MsgBox("Hubo un error en el evento CurrentCellChanged de DataGridProveedores: ERRROR: " + ex.Message)
        End Try
    End Sub

    Private Sub MostrarDatosProveedorConDocu(Identificador)
        Try
            Alerta = True
            CambioDeBoton()

            Dim DatosProveedor As SqlDataReader = SQLReader("SELECT dn.Nombre01, dn.Nombre02, dn.Apellido01, dn.Apellido02, dt.*, [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados].CodigoDpto, [GEOGRAXPSQL].[dbo].[Datos de paises].CodiPais
                                                                 FROM [GEOGRAXPSQL].[dbo].[Datos proveedores] as dt left join [GEOGRAXPSQL].[dbo].[Datos personas naturales] as dn 
                                                                 on dt.IdenProve = dn.NumDoc INNER JOIN
                                                                 [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto] ON dt.CodCity = [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto].CodDptoCity INNER JOIN
                                                                 [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados] ON [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto].CodigoDpto = [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados].CodigoDpto INNER JOIN
                                                                 [GEOGRAXPSQL].[dbo].[Datos de paises] ON [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados].CodigoPais = [GEOGRAXPSQL].[dbo].[Datos de paises].CodiPais
                                                                 WHERE dt.TipoDocu + dt.IdenProve = '" & Identificador & "'")
            If DatosProveedor.HasRows Then
                DatosProveedor.Read()

                txtIdentidadDos.Text = Convert.ToString(DatosProveedor("IdenProveDos"))
                cboTipoProvedor.SelectedValue = Convert.ToString(DatosProveedor("TipoProvee"))
                cboAutoRete.Text = Convert.ToString(DatosProveedor("AutoReteCree"))
                cboAutoRete.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("AutoReteCree")) = True, 1, 0)
                cboReteiva.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("ApliRetIVA")) = True, 1, 0)
                cboReteica.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("ApliRetICA")) = True, 1, 0)
                cboRetencion.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("ApliRete")) = True, 1, 0)
                cboRegimenTributario.SelectedValue = Convert.ToString(DatosProveedor("RegiTri"))
                txtNombreContacto.Text = Convert.ToString(DatosProveedor("NomConta"))
                txtCargoContacto.Text = Convert.ToString(DatosProveedor("CarConta"))
                txtCelularContacto.Text = Convert.ToString(DatosProveedor("CelConta"))
                txtCodigo1.Text = Convert.ToString(DatosProveedor("CodActi01"))
                txtCodigo2.Text = Convert.ToString(DatosProveedor("CodActi02"))
                txtCodigo3.Text = Convert.ToString(DatosProveedor("CodActi03"))
                txtObservaciones.Text = Convert.ToString(DatosProveedor("ObserProvee"))
                txtWeb.Text = Convert.ToString(DatosProveedor("PagWebPro"))
                txtRepresentanteLegal.Text = Convert.ToString(DatosProveedor("NomReLegal"))
                txtPorcentageIva.Text = Convert.ToString(DatosProveedor("PorRetIVA"))
                txtPrefijo.Text = Convert.ToString(DatosProveedor("IndiTel"))
                txtRazonSocial.Text = Convert.ToString(DatosProveedor("razonSol"))
                cboTipoDocumento.Text = Convert.ToString(DatosProveedor("TipoDocu"))
                TipoDePersona()
                txtDV.Text = Convert.ToString(DatosProveedor("DigVeri"))
                txtSucursal.Text = Convert.ToString(DatosProveedor("SucurProv"))


                txtDireccion.Text = Convert.ToString(DatosProveedor("DireProve"))
                txtEmail1.Text = Convert.ToString(DatosProveedor("DirElectro"))
                txtEmail2.Text = Convert.ToString(DatosProveedor("DirElectro1"))
                txtTelefono.Text = Convert.ToString(DatosProveedor("TelProve1"))
                txtTelefono2.Text = Convert.ToString(DatosProveedor("TelProve2"))
                txtTelefono3.Text = Convert.ToString(DatosProveedor("TelProve3"))
                txtCelular.Text = Convert.ToString(DatosProveedor("TelProve2"))
                txtNumeroDocumento.Text = Convert.ToString(DatosProveedor("IdenProve"))
                txtPrimerNombre.Text = Convert.ToString(DatosProveedor("Nombre01"))
                txtSegundoNombre.Text = Convert.ToString(DatosProveedor("Nombre02"))
                txtPrimerApellido.Text = Convert.ToString(DatosProveedor("Apellido01"))
                txtSegundoApellido.Text = Convert.ToString(DatosProveedor("Apellido02"))
                ftRegis.Value = Convert.ToDateTime(DatosProveedor("FecRegis"))
                lblCodigoRegistro.Text = Convert.ToString(DatosProveedor("CodRegis"))
                lblCodiModiPor.Text = Convert.ToString(DatosProveedor("CodModi"))
                ftModi.Value = Convert.ToDateTime(DatosProveedor("FecModi"))
                IIf(Convert.ToBoolean(DatosProveedor("HabilPro")) = True, lblhabilitado.Visible = True And lblPendiente.Visible = False And EstadoActivo = 1, lblPendiente.Visible = True And lblhabilitado.Visible = False And EstadoActivo = 0)
                Dim CodiPais As String = Convert.ToString(DatosProveedor("CodiPais"))
                Dim CodiDepar As String = Convert.ToString(DatosProveedor("CodigoDpto"))
                Dim CodiMunicipio As String = Convert.ToString(DatosProveedor("CodCity"))

                cn.Close()  'CERRAMOS CONEXION AQUI PORQUE LAS SIGUIENTES FUNCIONES, SOLICITAN QUE LA CONEXION ESTE CERRADA

                cboPais.SelectedValue = CodiPais
                ingreso = 0
                ComboDepartamentos()

                cboDpto.SelectedValue = CodiDepar
                ComboCiudad()
                cboMunicipios.SelectedValue = CodiMunicipio

                ingreso = 1


                NombreUsuarioRegistro(lblCodigoRegistro.Text)
                NombreUsuarioModifico(lblCodiModiPor.Text)
                CargarObligacionesFiscales(Identificador)
                CargarlisboxCuentasBancarias()


            Else
                cn.Close()
                Exit Sub
            End If



        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de MostrarDatosProveedorConDocu " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarDatosProveedor()
        Try
            If DataGridProveedores.SelectedCells.Count <> 0 Then
                Alerta = True
                CambioDeBoton()

                Dim TipoDoc As String = DataGridProveedores.SelectedCells(0).Value.ToString()
                Dim NumDoc As String = DataGridProveedores.SelectedCells(1).Value.ToString()

                Dim Identificador As String = TipoDoc + NumDoc

                Dim DatosProveedor As SqlDataReader = SQLReader("SELECT dn.Nombre01, dn.Nombre02, dn.Apellido01, dn.Apellido02, dt.*, [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados].CodigoDpto, [GEOGRAXPSQL].[dbo].[Datos de paises].CodiPais
                                                                 FROM [GEOGRAXPSQL].[dbo].[Datos proveedores] as dt left join [GEOGRAXPSQL].[dbo].[Datos personas naturales] as dn 
                                                                 on dt.IdenProve = dn.NumDoc INNER JOIN
                                                                 [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto] ON dt.CodCity = [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto].CodDptoCity INNER JOIN
                                                                 [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados] ON [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto].CodigoDpto = [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados].CodigoDpto INNER JOIN
                                                                 [GEOGRAXPSQL].[dbo].[Datos de paises] ON [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados].CodigoPais = [GEOGRAXPSQL].[dbo].[Datos de paises].CodiPais
                                                                 WHERE dt.TipoDocu + dt.IdenProve = '" & Identificador & "'")
                If DatosProveedor.HasRows Then
                    DatosProveedor.Read()

                    txtIdentidadDos.Text = Convert.ToString(DatosProveedor("IdenProveDos"))
                    cboTipoProvedor.SelectedValue = Convert.ToString(DatosProveedor("TipoProvee"))
                    cboAutoRete.Text = Convert.ToString(DatosProveedor("AutoReteCree"))
                    cboAutoRete.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("AutoReteCree")) = True, 1, 0)
                    cboReteiva.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("ApliRetIVA")) = True, 1, 0)
                    cboReteica.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("ApliRetICA")) = True, 1, 0)
                    cboRetencion.SelectedIndex = IIf(Convert.ToBoolean(DatosProveedor("ApliRete")) = True, 1, 0)
                    cboRegimenTributario.SelectedValue = Convert.ToString(DatosProveedor("RegiTri"))
                    txtNombreContacto.Text = Convert.ToString(DatosProveedor("NomConta"))
                    txtCargoContacto.Text = Convert.ToString(DatosProveedor("CarConta"))
                    txtCelularContacto.Text = Convert.ToString(DatosProveedor("CelConta"))
                    txtCodigo1.Text = Convert.ToString(DatosProveedor("CodActi01"))
                    txtCodigo2.Text = Convert.ToString(DatosProveedor("CodActi02"))
                    txtCodigo3.Text = Convert.ToString(DatosProveedor("CodActi03"))
                    txtObservaciones.Text = Convert.ToString(DatosProveedor("ObserProvee"))
                    txtWeb.Text = Convert.ToString(DatosProveedor("PagWebPro"))
                    txtRepresentanteLegal.Text = Convert.ToString(DatosProveedor("NomReLegal"))
                    txtPorcentageIva.Text = Convert.ToString(DatosProveedor("PorRetIVA"))
                    txtPrefijo.Text = Convert.ToString(DatosProveedor("IndiTel"))
                    txtRazonSocial.Text = Convert.ToString(DatosProveedor("razonSol"))
                    cboTipoDocumento.Text = Convert.ToString(DatosProveedor("TipoDocu"))
                    TipoDePersona()
                    txtDV.Text = Convert.ToString(DatosProveedor("DigVeri"))
                    txtSucursal.Text = Convert.ToString(DatosProveedor("SucurProv"))


                    txtDireccion.Text = Convert.ToString(DatosProveedor("DireProve"))
                    txtEmail1.Text = Convert.ToString(DatosProveedor("DirElectro"))
                    txtEmail2.Text = Convert.ToString(DatosProveedor("DirElectro1"))
                    txtTelefono.Text = Convert.ToString(DatosProveedor("TelProve1"))
                    txtTelefono2.Text = Convert.ToString(DatosProveedor("TelProve2"))
                    txtTelefono3.Text = Convert.ToString(DatosProveedor("TelProve3"))
                    txtCelular.Text = Convert.ToString(DatosProveedor("TelProve2"))
                    txtNumeroDocumento.Text = Convert.ToString(DatosProveedor("IdenProve"))
                    txtPrimerNombre.Text = Convert.ToString(DatosProveedor("Nombre01"))
                    txtSegundoNombre.Text = Convert.ToString(DatosProveedor("Nombre02"))
                    txtPrimerApellido.Text = Convert.ToString(DatosProveedor("Apellido01"))
                    txtSegundoApellido.Text = Convert.ToString(DatosProveedor("Apellido02"))
                    ftRegis.Value = Convert.ToDateTime(DatosProveedor("FecRegis"))
                    lblCodigoRegistro.Text = Convert.ToString(DatosProveedor("CodRegis"))
                    lblCodiModiPor.Text = Convert.ToString(DatosProveedor("CodModi"))
                    ftModi.Value = Convert.ToDateTime(DatosProveedor("FecModi"))

                    lblhabilitado.Visible = IIf(Convert.ToBoolean(DatosProveedor("HabilPro")) = True, True, False)
                    lblPendiente.Visible = IIf(Convert.ToBoolean(DatosProveedor("HabilPro")) = False, True, False)

                    EstadoActivo = IIf(Convert.ToBoolean(DatosProveedor("HabilPro")) = True, 1, 0)



                    Dim CodiPais As String = Convert.ToString(DatosProveedor("CodiPais"))
                    Dim CodiDepar As String = Convert.ToString(DatosProveedor("CodigoDpto"))
                    Dim CodiMunicipio As String = Convert.ToString(DatosProveedor("CodCity"))

                    cn.Close()  'CERRAMOS CONEXION AQUI PORQUE LAS SIGUIENTES FUNCIONES, SOLICITAN QUE LA CONEXION ESTE CERRADA

                    cboPais.SelectedValue = CodiPais
                    ingreso = 0
                    ComboDepartamentos()

                    cboDpto.SelectedValue = CodiDepar
                    ComboCiudad()
                    cboMunicipios.SelectedValue = CodiMunicipio

                    ingreso = 1


                    NombreUsuarioRegistro(lblCodigoRegistro.Text)
                    NombreUsuarioModifico(lblCodiModiPor.Text)
                    CargarObligacionesFiscales(Identificador)
                    CargarlisboxCuentasBancarias()


                Else
                    cn.Close()
                    Exit Sub
                End If


            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de MOSTRAR TEXBOX los datos de los proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub  'Funcion para mostrar todos los provedoores La incial

    Private Sub BuscarDataGridView(text)
        Try

            DataGridProveedores.Rows.Clear()

            Dim Proveedores As SqlDataReader = SQLReader("SELECT [TipoDocu] ,[IdenProve] ,[DigVeri] ,[RazonSol] FROM [GEOGRAXPSQL].[dbo].[Datos proveedores] where IdenProve LIKE '" & text.ToString & "%' OR RazonSol LIKE '%" & text.ToString & "%' order by RazonSol asc")
            If Proveedores.HasRows Then
                While Proveedores.Read()
                    DataGridProveedores.Rows.Add(New String() {Proveedores("TipoDocu"), Proveedores("IdenProve"), Proveedores("DigVeri"), Proveedores("RazonSol")})
                End While
            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de cargar la busqueda de los proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub  'Funcion para mostrar un provvedor el especifico

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            soloMayusculas(txtBuscar)
            If Len(txtBuscar.Text) > 3 Then
                BuscarDataGridView(txtBuscar.Text)
            Else
                CardaDataGridViewProvedores()
            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el evento que envia a buscar" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'Define que cunado el texbox sea mayor a un caracter espiece a buscar con la funcion buscarlisbox

    Public Sub CargarlisboxCuentasBancarias()
        Try
            Dim Sql As String = "select  dt.IdenProveCB, dt.NumCuenCB, tp.NomTipo + ' ' + dt.NumCuenCB + ' ' +  db.NomBanco as datosbanco
                from [GEOGRAXPSQL].[dbo].[Datos cuentas bancarias proveedores] as dt, 
                [GEOGRAXPSQL].[dbo].[Datos de los bancos] as db, 
                [GEOGRAXPSQL].[dbo].[Datos tipos cuentas bancarias] as tp 
                where  dt.CodiBancoCB = db.CodiBanco 
                and  dt.TipoCuenCB = tp.CodTipo
                and dt.IdenProveCB = '" & txtNumeroDocumento.Text & "'"
            Dim CuentasBancarias As DataSet = SQLDataSET(Sql)
            lbxCuentasBancarias.DataSource = CuentasBancarias.Tables(0)
            lbxCuentasBancarias.DisplayMember = "datosbanco"
            lbxCuentasBancarias.ValueMember = "NumCuenCB"
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar lisbox cuentas bancarias." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'CargarlisboxCuentasBancarias

    Private Sub CargarObligacionesFiscales(identificador)
        Try

            DataGridCodObliFiscal1.Rows.Clear()
            DataGridCodObliFiscal2.Rows.Clear()

            Dim ObligacionesFiscales As SqlDataReader = SQLReader("SELECT deta.CodObliFiscal, obli.NomObliFiscal, deta.TipoOblifiscal 
                                                                   FROM [GEOGRAXPSQL].[dbo].[Datos detalle obligacion fiscal] as deta, [GEOGRAXPSQL].[dbo].[Datos codificacion obligacion fiscal] as obli
                                                                   WHERE deta.CodObliFiscal = obli.CodObliFiscal AND deta.TipoOblifiscal = obli.TipoOblifiscal AND  deta.TipoDocu + deta.NumDoc  = '" & identificador.ToString & "'")
            If ObligacionesFiscales.HasRows Then
                While ObligacionesFiscales.Read()
                    If ObligacionesFiscales("TipoOblifiscal") = 1 Then
                        DataGridCodObliFiscal1.Rows.Add(New String() {ObligacionesFiscales("CodObliFiscal"), ObligacionesFiscales("NomObliFiscal")})
                    ElseIf (ObligacionesFiscales("TipoOblifiscal") = 2) Then
                        DataGridCodObliFiscal2.Rows.Add(New String() {ObligacionesFiscales("CodObliFiscal"), ObligacionesFiscales("NomObliFiscal")})
                    End If
                End While
                cn.Close()
            Else
                cn.Close()
                Exit Sub
            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de cargar Obligaciones Fiscales" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub  'Carga DataFGrid ObliFiscales

    Private Sub CardaDataGridViewProvedores()
        Try

            DataGridProveedores.Rows.Clear()

            Dim Proveedores As SqlDataReader = SQLReader("SELECT [TipoDocu] ,[IdenProve] ,[DigVeri] ,[RazonSol] FROM [GEOGRAXPSQL].[dbo].[Datos proveedores] order by IdenProve asc")
            If Proveedores.HasRows Then
                While Proveedores.Read()
                    DataGridProveedores.Rows.Add(New String() {Proveedores("TipoDocu"), Proveedores("IdenProve"), Proveedores("DigVeri"), Proveedores("RazonSol")})
                End While
            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion de cargar los proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub 'CARGA DATAGRID PROVEEDORES

#End Region
#Region "Botones Y Funciones"


    Private Sub btnAgregarFiscal1_Click(sender As Object, e As EventArgs) Handles btnAgregarFiscal1.Click
        Try

            DataGridCodObliFiscal1.Rows.Add(New String() {cboObliFiscal1.SelectedValue, cboObliFiscal1.Text})

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton guardar ObliFiscal 1" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub  'Agrega a la grilla la oblgacion fiscal tipo 1

    Private Sub btnAgregarFiscal2_Click(sender As Object, e As EventArgs) Handles btnAgregarFiscal2.Click
        Try

            DataGridCodObliFiscal2.Rows.Add(New String() {cboObliFiscal2.SelectedValue, cboObliFiscal2.Text})

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton guardar ObliFiscal 1" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Agrega a la grilla la oblgacion fiscal tipo 2


    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If MsgBox("Exportaras a excel", vbYesNo) = vbYes Then
            Dim Datos As DataTable = New DataTable
            Datos = DataTable("
                                SELECT dp.TipoDocu, dp.IdenProve, dp.DigVeri, dp.SucurProv, dp.IdenProveDos,  dp.RazonSol, dr.NomRegim, dt.NomRelComer, dp.PaisProve,
                                dp.DptoProve, dp.CityProve, dp.CodCity, dp.DirElectro, dp.DirElectro1, dp.DirElectro2, dp.PagWebPro, dp.IndiTel, dp.TelProve1,
                                dp.TelProve2, dp.TelProve3, dp.NomConta, dp.CarConta, dp.NomConta, dp.CarConta, dp.CelConta, dp.HabilPro, DP.AutoReteCree, DP.ApliRete,
                                dp.ApliRetICA, dp.ApliRetIVA, dp.PorRetIVA, dp.CodActi01, dp.CodActi02, dp.CodActi03, dp.NomReLegal, dp.ObserProvee, dp.CodRegis, dp.FecRegis,
                                dp.CodModi, dp.FecModi
                                FROM  [GEOGRAXPSQL].[dbo].[Datos proveedores] as dp, [GEOGRAXPSQL].[dbo].[Datos regimenes tributarios] as dr, [GEOGRAXPSQL].[dbo].[Datos relaciones comerciales] as dt
                                where dp.RegiTri = dr.CodRegim and dp.TipoProvee = dt.CodRelComer")
            Dim SaveFileDialog As New SaveFileDialog
            Dim RutaName As String = ""
            SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            SaveFileDialog.Filter = "Text Files | *.xlsx"
            SaveFileDialog.DefaultExt = "xlsx"

            If (SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                RutaName = SaveFileDialog.FileName
            End If

            GenerarExcel(Datos, RutaName)
        End If

    End Sub 'Exporta a excel

    Private Sub BtnCerrarProvedores_Click(sender As Object, e As EventArgs) Handles BtnCerrarProvedores.Click
        Me.Dispose()
    End Sub  'Cierra el formulario

    Private Sub CambioDeBoton()
        If Alerta = True Then
            btnActualizar.Visible = True
            btnGuardar.Visible = False
            txtNumeroDocumento.ReadOnly = True
            cboTipoDocumento.Enabled = False
            txtDV.Enabled = False
            btnEliminar.Enabled = True
            'GroupRegis.Enabled = False
            'GroupModi.Enabled = True

        Else
            'GroupRegis.Enabled = True
            'GroupModi.Enabled = False
            btnGuardar.Visible = True
            btnActualizar.Visible = False
            txtNumeroDocumento.ReadOnly = False
            cboTipoDocumento.Enabled = True
            txtDV.Enabled = True
            btnEliminar.Enabled = False

        End If
    End Sub  'Define cuando se muetra el boton guardar, eliminar o actualizar

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarProvedores()

    End Sub 'Boton para establecer que se va a registrar un nuevo proveedor

    Public Sub limpiarProvedores()


        Dim fechaActual As Date = Date.Now
        ftModi.Value = fechaActual
        ftRegis.Value = fechaActual



        DataGridCodObliFiscal1.Rows.Clear()
        DataGridCodObliFiscal2.Rows.Clear()
        Alerta = False
        EstadoActivo = 0
        lbxCuentasBancarias.DataSource = Nothing
        CambioDeBoton()
        cboTipoDocumento.SelectedIndex = 2
        cboPais.SelectedIndex = 0
        cboAutoRete.SelectedIndex = 0
        cboReteiva.SelectedIndex = 0
        cboDpto.SelectedIndex = 0
        cboMunicipios.SelectedIndex = 0
        cboRegimenTributario.SelectedIndex = 0
        cboReteiva.SelectedIndex = 0
        txtWeb.Clear()
        txtPorcentageIva.Clear()
        txtNombreContacto.Clear()
        txtCargoContacto.Clear()
        txtCelularContacto.Clear()
        txtCodigo1.Clear()
        txtCodigo2.Clear()
        txtCodigo3.Clear()
        txtObservaciones.Clear()
        cboReteica.SelectedIndex = 0
        txtTelefono2.Clear()
        txtTelefono3.Clear()
        cboTipoProvedor.SelectedIndex = 0
        cboRetencion.SelectedIndex = 0
        txtObservaciones.Clear()
        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtNumeroDocumento.Clear()
        txtDV.Clear()
        txtSucursal.Clear()
        txtIdentidadDos.Clear()
        txtRazonSocial.Clear()
        txtPrefijo.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtDireccion.Clear()
        txtEmail1.Clear()
        txtEmail2.Clear()
        txtRepresentanteLegal.Clear()
        txtBuscar.Clear()
    End Sub  'Limpira todos los campos

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If ValidarRellenoDeCampos() Then
                If MsgBox("Seguro que desea guardar este registro", vbYesNo) = vbYes Then
                    Try

                        Dim fechaActual As Date = Date.Now
                        ClaseModelo.AgregarProvedor(cboTipoDocumento.Text, txtNumeroDocumento.Text, txtDV.Text, txtSucursal.Text, txtIdentidadDos.Text, txtRazonSocial.Text, cboRegimenTributario.SelectedValue, cboTipoProvedor.SelectedValue, cboPais.Text, cboDpto.Text, cboMunicipios.Text, cboMunicipios.SelectedValue, txtDireccion.Text,
                                               txtEmail1.Text, txtEmail2.Text, txtWeb.Text, txtPrefijo.Text, txtTelefono.Text, txtTelefono2.Text, txtTelefono3.Text, txtNombreContacto.Text, txtCargoContacto.Text, txtCelularContacto.Text,
                                                   1, cboAutoRete.SelectedIndex, cboRetencion.SelectedIndex, cboReteica.SelectedIndex, cboReteiva.SelectedIndex, txtPorcentageIva.Text, txtCodigo1.Text, txtCodigo2.Text, txtCodigo3.Text, txtRepresentanteLegal.Text,
                                                   txtObservaciones.Text, lblCodigoUsuario2.Text, Format(fechaActual, "yyyy/MM/dd"), txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, DataGridCodObliFiscal1, DataGridCodObliFiscal2)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    MostrarDatosProveedor()
                End If
            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton guardar de proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Guarda Proveedor 

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If ValidarRellenoDeCampos() Then
                If MsgBox("Seguro que desea Actualizar este registro", vbYesNo) = vbYes Then
                    Try
                        Dim fechaActual As Date = Date.Now
                        ClaseModelo.ActualizarProvedor(cboTipoDocumento.Text, txtNumeroDocumento.Text, txtDV.Text, txtSucursal.Text, txtIdentidadDos.Text, txtRazonSocial.Text, cboRegimenTributario.SelectedValue, cboTipoProvedor.SelectedValue, cboPais.Text, cboDpto.Text, cboMunicipios.Text, cboMunicipios.SelectedValue, txtDireccion.Text,
                                               txtEmail1.Text, txtEmail2.Text, txtWeb.Text, txtPrefijo.Text, txtTelefono.Text, txtTelefono2.Text, txtTelefono3.Text, txtNombreContacto.Text, txtCargoContacto.Text, txtCelularContacto.Text,
                                                   EstadoActivo.ToString, cboAutoRete.SelectedIndex, cboRetencion.SelectedIndex, cboReteica.SelectedIndex, cboReteiva.SelectedIndex, txtPorcentageIva.Text, txtCodigo1.Text, txtCodigo2.Text, txtCodigo3.Text, txtRepresentanteLegal.Text,
                                                   txtObservaciones.Text, lblCodigoUsuario2.Text, Format(fechaActual, "yyyy/MM/dd"), txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, DataGridCodObliFiscal1, DataGridCodObliFiscal2)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    MostrarDatosProveedor()
                End If
            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton actualizar de proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Actualiza proveedor

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (txtNumeroDocumento.Text = "") Then
                MsgBox("Digite un numero de identificacion")
            Else
                If MsgBox("Seguro que desea Eliminar este registro", vbYesNo) = vbYes Then
                    ClaseModelo.EliminarProve(cboTipoDocumento.Text, txtNumeroDocumento.Text)
                    limpiarProvedores()
                    MostrarDatosProveedor()
                End If
            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton eliminar de proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Elimina proveedor

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        If lblhabilitado.Visible = True Then
            lblhabilitado.Visible = False
            lblPendiente.Visible = True
            EstadoActivo = 0

        ElseIf lblhabilitado.Visible = False Then
            lblPendiente.Visible = False
            lblhabilitado.Visible = True
            EstadoActivo = 1
        Else
            MsgBox("Provedor no habilitado, no desabilitado")
        End If
    End Sub  'Define si el provedor esta activo o inactivo


    Private Sub NombreUsuarioRegistro(codigo)
        Try
            Dim UserLogeado As SqlDataReader = SQLReader("select NombreUsa + Apellido1Usa as usuario from [DATUSIIGXPSQL].[dbo].[Datos usuarios de los aplicativos] where CodigoUsa = '" & codigo.ToString & "' ")
            If UserLogeado.HasRows = False Then
                MsgBox("No se encontro el nombre del usuairo que registro este proveedor en la base de datos")
                cn.Close()
            Else
                UserLogeado.Read()
                lblNameRegisPor.Text = UserLogeado("usuario")
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el nombre del usuario que registro " + ex.Message)
        End Try
    End Sub  'Funcion que trae nombre del usuario que registro

    Private Sub NombreUsuarioModifico(codigo)
        Try
            Dim UserLogeado As SqlDataReader = SQLReader("select NombreUsa + Apellido1Usa as usuario from [DATUSIIGXPSQL].[dbo].[Datos usuarios de los aplicativos] where CodigoUsa = '" & codigo.ToString & "' ")
            If UserLogeado.HasRows = False Then
                MsgBox("No se encontro el nombre de este usuario en la base de datos")
                cn.Close()
            Else
                UserLogeado.Read()
                lblNameModiPor.Text = UserLogeado("usuario")
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el nombre del usuario que modifico" + ex.Message)
        End Try
    End Sub 'Funcion que trae nombre del usuario que modifico

    Private Sub TipoDePersona()
        If cboTipoDocumento.Text <> "NIT" Then




            lblPrimerApellido.Visible = True
            lblSegundoApellido.Visible = True
            lblPrimerNombre.Visible = True
            lblSegundoNombre.Visible = True
            txtPrimerNombre.Visible = True
            txtSegundoNombre.Visible = True
            txtPrimerApellido.Visible = True
            txtSegundoApellido.Visible = True
            lblPersonaNatural.Visible = True
            lblPersonaJuridica.Visible = False
        Else
            lblPersonaNatural.Visible = False
            lblPersonaJuridica.Visible = True
            lblPrimerApellido.Visible = False
            lblSegundoApellido.Visible = False
            lblPrimerNombre.Visible = False
            lblSegundoNombre.Visible = False
            txtPrimerNombre.Visible = False
            txtSegundoNombre.Visible = False
            txtPrimerApellido.Visible = False
            txtSegundoApellido.Visible = False
        End If
    End Sub  'Define opciones para una persona natural o una persona juridica

    Private Sub btnBuscaPorNit_Click(sender As Object, e As EventArgs) Handles btnBuscaPorNit.Click
        Dim nit As String
        nit = InputBox("Ingrese tipo de documento y el numero de documento pegado. Ejemplo: CC**********")
        If String.IsNullOrWhiteSpace(nit) Then
            MsgBox("Operacion Cancelada")
        Else
            MostrarDatosProveedorConDocu(nit)
        End If
    End Sub   'Bucar el provedor por el nit en un inputbox

    Private Sub CargarUsuarioLogeado()
        Try
            lblNombreUsuario.Text = ModuloVariablesAplicacion.NombreUsuarioLogeado
            lblCodigoUsuario2.Text = ModuloVariablesAplicacion.CodigUsar
        Catch ex As Exception
            MsgBox("Hubo un error al cargar el usuario: ERRROR: " + ex.Message)
        End Try
    End Sub

    Private Sub btnaAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnaAgregarCuenta.Click
        If btnActualizar.Visible = True Then
            Try
                Dim cargavariables As Int32 = 0
                ModuloVariablesAplicacion.IdenProve = txtNumeroDocumento.Text
                ModuloVariablesAplicacion.TipoDocu = cboTipoDocumento.Text
                ModuloVariablesAplicacion.SucurProve = txtSucursal.Text
                ModuloVariablesAplicacion.CodRegis = lblCodigoRegistro.Text
                ModuloVariablesAplicacion.CodModi = lblCodiModiPor.Text
                cargavariables = 1
                If cargavariables = 1 Then

                    If (ModuloVariablesAplicacion.IdenProve = "" Or ModuloVariablesAplicacion.SucurProve = "" Or ModuloVariablesAplicacion.TipoDocu = "") Then
                        MsgBox("El campo de identidad o sucursal esta vacio")
                    Else
                        CuentasBancariasProve.ShowDialog()
                        CargarlisboxCuentasBancarias()
                    End If
                Else
                    MsgBox("Espere un momento")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Primero debes registrar el proveedor y luego podras añadirle las cuentas bancarias")
        End If


    End Sub 'Cargar formulario cuentas bancarias

    Private Sub NombreAutomatico()
        Try
            txtRazonSocial.Text = txtPrimerNombre.Text + " " + txtSegundoNombre.Text + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text
        Catch ex As Exception
            MsgBox("Hubo un error en la actualizacion automatica del nombre. ERRROR: " + ex.Message)
        End Try
    End Sub  'Cuando la persona es natural, actualiza automaticamente la Razon Social


#End Region

    Dim Alerta As Boolean = False
    Dim ingreso As Integer = 0
    Dim EstadoActivo As Integer = 1

    Private Sub Provedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CardaDataGridViewProvedores()
            CargarUsuarioLogeado()
            ComboDocumentosDeIdentidad()
            ComboRegimenesTributarios()
            ComboPais()
            ComboDepartamentos()
            ComboCiudad()
            ComboTipoProovedor()
            CambioDeBoton()
            ObligacionesFiscales()
            If DataGridProveedores.Rows.Count > 0 Then
                MostrarDatosProveedor()
                CargarlisboxCuentasBancarias()
                ingreso = 1 'Evalua que ya se cargaron las funciones anteriores
            Else
                MsgBox("No existes clientes ni proveedores")
                ingreso = 1
            End If
        Catch ex As Exception
            MsgBox("Hubo un error en el programa: ERRROR: " + ex.Message)
        End Try
    End Sub


End Class