Public Class StudentInformation
    Dim x As String = ""
    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        MsgBox("Information has been saved!")
        LastName_Text.ReadOnly = True
        FirstName_Text.ReadOnly = True
        MiddleName_Text.ReadOnly = True
        Address_Text.ReadOnly = True
        LRN_Text.ReadOnly = True
        Section_Text.ReadOnly = True
    End Sub

    Private Sub LastName_Text_Click(sender As Object, e As EventArgs) Handles LastName_Text.Click
        If LastName_Text.ReadOnly = False Then
            LastName_Text.Text = x
        End If
    End Sub

    Private Sub FirstName_Text_Click(sender As Object, e As EventArgs) Handles FirstName_Text.Click
        If FirstName_Text.ReadOnly = False Then
            FirstName_Text.Text = x
        End If
    End Sub

    Private Sub MiddleName_Text_Click(sender As Object, e As EventArgs) Handles MiddleName_Text.Click
        If MiddleName_Text.ReadOnly = False Then
            MiddleName_Text.Text = x
        End If
    End Sub

    Private Sub Address_Text_Click(sender As Object, e As EventArgs) Handles Address_Text.Click
        If Address_Text.ReadOnly = False Then
            Address_Text.Text = x
        End If
    End Sub

    Private Sub LRN_Text_Click(sender As Object, e As EventArgs) Handles LRN_Text.Click
        If LRN_Text.ReadOnly = False Then
            LRN_Text.Text = x
        End If
    End Sub

    Private Sub Section_Text_Click(sender As Object, e As EventArgs) Handles Section_Text.Click
        If Section_Text.ReadOnly = False Then
            Section_Text.Text = x
        End If
    End Sub

    Private Sub StudentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LastName_Text.ReadOnly = True
        FirstName_Text.ReadOnly = True
        MiddleName_Text.ReadOnly = True
        Address_Text.ReadOnly = True
        LRN_Text.ReadOnly = True
        Section_Text.ReadOnly = True
    End Sub

    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click
        LastName_Text.ReadOnly = False
        FirstName_Text.ReadOnly = False
        MiddleName_Text.ReadOnly = False
        Address_Text.ReadOnly = False
        LRN_Text.ReadOnly = False
        Section_Text.ReadOnly = False
    End Sub
End Class