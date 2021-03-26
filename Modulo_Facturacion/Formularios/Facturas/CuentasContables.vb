Imports System.Data.SqlClient
Public Class CuentasContables



    Private Sub CargarDataGrid(consulta)
        Try


            ' Dim Combo As DataSet = SQLDataSET("SELECT [CueContaIPS], NomCConIPS FROM [GEOGRAXPSQL].[dbo].[Datos ctas contables IPS]")
            DataGridCuentasContables.AutoGenerateColumns = False
            DataGridCuentasContables.DataSource = Nothing
            DataGridCuentasContables.Rows.Clear()
            Try
                Dim reader As SqlDataReader
                reader = SQLReader(consulta)

                If reader.HasRows Then
                    While reader.Read()
                        Me.DataGridCuentasContables.Rows.Add(reader("CueContaIPS"), reader("NomCConIPS"))

                    End While
                Else
                    Me.DataGridCuentasContables.Rows.Clear()
                End If
                reader.Close()
                reader = Nothing
                cn.Close()

            Catch ex As Exception
                Titulo01 = "Control de errores de ejecución"
                Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
                Informa += "en la funcion SQLReader que carga las cuentas contables." & Chr(13) & Chr(10)
                Informa += "Mensaje del error: " & ex.Message
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CuentasContables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim consulta As String = "SELECT [CueContaIPS], NomCConIPS FROM [GEOGRAXPSQL].[dbo].[Datos ctas contables IPS]"
            CargarDataGrid(consulta)
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al cargar el formulario de cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            If String.IsNullOrWhiteSpace(txtBuscar.Text) = False Then
                Dim consulta As String = "SELECT [CueContaIPS], NomCConIPS FROM [GEOGRAXPSQL].[dbo].[Datos ctas contables IPS] WHERE CueContaIPS LIKE '%" & txtBuscar.Text & "%' or NomCConIPS LIKE '%" & txtBuscar.Text & "%'"
                CargarDataGrid(consulta)
            Else
                Dim consulta As String = "SELECT [CueContaIPS], NomCConIPS FROM [GEOGRAXPSQL].[dbo].[Datos ctas contables IPS]"
                CargarDataGrid(consulta)
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la busqueda de cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DataGridCuentasContables_DoubleClick(sender As Object, e As EventArgs) Handles DataGridCuentasContables.DoubleClick
        Try

            If DataGridCuentasContables.SelectedCells.Count <> 0 Then

                Dim NumCuentaCont As String = DataGridCuentasContables.SelectedCells(0).Value.ToString()
                ModuloVariablesAplicacion.CuentasContables = NumCuentaCont
                Me.Dispose()

            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la seleccion de cuentas contables" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class