Public Class Enrollment2Form
    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click

        Enrollment1Form.Hide()
        ' replace previous statement
        Me.Hide()
        Enrollment1Form.Show()

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs)
        Enrollment1Form.Hide()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        ' check if textboxes are filled
        ' if yes, messagebox
        ' else, reload?
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click, ClassListSBar.Click
        Enrollment1Form.Hide()
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub SearchPB_Click(sender As Object, e As EventArgs) Handles SearchPB.Click, SearchSBar.Click
        Enrollment1Form.Hide()
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub AddStaffPB_Click(sender As Object, e As EventArgs) Handles AddStaffPB.Click, AddStaffSBar.Click
        Enrollment1Form.Hide()
        Me.Hide()
        AddStaff.Show()
    End Sub

    Private Sub LogoutBtn_Click_1(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Enrollment1Form.Hide()
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Enrollment2Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub NewClass_Click(sender As Object, e As EventArgs) Handles NewClass_PB.Click, NewClass_Label.Click
        Me.Hide()
        NewSection.Show()
    End Sub
End Class