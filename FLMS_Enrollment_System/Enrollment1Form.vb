Imports System.IO

Public Class Enrollment1Form
    Private Function ConvertImageToByte(ByVal img As Image)
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Panel2.BringToFront()
        EnrolleeName.Text = LnameTextBox.Text + " " + FnameTextBox.Text + " " + MnameTextBox.Text
        'Dim section = ""
        'Dim lrn_sy = LrnTextBox.Text + SYTextBox.Text
        'EnrollmentTableAdapter.Enrollment1Fn(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, ConvertImageToByte(NsoPictureBox.Image), ConvertImageToByte(GmPictureBox.Image), ConvertImageToByte(RcPictureBox.Image), ConvertImageToByte(F137PictureBox.Image), ConvertImageToByte(PicPictureBox.Image), SYTextBox.Text, section, lrn_sy)
        'Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        'Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

        Panel2.Show()
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

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles CListPB.Click, ClassListSBar.Click
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub AddStaffPB_Click(sender As Object, e As EventArgs) Handles AddStaffSBar.Click, AddStaffPB.Click
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

    Private Sub EnrollmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EnrollmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Enrollment1Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections1' table. You can move, or remove it, as needed.
        Me.Sections1TableAdapter.Fill(Me.DatabaseDataSet.Sections1)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment1' table. You can move, or remove it, as needed.
        'Me.Enrollment1TableAdapter.Fill(Me.DatabaseDataSet.Enrollment1)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections' table. You can move, or remove it, as needed.
        'Me.SectionsTableAdapter.Fill(Me.DatabaseDataSet.Sections)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Sections' table. You can move, or remove it, as needed.
        'Me.SectionsTableAdapter.Fill(Me.DatabaseDataSet.Sections)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        'Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

    End Sub

    Private Sub NsoPictureBox_Click(sender As Object, e As EventArgs) Handles NsoPictureBox.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            NsoPictureBox.ImageLocation = imgpath

        End If

        OFD = Nothing
        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub GmPictureBox_Click(sender As Object, e As EventArgs) Handles GmPictureBox.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            GmPictureBox.ImageLocation = imgpath

        End If

        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub F137PictureBox_Click(sender As Object, e As EventArgs)
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            F137PictureBox.ImageLocation = imgpath

        End If

        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RcPictureBox_Click(sender As Object, e As EventArgs)
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            RcPictureBox.ImageLocation = imgpath

        End If

        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RcPictureBox_Click_1(sender As Object, e As EventArgs) Handles RcPictureBox.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            RcPictureBox.ImageLocation = imgpath

        End If

        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub F137PictureBox_Click_1(sender As Object, e As EventArgs) Handles F137PictureBox.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            F137PictureBox.ImageLocation = imgpath

        End If

        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub PicPictureBox_Click_1(sender As Object, e As EventArgs) Handles PicPictureBox.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        Dim imgpath
        OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            PicPictureBox.ImageLocation = imgpath

        End If

        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub YearLevelBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearLevelBox.SelectedIndexChanged
        'grade 7
        If YearLevelBox.SelectedIndex = 0 Then
            SectionBox.Items.Clear()
            SectionBox.Items.Add("A")
            SectionBox.Items.Add("B")
            SectionBox.Items.Add("C")

            'grade 8
        ElseIf YearLevelBox.SelectedIndex = 1 Then
            SectionBox.Items.Clear()
            SectionBox.Items.Add("D")
            SectionBox.Items.Add("E")
            SectionBox.Items.Add("F")

            'grade 9
        ElseIf YearLevelBox.SelectedIndex = 2 Then
            SectionBox.Items.Clear()
            SectionBox.Items.Add("G")
            SectionBox.Items.Add("H")
            SectionBox.Items.Add("I")

            'grade 10
        ElseIf YearLevelBox.SelectedIndex = 3 Then
            SectionBox.Items.Clear()
            SectionBox.Items.Add("J")
            SectionBox.Items.Add("K")
            SectionBox.Items.Add("L")

            'grade 11
        ElseIf YearLevelBox.SelectedIndex = 4 Then
            SectionBox.Items.Clear()
            SectionBox.Items.Add("M")
            SectionBox.Items.Add("N")
            SectionBox.Items.Add("O")

            'grade 12
        ElseIf YearLevelBox.SelectedIndex = 5 Then
            SectionBox.Items.Clear()
            SectionBox.Items.Add("Q")
            SectionBox.Items.Add("R")
            SectionBox.Items.Add("S")
        End If
    End Sub

    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        Dim section = SectionBox.Text
        Dim lrn_sy = LrnTextBox.Text + ComboBox1.Text
        'if new student
        EnrollmentTableAdapter.Enrollment1Fn(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, ConvertImageToByte(NsoPictureBox.Image), ConvertImageToByte(GmPictureBox.Image), ConvertImageToByte(RcPictureBox.Image), ConvertImageToByte(F137PictureBox.Image), ConvertImageToByte(PicPictureBox.Image), ComboBox1.Text, YearLevelBox.Text, section)
        'add to classlist
        Sections1TableAdapter.SectionFn(lrn_sy, YearLevelBox.Text, section, ComboBox1.Text, LrnTextBox.Text, LnameTextBox.Text, FnameTextBox.Text, MnameTextBox.Text, SexComboBox.Text)
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)

        clearboxes()
        Panel2.SendToBack()
        MsgBox("Student Enrolled")
    End Sub

    Public Sub clearboxes()
        LnameTextBox.Text = ""
        FnameTextBox.Text = ""
        MnameTextBox.Text = ""
        PicPictureBox.Image = Nothing
        SuffixTextBox.Text = ""
        LrnTextBox.Text = ""
        AddressTextBox.Text = ""
        GuardianTextBox.Text = ""
        LsaTextBox.Text = ""
        SexComboBox.Text = ""
        YrscTextBox.Text = ""
        YrcTextBox.Text = ""
        NsoPictureBox.Image = Nothing
        GmPictureBox.Image = Nothing
        RcPictureBox.Image = Nothing
        F137PictureBox.Image = Nothing
        ComboBox1.Text = ""
        YearLevelBox.Text = ""
        SectionBox.Text = ""
    End Sub

    Private Sub SectionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectionBox.SelectedIndexChanged
        Sections1TableAdapter.FillBySection(DatabaseDataSet.Sections1, ComboBox1.Text, SectionBox.Text, YearLevelBox.Text)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'update current student info
        EnrollmentTableAdapter.UpdateOld(ComboBox1.Text, YearLevelBox.Text, SectionBox.Text, OldEnrollment.LRN_TBox.Text)


        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet.Enrollment)
        MsgBox("Student Enrolled")
    End Sub
End Class