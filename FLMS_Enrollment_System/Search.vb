Public Class Search

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click
        Me.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles EnrollmentPB.Click
        Me.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles ClassListSBar.Click
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub Search_btn_Click(sender As Object, e As EventArgs) Handles Search_btn.Click
        Me.Hide()
        StudentInfo.Show()
    End Sub

    Private Sub Search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class