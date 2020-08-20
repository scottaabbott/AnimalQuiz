<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.labHeader2 = New System.Windows.Forms.Label()
        Me.labDescription = New System.Windows.Forms.Label()
        Me.lblClickToStart = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(176, 51)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(106, 17)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to the"
        '
        'labHeader2
        '
        Me.labHeader2.AutoSize = True
        Me.labHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHeader2.Location = New System.Drawing.Point(68, 79)
        Me.labHeader2.Name = "labHeader2"
        Me.labHeader2.Size = New System.Drawing.Size(348, 32)
        Me.labHeader2.TabIndex = 1
        Me.labHeader2.Text = "Animal Group Quiz 2020"
        '
        'labDescription
        '
        Me.labDescription.AutoSize = True
        Me.labDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescription.Location = New System.Drawing.Point(86, 134)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(317, 25)
        Me.labDescription.TabIndex = 2
        Me.labDescription.Text = "You will be scored on this out of 20!"
        '
        'lblClickToStart
        '
        Me.lblClickToStart.AutoSize = True
        Me.lblClickToStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickToStart.Location = New System.Drawing.Point(109, 191)
        Me.lblClickToStart.Name = "lblClickToStart"
        Me.lblClickToStart.Size = New System.Drawing.Size(279, 29)
        Me.lblClickToStart.TabIndex = 3
        Me.lblClickToStart.Text = "Click the button to start"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(179, 258)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 36)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 351)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblClickToStart)
        Me.Controls.Add(Me.labDescription)
        Me.Controls.Add(Me.labHeader2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents labHeader2 As Label
    Friend WithEvents labDescription As Label
    Friend WithEvents lblClickToStart As Label
    Friend WithEvents btnStart As Button
End Class
