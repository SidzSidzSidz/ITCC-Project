<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClassList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassList))
        Me.ClassList_DGV = New System.Windows.Forms.DataGridView()
        Me.DatabaseDataSet = New FLMS_Enrollment_System.DatabaseDataSet()
        Me.SectionCBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NewClass_Label = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NewClass_PB = New System.Windows.Forms.PictureBox()
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FillBySectionToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SyToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SyToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SectionToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SectionToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GradelevelToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.GradelevelToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBySectionToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EnrollmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionsTableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.SectionsTableAdapter()
        Me.TableAdapterManager = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.LrnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuffixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LsaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrscDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NsoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GmDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RcDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.F137DataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PicDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradelevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LrnsyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollmentTableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.EnrollmentTableAdapter()
        Me.FillBySectionToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SyToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SyToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SectionToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SectionToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.GradelevelToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GradelevelToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBySectionToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.ClassList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        CType(Me.NewClass_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBySectionToolStrip.SuspendLayout()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBySectionToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClassList_DGV
        '
        Me.ClassList_DGV.AllowUserToAddRows = False
        Me.ClassList_DGV.AllowUserToDeleteRows = False
        Me.ClassList_DGV.AutoGenerateColumns = False
        Me.ClassList_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClassList_DGV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClassList_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClassList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LrnDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.SuffixDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.GuardianDataGridViewTextBoxColumn, Me.LsaDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.YrcDataGridViewTextBoxColumn, Me.YrscDataGridViewTextBoxColumn, Me.NsoDataGridViewImageColumn, Me.GmDataGridViewImageColumn, Me.RcDataGridViewImageColumn, Me.F137DataGridViewImageColumn, Me.PicDataGridViewImageColumn, Me.SyDataGridViewTextBoxColumn, Me.GradelevelDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.LrnsyDataGridViewTextBoxColumn})
        Me.ClassList_DGV.DataSource = Me.EnrollmentBindingSource
        Me.ClassList_DGV.Location = New System.Drawing.Point(267, 131)
        Me.ClassList_DGV.Name = "ClassList_DGV"
        Me.ClassList_DGV.ReadOnly = True
        Me.ClassList_DGV.Size = New System.Drawing.Size(956, 519)
        Me.ClassList_DGV.TabIndex = 16
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SectionCBox
        '
        Me.SectionCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SectionCBox.FormattingEnabled = True
        Me.SectionCBox.Location = New System.Drawing.Point(925, 84)
        Me.SectionCBox.Name = "SectionCBox"
        Me.SectionCBox.Size = New System.Drawing.Size(179, 21)
        Me.SectionCBox.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(856, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Section"
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
        Me.SelectBtn.Location = New System.Drawing.Point(1139, 76)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(84, 31)
        Me.SelectBtn.TabIndex = 15
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Sidebar.Controls.Add(Me.Label1)
        Me.Sidebar.Controls.Add(Me.Label8)
        Me.Sidebar.Controls.Add(Me.NewClass_Label)
        Me.Sidebar.Controls.Add(Me.Label7)
        Me.Sidebar.Controls.Add(Me.NewClass_PB)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "-----------------------------------------------------"
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
        'NewClass_Label
        '
        Me.NewClass_Label.AutoSize = True
        Me.NewClass_Label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewClass_Label.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewClass_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NewClass_Label.Location = New System.Drawing.Point(70, 538)
        Me.NewClass_Label.Name = "NewClass_Label"
        Me.NewClass_Label.Size = New System.Drawing.Size(112, 23)
        Me.NewClass_Label.TabIndex = 19
        Me.NewClass_Label.Text = "New Class"
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
        'NewClass_PB
        '
        Me.NewClass_PB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewClass_PB.Image = CType(resources.GetObject("NewClass_PB.Image"), System.Drawing.Image)
        Me.NewClass_PB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NewClass_PB.Location = New System.Drawing.Point(19, 528)
        Me.NewClass_PB.Name = "NewClass_PB"
        Me.NewClass_PB.Size = New System.Drawing.Size(45, 45)
        Me.NewClass_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NewClass_PB.TabIndex = 18
        Me.NewClass_PB.TabStop = False
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
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12", ""})
        Me.ComboBox2.Location = New System.Drawing.Point(636, 84)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(542, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Year Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(271, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "S.Y."
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2026-2027", "2028-2029"})
        Me.ComboBox1.Location = New System.Drawing.Point(314, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'FillBySectionToolStrip
        '
        Me.FillBySectionToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyToolStripLabel, Me.SyToolStripTextBox, Me.SectionToolStripLabel, Me.SectionToolStripTextBox, Me.GradelevelToolStripLabel, Me.GradelevelToolStripTextBox, Me.FillBySectionToolStripButton})
        Me.FillBySectionToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBySectionToolStrip.Name = "FillBySectionToolStrip"
        Me.FillBySectionToolStrip.Size = New System.Drawing.Size(1264, 25)
        Me.FillBySectionToolStrip.TabIndex = 20
        Me.FillBySectionToolStrip.Text = "FillBySectionToolStrip"
        Me.FillBySectionToolStrip.Visible = False
        '
        'SyToolStripLabel
        '
        Me.SyToolStripLabel.Name = "SyToolStripLabel"
        Me.SyToolStripLabel.Size = New System.Drawing.Size(21, 22)
        Me.SyToolStripLabel.Text = "sy:"
        '
        'SyToolStripTextBox
        '
        Me.SyToolStripTextBox.Name = "SyToolStripTextBox"
        Me.SyToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SectionToolStripLabel
        '
        Me.SectionToolStripLabel.Name = "SectionToolStripLabel"
        Me.SectionToolStripLabel.Size = New System.Drawing.Size(48, 22)
        Me.SectionToolStripLabel.Text = "section:"
        '
        'SectionToolStripTextBox
        '
        Me.SectionToolStripTextBox.Name = "SectionToolStripTextBox"
        Me.SectionToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'GradelevelToolStripLabel
        '
        Me.GradelevelToolStripLabel.Name = "GradelevelToolStripLabel"
        Me.GradelevelToolStripLabel.Size = New System.Drawing.Size(64, 22)
        Me.GradelevelToolStripLabel.Text = "gradelevel:"
        '
        'GradelevelToolStripTextBox
        '
        Me.GradelevelToolStripTextBox.Name = "GradelevelToolStripTextBox"
        Me.GradelevelToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBySectionToolStripButton
        '
        Me.FillBySectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBySectionToolStripButton.Name = "FillBySectionToolStripButton"
        Me.FillBySectionToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.FillBySectionToolStripButton.Text = "FillBySection"
        '
        'EnrollmentBindingSource
        '
        Me.EnrollmentBindingSource.DataMember = "Enrollment"
        Me.EnrollmentBindingSource.DataSource = Me.DatabaseDataSet
        '
        'SectionsBindingSource
        '
        Me.SectionsBindingSource.DataMember = "Sections"
        Me.SectionsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'SectionsTableAdapter
        '
        Me.SectionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EnrollmentTableAdapter = Nothing
        Me.TableAdapterManager.SectionsTableAdapter = Me.SectionsTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FLMS_Enrollment_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LrnDataGridViewTextBoxColumn
        '
        Me.LrnDataGridViewTextBoxColumn.DataPropertyName = "lrn"
        Me.LrnDataGridViewTextBoxColumn.HeaderText = "LRN"
        Me.LrnDataGridViewTextBoxColumn.Name = "LrnDataGridViewTextBoxColumn"
        Me.LrnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuffixDataGridViewTextBoxColumn
        '
        Me.SuffixDataGridViewTextBoxColumn.DataPropertyName = "suffix"
        Me.SuffixDataGridViewTextBoxColumn.HeaderText = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.Name = "SuffixDataGridViewTextBoxColumn"
        Me.SuffixDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        Me.DobDataGridViewTextBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'GuardianDataGridViewTextBoxColumn
        '
        Me.GuardianDataGridViewTextBoxColumn.DataPropertyName = "guardian"
        Me.GuardianDataGridViewTextBoxColumn.HeaderText = "guardian"
        Me.GuardianDataGridViewTextBoxColumn.Name = "GuardianDataGridViewTextBoxColumn"
        Me.GuardianDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuardianDataGridViewTextBoxColumn.Visible = False
        '
        'LsaDataGridViewTextBoxColumn
        '
        Me.LsaDataGridViewTextBoxColumn.DataPropertyName = "lsa"
        Me.LsaDataGridViewTextBoxColumn.HeaderText = "lsa"
        Me.LsaDataGridViewTextBoxColumn.Name = "LsaDataGridViewTextBoxColumn"
        Me.LsaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LsaDataGridViewTextBoxColumn.Visible = False
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexDataGridViewTextBoxColumn.Visible = False
        '
        'YrcDataGridViewTextBoxColumn
        '
        Me.YrcDataGridViewTextBoxColumn.DataPropertyName = "yrc"
        Me.YrcDataGridViewTextBoxColumn.HeaderText = "yrc"
        Me.YrcDataGridViewTextBoxColumn.Name = "YrcDataGridViewTextBoxColumn"
        Me.YrcDataGridViewTextBoxColumn.ReadOnly = True
        Me.YrcDataGridViewTextBoxColumn.Visible = False
        '
        'YrscDataGridViewTextBoxColumn
        '
        Me.YrscDataGridViewTextBoxColumn.DataPropertyName = "yrsc"
        Me.YrscDataGridViewTextBoxColumn.HeaderText = "yrsc"
        Me.YrscDataGridViewTextBoxColumn.Name = "YrscDataGridViewTextBoxColumn"
        Me.YrscDataGridViewTextBoxColumn.ReadOnly = True
        Me.YrscDataGridViewTextBoxColumn.Visible = False
        '
        'NsoDataGridViewImageColumn
        '
        Me.NsoDataGridViewImageColumn.DataPropertyName = "nso"
        Me.NsoDataGridViewImageColumn.HeaderText = "nso"
        Me.NsoDataGridViewImageColumn.Name = "NsoDataGridViewImageColumn"
        Me.NsoDataGridViewImageColumn.ReadOnly = True
        Me.NsoDataGridViewImageColumn.Visible = False
        '
        'GmDataGridViewImageColumn
        '
        Me.GmDataGridViewImageColumn.DataPropertyName = "gm"
        Me.GmDataGridViewImageColumn.HeaderText = "gm"
        Me.GmDataGridViewImageColumn.Name = "GmDataGridViewImageColumn"
        Me.GmDataGridViewImageColumn.ReadOnly = True
        Me.GmDataGridViewImageColumn.Visible = False
        '
        'RcDataGridViewImageColumn
        '
        Me.RcDataGridViewImageColumn.DataPropertyName = "rc"
        Me.RcDataGridViewImageColumn.HeaderText = "rc"
        Me.RcDataGridViewImageColumn.Name = "RcDataGridViewImageColumn"
        Me.RcDataGridViewImageColumn.ReadOnly = True
        Me.RcDataGridViewImageColumn.Visible = False
        '
        'F137DataGridViewImageColumn
        '
        Me.F137DataGridViewImageColumn.DataPropertyName = "f137"
        Me.F137DataGridViewImageColumn.HeaderText = "f137"
        Me.F137DataGridViewImageColumn.Name = "F137DataGridViewImageColumn"
        Me.F137DataGridViewImageColumn.ReadOnly = True
        Me.F137DataGridViewImageColumn.Visible = False
        '
        'PicDataGridViewImageColumn
        '
        Me.PicDataGridViewImageColumn.DataPropertyName = "pic"
        Me.PicDataGridViewImageColumn.HeaderText = "pic"
        Me.PicDataGridViewImageColumn.Name = "PicDataGridViewImageColumn"
        Me.PicDataGridViewImageColumn.ReadOnly = True
        Me.PicDataGridViewImageColumn.Visible = False
        '
        'SyDataGridViewTextBoxColumn
        '
        Me.SyDataGridViewTextBoxColumn.DataPropertyName = "sy"
        Me.SyDataGridViewTextBoxColumn.HeaderText = "sy"
        Me.SyDataGridViewTextBoxColumn.Name = "SyDataGridViewTextBoxColumn"
        Me.SyDataGridViewTextBoxColumn.ReadOnly = True
        Me.SyDataGridViewTextBoxColumn.Visible = False
        '
        'GradelevelDataGridViewTextBoxColumn
        '
        Me.GradelevelDataGridViewTextBoxColumn.DataPropertyName = "gradelevel"
        Me.GradelevelDataGridViewTextBoxColumn.HeaderText = "gradelevel"
        Me.GradelevelDataGridViewTextBoxColumn.Name = "GradelevelDataGridViewTextBoxColumn"
        Me.GradelevelDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradelevelDataGridViewTextBoxColumn.Visible = False
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectionDataGridViewTextBoxColumn.Visible = False
        '
        'LrnsyDataGridViewTextBoxColumn
        '
        Me.LrnsyDataGridViewTextBoxColumn.DataPropertyName = "lrn_sy"
        Me.LrnsyDataGridViewTextBoxColumn.HeaderText = "lrn_sy"
        Me.LrnsyDataGridViewTextBoxColumn.Name = "LrnsyDataGridViewTextBoxColumn"
        Me.LrnsyDataGridViewTextBoxColumn.ReadOnly = True
        Me.LrnsyDataGridViewTextBoxColumn.Visible = False
        '
        'EnrollmentTableAdapter
        '
        Me.EnrollmentTableAdapter.ClearBeforeFill = True
        '
        'FillBySectionToolStrip1
        '
        Me.FillBySectionToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyToolStripLabel1, Me.SyToolStripTextBox1, Me.SectionToolStripLabel1, Me.SectionToolStripTextBox1, Me.GradelevelToolStripLabel1, Me.GradelevelToolStripTextBox1, Me.FillBySectionToolStripButton1})
        Me.FillBySectionToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillBySectionToolStrip1.Name = "FillBySectionToolStrip1"
        Me.FillBySectionToolStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.FillBySectionToolStrip1.TabIndex = 21
        Me.FillBySectionToolStrip1.Text = "FillBySectionToolStrip1"
        Me.FillBySectionToolStrip1.Visible = False
        '
        'SyToolStripLabel1
        '
        Me.SyToolStripLabel1.Name = "SyToolStripLabel1"
        Me.SyToolStripLabel1.Size = New System.Drawing.Size(21, 22)
        Me.SyToolStripLabel1.Text = "sy:"
        '
        'SyToolStripTextBox1
        '
        Me.SyToolStripTextBox1.Name = "SyToolStripTextBox1"
        Me.SyToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'SectionToolStripLabel1
        '
        Me.SectionToolStripLabel1.Name = "SectionToolStripLabel1"
        Me.SectionToolStripLabel1.Size = New System.Drawing.Size(48, 15)
        Me.SectionToolStripLabel1.Text = "section:"
        '
        'SectionToolStripTextBox1
        '
        Me.SectionToolStripTextBox1.Name = "SectionToolStripTextBox1"
        Me.SectionToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'GradelevelToolStripLabel1
        '
        Me.GradelevelToolStripLabel1.Name = "GradelevelToolStripLabel1"
        Me.GradelevelToolStripLabel1.Size = New System.Drawing.Size(64, 15)
        Me.GradelevelToolStripLabel1.Text = "gradelevel:"
        '
        'GradelevelToolStripTextBox1
        '
        Me.GradelevelToolStripTextBox1.Name = "GradelevelToolStripTextBox1"
        Me.GradelevelToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'FillBySectionToolStripButton1
        '
        Me.FillBySectionToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBySectionToolStripButton1.Name = "FillBySectionToolStripButton1"
        Me.FillBySectionToolStripButton1.Size = New System.Drawing.Size(78, 19)
        Me.FillBySectionToolStripButton1.Text = "FillBySection"
        '
        'ClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.FillBySectionToolStrip1)
        Me.Controls.Add(Me.FillBySectionToolStrip)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.ClassList_DGV)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SectionCBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SelectBtn)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ClassList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLMS Enrollment System"
        CType(Me.ClassList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.NewClass_PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBySectionToolStrip.ResumeLayout(False)
        Me.FillBySectionToolStrip.PerformLayout()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBySectionToolStrip1.ResumeLayout(False)
        Me.FillBySectionToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClassList_DGV As DataGridView
    Friend WithEvents SectionCBox As ComboBox
    Friend WithEvents Label11 As Label
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
    Friend WithEvents Label1 As Label
    Friend WithEvents NewClass_Label As Label
    Friend WithEvents NewClass_PB As PictureBox
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents SectionsBindingSource As BindingSource
    Friend WithEvents SectionsTableAdapter As DatabaseDataSetTableAdapters.SectionsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EnrollmentBindingSource As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FillBySectionToolStrip As ToolStrip
    Friend WithEvents SyToolStripLabel As ToolStripLabel
    Friend WithEvents SyToolStripTextBox As ToolStripTextBox
    Friend WithEvents SectionToolStripLabel As ToolStripLabel
    Friend WithEvents SectionToolStripTextBox As ToolStripTextBox
    Friend WithEvents GradelevelToolStripLabel As ToolStripLabel
    Friend WithEvents GradelevelToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBySectionToolStripButton As ToolStripButton
    Friend WithEvents LrnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuffixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LsaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YrcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YrscDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NsoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents GmDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents RcDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents F137DataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents PicDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents SyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradelevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LrnsyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnrollmentTableAdapter As DatabaseDataSetTableAdapters.EnrollmentTableAdapter
    Friend WithEvents FillBySectionToolStrip1 As ToolStrip
    Friend WithEvents SyToolStripLabel1 As ToolStripLabel
    Friend WithEvents SyToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SectionToolStripLabel1 As ToolStripLabel
    Friend WithEvents SectionToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents GradelevelToolStripLabel1 As ToolStripLabel
    Friend WithEvents GradelevelToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBySectionToolStripButton1 As ToolStripButton
End Class
