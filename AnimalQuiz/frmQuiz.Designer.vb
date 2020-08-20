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
        Me.labQNum = New System.Windows.Forms.Label()
        Me.labQuestionText = New System.Windows.Forms.Label()
        Me.rbtOption1 = New System.Windows.Forms.RadioButton()
        Me.rbtOption2 = New System.Windows.Forms.RadioButton()
        Me.rbtOption3 = New System.Windows.Forms.RadioButton()
        Me.rbtOption4 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labQNum
        '
        Me.labQNum.AutoSize = True
        Me.labQNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labQNum.Location = New System.Drawing.Point(32, 51)
        Me.labQNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labQNum.Name = "labQNum"
        Me.labQNum.Size = New System.Drawing.Size(16, 16)
        Me.labQNum.TabIndex = 0
        Me.labQNum.Text = "#"
        '
        'labQuestionText
        '
        Me.labQuestionText.AutoSize = True
        Me.labQuestionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labQuestionText.Location = New System.Drawing.Point(68, 51)
        Me.labQuestionText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labQuestionText.Name = "labQuestionText"
        Me.labQuestionText.Size = New System.Drawing.Size(121, 16)
        Me.labQuestionText.TabIndex = 1
        Me.labQuestionText.Text = "labQuestionText"
        '
        'rbtOption1
        '
        Me.rbtOption1.AutoSize = True
        Me.rbtOption1.Location = New System.Drawing.Point(124, 103)
        Me.rbtOption1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtOption1.Name = "rbtOption1"
        Me.rbtOption1.Size = New System.Drawing.Size(74, 17)
        Me.rbtOption1.TabIndex = 5
        Me.rbtOption1.TabStop = True
        Me.rbtOption1.Text = "rbtOption1"
        Me.rbtOption1.UseVisualStyleBackColor = True
        '
        'rbtOption2
        '
        Me.rbtOption2.AutoSize = True
        Me.rbtOption2.Location = New System.Drawing.Point(124, 167)
        Me.rbtOption2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtOption2.Name = "rbtOption2"
        Me.rbtOption2.Size = New System.Drawing.Size(74, 17)
        Me.rbtOption2.TabIndex = 6
        Me.rbtOption2.TabStop = True
        Me.rbtOption2.Text = "rbtOption2"
        Me.rbtOption2.UseVisualStyleBackColor = True
        '
        'rbtOption3
        '
        Me.rbtOption3.AutoSize = True
        Me.rbtOption3.Location = New System.Drawing.Point(238, 103)
        Me.rbtOption3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtOption3.Name = "rbtOption3"
        Me.rbtOption3.Size = New System.Drawing.Size(74, 17)
        Me.rbtOption3.TabIndex = 7
        Me.rbtOption3.TabStop = True
        Me.rbtOption3.Text = "rbtOption3"
        Me.rbtOption3.UseVisualStyleBackColor = True
        '
        'rbtOption4
        '
        Me.rbtOption4.AutoSize = True
        Me.rbtOption4.Location = New System.Drawing.Point(238, 167)
        Me.rbtOption4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtOption4.Name = "rbtOption4"
        Me.rbtOption4.Size = New System.Drawing.Size(74, 17)
        Me.rbtOption4.TabIndex = 8
        Me.rbtOption4.TabStop = True
        Me.rbtOption4.Text = "rbtOption4"
        Me.rbtOption4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(263, 242)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(74, 31)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 306)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rbtOption4)
        Me.Controls.Add(Me.rbtOption3)
        Me.Controls.Add(Me.rbtOption2)
        Me.Controls.Add(Me.rbtOption1)
        Me.Controls.Add(Me.labQuestionText)
        Me.Controls.Add(Me.labQNum)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "QuestionForm"
        Me.Text = "Quiz Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labQNum As Label
    Friend WithEvents labQuestionText As Label
    Friend WithEvents rbtOption1 As RadioButton
    Friend WithEvents rbtOption2 As RadioButton
    Friend WithEvents rbtOption3 As RadioButton
    Friend WithEvents rbtOption4 As RadioButton
    Friend WithEvents btnNext As Button
End Class
