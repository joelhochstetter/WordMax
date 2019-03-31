Module mdlPlaceWord
    Dim DidNotPlace As Integer
    Sub PlaceWord()
        frmPlay.Placed = False
        IsWordPositionValid(0) 'determines if the position entered is valid and places on board
        If frmPlay.Placed = True Then
            PutWordOnBoard()
            ScoreWord()
            frmPlay.WordsLeft = frmPlay.WordsLeft - 1
            UpdateWordList() 'removes wordlist buttons that aren't needed
            If IsGameOver() = True Then
                frmPlay.EndGame()
            End If
        End If
    End Sub
    Sub ScoreWord()
        Dim addtoscore As Integer 'this stores the points for this word so they add as one value
        addtoscore = Len(frmPlay.WordToPlace) + 10
        For test = 1 To Len(frmPlay.WordToPlace)
            If frmPlay.Overlap(test) = True Then 'If the word is overlapping there is extra points depending on the character value
                Dim Letter As String = UCase(frmPlay.WordToPlace.Chars(test - 1).ToString)
                Select Case Letter
                    Case "A", "E", "I", "O", "U" 'This checks if the letter that is overlapping is of 2 point value
                        addtoscore = addtoscore + 1 'note I have already given a point for the letter being there so it is only one point not two
                    Case "B", "C", "D", "F", "G", "H" 'This checks if the letter that is overlapping is of 4 point value
                        addtoscore = addtoscore + 3
                    Case "J", "K", "L", "M", "N", "P" 'This checks if the letter that is overlapping is of 6 point value
                        addtoscore = addtoscore + 5
                    Case "Q", "R", "S", "T", "V", "W" 'This checks if the letter that is overlapping is of 8 point value
                        addtoscore = addtoscore + 7
                    Case "X", "Y", "Z" 'This checks if the letter that is overlapping is of 10 point value
                        addtoscore = addtoscore + 9
                End Select
            End If
        Next
        frmPlay.score = frmPlay.score + addtoscore
        frmPlay.lblScore.Text = "SCORE:" & vbNewLine & frmPlay.score
        'updates the in-game highscore if you overtake it
        If frmHome.Gamemode = 0 Then
            If frmHome.ClassicHighScore(1) < frmPlay.score Then
                frmPlay.lblHighScore.Text = "HIGH" & vbNewLine & "SCORE:" & vbNewLine & frmPlay.score & vbNewLine & "YOU"
                frmPlay.lblHighScore.Show()
            End If
        Else
            If frmHome.BTCHighScore(1) < frmPlay.score Then
                frmPlay.lblHighScore.Text = "HIGH" & vbNewLine & "SCORE:" & vbNewLine & frmPlay.score & vbNewLine & "YOU"
                frmPlay.lblHighScore.Show()
            End If
        End If
    End Sub
    Sub IsWordPositionValid(ByVal ModuleUse As Integer) 'if called to determine placing words and position is invalid it removes original letter. If called to test if words can still be placed then it does not
        'test this module thoroughly. Check that stuff already handled in frmPlay is not here also. Make sure it gives messages if it fails
        frmPlay.Placed = False
        If frmPlay.WordOrientation = "right" Then
            If (Len(frmPlay.WordToPlace) + frmPlay.WordStartX - 1) > 15 Then 'This determines that all the word fits on the gameboard
                RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                Exit Sub
            End If
            For index = 2 To Len(frmPlay.WordToPlace) 'checks there are no letters already in position that are not valid overlapping letters 
                If frmPlay.GameBoard((frmPlay.WordStartX + index - 1), frmPlay.WordStartY).Text <> "" Then
                    If frmPlay.GameBoard((frmPlay.WordStartX + index - 1), frmPlay.WordStartY).Text = frmPlay.WordToPlace.Chars(index - 1) Then
                        frmPlay.Overlap(index) = True
                    Else
                        RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                        Exit Sub
                    End If
                End If
            Next
            If frmPlay.WordStartX + Len(frmPlay.WordToPlace) < 16 Then
                If frmPlay.GameBoard((frmPlay.WordStartX + Len(frmPlay.WordToPlace)), (frmPlay.WordStartY)).Text <> "" Then 'checks that there are no letters at the end of the word
                    If frmPlay.Overlap(1) = False And ModuleUse = 0 Then
                        frmPlay.GameBoard(frmPlay.WordStartX, frmPlay.WordStartY).Text = ""
                        frmPlay.GameBoard(frmPlay.WordStartX, frmPlay.WordStartY).BackColor = Color.White
                        MsgBox("Invalid position")
                    End If
                    Exit Sub
                End If
            End If
            If frmPlay.WordStartX > 1 Then
                If frmPlay.GameBoard((frmPlay.WordStartX - 1), (frmPlay.WordStartY)).Text <> "" Then 'checks that there are no letters at the front and end of the word
                    RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                    Exit Sub
                End If
            End If
            For index = 1 To Len(frmPlay.WordToPlace) 'checks that there are only letters above and below if the letter is overlapping with another word
                If frmPlay.Overlap(index) = False Then
                    If frmPlay.WordStartY > 1 Then
                        If frmPlay.GameBoard((frmPlay.WordStartX - 1 + index), (frmPlay.WordStartY - 1)).Text <> "" Then
                            RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                            Exit Sub
                        End If
                    End If
                    If frmPlay.WordStartY < 15 Then
                        If frmPlay.GameBoard((frmPlay.WordStartX - 1 + index), (frmPlay.WordStartY + 1)).Text <> "" Then
                            RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                            Exit Sub
                        End If
                    End If
                End If
            Next
        Else 'this means that the orientation is  down
            If (Len(frmPlay.WordToPlace) + frmPlay.WordStartY - 1) > 15 Then 'This determines that all the word fits on the gameboard
                RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                Exit Sub
            End If
            For index = 2 To Len(frmPlay.WordToPlace) 'checks there are no letters already in position that are not valid overlapping letters 
                If frmPlay.GameBoard(frmPlay.WordStartX, (frmPlay.WordStartY + index - 1)).Text <> "" Then
                    If frmPlay.GameBoard(frmPlay.WordStartX, (frmPlay.WordStartY + index - 1)).Text = frmPlay.WordToPlace.Chars(index - 1) Then
                        frmPlay.Overlap(index) = True
                    Else
                        RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                        Exit Sub
                    End If
                End If
            Next
            If frmPlay.WordStartY + Len(frmPlay.WordToPlace) < 16 Then
                If frmPlay.GameBoard(frmPlay.WordStartX, (frmPlay.WordStartY + Len(frmPlay.WordToPlace))).Text <> "" Then 'checks that there are no letters at the end of the word
                    RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                    Exit Sub
                End If
            End If
            If frmPlay.WordStartY > 1 Then
                If frmPlay.GameBoard((frmPlay.WordStartX), (frmPlay.WordStartY - 1)).Text <> "" Then 'checks that there are no letters at the front and end of the word
                    RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                    Exit Sub
                End If
            End If
            For index = 1 To Len(frmPlay.WordToPlace) 'checks that there are only letters above and below if the letter is overlapping with another word
                If frmPlay.Overlap(index) = False Then
                    If frmPlay.WordStartX > 1 Then
                        If frmPlay.GameBoard((frmPlay.WordStartX - 1), (frmPlay.WordStartY - 1 + index)).Text <> "" Then
                            RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                            Exit Sub
                        End If
                    End If
                    If frmPlay.WordStartX < 15 Then
                        If frmPlay.GameBoard((frmPlay.WordStartX + 1), (frmPlay.WordStartY - 1 + index)).Text <> "" Then
                            RemoveFirstLetter(ModuleUse) 'this changes the board back to what it was before the user attempted to place the invalid word
                            Exit Sub
                        End If
                    End If
                End If
            Next
        End If
        frmPlay.Placed = True
    End Sub
    Sub UpdateWordList()
        For index = frmPlay.WordToPlaceIndex To frmPlay.WordsLeft 'moves all words down one position in array
            frmPlay.WordList(index) = frmPlay.WordList(index + 1)
        Next
        frmPlay.WordList(frmPlay.WordsLeft + 1) = "" 'this removes the final word in the list which is a repeat of what has been moved places in the array
        For index = 1 To 45
            If frmPlay.WordList(index) = "" Then
                frmPlay.BtnWordList(index).Visible = False 'hides all empty spots in array
            Else
                frmPlay.BtnWordList(index).Text = frmPlay.WordList(index) 'updates words on other buttons to what is in array
            End If
        Next
        frmPlay.BtnWordList(frmPlay.WordToPlaceIndex).BackColor = Color.White
    End Sub
    Sub PutWordOnBoard()
        If frmPlay.WordOrientation = "right" Then
            For index = 1 To Len(frmPlay.WordToPlace) 'loops through each letter in word
                frmPlay.GameBoard((frmPlay.WordStartX - 1 + index), frmPlay.WordStartY).Text = frmPlay.WordToPlace.Chars(index - 1).ToString 'puts letter corresponding to that position on square
                If frmPlay.Overlap(index) = True Then 'colouring is dependent on whether or not there is an overlap
                    frmPlay.GameBoard((frmPlay.WordStartX - 1 + index), frmPlay.WordStartY).BackColor = Color.Orange
                Else
                    frmPlay.GameBoard((frmPlay.WordStartX - 1 + index), frmPlay.WordStartY).BackColor = Color.LimeGreen
                End If
            Next
        Else 'same process for words that are down
            For index = 1 To Len(frmPlay.WordToPlace)
                frmPlay.GameBoard(frmPlay.WordStartX, (frmPlay.WordStartY - 1 + index)).Text = frmPlay.WordToPlace.Chars(index - 1).ToString
                If frmPlay.Overlap(index) = True Then
                    frmPlay.GameBoard(frmPlay.WordStartX, (frmPlay.WordStartY - 1 + index)).BackColor = Color.Orange
                Else
                    frmPlay.GameBoard(frmPlay.WordStartX, (frmPlay.WordStartY - 1 + index)).BackColor = Color.LimeGreen
                End If
            Next
        End If
    End Sub
    Function IsGameOver() As Boolean
        'how this works:
        'once each word is placed it goes through the wordlist
        'if the first character overlaps or the square is empty it checks for both orientations whther the word is valid using IsWordPositionValid sub
        'But it uses a special type of call of that sub hence IsWordPositionValid(1) so that letters are not removed if it is invalid
        'if a valid position is found sub ends, returns true and the game continues
        'if a valid position is not found it keeps looking through words until one is found
        'if one is not found then the EndGame sub is called
        For index = 1 To frmPlay.WordsLeft
            frmPlay.WordToPlace = frmPlay.WordList(index)
            For horizontal = 1 To 15
                For vertical = 1 To 15
                    If frmPlay.GameBoard(horizontal, vertical).Text = "" Or frmPlay.GameBoard(horizontal, vertical).Text = frmPlay.WordToPlace.Chars(0) Then
                        frmPlay.WordStartX = horizontal
                        frmPlay.WordStartY = vertical
                        frmPlay.WordOrientation = "right"
                        If frmPlay.WordToPlace.Chars(0) = frmPlay.GameBoard(horizontal, vertical).Text Then
                            frmPlay.Overlap(1) = True
                        Else
                            frmPlay.Overlap(1) = False
                        End If
                        IsWordPositionValid(1)
                        If frmPlay.Placed = True Then
                            Return False
                            Exit Function
                        End If
                        frmPlay.WordOrientation = "down"
                        frmPlay.Overlap(1) = False
                        IsWordPositionValid(1)
                        If frmPlay.Placed = True Then
                            Return False
                            Exit Function
                        End If
                    End If
                Next
            Next
        Next
        Return True
    End Function
    Sub RemoveFirstLetter(ByVal ModuleUse As Integer)
        If ModuleUse = 0 Then 'if the word cannot be placed in the wordplacing module then it sets the square back to was before. If it is checking if the game if over then it doesn't touch anything
            If frmPlay.Overlap(1) = False Then 'both these options allow the square to be set to its original condition
                frmPlay.GameBoard(frmPlay.WordStartX, frmPlay.WordStartY).Text = ""
                frmPlay.GameBoard(frmPlay.WordStartX, frmPlay.WordStartY).BackColor = Color.White
            Else
                frmPlay.GameBoard(frmPlay.WordStartX, frmPlay.WordStartY).BackColor = Color.LimeGreen
            End If
            MsgBox("Invalid position")
        End If
    End Sub
End Module
