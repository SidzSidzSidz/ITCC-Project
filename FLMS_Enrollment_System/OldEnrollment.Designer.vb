<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OldEnrollment
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
        Me.LRN_TBox = New System.Windows.Forms.TextBox()
        Me.Enter_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LRN_TBox
        '
        Me.LRN_TBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LRN_TBox.Location = New System.Drawing.Point(87, 91)
        Me.LRN_TBox.Name = "LRN_TBox"
        Me.LRN_TBox.Size = New System.Drawing.Size(264, 26)
        Me.LRN_TBox.TabIndex = 0
        '
        'Enter_btn
        '
        Me.Enter_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Enter_btn.Location = New System.Drawing.Point(167, 138)
        Me.Enter_btn.Name = "Enter_btn"
        Me.Enter_btn.Size = New System.Drawing.Size(104, 42)
        Me.Enter_btn.TabIndex = 1
        Me.Enter_btn.Text = "Enter"
        Me.Enter_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter LRN"
        '
        'OldEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(438, 220)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Enter_btn)
        Me.Controls.Add(Me.LRN_TBox)
        Me.Name = "OldEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLMS Enrollment System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LRN_TBox As TextBox
    Friend WithEvents Enter_btn As Button
    Friend WithEvents Label1 As Label
End Class
