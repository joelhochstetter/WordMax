Public Class frmPlay
    Public BtnWordList(45) As Button
    Public WordList(45) As String
    Dim Time As Integer = 120
    Public Overlap(10) As Boolean
    Public Placed As Integer
    Public WordStartX As Integer
    Public WordStartY As Integer
    Public WordToPlace As String
    Public WordToPlaceIndex As Integer = -1
    Public WordsInList As Integer
    Public WordOrientation As String
    Public score As Integer
    Public WordListButton(3, 15) As Button
    Public SelectedWordlist As String
    Public GameBoard(15, 15) As Button           'array of buttons that make up the game board
    'make variables for word placing when I work out how to do it
    'screen elements. need to add buttons, timer, game board, game list, sort
    Dim PlaceType As Integer 'this is an integer and depending on the remainder when divided determines if 
    Public WordsLeft As Integer = 45
    Dim EndOfGame As Boolean
    Dim PlayerName As String
    Dim NamePos As Integer
    Private Sub Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmHome.Gamemode = 0 Then 'sets the settings deping on the gamemode. There is a different colourscheme for beat the clock
            BackColor = Color.PowderBlue
            lblHeader.Text = "Classic"
        Else
            BackColor = Color.DarkGray
            lblHeader.Text = "Beat the Clock"
            lblBTCTime.Visible = True
            lblSelectHeader.ForeColor = Color.White
            radioAni.ForeColor = Color.White
            radioComp.ForeColor = Color.White
            lblHS.ForeColor = Color.White
            lblName.ForeColor = Color.White
            lblSelectHeader.ForeColor = Color.White
            lblWList.ForeColor = Color.White
        End If
        lblScore.Text = "SCORE:" & vbNewLine & score
        If frmHome.Gamemode = 0 Then 'if there is a highscore for the gamemode you are playing it is displayed
            If frmHome.ClassicHighScore(1) > 0 Then
                lblHighScore.Text = "HIGH" & vbNewLine & "SCORE:" & vbNewLine & frmHome.ClassicHighScore(1) & vbNewLine & frmHome.ClassicHighScoreName(1)
            Else
                lblHighScore.Hide()
            End If
        Else
            If frmHome.BTCHighScore(1) > 0 Then
                lblHighScore.Text = "HIGH" & vbNewLine & "SCORE:" & vbNewLine & frmHome.BTCHighScore(1) & vbNewLine & frmHome.BTCHighScoreName(1)
            Else
                lblHighScore.Hide()
            End If
        End If
        btnSortAlphabetically.Hide()
        btnSortByLen.Hide()
        WordsLeft = 45
        EndOfGame = True
        btnQuit.Text = "HOME" 'so that the user is entirely clear over what the quit button does
    End Sub
    Sub EndGame()
        EndOfGame = True
        btnQuit.Text = "HOME"
        Dim index As Integer
        For horizontal = 1 To 15 'removes the gameboard
            For vertical = 1 To 15
                Controls.Remove(GameBoard(horizontal, vertical))
            Next
        Next
        For count = 1 To WordsLeft 'removes the wordlist buttons
            Controls.Remove(BtnWordList(count))
        Next
        lblWList.Hide()
        btnSortAlphabetically.Hide()
        btnSortByLen.Hide()
        btnHelp.Hide()
        lblScore.Hide()
        lblFinalScore.Show()
        lblHighScore.Visible = False 'I change the attribute incase it has already been hidden
        lblFinalScore.Text = "FINAL SCORE: " & score
        btnGoToHS.Show()
        If frmHome.Gamemode = 0 Then 'Only changes high scores if it is a high score
            If score > frmHome.ClassicHighScore(10) Then
                lblHS.Show()
                txtName.Show()
                btnEnterName.Show()
                index = 9
                While score > frmHome.ClassicHighScore(index) And index > 0 'uses an insertion sort to add to the new highscore to the array
                    frmHome.ClassicHighScore(index + 1) = frmHome.ClassicHighScore(index)
                    frmHome.ClassicHighScoreName(index + 1) = frmHome.ClassicHighScoreName(index) 'name as well as score is moved
                    index = index - 1
                End While
                frmHome.ClassicHighScore(index + 1) = score
                NamePos = index + 1 'this is so that when name is entered the index of where to add the corresponding name as well
            End If
        Else 'same thing for beat the clock
            If score > frmHome.BTCHighScore(10) Then
                lblHS.Show()
                txtName.Show()
                btnEnterName.Show()
                index = 9
                While score > frmHome.BTCHighScore(index) And index > 0
                    frmHome.BTCHighScore(index + 1) = frmHome.BTCHighScore(index)
                    frmHome.BTCHighScoreName(index + 1) = frmHome.BTCHighScoreName(index)
                    index = index - 1
                End While
                frmHome.BTCHighScore(index + 1) = score
                NamePos = index + 1
            End If
        End If
        If frmHome.Gamemode = 0 Then
            WriteHighScoresFile(0) 'writes to classic high score files
        Else
            WriteHighScoresFile(1) 'writes to beat the clock high score files
        End If
    End Sub
    Sub GenerateGameBoard()
        Const SquareSize As Integer = 35 'This is the size of each square (Button) in the game
        'following loops set properties of each button in the array and places them on the form 
        For horizontal = 1 To 15
            For vertical = 1 To 15
                GameBoard(horizontal, vertical) = New Button 'creates a button
                GameBoard(horizontal, vertical).Size = New System.Drawing.Size(SquareSize, SquareSize)
                GameBoard(horizontal, vertical).Name = horizontal & "," & vertical 'this name is used so that it is more simple to obtain the index when clicked
                GameBoard(horizontal, vertical).Visible = True
                GameBoard(horizontal, vertical).Location = New System.Drawing.Point(SquareSize * (horizontal - 1) + 10, (vertical - 1) * SquareSize + 125)
                GameBoard(horizontal, vertical).TextAlign = ContentAlignment.MiddleCenter
                GameBoard(horizontal, vertical).Text = ""
                GameBoard(horizontal, vertical).Font = New Font("Microsoft Sans Serif", 12) 'sets font size to 12
                GameBoard(horizontal, vertical).BackColor = Color.White
                GameBoard(horizontal, vertical).ForeColor = Color.Black
                Controls.Add(GameBoard(horizontal, vertical))
                AddHandler GameBoard(horizontal, vertical).Click, AddressOf BoardBox_Click
                GameBoard(horizontal, vertical).Enabled = False
            Next
        Next
        'the following generates buttons for the btnWordList in 3 columns
        For index = 1 To 15
            BtnWordList(index) = New Button
            BtnWordList(index).Size = New System.Drawing.Size(136, SquareSize)
            BtnWordList(index).Name = "BtnWordList(" & index & ")"
            BtnWordList(index).Visible = True
            BtnWordList(index).Location = New System.Drawing.Point(545, (index - 1) * SquareSize + 125)
            BtnWordList(index).TextAlign = ContentAlignment.MiddleCenter
            BtnWordList(index).Font = New Font("Microsoft Sans Serif", 12) 'sets font size to 12
            BtnWordList(index).BackColor = Color.WhiteSmoke
            BtnWordList(index).Text = WordList(index)
            Controls.Add(BtnWordList(index))
            AddHandler BtnWordList(index).Click, AddressOf WordListBox_Click
        Next
        For index = 16 To 30
            BtnWordList(index) = New Button
            BtnWordList(index).Size = New System.Drawing.Size(136, SquareSize)
            BtnWordList(index).Name = "BtnWordList(" & index & ")"
            BtnWordList(index).Visible = True
            BtnWordList(index).Location = New System.Drawing.Point(136 + 545, (index - 16) * SquareSize + 125)
            BtnWordList(index).TextAlign = ContentAlignment.MiddleCenter
            BtnWordList(index).Font = New Font("Microsoft Sans Serif", 12) 'sets font size to 12
            BtnWordList(index).BackColor = Color.WhiteSmoke
            BtnWordList(index).Text = WordList(index)
            Controls.Add(BtnWordList(index))
            AddHandler BtnWordList(index).Click, AddressOf WordListBox_Click
        Next
        For index = 31 To 45
            BtnWordList(index) = New Button
            BtnWordList(index).Size = New System.Drawing.Size(136, SquareSize)
            BtnWordList(index).Name = "BtnWordList(" & index & ")"
            BtnWordList(index).Visible = True
            BtnWordList(index).Location = New System.Drawing.Point(136 * 2 + 545, (index - 31) * SquareSize + 125)
            BtnWordList(index).TextAlign = ContentAlignment.MiddleCenter
            BtnWordList(index).Font = New Font("Microsoft Sans Serif", 12) 'sets font size to 12
            BtnWordList(index).BackColor = Color.WhiteSmoke
            BtnWordList(index).Text = WordList(index)
            Controls.Add(BtnWordList(index))
            AddHandler BtnWordList(index).Click, AddressOf WordListBox_Click
        Next
    End Sub
    Private Sub BoardBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        'note sender is the button clicked. Its text is the word on the button clicked
        Dim horizontal As Integer = StripP(Microsoft.VisualBasic.Left(CType(sender, Button).Name, 2)) 'this stores the horizontal coordinate of the clicked box
        Dim vertical As Integer = StripP(Microsoft.VisualBasic.Right(CType(sender, Button).Name, 2)) 'this stores the vertical coordinate of the clicked box
        If PlaceType Mod 2 = 1 Then 'determines whether it is placing the first letter or the direction of the word
            'if the square clicked is empty or shares letters with first letter of the wordtoplace
            If GameBoard(horizontal, vertical).Text = "" Or GameBoard(horizontal, vertical).Text = Microsoft.VisualBasic.Left(WordToPlace, 1) Then
                WordStartX = horizontal
                WordStartY = vertical
                If GameBoard(horizontal, vertical).Text = "" Then
                    Overlap(1) = False
                    GameBoard(horizontal, vertical).BackColor = Color.LimeGreen
                Else
                    Overlap(1) = True
                    GameBoard(horizontal, vertical).BackColor = Color.Orange
                End If
                sender.text = Microsoft.VisualBasic.Left(WordToPlace, 1) 'assign text to button
                If WordsLeft > 42 Then 'until you place 3 words this displays to ensure that you get the hang of how to play
                    MsgBox("Click a square directly BELOW or to the RIGHT to place word.")
                End If
            Else
                MsgBox("Invalid position")
                PlaceType = PlaceType - 1
            End If
        Else
            'the following allows you to select the orientation to place the word
            If horizontal = WordStartX Or vertical = WordStartY Then
                If vertical > WordStartY Then
                    WordOrientation = "down"
                ElseIf horizontal > WordStartX Then
                    WordOrientation = "right"
                Else
                    MsgBox("Invalid orientation") 'give option to replace word
                    Exit Sub
                End If
            Else
                MsgBox("Invalid orientation")
                Exit Sub
            End If
            For index = 2 To 10 'initialises whether of not following letters of the word are overlapping
                Overlap(index) = False
            Next
            Call PlaceWord()
            BtnWordList(WordToPlaceIndex).BackColor = Color.White
            For horizontal = 1 To 15 'disables buttons once word is placed or if it can't be placed
                For vertical = 1 To 15
                    GameBoard(horizontal, vertical).Enabled = False
                Next
            Next
        End If
        PlaceType = PlaceType + 1
    End Sub
    Private Sub WordListBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        If WordsLeft > 42 Then
            MsgBox("click a square to place the FIRST letter of this word")
        End If
        If WordToPlaceIndex > 0 Then
            BtnWordList(WordToPlaceIndex).BackColor = Color.White 'resets the word previously clicked
        End If
        For horizontal = 1 To 15
            For vertical = 1 To 15
                GameBoard(horizontal, vertical).Enabled = True
            Next
        Next
        If PlaceType Mod 2 = 0 Then 'this means that the first letter has been placed but the remainder of the word has not
            If Overlap(1) = False Then
                GameBoard(WordStartX, WordStartY).Text = ""
                GameBoard(WordStartX, WordStartY).BackColor = Color.White
            Else
                GameBoard(WordStartX, WordStartY).BackColor = Color.LimeGreen
            End If
        End If
        WordToPlaceIndex = StripP(Microsoft.VisualBasic.Right(CType(sender, Button).Name, 3))
        WordToPlace = sender.Text()
        PlaceType = 1
        BtnWordList(WordToPlaceIndex).BackColor = Color.Yellow
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click 'this button is to confirm your word list
        'the below hides and shows elements so game play can begin and initialises some values
        lblSelectHeader.Hide()
        btnQuit.Text = "FINISH"
        EndOfGame = False
        btnConfirm.Hide()
        radioAni.Hide()
        radioComp.Hide()
        btnSortAlphabetically.Show()
        btnSortByLen.Show()
        lblWList.Show()
        Call GenerateGameWordList()
        Call GenerateGameBoard()
        WordToPlace = "" 'get this if anything is clicked besides a spot on the board
        PlaceType = 1
        For index = 1 To 10
            Overlap(index) = False
        Next
        If frmHome.Gamemode = 1 Then
            BTCTimer.Enabled = True
        End If
        MsgBox("select a word from the wordlist on the RIGHT") 'provides an initial prompt as how to play
    End Sub

    Private Sub radioAnimals_CheckedChanged(sender As Object, e As EventArgs) Handles radioAni.CheckedChanged
        SelectedWordlist = "Animals"
        If btnConfirm.Visible = False Then
            btnConfirm.Show()
        End If
    End Sub

    Private Sub radioComputing_CheckedChanged(sender As Object, e As EventArgs) Handles radioComp.CheckedChanged
        SelectedWordlist = "Computing"
        If btnConfirm.Visible = False Then
            btnConfirm.Show()
        End If
    End Sub

    Private Sub btnSortAlphabetically_Click(sender As Object, e As EventArgs) Handles btnSortAlphabetically.Click
        SortAlphabetically() 'calls function to sort wordlist alphabetically
        For index = 1 To 45 'updates wordlist buttons to correspond with wordlist
            BtnWordList(index).Text = WordList(index)
        Next
    End Sub

    Private Sub btnSortByLen_Click(sender As Object, e As EventArgs) Handles btnSortByLen.Click
        SortByLength() 'calls function to sort wordlist by length
        For index = 1 To 45 'updates wordlist buttons to correspond with wordlist
            BtnWordList(index).Text = WordList(index)
        Next
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        If EndOfGame = False Then
            EndGame() 'calls endgame function
        Else 'if its already the end of game it closes form and opens home
            Me.Close()
            frmHome.Show()
        End If
    End Sub

    Private Sub btnEnterName_Click(sender As Object, e As EventArgs) Handles btnEnterName.Click 'allows user to enter name at the end of game
        PlayerName = txtName.Text
        If frmHome.Gamemode = 0 Then
            frmHome.ClassicHighScoreName(NamePos) = PlayerName
            WriteHighScoresFile(0)
        Else
            frmHome.BTCHighScoreName(NamePos) = PlayerName
            WriteHighScoresFile(1)
        End If
        txtName.Hide()
        btnEnterName.Hide()
    End Sub

    Private Sub btnGoToHS_Click(sender As Object, e As EventArgs) Handles btnGoToHS.Click
        Me.Close()
        frmHighScores.Show()
    End Sub
    Private Sub btnQuit_MouseHover(sender As Object, e As EventArgs) Handles btnQuit.MouseHover
        If EndOfGame = 0 Then
            HoverOverText.Show("Ends the game", btnQuit)
        Else
            HoverOverText.Show("Return to home screen", btnQuit)
        End If
    End Sub
    Private Sub btnSortByLen_MouseHover(sender As Object, e As EventArgs) Handles btnSortByLen.MouseHover
        HoverOverText.Show("Sorts by length of word", btnSortByLen)
    End Sub
    Private Sub btnSortAlphabetically_MouseHover(sender As Object, e As EventArgs) Handles btnSortAlphabetically.MouseHover
        HoverOverText.Show("Sorts alphabetically", btnSortAlphabetically)
    End Sub
    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles BTCTimer.Tick 'this is only for the beat the clock gamemode
        Time = Time - 1 'decreases time. in properties interval is 1000 so is each second
        lblBTCTime.Text = "TIME: " & Time 'updates time label
        If Time = 0 Then 'when time is elapsed it stops
            BTCTimer.Enabled = False
            lblBTCTime.Visible = False
            EndGame()
        End If
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub
End Class