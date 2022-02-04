Imports System.IO 'used for reading files

'VV A window with settings and buttons to test and debug features of the game VV
Public Class devSettings

    Public SR As StreamReader 'delcare a stream Reader for use later

    Public SW As StreamWriter 'delcare a stream Writer for use later

    'declare variables
    Dim filepath As String = "C:\Users\dublo\Desktop\highscore.txt" 'location of the highscore file

    Dim highscore As Integer = 0

    Dim player As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'close the devSettings window
    End Sub

    Private Sub btnShowHighscores_Click(sender As Object, e As EventArgs) Handles btnShowHighscores.Click
        showHighscores() 'read the highscore.txt file and display as message box
    End Sub

    Private Sub btnUpdateScore_Click(sender As Object, e As EventArgs) Handles btnUpdateScore.Click
        Try
            player = txtPlayerName.Text
            highscore = CInt(txtPlayerScore.Text)
            updateHighscoreFile() 'write thease variables to the highscore.txt file
            displayAddedHighscore() 'print thease variables to a messagebox
        Catch ex As InvalidCastException
            MsgBox("Enter correct data type", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            'MsgBox("Something has gone wrong", "Error", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub displayAddedHighscore()
        'tell the user what your adding to the highscore.txt file
        MessageBox.Show("Player " + "'" + player + "' added score of '" + CStr(highscore) + "'", "Highscore updated")
    End Sub

    Private Sub showHighscores() 'read the highscore.txt file and display as message box
        Try
            SR = New StreamReader(filepath)
            Dim filecontense As String
            filecontense = SR.ReadToEnd()
            MessageBox.Show(filecontense)
            SR.Close()
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("'highscore.txt' file not found")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub updateHighscoreFile()
        Try
            If Not My.Computer.FileSystem.FileExists(filepath) Then
                'create highscore.txt file
                SW = New StreamWriter(filepath, True)
                SW.WriteLine("'Game' Highscores:")
                SW.WriteLine("-------------------")
                SW.WriteLine(System.Environment.NewLine)
                SW.Close()
            End If
            SW = New StreamWriter(filepath, True) 'open highscore.txt and append new scores to it
            SW.WriteLine(CStr(highscore) & " " & player)
            SW.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class