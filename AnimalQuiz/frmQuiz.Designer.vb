<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Me.lblQNum = New System.Windows.Forms.Label()
        Me.lblQText = New System.Windows.Forms.Label()
        Me.optChoice1 = New System.Windows.Forms.RadioButton()
        Me.optChoice2 = New System.Windows.Forms.RadioButton()
        Me.optChoice3 = New System.Windows.Forms.RadioButton()
        Me.optChoice4 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQNum
        '
        Me.lblQNum.AutoSize = True
        Me.lblQNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNum.Location = New System.Drawing.Point(32, 51)
        Me.lblQNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQNum.Name = "lblQNum"
        Me.lblQNum.Size = New System.Drawing.Size(16, 16)
        Me.lblQNum.TabIndex = 0
        Me.lblQNum.Text = "#"
        '
        'lblQText
        '
        Me.lblQText.AutoSize = True
        Me.lblQText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQText.Location = New System.Drawing.Point(68, 51)
        Me.lblQText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQText.Name = "lblQText"
        Me.lblQText.Size = New System.Drawing.Size(116, 16)
        Me.lblQText.TabIndex = 1
        Me.lblQText.Text = "lblQuestionText"
        '
        'optChoice1
        '
        Me.optChoice1.AutoSize = True
        Me.optChoice1.Location = New System.Drawing.Point(124, 103)
        Me.optChoice1.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice1.Name = "optChoice1"
        Me.optChoice1.Size = New System.Drawing.Size(79, 17)
        Me.optChoice1.TabIndex = 5
        Me.optChoice1.TabStop = True
        Me.optChoice1.Text = "optChoice1"
        Me.optChoice1.UseVisualStyleBackColor = True
        '
        'optChoice2
        '
        Me.optChoice2.AutoSize = True
        Me.optChoice2.Location = New System.Drawing.Point(124, 167)
        Me.optChoice2.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice2.Name = "optChoice2"
        Me.optChoice2.Size = New System.Drawing.Size(79, 17)
        Me.optChoice2.TabIndex = 6
        Me.optChoice2.TabStop = True
        Me.optChoice2.Text = "optChoice2"
        Me.optChoice2.UseVisualStyleBackColor = True
        '
        'optChoice3
        '
        Me.optChoice3.AutoSize = True
        Me.optChoice3.Location = New System.Drawing.Point(238, 103)
        Me.optChoice3.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice3.Name = "optChoice3"
        Me.optChoice3.Size = New System.Drawing.Size(79, 17)
        Me.optChoice3.TabIndex = 7
        Me.optChoice3.TabStop = True
        Me.optChoice3.Text = "optChoice3"
        Me.optChoice3.UseVisualStyleBackColor = True
        '
        'optChoice4
        '
        Me.optChoice4.AutoSize = True
        Me.optChoice4.Location = New System.Drawing.Point(238, 167)
        Me.optChoice4.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice4.Name = "optChoice4"
        Me.optChoice4.Size = New System.Drawing.Size(79, 17)
        Me.optChoice4.TabIndex = 8
        Me.optChoice4.TabStop = True
        Me.optChoice4.Text = "optChoice4"
        Me.optChoice4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(263, 242)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(74, 31)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 306)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.optChoice4)
        Me.Controls.Add(Me.optChoice3)
        Me.Controls.Add(Me.optChoice2)
        Me.Controls.Add(Me.optChoice1)
        Me.Controls.Add(Me.lblQText)
        Me.Controls.Add(Me.lblQNum)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuiz"
        Me.Text = "Quiz Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQNum As Label
    Friend WithEvents lblQText As Label
    Friend WithEvents optChoice1 As RadioButton
    Friend WithEvents optChoice2 As RadioButton
    Friend WithEvents optChoice3 As RadioButton
    Friend WithEvents optChoice4 As RadioButton
    Friend WithEvents btnNext As Button
End Class
