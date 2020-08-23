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
        Me.optChoice1 = New System.Windows.Forms.RadioButton()
        Me.optChoice2 = New System.Windows.Forms.RadioButton()
        Me.optChoice3 = New System.Windows.Forms.RadioButton()
        Me.optChoice4 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.gbxQuestion = New System.Windows.Forms.GroupBox()
        Me.lblQnNum = New System.Windows.Forms.Label()
        Me.gbxQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'optChoice1
        '
        Me.optChoice1.AutoSize = True
        Me.optChoice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optChoice1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optChoice1.Location = New System.Drawing.Point(20, 37)
        Me.optChoice1.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice1.Name = "optChoice1"
        Me.optChoice1.Size = New System.Drawing.Size(87, 19)
        Me.optChoice1.TabIndex = 5
        Me.optChoice1.TabStop = True
        Me.optChoice1.Text = "optChoice1"
        Me.optChoice1.UseVisualStyleBackColor = True
        '
        'optChoice2
        '
        Me.optChoice2.AutoSize = True
        Me.optChoice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optChoice2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optChoice2.Location = New System.Drawing.Point(20, 76)
        Me.optChoice2.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice2.Name = "optChoice2"
        Me.optChoice2.Size = New System.Drawing.Size(87, 19)
        Me.optChoice2.TabIndex = 6
        Me.optChoice2.TabStop = True
        Me.optChoice2.Text = "optChoice2"
        Me.optChoice2.UseVisualStyleBackColor = True
        '
        'optChoice3
        '
        Me.optChoice3.AutoSize = True
        Me.optChoice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optChoice3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optChoice3.Location = New System.Drawing.Point(20, 118)
        Me.optChoice3.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice3.Name = "optChoice3"
        Me.optChoice3.Size = New System.Drawing.Size(87, 19)
        Me.optChoice3.TabIndex = 7
        Me.optChoice3.TabStop = True
        Me.optChoice3.Text = "optChoice3"
        Me.optChoice3.UseVisualStyleBackColor = True
        '
        'optChoice4
        '
        Me.optChoice4.AutoSize = True
        Me.optChoice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optChoice4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optChoice4.Location = New System.Drawing.Point(20, 158)
        Me.optChoice4.Margin = New System.Windows.Forms.Padding(2)
        Me.optChoice4.Name = "optChoice4"
        Me.optChoice4.Size = New System.Drawing.Size(87, 19)
        Me.optChoice4.TabIndex = 8
        Me.optChoice4.TabStop = True
        Me.optChoice4.Text = "optChoice4"
        Me.optChoice4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(275, 255)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(74, 31)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'gbxQuestion
        '
        Me.gbxQuestion.Controls.Add(Me.optChoice3)
        Me.gbxQuestion.Controls.Add(Me.optChoice4)
        Me.gbxQuestion.Controls.Add(Me.optChoice1)
        Me.gbxQuestion.Controls.Add(Me.optChoice2)
        Me.gbxQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbxQuestion.Location = New System.Drawing.Point(38, 43)
        Me.gbxQuestion.Name = "gbxQuestion"
        Me.gbxQuestion.Size = New System.Drawing.Size(311, 197)
        Me.gbxQuestion.TabIndex = 10
        Me.gbxQuestion.TabStop = False
        '
        'lblQnNum
        '
        Me.lblQnNum.AutoSize = True
        Me.lblQnNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQnNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQnNum.Location = New System.Drawing.Point(12, 20)
        Me.lblQnNum.Name = "lblQnNum"
        Me.lblQnNum.Size = New System.Drawing.Size(57, 18)
        Me.lblQnNum.TabIndex = 11
        Me.lblQnNum.Text = "Label1"
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 306)
        Me.Controls.Add(Me.lblQnNum)
        Me.Controls.Add(Me.gbxQuestion)
        Me.Controls.Add(Me.btnNext)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuiz"
        Me.Text = "Quiz Question"
        Me.gbxQuestion.ResumeLayout(False)
        Me.gbxQuestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optChoice1 As RadioButton
    Friend WithEvents optChoice2 As RadioButton
    Friend WithEvents optChoice3 As RadioButton
    Friend WithEvents optChoice4 As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents gbxQuestion As GroupBox
    Friend WithEvents lblQnNum As Label
End Class
