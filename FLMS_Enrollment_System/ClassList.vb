﻿Public Class ClassList

    Private Sub ClassList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        Me.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click, SearchPB.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub AddStaffPB_Click(sender As Object, e As EventArgs) Handles AddStaffPB.Click, AddStaffSBar.Click
        'add staff
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class