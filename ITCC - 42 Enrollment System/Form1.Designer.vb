<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginUserTextBox = New System.Windows.Forms.TextBox()
        Me.LoginPasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ITCC___42_Enrollment_System.My.Resources.Resources.flms
        Me.PictureBox1.Location = New System.Drawing.Point(248, 268)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 233)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(74, 570)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Father Leoni Memorial School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(179, 640)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enrollment System"
        '
        'LoginUserTextBox
        '
        Me.LoginUserTextBox.BackColor = System.Drawing.Color.White
        Me.LoginUserTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginUserTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginUserTextBox.Location = New System.Drawing.Point(957, 297)
        Me.LoginUserTextBox.Name = "LoginUserTextBox"
        Me.LoginUserTextBox.Size = New System.Drawing.Size(345, 31)
        Me.LoginUserTextBox.TabIndex = 5
        Me.LoginUserTextBox.Text = "Username"
        '
        'LoginPasswordTextBox1
        '
        Me.LoginPasswordTextBox1.BackColor = System.Drawing.Color.White
        Me.LoginPasswordTextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPasswordTextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginPasswordTextBox1.Location = New System.Drawing.Point(957, 417)
        Me.LoginPasswordTextBox1.Name = "LoginPasswordTextBox1"
        Me.LoginPasswordTextBox1.Size = New System.Drawing.Size(345, 31)
        Me.LoginPasswordTextBox1.TabIndex = 5
        Me.LoginPasswordTextBox1.Text = "Password"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(1021, 575)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(235, 58)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.LoginPasswordTextBox1)
        Me.Controls.Add(Me.LoginUserTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginUserTextBox As TextBox
    Friend WithEvents LoginPasswordTextBox1 As TextBox
    Friend WithEvents LoginButton As Button
End Class
