Public Class HomePage

    'opens up the relevent pages
    Private Sub btnPlants_Click(sender As Object, e As EventArgs) Handles btnPlants.Click

        Me.Hide()
        PlantData.Show()

    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click

        Me.Hide()
        Client_Data.Show()

    End Sub

    Private Sub btnManager_Click(sender As Object, e As EventArgs) Handles btnManager.Click

        Me.Hide()
        Manage.Show()

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'username and login system for when the software loads - simple password

        Try
            Dim username = InputBox("Please enter your USERNAME", "Login")
            If username = "admin" Then
                Dim password = InputBox("Please enter your PASSWORD", "Login")
                If password = "admin" Then
                    MessageBox.Show("Login successful - Click OK to continue", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Incorrect Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            Else
                MessageBox.Show("Incorrect Username", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error has occurred: " & ex.Message & vbNewLine & "Please try again")
        End Try


    End Sub
End Class