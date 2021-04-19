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
        'TODO: update datagrid table


        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections1' table. You can move, or remove it, as needed.
        Me.Sections1TableAdapter.Fill(Me.DatabaseDataSet.Sections1)

        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'todo
        Dim Ikawbahala As DataTable
        Ikawbahala = ClassesTableAdapter.GetDataByClass(ComboBox1.Text, YearLevelBox.Text)

        For Each row As DataRow In Ikawbahala.Rows
            MsgBox(row.ToString)
            SectionCBox.Items.Add(Ikawbahala(row.ToString))
        Next


        ''grade 7
        'If ComboBox2.SelectedIndex = 0 Then
        '    SectionCBox.Items.Clear()
        '    SectionCBox.Items.Add("A")
        '    SectionCBox.Items.Add("B")
        '    SectionCBox.Items.Add("C")

        '    'grade 8
        'ElseIf ComboBox2.SelectedIndex = 1 Then
        '    SectionCBox.Items.Clear()
        '    SectionCBox.Items.Add("D")
        '    SectionCBox.Items.Add("E")
        '    SectionCBox.Items.Add("F")

        '    'grade 9
        'ElseIf ComboBox2.SelectedIndex = 2 Then
        '    SectionCBox.Items.Clear()
        '    SectionCBox.Items.Add("G")
        '    SectionCBox.Items.Add("H")
        '    SectionCBox.Items.Add("I")

        '    'grade 10
        'ElseIf ComboBox2.SelectedIndex = 3 Then
        '    SectionCBox.Items.Clear()
        '    SectionCBox.Items.Add("J")
        '    SectionCBox.Items.Add("K")
        '    SectionCBox.Items.Add("L")

        '    'grade 11
        'ElseIf ComboBox2.SelectedIndex = 4 Then
        '    SectionCBox.Items.Clear()
        '    SectionCBox.Items.Add("M")
        '    SectionCBox.Items.Add("N")
        '    SectionCBox.Items.Add("O")

        '    'grade 12
        'ElseIf ComboBox2.SelectedIndex = 5 Then
        '    SectionCBox.Items.Clear()
        '    SectionCBox.Items.Add("Q")
        '    SectionCBox.Items.Add("R")
        '    SectionCBox.Items.Add("S")
        'End If
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

    Private Sub SectionCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectionCBox.SelectedIndexChanged

    End Sub
End Class