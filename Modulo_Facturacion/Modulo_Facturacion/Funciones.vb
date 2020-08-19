Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module Funciones

    Public Function CargaPaises(ByRef Combobox As ComboBox)
        Call conectarGeogebra()
        Dim adapatador As New SqlDataAdapter("SELECT NomPais, CodiPais FROM [Datos de paises]", cn)
        Dim datos As New DataSet
        datos.Tables.Add("[Datos de paises]")
        adapatador.Fill(datos.Tables("[Datos de paises]"))
        Combobox.DataSource = datos.Tables("[Datos de paises]")
        Combobox.DisplayMember = "NomPais"
        Combobox.ValueMember = "CodiPais"
        cn.Close()
        Return Nothing
    End Function
    Public Function CargaDepartamentos(ByRef ComboboxDepa As ComboBox, ByRef ComboboxPais As ComboBox)
        Call conectarGeogebra()
        Dim strSql As String = "SELECT NombreDpto, CodigoDpto FROM [Datos de los Dpto o Estados] WHERE CodigoPais = '" & ComboboxPais.SelectedValue & "' "
        Dim adapatador1 As New SqlDataAdapter(strSql, cn)
        Dim datos1 As New DataSet
        datos1.Tables.Add("[Datos de los Dpto o Estados]")
        adapatador1.Fill(datos1.Tables("[Datos de los Dpto o Estados]"))
        ComboboxDepa.DataSource = datos1.Tables("[Datos de los Dpto o Estados]")
        ComboboxDepa.DisplayMember = "NombreDpto"
        ComboboxDepa.ValueMember = "CodigoDpto"
        cn.Close()
        Return Nothing
    End Function
    Public Function CargaCiudad(ByRef cboCiudad As ComboBox, ByRef cboDepa As ComboBox)
        Call conectarGeogebra()
        Dim adapatador As New SqlDataAdapter("SELECT NombreCiudad, CodCiudad  FROM [Datos ciudades del dpto] where CodigoDpto = '" & cboDepa.SelectedValue & "' ", cn)
        Dim datos As New DataSet
        datos.Tables.Add("Datos ciudades del dpto")
        adapatador.Fill(datos.Tables("Datos ciudades del dpto"))
        cboCiudad.DataSource = datos.Tables("Datos ciudades del dpto")
        cboCiudad.DisplayMember = "NombreCiudad"
        cboCiudad.ValueMember = "CodCiudad"
        cn.Close()
        Return Nothing
    End Function
    Public Function CargaDocumentosIdentidad(ByRef cboDocumentos As ComboBox)
        Call conectarGeogebra()
        Dim adapatador As New SqlDataAdapter("SELECT CodIdenti FROM [Datos documentos empresas]", cn)
        Dim datos As New DataSet
        datos.Tables.Add("[Datos documentos empresas]")
        adapatador.Fill(datos.Tables("[Datos documentos empresas]"))
        cboDocumentos.DataSource = datos.Tables("[Datos documentos empresas]")
        cboDocumentos.DisplayMember = "CodIdenti"
        cn.Close()
        Return Nothing
    End Function

    Public Function ConsecutivoDocumen(CodDocu As String, ActConse As Boolean, CodUsua As String) As String 'actconse se utiliza para si es treu actualize el cod si el false no lo va actualizar
        Try
            'Permite buscar el consecutivo del documento deseado

            Dim FechaUltima As Date, SigPro As Integer, ConTomado As String
            Dim ConsecActual As Long, PreDoc As String, TCG As Integer, CodFormado As String, TCGPf As Integer
            Dim SqlConsecu As String

            Dim dr As SqlDataReader

            Titulo01 = "Control para cargar formularios"

            SqlConsecu = "SELECT  CodConse, PrefiConse, ConseDocu, UlltiConseDoc, CodUsaConse, "
            SqlConsecu = SqlConsecu & "ConseCrono, FecConseDoc, CanDigConse, NomDocuConse, CodRegis, FecRegis "
            SqlConsecu = SqlConsecu & "FROM [Datos consecutivos SIIGHOSPLUS] "
            SqlConsecu = SqlConsecu & "WHERE CodConse = '" & CodDocu & "' "
            SqlConsecu = SqlConsecu & "ORDER BY CodConse "

            'Cargamos primeramente los combos, abriendo las instancias que se pueden cerrar inmediatamente

            dr = SQLReader(SqlConsecu)

            If dr.HasRows = False Then
                'NO se encontró el registro de consecutivo para este documento
                Return CodFormado = "0"
            Else
                dr.Read()

                'Revisamos si el documento es obligatorio que sea cronologíco

                If dr![ConseCrono] = True Then

                    'Es obligatorio la fecha cronologica

                    FechaUltima = Format(FormatDateTime(dr![FecConseDoc], vbShortDate), "yyyy-mm-dd")

                    'Revisemos que esta no sea mayor a la del sistema

                    If FechaUltima > Date.Now Then
                        Return CodFormado = "-2"
                        SigPro = 0
                    Else
                        SigPro = 1
                    End If 'Final de FechaUltima > Date

                Else
                    SigPro = 1
                End If

                If SigPro = 1 Then
                    'Revisamos si existe un consecutivo por reasignar o perdido

                    If dr![UlltiConseDoc] = 0 Then
                        'No existen comprobantes perdidos, debe generar el siguiente

                        ConsecActual = dr![ConseDocu]
                        ConsecActual = ConsecActual + 1

                        'Procedemos a actualizar el consecutivo, si la función viene positiva
                 
                        If ActConse = True Then
                            Dim fecha As Date = Date.Now
                            SQLDatos = Nothing
                            SQLDatos = "UPDATE [Datos consecutivos SIIGHOSPLUS] 
                            SET ConseDocu = '" & ConsecActual & "', CodUsaConse = '" & CodUsua & "', 
                            FecConseDoc = '" & fecha.ToString("yyyy-MM-dd") & "'
                            WHERE CodConse = '" & dr![CodConse] & "'"



                            If SQLUpdate(SQLDatos) = False Then
                                MsgBox("Error en la actualizacion")
                            End If


                        End If 'Final de ActConse = True

                    Else
                        'Existe un consecutivo perdido
                        ConsecActual = dr![UlltiConseDoc]
                        If ActConse = True Then
                            SQLDatos = Nothing
                            SQLDatos = "UPDATE [Datos consecutivos SIIGHOSPLUS] SET" +
                                       "UlltiConseDoc = " & 0 & "" +
                                       "WHERE CodConse = " + dr![CodConse]

                            SQLUpdate(SQLDatos)
                        End If

                    End If 'Final de dr![UlltiConseDoc] = 0

                    'Tomamos el tamaño del código a generar

                    TCG = dr![CanDigConse]

                    'Revisamos si el consecutivo lleva prefijo

                    PreDoc = dr![PrefiConse]
                    ConTomado = CStr(ConsecActual)


                    If PreDoc = "00" Then
                        'No lleva prefijo
                        If TCG < Len(ConTomado) Then
                            'NO se pueden generar más código, porqu llego al limite
                            Return CodFormado = "-3"
                        Else
                            CodFormado = ConTomado.PadLeft(TCG, "0") 'Agregue cuantos ceros falten a la izquierda para completar el tamaño
                        End If 'Final de TCG < Len(ConTomado)
                    Else
                        'LLeva prefijo, al tamanó real se le el tamño del prefijo
                        TCGPf = TCG - Len(PreDoc)
                        If TCGPf < Len(ConTomado) Then
                            'NO se pueden generar más código, porqu llego al limite
                            Return CodFormado = "-3"
                        Else
                            CodFormado = PreDoc & ConTomado.PadLeft(TCGPf, "0") 'Agregue cuantos ceros falten a la izquierda para completar el tamaño
                        End If 'Final de TCG < Len(ConTomado)

                    End If 'Final de PreDoc = "00"

                End If 'Fin SigPro = 1

            End If


            ConsecutivoDocumen = CodFormado
            cn.Close()

            Exit Function


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa = Informa & "en la función: ConsecutivoDocumen del" & Chr(13) & Chr(10)
            Informa = Informa & "Módulo variables de la aplicación" & Chr(13) & Chr(10) & Chr(13) & Chr(10)
            Informa = Informa & "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ConsecutivoDocumen = "-1"
        End Try
    End Function
    Public Sub GenerarExcel(ByVal dt As DataTable, ByVal File As String)

        Try
            Dim AplicacionExcel As Excel.Application = CType(CreateObject("Excel.Application"), Excel.Application)
            Dim LibroDeTrabajo As Excel.Workbook
            Dim HojaDeCalculo As Excel.Worksheet
            '  Dim Rango As Excel.Range


            LibroDeTrabajo = AplicacionExcel.Workbooks.Add
            HojaDeCalculo = CType(LibroDeTrabajo.ActiveSheet, Excel.Worksheet)


            Dim dc As DataColumn
            Dim dr As DataRow


            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                AplicacionExcel.Cells(1, colIndex) = dc.ColumnName
                AplicacionExcel.Cells.Font.Bold = True
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns

                    colIndex = colIndex + 1
                    AplicacionExcel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    AplicacionExcel.Cells.Font.Bold = False
                Next
            Next


            HojaDeCalculo.Cells.Select()
            HojaDeCalculo.Columns.AutoFit()
            HojaDeCalculo.Rows.AutoFit()

            '   AplicacionExcel.Visible = True
            AplicacionExcel.UserControl = True

            LibroDeTrabajo.SaveAs(File)
            AplicacionExcel.Quit()

            MessageBox.Show("Exportacion exitosa", "Exportar a excel", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al exportar a excel." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
End Module
