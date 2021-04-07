Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If StaffTableAdapter.CheckStaffFn(UserTbox.Text, PasswordTBox.Text) = 1 Then
            Me.Hide()
            Search.Show()
        Else
            MsgBox("Incorrect Username or Password")
        End If
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DatabaseDataSet.Staff)

    End Sub
End Class
