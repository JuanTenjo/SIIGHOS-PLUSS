Public Class AnularRemi
    Dim ClaseModuloDeRemisiones As New ModuloDeClasesRemision 'Instancia clase ModuloDeClasesRemision
    Private Sub AnularRemi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try



        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el load de la remision " & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try

            If MsgBox("Se anulara esta remision. ¿Estas de acuerdo?", vbYesNo) = vbYes Then


                If (ModuloVariablesAplicacion.IDRemi = "") Then
                    MsgBox("No se cargo el numero de remision")
                    Exit Sub
                End If

                If (ModuloVariablesAplicacion.AnulaUser = "") Then
                    MsgBox("El usuario que eliminara la remision no se cargo")
                    Exit Sub
                End If

                If String.IsNullOrEmpty(txtRazonAnulRemi.Text) Then

                    MsgBox("No ingresaste la razon de anulamiento")
                    Exit Sub

                Else
                    Dim EstadoAnul As Boolean = ClaseModuloDeRemisiones.AnularRemision(ModuloVariablesAplicacion.IDRemi, ModuloVariablesAplicacion.AnulaUser, txtRazonAnulRemi.Text)

                    If (EstadoAnul) Then

                        ModuloVariablesAplicacion.EstadoAnul = 1

                        MsgBox("Anulacion Exitosa")

                    End If

                End If

                Me.Dispose()

            End If



        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al anular la remision" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelarAnulRemi_Click(sender As Object, e As EventArgs) Handles BtnCancelarAnulRemi.Click
        Me.Dispose()
    End Sub

End Class