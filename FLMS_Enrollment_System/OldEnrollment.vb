Public Class OldEnrollment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enter_btn.Click
        Me.Hide()
        Enrollment1Form.Panel2.BringToFront()
        Enrollment1Form.Show()
    End Sub
End Class