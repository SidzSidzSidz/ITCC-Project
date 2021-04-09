Imports System.IO
Public Class Search

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Search1_Panel.BringToFront()
        Login.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles EnrollmentSBar.Click, EnrollmentPB.Click
        Search1_Panel.BringToFront()
        EnrollmentChoice.Show()
    End Sub

    Private Sub ClassListSBar_Click(sender As Object, e As EventArgs) Handles ClassListSBar.Click
        Me.Hide()
        Search1_Panel.BringToFront()
        ClassList.Show()
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click
        Me.Hide()
        Search1_Panel.BringToFront()
        ClassList.Show()
    End Sub

    Private Sub Search_btn_Click(sender As Object, e As EventArgs) Handles Search_btn.Click
        If Me.EnrollmentTableAdapter1.SearchStudent(LRN_text.Text) = 1 Then
            Search1_Panel.SendToBack()
            EditInfo_Panel.BringToFront()
            EnrollmentTableAdapter1.FillSearchedStudent(DatabaseDataSet1.Enrollment, LRN_text.Text)
        Else
            MsgBox("LRN not found.")
        End If
    End Sub

    Private Sub Search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub AddStaffSBar_Click(sender As Object, e As EventArgs) Handles AddStaffSBar.Click, AddStaffPB.Click
        Me.Hide()
        AddStaff.Show()
    End Sub

    Private Sub NewClass_Click(sender As Object, e As EventArgs) Handles NewClass_PB.Click, NewClass_Label.Click
        Me.Hide()
        NewSection.Show()
    End Sub

    Public Function GetLRN()
        Return LRN_text.Text
    End Function

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
        EnrollmentTableAdapter1.UpdateEnrollment(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, ConvertImageToByte(NsoPictureBox.Image), ConvertImageToByte(GmPictureBox.Image), ConvertImageToByte(RcPictureBox.Image), ConvertImageToByte(F137PictureBox.Image), ConvertImageToByte(PicPictureBox.Image))

        MsgBox("Changes saved.")
    End Sub

    Private Function ConvertImageToByte(ByVal img As Image)
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click, SearchPB.Click
        Search1_Panel.BringToFront()
        EditInfo_Panel.SendToBack()
    End Sub

    Private Sub EditInfo_Panel_Paint(sender As Object, e As PaintEventArgs) Handles EditInfo_Panel.Paint
        EditInfo_Panel.Show()
        Search1_Panel.Show()

    End Sub
End Class