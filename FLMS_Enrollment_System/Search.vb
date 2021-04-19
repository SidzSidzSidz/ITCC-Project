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
        ClassList.Panel1.BringToFront()
        ClassList.Show()
    End Sub

    Private Sub CListPB_Click(sender As Object, e As EventArgs) Handles CListPB.Click
        Me.Hide()
        Search1_Panel.BringToFront()
        ClassList.Show()
    End Sub

    Private Sub Search_btn_Click(sender As Object, e As EventArgs) Handles Search_btn.Click
        Dim Search = LRN_text.Text
        If Me.EnrollmentTableAdapter.SearchStudent(LRN_text.Text) = 1 Then
            Search1_Panel.SendToBack()
            EditInfo_Panel.BringToFront()
            EnrollmentTableAdapter.FillSearchedStudent(DatabaseDataSet1.Enrollment, Search)
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

    Public Function GetLRN()
        Return LRN_text.Text
    End Function


    Private Sub PicPictureBox_Click(sender As Object, e As EventArgs) Handles PicPictureBox.Click
        Static hits As Integer

        hits += 1
        'need twice to open picture box to save
        If hits >= 2 Then
            Try
                hits = 0
                Dim pic As Image
                pic = PicPictureBox.Image
                SaveFileDialog1.Filter = "JPEG (.jpeg) |*.jpeg"
                SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                SaveFileDialog1.ShowDialog()
                Dim path = SaveFileDialog1.FileName + ".jpeg"
                pic.Save(path)

                If System.IO.File.Exists(path) = True Then
                    Process.Start(path)
                Else
                    MsgBox("File not saved.")
                End If

            Catch ex As Exception

            End Try

        ElseIf hits = 1 Then
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

        End If

    End Sub

    Private Sub NsoPictureBox_Click(sender As Object, e As EventArgs) Handles NsoPictureBox.Click
        Static hits As Integer

        hits += 1
        'need twice to open picture box to save
        If hits >= 2 Then
            Try
                hits = 0
                Dim pic As Image
                pic = NsoPictureBox.Image
                SaveFileDialog1.Filter = "JPEG (.jpeg) |*.jpeg"
                SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                SaveFileDialog1.ShowDialog()
                Dim path = SaveFileDialog1.FileName + ".jpeg"
                pic.Save(path)

                If System.IO.File.Exists(path) = True Then
                    Process.Start(path)
                Else
                    MsgBox("File not saved.")
                End If

            Catch ex As Exception

            End Try

        ElseIf hits = 1 Then
            Dim OFD As FileDialog = New OpenFileDialog()
            Dim imgpath
            OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                NsoPictureBox.ImageLocation = imgpath

            End If

            Try
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try

        End If
    End Sub

    Private Sub GmPictureBox_Click(sender As Object, e As EventArgs) Handles GmPictureBox.Click
        Static hits As Integer

        hits += 1
        'need twice to open picture box to save
        If hits >= 2 Then
            Try
                hits = 0
                Dim pic As Image
                pic = GmPictureBox.Image
                SaveFileDialog1.Filter = "JPEG (.jpeg) |*.jpeg"
                SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                SaveFileDialog1.ShowDialog()
                Dim path = SaveFileDialog1.FileName + ".jpeg"
                pic.Save(path)

                If System.IO.File.Exists(path) = True Then
                    Process.Start(path)
                Else
                    MsgBox("File not saved.")
                End If

            Catch ex As Exception

            End Try

        ElseIf hits = 1 Then
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

        End If
    End Sub

    Private Sub RcPictureBox_Click(sender As Object, e As EventArgs) Handles RcPictureBox.Click
        Static hits As Integer

        hits += 1
        'need twice to open picture box to save
        If hits >= 2 Then
            Try
                hits = 0
                Dim pic As Image
                pic = RcPictureBox.Image
                SaveFileDialog1.Filter = "JPEG (.jpeg) |*.jpeg"
                SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                SaveFileDialog1.ShowDialog()
                Dim path = SaveFileDialog1.FileName + ".jpeg"
                pic.Save(path)

                If System.IO.File.Exists(path) = True Then
                    Process.Start(path)
                Else
                    MsgBox("File not saved.")
                End If

            Catch ex As Exception

            End Try

        ElseIf hits = 1 Then
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

        End If
    End Sub

    Private Sub F137PictureBox_Click(sender As Object, e As EventArgs) Handles F137PictureBox.Click
        Static hits As Integer

        hits += 1
        'need twice to open picture box to save
        If hits >= 2 Then
            Try
                hits = 0
                Dim pic As Image
                pic = F137PictureBox.Image
                SaveFileDialog1.Filter = "JPEG (.jpeg) |*.jpeg"
                SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                SaveFileDialog1.ShowDialog()
                Dim path = SaveFileDialog1.FileName + ".jpeg"
                pic.Save(path)

                If System.IO.File.Exists(path) = True Then
                    Process.Start(path)
                Else
                    MsgBox("File not saved.")
                End If

            Catch ex As Exception

            End Try

        ElseIf hits = 1 Then
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

        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'updates student based on lrn
        EnrollmentTableAdapter.UpdateEnrollment(LrnTextBox.Text, LnameTextBox.Text, MnameTextBox.Text, FnameTextBox.Text, SuffixTextBox.Text, DobDateTimePicker.Text, AddressTextBox.Text, GuardianTextBox.Text, LsaTextBox.Text, SexComboBox.Text, YrscTextBox.Text, YrcTextBox.Text, ConvertImageToByte(NsoPictureBox.Image), ConvertImageToByte(GmPictureBox.Image), ConvertImageToByte(RcPictureBox.Image), ConvertImageToByte(F137PictureBox.Image), ConvertImageToByte(PicPictureBox.Image))
        Sections1TableAdapter1.UpdateStudentInfo(LrnTextBox.Text, LnameTextBox.Text, FnameTextBox.Text, MnameTextBox.Text, SexComboBox.Text, LrnTextBox.Text)

        ClassList.Sections1TableAdapter.Fill(ClassList.DatabaseDataSet.Sections1)

        'TODO: This line of code loads data into the 'DatabaseDataSet.Enrollment' table. You can move, or remove it, as needed.
        ClassList.EnrollmentTableAdapter.Fill(ClassList.DatabaseDataSet.Enrollment)

        'Me.EnrollmentTableAdapter.Update(Me.DatabaseDataSet1.Enrollment)
        'Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet1.Enrollment)
        MsgBox("Changes saved.")
        LRN_text.Text = ""
        Enrollment1Form.clearboxes()
        Search1_Panel.BringToFront()
    End Sub

    Private Function ConvertImageToByte(ByVal img As Image)
        If img Is Nothing Then

        Else
            Using mStream As New MemoryStream()
                img.Save(mStream, img.RawFormat)
                Return mStream.ToArray()
            End Using
        End If
    End Function

    Private Sub SearchSBar_Click(sender As Object, e As EventArgs) Handles SearchSBar.Click, SearchPB.Click
        Search1_Panel.BringToFront()
        EditInfo_Panel.SendToBack()
    End Sub

    Private Sub EditInfo_Panel_Paint(sender As Object, e As PaintEventArgs) Handles EditInfo_Panel.Paint
        EditInfo_Panel.Show()
        Search1_Panel.Show()

    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Enrollment1' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DatabaseDataSet1.Enrollment)
        Search1_Panel.BringToFront()
    End Sub

End Class