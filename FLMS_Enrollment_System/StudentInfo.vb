Imports System.IO
Public Class StudentInfo
    Dim lrn As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub EnrollmentSBar_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        Me.Hide()
        Enrollment1Form.Show()
    End Sub

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles ClassListSBar.Click, CListPB.Click
        Me.Hide()
        ClassList.Show()
    End Sub

    Private Sub AddStaffSBar_Click(sender As Object, e As EventArgs) Handles AddStaffSBar.Click, AddStaffPB.Click
        Me.Hide()
        AddStaff.Show()
    End Sub

    Private Sub StudentInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub NewClass_Click(sender As Object, e As EventArgs) Handles NewClass_PB.Click, NewClass_Label.Click
        Me.Hide()
        NewSection.Show()
    End Sub

    Private Sub StudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lrn = ""
        lrn = Search.GetLRN
        EnrollmentTableAdapter1.FillSearchedStudent(DatabaseDataSet.Enrollment, lrn)


        ' clear 
    End Sub

    Private Sub PicPictureBox_Click(sender As Object, e As EventArgs) Handles PicPictureBox.Click
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

    Private Sub NsoPictureBox_Click(sender As Object, e As EventArgs) Handles NsoPictureBox.Click
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

    Private Sub GmPictureBox_Click(sender As Object, e As EventArgs) Handles GmPictureBox.Click
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

    Private Sub RcPictureBox_Click(sender As Object, e As EventArgs) Handles RcPictureBox.Click
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

    Private Sub F137PictureBox_Click(sender As Object, e As EventArgs) Handles F137PictureBox.Click
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

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'EnrollmentTableAdapter.UpdateEnrollment(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, ConvertImageToByte(NsoPictureBox.Image), ConvertImageToByte(GmPictureBox.Image), ConvertImageToByte(RcPictureBox.Image), ConvertImageToByte(F137PictureBox.Image), ConvertImageToByte(PicPictureBox.Image))

        MsgBox("Changes saved.")
    End Sub

    Private Function ConvertImageToByte(ByVal img As Image)
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function
End Class