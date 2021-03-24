<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enrollment2Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enrollment2Form))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StudentsDTB = New System.Windows.Forms.DataGridView()
        Me.SectionBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.YearLevelBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EnrolleeName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NoStudentsLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SlotsLeftLabel = New System.Windows.Forms.Label()
        Me.EnrollBtn = New System.Windows.Forms.Button()
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
        CType(Me.StudentsDTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(265, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(295, 22)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "List of Students based on Database"
        '
        'StudentsDTB
        '
        Me.StudentsDTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDTB.Location = New System.Drawing.Point(232, 156)
        Me.StudentsDTB.Name = "StudentsDTB"
        Me.StudentsDTB.Size = New System.Drawing.Size(747, 495)
        Me.StudentsDTB.TabIndex = 13
        '
        'SectionBox
        '
        Me.SectionBox.FormattingEnabled = True
        Me.SectionBox.Location = New System.Drawing.Point(620, 116)
        Me.SectionBox.Name = "SectionBox"
        Me.SectionBox.Size = New System.Drawing.Size(177, 21)
        Me.SectionBox.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(559, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Section"
        '
        'YearLevelBox
        '
        Me.YearLevelBox.FormattingEnabled = True
        Me.YearLevelBox.Location = New System.Drawing.Point(306, 117)
        Me.YearLevelBox.Name = "YearLevelBox"
        Me.YearLevelBox.Size = New System.Drawing.Size(177, 21)
        Me.YearLevelBox.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(229, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Year level"
        '
        'EnrolleeName
        '
        Me.EnrolleeName.AutoSize = True
        Me.EnrolleeName.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.EnrolleeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnrolleeName.Location = New System.Drawing.Point(221, 13)
        Me.EnrolleeName.Name = "EnrolleeName"
        Me.EnrolleeName.Size = New System.Drawing.Size(403, 66)
        Me.EnrolleeName.TabIndex = 10
        Me.EnrolleeName.Text = "Name Of Enrollee"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.NoStudentsLabel)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.SlotsLeftLabel)
        Me.Panel1.Controls.Add(Me.EnrollBtn)
        Me.Panel1.Location = New System.Drawing.Point(985, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 495)
        Me.Panel1.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(49, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 22)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Number of Students"
        '
        'NoStudentsLabel
        '
        Me.NoStudentsLabel.AutoSize = True
        Me.NoStudentsLabel.BackColor = System.Drawing.Color.Transparent
        Me.NoStudentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!)
        Me.NoStudentsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NoStudentsLabel.Location = New System.Drawing.Point(92, 47)
        Me.NoStudentsLabel.Name = "NoStudentsLabel"
        Me.NoStudentsLabel.Size = New System.Drawing.Size(83, 91)
        Me.NoStudentsLabel.TabIndex = 5
        Me.NoStudentsLabel.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(90, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 22)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Slots Left"
        '
        'SlotsLeftLabel
        '
        Me.SlotsLeftLabel.AutoSize = True
        Me.SlotsLeftLabel.BackColor = System.Drawing.Color.Transparent
        Me.SlotsLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!)
        Me.SlotsLeftLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SlotsLeftLabel.Location = New System.Drawing.Point(92, 185)
        Me.SlotsLeftLabel.Name = "SlotsLeftLabel"
        Me.SlotsLeftLabel.Size = New System.Drawing.Size(83, 91)
        Me.SlotsLeftLabel.TabIndex = 5
        Me.SlotsLeftLabel.Text = "0"
        '
        'EnrollBtn
        '
        Me.EnrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollBtn.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnrollBtn.Location = New System.Drawing.Point(61, 384)
        Me.EnrollBtn.Name = "EnrollBtn"
        Me.EnrollBtn.Size = New System.Drawing.Size(145, 64)
        Me.EnrollBtn.TabIndex = 4
        Me.EnrollBtn.Text = "Enroll"
        Me.EnrollBtn.UseVisualStyleBackColor = True
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
        Me.Sidebar.TabIndex = 16
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
        Me.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutBtn.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.AddStaffSBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddStaffSBar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaffSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AddStaffSBar.Location = New System.Drawing.Point(72, 467)
        Me.AddStaffSBar.Name = "AddStaffSBar"
        Me.AddStaffSBar.Size = New System.Drawing.Size(98, 23)
        Me.AddStaffSBar.TabIndex = 3
        Me.AddStaffSBar.Text = "Add Staff"
        '
        'SearchSBar
        '
        Me.SearchSBar.AutoSize = True
        Me.SearchSBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchSBar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SearchSBar.Location = New System.Drawing.Point(72, 397)
        Me.SearchSBar.Name = "SearchSBar"
        Me.SearchSBar.Size = New System.Drawing.Size(77, 23)
        Me.SearchSBar.TabIndex = 3
        Me.SearchSBar.Text = "Search"
        '
        'ClassListSBar
        '
        Me.ClassListSBar.AutoSize = True
        Me.ClassListSBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClassListSBar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassListSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ClassListSBar.Location = New System.Drawing.Point(72, 327)
        Me.ClassListSBar.Name = "ClassListSBar"
        Me.ClassListSBar.Size = New System.Drawing.Size(97, 23)
        Me.ClassListSBar.TabIndex = 3
        Me.ClassListSBar.Text = "Class List"
        '
        'EnrollmentSBar
        '
        Me.EnrollmentSBar.AutoSize = True
        Me.EnrollmentSBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollmentSBar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentSBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnrollmentSBar.Location = New System.Drawing.Point(72, 257)
        Me.EnrollmentSBar.Name = "EnrollmentSBar"
        Me.EnrollmentSBar.Size = New System.Drawing.Size(111, 23)
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
        Me.SearchPB.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.AddStaffPB.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.CListPB.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.EnrollmentPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollmentPB.Image = CType(resources.GetObject("EnrollmentPB.Image"), System.Drawing.Image)
        Me.EnrollmentPB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EnrollmentPB.Location = New System.Drawing.Point(21, 247)
        Me.EnrollmentPB.Name = "EnrollmentPB"
        Me.EnrollmentPB.Size = New System.Drawing.Size(45, 45)
        Me.EnrollmentPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnrollmentPB.TabIndex = 2
        Me.EnrollmentPB.TabStop = False
        '
        'Enrollment2Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.StudentsDTB)
        Me.Controls.Add(Me.SectionBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.YearLevelBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.EnrolleeName)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Enrollment2Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrollment2Form"
        CType(Me.StudentsDTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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

    Friend WithEvents Label12 As Label
    Friend WithEvents StudentsDTB As DataGridView
    Friend WithEvents SectionBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents YearLevelBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents EnrolleeName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents NoStudentsLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SlotsLeftLabel As Label
    Friend WithEvents EnrollBtn As Button
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
