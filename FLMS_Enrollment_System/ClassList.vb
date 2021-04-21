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

    Private Sub SectionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SectionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub ClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        'TODO: This line of code loads data into the 'DatabaseDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.DatabaseDataSet.Classes)

        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections1' table. You can move, or remove it, as needed.
        Me.Sections1TableAdapter.Fill(Me.DatabaseDataSet.Sections1)

        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'todo
        SectionCBox.Items.Clear()
        Dim Ikawbahala As DataTable
        Ikawbahala = ClassesTableAdapter.GetDataByClass(ComboBox1.Text, ComboBox2.Text)

        For Each row As DataRow In Ikawbahala.Rows
            SectionCBox.Items.Add(row("Name").ToString)
        Next

    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        Sections1TableAdapter.FillBySection(DatabaseDataSet.Sections1, ComboBox1.Text, SectionCBox.Text, ComboBox2.Text)
        ClassList_DGV.Visible = True
    End Sub

    Private Sub FillBySectionToolStripButton2_Click(sender As Object, e As EventArgs) Handles FillBySectionToolStripButton2.Click
        Try
            Me.Sections1TableAdapter.FillBySection(Me.DatabaseDataSet.Sections1, SyToolStripTextBox2.Text, SectionToolStripTextBox2.Text, YearlevelToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBySectionToolStripButton3_Click(sender As Object, e As EventArgs) Handles FillBySectionToolStripButton3.Click
        Try
            Me.Sections1TableAdapter.FillBySection(Me.DatabaseDataSet.Sections1, SyToolStripTextBox3.Text, SectionToolStripTextBox3.Text, YearlevelToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'add section pasabot ani kapoy change sa name sa button :)
    Private Sub AddStaff_btn_Click(sender As Object, e As EventArgs) Handles AddStaff_btn.Click
        Try
            Dim PrimaryKey = SYBox.Text + YearLevelBox.Text + SectionsBox.Text

            ClassesTableAdapter.InsertClass(PrimaryKey, SYBox.Text, YearLevelBox.Text, SectionsBox.Text, PasswordTextBox.Text)
            MsgBox("Class Created")
            PrimaryKey = Nothing
            SYBox.Text = Nothing
            YearLevelBox.Text = Nothing
            SectionsBox.Text = Nothing
            PasswordTextBox.Text = Nothing

        Catch ex As Exception
            MsgBox("Error Occured Try Again")

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SYBox.Text = Nothing
        YearLevelBox.Text = Nothing
        SectionsBox.Text = Nothing
        PasswordTextBox.Text = Nothing
        Panel2.BringToFront()
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click, ClassListSBar.Click
        Panel1.BringToFront()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = Nothing
        SectionCBox.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)






        ClassesTableAdapter.Update(DatabaseDataSet.Classes)
        ClassesTableAdapter.Fill(DatabaseDataSet.Classes)
        Sections1TableAdapter.Fill(DatabaseDataSet.Sections1)
        EnrollmentTableAdapter.Fill(DatabaseDataSet.Enrollment)

        'Sections1TableAdapter.UpdatSection()
    End Sub
End Class