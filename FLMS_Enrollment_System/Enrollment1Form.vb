Imports System.IO

Public Class Enrollment1Form
    Private Function ConvertImageToByte(ByVal img As Image)
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        EnrollmentTableAdapter.Enrollment1Fn(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, ConvertImageToByte(NsoPictureBox.Image), ConvertImageToByte(GmPictureBox.Image), ConvertImageToByte(RcPictureBox.Image), ConvertImageToByte(F137PictureBox.Image), ConvertImageToByte(PicPictureBox.Image))

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

        OFD = Nothing
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

        OFD = Nothing
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

        OFD = Nothing
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

        OFD = Nothing
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

        OFD = Nothing
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

        OFD = Nothing
        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class