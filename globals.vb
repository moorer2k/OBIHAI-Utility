Module Globals
    Delegate Sub TextDelegate(ByVal form As Form, ByVal userControl As Control, ByVal newText As String)
    Public Sub SetText(ByVal form As Form, ByVal userControl As Control, ByVal newText As String)

        If form.InvokeRequired Then
            Dim myDelegate As New TextDelegate(AddressOf SetText)
            userControl.Invoke(myDelegate, New Object() {form, userControl, newText})
        Else
            userControl.Text = newText
        End If
    End Sub
End Module
