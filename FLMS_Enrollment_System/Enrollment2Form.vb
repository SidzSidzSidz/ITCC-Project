Public Class Enrollment2Form
    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        Enrollment1Form.Close()
        Me.Close()
        Enrollment1Form.Show()
    End Sub
End Class