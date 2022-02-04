<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devSettings
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
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.txtPlayerScore = New System.Windows.Forms.TextBox()
        Me.btnUpdateScore = New System.Windows.Forms.Button()
        Me.btnShowHighscores = New System.Windows.Forms.Button()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(24, 89)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(100, 23)
        Me.txtPlayerName.TabIndex = 0
        '
        'txtPlayerScore
        '
        Me.txtPlayerScore.Location = New System.Drawing.Point(176, 89)
        Me.txtPlayerScore.Name = "txtPlayerScore"
        Me.txtPlayerScore.Size = New System.Drawing.Size(100, 23)
        Me.txtPlayerScore.TabIndex = 1
        '
        'btnUpdateScore
        '
        Me.btnUpdateScore.Location = New System.Drawing.Point(24, 140)
        Me.btnUpdateScore.Name = "btnUpdateScore"
        Me.btnUpdateScore.Size = New System.Drawing.Size(90, 23)
        Me.btnUpdateScore.TabIndex = 2
        Me.btnUpdateScore.Text = "Update Score"
        Me.btnUpdateScore.UseVisualStyleBackColor = True
        '
        'btnShowHighscores
        '
        Me.btnShowHighscores.Location = New System.Drawing.Point(176, 140)
        Me.btnShowHighscores.Name = "btnShowHighscores"
        Me.btnShowHighscores.Size = New System.Drawing.Size(108, 23)
        Me.btnShowHighscores.TabIndex = 3
        Me.btnShowHighscores.Text = "Show Highscores"
        Me.btnShowHighscores.UseVisualStyleBackColor = True
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(37, 54)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(77, 15)
        Me.lblPlayerName.TabIndex = 4
        Me.lblPlayerName.Text = "Player Name:"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Location = New System.Drawing.Point(187, 54)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(74, 15)
        Me.lblPlayerScore.TabIndex = 5
        Me.lblPlayerScore.Text = "Player Score:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(24, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'devSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.btnShowHighscores)
        Me.Controls.Add(Me.btnUpdateScore)
        Me.Controls.Add(Me.txtPlayerScore)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Name = "devSettings"
        Me.Text = "devSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents txtPlayerScore As TextBox
    Friend WithEvents btnUpdateScore As Button
    Friend WithEvents btnShowHighscores As Button
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents btnExit As Button
End Class
