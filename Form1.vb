Imports System.IO 'used for reading and writing files

Public Class Form1

    Public SR As StreamReader 'declare a Stream Reader for use later
    Public SW As StreamWriter 'declare a Stream Writer for use later

    'create global arrays

    Dim arrayPlayerGameBoard(9, 9) As Integer 'Create board for the positions of the players ships
    Dim arrayPlayerGuessBoard(9, 9) As Integer 'board for the positions of the players guesses
    Dim arrayComputerGameBoard(9, 9) As Integer 'Create board for the positions of the computers ships
    Dim arrayComputerGuessBoard(9, 9) As Integer 'board for the positions of the players guesses
    Dim arraySortedScores(900) As String 'an array for the scores of players sorted from low to high

    'create global variables
    Dim strScoreFilepath As String = "scores.txt" 'location of the score file

    Dim strPlayerName As String = "" 'a variable to store the player name for scores
    Dim strWinner As String = "" 'a variable for the name of the Winner of a game
    Dim intScore As Integer = 0
    Dim intTurn As Integer = 0 'a variable to keep track of who's turn it is ( 0 = player's turn, 1 = computer's turn)
    Dim intShotsFiredPlayer As Integer
    Dim intShotsFiredComputer As Integer
    Dim blnGameHasBeenWon As Boolean = False

    Private Sub readyPlayer1()
        'load the arrays for the players boards, fill them with water and print them to list boxes

        System.Diagnostics.Debug.WriteLine("readyPlayer1")

        'Step 1: Player game array

        'set all squares of the game board to 0 (water)
        For x = 0 To UBound(arrayPlayerGameBoard) 'for every column  x
            For y = 0 To UBound(arrayPlayerGameBoard) 'for every row y
                arrayPlayerGameBoard(0, y) = 0 'set selected cell in row y to 0
            Next
            arrayPlayerGameBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        'Hard coded layout:
        '    0 1 2 3 4 5 6 7 8 9

        '0:  0 3 3 3 0 0 0 0 0 0
        '1:  0 0 0 0 0 0 0 0 0 0
        '2:  0 0 0 0 0 0 0 0 0 0
        '3:  0 0 0 0 0 0 0 2 2 2
        '4:  0 0 1 0 0 0 0 0 0 0
        '5:  0 0 1 4 0 0 0 0 0 0
        '6:  0 0 0 4 0 0 0 0 0 0
        '7:  0 0 0 4 0 0 0 0 0 0
        '8:  0 0 0 4 0 0 0 0 0 0
        '9:  0 0 0 0 0 5 5 5 5 5

        'add the ships from the hard coded layout above
        System.Diagnostics.Debug.WriteLine("readyPlayer1: add ships to player game board")
        arrayPlayerGameBoard(0, 1) = 3
        arrayPlayerGameBoard(0, 2) = 3
        arrayPlayerGameBoard(0, 3) = 3
        arrayPlayerGameBoard(3, 7) = 2
        arrayPlayerGameBoard(3, 8) = 2
        arrayPlayerGameBoard(3, 9) = 2
        arrayPlayerGameBoard(4, 2) = 1
        arrayPlayerGameBoard(5, 2) = 1
        arrayPlayerGameBoard(3, 5) = 4
        arrayPlayerGameBoard(3, 6) = 4
        arrayPlayerGameBoard(3, 7) = 4
        arrayPlayerGameBoard(3, 8) = 4
        arrayPlayerGameBoard(9, 5) = 5
        arrayPlayerGameBoard(9, 6) = 5
        arrayPlayerGameBoard(9, 7) = 5
        arrayPlayerGameBoard(9, 8) = 5
        arrayPlayerGameBoard(9, 9) = 5

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

        ' Step 2: Player guess array

        'set all squares of the guess board to 0 (water)
        For x = 0 To UBound(arrayPlayerGuessBoard) 'for every column  x
            For y = 0 To UBound(arrayPlayerGuessBoard) 'for every row y
                arrayPlayerGuessBoard(x, y) = 0 'set selected cell in row y to 0
            Next
            arrayPlayerGuessBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        System.Diagnostics.Debug.WriteLine("Exit: readyPlayer1")
    End Sub

    Public Sub readyPlayerComputer()
        'load the arrays for the computers boards, fill them with water and then add ships from hard coded layout to the game array

        System.Diagnostics.Debug.WriteLine("readyPlayerComputer")
        ' meaning of all values in the array
        ' 0 = water
        ' 1 = destroyer (2 holes)
        ' 2 = cruiser (3 holes)
        ' 3 = submarine (3 holes)
        ' 4 = battleship (4 holes)
        ' 5 = aircraft carrier (5 holes)
        ' 6 = hit ship

        ' Step 1: Computer game array

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

        ' Step 2: Computer guess array

        'set all squares of the guess array to 0 (water)
        For x = 0 To UBound(arrayComputerGuessBoard) 'for every column  x
            For y = 0 To UBound(arrayComputerGuessBoard) 'for every row y
                arrayComputerGuessBoard(x, y) = 0 'set selected cell in row y to 0
            Next
            arrayComputerGuessBoard(x, 0) = 0 'set selected cell in column  x to 0
        Next

        System.Diagnostics.Debug.WriteLine("Exit: readyPlayerComputer")
    End Sub

    Private Sub updateTurnInfo()
        'updates the text box to tell the user who's turn it is
        System.Diagnostics.Debug.WriteLine("updateTurnInfo")
        If intTurn = 0 Then
            txtTurnInfo.Text = "Player's Turn"
            System.Diagnostics.Debug.WriteLine("updateTurnInfo: Player's turn")
        Else
            txtTurnInfo.Text = "Computer's Turn"
            System.Diagnostics.Debug.WriteLine("updateTurnInfo: Computer's turn")
        End If
        System.Diagnostics.Debug.WriteLine("Exit: updateTurnInfo")
    End Sub

    Private Sub loadGame()
        System.Diagnostics.Debug.WriteLine("loadGame:")

        System.Diagnostics.Debug.WriteLine("Call: readyPlayer1")
        readyPlayer1() '(Yes I did Structure this program deliberately so I could write Ready Player 1)
        System.Diagnostics.Debug.WriteLine("Call: readyPlayerComputer")
        readyPlayerComputer()

        'print player game array to lsbPlayerGameBoard
        updateBoard(arrayPlayerGameBoard, lsbPlayerGameBoard)
        'print player guess array to lsbPlayerGuessBoard
        updateBoard(arrayPlayerGuessBoard, lsbPlayerGuessBoard)

        System.Diagnostics.Debug.WriteLine("Call: updateTurnInfo")
        updateTurnInfo()

        'get the player's name
        Do Until strPlayerName.Length > 0 'repeat until player enters a name
            strPlayerName = InputBox("Enter player name :")
            If strPlayerName.Length = 0 Then 'if player doesn't enter a name
                MsgBox("Enter a player name")
            End If
            Diagnostics.Debug.WriteLine("loadGame: Player name is: '" & strPlayerName & "'")
        Loop

        createScoreFile()
        sortScores()
        displayScores()

        System.Diagnostics.Debug.WriteLine("Exit: loadGame")
    End Sub

    Private Sub btnForm1Exit_Click(sender As Object, e As EventArgs) Handles btnForm1Exit.Click
        System.Diagnostics.Debug.WriteLine("EXIT GAME")
        Me.Close() 'close the game
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine(vbNewLine)
        System.Diagnostics.Debug.WriteLine("Done!")
        System.Diagnostics.Debug.WriteLine("Form1_Load")
        System.Diagnostics.Debug.WriteLine("Call: loadGame()")
        loadGame() 'start the game
        System.Diagnostics.Debug.WriteLine("Exit: Form1_load")
    End Sub

    Private Function guessToUpperCase(input As String)
        'capitalise user input
        'Yes I am aware putting this in a function is rather unnecessary
        Diagnostics.Debug.WriteLine("guessToUpperCase")
        Diagnostics.Debug.WriteLine("Return: " & UCase(input))
        Diagnostics.Debug.WriteLine("Exit: guessToUpperCase")
        Return UCase(input)
    End Function

    Private Function validateInput(strCoordinates As String)
        'check that the input is a valid set of coordinates
        Diagnostics.Debug.WriteLine("validateInput")
        Dim intLengthOfCord As Integer = strCoordinates.Length
        Diagnostics.Debug.WriteLine("validateInput: Length of coordinates: " & intLengthOfCord)
        If intLengthOfCord = 2 Or intLengthOfCord = 3 Then 'check for a length of 2 or 3 chars

            'Split the Coordinates:

            'create a variable for X and Y cords
            Dim charYCord As Char
            Dim strXCord As String

            charYCord = Strings.Left(strCoordinates, 1) 'take the first char from the left
            Diagnostics.Debug.WriteLine("validateInput: Y Cord: " & charYCord)
            strXCord = Strings.Right(strCoordinates, intLengthOfCord - 1) 'take the 1st (or 1st and 2nd) chars from the right
            Diagnostics.Debug.WriteLine("validateInput: X Cord: " & strXCord)

            'check if cords are on the board (in range: A1-J10)
            Select Case charYCord
                Case = "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" 'if Y cord is valid
                    Diagnostics.Debug.WriteLine("validateInput: Y Cord '" & charYCord & "': Valid")

                    Select Case strXCord
                        Case = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10  'if X cord is valid
                            Diagnostics.Debug.WriteLine("validateInput: X Cord '" & strXCord & "': Valid")
                            Diagnostics.Debug.WriteLine("Return: True")
                            Diagnostics.Debug.WriteLine("Exit: validateInput")
                            Return True
                            'Yay the end of validateInput!
                            'Return true!
                        Case Else 'if X cord is invalid
                            Diagnostics.Debug.WriteLine("validateInput: X Cord '" & strXCord & "': Invalid")
                            Diagnostics.Debug.WriteLine("validateInput: Enter a valid X coordinate")
                            MessageBox.Show("Enter a valid X coordinate")
                    End Select

                Case Else 'if Y cord is invalid
                    Diagnostics.Debug.WriteLine("validateInput: Y cord not valid")
                    MessageBox.Show("Enter a valid Y coordinate")
                    Diagnostics.Debug.WriteLine("Return: False")
                    Return False
            End Select
        ElseIf intLengthOfCord > 3 Then 'if intput is too long
            Diagnostics.Debug.WriteLine("validateInput: Too many letters")
            MessageBox.Show("Too many letters")
            Diagnostics.Debug.WriteLine("Return False")
            Diagnostics.Debug.WriteLine("Exit: validateInput")
            Return False
        ElseIf intLengthOfCord = 1 Then 'if input is too short
            Diagnostics.Debug.WriteLine("validateInput: Not enough letters")
            MessageBox.Show("Not enough letters!")
            Diagnostics.Debug.WriteLine("Return False")
            Diagnostics.Debug.WriteLine("Exit: validateInput")
            Return False
        End If
        Diagnostics.Debug.WriteLine("Exit: validateInput")
    End Function

    Private Function boardToArray(input As String, intNumberOfCord As Integer)
        'convert board coordinates to array coordinates
        Diagnostics.Debug.WriteLine("boardToArray")
        Dim yCord As Char = Strings.Left(input, 1)
        Diagnostics.Debug.WriteLine("boardToArray: Y Cord = " & yCord)
        Dim xCord As String = Strings.Right(input, intNumberOfCord - 1)
        Diagnostics.Debug.WriteLine("boardToArray: X cord = " & xCord)

        Dim yCordArray As Integer = 0
        Dim xCordArray As Integer = 0

        'I know this is inefficient

        'Convert Y coordinate to array number:
        If yCord = "A" Then
            yCordArray = 0
        ElseIf yCord = "B" Then
            yCordArray = 1
        ElseIf yCord = "C" Then
            yCordArray = 2
        ElseIf yCord = "D" Then
            yCordArray = 3
        ElseIf yCord = "E" Then
            yCordArray = 4
        ElseIf yCord = "F" Then
            yCordArray = 5
        ElseIf yCord = "G" Then
            yCordArray = 6
        ElseIf yCord = "H" Then
            yCordArray = 7
        ElseIf yCord = "I" Then
            yCordArray = 8
        ElseIf yCord = "J" Then
            yCordArray = 9
        End If

        'Convert X coordinate to array number:
        xCordArray = xCord - 1

        'Split the Coordinates:

        'create a variable for X and Y cords
        Dim charYCord As Char
        Dim strXCord As String

        charYCord = Strings.Left(input, 1) 'take the first char from the left
        Diagnostics.Debug.WriteLine("validateInput: Y Cord: " & charYCord)
        strXCord = Strings.Right(input, intNumberOfCord - 1) 'take the 1st (or 1st and 2nd) chars from the right
        Diagnostics.Debug.WriteLine("validateInput: X Cord: " & strXCord)

        Diagnostics.Debug.WriteLine("Return: '" & yCordArray & xCordArray & "'")
        Diagnostics.Debug.WriteLine("Exit: boardToArray")
        Return CStr(yCordArray & xCordArray)
        'return the new coordinates
    End Function

    Public Function checkHit(cords As String, array As Array)
        'check and return what is located in the given array the coordinates provided
        System.Diagnostics.Debug.WriteLine("checkHit")
        'Split the Coordinates:

        'create a variable for X and Y cords
        Dim intYCord As Integer
        Dim intXCord As Integer

        intYCord = Strings.Left(cords, 1) 'take the first char from the left
        Diagnostics.Debug.WriteLine("checkHit: Y Cord: " & intYCord)
        intXCord = Strings.Right(cords, 1) 'take the 1st (or 1st and 2nd) chars from the right
        Diagnostics.Debug.WriteLine("checkHit: X Cord: " & intXCord)

        If array(intYCord, intXCord) = 0 Then
            System.Diagnostics.Debug.WriteLine("Return: 0")
            Diagnostics.Debug.WriteLine("Exit: checkHit")
            Return 0
        ElseIf array(intYCord, intXCord) = 1 Then
            System.Diagnostics.Debug.WriteLine("Return: 1")
            Diagnostics.Debug.WriteLine("Exit: checkHit")
            Return 1
        ElseIf array(intYCord, intXCord) = 2 Then
            System.Diagnostics.Debug.WriteLine("Return: 2")
            Diagnostics.Debug.WriteLine("Exit: checkHit")
            Return 2
        ElseIf array(intYCord, intXCord) = 3 Then
            System.Diagnostics.Debug.WriteLine("Return: 3")
            Diagnostics.Debug.WriteLine("Exit: checkHit")
            Return 3
        ElseIf array(intYCord, intXCord) = 4 Then
            System.Diagnostics.Debug.WriteLine("Return: 4")
            Diagnostics.Debug.WriteLine("Exit: checkHit")
            Return 4
        ElseIf array(intYCord, intXCord) = 5 Then
            System.Diagnostics.Debug.WriteLine("Return: 5")
            Diagnostics.Debug.WriteLine("Exit: checkHit")
            Return 5
        End If

    End Function

    Private Sub updateBoard(inputArray As Array, boardName As ListBox)
        System.Diagnostics.Debug.WriteLine("updateBoard")
        'Format the contents of a 2d array and print it to a listbox

        Dim outputArray(9, 9) As String 'Create an array for "translated" output to board

        'convert inputArray (integer) to output array (string)
        For r = 0 To 9
            For c = 0 To 9
                outputArray(r, c) = inputArray(r, c).ToString
            Next
        Next

        ' 0 = water
        ' 1 = destroyer (2 holes)
        ' 2 = cruiser (3 holes)
        ' 3 = submarine (3 holes)
        ' 4 = battleship (4 holes)
        ' 5 = aircraft carrier (5 holes)
        ' 6 = hit ship
        ' 7 = miss

        'for every column in every row, replace numbers with pictures to represent what the number means
        For r = 0 To 9
            For c = 0 To 9
                Select Case outputArray(r, c)
                    Case 0
                        outputArray(r, c) = "〰  "
                    Case 1
                        outputArray(r, c) = "⛵"
                    Case 2
                        outputArray(r, c) = "🚤"
                    Case 3
                        outputArray(r, c) = "🛥"
                    Case 4
                        outputArray(r, c) = "🚢"
                    Case 5
                        outputArray(r, c) = "⛴"
                    Case 6
                        outputArray(r, c) = "🚩"
                    Case 7
                        outputArray(r, c) = "🏳"
                End Select
            Next
        Next

        'print outputArray to board(boardName)
        System.Diagnostics.Debug.WriteLine("updateBoard: update the board from array")
        Dim rows(9) As String
        boardName.Items.Clear()
        For r = 0 To 9
            For c = 0 To 9
                rows(r) &= outputArray(r, c)
                If c < 9 Then
                    rows(r) &= " " 'this puts a space between each item horizontally
                End If
            Next
            boardName.Items.Add(rows(r))
        Next
        System.Diagnostics.Debug.WriteLine("Exit: updateBoard")
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        'when Fire button is clicked:
        System.Diagnostics.Debug.WriteLine("btnFire_Click")
        If intTurn = 0 Then 'if it's the player's turn
            Dim strUserInput As String

            Dim intLengthOfInput As Integer = txtPlayerGuess.Text.Length 'get the length of the user input
            If intLengthOfInput > 0 Then 'if textbox isn't empty

                strUserInput = txtPlayerGuess.Text
                Diagnostics.Debug.WriteLine("btnFire_Click: user input: " & strUserInput) 'print user input to console
                Dim strUserInputUpper As String
                strUserInputUpper = guessToUpperCase(strUserInput) 'capitalise user input

                If validateInput(strUserInputUpper) = True Then 'if input is real coordinates
                    intTurn = 1 'use up player's turn
                    intShotsFiredPlayer += 1 'add 1 to intShotsFiredPlayer for determining the score if the player wins
                    Dim strFireOrder As String 'create a variable to send to the computer board to check for ships
                    strFireOrder = boardToArray(strUserInputUpper, intLengthOfInput) 'set strFireOrder to the board coordinates converted to array coordinates
                    'split strFireOrder into two integers for X and Y cords
                    Dim intFireOrderX As Integer = Strings.Left(strFireOrder, 1)
                    System.Diagnostics.Debug.WriteLine("btnFire_Click: intFireOrderX = " & intFireOrderX)
                    Dim intFireOrderY As Integer = Strings.Right(strFireOrder, 1)
                    System.Diagnostics.Debug.WriteLine("btnFire_Click: intFireOrderY = " & intFireOrderY)

                    'Call a function to check if fire order is a hit, sink or miss
                    System.Diagnostics.Debug.WriteLine("Call: checkHit")

                    'update player guess array

                    If checkHit(strFireOrder, arrayComputerGameBoard) = 0 Then
                        arrayPlayerGuessBoard(intFireOrderX, intFireOrderY) = 7
                        arrayComputerGameBoard(intFireOrderX, intFireOrderY) = 7
                        MessageBox.Show("Miss!")
                        System.Diagnostics.Debug.WriteLine("Miss")
                    ElseIf checkHit(strFireOrder, arrayComputerGameBoard) = 1 Or 2 Or 3 Or 4 Or 5 Then
                        arrayPlayerGuessBoard(intFireOrderX, intFireOrderY) = 6
                        arrayComputerGameBoard(intFireOrderX, intFireOrderY) = 6
                        MessageBox.Show("Hit!")
                        System.Diagnostics.Debug.WriteLine("Hit")
                    End If

                    System.Diagnostics.Debug.WriteLine("btnFire_Click: Set arrayPlayerGuessBoard(" & intFireOrderX & "," & intFireOrderY & ") to " & checkHit(strFireOrder, arrayComputerGameBoard))

                    'redraw player guess board with new information in the array
                    System.Diagnostics.Debug.WriteLine("Call: updateBoard")
                    updateBoard(arrayPlayerGuessBoard, lsbPlayerGuessBoard)

                End If
            Else
                Diagnostics.Debug.WriteLine("btnFire_Click: No coordinates in box")
                MessageBox.Show("Put some coordinates in the box!")
            End If
        Else
            MessageBox.Show("Not your turn!")
            System.Diagnostics.Debug.WriteLine("Not the player's turn yet")
        End If
        'check to see if this turn ended the game by beating the computer
        If checkForWin(arrayComputerGameBoard, "arrayComputerGameBoard") = "computer" Then
            MsgBox("You loose!")
        ElseIf checkForWin(arrayComputerGameBoard, "arrayComputerGameBoard") = "player" Then
            MsgBox("You win!")
        End If

        System.Diagnostics.Debug.WriteLine("Call: updateTurnInfo")
        updateTurnInfo()
        Diagnostics.Debug.WriteLine("Exit: btnFire_Click")
    End Sub

    Private Sub compTurn()
        'handles the computer's turn
        Diagnostics.Debug.WriteLine("compTurn")
        If intTurn = 1 Then 'if its the computers turn
            'System.Threading.Thread.Sleep(1250) 'pause so the computer's turn doesn't run instantly
            System.Diagnostics.Debug.WriteLine("compTurn: Pause for 750ms")
            System.Diagnostics.Debug.WriteLine("compTurn: Pause done")
            intTurn = 0 'use up the computers turn
            intShotsFiredComputer += 1 'add 1 to intShotsFiredComputer for determining the score if the computer wins
            Dim blnCordsTried As Boolean = True

            'crate variables for coordinates
            Dim intYCord As Integer = 0
            Dim intXCord As Integer = 0

            Do Until blnCordsTried = False 'generate coordinates that haven't been tried yet
                System.Diagnostics.Debug.WriteLine("Start loop")
                'generate random coordinates for attack

                Randomize() 'Initialize the random-number generator
                ' Generate random value between 0 and 9 for both coordinates
                intXCord = CInt(Math.Floor((9 - 0 + 1) * Rnd())) + 0
                intYCord = CInt(Math.Floor((9 - 0 + 1) * Rnd())) + 0
                System.Diagnostics.Debug.WriteLine("compTurn: X cord: " & CStr(intXCord))
                System.Diagnostics.Debug.WriteLine("compTurn: Y cord: " & CStr(intYCord))
                If arrayComputerGuessBoard(intXCord, intYCord) = 1 Then 'if coordinates already tired
                    blnCordsTried = True
                    System.Diagnostics.Debug.WriteLine("compTurn: Coordinate already tired")
                    System.Diagnostics.Debug.WriteLine("Loop again!")
                ElseIf arrayComputerGuessBoard(intXCord, intYCord) = 0 Then 'if coordinates not tired
                    blnCordsTried = False
                    System.Diagnostics.Debug.WriteLine("compTurn: Coordinate not tired")

                End If
                System.Diagnostics.Debug.WriteLine("End loop")
            Loop

            Dim strCords As String = CStr(intXCord) & CStr(intYCord) 'put both coordinates in a string
            'update computer guess array with coordinates that have been guessed
            System.Diagnostics.Debug.WriteLine("compTurn: update arrayComputerGuessBoard(" & intXCord & "," & intYCord & ")")
            arrayComputerGuessBoard(intXCord, intYCord) = 1 ' 1 = coordinate already tried

            System.Diagnostics.Debug.WriteLine("Call: checkHit")
            If checkHit(strCords, arrayPlayerGameBoard) = 0 Then 'if the attack is a miss
                arrayPlayerGameBoard(intXCord, intYCord) = 7 'add miss to player game array
                updateBoard(arrayPlayerGameBoard, lsbPlayerGameBoard) 'update player game board to show miss
                MessageBox.Show("The computer missed") 'tell the player it was a miss
                System.Diagnostics.Debug.WriteLine("compTurn: Miss")
            Else 'if the attack is a hit
                arrayPlayerGameBoard(intXCord, intYCord) = 6 'add hit to player game array
                updateBoard(arrayPlayerGameBoard, lsbPlayerGameBoard) 'update player game board to show hit
                System.Diagnostics.Debug.WriteLine("compTurn: Hit!")
                MessageBox.Show("You have been hit by the computer!") 'tell the player they have been hit
            End If

        ElseIf intTurn = 0 Then 'if it's not the computers turn
            System.Diagnostics.Debug.WriteLine("Not the computers turn yet")
            MessageBox.Show("Not the computer's turn yet")
        End If

        'check to see if this turn ended the game by beating the player
        If checkForWin(arrayPlayerGameBoard, "arrayPlayerGameBoard") = "computer" Then
            MsgBox("You loose!")
        ElseIf checkForWin(arrayPlayerGameBoard, "arrayPlayerGameBoard") = "player" Then
            MsgBox("You win!")
        End If

        System.Diagnostics.Debug.WriteLine("Call: updateTurnInfo")
        updateTurnInfo()
        Diagnostics.Debug.WriteLine("Exit: compTurn")
    End Sub

    Private Sub createScoreFile()
        'if the 'score.txt' file doesn't exist create it
        System.Diagnostics.Debug.WriteLine("createScoreFile")
        If Not My.Computer.FileSystem.FileExists(strScoreFilepath) Then 'if file doesn't exist
            Diagnostics.Debug.WriteLine("createScoreFile: score file doesn't exist")
            'create score.txt file
            SW = New StreamWriter(strScoreFilepath, True)
            SW.WriteLine(System.Environment.NewLine)
            SW.Close()
            Diagnostics.Debug.WriteLine("createScoreFile: Created score file at '" & strScoreFilepath & "'")
        Else
            Diagnostics.Debug.WriteLine("createScoreFile: Score file does exist")
        End If
        System.Diagnostics.Debug.WriteLine("Exit: createScoreFile")
    End Sub

    Private Sub updateScore(strWinner As String)
        'add new scores to score file then display score to player as message box
        System.Diagnostics.Debug.WriteLine("updateScore")
        Try
            If Not My.Computer.FileSystem.FileExists(strScoreFilepath) Then 'if file doesn't exist
                Diagnostics.Debug.WriteLine("updateScore: score file doesn't exist")
                'create score.txt file
                'SW = New StreamWriter(strScoreFilepath, True)
                SW.WriteLine(System.Environment.NewLine)
                SW.Close()
                Diagnostics.Debug.WriteLine("updateScore: Created score file at '" & strScoreFilepath & "'")
            End If

            If strWinner = "computer" Then 'if the computer has won
                intScore = intShotsFiredComputer 'this is actually a low score system
                Try 'add new score to score file
                    SW = New StreamWriter(strScoreFilepath, True) 'open score.txt and append new scores to it
                    'SW.WriteLine(CStr(intScore) & " " & "computer" & ",")
                    SW.WriteLine(CStr(intScore) & ",")
                    SW.Close()
                    Diagnostics.Debug.WriteLine("updateScore: added computer with a score of " & intScore & "to score.txt")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else 'if the player has won
                intScore = intShotsFiredPlayer 'this is actually a low score system
                Try 'add new score to score file
                    SW = New StreamWriter(strScoreFilepath, True) 'open score.txt and append new scores to it
                    'SW.WriteLine(CStr(intScore) & " " & strPlayerName)
                    SW.WriteLine(CStr(intScore) & ",")
                    SW.Close()
                    Diagnostics.Debug.WriteLine("updateScore: added " & strWinner & " with a score of " & intScore & "to score.txt")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

            displayAddedscore() 'print the winner and they're score to a messagebox
        Catch ex As Exception
            MsgBox("Something has gone wrong", "Error", MsgBoxStyle.Exclamation)
        End Try
        System.Diagnostics.Debug.WriteLine("Exit: updateScore")
    End Sub

    Private Sub displayAddedscore()
        'display the score just achieved to the player
        System.Diagnostics.Debug.WriteLine("displayAddedscore")
        MessageBox.Show("Player " + "'" + strWinner + "' added score of '" + CStr(intScore) + "'", "Score updated") 'say what your adding to the score.txt file
        System.Diagnostics.Debug.WriteLine("displayAddedscore: Player " + "'" + strWinner + "' added score of '" + CStr(intScore) + "'")
        System.Diagnostics.Debug.WriteLine("Exit: displayAddedscore")
    End Sub

    Private Sub showscores()
        'read the score.txt file and display as message box
        Diagnostics.Debug.WriteLine("showscores")
        Try
            SR = New StreamReader(strScoreFilepath)
            Dim strFileContense As String
            strFileContense = SR.ReadToEnd()
            MessageBox.Show(strFileContense)
            SR.Close()
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("'score.txt' file not found")
            Diagnostics.Debug.WriteLine("showscores: 'score.txt' file not found")
        Catch ex As Exception
        End Try
        Diagnostics.Debug.WriteLine("Exit: showscores")
    End Sub

    Private Sub sortScores()
        'read scores from disk, split them by "," and sort them
        System.Diagnostics.Debug.WriteLine("sortScores")
        Dim strFileContents As String

        'read the highscores file into memory
        SR = New StreamReader(strScoreFilepath)
        strFileContents = SR.ReadToEnd()
        SR.Close()
        Dim arrayUnsortedScores(strFileContents.Length) As String 'array for guesses before they are sorted

        arrayUnsortedScores = strFileContents.Split(",")
        'and add a check so that the player can't enter a commer in they're name......not done

        arraySortedScores = arrayUnsortedScores

        'bubble sort scores
        For iPass = 1 To UBound(arraySortedScores) 'for every pass
            For i = 0 To UBound(arraySortedScores) - 1 'for every item from the first score
                If arraySortedScores(i) > arraySortedScores(i + 1) Then 'if this item is bigger than the next
                    Dim strTempVar As Integer
                    'swap the item with the next item in the list
                    strTempVar = arraySortedScores(i)
                    arraySortedScores(i) = arraySortedScores(i + 1)
                    arraySortedScores(i + 1) = strTempVar
                End If
            Next
        Next

        System.Diagnostics.Debug.WriteLine("sortScores: Bubble sort compleate")
        System.Diagnostics.Debug.WriteLine("Exit: sortScores")
    End Sub

    Private Sub displayScores() 'was a button, is now very much not a button
        'print the sorted scores to lsbScores
        System.Diagnostics.Debug.WriteLine("displayScores")
        For i = 0 To UBound(arraySortedScores)
            lsbScores.Items.Add(arraySortedScores(i))
        Next
        System.Diagnostics.Debug.WriteLine("Exit: displayScores")
    End Sub

    Private Function checkForWin(gameBoard As Array, gameBoardName As String)
        'check to see if the games has been won
        Diagnostics.Debug.WriteLine("checkForWin")

        If blnGameHasBeenWon = False Then
            Dim blnFound As Boolean = False
            For x = 0 To UBound(gameBoard) 'for every column  x
                For y = 0 To UBound(gameBoard) 'for every row y
                    If gameBoard(x, y) = 1 Or gameBoard(x, y) = 2 Or gameBoard(x, y) = 3 Or gameBoard(x, y) = 4 Or gameBoard(x, y) = 5 Then 'if the square selected is a ship
                        blnFound = True
                        Diagnostics.Debug.WriteLine("ship " & gameBoardName & " " & x & "," & y & " = " & gameBoard(x, y) & " (x,y)")
                    Else
                        Diagnostics.Debug.WriteLine("no ship " & gameBoardName & " " & x & "," & y & " = " & gameBoard(x, y) & " (x,y)")
                    End If
                Next
            Next

            If blnFound = False Then 'if there are no ships left on the gameboard
                If gameBoardName = "arrayPlayerGameBoard" Then 'if the board is the player's game board
                    'computer wins
                    blnGameHasBeenWon = True
                    strWinner = "computer"
                    Diagnostics.Debug.WriteLine("checkForWin: Computer wins!")
                    Diagnostics.Debug.WriteLine("checkForWin: call updateScore")
                    updateScore("computer") 'update the score file with the new score
                    Return "computer"
                End If

                If gameBoardName = "arrayComputerGameBoard" Then 'if the board is the computer's game board
                    'player wins
                    blnGameHasBeenWon = True
                    strWinner = strPlayerName
                    Diagnostics.Debug.WriteLine("checkForWin: Player wins!")
                    Diagnostics.Debug.WriteLine("checkForWin: call updateScore")
                    updateScore("player") 'update the score file with the new score
                    Return "player"
                End If
            Else 'if there are still ships left on the board
                'nobody wins
                Diagnostics.Debug.WriteLine("checkForWin: Nobody wins!")
                Return "nobody"
            End If

        ElseIf blnGameHasBeenWon = True Then
            System.Diagnostics.Debug.WriteLine("checkForWin: Game has already been won")
        End If
        Diagnostics.Debug.WriteLine("Exit: checkForWin")

    End Function

    Private Sub btnEndTurn_Click(sender As Object, e As EventArgs) Handles btnEndTurn.Click
        System.Diagnostics.Debug.WriteLine("btnEndTurn_Click")
        System.Diagnostics.Debug.WriteLine("Call: compTurn")
        compTurn()
        System.Diagnostics.Debug.WriteLine("Exit: btnEndTurn_Click")
    End Sub

End Class