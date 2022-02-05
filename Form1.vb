Public Class Form1

    Private Sub readyPlayerComputer()
        'get the computer player ready

        'numbers for all the different ships on the board + water
        '0 = water
        '1 = destroyer (2 holes)
        '2 = submarine (3 holes)
        '3 = cruiser (3 holes)
        '4 = battleship (4 holes)
        '5 = carrier (5 holes)

        Dim computerGameBoard(9, 9) As Integer 'board for the positions of comp's ships

        'set all squares of the game board to 0 (water)
        For x = 0 To UBound(computerGameBoard) 'for every column  x
            For y = 0 To UBound(computerGameBoard) 'for every row y
                computerGameBoard(0, y) = 0 'set selected cell in row y to 0
            Next
            computerGameBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

    End Sub

    Private Sub readyPlayer1()
        'TODO: Make this sub
    End Sub

    Private Sub loadGame()
        readyPlayerComputer()
        readyPlayer1() 'currently does nothing
        '(Yes I did Structure this program deliberately so I could write Ready Player 1)
    End Sub

    Private Sub btnForm1Exit_Click(sender As Object, e As EventArgs) Handles btnForm1Exit.Click
        Me.Close() 'close the game
    End Sub

    Private Sub developerSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles developerSettingsToolStripMenuItem.Click
        devSettings.Show() 'open the developer settings window
    End Sub

    Private Sub btnLoadGame_Click(sender As Object, e As EventArgs)
        loadGame()
    End Sub

End Class