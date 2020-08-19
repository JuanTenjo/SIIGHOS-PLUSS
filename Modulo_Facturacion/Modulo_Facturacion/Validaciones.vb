Module Validaciones
    Sub LimpiarCampos(ByVal control As Form, ByVal gb As GroupBox)
        Dim txt As Object
        Dim txttemporal As TextBox
        Dim cmbtemporal As ComboBox

        For Each txt In control.Controls
            If TypeOf txt Is TextBox Then
                txttemporal = CType(txt, TextBox)
                txttemporal.Text = ""
            ElseIf TypeOf txt Is ComboBox Then
                cmbtemporal = CType(txt, ComboBox)
                cmbtemporal.Text = ""
            End If
        Next

        For Each txt In gb.Controls
            If TypeOf txt Is TextBox Then
                txttemporal = CType(txt, TextBox)
                txttemporal.Text = ""
            ElseIf TypeOf txt Is ComboBox Then
                cmbtemporal = CType(txt, ComboBox)
                cmbtemporal.Text = ""
            End If
        Next

    End Sub
    Sub soloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub sololetras(ByRef e As KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If

    End Sub
    Public Sub soloMayusculas(ByRef texbox As TextBox)
        texbox.CharacterCasing = CharacterCasing.Upper
    End Sub

    Public Function digito_verificacion(ByVal nit As String)
        nit = Format(Val("" & nit), "000000000000000")
        Dim residuo As Integer = 0
        Dim mul As Integer = 0
        'MsgBox(res)

        For i As Integer = 15 To 1 Step -1
            If i = 15 Then
                mul = 3
            ElseIf i = 14 Then
                mul = 7
            ElseIf i = 13 Then
                mul = 13
            ElseIf i = 12 Then
                mul = 17
            ElseIf i = 11 Then
                mul = 19
            ElseIf i = 10 Then
                mul = 23
            ElseIf i = 9 Then
                mul = 29
            ElseIf i = 8 Then
                mul = 37
            ElseIf i = 7 Then
                mul = 41
            ElseIf i = 6 Then
                mul = 43
            ElseIf i = 5 Then
                mul = 47
            ElseIf i = 4 Then
                mul = 53
            ElseIf i = 3 Then
                mul = 59
            ElseIf i = 2 Then
                mul = 67
            Else
                mul = 71
            End If
            residuo = residuo + (Val(GetChar(nit, i)) * mul)
        Next
        residuo = residuo Mod 11

        If residuo = 0 Then
            residuo = 0
        ElseIf residuo = 1 Then
            residuo = 1
        Else
            residuo = 11 - residuo
        End If
        Return residuo
    End Function
End Module
