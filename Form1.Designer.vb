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
        Me.lsbPlayerGuessBoard = New System.Windows.Forms.ListBox()
        Me.lsbPlayerGameBoard = New System.Windows.Forms.ListBox()
        Me.lblGuessBoard = New System.Windows.Forms.Label()
        Me.lblGameBoard = New System.Windows.Forms.Label()
        Me.txtPlayerGuess = New System.Windows.Forms.TextBox()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.lblCoordinates = New System.Windows.Forms.Label()
        Me.lblGuessColumns = New System.Windows.Forms.Label()
        Me.lblGameColumns = New System.Windows.Forms.Label()
        Me.lblGuessA = New System.Windows.Forms.Label()
        Me.lblGuessB = New System.Windows.Forms.Label()
        Me.lblGuessC = New System.Windows.Forms.Label()
        Me.lblGuessD = New System.Windows.Forms.Label()
        Me.lblGuessE = New System.Windows.Forms.Label()
        Me.lblGuessF = New System.Windows.Forms.Label()
        Me.lblGuessG = New System.Windows.Forms.Label()
        Me.lblGuessH = New System.Windows.Forms.Label()
        Me.lblGuessI = New System.Windows.Forms.Label()
        Me.lblGuessJ = New System.Windows.Forms.Label()
        Me.lblGameJ = New System.Windows.Forms.Label()
        Me.lblGameI = New System.Windows.Forms.Label()
        Me.lblGameH = New System.Windows.Forms.Label()
        Me.lblGameG = New System.Windows.Forms.Label()
        Me.lblGameF = New System.Windows.Forms.Label()
        Me.lblGameE = New System.Windows.Forms.Label()
        Me.lblGameD = New System.Windows.Forms.Label()
        Me.lblGameC = New System.Windows.Forms.Label()
        Me.lblGameB = New System.Windows.Forms.Label()
        Me.lblGameA = New System.Windows.Forms.Label()
        Me.btnEndTurn = New System.Windows.Forms.Button()
        Me.txtTurnInfo = New System.Windows.Forms.TextBox()
        Me.picVBWarships = New System.Windows.Forms.PictureBox()
        Me.lsbScores = New System.Windows.Forms.ListBox()
        CType(Me.picVBWarships, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnForm1Exit
        '
        Me.btnForm1Exit.Location = New System.Drawing.Point(43, 491)
        Me.btnForm1Exit.Name = "btnForm1Exit"
        Me.btnForm1Exit.Size = New System.Drawing.Size(75, 23)
        Me.btnForm1Exit.TabIndex = 1
        Me.btnForm1Exit.Text = "Exit"
        Me.btnForm1Exit.UseVisualStyleBackColor = True
        '
        'lsbPlayerGuessBoard
        '
        Me.lsbPlayerGuessBoard.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lsbPlayerGuessBoard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lsbPlayerGuessBoard.FormattingEnabled = True
        Me.lsbPlayerGuessBoard.ItemHeight = 21
        Me.lsbPlayerGuessBoard.Location = New System.Drawing.Point(43, 227)
        Me.lsbPlayerGuessBoard.Name = "lsbPlayerGuessBoard"
        Me.lsbPlayerGuessBoard.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lsbPlayerGuessBoard.Size = New System.Drawing.Size(283, 214)
        Me.lsbPlayerGuessBoard.TabIndex = 3
        '
        'lsbPlayerGameBoard
        '
        Me.lsbPlayerGameBoard.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lsbPlayerGameBoard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lsbPlayerGameBoard.FormattingEnabled = True
        Me.lsbPlayerGameBoard.ItemHeight = 21
        Me.lsbPlayerGameBoard.Location = New System.Drawing.Point(500, 225)
        Me.lsbPlayerGameBoard.Name = "lsbPlayerGameBoard"
        Me.lsbPlayerGameBoard.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lsbPlayerGameBoard.Size = New System.Drawing.Size(283, 214)
        Me.lsbPlayerGameBoard.TabIndex = 4
        '
        'lblGuessBoard
        '
        Me.lblGuessBoard.AutoSize = True
        Me.lblGuessBoard.Location = New System.Drawing.Point(104, 188)
        Me.lblGuessBoard.Name = "lblGuessBoard"
        Me.lblGuessBoard.Size = New System.Drawing.Size(72, 15)
        Me.lblGuessBoard.TabIndex = 5
        Me.lblGuessBoard.Text = "Guess Board"
        '
        'lblGameBoard
        '
        Me.lblGameBoard.AutoSize = True
        Me.lblGameBoard.Location = New System.Drawing.Point(576, 186)
        Me.lblGameBoard.Name = "lblGameBoard"
        Me.lblGameBoard.Size = New System.Drawing.Size(72, 15)
        Me.lblGameBoard.TabIndex = 6
        Me.lblGameBoard.Text = "Game Board"
        '
        'txtPlayerGuess
        '
        Me.txtPlayerGuess.Location = New System.Drawing.Point(349, 292)
        Me.txtPlayerGuess.Name = "txtPlayerGuess"
        Me.txtPlayerGuess.Size = New System.Drawing.Size(100, 23)
        Me.txtPlayerGuess.TabIndex = 7
        '
        'btnFire
        '
        Me.btnFire.Location = New System.Drawing.Point(361, 344)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(75, 23)
        Me.btnFire.TabIndex = 8
        Me.btnFire.Text = "Fire!"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'lblCoordinates
        '
        Me.lblCoordinates.AutoSize = True
        Me.lblCoordinates.Location = New System.Drawing.Point(361, 268)
        Me.lblCoordinates.Name = "lblCoordinates"
        Me.lblCoordinates.Size = New System.Drawing.Size(74, 15)
        Me.lblCoordinates.TabIndex = 9
        Me.lblCoordinates.Text = "Coordinates:"
        '
        'lblGuessColumns
        '
        Me.lblGuessColumns.AutoSize = True
        Me.lblGuessColumns.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessColumns.Location = New System.Drawing.Point(56, 203)
        Me.lblGuessColumns.Name = "lblGuessColumns"
        Me.lblGuessColumns.Size = New System.Drawing.Size(217, 21)
        Me.lblGuessColumns.TabIndex = 10
        Me.lblGuessColumns.Text = "1   2   3   4   5   6   7   8   9   10"
        '
        'lblGameColumns
        '
        Me.lblGameColumns.AutoSize = True
        Me.lblGameColumns.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameColumns.Location = New System.Drawing.Point(500, 201)
        Me.lblGameColumns.Name = "lblGameColumns"
        Me.lblGameColumns.Size = New System.Drawing.Size(217, 21)
        Me.lblGameColumns.TabIndex = 11
        Me.lblGameColumns.Text = "1   2   3   4   5   6   7   8   9   10"
        '
        'lblGuessA
        '
        Me.lblGuessA.AutoSize = True
        Me.lblGuessA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessA.Location = New System.Drawing.Point(22, 229)
        Me.lblGuessA.Name = "lblGuessA"
        Me.lblGuessA.Size = New System.Drawing.Size(20, 21)
        Me.lblGuessA.TabIndex = 12
        Me.lblGuessA.Text = "A"
        '
        'lblGuessB
        '
        Me.lblGuessB.AutoSize = True
        Me.lblGuessB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessB.Location = New System.Drawing.Point(22, 250)
        Me.lblGuessB.Name = "lblGuessB"
        Me.lblGuessB.Size = New System.Drawing.Size(19, 21)
        Me.lblGuessB.TabIndex = 13
        Me.lblGuessB.Text = "B"
        '
        'lblGuessC
        '
        Me.lblGuessC.AutoSize = True
        Me.lblGuessC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessC.Location = New System.Drawing.Point(22, 271)
        Me.lblGuessC.Name = "lblGuessC"
        Me.lblGuessC.Size = New System.Drawing.Size(20, 21)
        Me.lblGuessC.TabIndex = 14
        Me.lblGuessC.Text = "C"
        '
        'lblGuessD
        '
        Me.lblGuessD.AutoSize = True
        Me.lblGuessD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessD.Location = New System.Drawing.Point(22, 292)
        Me.lblGuessD.Name = "lblGuessD"
        Me.lblGuessD.Size = New System.Drawing.Size(21, 21)
        Me.lblGuessD.TabIndex = 15
        Me.lblGuessD.Text = "D"
        '
        'lblGuessE
        '
        Me.lblGuessE.AutoSize = True
        Me.lblGuessE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessE.Location = New System.Drawing.Point(23, 313)
        Me.lblGuessE.Name = "lblGuessE"
        Me.lblGuessE.Size = New System.Drawing.Size(18, 21)
        Me.lblGuessE.TabIndex = 16
        Me.lblGuessE.Text = "E"
        '
        'lblGuessF
        '
        Me.lblGuessF.AutoSize = True
        Me.lblGuessF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessF.Location = New System.Drawing.Point(22, 334)
        Me.lblGuessF.Name = "lblGuessF"
        Me.lblGuessF.Size = New System.Drawing.Size(18, 21)
        Me.lblGuessF.TabIndex = 17
        Me.lblGuessF.Text = "F"
        '
        'lblGuessG
        '
        Me.lblGuessG.AutoSize = True
        Me.lblGuessG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessG.Location = New System.Drawing.Point(19, 355)
        Me.lblGuessG.Name = "lblGuessG"
        Me.lblGuessG.Size = New System.Drawing.Size(21, 21)
        Me.lblGuessG.TabIndex = 18
        Me.lblGuessG.Text = "G"
        '
        'lblGuessH
        '
        Me.lblGuessH.AutoSize = True
        Me.lblGuessH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessH.Location = New System.Drawing.Point(20, 376)
        Me.lblGuessH.Name = "lblGuessH"
        Me.lblGuessH.Size = New System.Drawing.Size(21, 21)
        Me.lblGuessH.TabIndex = 19
        Me.lblGuessH.Text = "H"
        '
        'lblGuessI
        '
        Me.lblGuessI.AutoSize = True
        Me.lblGuessI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessI.Location = New System.Drawing.Point(23, 397)
        Me.lblGuessI.Name = "lblGuessI"
        Me.lblGuessI.Size = New System.Drawing.Size(14, 21)
        Me.lblGuessI.TabIndex = 20
        Me.lblGuessI.Text = "I"
        '
        'lblGuessJ
        '
        Me.lblGuessJ.AutoSize = True
        Me.lblGuessJ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuessJ.Location = New System.Drawing.Point(23, 418)
        Me.lblGuessJ.Name = "lblGuessJ"
        Me.lblGuessJ.Size = New System.Drawing.Size(16, 21)
        Me.lblGuessJ.TabIndex = 21
        Me.lblGuessJ.Text = "J"
        '
        'lblGameJ
        '
        Me.lblGameJ.AutoSize = True
        Me.lblGameJ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameJ.Location = New System.Drawing.Point(475, 416)
        Me.lblGameJ.Name = "lblGameJ"
        Me.lblGameJ.Size = New System.Drawing.Size(16, 21)
        Me.lblGameJ.TabIndex = 31
        Me.lblGameJ.Text = "J"
        '
        'lblGameI
        '
        Me.lblGameI.AutoSize = True
        Me.lblGameI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameI.Location = New System.Drawing.Point(475, 395)
        Me.lblGameI.Name = "lblGameI"
        Me.lblGameI.Size = New System.Drawing.Size(14, 21)
        Me.lblGameI.TabIndex = 30
        Me.lblGameI.Text = "I"
        '
        'lblGameH
        '
        Me.lblGameH.AutoSize = True
        Me.lblGameH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameH.Location = New System.Drawing.Point(472, 374)
        Me.lblGameH.Name = "lblGameH"
        Me.lblGameH.Size = New System.Drawing.Size(21, 21)
        Me.lblGameH.TabIndex = 29
        Me.lblGameH.Text = "H"
        '
        'lblGameG
        '
        Me.lblGameG.AutoSize = True
        Me.lblGameG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameG.Location = New System.Drawing.Point(471, 353)
        Me.lblGameG.Name = "lblGameG"
        Me.lblGameG.Size = New System.Drawing.Size(21, 21)
        Me.lblGameG.TabIndex = 28
        Me.lblGameG.Text = "G"
        '
        'lblGameF
        '
        Me.lblGameF.AutoSize = True
        Me.lblGameF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameF.Location = New System.Drawing.Point(474, 332)
        Me.lblGameF.Name = "lblGameF"
        Me.lblGameF.Size = New System.Drawing.Size(18, 21)
        Me.lblGameF.TabIndex = 27
        Me.lblGameF.Text = "F"
        '
        'lblGameE
        '
        Me.lblGameE.AutoSize = True
        Me.lblGameE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameE.Location = New System.Drawing.Point(475, 311)
        Me.lblGameE.Name = "lblGameE"
        Me.lblGameE.Size = New System.Drawing.Size(18, 21)
        Me.lblGameE.TabIndex = 26
        Me.lblGameE.Text = "E"
        '
        'lblGameD
        '
        Me.lblGameD.AutoSize = True
        Me.lblGameD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameD.Location = New System.Drawing.Point(474, 290)
        Me.lblGameD.Name = "lblGameD"
        Me.lblGameD.Size = New System.Drawing.Size(21, 21)
        Me.lblGameD.TabIndex = 25
        Me.lblGameD.Text = "D"
        '
        'lblGameC
        '
        Me.lblGameC.AutoSize = True
        Me.lblGameC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameC.Location = New System.Drawing.Point(474, 269)
        Me.lblGameC.Name = "lblGameC"
        Me.lblGameC.Size = New System.Drawing.Size(20, 21)
        Me.lblGameC.TabIndex = 24
        Me.lblGameC.Text = "C"
        '
        'lblGameB
        '
        Me.lblGameB.AutoSize = True
        Me.lblGameB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameB.Location = New System.Drawing.Point(474, 248)
        Me.lblGameB.Name = "lblGameB"
        Me.lblGameB.Size = New System.Drawing.Size(19, 21)
        Me.lblGameB.TabIndex = 23
        Me.lblGameB.Text = "B"
        '
        'lblGameA
        '
        Me.lblGameA.AutoSize = True
        Me.lblGameA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGameA.Location = New System.Drawing.Point(474, 227)
        Me.lblGameA.Name = "lblGameA"
        Me.lblGameA.Size = New System.Drawing.Size(20, 21)
        Me.lblGameA.TabIndex = 22
        Me.lblGameA.Text = "A"
        '
        'btnEndTurn
        '
        Me.btnEndTurn.Location = New System.Drawing.Point(361, 409)
        Me.btnEndTurn.Name = "btnEndTurn"
        Me.btnEndTurn.Size = New System.Drawing.Size(68, 23)
        Me.btnEndTurn.TabIndex = 33
        Me.btnEndTurn.Text = "End turn"
        Me.btnEndTurn.UseVisualStyleBackColor = True
        '
        'txtTurnInfo
        '
        Me.txtTurnInfo.Location = New System.Drawing.Point(349, 231)
        Me.txtTurnInfo.Name = "txtTurnInfo"
        Me.txtTurnInfo.ReadOnly = True
        Me.txtTurnInfo.Size = New System.Drawing.Size(100, 23)
        Me.txtTurnInfo.TabIndex = 34
        Me.txtTurnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picVBWarships
        '
        Me.picVBWarships.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.picVBWarships.BackColor = System.Drawing.Color.Transparent
        Me.picVBWarships.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picVBWarships.Image = Global.VBWarships.My.Resources.Resources.VB_Warships
        Me.picVBWarships.Location = New System.Drawing.Point(104, 55)
        Me.picVBWarships.Name = "picVBWarships"
        Me.picVBWarships.Size = New System.Drawing.Size(510, 89)
        Me.picVBWarships.TabIndex = 35
        Me.picVBWarships.TabStop = False
        '
        'lsbScores
        '
        Me.lsbScores.FormattingEnabled = True
        Me.lsbScores.ItemHeight = 15
        Me.lsbScores.Location = New System.Drawing.Point(816, 163)
        Me.lsbScores.Name = "lsbScores"
        Me.lsbScores.Size = New System.Drawing.Size(132, 274)
        Me.lsbScores.TabIndex = 36
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(981, 537)
        Me.Controls.Add(Me.lsbScores)
        Me.Controls.Add(Me.picVBWarships)
        Me.Controls.Add(Me.txtTurnInfo)
        Me.Controls.Add(Me.btnEndTurn)
        Me.Controls.Add(Me.lblGameJ)
        Me.Controls.Add(Me.lblGameI)
        Me.Controls.Add(Me.lblGameH)
        Me.Controls.Add(Me.lblGameG)
        Me.Controls.Add(Me.lblGameF)
        Me.Controls.Add(Me.lblGameE)
        Me.Controls.Add(Me.lblGameD)
        Me.Controls.Add(Me.lblGameC)
        Me.Controls.Add(Me.lblGameB)
        Me.Controls.Add(Me.lblGameA)
        Me.Controls.Add(Me.lblGuessJ)
        Me.Controls.Add(Me.lblGuessI)
        Me.Controls.Add(Me.lblGuessH)
        Me.Controls.Add(Me.lblGuessG)
        Me.Controls.Add(Me.lblGuessF)
        Me.Controls.Add(Me.lblGuessE)
        Me.Controls.Add(Me.lblGuessD)
        Me.Controls.Add(Me.lblGuessC)
        Me.Controls.Add(Me.lblGuessB)
        Me.Controls.Add(Me.lblGuessA)
        Me.Controls.Add(Me.lblGameColumns)
        Me.Controls.Add(Me.lblGuessColumns)
        Me.Controls.Add(Me.lblCoordinates)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.txtPlayerGuess)
        Me.Controls.Add(Me.lblGameBoard)
        Me.Controls.Add(Me.lblGuessBoard)
        Me.Controls.Add(Me.lsbPlayerGameBoard)
        Me.Controls.Add(Me.lsbPlayerGuessBoard)
        Me.Controls.Add(Me.btnForm1Exit)
        Me.Name = "Form1"
        Me.Text = "VB-Warships"
        CType(Me.picVBWarships, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnForm1Exit As Button
    Friend WithEvents lsbPlayerGuessBoard As ListBox
    Friend WithEvents lsbPlayerGameBoard As ListBox
    Friend WithEvents lblGuessBoard As Label
    Friend WithEvents lblGameBoard As Label
    Friend WithEvents txtPlayerGuess As TextBox
    Friend WithEvents btnFire As Button
    Friend WithEvents lblCoordinates As Label
    Friend WithEvents lblGuessColumns As Label
    Friend WithEvents lblGameColumns As Label
    Friend WithEvents lblGuessA As Label
    Friend WithEvents lblGuessB As Label
    Friend WithEvents lblGuessC As Label
    Friend WithEvents lblGuessD As Label
    Friend WithEvents lblGuessE As Label
    Friend WithEvents lblGuessF As Label
    Friend WithEvents lblGuessG As Label
    Friend WithEvents lblGuessH As Label
    Friend WithEvents lblGuessI As Label
    Friend WithEvents lblGuessJ As Label
    Friend WithEvents lblGameJ As Label
    Friend WithEvents lblGameI As Label
    Friend WithEvents lblGameH As Label
    Friend WithEvents lblGameG As Label
    Friend WithEvents lblGameF As Label
    Friend WithEvents lblGameE As Label
    Friend WithEvents lblGameD As Label
    Friend WithEvents lblGameC As Label
    Friend WithEvents lblGameB As Label
    Friend WithEvents lblGameA As Label
    Friend WithEvents btnEndTurn As Button
    Friend WithEvents txtTurnInfo As TextBox
    Friend WithEvents picVBWarships As PictureBox
    Friend WithEvents lsbScores As ListBox
End Class
