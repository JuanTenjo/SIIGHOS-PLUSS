Imports QRCoder

Public Class Pruebas
    Private Sub btnGenerarQR_Click(sender As Object, e As EventArgs) Handles btnGenerarQR.Click
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(TextBox1.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pic.Image = code.GetGraphic(6)
        'Tabla.Columns.Add("NombreColumna", Type.GetType("System.String"
    End Sub

    Private Sub Pruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub








End Class