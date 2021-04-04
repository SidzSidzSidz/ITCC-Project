Public Class Enrollment1Form

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'EnrollmentTableAdapter.Enrollment1Fn(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, NsoPictureBox., )

        Enrollment2Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click, SearchPB.Click
        Me.Hide()
        Search.Show()
    End Sub

    'Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
    ' reload?
    ' if 1: unfinished changes
    ' if 2: unfinished changes
    'End Sub

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles ClassListSBar.Click, CListPB.Click
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub AddStaffPB_Click(sender As Object, e As EventArgs) Handles AddStaffPB.Click, AddStaffSBar.Click
        Me.Hide()
        AddStaff.Show()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        ' TODO: check if textboxes are filled
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Enrollment1Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub NewClass_Click(sender As Object, e As EventArgs) Handles NewClass_PB.Click, NewClass_Label.Click
        Me.Hide()
        NewSection.Show()
    End Sub

    Private Sub EnrollmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EnrollmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Enrollment1Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

    End Sub
End Class