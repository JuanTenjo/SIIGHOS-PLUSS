Imports System.Data.SqlClient


Public Class CodigosProductos


    Dim ModuloDeClaseUtilidades As New ModuloDeClaseUtilidades


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            btnGuardar.Visible = True
            btnActualizar.Visible = False
            btnEliminarCodigo.Enabled = False
            LimpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LimpiarCampos()
        Try

            txtNombreCodigo.Clear()
            cboClasificacion.SelectedIndex = 0
            txtValorTarifa.Clear()
            txtPorceIVA.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarCombobox()
        Try
            Dim ClasificacionProductos As DataSet = SQLDataSET("SELECT NomClasPS,CodClasPS FROM [Datos clasificacion producservicios]")
            cboClasificacion.DataSource = ClasificacionProductos.Tables(0)
            cboClasificacion.DisplayMember = "NomClasPS"
            cboClasificacion.ValueMember = "CodClasPS"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarDatos()
        Try
            DataGridCodigosModulos.Rows.Clear()

            Dim consulta As String = "SELECT cp.CodProSer, cp.NomProSer, dcp.NomClasPS, dcp.CodClasPS, cp.ValTarifa, cp.PorcIVA FROM [Datos catalogo de producservicios] as cp, [Datos clasificacion producservicios] as dcp WHERE cp.ClasiProSer = dcp.CodClasPS"
            Dim reader As SqlDataReader = SQLReader(consulta)
            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridCodigosModulos.Rows.Add(reader("CodProSer"), reader("NomProSer"), reader("NomClasPS"), reader("ValTarifa"), reader("PorcIVA"), reader("CodClasPS"))
                End While
            End If
            reader.Close()
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargasr Codigos en la grilla" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridCodigosModulos_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridCodigosModulos.CurrentCellChanged
        If DataGridCodigosModulos.SelectedCells.Count <> 0 Then
            btnActualizar.Visible = True
            btnGuardar.Visible = False
            btnEliminarCodigo.Enabled = True
            txtNombreCodigo.Text = DataGridCodigosModulos.SelectedCells(1).Value.ToString()
            cboClasificacion.SelectedValue = DataGridCodigosModulos.SelectedCells(5).Value
            txtValorTarifa.Text = DataGridCodigosModulos.SelectedCells(3).Value.ToString()
            txtPorceIVA.Text = DataGridCodigosModulos.SelectedCells(4).Value.ToString()
        End If
    End Sub

    Private Sub CargarUsuarioLogeado()
        Try
            lblNombreUsuario.Text = ModuloVariablesAplicacion.NombreUsuarioLogeado
            lblCodigoUsuario2.Text = ModuloVariablesAplicacion.CodigUsar
        Catch ex As Exception
            MsgBox("Hubo un error al cargar el usuario: ERRROR: " + ex.Message)
        End Try
    End Sub

    Private Sub CodigosProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarUsuarioLogeado()
            cargarDatos()
            CargarCombobox()

        Catch ex As Exception

        End Try
    End Sub

    Public Function ValidarCampos() As Boolean
        Try
            Dim estado As Boolean




            If cboClasificacion.SelectedIndex < 0 Then
                MsgBox("Seleccion una clasificacion ", MsgBoxStyle.Information, "Control de datos")
                Me.cboClasificacion.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If cboClasificacion.SelectedIndex < 0 Then
                MsgBox("Seleccion una clasificacion ", MsgBoxStyle.Information, "Control de datos")
                Me.cboClasificacion.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            If String.IsNullOrWhiteSpace(txtNombreCodigo.Text) = True Then
                MsgBox("Digite un nombre para este producto", MsgBoxStyle.Information, "Control de datos")
                Me.txtNombreCodigo.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(txtPorceIVA.Text) = True Then
                MsgBox("Digite un procentage para este producto", MsgBoxStyle.Information, "Control de datos")
                Me.txtPorceIVA.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If
            If String.IsNullOrWhiteSpace(txtValorTarifa.Text) = True Then
                MsgBox("Digite un valor de tarifa para este producto", MsgBoxStyle.Information, "Control de datos")
                Me.txtValorTarifa.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

            Return estado

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la validacion de campos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CreaConsecutivo(CodDocu As String, ActConse As Boolean, CodUsua As String) As String
        Try
            Dim Consecutivo As String = ConsecutivoDocumen(CodDocu, ActConse, CodUsua)
            Select Case Consecutivo
                Case "0"
                    Informa = "Lo siento pero en esta base de datos no" & Chr(13) & Chr(10)
                    Informa = Informa & "se encontro el registro consecutivo," & Chr(13) & Chr(10)
                    MsgBox(Informa, vbExclamation, Titulo01)
                    Consecutivo = 0
                Case "-3"
                    Informa = "Lo siento pero en esta base de datos no" & Chr(13) & Chr(10)
                    Informa = Informa & "se pueden registrar más facturas de ventas," & Chr(13) & Chr(10)
                    Informa = Informa & "porque pasó la longitud permitida del código."
                    MsgBox(Informa, vbExclamation, Titulo01)
                    Consecutivo = 0

                Case "-2"
                    Informa = "Lo siento pero en esta base de datos no se" & Chr(13) & Chr(10)
                    Informa = Informa & "pueden registrar más más facturas de ventas, porque" & Chr(13) & Chr(10)
                    Informa = Informa & "la fecha del último generado es mayor a la del sistema."
                    MsgBox(Informa, vbExclamation, Titulo01)
                    Consecutivo = 0
            End Select
            cn.Close()

            If Consecutivo = "0" Or Consecutivo = "-3" Or Consecutivo = "-2" Then
                Return False
            Else
                Return Consecutivo
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la creacion del concecutivo " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function 'Crea el concecutivo

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If ValidarCampos() = True Then

                Dim concecutivoProducCatalogo As String = CreaConsecutivo("07", True, lblCodigoUsuario2.Text)

                Dim EstadoRegistro As Boolean = ModuloDeClaseUtilidades.RegistrarCodigo(concecutivoProducCatalogo, txtNombreCodigo.Text, cboClasificacion.SelectedValue, txtValorTarifa.Text, txtPorceIVA.Text, lblCodigoUsuario2.Text)

                If EstadoRegistro Then
                    cargarDatos()
                End If


            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el registro de productos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If DataGridCodigosModulos.SelectedCells.Count <> 0 Then
                Dim Codigo As String = DataGridCodigosModulos.SelectedCells(0).Value.ToString()
                If ValidarCampos() = True Then
                    Dim EstadoAct As Boolean = ModuloDeClaseUtilidades.ActualizarCodigo(Codigo, txtNombreCodigo.Text, cboClasificacion.SelectedValue, txtValorTarifa.Text, txtPorceIVA.Text, lblCodigoUsuario2.Text)
                    If EstadoAct Then
                        cargarDatos()
                    End If
                End If
            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el actualizacion de productos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminarCodigo_Click(sender As Object, e As EventArgs) Handles btnEliminarCodigo.Click
        Try
            If DataGridCodigosModulos.SelectedCells.Count <> 0 Then
                Dim Codigo As String = DataGridCodigosModulos.SelectedCells(0).Value.ToString()
                Dim EstadoDel As Boolean = ModuloDeClaseUtilidades.EliminarServicio(Codigo)

                If EstadoDel Then
                    cargarDatos()
                End If
            End If



        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el actualizacion de productos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class