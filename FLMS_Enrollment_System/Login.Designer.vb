<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.LoginPasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginUserTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(830, 348)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(176, 47)
        Me.LoginBtn.TabIndex = 12
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'LoginPasswordTextBox1
        '
        Me.LoginPasswordTextBox1.BackColor = System.Drawing.Color.White
        Me.LoginPasswordTextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!)
        Me.LoginPasswordTextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginPasswordTextBox1.Location = New System.Drawing.Point(784, 278)
        Me.LoginPasswordTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginPasswordTextBox1.Name = "LoginPasswordTextBox1"
        Me.LoginPasswordTextBox1.Size = New System.Drawing.Size(260, 34)
        Me.LoginPasswordTextBox1.TabIndex = 13
        Me.LoginPasswordTextBox1.Text = "Password"
        '
        'LoginUserTextBox
        '
        Me.LoginUserTextBox.BackColor = System.Drawing.Color.White
        Me.LoginUserTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!)
        Me.LoginUserTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginUserTextBox.Location = New System.Drawing.Point(784, 215)
        Me.LoginUserTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginUserTextBox.Name = "LoginUserTextBox"
        Me.LoginUserTextBox.Size = New System.Drawing.Size(260, 34)
        Me.LoginUserTextBox.TabIndex = 12
        Me.LoginUserTextBox.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(230, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 39)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enrollment System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(152, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Father Leoni Memorial School"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(274, 117)
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
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.LoginPasswordTextBox1)
        Me.Controls.Add(Me.LoginUserTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLMS Enrollment System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents LoginPasswordTextBox1 As TextBox
    Friend WithEvents LoginUserTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
