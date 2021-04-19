Public Class AddStaff

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        Me.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click, ClassListSBar.Click
        Me.Hide()
        ClassList.Show()
        ClassList.Panel1.BringToFront()
    End Sub

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click, SearchPB.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub AddStaff_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet.Staff)
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

        'Sets textboxes to blank
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub AddStaff_btn_Click(sender As Object, e As EventArgs) Handles AddStaff_btn.Click
        Try
            StaffTableAdapter.StaffFn(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text)
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            Me.StaffTableAdapter.Fill(Me.DatabaseDataSet.Staff)
            MsgBox("Staff Added")
        Catch
            MsgBox("Username Already Taken")
        End Try
    End Sub
End Class