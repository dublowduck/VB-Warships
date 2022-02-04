Public Class Form1

    Private Sub btnForm1Exit_Click(sender As Object, e As EventArgs) Handles btnForm1Exit.Click
        Me.Close()
    End Sub

    Private Sub developerSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles developerSettingsToolStripMenuItem.Click
        devSettings.Show() 'open the developer settings window
    End Sub

End Class