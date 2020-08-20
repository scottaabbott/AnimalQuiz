<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.lblClickToStart = New System.Windows.Forms.Label()
        Me.labDescription = New System.Windows.Forms.Label()
        Me.labHeader2 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClickToStart
        '
        Me.lblClickToStart.AutoSize = True
        Me.lblClickToStart.Font = New System.Drawing.Font("Perpetua", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickToStart.ForeColor = System.Drawing.Color.DarkRed
        Me.lblClickToStart.Location = New System.Drawing.Point(41, 136)
        Me.lblClickToStart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickToStart.Name = "lblClickToStart"
        Me.lblClickToStart.Size = New System.Drawing.Size(284, 18)
        Me.lblClickToStart.TabIndex = 7
        Me.lblClickToStart.Text = "Select Forms->Quiz from the menu to Start"
        '
        'labDescription
        '
        Me.labDescription.AutoSize = True
        Me.labDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescription.Location = New System.Drawing.Point(52, 94)
        Me.labDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(258, 20)
        Me.labDescription.TabIndex = 6
        Me.labDescription.Text = "You will be scored on this out of 20!"
        '
        'labHeader2
        '
        Me.labHeader2.AutoSize = True
        Me.labHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHeader2.Location = New System.Drawing.Point(39, 49)
        Me.labHeader2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labHeader2.Name = "labHeader2"
        Me.labHeader2.Size = New System.Drawing.Size(273, 26)
        Me.labHeader2.TabIndex = 5
        Me.labHeader2.Text = "Animal Group Quiz 2020"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(120, 26)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(82, 13)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome to the"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(127, 179)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(98, 34)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 237)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblClickToStart)
        Me.Controls.Add(Me.labDescription)
        Me.Controls.Add(Me.labHeader2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "frmHelp"
        Me.Text = "frmHelp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClickToStart As Label
    Friend WithEvents labDescription As Label
    Friend WithEvents labHeader2 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnOk As Button
End Class
