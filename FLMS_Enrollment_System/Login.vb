Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Enrollment1Form.Show()
        Me.Hide()
    End Sub
End Class
