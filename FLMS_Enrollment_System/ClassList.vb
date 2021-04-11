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

        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment1' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment1' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.DatabaseDataSet.Sections)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'grade 7
        If ComboBox2.SelectedIndex = 0 Then
            SectionCBox.Items.Clear()
            SectionCBox.Items.Add("A")
            SectionCBox.Items.Add("B")
            SectionCBox.Items.Add("C")

            'grade 8
        ElseIf ComboBox2.SelectedIndex = 1 Then
            SectionCBox.Items.Clear()
            SectionCBox.Items.Add("D")
            SectionCBox.Items.Add("E")
            SectionCBox.Items.Add("F")

            'grade 9
        ElseIf ComboBox2.SelectedIndex = 2 Then
            SectionCBox.Items.Clear()
            SectionCBox.Items.Add("G")
            SectionCBox.Items.Add("H")
            SectionCBox.Items.Add("I")

            'grade 10
        ElseIf ComboBox2.SelectedIndex = 3 Then
            SectionCBox.Items.Clear()
            SectionCBox.Items.Add("J")
            SectionCBox.Items.Add("K")
            SectionCBox.Items.Add("L")

            'grade 11
        ElseIf ComboBox2.SelectedIndex = 4 Then
            SectionCBox.Items.Clear()
            SectionCBox.Items.Add("M")
            SectionCBox.Items.Add("N")
            SectionCBox.Items.Add("O")

            'grade 12
        ElseIf ComboBox2.SelectedIndex = 5 Then
            SectionCBox.Items.Clear()
            SectionCBox.Items.Add("Q")
            SectionCBox.Items.Add("R")
            SectionCBox.Items.Add("S")
        End If
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        EnrollmentTableAdapter.FillBySection(DatabaseDataSet.Enrollment, ComboBox1.Text, SectionCBox.Text, ComboBox2.Text)
    End Sub

    Private Sub FillBySectionToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EnrollmentTableAdapter.FillBySection(Me.DatabaseDataSet.Enrollment, SyToolStripTextBox.Text, SectionToolStripTextBox.Text, GradelevelToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySectionToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.EnrollmentTableAdapter.FillBySection(Me.DatabaseDataSet.Enrollment, SyToolStripTextBox.Text, SectionToolStripTextBox.Text, GradelevelToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySectionToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.EnrollmentTableAdapter.FillBySection(Me.DatabaseDataSet.Enrollment, SyToolStripTextBox.Text, SectionToolStripTextBox.Text, GradelevelToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySectionToolStripButton_Click_2(sender As Object, e As EventArgs)
        Try
            Me.EnrollmentTableAdapter.FillBySection(Me.DatabaseDataSet.Enrollment, SyToolStripTextBox.Text, SectionToolStripTextBox.Text, GradelevelToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySectionToolStripButton_Click_3(sender As Object, e As EventArgs) Handles FillBySectionToolStripButton.Click
        Try
            Me.EnrollmentTableAdapter.FillBySection(Me.DatabaseDataSet.Enrollment, SyToolStripTextBox.Text, SectionToolStripTextBox.Text, GradelevelToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySectionToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles FillBySectionToolStripButton1.Click
        Try
            Me.EnrollmentTableAdapter.FillBySection(Me.DatabaseDataSet.Enrollment, SyToolStripTextBox1.Text, SectionToolStripTextBox1.Text, GradelevelToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class