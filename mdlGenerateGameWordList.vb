Module mdlGenerateGameWordList
    Dim random(10, 15) As Integer 'This allows creation of a random wordlist without repeating words
    Dim numcount(10) As Integer 'this counts the number of words placed in the wordlist for each length
    Dim numthreshold(10) As Integer 'this stores the amount of words for each word length allowed in a list
    Dim rndnum As Integer

    Public Sub GenerateGameWordList()
        numthreshold(3) = 10 'these are the number of words from each length from the program rules
        numthreshold(4) = 8
        numthreshold(5) = 7
        numthreshold(6) = 6
        numthreshold(7) = 5
        numthreshold(8) = 4
        numthreshold(9) = 3
        numthreshold(10) = 2
        For length = 3 To 10 'initialises all values to zero
            For index = 1 To 15
                random(length, index) = 0
            Next
        Next
        frmPlay.WordsInList = 0 'stores the amount of words already in the wordlist
        For count = 3 To 10 'initialises values to zero
            numcount(count) = 0
        Next
        If frmPlay.SelectedWordlist = "Animals" Then 'this struture creates game wordlists randomly from larger wordlist for select wordlist
            For length = 3 To 10
                While numcount(length) < numthreshold(length)
                    Randomize()
                    rndnum = CInt(Math.Ceiling(Rnd() * 14)) + 1 'generates random integer between 1 and 15 
                    If random(length, rndnum) = 0 And frmHome.WListAnimals(length, rndnum) <> "" Then 'needs to compare with both same case then change the case
                        frmPlay.WordsInList = frmPlay.WordsInList + 1
                        frmPlay.WordList(frmPlay.WordsInList) = frmHome.WListAnimals(length, rndnum)
                        random(length, rndnum) = 1 'this prevents a repeat of the value
                        numcount(length) = numcount(length) + 1
                    End If
                End While
            Next
        Else
            For length = 3 To 10
                While numcount(length) < numthreshold(length)
                    rndnum = CInt(Math.Ceiling(Rnd() * 14)) + 1 'generates random integer between 1 and 15 
                    If random(length, rndnum) = 0 And frmHome.WListComputing(length, rndnum) <> "" Then 'needs to compare with both same case then change the case
                        frmPlay.WordsInList = frmPlay.WordsInList + 1
                        frmPlay.WordList(frmPlay.WordsInList) = frmHome.WListComputing(length, rndnum)
                        random(length, rndnum) = 1 'this prevents a repeat of the value
                        numcount(length) = numcount(length) + 1
                    End If
                End While
            Next
        End If
    End Sub
End Module
