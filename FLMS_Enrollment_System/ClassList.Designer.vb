<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassList))
        Me.ClassList_DGV = New System.Windows.Forms.DataGridView()
        Me.SectionCBox = New System.Windows.Forms.ComboBox()
        Me.YLCBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SelectBtn = New System.Windows.Forms.Button()
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
        CType(Me.ClassList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassList_DGV
        '
        Me.ClassList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassList_DGV.Location = New System.Drawing.Point(267, 131)
        Me.ClassList_DGV.Name = "ClassList_DGV"
        Me.ClassList_DGV.Size = New System.Drawing.Size(956, 519)
        Me.ClassList_DGV.TabIndex = 16
        '
        'SectionCBox
        '
        Me.SectionCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SectionCBox.FormattingEnabled = True
        Me.SectionCBox.Location = New System.Drawing.Point(646, 84)
        Me.SectionCBox.Name = "SectionCBox"
        Me.SectionCBox.Size = New System.Drawing.Size(179, 21)
        Me.SectionCBox.TabIndex = 14
        '
        'YLCBox
        '
        Me.YLCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YLCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.YLCBox.FormattingEnabled = True
        Me.YLCBox.Location = New System.Drawing.Point(357, 84)
        Me.YLCBox.Name = "YLCBox"
        Me.YLCBox.Size = New System.Drawing.Size(179, 21)
        Me.YLCBox.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(577, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Section"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(263, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Year Level"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(256, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 66)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Class List"
        '
        'SelectBtn
        '
        Me.SelectBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.SelectBtn.Location = New System.Drawing.Point(860, 78)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(84, 31)
        Me.SelectBtn.TabIndex = 15
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
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
        Me.Sidebar.TabIndex = 17
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
        'ClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.ClassList_DGV)
        Me.Controls.Add(Me.SectionCBox)
        Me.Controls.Add(Me.YLCBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SelectBtn)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ClassList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClassList"
        CType(Me.ClassList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents ClassList_DGV As DataGridView
    Friend WithEvents SectionCBox As ComboBox
    Friend WithEvents YLCBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SelectBtn As Button
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
