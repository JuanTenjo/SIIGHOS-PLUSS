Imports System.Data.SqlClient


Public Class GestionContabilidad

    Dim ClaseModuloDeRemisiones As New ModuloDeClasesRemision 'Instancia clase ModuloDeClasesRemision


    Private Sub CargarDataGrid()
        Try

            Dim Query As String = "SELECT [Datos contabilizacion factura].PrefiFact, [Datos contabilizacion factura].NumFact, [Datos contabilizacion factura].TipDocTer, [Datos contabilizacion factura].NumDocTer, [Datos contabilizacion factura].SucDocTer, 
                                [Datos contabilizacion factura].MesPerCon, [Datos contabilizacion factura].AnoPerCon, [Datos contabilizacion factura].FecDoc
                                FROM [Datos contabilizacion factura] INNER JOIN
                                [Datos facturas realizadas] ON [Datos contabilizacion factura].PrefiFact = [Datos facturas realizadas].PrefiFact AND [Datos contabilizacion factura].NumFact = [Datos facturas realizadas].NumFact
                                GROUP BY [Datos contabilizacion factura].PrefiFact, [Datos contabilizacion factura].NumFact, [Datos contabilizacion factura].TipDocTer, [Datos contabilizacion factura].NumDocTer, [Datos contabilizacion factura].SucDocTer, 
                                [Datos contabilizacion factura].MesPerCon, [Datos contabilizacion factura].AnoPerCon, [Datos contabilizacion factura].FecDoc"


            Dim FactPending As SqlDataReader = ConexionBaseDeDatos.SQLReader(Query)

            If FactPending.HasRows Then

                While FactPending.Read()

                    cn2.Open()

                    Dim NumFacFormado As String = FactPending("NumFact").ToString()

                    NumFacFormado = NumFacFormado.PadLeft(15, "0") 'Agregue cuantos ceros falten a la izquierda para completar el tamaño

                    Query = "SELECT * FROM [ADYSNET].[dbo].[CMDMOVIMIENTO] WHERE [CMDDocumentoMovimiento] = '" & NumFacFormado & "' and [CMDPrefijoMovimiento] = '" & FactPending("PrefiFact").ToString() & "'"

                    Dim comando As SqlCommand
                    Dim reader As SqlDataReader
                    comando = New SqlCommand(Query, cn2)
                    reader = comando.ExecuteReader()

                    If reader.HasRows = False Then

                        DataGridFacturasPendientes.Rows.Add(FactPending("PrefiFact").ToString(), FactPending("NumFact").ToString(), FactPending("FecDoc").ToString(), FactPending("TipDocTer").ToString(), FactPending("NumDocTer").ToString(), FactPending("MesPerCon").ToString(), FactPending("AnoPerCon").ToString())

                    End If

                    reader.Close()
                    cn2.Close()

                End While


            End If

            cn.Close()

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al cargar el datagrid de facturas" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GestionContabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CargarDataGrid()


        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al abrir el formulario Gestion Contabilidad" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try

            If DataGridFacturasPendientes.SelectedCells.Count <> 0 Then

                Dim NumFac As String = DataGridFacturasPendientes.SelectedCells(1).Value.ToString()

                If MessageBox.Show("Se agregara la cuenta contable de esta factura: " & NumFac & " ¿esta seguro? ", "Control de contabuilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then


                    Dim Esta As Boolean = ClaseModuloDeRemisiones.RegistrarContabilidad(NumFac)

                    If Esta Then
                        Titulo01 = "Controld de contabilidad"
                        Informa = "La cuenta contable de la factura " & NumFac & " se registro correctamente" & Chr(13) & Chr(10)
                        MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDataGrid()
                    End If



                End If


            Else
                Informa = "Lo siento pero se ha seleccionado ninguna factura" & Chr(13) & Chr(10)
                MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al enviar la factura a contabilidad" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class