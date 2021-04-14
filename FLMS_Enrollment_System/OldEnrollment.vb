Public Class OldEnrollment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enter_btn.Click
        Me.Hide()
        Dim Name = EnrollmentTableAdapter.GetLName(LRN_TBox.Text) + ", " + EnrollmentTableAdapter.GetFName(LRN_TBox.Text) + " " + EnrollmentTableAdapter.GetMName(LRN_TBox.Text)
        Enrollment1Form.EnrollmentTableAdapter.FillSearchedStudent(DatabaseDataSet.Enrollment, LRN_TBox.Text)
        Enrollment1Form.EnrolleeName.Text = Name
        Enrollment1Form.UpdateButton.BringToFront()
        Enrollment1Form.Panel2.BringToFront()
        Enrollment1Form.Show()
    End Sub

    Private Sub EnrollmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EnrollmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub OldEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

    End Sub
End Class