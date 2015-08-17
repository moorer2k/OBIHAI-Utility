Imports System.Net

Public Class ObiClass
    Public Property IpAddress As String
    Public Property Username As String
    Public Property Password As String
    Public Property Port As Integer

    Public Event InvalidLogin(ByVal message As String)
    Public Event OnLoggedIn(ByVal message As String)
    Public Event GetResponse(ByVal response As String)
    Public Event CallStatus(ByVal response As String)
    Public Event OnError(ByVal response As String)

    Public IsLoggedin As Boolean

    Private WithEvents _wc As New WebClient

    Public Sub New(ByVal username As String, ByVal password As String, ByVal ipAddress As String,
                   Optional ByVal port As Integer = 80)
        Me.Username = username
        Me.Password = password
        Me.IpAddress = ipAddress
        Me.Port = port
    End Sub

    Public Sub GetCalls()
        _wc.DownloadStringAsync(New Uri("http://" & IpAddress & ":" & Port & "/callstatus.htm"))
    End Sub

    Public Sub Login(Optional ByVal domain As String = "/")

        Dim cc As New CredentialCache
        cc.Add(New Uri("http://" & IpAddress & ":" & Port), "Digest", New NetworkCredential(Username, Password, domain))

        _wc.Credentials = cc
        _wc.DownloadStringAsync(New Uri("http://" & IpAddress & ":" & Port))
    End Sub

    Private Sub _wc_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs) _
        Handles _wc.DownloadStringCompleted

        Try
            If e.Result IsNot Nothing Then
                If Not IsLoggedin Then
                    If e.Error IsNot Nothing Then
                        If e.Error.Message.Contains("(401)") Then
                            IsLoggedin = False
                            RaiseEvent InvalidLogin("Username/Password is incorrect.")
                        End If
                    Else
                        RaiseEvent GetResponse(e.Result)
                        If e.Result.StartsWith("<html><head>") Then
                            IsLoggedin = True
                            RaiseEvent OnLoggedIn("Logged in!")
                        End If
                    End If

                End If

                RaiseEvent CallStatus(e.Result)

            End If

        Catch ex As Exception
            RaiseEvent OnError(ex.Message)
        End Try
    End Sub
End Class
