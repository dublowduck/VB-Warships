Public Class Form1

    Private Sub readyPlayer1()
        'load the arrays for the players boards, fill them with water and print them to list boxes

        System.Diagnostics.Debug.WriteLine("readyPlayer1")

        'Step 1: create player game array
        Dim arrayPlayerGameBoard(9, 9) As Integer 'Create board for the positions of the players ships
        'set all squares of the game board to 0 (water)
        For x = 0 To UBound(arrayPlayerGameBoard) 'for every column  x
            For y = 0 To UBound(arrayPlayerGameBoard) 'for every row y
                arrayPlayerGameBoard(0, y) = 0 'set selected cell in row y to 0
            Next
            arrayPlayerGameBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        'print player game array to lsbPlayerGameBoard
        System.Diagnostics.Debug.WriteLine("readyPlayer1: add 'arrayPlayerGameBoard' to 'lsbPlayerGameBoard'")
        Dim rows(9) As String
        lsbPlayerGuessBoard.Items.Clear()
        For r = 0 To 9
            For c = 0 To 9
                rows(r) &= arrayPlayerGameBoard(r, c)
                If c < 9 Then
                    rows(r) &= " " 'this puts a space between each item horizontally
                End If
            Next
            lsbPlayerGameBoard.Items.Add(rows(r))
        Next

        ' Step 2: load player guess array
        Dim arrayPlayerGuessBoard(9, 9) As Integer 'board for the positions of the players guesses

        'set all squares of the guess board to 0 (water)
        For x = 0 To UBound(arrayPlayerGuessBoard) 'for every column  x
            For y = 0 To UBound(arrayPlayerGuessBoard) 'for every row y
                arrayPlayerGuessBoard(x, y) = 0 'set selected cell in row y to 0
            Next
            arrayPlayerGuessBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        'print player guess array to lsbPlayerGuessBoard
        System.Diagnostics.Debug.WriteLine("readyPlayer1: add 'arrayPlayerGuessBoard' to 'lsbPlayerGuessBoard'")
        Dim rows2(9) As String
        lsbPlayerGuessBoard.Items.Clear()
        For r = 0 To 9
            For c = 0 To 9
                rows2(r) &= arrayPlayerGuessBoard(r, c)
                If c < 9 Then
                    rows2(r) &= " " 'this puts a space between each item horizontally
                End If
            Next
            lsbPlayerGuessBoard.Items.Add(rows2(r))
        Next

        System.Diagnostics.Debug.WriteLine("Exit: readyPlayer1")
    End Sub

    Public Sub readyPlayerComputer()
        'load the arrays for the computers boards, fill them with water and then add ships from hard coded layout

        System.Diagnostics.Debug.WriteLine("readyPlayerComputer")
        ' meaning of all values in the array
        ' 0 = water
        ' 1 = destroyer (2 holes)
        ' 2 = cruiser (3 holes)
        ' 3 = submarine (3 holes)
        ' 4 = battleship (4 holes)
        ' 5 = aircraft carrier (5 holes)

        ' Step 1: load computer game array
        Dim arrayComputerGameBoard(9, 9) As Integer 'Create board for the positions of the players ships

        'set all squares of the game board to 0 (water)
        For x = 0 To UBound(arrayComputerGameBoard) 'for every column  x
            For y = 0 To UBound(arrayComputerGameBoard) 'for every row y
                arrayComputerGameBoard(0, y) = 0 'set selected cell in row y to 0
            Next
            arrayComputerGameBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        'Hard coded layout:
        '    0 1 2 3 4 5 6 7 8 9

        '0:  0 3 3 3 0 0 0 0 0 0
        '1:  0 0 0 0 0 0 0 0 0 0
        '2:  0 5 5 5 5 5 0 0 0 0
        '3:  0 0 0 0 0 0 0 2 2 2
        '4:  0 0 1 0 0 0 0 0 0 0
        '5:  0 0 1 4 0 0 0 0 0 0
        '6:  0 0 0 4 0 0 0 0 0 0
        '7:  0 0 0 4 0 0 0 0 0 0
        '8:  0 0 0 4 0 0 0 0 0 0
        '9:  0 0 0 0 0 0 0 0 0 0

        'add the ships from the hard coded layout above
        System.Diagnostics.Debug.WriteLine("readyPlayerComputer: add ships to Computer game board")
        arrayComputerGameBoard(0, 1) = 3
        arrayComputerGameBoard(0, 2) = 3
        arrayComputerGameBoard(0, 3) = 3
        arrayComputerGameBoard(2, 1) = 5
        arrayComputerGameBoard(2, 2) = 5
        arrayComputerGameBoard(2, 3) = 5
        arrayComputerGameBoard(2, 4) = 5
        arrayComputerGameBoard(2, 5) = 5
        arrayComputerGameBoard(3, 7) = 2
        arrayComputerGameBoard(3, 8) = 2
        arrayComputerGameBoard(3, 9) = 2
        arrayComputerGameBoard(4, 2) = 1
        arrayComputerGameBoard(5, 2) = 1
        arrayComputerGameBoard(3, 5) = 4
        arrayComputerGameBoard(3, 6) = 4
        arrayComputerGameBoard(3, 7) = 4
        arrayComputerGameBoard(3, 8) = 4

        ' Step 2: load computer guess array
        Dim arrayComputerGuessBoard(9, 9) As Integer 'board for the positions of the players guesses

        'set all squares of the guess array to 0 (water)
        For x = 0 To UBound(arrayComputerGuessBoard) 'for every column  x
            For y = 0 To UBound(arrayComputerGuessBoard) 'for every row y
                arrayComputerGuessBoard(x, y) = 0 'set selected cell in row y to 0
            Next
            arrayComputerGuessBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        System.Diagnostics.Debug.WriteLine("Exit: readyPlayerComputer")
    End Sub

    Private Sub loadGame()
        System.Diagnostics.Debug.WriteLine("loadGame:")
        System.Diagnostics.Debug.WriteLine("Call: readyPlayer1")
        readyPlayer1() '(Yes I did Structure this program deliberately so I could write Ready Player 1)
        System.Diagnostics.Debug.WriteLine("Call: readyPlayerComputer")
        readyPlayerComputer()

        System.Diagnostics.Debug.WriteLine("Exit: loadGame")
    End Sub

    Private Sub btnForm1Exit_Click(sender As Object, e As EventArgs) Handles btnForm1Exit.Click
        System.Diagnostics.Debug.WriteLine("EXIT GAME")
        Me.Close() 'close the game
    End Sub

    Private Sub developerSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles developerSettingsToolStripMenuItem.Click
        devSettings.Show() 'open the developer settings window
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine(vbNewLine)
        System.Diagnostics.Debug.WriteLine("Done!")
        System.Diagnostics.Debug.WriteLine("Form1_Load")
        System.Diagnostics.Debug.WriteLine("Call: loadGame()")
        loadGame() 'start the game
        System.Diagnostics.Debug.WriteLine("Exit: Form1_load")
    End Sub

End Class