<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LRN_Label = New System.Windows.Forms.Label()
        Me.LRN_text = New System.Windows.Forms.TextBox()
        Me.Search_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Search1_Panel = New System.Windows.Forms.Panel()
        Me.EditInfo_Panel = New System.Windows.Forms.Panel()
        Me.F137PictureBox = New System.Windows.Forms.PictureBox()
        Me.EnrollmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New FLMS_Enrollment_System.DatabaseDataSet()
        Me.RcPictureBox = New System.Windows.Forms.PictureBox()
        Me.GmPictureBox = New System.Windows.Forms.PictureBox()
        Me.NsoPictureBox = New System.Windows.Forms.PictureBox()
        Me.YrscTextBox = New System.Windows.Forms.TextBox()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.LsaTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.GuardianTextBox = New System.Windows.Forms.TextBox()
        Me.MnameTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.SuffixTextBox = New System.Windows.Forms.TextBox()
        Me.LrnTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.YrcTextBox = New System.Windows.Forms.TextBox()
        Me.PicPictureBox = New System.Windows.Forms.PictureBox()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.EnrollmentTableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.EnrollmentTableAdapter()
        Me.Sections1TableAdapter1 = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.Sections1TableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Search1_Panel.SuspendLayout()
        Me.EditInfo_Panel.SuspendLayout()
        CType(Me.F137PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RcPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GmPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NsoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Sidebar.TabIndex = 8
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
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LRN_Label
        '
        Me.LRN_Label.AutoSize = True
        Me.LRN_Label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LRN_Label.Location = New System.Drawing.Point(487, 296)
        Me.LRN_Label.Name = "LRN_Label"
        Me.LRN_Label.Size = New System.Drawing.Size(90, 33)
        Me.LRN_Label.TabIndex = 10
        Me.LRN_Label.Text = "ENTER"
        '
        'LRN_text
        '
        Me.LRN_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN_text.Location = New System.Drawing.Point(248, 342)
        Me.LRN_text.Name = "LRN_text"
        Me.LRN_text.Size = New System.Drawing.Size(569, 38)
        Me.LRN_text.TabIndex = 11
        Me.LRN_text.Text = "LRN"
        '
        'Search_btn
        '
        Me.Search_btn.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_btn.Location = New System.Drawing.Point(486, 406)
        Me.Search_btn.Name = "Search_btn"
        Me.Search_btn.Size = New System.Drawing.Size(92, 42)
        Me.Search_btn.TabIndex = 12
        Me.Search_btn.Text = "Search"
        Me.Search_btn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(42, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(367, 66)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Search Student"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Search1_Panel)
        Me.Panel1.Controls.Add(Me.EditInfo_Panel)
        Me.Panel1.Location = New System.Drawing.Point(196, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 681)
        Me.Panel1.TabIndex = 13
        '
        'Search1_Panel
        '
        Me.Search1_Panel.Controls.Add(Me.Label9)
        Me.Search1_Panel.Controls.Add(Me.Search_btn)
        Me.Search1_Panel.Controls.Add(Me.LRN_text)
        Me.Search1_Panel.Controls.Add(Me.LRN_Label)
        Me.Search1_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Search1_Panel.Name = "Search1_Panel"
        Me.Search1_Panel.Size = New System.Drawing.Size(1069, 681)
        Me.Search1_Panel.TabIndex = 13
        '
        'EditInfo_Panel
        '
        Me.EditInfo_Panel.Controls.Add(Me.F137PictureBox)
        Me.EditInfo_Panel.Controls.Add(Me.RcPictureBox)
        Me.EditInfo_Panel.Controls.Add(Me.GmPictureBox)
        Me.EditInfo_Panel.Controls.Add(Me.NsoPictureBox)
        Me.EditInfo_Panel.Controls.Add(Me.YrscTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.SexComboBox)
        Me.EditInfo_Panel.Controls.Add(Me.LsaTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.AddressTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.GuardianTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.MnameTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.FnameTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.LnameTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.SuffixTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.LrnTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.DobDateTimePicker)
        Me.EditInfo_Panel.Controls.Add(Me.YrcTextBox)
        Me.EditInfo_Panel.Controls.Add(Me.PicPictureBox)
        Me.EditInfo_Panel.Controls.Add(Me.NextBtn)
        Me.EditInfo_Panel.Controls.Add(Me.Label10)
        Me.EditInfo_Panel.Controls.Add(Me.Label12)
        Me.EditInfo_Panel.Controls.Add(Me.Label25)
        Me.EditInfo_Panel.Controls.Add(Me.Label11)
        Me.EditInfo_Panel.Controls.Add(Me.Label13)
        Me.EditInfo_Panel.Controls.Add(Me.Label14)
        Me.EditInfo_Panel.Controls.Add(Me.Label15)
        Me.EditInfo_Panel.Controls.Add(Me.Label16)
        Me.EditInfo_Panel.Controls.Add(Me.Label20)
        Me.EditInfo_Panel.Controls.Add(Me.Label22)
        Me.EditInfo_Panel.Controls.Add(Me.Label23)
        Me.EditInfo_Panel.Controls.Add(Me.Label24)
        Me.EditInfo_Panel.Controls.Add(Me.Label26)
        Me.EditInfo_Panel.Controls.Add(Me.Label27)
        Me.EditInfo_Panel.Controls.Add(Me.Label28)
        Me.EditInfo_Panel.Controls.Add(Me.Label29)
        Me.EditInfo_Panel.Controls.Add(Me.Label30)
        Me.EditInfo_Panel.Location = New System.Drawing.Point(0, 0)
        Me.EditInfo_Panel.Name = "EditInfo_Panel"
        Me.EditInfo_Panel.Size = New System.Drawing.Size(1069, 681)
        Me.EditInfo_Panel.TabIndex = 13
        '
        'F137PictureBox
        '
        Me.F137PictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.F137PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F137PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.F137PictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EnrollmentBindingSource, "f137", True))
        Me.F137PictureBox.Location = New System.Drawing.Point(652, 552)
        Me.F137PictureBox.Name = "F137PictureBox"
        Me.F137PictureBox.Size = New System.Drawing.Size(107, 102)
        Me.F137PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F137PictureBox.TabIndex = 135
        Me.F137PictureBox.TabStop = False
        '
        'EnrollmentBindingSource
        '
        Me.EnrollmentBindingSource.DataMember = "Enrollment"
        Me.EnrollmentBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RcPictureBox
        '
        Me.RcPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.RcPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RcPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RcPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EnrollmentBindingSource, "rc", True))
        Me.RcPictureBox.Location = New System.Drawing.Point(469, 552)
        Me.RcPictureBox.Name = "RcPictureBox"
        Me.RcPictureBox.Size = New System.Drawing.Size(107, 102)
        Me.RcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RcPictureBox.TabIndex = 134
        Me.RcPictureBox.TabStop = False
        '
        'GmPictureBox
        '
        Me.GmPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GmPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GmPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GmPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EnrollmentBindingSource, "gm", True))
        Me.GmPictureBox.Location = New System.Drawing.Point(285, 552)
        Me.GmPictureBox.Name = "GmPictureBox"
        Me.GmPictureBox.Size = New System.Drawing.Size(107, 102)
        Me.GmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GmPictureBox.TabIndex = 133
        Me.GmPictureBox.TabStop = False
        '
        'NsoPictureBox
        '
        Me.NsoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NsoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NsoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NsoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EnrollmentBindingSource, "nso", True))
        Me.NsoPictureBox.Location = New System.Drawing.Point(102, 553)
        Me.NsoPictureBox.Name = "NsoPictureBox"
        Me.NsoPictureBox.Size = New System.Drawing.Size(108, 101)
        Me.NsoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NsoPictureBox.TabIndex = 132
        Me.NsoPictureBox.TabStop = False
        '
        'YrscTextBox
        '
        Me.YrscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "yrsc", True))
        Me.YrscTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.YrscTextBox.Location = New System.Drawing.Point(560, 441)
        Me.YrscTextBox.Name = "YrscTextBox"
        Me.YrscTextBox.Size = New System.Drawing.Size(129, 26)
        Me.YrscTextBox.TabIndex = 131
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "sex", True))
        Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SexComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.SexComboBox.Location = New System.Drawing.Point(413, 438)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(127, 28)
        Me.SexComboBox.TabIndex = 129
        '
        'LsaTextBox
        '
        Me.LsaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "lsa", True))
        Me.LsaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LsaTextBox.Location = New System.Drawing.Point(102, 441)
        Me.LsaTextBox.Name = "LsaTextBox"
        Me.LsaTextBox.Size = New System.Drawing.Size(277, 26)
        Me.LsaTextBox.TabIndex = 128
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(104, 330)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(523, 26)
        Me.AddressTextBox.TabIndex = 127
        '
        'GuardianTextBox
        '
        Me.GuardianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "guardian", True))
        Me.GuardianTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GuardianTextBox.Location = New System.Drawing.Point(651, 330)
        Me.GuardianTextBox.Name = "GuardianTextBox"
        Me.GuardianTextBox.Size = New System.Drawing.Size(325, 26)
        Me.GuardianTextBox.TabIndex = 126
        '
        'MnameTextBox
        '
        Me.MnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "mname", True))
        Me.MnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MnameTextBox.Location = New System.Drawing.Point(589, 133)
        Me.MnameTextBox.Name = "MnameTextBox"
        Me.MnameTextBox.Size = New System.Drawing.Size(217, 26)
        Me.MnameTextBox.TabIndex = 123
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "fname", True))
        Me.FnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FnameTextBox.Location = New System.Drawing.Point(345, 133)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(216, 26)
        Me.FnameTextBox.TabIndex = 122
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "lname", True))
        Me.LnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LnameTextBox.Location = New System.Drawing.Point(102, 133)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.LnameTextBox.TabIndex = 121
        '
        'SuffixTextBox
        '
        Me.SuffixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "suffix", True))
        Me.SuffixTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SuffixTextBox.Location = New System.Drawing.Point(102, 238)
        Me.SuffixTextBox.Name = "SuffixTextBox"
        Me.SuffixTextBox.Size = New System.Drawing.Size(220, 26)
        Me.SuffixTextBox.TabIndex = 124
        '
        'LrnTextBox
        '
        Me.LrnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "lrn", True))
        Me.LrnTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LrnTextBox.Location = New System.Drawing.Point(345, 238)
        Me.LrnTextBox.Name = "LrnTextBox"
        Me.LrnTextBox.Size = New System.Drawing.Size(325, 26)
        Me.LrnTextBox.TabIndex = 120
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "dob", True))
        Me.DobDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DobDateTimePicker.Location = New System.Drawing.Point(699, 238)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(277, 27)
        Me.DobDateTimePicker.TabIndex = 125
        '
        'YrcTextBox
        '
        Me.YrcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "yrc", True))
        Me.YrcTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.YrcTextBox.Location = New System.Drawing.Point(713, 441)
        Me.YrcTextBox.Name = "YrcTextBox"
        Me.YrcTextBox.Size = New System.Drawing.Size(263, 26)
        Me.YrcTextBox.TabIndex = 130
        '
        'PicPictureBox
        '
        Me.PicPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EnrollmentBindingSource, "pic", True))
        Me.PicPictureBox.Location = New System.Drawing.Point(830, 62)
        Me.PicPictureBox.Name = "PicPictureBox"
        Me.PicPictureBox.Size = New System.Drawing.Size(146, 129)
        Me.PicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPictureBox.TabIndex = 136
        Me.PicPictureBox.TabStop = False
        '
        'NextBtn
        '
        Me.NextBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.NextBtn.Location = New System.Drawing.Point(830, 552)
        Me.NextBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(146, 63)
        Me.NextBtn.TabIndex = 119
        Me.NextBtn.Text = "Save"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(709, 416)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Year Completed"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(409, 417)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 20)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Sex"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(647, 530)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 20)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "Form 137"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(648, 308)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 20)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Parent/Guardian"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(695, 215)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Date of Birth"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(585, 111)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 20)
        Me.Label14.TabIndex = 116
        Me.Label14.Text = "Middle Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(342, 217)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 20)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "LRN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(556, 416)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 20)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Yrs Completed"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(465, 530)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 20)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "Report Card"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(281, 530)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 20)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "Good Moral"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(99, 530)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 20)
        Me.Label23.TabIndex = 102
        Me.Label23.Text = "NSO"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(99, 417)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(144, 20)
        Me.Label24.TabIndex = 108
        Me.Label24.Text = "Last School Attend"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(99, 308)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 20)
        Me.Label26.TabIndex = 107
        Me.Label26.Text = "Address"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(99, 217)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 20)
        Me.Label27.TabIndex = 106
        Me.Label27.Text = "Suffix"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(341, 111)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 20)
        Me.Label28.TabIndex = 105
        Me.Label28.Text = "First Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(91, 16)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(382, 66)
        Me.Label29.TabIndex = 104
        Me.Label29.Text = "Edit Information"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(100, 111)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(85, 20)
        Me.Label30.TabIndex = 103
        Me.Label30.Text = "Last Name"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EnrollmentTableAdapter = Nothing
        Me.TableAdapterManager.Sections1TableAdapter = Nothing
        Me.TableAdapterManager.SectionsTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FLMS_Enrollment_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EnrollmentTableAdapter
        '
        Me.EnrollmentTableAdapter.ClearBeforeFill = True
        '
        'Sections1TableAdapter1
        '
        Me.Sections1TableAdapter1.ClearBeforeFill = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1265, 681)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLMS Enrollment System"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Search1_Panel.ResumeLayout(False)
        Me.Search1_Panel.PerformLayout()
        Me.EditInfo_Panel.ResumeLayout(False)
        Me.EditInfo_Panel.PerformLayout()
        CType(Me.F137PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RcPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GmPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NsoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LRN_Label As Label
    Friend WithEvents LRN_text As TextBox
    Friend WithEvents Search_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EditInfo_Panel As Panel
    Friend WithEvents Search1_Panel As Panel
    Friend WithEvents F137PictureBox As PictureBox
    Friend WithEvents RcPictureBox As PictureBox
    Friend WithEvents GmPictureBox As PictureBox
    Friend WithEvents NsoPictureBox As PictureBox
    Friend WithEvents YrscTextBox As TextBox
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents LsaTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents GuardianTextBox As TextBox
    Friend WithEvents MnameTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents SuffixTextBox As TextBox
    Friend WithEvents LrnTextBox As TextBox
    Friend WithEvents DobDateTimePicker As DateTimePicker
    Friend WithEvents YrcTextBox As TextBox
    Friend WithEvents PicPictureBox As PictureBox
    Friend WithEvents NextBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents DatabaseDataSet1 As DatabaseDataSet
    Friend WithEvents EnrollmentBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EnrollmentTableAdapter As DatabaseDataSetTableAdapters.EnrollmentTableAdapter
    Friend WithEvents Sections1TableAdapter1 As DatabaseDataSetTableAdapters.Sections1TableAdapter
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
