Imports HtmlAgilityPack
Imports Tulpep.NotificationWindow

Public Class FormMain
    Public WithEvents Obi As ObiClass
    Private _isCalling As Boolean

    Public Function CheckSettings() As Boolean
        If My.Settings.remember Then
            Obi = New ObiClass(My.Settings.username, My.Settings.password, My.Settings.ipaddress, My.Settings.port)
            Return True
        End If
        Return False
    End Function

    Private Sub Obi_CallStatus(response As String) Handles Obi.CallStatus

        Try

            Dim callResponse As String = ParseCalls(response)

            If callResponse IsNot Nothing Then

                If callResponse = "0" Then
                    SetText(LabelStatus, "Status: Waiting. Listening...")
                    _isCalling = False
                End If

                If callResponse.Length > 1 Then

                    If _isCalling = False Then

                        _test.Add(New PhoneHistory(DateTime.Now.ToShortDateString(), callResponse))
                        ObjectListView1.SetObjects(_test)

                        If UsePopupNotification Then

                            Dim fPopup As New PopupNotifier()
                            fPopup.TitleText = "INCOMING CALL"
                            fPopup.ContentText = "Incoming call from " & callResponse
                            fPopup.Popup()

                        End If

                        _isCalling = True


                    End If

                    SetText(LabelStatus, "Status: Incoming call!")

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Obi_GetResponse(response As String) Handles Obi.GetResponse
        'Debug.WriteLine(response)
    End Sub

    Private Sub Obi_InvalidLogin(message As String) Handles Obi.InvalidLogin
        SetText(LabelStatus, "Status: Invalid login!")
    End Sub

    Private Sub Obi_LoggedIn(message As String) Handles Obi.OnLoggedIn
        SetText(LabelStatus, "Status: Successfully logged in!")
    End Sub

    Public Function ParseCalls(ByVal callstatus As String) As String

        If callstatus.Contains("Calls: 0") Then
            Return "0"
        End If

        Try

            Dim doc As New HtmlDocument
            doc.LoadHtml(callstatus)

            Dim strIncoming As String = doc.DocumentNode.SelectSingleNode("//tr[5]/td").InnerHtml
            Dim splitData As String() = strIncoming.Split("<td>")
            Dim strTelephone As String = splitData(1).Remove(0, 3) _
            'had to remove 3 because of it capturing td> with the results.

            Return strTelephone

        Catch ex As Exception

            Return ""

        End Try
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Obi.IsLoggedin Then
            Obi.GetCalls()
        Else
            SetText(LabelStatus, "Status: Not logged in!")
        End If
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        Select Case ButtonStart.Text

            Case "Start"

                Timer1.Enabled = True
                MetroTabControl1.SelectedTab = MetroTabPage3
                MetroProgressSpinner1.Enabled = True
                ButtonStart.Text = "Stop"

                Obi.Login()


            Case "Stop"

                MetroTabControl1.SelectedTab = MetroTabPage1
                ButtonStart.Text = "Start"
                MetroProgressSpinner1.Enabled = False
                Timer1.Enabled = False
                SetText(LabelStatus, "Status: Stopped.")

        End Select
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click

        FormSettings.Show()
    End Sub

    Private ReadOnly _test As New List(Of PhoneHistory)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        MetroToggle1.Checked = My.Settings.popupNotification

        If CheckSettings() Then
            ButtonStart.Enabled = True
        Else
            ButtonStart.Enabled = False
        End If
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        End
    End Sub

    Delegate Sub TextDelegate(ByVal userControl As Control, ByVal newText As String)

    Public Sub SetText(ByVal userControl As Control, ByVal newText As String)

        If userControl.InvokeRequired Then
            Dim myDelegate As New TextDelegate(AddressOf SetText)
            userControl.Invoke(myDelegate, New Object() {userControl, newText})
        Else
            userControl.Text = newText
        End If
    End Sub

    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged

        If MetroToggle1.Checked Then
            My.Settings.popupNotification = True
            UsePopupNotification = True
        Else
            My.Settings.popupNotification = False
            UsePopupNotification = False
        End If

        My.Settings.Save()
    End Sub

    Public Property UsePopupNotification As Boolean
End Class