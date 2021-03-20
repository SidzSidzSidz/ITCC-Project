<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInformation))
        Me.Student_Info_Text = New System.Windows.Forms.Label()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LastName_Text = New System.Windows.Forms.TextBox()
        Me.FirstName_Text = New System.Windows.Forms.TextBox()
        Me.MiddleName_Text = New System.Windows.Forms.TextBox()
        Me.Address_Text = New System.Windows.Forms.TextBox()
        Me.LRN_Text = New System.Windows.Forms.TextBox()
        Me.Section_Text = New System.Windows.Forms.TextBox()
        Me.Edit_btn = New System.Windows.Forms.Button()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Student_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Personal_Info_Text = New System.Windows.Forms.Label()
        Me.Search_Label = New System.Windows.Forms.Label()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_Info_Text
        '
        Me.Student_Info_Text.AutoSize = True
        Me.Student_Info_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Student_Info_Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Student_Info_Text.Location = New System.Drawing.Point(358, 373)
        Me.Student_Info_Text.Name = "Student_Info_Text"
        Me.Student_Info_Text.Size = New System.Drawing.Size(251, 31)
        Me.Student_Info_Text.TabIndex = 6
        Me.Student_Info_Text.Text = "Student Information"
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Sidebar.Controls.Add(Me.Label8)
        Me.Sidebar.Controls.Add(Me.Label7)
        Me.Sidebar.Controls.Add(Me.Label6)
        Me.Sidebar.Controls.Add(Me.Button1)
        Me.Sidebar.Controls.Add(Me.Label5)
        Me.Sidebar.Controls.Add(Me.Label4)
        Me.Sidebar.Controls.Add(Me.Label3)
        Me.Sidebar.Controls.Add(Me.Label2)
        Me.Sidebar.Controls.Add(Me.Label1)
        Me.Sidebar.Controls.Add(Me.PictureBox2)
        Me.Sidebar.Controls.Add(Me.PictureBox3)
        Me.Sidebar.Controls.Add(Me.PictureBox8)
        Me.Sidebar.Controls.Add(Me.PictureBox4)
        Me.Sidebar.Controls.Add(Me.PictureBox7)
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(196, 720)
        Me.Sidebar.TabIndex = 5
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(46, 607)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(72, 467)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Add Staff"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(72, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(72, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Class List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(72, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enrollment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(13, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lorem Ipsum"
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
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(21, 387)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox8.Location = New System.Drawing.Point(21, 457)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(21, 317)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox7.Location = New System.Drawing.Point(21, 247)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 273)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LastName_Text
        '
        Me.LastName_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LastName_Text.Location = New System.Drawing.Point(330, 130)
        Me.LastName_Text.Name = "LastName_Text"
        Me.LastName_Text.Size = New System.Drawing.Size(306, 30)
        Me.LastName_Text.TabIndex = 7
        Me.LastName_Text.Text = "Last Name"
        '
        'FirstName_Text
        '
        Me.FirstName_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.FirstName_Text.Location = New System.Drawing.Point(330, 181)
        Me.FirstName_Text.Name = "FirstName_Text"
        Me.FirstName_Text.Size = New System.Drawing.Size(306, 30)
        Me.FirstName_Text.TabIndex = 8
        Me.FirstName_Text.Text = "First Name"
        '
        'MiddleName_Text
        '
        Me.MiddleName_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.MiddleName_Text.Location = New System.Drawing.Point(330, 231)
        Me.MiddleName_Text.Name = "MiddleName_Text"
        Me.MiddleName_Text.Size = New System.Drawing.Size(306, 30)
        Me.MiddleName_Text.TabIndex = 9
        Me.MiddleName_Text.Text = "Middle Name"
        '
        'Address_Text
        '
        Me.Address_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Address_Text.Location = New System.Drawing.Point(330, 278)
        Me.Address_Text.Name = "Address_Text"
        Me.Address_Text.Size = New System.Drawing.Size(306, 30)
        Me.Address_Text.TabIndex = 10
        Me.Address_Text.Text = "Address"
        '
        'LRN_Text
        '
        Me.LRN_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LRN_Text.Location = New System.Drawing.Point(330, 408)
        Me.LRN_Text.Name = "LRN_Text"
        Me.LRN_Text.Size = New System.Drawing.Size(306, 30)
        Me.LRN_Text.TabIndex = 11
        Me.LRN_Text.Text = "LRN"
        '
        'Section_Text
        '
        Me.Section_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Section_Text.Location = New System.Drawing.Point(330, 453)
        Me.Section_Text.Name = "Section_Text"
        Me.Section_Text.Size = New System.Drawing.Size(306, 30)
        Me.Section_Text.TabIndex = 12
        Me.Section_Text.Text = "Section"
        '
        'Edit_btn
        '
        Me.Edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Edit_btn.Location = New System.Drawing.Point(382, 505)
        Me.Edit_btn.Name = "Edit_btn"
        Me.Edit_btn.Size = New System.Drawing.Size(94, 35)
        Me.Edit_btn.TabIndex = 13
        Me.Edit_btn.Text = "Edit "
        Me.Edit_btn.UseVisualStyleBackColor = True
        '
        'Save_btn
        '
        Me.Save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Save_btn.Location = New System.Drawing.Point(485, 505)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(94, 35)
        Me.Save_btn.TabIndex = 14
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Student_PictureBox
        '
        Me.Student_PictureBox.Location = New System.Drawing.Point(793, 99)
        Me.Student_PictureBox.Name = "Student_PictureBox"
        Me.Student_PictureBox.Size = New System.Drawing.Size(282, 282)
        Me.Student_PictureBox.TabIndex = 15
        Me.Student_PictureBox.TabStop = False
        '
        'Personal_Info_Text
        '
        Me.Personal_Info_Text.AutoSize = True
        Me.Personal_Info_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Personal_Info_Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Personal_Info_Text.Location = New System.Drawing.Point(358, 95)
        Me.Personal_Info_Text.Name = "Personal_Info_Text"
        Me.Personal_Info_Text.Size = New System.Drawing.Size(264, 31)
        Me.Personal_Info_Text.TabIndex = 16
        Me.Personal_Info_Text.Text = "Personal Information"
        '
        'Search_Label
        '
        Me.Search_Label.AutoSize = True
        Me.Search_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Search_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Search_Label.Location = New System.Drawing.Point(216, 23)
        Me.Search_Label.Name = "Search_Label"
        Me.Search_Label.Size = New System.Drawing.Size(125, 39)
        Me.Search_Label.TabIndex = 17
        Me.Search_Label.Text = "Search"
        '
        'StudentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Search_Label)
        Me.Controls.Add(Me.Personal_Info_Text)
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
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "StudentInformation"
        Me.Text = "Student Information"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Student_Info_Text As Label
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LastName_Text As TextBox
    Friend WithEvents FirstName_Text As TextBox
    Friend WithEvents MiddleName_Text As TextBox
    Friend WithEvents Address_Text As TextBox
    Friend WithEvents LRN_Text As TextBox
    Friend WithEvents Section_Text As TextBox
    Friend WithEvents Edit_btn As Button
    Friend WithEvents Save_btn As Button
    Friend WithEvents Student_PictureBox As PictureBox
    Friend WithEvents Personal_Info_Text As Label
    Friend WithEvents Search_Label As Label
End Class
