Public Class Enrollment2Form
    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        Enrollment1Form.Close()
        Me.Close()
        Enrollment1Form.Show()
    End Sub

    Private Sub Enrollment2Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub
End Class