Public Class Enrollment1Form
    Private Sub Enrollment1Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Enrollment2Form.Show()
        Me.Hide()
    End Sub
End Class