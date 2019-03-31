Module mdlExtraFunctions
    Public Function StripP(Text As String) As String
        'Strips all punctuation from a string.
        Dim TxtLen, CheckChr, Counter As Long

        Counter = 0
        TxtLen = Len(Text)

        Do While Counter < TxtLen
            Counter = Counter + 1
            CheckChr = Asc(Mid(Text, Counter, 1))
            Select Case CheckChr
                Case 32, 48 To 57, 65 To 90, 95, 97 To 122
                    'Do Nothing
                Case Else
                    Text = Microsoft.VisualBasic.Left(Text, Counter - 1) & Microsoft.VisualBasic.Right(Text, TxtLen - Counter)
                    TxtLen = Len(Text)
                    Counter = Counter - 1
            End Select
        Loop
        StripP = UCase(Text)
    End Function
End Module
