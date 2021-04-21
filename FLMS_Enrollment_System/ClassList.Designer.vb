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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassList))
        Me.ClassList_DGV = New System.Windows.Forms.DataGridView()
        Me.LRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.YearLevelBox = New System.Windows.Forms.ComboBox()
        Me.SYBox = New System.Windows.Forms.ComboBox()
        Me.AddStaff_Label = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LastName_Label = New System.Windows.Forms.Label()
        Me.AddStaff_btn = New System.Windows.Forms.Button()
        Me.SectionsBox = New System.Windows.Forms.TextBox()
        Me.FirstName_Label = New System.Windows.Forms.Label()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.EnrollmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.EnrollmentTableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.EnrollmentTableAdapter()
        Me.Sections1TableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.Sections1TableAdapter()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesTableAdapter = New FLMS_Enrollment_System.DatabaseDataSetTableAdapters.ClassesTableAdapter()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClassList_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ClassList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LRNDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn})
        Me.ClassList_DGV.DataSource = Me.Sections1BindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClassList_DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClassList_DGV.Location = New System.Drawing.Point(65, 139)
        Me.ClassList_DGV.Name = "ClassList_DGV"
        Me.ClassList_DGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClassList_DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ClassList_DGV.RowHeadersVisible = False
        Me.ClassList_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ClassList_DGV.Size = New System.Drawing.Size(956, 501)
        Me.ClassList_DGV.TabIndex = 16
        Me.ClassList_DGV.Visible = False
        '
        'LRNDataGridViewTextBoxColumn
        '
        Me.LRNDataGridViewTextBoxColumn.DataPropertyName = "LRN"
        Me.LRNDataGridViewTextBoxColumn.HeaderText = "LRN"
        Me.LRNDataGridViewTextBoxColumn.Name = "LRNDataGridViewTextBoxColumn"
        Me.LRNDataGridViewTextBoxColumn.ReadOnly = True
        Me.LRNDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MiddleNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        Me.SectionCBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionCBox.FormattingEnabled = True
        Me.SectionCBox.Location = New System.Drawing.Point(728, 92)
        Me.SectionCBox.Name = "SectionCBox"
        Me.SectionCBox.Size = New System.Drawing.Size(179, 24)
        Me.SectionCBox.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(654, 93)
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
        Me.Label9.Location = New System.Drawing.Point(18, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 66)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Class List"
        '
        'SelectBtn
        '
        Me.SelectBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.SelectBtn.Location = New System.Drawing.Point(937, 88)
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
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12", ""})
        Me.ComboBox2.Location = New System.Drawing.Point(437, 93)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(179, 24)
        Me.ComboBox2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(340, 93)
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
        Me.Label2.Location = New System.Drawing.Point(69, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "S.Y."
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2010-2011", "2011-2012", "2012-2013", "2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020", "2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2026-2027", "2028-2029", "2029-2030"})
        Me.ComboBox1.Location = New System.Drawing.Point(112, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 24)
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
        Me.SyToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SectionToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.GradelevelToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SyToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SectionToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.GradelevelToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SyToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SectionToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.YearlevelToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SyToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.SectionToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.YearlevelToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.SelectBtn)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.SectionCBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.ClassList_DGV)
        Me.Panel1.Location = New System.Drawing.Point(195, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 692)
        Me.Panel1.TabIndex = 24
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(910, 653)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 21)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add New Class"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.YearLevelBox)
        Me.Panel2.Controls.Add(Me.SYBox)
        Me.Panel2.Controls.Add(Me.AddStaff_Label)
        Me.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.Panel2.Controls.Add(Me.LastName_Label)
        Me.Panel2.Controls.Add(Me.AddStaff_btn)
        Me.Panel2.Controls.Add(Me.SectionsBox)
        Me.Panel2.Controls.Add(Me.FirstName_Label)
        Me.Panel2.Controls.Add(Me.Username_Label)
        Me.Panel2.Controls.Add(Me.Password_Label)
        Me.Panel2.Location = New System.Drawing.Point(195, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 692)
        Me.Panel2.TabIndex = 39
        '
        'YearLevelBox
        '
        Me.YearLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearLevelBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.YearLevelBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.YearLevelBox.FormattingEnabled = True
        Me.YearLevelBox.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12"})
        Me.YearLevelBox.Location = New System.Drawing.Point(449, 261)
        Me.YearLevelBox.Name = "YearLevelBox"
        Me.YearLevelBox.Size = New System.Drawing.Size(370, 33)
        Me.YearLevelBox.TabIndex = 39
        '
        'SYBox
        '
        Me.SYBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SYBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SYBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SYBox.FormattingEnabled = True
        Me.SYBox.Items.AddRange(New Object() {"2010-2011", "2011-2012", "2012-2013", "2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020", "2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2026-2027", "2028-2029", "2029-2030"})
        Me.SYBox.Location = New System.Drawing.Point(449, 200)
        Me.SYBox.Name = "SYBox"
        Me.SYBox.Size = New System.Drawing.Size(370, 33)
        Me.SYBox.TabIndex = 39
        '
        'AddStaff_Label
        '
        Me.AddStaff_Label.AutoSize = True
        Me.AddStaff_Label.Font = New System.Drawing.Font("Impact", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaff_Label.Location = New System.Drawing.Point(18, 18)
        Me.AddStaff_Label.Name = "AddStaff_Label"
        Me.AddStaff_Label.Size = New System.Drawing.Size(241, 65)
        Me.AddStaff_Label.TabIndex = 38
        Me.AddStaff_Label.Text = "Add Class"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(449, 382)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(370, 32)
        Me.PasswordTextBox.TabIndex = 32
        '
        'LastName_Label
        '
        Me.LastName_Label.AutoSize = True
        Me.LastName_Label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName_Label.Location = New System.Drawing.Point(289, 257)
        Me.LastName_Label.Name = "LastName_Label"
        Me.LastName_Label.Size = New System.Drawing.Size(153, 33)
        Me.LastName_Label.TabIndex = 34
        Me.LastName_Label.Text = "Year Level"
        '
        'AddStaff_btn
        '
        Me.AddStaff_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.AddStaff_btn.Location = New System.Drawing.Point(417, 457)
        Me.AddStaff_btn.Name = "AddStaff_btn"
        Me.AddStaff_btn.Size = New System.Drawing.Size(234, 40)
        Me.AddStaff_btn.TabIndex = 37
        Me.AddStaff_btn.Text = "Add New Class"
        Me.AddStaff_btn.UseVisualStyleBackColor = True
        '
        'SectionsBox
        '
        Me.SectionsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SectionsBox.Location = New System.Drawing.Point(449, 322)
        Me.SectionsBox.Name = "SectionsBox"
        Me.SectionsBox.Size = New System.Drawing.Size(370, 32)
        Me.SectionsBox.TabIndex = 31
        '
        'FirstName_Label
        '
        Me.FirstName_Label.AutoSize = True
        Me.FirstName_Label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName_Label.Location = New System.Drawing.Point(273, 200)
        Me.FirstName_Label.Name = "FirstName_Label"
        Me.FirstName_Label.Size = New System.Drawing.Size(170, 33)
        Me.FirstName_Label.TabIndex = 33
        Me.FirstName_Label.Text = "School Year"
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Label.Location = New System.Drawing.Point(330, 322)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(113, 33)
        Me.Username_Label.TabIndex = 35
        Me.Username_Label.Text = "Section"
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_Label.Location = New System.Drawing.Point(253, 383)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(190, 33)
        Me.Password_Label.TabIndex = 36
        Me.Password_Label.Text = "Max Students"
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
        'Sections1TableAdapter
        '
        Me.Sections1TableAdapter.ClearBeforeFill = True
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'ClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 692)
        Me.Controls.Add(Me.FillBySectionToolStrip)
        Me.Controls.Add(Me.FillBySectionToolStrip1)
        Me.Controls.Add(Me.FillBySectionToolStrip2)
        Me.Controls.Add(Me.FillBySectionToolStrip3)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SYBox As ComboBox
    Friend WithEvents AddStaff_Label As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LastName_Label As Label
    Friend WithEvents AddStaff_btn As Button
    Friend WithEvents SectionsBox As TextBox
    Friend WithEvents FirstName_Label As Label
    Friend WithEvents Username_Label As Label
    Friend WithEvents Password_Label As Label
    Friend WithEvents ClassesBindingSource As BindingSource
    Friend WithEvents ClassesTableAdapter As DatabaseDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents YearLevelBox As ComboBox
    Friend WithEvents LRNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
