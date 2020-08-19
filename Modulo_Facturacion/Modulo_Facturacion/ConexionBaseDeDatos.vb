Imports System.Data.SqlClient

Module ConexionBaseDeDatos
    Public cn As New SqlConnection

    Public Sub conectarGeogebra()
        Try
            cn.ConnectionString = "Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True"
        Catch ex As Exception
            MsgBox("Error en la base de datos BDADYSNET" + ex.Message)
        End Try
    End Sub

    Public Function SQLReader(sqlString As String) As SqlDataReader
        Try
            cn.Open()
            Dim comando As SqlCommand
            Dim reader As SqlDataReader
            comando = New SqlCommand(sqlString, cn)
            reader = comando.ExecuteReader()
            Return reader

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion SQLReader." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function 'Retorna un SqlDataReader
    Public Function SQLDataSET(sqlString As String) As DataSet
        Try
            cn.Open()
            Dim adapatador As New SqlDataAdapter(sqlString, cn) 'llena combox Nombre contratante
            Dim datos As New DataSet
            datos.Tables.Add(0)
            adapatador.Fill(datos.Tables(0))
            Return datos
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion SQLUpdate." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function 'Retorna un dataset
    Public Function SQLUpdate(sqlString As String) As Boolean 'Actualiza Update
        Try
            Dim cna As SqlConnection = New SqlConnection
            cna.ConnectionString = "Data Source=LAPTOP-00RLF157\SQLEXPRESS;Initial Catalog=BDADYSNET;Integrated Security=True"
            cna.Open()
            Dim Actualizar As SqlCommand
            Actualizar = New SqlCommand(sqlString, cna)
            Actualizar.ExecuteNonQuery()
            cna.Close()
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion SQLUpdate en el modulo llamado conexion base de datos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try
    End Function 'Ejecuta una actualizacion
    Public Function DataTable(sqlString) As DataTable
        Try
            cn.Open()
            Dim comando As SqlCommand
            comando = New SqlCommand(sqlString, cn)
            If comando.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(comando)
                Dim MostrarContratos = New DataTable
                da.Fill(MostrarContratos)
                Return MostrarContratos
            Else
                MsgBox("No trae registros")
                Return Nothing
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion DataTbale." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function  'Funcion que recibe consulta y retorna un dataTable
End Module
