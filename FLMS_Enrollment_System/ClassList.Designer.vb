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
        Me.Sections1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New FLMS_Enrollment_System.DatabaseDataSet()
        Me.SectionCBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.FillBySectionToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SyToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SyToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SectionToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SectionToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.GradelevelToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GradelevelToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBySectionToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.FillBySectionToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.SyToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SyToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.SectionToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SectionToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.YearlevelToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.YearlevelToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBySectionToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.FillBySectionToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.SyToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.SyToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.SectionToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.SectionToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.YearlevelToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.YearlevelToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBySectionToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.EnrollmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.EnrollmentTableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.EnrollmentTableAdapter()
        Me.Sections1TableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.Sections1TableAdapter()
        Me.LrnSyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ClassList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sections1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBySectionToolStrip.SuspendLayout()
        Me.FillBySectionToolStrip1.SuspendLayout()
        Me.FillBySectionToolStrip2.SuspendLayout()
        Me.FillBySectionToolStrip3.SuspendLayout()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ClassList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LrnSyDataGridViewTextBoxColumn, Me.YearLevelDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.SYDataGridViewTextBoxColumn, Me.LRNDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn})
        Me.ClassList_DGV.DataSource = Me.Sections1BindingSource
        Me.ClassList_DGV.Location = New System.Drawing.Point(267, 131)
        Me.ClassList_DGV.Name = "ClassList_DGV"
        Me.ClassList_DGV.ReadOnly = True
        Me.ClassList_DGV.Size = New System.Drawing.Size(956, 519)
        Me.ClassList_DGV.TabIndex = 16
        '
        'Sections1BindingSource
        '
        Me.Sections1BindingSource.DataMember = "Sections1"
        Me.Sections1BindingSource.DataSource = Me.DatabaseDataSet
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
        Me.SyToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'SectionToolStripLabel1
        '
        Me.SectionToolStripLabel1.Name = "SectionToolStripLabel1"
        Me.SectionToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.SectionToolStripLabel1.Text = "section:"
        '
        'SectionToolStripTextBox1
        '
        Me.SectionToolStripTextBox1.Name = "SectionToolStripTextBox1"
        Me.SectionToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'GradelevelToolStripLabel1
        '
        Me.GradelevelToolStripLabel1.Name = "GradelevelToolStripLabel1"
        Me.GradelevelToolStripLabel1.Size = New System.Drawing.Size(64, 22)
        Me.GradelevelToolStripLabel1.Text = "gradelevel:"
        '
        'GradelevelToolStripTextBox1
        '
        Me.GradelevelToolStripTextBox1.Name = "GradelevelToolStripTextBox1"
        Me.GradelevelToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillBySectionToolStripButton1
        '
        Me.FillBySectionToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBySectionToolStripButton1.Name = "FillBySectionToolStripButton1"
        Me.FillBySectionToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.FillBySectionToolStripButton1.Text = "FillBySection"
        '
        'FillBySectionToolStrip2
        '
        Me.FillBySectionToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyToolStripLabel2, Me.SyToolStripTextBox2, Me.SectionToolStripLabel2, Me.SectionToolStripTextBox2, Me.YearlevelToolStripLabel, Me.YearlevelToolStripTextBox, Me.FillBySectionToolStripButton2})
        Me.FillBySectionToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.FillBySectionToolStrip2.Name = "FillBySectionToolStrip2"
        Me.FillBySectionToolStrip2.Size = New System.Drawing.Size(1264, 25)
        Me.FillBySectionToolStrip2.TabIndex = 22
        Me.FillBySectionToolStrip2.Text = "FillBySectionToolStrip2"
        Me.FillBySectionToolStrip2.Visible = False
        '
        'SyToolStripLabel2
        '
        Me.SyToolStripLabel2.Name = "SyToolStripLabel2"
        Me.SyToolStripLabel2.Size = New System.Drawing.Size(21, 22)
        Me.SyToolStripLabel2.Text = "sy:"
        '
        'SyToolStripTextBox2
        '
        Me.SyToolStripTextBox2.Name = "SyToolStripTextBox2"
        Me.SyToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'SectionToolStripLabel2
        '
        Me.SectionToolStripLabel2.Name = "SectionToolStripLabel2"
        Me.SectionToolStripLabel2.Size = New System.Drawing.Size(48, 22)
        Me.SectionToolStripLabel2.Text = "section:"
        '
        'SectionToolStripTextBox2
        '
        Me.SectionToolStripTextBox2.Name = "SectionToolStripTextBox2"
        Me.SectionToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'YearlevelToolStripLabel
        '
        Me.YearlevelToolStripLabel.Name = "YearlevelToolStripLabel"
        Me.YearlevelToolStripLabel.Size = New System.Drawing.Size(56, 22)
        Me.YearlevelToolStripLabel.Text = "yearlevel:"
        '
        'YearlevelToolStripTextBox
        '
        Me.YearlevelToolStripTextBox.Name = "YearlevelToolStripTextBox"
        Me.YearlevelToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBySectionToolStripButton2
        '
        Me.FillBySectionToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBySectionToolStripButton2.Name = "FillBySectionToolStripButton2"
        Me.FillBySectionToolStripButton2.Size = New System.Drawing.Size(78, 22)
        Me.FillBySectionToolStripButton2.Text = "FillBySection"
        '
        'FillBySectionToolStrip3
        '
        Me.FillBySectionToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyToolStripLabel3, Me.SyToolStripTextBox3, Me.SectionToolStripLabel3, Me.SectionToolStripTextBox3, Me.YearlevelToolStripLabel1, Me.YearlevelToolStripTextBox1, Me.FillBySectionToolStripButton3})
        Me.FillBySectionToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.FillBySectionToolStrip3.Name = "FillBySectionToolStrip3"
        Me.FillBySectionToolStrip3.Size = New System.Drawing.Size(1264, 25)
        Me.FillBySectionToolStrip3.TabIndex = 23
        Me.FillBySectionToolStrip3.Text = "FillBySectionToolStrip3"
        Me.FillBySectionToolStrip3.Visible = False
        '
        'SyToolStripLabel3
        '
        Me.SyToolStripLabel3.Name = "SyToolStripLabel3"
        Me.SyToolStripLabel3.Size = New System.Drawing.Size(21, 22)
        Me.SyToolStripLabel3.Text = "sy:"
        '
        'SyToolStripTextBox3
        '
        Me.SyToolStripTextBox3.Name = "SyToolStripTextBox3"
        Me.SyToolStripTextBox3.Size = New System.Drawing.Size(100, 25)
        '
        'SectionToolStripLabel3
        '
        Me.SectionToolStripLabel3.Name = "SectionToolStripLabel3"
        Me.SectionToolStripLabel3.Size = New System.Drawing.Size(48, 22)
        Me.SectionToolStripLabel3.Text = "section:"
        '
        'SectionToolStripTextBox3
        '
        Me.SectionToolStripTextBox3.Name = "SectionToolStripTextBox3"
        Me.SectionToolStripTextBox3.Size = New System.Drawing.Size(100, 25)
        '
        'YearlevelToolStripLabel1
        '
        Me.YearlevelToolStripLabel1.Name = "YearlevelToolStripLabel1"
        Me.YearlevelToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.YearlevelToolStripLabel1.Text = "yearlevel:"
        '
        'YearlevelToolStripTextBox1
        '
        Me.YearlevelToolStripTextBox1.Name = "YearlevelToolStripTextBox1"
        Me.YearlevelToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillBySectionToolStripButton3
        '
        Me.FillBySectionToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBySectionToolStripButton3.Name = "FillBySectionToolStripButton3"
        Me.FillBySectionToolStripButton3.Size = New System.Drawing.Size(78, 22)
        Me.FillBySectionToolStripButton3.Text = "FillBySection"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        'Sections1TableAdapter
        '
        Me.Sections1TableAdapter.ClearBeforeFill = True
        '
        'LrnSyDataGridViewTextBoxColumn
        '
        Me.LrnSyDataGridViewTextBoxColumn.DataPropertyName = "LrnSy"
        Me.LrnSyDataGridViewTextBoxColumn.HeaderText = "LrnSy"
        Me.LrnSyDataGridViewTextBoxColumn.Name = "LrnSyDataGridViewTextBoxColumn"
        Me.LrnSyDataGridViewTextBoxColumn.ReadOnly = True
        Me.LrnSyDataGridViewTextBoxColumn.Visible = False
        '
        'YearLevelDataGridViewTextBoxColumn
        '
        Me.YearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel"
        Me.YearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel"
        Me.YearLevelDataGridViewTextBoxColumn.Name = "YearLevelDataGridViewTextBoxColumn"
        Me.YearLevelDataGridViewTextBoxColumn.ReadOnly = True
        Me.YearLevelDataGridViewTextBoxColumn.Visible = False
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectionDataGridViewTextBoxColumn.Visible = False
        '
        'SYDataGridViewTextBoxColumn
        '
        Me.SYDataGridViewTextBoxColumn.DataPropertyName = "SY"
        Me.SYDataGridViewTextBoxColumn.HeaderText = "SY"
        Me.SYDataGridViewTextBoxColumn.Name = "SYDataGridViewTextBoxColumn"
        Me.SYDataGridViewTextBoxColumn.ReadOnly = True
        Me.SYDataGridViewTextBoxColumn.Visible = False
        '
        'LRNDataGridViewTextBoxColumn
        '
        Me.LRNDataGridViewTextBoxColumn.DataPropertyName = "LRN"
        Me.LRNDataGridViewTextBoxColumn.HeaderText = "LRN"
        Me.LRNDataGridViewTextBoxColumn.Name = "LRNDataGridViewTextBoxColumn"
        Me.LRNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.FillBySectionToolStrip)
        Me.Controls.Add(Me.FillBySectionToolStrip1)
        Me.Controls.Add(Me.FillBySectionToolStrip2)
        Me.Controls.Add(Me.FillBySectionToolStrip3)
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
        CType(Me.Sections1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddStaffPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CListPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBySectionToolStrip.ResumeLayout(False)
        Me.FillBySectionToolStrip.PerformLayout()
        Me.FillBySectionToolStrip1.ResumeLayout(False)
        Me.FillBySectionToolStrip1.PerformLayout()
        Me.FillBySectionToolStrip2.ResumeLayout(False)
        Me.FillBySectionToolStrip2.PerformLayout()
        Me.FillBySectionToolStrip3.ResumeLayout(False)
        Me.FillBySectionToolStrip3.PerformLayout()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents SectionsBindingSource As BindingSource
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
    Friend WithEvents EnrollmentTableAdapter As DatabaseDataSetTableAdapters.EnrollmentTableAdapter
    Friend WithEvents FillBySectionToolStrip1 As ToolStrip
    Friend WithEvents SyToolStripLabel1 As ToolStripLabel
    Friend WithEvents SyToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SectionToolStripLabel1 As ToolStripLabel
    Friend WithEvents SectionToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents GradelevelToolStripLabel1 As ToolStripLabel
    Friend WithEvents GradelevelToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBySectionToolStripButton1 As ToolStripButton
    Friend WithEvents Sections1BindingSource As BindingSource
    Friend WithEvents Sections1TableAdapter As DatabaseDataSetTableAdapters.Sections1TableAdapter
    Friend WithEvents FillBySectionToolStrip2 As ToolStrip
    Friend WithEvents SyToolStripLabel2 As ToolStripLabel
    Friend WithEvents SyToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents SectionToolStripLabel2 As ToolStripLabel
    Friend WithEvents SectionToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents YearlevelToolStripLabel As ToolStripLabel
    Friend WithEvents YearlevelToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBySectionToolStripButton2 As ToolStripButton
    Friend WithEvents FillBySectionToolStrip3 As ToolStrip
    Friend WithEvents SyToolStripLabel3 As ToolStripLabel
    Friend WithEvents SyToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents SectionToolStripLabel3 As ToolStripLabel
    Friend WithEvents SectionToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents YearlevelToolStripLabel1 As ToolStripLabel
    Friend WithEvents YearlevelToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBySectionToolStripButton3 As ToolStripButton
    Friend WithEvents LrnSyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LRNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
