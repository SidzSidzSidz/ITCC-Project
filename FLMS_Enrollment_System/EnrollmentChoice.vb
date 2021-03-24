Public Class EnrollmentChoice
    Private Sub EnrollmentChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Search.Hide()
        ClassList.Hide()
        StudentInfo.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Search.Hide()
        ClassList.Hide()
        StudentInfo.Hide()
        OldEnrollment.Show()
        'fetch lrn
    End Sub
End Class