Public Class ClassList

    Private Sub ClassList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        EnrollmentChoice.Show()
    End Sub

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click, SearchPB.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub AddStaffPB_Click(sender As Object, e As EventArgs) Handles AddStaffPB.Click, AddStaffSBar.Click
        Me.Hide()
        AddStaff.Show()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub


    Private Sub NewClass_Click(sender As Object, e As EventArgs) Handles NewClass_PB.Click, NewClass_Label.Click
        Me.Hide()
        NewSection.Show()
    End Sub

    Private Sub SectionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SectionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub ClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.DatabaseDataSet.Sections)

    End Sub
End Class