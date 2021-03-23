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

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        ' check if textboxes are filled
        ' if yes, messagebox
        ' else, reload?
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click, ClassListSBar.Click
        Me.Close()
        ClassList.Show()
    End Sub

    Private Sub SearchPB_Click(sender As Object, e As EventArgs) Handles SearchPB.Click, SearchSBar.Click
        Me.Close()
        Search.Show()
    End Sub

    Private Sub AddStaffPB_Click(sender As Object, e As EventArgs) Handles AddStaffPB.Click, AddStaffSBar.Click
        ' form is missing
    End Sub

    Private Sub LogoutBtn_Click_1(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()
        Login.Close()
    End Sub
End Class