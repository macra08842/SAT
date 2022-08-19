Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String

        username = tbxUser.Text
        password = tbxPassword.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            MessageBox.Show("login success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            HomePage.Show()
        Else
            MessageBox.Show("error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class