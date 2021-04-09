Public Class NewSection
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

    Private Sub SectionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SectionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub NewSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.DatabaseDataSet.Sections)
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

        SYTextBox.Text = ""
        YearLevelComboBox.Text = ""
        SectionTextBox.Text = ""
        MaxStudentsTextBox.Text = ""
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Dim PrimaryKey = SYTextBox.Text + " " + YearLevelComboBox.Text + " " + SectionTextBox.Text

        SectionsTableAdapter.SectionFn(YearLevelComboBox.Text, SectionTextBox.Text, MaxStudentsTextBox.Text, SYTextBox.Text, PrimaryKey)
        Me.SectionsTableAdapter.Update(DatabaseDataSet.Sections)
        Me.SectionsTableAdapter.Fill(Me.DatabaseDataSet.Sections)
        MsgBox("Section Created")
    End Sub

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles ClassListSBar.Click, CListPB.Click
        Me.Hide()
        ClassList.Show()
    End Sub
End Class