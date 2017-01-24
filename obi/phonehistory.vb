Namespace obi
    Public Class PhoneHistory
        Public Property DateTime As String
        Public Property PhoneNumber As String
        Public Property Direction As String
        Public Sub New(ByVal datetime As String, ByVal phonenumber As String, ByVal direction As String)
            Me.DateTime = datetime
            Me.PhoneNumber = phonenumber
            Me.Direction = direction
        End Sub
    End Class
End Namespace