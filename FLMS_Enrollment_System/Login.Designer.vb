﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.PasswordTBox = New System.Windows.Forms.TextBox()
        Me.UserTbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoginBtn.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.Black
        Me.LoginBtn.Location = New System.Drawing.Point(827, 398)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(176, 47)
        Me.LoginBtn.TabIndex = 12
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PasswordTBox
        '
<<<<<<< HEAD
        Me.PasswordTBox.BackColor = System.Drawing.Color.White
        Me.PasswordTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTBox.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!)
        Me.PasswordTBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PasswordTBox.Location = New System.Drawing.Point(785, 292)
        Me.PasswordTBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTBox.Name = "PasswordTBox"
        Me.PasswordTBox.Size = New System.Drawing.Size(260, 34)
        Me.PasswordTBox.TabIndex = 13
        Me.PasswordTBox.Text = "Password"
=======
        Me.LoginPasswordTextBox1.BackColor = System.Drawing.Color.White
        Me.LoginPasswordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginPasswordTextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!)
        Me.LoginPasswordTextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginPasswordTextBox1.Location = New System.Drawing.Point(781, 328)
        Me.LoginPasswordTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginPasswordTextBox1.Name = "LoginPasswordTextBox1"
        Me.LoginPasswordTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPasswordTextBox1.Size = New System.Drawing.Size(260, 34)
        Me.LoginPasswordTextBox1.TabIndex = 13
        Me.LoginPasswordTextBox1.Text = "Password"
>>>>>>> 84111eb8c48945239de0b16b8e1532eacbd5f51f
        '
        'UserTbox
        '
<<<<<<< HEAD
        Me.UserTbox.BackColor = System.Drawing.Color.White
        Me.UserTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserTbox.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!)
        Me.UserTbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UserTbox.Location = New System.Drawing.Point(785, 229)
        Me.UserTbox.Margin = New System.Windows.Forms.Padding(2)
        Me.UserTbox.Name = "UserTbox"
        Me.UserTbox.Size = New System.Drawing.Size(260, 34)
        Me.UserTbox.TabIndex = 12
        Me.UserTbox.Text = "Username"
=======
        Me.LoginUserTextBox.BackColor = System.Drawing.Color.White
        Me.LoginUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginUserTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!)
        Me.LoginUserTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginUserTextBox.Location = New System.Drawing.Point(781, 265)
        Me.LoginUserTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginUserTextBox.Name = "LoginUserTextBox"
        Me.LoginUserTextBox.Size = New System.Drawing.Size(260, 34)
        Me.LoginUserTextBox.TabIndex = 12
        Me.LoginUserTextBox.Text = "Username"
>>>>>>> 84111eb8c48945239de0b16b8e1532eacbd5f51f
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(279, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enrollment System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(188, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Father Leoni Memorial School Inc."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(305, 167)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 229)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordTBox)
        Me.Controls.Add(Me.UserTbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLMS Enrollment System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordTBox As TextBox
    Friend WithEvents UserTbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
