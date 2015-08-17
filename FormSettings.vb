Public Class FormSettings
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click


        If String.IsNullOrEmpty(TextUser.Text) Or String.IsNullOrEmpty(TextPass.Text) Then

        Else

            If CheckSave.Checked Then
                My.Settings.remember = True
                My.Settings.username = TextUser.Text
                My.Settings.password = TextPass.Text
            End If

        End If

        If String.IsNullOrEmpty(TextIP.Text) Or String.IsNullOrEmpty(TextPort.Text) Then

        Else

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
End Class