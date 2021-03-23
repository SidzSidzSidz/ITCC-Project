Public Class StudentInfo

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        Me.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles ClassListSBar.Click, CListPB.Click
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub AddStaffSBar_Click(sender As Object, e As EventArgs) Handles AddStaffSBar.Click, AddStaffPB.Click

    End Sub

    Private Sub StudentInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click

    End Sub
End Class