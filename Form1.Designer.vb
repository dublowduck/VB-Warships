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
        Me.lblGamePlaceholder = New System.Windows.Forms.Label()
        Me.btnForm1Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGamePlaceholder
        '
        Me.lblGamePlaceholder.AutoSize = True
        Me.lblGamePlaceholder.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGamePlaceholder.Location = New System.Drawing.Point(250, 208)
        Me.lblGamePlaceholder.Name = "lblGamePlaceholder"
        Me.lblGamePlaceholder.Size = New System.Drawing.Size(273, 37)
        Me.lblGamePlaceholder.TabIndex = 0
        Me.lblGamePlaceholder.Text = "Placeholder for Game"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnForm1Exit)
        Me.Controls.Add(Me.lblGamePlaceholder)
        Me.Name = "Form1"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGamePlaceholder As Label
    Friend WithEvents btnForm1Exit As Button
End Class
