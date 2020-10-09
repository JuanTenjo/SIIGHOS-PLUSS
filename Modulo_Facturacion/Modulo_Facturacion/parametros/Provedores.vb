Imports System.Data.SqlClient

Public Class Provedores
    Dim ClaseModelo As New ModulosDeClaseProvedor  'Instancia clase Modulos de clase
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
        Call conectarGeogebra()
        Try
            Dim adapatador As New SqlDataAdapter("SELECT NomRegim, CodRegim FROM [Datos regimenes tributarios]", cn)
            Dim datos As New DataSet
            datos.Tables.Add("[Datos regimenes tributarios]")
            adapatador.Fill(datos.Tables("[Datos regimenes tributarios]"))
            cboRegimenTributario.DataSource = datos.Tables("[Datos regimenes tributarios]")
            cboRegimenTributario.DisplayMember = "NomRegim"
            cboRegimenTributario.ValueMember = "CodRegim"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
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

    Private Sub ComboRelacionesComerciales()
        Try
            Dim TipoContrato As DataSet = SQLDataSET("SELECT NomRelComer, CodRelComer FROM [Datos relaciones comerciales]")
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

#End Region
#Region "Texbox"
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
            If cboPais.SelectedIndex < 0 Then
                MsgBox("Seleccione un pais", MsgBoxStyle.Information, "Control de datos")
                Me.cboPais.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboDpto.SelectedIndex <= 0 Then
                MsgBox("Seleccione un departamento", MsgBoxStyle.Information, "Control de datos")
                Me.cboDpto.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboMunicipios.SelectedIndex < 0 Then
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
            If String.IsNullOrEmpty(Me.txtEmail1.Text) Or String.IsNullOrEmpty(Me.txtEmail2.Text) Then
                MsgBox("Algun campo del Email 1 o 2 esta vacio", MsgBoxStyle.Information, "Control de datos")
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
#End Region
#Region "ListBox"
    Private Sub listarLisbox(consulta)
        Try
            Dim exitoso As Boolean = False
            cn.Open()
            Dim Sql As String
            Dim cm As SqlCommand

            Sql = consulta
            cm = New SqlCommand()
            cm.CommandText = Sql
            cm.CommandType = CommandType.Text
            cm.Connection = cn
            If cm.ExecuteNonQuery() Then
                exitoso = True
            Else
                MsgBox("No hay clientes/proveedores")
            End If

            cn.Close()

            If exitoso Then
                Dim adapatador As New SqlDataAdapter(consulta, cn)
                Dim datos As New DataSet
                adapatador.Fill(datos)
                lista.DataSource = datos.Tables(0)
                lista.DisplayMember = "nomProv"
                lista.ValueMember = "idenprove"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub  'Rellena el lisbox, el parametro es la consulta que lo llenara

    Private Sub MostrarLisbox()
        Dim consulta As String
        consulta = "Select idenprove, tipodocu + ' ' + idenprove + ' ' + razonsol as nomProv FROM [GEOGRAXPSQL].[dbo].[Datos proveedores]"
        listarLisbox(consulta)
    End Sub  'Funcion para mostrar todos los provedoores La incial

    Private Sub BuscarLisbox()
        Dim consulta As String
        consulta = "SELECT idenprove, tipodocu + ' ' + idenprove + ' ' + razonsol as nomProv FROM [Datos proveedores] WHERE RazonSol like '%'+'" & txtBuscar.Text & "'+'%' OR IdenProve Like '%'+'" & txtBuscar.Text & "'+'%'"
        listarLisbox(consulta)
    End Sub  'Funcion para mostrar un provvedor el especifico

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        soloMayusculas(txtBuscar)
        If Len(txtBuscar.Text) > 1 Then
            BuscarLisbox()
        Else
            MostrarLisbox()
        End If
    End Sub  'Define que cunado el texbox sea mayor a un caracter espiece a buscar con la funcion buscarlisbox

    Private Function Buscar(id As String) As DataRow

        Try
            If (String.IsNullOrEmpty(id)) Then
                Throw New ArgumentNullException("id")
            End If

            ' Declaramos la variable que devolverá la función, que
            ' en principio indica que no existe ningún registro
            ' que coincida con el ID especificado.
            '
            Dim returnValue As DataRow = Nothing

            ' Creamos la conexión con la base de SQL Server.


            Call conectarGeogebra()

            ' Creamos un objeto Command.
            Dim cmd As SqlCommand = cn.CreateCommand()

            ' Indicamos la consulta SQL de selección que deseamos ejecutar
            cmd.CommandText = "SELECT dn.Nombre01, dn.Nombre02, dn.Apellido01, dn.Apellido02, dt.*  
                            FROM [Datos proveedores] as dt left join [Datos personas naturales] as dn 
                            on dt.IdenProve = dn.NumDoc
                            WHERE dt.IdenProve = @id"

            ' Añadimos el único parámetro de entrada existente en la consulta
            cmd.Parameters.AddWithValue("@id", id)

            ' Creamos el adaptador de datos al que le pasamos el objeto Command.
            Dim da As New SqlDataAdapter(cmd)

            ' Intentamos rellenar un objeto DataTable como resultado
            ' de ejecutar la consulta SQL de selección especificada.
            '
            Using dt As New DataTable()

                da.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    ' Nos quedamos con la primera fila u objeto DataRow.
                    '
                    returnValue = dt.Rows(0)
                End If

            End Using

            cn.Close()

            ' Devolvemos el objeto DataRow obtenido.
            '
            Return returnValue
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion buscar proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try



    End Function  'Busca en el lisbox la fila seleccionada y cargar el valuemeber 

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        Try
            If ingreso = 0 Then
                Exit Sub
            End If
            Dim cadena As String = lista.SelectedValue
            MostrarTexbox(cadena)
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub  'Busca cada vez que se cambie el items del lisbox

    Public Sub CargarlisboxCuentasBancarias()
        Try
            Dim Sql As String = "select  dt.IdenProveCB, dt.NumCuenCB, tp.NomTipo + ' ' + dt.NumCuenCB + ' ' +  db.NomBanco as datosbanco
                from [Datos cuentas bancarias proveedores] as dt, 
                [Datos de los bancos] as db, 
                [Datos tipos cuentas bancarias] as tp 
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

#End Region
#Region "Botones Y Funciones"

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If MsgBox("Exportaras a excel", vbYesNo) = vbYes Then
            Dim Datos As DataTable = New DataTable
            Datos = DataTable("
                                SELECT dp.TipoDocu, dp.IdenProve, dp.DigVeri, dp.SucurProv, dp.IdenProveDos,  dp.RazonSol, dr.NomRegim, dt.NomRelComer, dp.PaisProve,
                                dp.DptoProve, dp.CityProve, dp.CodCity, dp.DirElectro, dp.DirElectro1, dp.DirElectro2, dp.PagWebPro, dp.IndiTel, dp.TelProve1,
                                dp.TelProve2, dp.TelProve3, dp.NomConta, dp.CarConta, dp.NomConta, dp.CarConta, dp.CelConta, dp.HabilPro, DP.AutoReteCree, DP.ApliRete,
                                dp.ApliRetICA, dp.ApliRetIVA, dp.PorRetIVA, dp.CodActi01, dp.CodActi02, dp.CodActi03, dp.NomReLegal, dp.ObserProvee, dp.CodRegis, dp.FecRegis,
                                dp.CodModi, dp.FecModi
                                FROM  [Datos proveedores] as dp, [Datos regimenes tributarios] as dr, [Datos relaciones comerciales] as dt
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
        Me.Close()
    End Sub  'Cierra el formulario

    Private Sub CambioDeBoton()
        If Alerta = True Then
            btnActualizar.Visible = True
            btnGuardar.Visible = False
            txtNumeroDocumento.Enabled = False
            cboTipoDocumento.Enabled = False
            txtDV.Enabled = False
            btnEliminar.Enabled = True
            GroupRegis.Enabled = False
            GroupModi.Enabled = True

        Else
            GroupRegis.Enabled = True
            GroupModi.Enabled = False
            btnGuardar.Visible = True
            btnActualizar.Visible = False
            txtNumeroDocumento.Enabled = True
            cboTipoDocumento.Enabled = True
            txtDV.Enabled = True
            btnEliminar.Enabled = False

        End If
    End Sub  'Define cuando se muetra el boton guardar, eliminar o actualizar

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarProvedores()

    End Sub 'Boton para establecer que se va a registrar un nuevo provedor

    Public Sub limpiarProvedores()
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
        txtCodifoModiPor.Clear()
        txtCodigoRegistro.Clear()
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
                        ClaseModelo.AgregarProvedor(cboTipoDocumento.Text, txtNumeroDocumento.Text, txtDV.Text, txtSucursal.Text, txtIdentidadDos.Text, txtRazonSocial.Text, cboRegimenTributario.SelectedValue, cboTipoProvedor.SelectedValue, cboPais.Text, cboDpto.Text, cboMunicipios.Text, txtDireccion.Text,
                                               txtEmail1.Text, txtEmail2.Text, txtWeb.Text, txtPrefijo.Text, txtTelefono.Text, txtTelefono2.Text, txtTelefono3.Text, txtNombreContacto.Text, txtCargoContacto.Text, txtCelularContacto.Text,
                                                   EstadoActivo, cboAutoRete.SelectedIndex, cboRetencion.SelectedIndex, cboReteica.SelectedIndex, cboReteiva.SelectedIndex, txtPorcentageIva.Text, txtCodigo1.Text, txtCodigo2.Text, txtCodigo3.Text, txtRepresentanteLegal.Text,
                                                   txtObservaciones.Text, txtCodigoRegistro.Text, fechaActual, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    MostrarLisbox()
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
                        ClaseModelo.ActualizarProvedor(cboTipoDocumento.Text, txtNumeroDocumento.Text, txtDV.Text, txtSucursal.Text, txtIdentidadDos.Text, txtRazonSocial.Text, cboRegimenTributario.SelectedValue, cboTipoProvedor.SelectedValue, cboPais.Text, cboDpto.Text, cboMunicipios.Text, txtDireccion.Text,
                                               txtEmail1.Text, txtEmail2.Text, txtWeb.Text, txtPrefijo.Text, txtTelefono.Text, txtTelefono2.Text, txtTelefono3.Text, txtNombreContacto.Text, txtCargoContacto.Text, txtCelularContacto.Text,
                                                   EstadoActivo.ToString, cboAutoRete.SelectedIndex, cboRetencion.SelectedIndex, cboReteica.SelectedIndex, cboReteiva.SelectedIndex, txtPorcentageIva.Text, txtCodigo1.Text, txtCodigo2.Text, txtCodigo3.Text, txtRepresentanteLegal.Text,
                                                   txtObservaciones.Text, txtCodifoModiPor.Text, fechaActual, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    MostrarLisbox()
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
                    MostrarLisbox()
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

    Private Sub MostrarTexbox(identificador)
        Alerta = True
        CambioDeBoton()
        Try
            ' Obtenemos un objeto DataRow correspondiente con
            ' el ID escrito en un control TextBox
            '
            Dim row As DataRow = Buscar(identificador)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")
                ' Abandonamos el procedimiento
                Return
            End If

            ' Rellenamos los correspondientes controles TextBox
            ' con los datos existentes en el objeto DataRow
            ' obtenido.
            '



            txtIdentidadDos.Text = Convert.ToString(row("IdenProveDos"))
            cboTipoProvedor.SelectedValue = Convert.ToString(row("TipoProvee"))
            cboAutoRete.Text = Convert.ToString(row("AutoReteCree"))
            cboRegimenTributario.SelectedValue = Convert.ToString(row("RegiTri"))
            txtCodifoModiPor.Text = Convert.ToString(row("CodModi"))
            txtCodigoRegistro.Text = Convert.ToString(row("CodRegis"))
            txtNombreContacto.Text = Convert.ToString(row("NomConta"))
            txtCargoContacto.Text = Convert.ToString(row("CarConta"))
            txtCelularContacto.Text = Convert.ToString(row("CelConta"))
            txtCodigo1.Text = Convert.ToString(row("CodActi01"))
            txtCodigo2.Text = Convert.ToString(row("CodActi02"))
            txtCodigo3.Text = Convert.ToString(row("CodActi03"))
            txtObservaciones.Text = Convert.ToString(row("ObserProvee"))

            txtWeb.Text = Convert.ToString(row("PagWebPro"))
            txtRepresentanteLegal.Text = Convert.ToString(row("NomReLegal"))
            txtPorcentageIva.Text = Convert.ToString(row("PorRetIVA"))
            txtPrefijo.Text = Convert.ToString(row("IndiTel"))
            txtRazonSocial.Text = Convert.ToString(row("razonSol"))
            cboTipoDocumento.Text = Convert.ToString(row("TipoDocu"))
            TipoDePersona()
            txtDV.Text = Convert.ToString(row("DigVeri"))
            txtSucursal.Text = Convert.ToString(row("SucurProv"))
            cboPais.Text = Convert.ToString(row("PaisProve"))
            cboDpto.Text = Convert.ToString(row("DptoProve"))
            cboMunicipios.Text = Convert.ToString(row("CityProve"))
            txtDireccion.Text = Convert.ToString(row("DireProve"))
            txtEmail1.Text = Convert.ToString(row("DirElectro"))
            txtEmail2.Text = Convert.ToString(row("DirElectro1"))
            txtTelefono.Text = Convert.ToString(row("TelProve1"))
            txtTelefono2.Text = Convert.ToString(row("TelProve2"))
            txtTelefono3.Text = Convert.ToString(row("TelProve3"))
            txtCelular.Text = Convert.ToString(row("TelProve2"))
            txtNumeroDocumento.Text = Convert.ToString(row("IdenProve"))
            txtPrimerNombre.Text = Convert.ToString(row("Nombre01"))
            txtSegundoNombre.Text = Convert.ToString(row("Nombre02"))
            txtPrimerApellido.Text = Convert.ToString(row("Apellido01"))
            txtSegundoApellido.Text = Convert.ToString(row("Apellido02"))

            txtCodigoRegistro.Text = Convert.ToString(row("CodRegis"))
            ftRegis.Value = Convert.ToDateTime(row("FecRegis"))
            txtCodifoModiPor.Text = Convert.ToString(row("CodRegis"))
            ftModi.Value = Convert.ToDateTime(row("FecModi"))


            CargarlisboxCuentasBancarias()
            If Convert.ToString(row("HabilPro")) = True Then
                lblhabilitado.Visible = True
                lblPendiente.Visible = False
                EstadoActivo = 1
            Else
                lblhabilitado.Visible = False
                lblPendiente.Visible = True
                EstadoActivo = 0
            End If

            If Convert.ToString(row("ApliRetIVA")) = True Then
                cboReteiva.SelectedIndex = 1
            Else
                cboReteiva.SelectedIndex = 0
            End If
            If Convert.ToString(row("ApliRetICA")) = True Then
                cboReteica.SelectedIndex = 1
            Else
                cboReteica.SelectedIndex = 0
            End If
            If Convert.ToString(row("ApliRete")) = True Then
                cboRetencion.SelectedIndex = 1
            Else
                cboRetencion.SelectedIndex = 0
            End If
            If Convert.ToString(row("ApliRete")) = True Then
                cboRetencion.SelectedIndex = 1
            Else
                cboRetencion.SelectedIndex = 0
            End If
            If Convert.ToString(row("AutoReteCree")) = True Then
                cboAutoRete.SelectedIndex = 1
            Else
                cboAutoRete.SelectedIndex = 0
            End If
        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion mostrar proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub   ',Muestra en los texbox la seleccion del lisbox

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
        nit = InputBox("Ingrese Nit o documento a buscar")
        If nit = "" Then
            MsgBox("Operacion Cancelada")
        Else
            MostrarTexbox(nit)
        End If
    End Sub   'Bucar el provedor por el nit en un inputbox

    Private Sub btnaAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnaAgregarCuenta.Click
        Try
            Dim cargavariables As Int32 = 0
            ModuloVariablesAplicacion.IdenProve = txtNumeroDocumento.Text
            ModuloVariablesAplicacion.TipoDocu = cboTipoDocumento.Text
            ModuloVariablesAplicacion.SucurProve = txtSucursal.Text
            ModuloVariablesAplicacion.CodRegis = txtCodigoRegistro.Text
            ModuloVariablesAplicacion.CodModi = txtCodifoModiPor.Text
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

    End Sub 'Cargar formulario cuentas bancarias

#End Region
    Dim Alerta As Boolean = False
    Dim ingreso As Integer = 0
    Dim EstadoActivo As Integer
    Private Sub Provedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ComboDocumentosDeIdentidad()
            ComboRegimenesTributarios()
            ComboPais()
            ComboDepartamentos()
            ComboCiudad()
            ComboRelacionesComerciales()
            CambioDeBoton()
            MostrarLisbox()
            If lista.Items.Count > 0 Then
                Dim cadena As String = lista.SelectedValue
                MostrarTexbox(cadena)
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