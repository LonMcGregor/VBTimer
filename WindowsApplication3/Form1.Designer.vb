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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.timeSec = New System.Windows.Forms.NumericUpDown()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.timeMin = New System.Windows.Forms.NumericUpDown()
        Me.timeHr = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdSilence = New System.Windows.Forms.Button()
        CType(Me.timeSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeHr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(721, 25)
        Me.ProgressBar1.TabIndex = 0
        '
        'cmdStart
        '
        Me.cmdStart.AutoSize = True
        Me.cmdStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdStart.Location = New System.Drawing.Point(0, 0)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(251, 39)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.AutoSize = True
        Me.cmdStop.Location = New System.Drawing.Point(0, 57)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(125, 82)
        Me.cmdStop.TabIndex = 2
        Me.cmdStop.Text = "Pause"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Time to Count"
        '
        'cmdReset
        '
        Me.cmdReset.AutoSize = True
        Me.cmdReset.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdReset.Location = New System.Drawing.Point(0, 145)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(251, 39)
        Me.cmdReset.TabIndex = 5
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'timeSec
        '
        Me.timeSec.AutoSize = True
        Me.timeSec.Location = New System.Drawing.Point(3, 70)
        Me.timeSec.Name = "timeSec"
        Me.timeSec.Size = New System.Drawing.Size(422, 20)
        Me.timeSec.TabIndex = 8
        '
        'cmdResume
        '
        Me.cmdResume.AutoSize = True
        Me.cmdResume.Location = New System.Drawing.Point(126, 57)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(125, 82)
        Me.cmdResume.TabIndex = 9
        Me.cmdResume.Text = "Continue"
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'timeMin
        '
        Me.timeMin.AutoSize = True
        Me.timeMin.Location = New System.Drawing.Point(3, 96)
        Me.timeMin.Name = "timeMin"
        Me.timeMin.Size = New System.Drawing.Size(422, 20)
        Me.timeMin.TabIndex = 10
        '
        'timeHr
        '
        Me.timeHr.AutoSize = True
        Me.timeHr.Location = New System.Drawing.Point(3, 122)
        Me.timeHr.Name = "timeHr"
        Me.timeHr.Size = New System.Drawing.Size(422, 20)
        Me.timeHr.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mins"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Hrs"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdResume)
        Me.Panel1.Controls.Add(Me.cmdReset)
        Me.Panel1.Controls.Add(Me.cmdStop)
        Me.Panel1.Controls.Add(Me.cmdStart)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 184)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.cmdSilence)
        Me.Panel2.Controls.Add(Me.timeHr)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.timeSec)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.timeMin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(257, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 191)
        Me.Panel2.TabIndex = 16
        '
        'cmdSilence
        '
        Me.cmdSilence.Location = New System.Drawing.Point(10, 6)
        Me.cmdSilence.Name = "cmdSilence"
        Me.cmdSilence.Size = New System.Drawing.Size(54, 39)
        Me.cmdSilence.TabIndex = 15
        Me.cmdSilence.Text = "Silence"
        Me.cmdSilence.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 216)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Timer"
        CType(Me.timeSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeHr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents timeSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdResume As System.Windows.Forms.Button
    Friend WithEvents timeMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents timeHr As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdSilence As System.Windows.Forms.Button

End Class
