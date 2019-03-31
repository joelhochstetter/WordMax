Module mdlSort
    Dim Temp As String
    Dim index As Integer
    Dim Last As Integer
    Dim Swapped As Boolean
    Public Sub SortAlphabetically() 'uses a bubble sort
        Last = frmPlay.WordsLeft
        Swapped = True
        While Swapped = True 'continues until in correct order
            Swapped = False
            index = 1
            While index < Last 'for one pass it swaps adjacent values if they are out of order
                If frmPlay.WordList(index) > frmPlay.WordList(index + 1) Then
                    Swap(frmPlay.WordList(index), frmPlay.WordList(index + 1))
                    Swapped = True
                End If
                index = index + 1
            End While
            Last = Last - 1
        End While
    End Sub
    Public Sub SortByLength() 'uses a bubble sort. works exactly same as other sort
        Last = frmPlay.WordsLeft
        Swapped = True
        While Swapped = True
            Swapped = False
            index = 1
            While index < Last
                If Int(Len(frmPlay.WordList(index)) > Int(Len(frmPlay.WordList(index + 1)))) Then 'compares length
                    Swap(frmPlay.WordList(index), frmPlay.WordList(index + 1)) 'swaps so ascending by length
                    Swapped = True
                End If
                index = index + 1
            End While
            Last = Last - 1
        End While
    End Sub
    Sub Swap(ByRef A As String, ByRef B As String) 'swaps A and B
        Temp = A
        A = B
        B = Temp
    End Sub
End Module
