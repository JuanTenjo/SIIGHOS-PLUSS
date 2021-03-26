Imports System.Data.SqlClient


Public Class CuentasBancariasProve
    Dim ClaseModelo As New ModulosDeClaseProvedor  'Instancia clase Modulos de clase
#Region "CargaCombobox"
    Public Sub cargacombobox()

        Try
            Dim DatosDeLosBancos As DataSet = SQLDataSET("SELECT NomBanco, CodiBanco FROM [GEOGRAXPSQL].[dbo].[Datos de los bancos]")
            cboBancos.DataSource = DatosDeLosBancos.Tables(0)
            cboBancos.DisplayMember = "NomBanco"
            cboBancos.ValueMember = "CodiBanco"
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar combobox cboBancos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Dim DatosTiposDeCuentasBancarias As DataSet = SQLDataSET("SELECT NomTipo, CodTipo FROM [GEOGRAXPSQL].[dbo].[Datos tipos cuentas bancarias]")
            cboTipoCuenta.DataSource = DatosTiposDeCuentasBancarias.Tables(0)
            cboTipoCuenta.DisplayMember = "NomTipo"
            cboTipoCuenta.ValueMember = "CodTipo"
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar combobox cboTipoCuenta" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub cargarlisbox()
        Dim Sql As String
        Dim cm As SqlCommand
        cn.Open()

        Sql = "select  dt.IdenProveCB + dt.NumCuenCB + dt.CodiBancoCB + dt.TipoCuenCB as id, tp.NomTipo + ' ' + dt.NumCuenCB + ' ' +  db.NomBanco as datosbanco
                from [GEOGRAXPSQL].[dbo].[Datos cuentas bancarias proveedores] as dt, 
                [GEOGRAXPSQL].[dbo].[Datos de los bancos] as db, 
                [GEOGRAXPSQL].[dbo].[Datos tipos cuentas bancarias] as tp 
                where  dt.CodiBancoCB = db.CodiBanco 
                and  dt.TipoCuenCB = tp.CodTipo
                and dt.IdenProveCB = '" & ModuloVariablesAplicacion.IdenProve & "'"


        cm = New SqlCommand()
        cm.CommandText = Sql
        cm.CommandType = CommandType.Text
        cm.Connection = cn
        Dim adapatador As New SqlDataAdapter(Sql, cn)
        Dim datos As New DataSet
        adapatador.Fill(datos)
        lblCuentasProvedor.DataSource = datos.Tables(0)
        lblCuentasProvedor.DisplayMember = "datosbanco"
        lblCuentasProvedor.ValueMember = "id"
        cn.Close()
    End Sub
#End Region
#Region "Funciones"
    Private Sub MostrarTexbox(identificador, NumeroCuenta)
        btnBorrarCuenta.Visible = True
        btnGuardarCue.Visible = False
        Try
            ' Obtenemos un objeto DataRow correspondiente con
            ' el ID escrito en un control TextBox
            '
            Dim row As DataRow = Buscar(identificador, NumeroCuenta)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")
                ' Abandonamos el procedimiento
                Return
            End If
            ' Rellenamos los correspondientes controles TextBox
            ' con los datos existentes en el objeto DataRow
            ' obtenido.
            '
            txtNumeroDeCuenta.Text = Convert.ToString(row("NumCuenCB"))
            txtObservacionesBanco.Text = Convert.ToString(row("ObservaCB"))
            cboTipoCuenta.SelectedValue = Convert.ToString(row("TipoCuenCB"))
            cboBancos.SelectedValue = Convert.ToString(row("CodiBancoCB"))
        Catch ex As Exception
            ' Se ha producido un error
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function Buscar(id, NumeroCuenta) As DataRow

        If (String.IsNullOrEmpty(id)) Then
            Throw New ArgumentNullException("id")
        End If

        ' Declaramos la variable que devolverá la función, que
        ' en principio indica que no existe ningún registro
        ' que coincida con el ID especificado.
        '
        Dim returnValue As DataRow = Nothing

        ' Creamos la conexión con la base de SQL Server.

        ' Creamos un objeto Command.
        Dim cmd As SqlCommand = cn.CreateCommand()

        ' Indicamos la consulta SQL de selección que deseamos ejecutar
        cmd.CommandText = "select  dt.CodiBancoCB, dt.NumCuenCB, dt.ObservaCB, dt.TipoCuenCB
                            from [GEOGRAXPSQL].[dbo].[Datos cuentas bancarias proveedores] As dt, 
                            [GEOGRAXPSQL].[dbo].[Datos de los bancos] as db, 
                            [GEOGRAXPSQL].[dbo].[Datos tipos cuentas bancarias] as tp 
                            where  dt.CodiBancoCB = db.CodiBanco 
                            And  dt.TipoCuenCB = tp.CodTipo
                            And dt.IdenProveCB = @id and dt.IdenProveCB + dt.NumCuenCB + dt.CodiBancoCB + dt.TipoCuenCB = @NumeroCuenta"

        ' Añadimos el único parámetro de entrada existente en la consulta
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@NumeroCuenta", NumeroCuenta)
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

    End Function
#End Region
#Region "Botones, Texbox y listbox"
    Private Sub BtnCerrarProvedores_Click(sender As Object, e As EventArgs) Handles BtnCerrarProvedores.Click
        ModuloVariablesAplicacion.IdenProve = ""
        ModuloVariablesAplicacion.TipoDocu = ""
        ModuloVariablesAplicacion.SucurProve = ""
        ModuloVariablesAplicacion.CodRegis = ""
        ModuloVariablesAplicacion.CodModi = ""
        Me.Close()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnBorrarCuenta.Visible = False
        btnGuardarCue.Visible = True
        txtNumeroDeCuenta.Clear()
        txtObservacionesBanco.Clear()
        cboBancos.SelectedIndex = 0
        cboTipoCuenta.SelectedIndex = 0
    End Sub
    Private Sub lblCuentasProvedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblCuentasProvedor.SelectedIndexChanged
        Try
            If ingreso = 0 Then
                Exit Sub
            End If
            Dim cadena As String = lblCuentasProvedor.SelectedValue
            MostrarTexbox(ModuloVariablesAplicacion.IdenProve, cadena)
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub txtNumeroDeCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroDeCuenta.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub btnGuardarCue_Click(sender As Object, e As EventArgs) Handles btnGuardarCue.Click
        Try
            If txtNumeroDeCuenta.Text = "" Or cboBancos.SelectedValue = 0 Or cboTipoCuenta.SelectedValue = 0 Then
                MsgBox("Te falta rellenar o seleccionar algunos campos importantes")
            Else
                If MsgBox("Seguro que desea Guardar esta cuenta", vbYesNo) = vbYes Then
                    Dim fechaActual As Date = Date.Now
                    ClaseModelo.AgregarCuentaBancaria(TipoDocu, IdenProve, SucurProve, cboBancos.SelectedValue, txtNumeroDeCuenta.Text, cboTipoCuenta.SelectedValue, txtObservacionesBanco.Text, CodRegis, fechaActual)
                    cargarlisbox()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnBorrarCuenta_Click(sender As Object, e As EventArgs) Handles btnBorrarCuenta.Click
        Try
            If MsgBox("Seguro que desea Eliminar esta cuenta", vbYesNo) = vbYes Then
                ClaseModelo.EliminarCuentaBancaria(IdenProve, cboBancos.SelectedValue, txtNumeroDeCuenta.Text)
                cargarlisbox()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

    Dim ingreso As Integer = 0
    Private Sub CuentasBancariasProve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Call conectarGeogebra()
            cargacombobox()
            cargarlisbox()
            Dim cadena As String = lblCuentasProvedor.SelectedValue 'no esta sirviendo porque np tiene cuentas 
            If cadena = "" Then
                MessageBox.Show("Actualmente no tiene cuentas registradas, agregale una!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnGuardarCue.Visible = True
                btnBorrarCuenta.Visible = False
                btnGuardarCue.Visible = True
                txtNumeroDeCuenta.Clear()
                txtObservacionesBanco.Clear()
                cboBancos.SelectedIndex = 0
                cboTipoCuenta.SelectedIndex = 0
            Else
                MostrarTexbox(ModuloVariablesAplicacion.IdenProve, cadena)
                ingreso = 1
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar formulario cuentas bancarias" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNumeroDeCuenta_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtNumeroDeCuenta.KeyPress

    End Sub
End Class