Public Class Search

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click

        EnrollmentChoice.Show()
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
        If Me.EnrollmentTableAdapter1.SearchStudent(LRN_text.Text) = 1 Then
            Me.Hide()
            StudentInfo.Show()
        Else
            MsgBox("LRN not found.")
        End If
    End Sub

    Private Sub Search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub AddStaffSBar_Click(sender As Object, e As EventArgs) Handles AddStaffSBar.Click, AddStaffPB.Click
        Me.Hide()
        AddStaff.Show()
    End Sub

    Private Sub NewClass_Click(sender As Object, e As EventArgs) Handles NewClass_PB.Click, NewClass_Label.Click
        Me.Hide()
        NewSection.Show()
    End Sub

    Public Function GetLRN()
        Return LRN_text.Text
    End Function
End Class