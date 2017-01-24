Imports OBIHAIUtility.obi
Imports Tulpep.NotificationWindow

Public Class FormMain
    Public WithEvents Obi As Client
    Private _isCalling As Boolean
    Private ReadOnly _test As New List(Of PhoneHistory)
    Public Function CheckSettings() As Boolean
        If My.Settings.remember Then
            Obi = New Client(My.Settings.username, My.Settings.password, My.Settings.ipaddress, My.Settings.port)
            Return True
        End If
        Return False
    End Function
    Private Sub Obi_CallHistory(jsonResp As List(Of PhoneHistory)) Handles Obi.CallHistory
        ObjectListView1.SetObjects(jsonResp)
    End Sub
    Private Sub Obi_CallStatus(response As String) Handles Obi.CallStatus
        Try
            Dim callResponse As String = Obi.ParseCalls(response)
            If callResponse IsNot Nothing Then
                If callResponse = "0" Then
                    SetText(Me, LabelStatus, "Status: Listening...")
                    _isCalling = False
                End If
                If callResponse.Length > 1 Then
                    If _isCalling = False Then
                        _test.Add(New PhoneHistory(DateTime.Now.ToShortDateString(), callResponse, "In"))
                        ObjectListView1.SetObjects(_test)
                        If My.Settings.popupNotification Then
                            Dim fPopup As New PopupNotifier()
                            fPopup.TitleText = "INCOMING CALL"
                            fPopup.ContentText = "Incoming call from " & callResponse
                            fPopup.Popup()
                        End If
                        _isCalling = True
                    End If
                    SetText(Me, LabelStatus, "Status: Incoming call!")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Obi_GetResponse(response As String) Handles Obi.GetResponse
        'Debug.WriteLine(response)
    End Sub
    Private Sub Obi_InvalidLogin(message As String) Handles Obi.InvalidLogin
        SetText(Me, LabelStatus, "Status: Invalid login!")
    End Sub
    Private Sub Obi_LoggedIn(message As String) Handles Obi.OnLoggedIn
        SetText(Me, LabelStatus, "Status: Successfully logged in!")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Obi.IsLoggedin Then
            Obi.GetCalls()
        Else
            SetText(Me, LabelStatus, "Status: Not logged in!")
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
                SetText(Me, LabelStatus, "Status: Stopped.")
        End Select
    End Sub
    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Dim settings As New FormSettings
        settings.StartPosition = FormStartPosition.CenterScreen
        settings.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'weird visual issue happening, dirty fix.
        '-------------------------------
        ObjectListView1.BringToFront()
        ButtonRefresh.BringToFront()
        '-------------------------------
        If CheckSettings() Then
            ButtonStart.Enabled = True
        Else
            ButtonStart.Enabled = False
        End If
    End Sub
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        End
    End Sub
    Private Sub ButtonAbout_Click(sender As Object, e As EventArgs) Handles ButtonAbout.Click
        Obi.GetCallHistory()
    End Sub

    Private Sub ButtonExport_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        Dim history As String = ""
        For Each item As ListViewItem In ObjectListView1.Items
            history += item.Text & "," & item.SubItems(1).Text & "," & item.SubItems(2).Text & vbCrLf
        Next
        Clipboard.SetText(history)
        MsgBox("Copied to clipboard.")
    End Sub
End Class

