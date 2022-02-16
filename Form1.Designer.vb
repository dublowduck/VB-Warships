<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnForm1Exit = New System.Windows.Forms.Button()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolStripTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.developerSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsbPlayerGuessBoard = New System.Windows.Forms.ListBox()
        Me.lsbPlayerGameBoard = New System.Windows.Forms.ListBox()
        Me.lblPlayerGuessBoard = New System.Windows.Forms.Label()
        Me.lblPlayerGameBoard = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnForm1Exit
        '
        Me.btnForm1Exit.Location = New System.Drawing.Point(41, 398)
        Me.btnForm1Exit.Name = "btnForm1Exit"
        Me.btnForm1Exit.Size = New System.Drawing.Size(75, 23)
        Me.btnForm1Exit.TabIndex = 1
        Me.btnForm1Exit.Text = "Exit"
        Me.btnForm1Exit.UseVisualStyleBackColor = True
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripTools})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "MenuStrip1"
        '
        'toolStripTools
        '
        Me.toolStripTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.developerSettingsToolStripMenuItem})
        Me.toolStripTools.Name = "toolStripTools"
        Me.toolStripTools.Size = New System.Drawing.Size(46, 20)
        Me.toolStripTools.Text = "Tools"
        '
        'developerSettingsToolStripMenuItem
        '
        Me.developerSettingsToolStripMenuItem.Name = "developerSettingsToolStripMenuItem"
        Me.developerSettingsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.developerSettingsToolStripMenuItem.Text = "Developer Settings"
        '
        'lsbPlayerGuessBoard
        '
        Me.lsbPlayerGuessBoard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lsbPlayerGuessBoard.FormattingEnabled = True
        Me.lsbPlayerGuessBoard.ItemHeight = 21
        Me.lsbPlayerGuessBoard.Location = New System.Drawing.Point(41, 62)
        Me.lsbPlayerGuessBoard.Name = "lsbPlayerGuessBoard"
        Me.lsbPlayerGuessBoard.Size = New System.Drawing.Size(180, 214)
        Me.lsbPlayerGuessBoard.TabIndex = 3
        '
        'lsbPlayerGameBoard
        '
        Me.lsbPlayerGameBoard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lsbPlayerGameBoard.FormattingEnabled = True
        Me.lsbPlayerGameBoard.ItemHeight = 21
        Me.lsbPlayerGameBoard.Location = New System.Drawing.Point(372, 62)
        Me.lsbPlayerGameBoard.Name = "lsbPlayerGameBoard"
        Me.lsbPlayerGameBoard.Size = New System.Drawing.Size(180, 214)
        Me.lsbPlayerGameBoard.TabIndex = 4
        '
        'lblPlayerGuessBoard
        '
        Me.lblPlayerGuessBoard.AutoSize = True
        Me.lblPlayerGuessBoard.Location = New System.Drawing.Point(73, 44)
        Me.lblPlayerGuessBoard.Name = "lblPlayerGuessBoard"
        Me.lblPlayerGuessBoard.Size = New System.Drawing.Size(107, 15)
        Me.lblPlayerGuessBoard.TabIndex = 5
        Me.lblPlayerGuessBoard.Text = "Player Guess Board"
        '
        'lblPlayerGameBoard
        '
        Me.lblPlayerGameBoard.AutoSize = True
        Me.lblPlayerGameBoard.Location = New System.Drawing.Point(412, 44)
        Me.lblPlayerGameBoard.Name = "lblPlayerGameBoard"
        Me.lblPlayerGameBoard.Size = New System.Drawing.Size(107, 15)
        Me.lblPlayerGameBoard.TabIndex = 6
        Me.lblPlayerGameBoard.Text = "Player Game Board"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPlayerGameBoard)
        Me.Controls.Add(Me.lblPlayerGuessBoard)
        Me.Controls.Add(Me.lsbPlayerGameBoard)
        Me.Controls.Add(Me.lsbPlayerGuessBoard)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.btnForm1Exit)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.Text = "VB-Warships"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnForm1Exit As Button
    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents toolStripTools As ToolStripMenuItem
    Friend WithEvents developerSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lsbPlayerGuessBoard As ListBox
    Friend WithEvents lsbPlayerGameBoard As ListBox
    Friend WithEvents lblPlayerGuessBoard As Label
    Friend WithEvents lblPlayerGameBoard As Label
End Class
