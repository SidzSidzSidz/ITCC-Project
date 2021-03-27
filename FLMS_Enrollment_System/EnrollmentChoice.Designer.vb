<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentChoice
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
        Me.NewStudent_btn = New System.Windows.Forms.Button()
        Me.OldStudent_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewStudent_btn
        '
        Me.NewStudent_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewStudent_btn.Location = New System.Drawing.Point(59, 68)
        Me.NewStudent_btn.Name = "NewStudent_btn"
        Me.NewStudent_btn.Size = New System.Drawing.Size(142, 84)
        Me.NewStudent_btn.TabIndex = 0
        Me.NewStudent_btn.Text = "New Student"
        Me.NewStudent_btn.UseVisualStyleBackColor = True
        '
        'OldStudent_btn
        '
        Me.OldStudent_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldStudent_btn.Location = New System.Drawing.Point(237, 68)
        Me.OldStudent_btn.Name = "OldStudent_btn"
        Me.OldStudent_btn.Size = New System.Drawing.Size(142, 84)
        Me.OldStudent_btn.TabIndex = 0
        Me.OldStudent_btn.Text = "Old Student"
        Me.OldStudent_btn.UseVisualStyleBackColor = True
        '
        'EnrollmentChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(438, 220)
        Me.Controls.Add(Me.OldStudent_btn)
        Me.Controls.Add(Me.NewStudent_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EnrollmentChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnrollmentChoice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewStudent_btn As Button
    Friend WithEvents OldStudent_btn As Button
End Class
