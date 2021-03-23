<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInfo))
        Me.Search_Label = New System.Windows.Forms.Label()
        Me.Student_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Edit_btn = New System.Windows.Forms.Button()
        Me.Section_Text = New System.Windows.Forms.TextBox()
        Me.LRN_Text = New System.Windows.Forms.TextBox()
        Me.Address_Text = New System.Windows.Forms.TextBox()
        Me.MiddleName_Text = New System.Windows.Forms.TextBox()
        Me.FirstName_Text = New System.Windows.Forms.TextBox()
        Me.LastName_Text = New System.Windows.Forms.TextBox()
        Me.Student_Info_Text = New System.Windows.Forms.Label()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.AddStaffSBar = New System.Windows.Forms.Label()
        Me.SearchSBar = New System.Windows.Forms.Label()
        Me.ClassListSBar = New System.Windows.Forms.Label()
        Me.EnrollmentSBar = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SearchPB = New System.Windows.Forms.PictureBox()
        Me.AddStaffPB = New System.Windows.Forms.PictureBox()
        Me.CListPB = New System.Windows.Forms.PictureBox()
        Me.EnrollmentPB = New System.Windows.Forms.PictureBox()
        CType(Me.Student_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search_Label
        '
        Me.Search_Label.AutoSize = True
        Me.Search_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Search_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Search_Label.Location = New System.Drawing.Point(216, 23)
        Me.Search_Label.Name = "Search_Label"
        Me.Search_Label.Size = New System.Drawing.Size(125, 39)
        Me.Search_Label.TabIndex = 29
        Me.Search_Label.Text = "Search"
        '
        'Student_PictureBox
        '
        Me.Student_PictureBox.Location = New System.Drawing.Point(793, 99)
        Me.Student_PictureBox.Name = "Student_PictureBox"
        Me.Student_PictureBox.Size = New System.Drawing.Size(282, 282)
        Me.Student_PictureBox.TabIndex = 28
        Me.Student_PictureBox.TabStop = False
        '
        'Save_btn
        '
        Me.Save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Save_btn.Location = New System.Drawing.Point(485, 505)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(94, 35)
        Me.Save_btn.TabIndex = 27
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Edit_btn
        '
        Me.Edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Edit_btn.Location = New System.Drawing.Point(382, 505)
        Me.Edit_btn.Name = "Edit_btn"
        Me.Edit_btn.Size = New System.Drawing.Size(94, 35)
        Me.Edit_btn.TabIndex = 26
        Me.Edit_btn.Text = "Edit "
        Me.Edit_btn.UseVisualStyleBackColor = True
        '
        'Section_Text
        '
        Me.Section_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Section_Text.Location = New System.Drawing.Point(330, 453)
        Me.Section_Text.Name = "Section_Text"
        Me.Section_Text.Size = New System.Drawing.Size(306, 30)
        Me.Section_Text.TabIndex = 25
        Me.Section_Text.Text = "Section"
        '
        'LRN_Text
        '
        Me.LRN_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LRN_Text.Location = New System.Drawing.Point(330, 408)
        Me.LRN_Text.Name = "LRN_Text"
        Me.LRN_Text.Size = New System.Drawing.Size(306, 30)
        Me.LRN_Text.TabIndex = 24
        Me.LRN_Text.Text = "LRN"
        '
        'Address_Text
        '
        Me.Address_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Address_Text.Location = New System.Drawing.Point(330, 278)
        Me.Address_Text.Name = "Address_Text"
        Me.Address_Text.Size = New System.Drawing.Size(306, 30)
        Me.Address_Text.TabIndex = 23
        Me.Address_Text.Text = "Address"
        '
        'MiddleName_Text
        '
        Me.MiddleName_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.MiddleName_Text.Location = New System.Drawing.Point(330, 231)
        Me.MiddleName_Text.Name = "MiddleName_Text"
        Me.MiddleName_Text.Size = New System.Drawing.Size(306, 30)
        Me.MiddleName_Text.TabIndex = 22
        Me.MiddleName_Text.Text = "Middle Name"
        '
        'FirstName_Text
        '
        Me.FirstName_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.FirstName_Text.Location = New System.Drawing.Point(330, 181)
        Me.FirstName_Text.Name = "FirstName_Text"
        Me.FirstName_Text.Size = New System.Drawing.Size(306, 30)
        Me.FirstName_Text.TabIndex = 21
        Me.FirstName_Text.Text = "First Name"
        '
        'LastName_Text
        '
        Me.LastName_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LastName_Text.Location = New System.Drawing.Point(330, 130)
        Me.LastName_Text.Name = "LastName_Text"
        Me.LastName_Text.Size = New System.Drawing.Size(306, 30)
        Me.LastName_Text.TabIndex = 20
        Me.LastName_Text.Text = "Last Name"
        '
        'Student_Info_Text
        '
        Me.Student_Info_Text.AutoSize = True
        Me.Student_Info_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Student_Info_Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Student_Info_Text.Location = New System.Drawing.Point(358, 373)
        Me.Student_Info_Text.Name = "Student_Info_Text"
        Me.Student_Info_Text.Size = New System.Drawing.Size(251, 31)
        Me.Student_Info_Text.TabIndex = 19
        Me.Student_Info_Text.Text = "Student Information"
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Sidebar.Controls.Add(Me.Label8)
        Me.Sidebar.Controls.Add(Me.Label7)
        Me.Sidebar.Controls.Add(Me.Label6)
        Me.Sidebar.Controls.Add(Me.LogoutBtn)
        Me.Sidebar.Controls.Add(Me.AddStaffSBar)
        Me.Sidebar.Controls.Add(Me.SearchSBar)
        Me.Sidebar.Controls.Add(Me.ClassListSBar)
        Me.Sidebar.Controls.Add(Me.EnrollmentSBar)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Controls.Add(Me.SearchPB)
        Me.Sidebar.Controls.Add(Me.AddStaffPB)
        Me.Sidebar.Controls.Add(Me.CListPB)
        Me.Sidebar.Controls.Add(Me.EnrollmentPB)
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(196, 692)
        Me.Sidebar.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(18, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "-----------------------------------------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(16, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "-----------------------------------------------------"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(18, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "-----------------------------------------------------"
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LogoutBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LogoutBtn.Location = New System.Drawing.Point(46, 607)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(105, 44)
        Me.LogoutBtn.TabIndex = 4
        Me.LogoutBtn.Text = "Log Out"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'AddStaffSBar
        '
        Me.AddStaffSBar.AutoSize = True
        Me.AddStaffSBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.AddStaffSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AddStaffSBar.Location = New System.Drawing.Point(72, 467)
        Me.AddStaffSBar.Name = "AddStaffSBar"
        Me.AddStaffSBar.Size = New System.Drawing.Size(93, 25)
        Me.AddStaffSBar.TabIndex = 3
        Me.AddStaffSBar.Text = "Add Staff"
        '
        'SearchSBar
        '
        Me.SearchSBar.AutoSize = True
        Me.SearchSBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.SearchSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SearchSBar.Location = New System.Drawing.Point(72, 397)
        Me.SearchSBar.Name = "SearchSBar"
        Me.SearchSBar.Size = New System.Drawing.Size(75, 25)
        Me.SearchSBar.TabIndex = 3
        Me.SearchSBar.Text = "Search"
        '
        'ClassListSBar
        '
        Me.ClassListSBar.AutoSize = True
        Me.ClassListSBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ClassListSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ClassListSBar.Location = New System.Drawing.Point(72, 327)
        Me.ClassListSBar.Name = "ClassListSBar"
        Me.ClassListSBar.Size = New System.Drawing.Size(97, 25)
        Me.ClassListSBar.TabIndex = 3
        Me.ClassListSBar.Text = "Class List"
        '
        'EnrollmentSBar
        '
        Me.EnrollmentSBar.AutoSize = True
        Me.EnrollmentSBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.EnrollmentSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnrollmentSBar.Location = New System.Drawing.Point(72, 257)
        Me.EnrollmentSBar.Name = "EnrollmentSBar"
        Me.EnrollmentSBar.Size = New System.Drawing.Size(104, 25)
        Me.EnrollmentSBar.TabIndex = 3
        Me.EnrollmentSBar.Text = "Enrollment"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 175)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'SearchPB
        '
        Me.SearchPB.Image = CType(resources.GetObject("SearchPB.Image"), System.Drawing.Image)
        Me.SearchPB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SearchPB.Location = New System.Drawing.Point(21, 387)
        Me.SearchPB.Name = "SearchPB"
        Me.SearchPB.Size = New System.Drawing.Size(45, 45)
        Me.SearchPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SearchPB.TabIndex = 2
        Me.SearchPB.TabStop = False
        '
        'AddStaffPB
        '
        Me.AddStaffPB.Image = CType(resources.GetObject("AddStaffPB.Image"), System.Drawing.Image)
        Me.AddStaffPB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AddStaffPB.Location = New System.Drawing.Point(21, 457)
        Me.AddStaffPB.Name = "AddStaffPB"
        Me.AddStaffPB.Size = New System.Drawing.Size(45, 45)
        Me.AddStaffPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AddStaffPB.TabIndex = 2
        Me.AddStaffPB.TabStop = False
        '
        'CListPB
        '
        Me.CListPB.Image = CType(resources.GetObject("CListPB.Image"), System.Drawing.Image)
        Me.CListPB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CListPB.Location = New System.Drawing.Point(21, 317)
        Me.CListPB.Name = "CListPB"
        Me.CListPB.Size = New System.Drawing.Size(45, 45)
        Me.CListPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CListPB.TabIndex = 2
        Me.CListPB.TabStop = False
        '
        'EnrollmentPB
        '
        Me.EnrollmentPB.Image = CType(resources.GetObject("EnrollmentPB.Image"), System.Drawing.Image)
        Me.EnrollmentPB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnrollmentPB.Location = New System.Drawing.Point(21, 247)
        Me.EnrollmentPB.Name = "EnrollmentPB"
        Me.EnrollmentPB.Size = New System.Drawing.Size(45, 45)
        Me.EnrollmentPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnrollmentPB.TabIndex = 2
        Me.EnrollmentPB.TabStop = False
        '
        'StudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.Search_Label)
        Me.Controls.Add(Me.Student_PictureBox)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.Edit_btn)
        Me.Controls.Add(Me.Section_Text)
        Me.Controls.Add(Me.LRN_Text)
        Me.Controls.Add(Me.Address_Text)
        Me.Controls.Add(Me.MiddleName_Text)
        Me.Controls.Add(Me.FirstName_Text)
        Me.Controls.Add(Me.LastName_Text)
        Me.Controls.Add(Me.Student_Info_Text)
        Me.Name = "StudentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInfo"
        CType(Me.Student_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search_Label As Label
    Friend WithEvents Student_PictureBox As PictureBox
    Friend WithEvents Save_btn As Button
    Friend WithEvents Edit_btn As Button
    Friend WithEvents Section_Text As TextBox
    Friend WithEvents LRN_Text As TextBox
    Friend WithEvents Address_Text As TextBox
    Friend WithEvents MiddleName_Text As TextBox
    Friend WithEvents FirstName_Text As TextBox
    Friend WithEvents LastName_Text As TextBox
    Friend WithEvents Student_Info_Text As Label
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents AddStaffSBar As Label
    Friend WithEvents SearchSBar As Label
    Friend WithEvents ClassListSBar As Label
    Friend WithEvents EnrollmentSBar As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SearchPB As PictureBox
    Friend WithEvents AddStaffPB As PictureBox
    Friend WithEvents CListPB As PictureBox
    Friend WithEvents EnrollmentPB As PictureBox
End Class
