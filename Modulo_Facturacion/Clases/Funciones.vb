Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Module Funciones
    Public Function CargaPaises(ByRef Combobox As ComboBox)
        Try

            Combobox.DataSource = Nothing
            Combobox.Items.Clear()

            Dim CargarPaises As DataSet = SQLDataSET("SELECT NomPais, CodiPais FROM [GEOGRAXPSQL].[dbo].[Datos de paises] order by 1")


            Combobox.DataSource = CargarPaises.Tables(0)
            Combobox.DisplayMember = "NomPais"
            Combobox.ValueMember = "CodiPais"

            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar los Paises." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Public Function CargaDepartamentos(ByRef ComboboxDepa As ComboBox, ByRef ComboboxPais As ComboBox)
        Try

            ComboboxDepa.DataSource = Nothing
            ComboboxDepa.Items.Clear()

            Dim CargarDepartamentos As DataSet = SQLDataSET("SELECT NombreDpto, CodigoDpto FROM [GEOGRAXPSQL].[dbo].[Datos de los Dpto o Estados] WHERE CodigoPais = '" & ComboboxPais.SelectedValue & "' order by 1")
            ComboboxDepa.DataSource = CargarDepartamentos.Tables(0)
            ComboboxDepa.DisplayMember = "NombreDpto"
            ComboboxDepa.ValueMember = "CodigoDpto"
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar los Departamentos." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function CargaCiudad(ByRef cboCiudad As ComboBox, ByRef cboDepa As ComboBox)

        Try

            cboCiudad.DataSource = Nothing
            cboCiudad.Items.Clear()

            Dim CargarCiudad As DataSet = SQLDataSET("SELECT NombreCiudad, CodDptoCity  FROM [GEOGRAXPSQL].[dbo].[Datos ciudades del dpto] where CodigoDpto = '" & cboDepa.SelectedValue & "' order by 1")
            cboCiudad.DataSource = CargarCiudad.Tables(0)
            cboCiudad.DisplayMember = "NombreCiudad"
            cboCiudad.ValueMember = "CodDptoCity"
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar las ciudades." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function CargaDocumentosIdentidad(ByRef cboDocumentos As ComboBox)
        Try
            Dim CargarDocumentosIdentidad As DataSet = SQLDataSET("SELECT CodIdenti FROM [GEOGRAXPSQL].[dbo].[Datos documentos empresas]")
            cboDocumentos.DataSource = CargarDocumentosIdentidad.Tables(0)
            cboDocumentos.DisplayMember = "CodIdenti"
            cboDocumentos.ValueMember = "CodIdenti"
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "Al cargar Documentos Identidad." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
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

    Dim UNIDADES As String() = {"", "un ", "dos ", "tres ", "cuatro ", "cinco ", "seis ", "siete ", "ocho ", "nueve "}
    Dim DECENAS As String() = {"diez ", "once ", "doce ", "trece ", "catorce ", "quince ", "dieciseis ", "diecisiete ", "dieciocho ", "diecinueve", "veinte ", "treinta ", "cuarenta ", "cincuenta ", "sesenta ", "setenta ", "ochenta ", "noventa "}
    Dim CENTENAS As String() = {"", "ciento ", "doscientos ", "trecientos ", "cuatrocientos ", "quinientos ", "seiscientos ", "setecientos ", "ochocientos ", "novecientos "}
    Dim r As Regex

    Sub NumLetra()
    End Sub



    Public Function Convertir(ByVal numero As String, ByVal mayusculas As Boolean) As String
        Dim literal As String = ""
        Dim parte_decimal As String = ""
        'si el numero utiliza (.) en lugar de (,) -> se reemplaza



        numero = Replace(numero, ".", ",")
        'si el numero no tiene parte decimal, se le agrega ,00        
        If numero.IndexOf(",") = -1 Then
            numero = numero & ",00"
        End If
        'se valida formato de entrada -> 0,00 y 999 999 999,00
        'if (Pattern.matches("\\d{1,9},\\d{1,2}", numero)) {

        r = New Regex("\d{1,9},\d{1,2}")
        Dim mc As MatchCollection = r.Matches(numero)
        If mc.Count > 0 Then
            'se divide el numero 0000000,00 -> entero y decimal
            Dim Num As String() = numero.Split(",")
            'de da formato al numero decimal
            parte_decimal = " PESOS CON " & Num(1) & " CENTAVOS"
            'se convierte el numero a literal            
            If Num(0) = 0 Then
                literal = "cero "
            ElseIf Num(0) > 999999 Then
                literal = getMillones(Num(0))
            ElseIf Num(0) > 999 Then
                literal = getMiles(Num(0))
            ElseIf Num(0) > 99 Then
                literal = getCentenas(Num(0))
            ElseIf Num(0) > 9 Then
                literal = getDecenas(Num(0))
            Else
                literal = getUnidades(Num(0))
            End If
            'devuelve el resultado en mayusculas o minusculas
            If mayusculas Then
                Return (literal & parte_decimal).ToUpper
            Else
                Return literal & parte_decimal
            End If
        Else
            Return ""
        End If

    End Function

    ' funciones para convertir los numeros a literales
    Private Function getUnidades(ByVal numero As String) As String '1 - 9
        'si tuviera algun 0 antes se lo quita -> 09 = 9 o 009=9
        Dim num As String = numero.Substring(numero.Length - 1)
        Return UNIDADES(num)
    End Function

    Private Function getDecenas(ByVal numero As String) As String '99
        If numero < 10 Then 'para casos como -> 01 - 09
            Return getUnidades(numero)
        ElseIf numero > 19 Then 'para 20...99
            Dim u As String = getUnidades(numero)
            If u.Equals("") Then 'para 20,30,40,50,60,70,80,90
                Return DECENAS(numero.Substring(0, 1) + 8)
            Else
                Return DECENAS(numero.Substring(0, 1) + 8) & "y " & u
            End If
        Else
            Return DECENAS(numero - 10)
        End If
    End Function

    Private Function getCentenas(ByVal numero As String) As String
        If numero > 99 Then 'es centena
            If numero = 100 Then 'caso especial
                Return "cien "
            Else
                Return CENTENAS(numero.Substring(0, 1)) & getDecenas(numero.Substring(1))
            End If
        Else 'se quita el 0 antes de convertir a decenas
            Return getDecenas(numero)
        End If
    End Function

    Private Function getMiles(ByVal numero As String) As String
        'obtiene las centenas'
        Dim c As String = numero.Substring(numero.Length - 3)
        'obtiene los miles
        Dim m As String = numero.Substring(0, numero.Length - 3)
        Dim n As String = ""
        'se comprueba que miles tenga valor entero
        If m > 0 Then
            n = getCentenas(m)
            Return n & " mil " & getCentenas(c)
        Else
            Return "" & getCentenas(c)
        End If
    End Function

    Private Function getMillones(ByVal numero As String) As String
        'se obtiene los miles
        Dim miles As String = numero.Substring(numero.Length - 6)
        'millones
        Dim millon As String = numero.Substring(0, numero.Length - 6)
        Dim n As String = ""
        If millon > 9 Then
            n = getCentenas(millon) & " millones "
        Else
            n = getUnidades(millon) & " millon "
        End If
        Return n & getMiles(miles)
    End Function

End Module
