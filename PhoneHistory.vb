Public Class PhoneHistory
    Private _dateTime1 As String
    Private _phoneNumber1 As String

    Public Property DateTime() As String
        Get
            Return _dateTime1
        End Get
        Set(value As String)
            _dateTime1 = value
        End Set
    End Property

    Public Property PhoneNumber() As String
        Get
            Return _phoneNumber1
        End Get
        Set(value As String)
            _phoneNumber1 = value
        End Set
    End Property

    Public Sub New(ByVal datetime As String, ByVal phonenumber As String)
        Me.DateTime = datetime
        Me.PhoneNumber = phonenumber
    End Sub
End Class