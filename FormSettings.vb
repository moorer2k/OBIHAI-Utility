Imports OBIHAIUtility.obi

Public Class FormSettings
    Private WithEvents _discover As Discovery
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If Not String.IsNullOrEmpty(TextUser.Text) And Not String.IsNullOrEmpty(TextPass.Text) Then
            If CheckSave.Checked Then
                My.Settings.remember = True
                My.Settings.username = TextUser.Text
                My.Settings.password = TextPass.Text
            End If
        End If
        If Not String.IsNullOrEmpty(TextIP.Text) And Not String.IsNullOrEmpty(TextPort.Text) Then
            My.Settings.ipaddress = TextIP.Text
            My.Settings.port = TextPort.Text
        End If
        My.Settings.Save()
        If FormMain.CheckSettings() Then
            FormMain.ButtonStart.Enabled = True
        Else
            FormMain.ButtonStart.Enabled = False
        End If
        Close()
    End Sub

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.remember Then
            CheckSave.Checked = True
            TextUser.Text = My.Settings.username
            TextPass.Text = My.Settings.password
        End If
        MetroToggle1.Checked = My.Settings.popupNotification
        TextIP.Text = My.Settings.ipaddress
        TextPort.Text = My.Settings.port
        If My.Settings.port = "" Then TextPort.Text = "80"
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        My.Settings.Reset()
    End Sub
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub
    Private Async Sub ButtonDiscover_Click(sender As Object, e As EventArgs) Handles ButtonDiscover.Click
        Select Case ButtonDiscover.Text
            Case "Start auto discovery"
                ButtonDiscover.Text = "Stop auto discovery"
                _discover = New Discovery()
                labelStatus.Text = "Status: Scanning subnet " & _discover.IpRange & "* for OBI.."
                Await _discover.Discover()
            Case "Stop auto discovery"
                ButtonDiscover.Text = "Start auto discovery"
                _discover.Cancel()
                labelStatus.Text = "Status: Canceled auto discovery."
        End Select
    End Sub
    Private Sub _discover_OnComputerFound(ip As String, isObi As Boolean) Handles _discover.OnComputerFound
        Select Case isObi
            Case True
                SetText(Me, labelStatus, "Status: Discovered OBI device on " & ip)
                SetText(Me, TextIP, ip)
                SetText(Me, labelStatus, "Status: Finished discovery.")
                _discover.Cancel()
            Case False
                SetText(Me, labelStatus, "Status: " & ip & " is a non-OBI device ")
        End Select
    End Sub
    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged
        If MetroToggle1.Checked Then
            My.Settings.popupNotification = True
        Else
            My.Settings.popupNotification = False
        End If
        My.Settings.Save()
    End Sub
End Class