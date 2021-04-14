Public Class EnrollmentChoice
    Private Sub EnrollmentChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewStudent_btn.Click
        Me.Hide()
        Search.Hide()
        ClassList.Hide()
        Enrollment1Form.EnrollBtn.BringToFront()
        Enrollment1Form.clearboxes()
        Enrollment1Form.Panel1.BringToFront()
        Enrollment1Form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OldStudent_btn.Click
        Me.Hide()
        Search.Hide()
        ClassList.Hide()
        Enrollment1Form.UpdateButton.BringToFront()
        Enrollment1Form.Panel2.BringToFront()
        OldEnrollment.Show()
        'fetch lrn
    End Sub
End Class