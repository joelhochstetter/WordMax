Module mdlHighScores
    Dim FolderPath As String = My.Application.Info.DirectoryPath & "\WordMaxHighScores\"
    Dim filepath As String
    Public Sub ReadHighScoresFile()
        If Not System.IO.Directory.Exists(FolderPath) = True Then 'if the folder doesn't exist then it creates it
            System.IO.Directory.CreateDirectory(FolderPath)
        End If
        filepath = FolderPath & "ClassicHighScores.txt"
        Dim FileClassic As Integer = FreeFile()
        If Not System.IO.File.Exists(filepath) = True Then 'if the file doesn't exist then it creates it
            System.IO.File.Create(filepath).Dispose()
            'makes sure the file has contents so that it doesn't cause an error when the program tries to read from the file
            FileOpen(FileClassic, filepath, OpenMode.Output)
            For line = 0 To 9
                PrintLine(FileClassic, "0")
            Next
            FileClose(FileClassic)
        End If
        FileOpen(FileClassic, filepath, OpenMode.Input)
        For index = 0 To 9
            frmHome.ClassicHighScore(index + 1) = LineInput(FileClassic)
        Next
        FileClose(FileClassic)
        filepath = FolderPath & "ClassicHighScoresName.txt" 'process repeats for other arrays
        Dim FileClassicName As Integer = FreeFile()
        If Not System.IO.File.Exists(filepath) = True Then 'if the file doesn't exist then it creates it
            System.IO.File.Create(filepath).Dispose()
            'makes sure the file has contents so that it doesn't cause an error when the program tries to read from the file
            FileOpen(FileClassicName, filepath, OpenMode.Output)
            For line = 0 To 9
                PrintLine(FileClassicName, "")
            Next
            FileClose(FileClassicName)
        End If
        FileOpen(FileClassicName, filepath, OpenMode.Input)
        For index = 0 To 9
            frmHome.ClassicHighScoreName(index + 1) = LineInput(FileClassicName)
        Next
        FileClose(FileClassicName)
        filepath = FolderPath & "BTCHighScores.txt"
        Dim FileBTC As Integer = FreeFile()
        If Not System.IO.File.Exists(filepath) = True Then 'if the file doesn't exist then it creates it
            System.IO.File.Create(filepath).Dispose()
            'makes sure the file has contents so that it doesn't cause an error when the program tries to read from the file
            FileOpen(FileBTC, filepath, OpenMode.Output)
            For line = 0 To 9
                PrintLine(FileBTC, "0")
            Next
            FileClose(FileBTC)
        End If
        FileOpen(FileBTC, filepath, OpenMode.Input)
        For index = 0 To 9
            frmHome.BTCHighScore(index + 1) = LineInput(FileBTC)
        Next
        FileClose(FileBTC)
        filepath = FolderPath & "BTCHighScoresName.txt" 'process repeats for other arrays
        Dim FileBTCName As Integer = FreeFile()
        If Not System.IO.File.Exists(filepath) = True Then 'if the file doesn't exist then it creates it
            System.IO.File.Create(filepath).Dispose()
            'makes sure the file has contents so that it doesn't cause an error when the program tries to read from the file
            FileOpen(FileBTCName, filepath, OpenMode.Output)
            For line = 0 To 9
                PrintLine(FileBTCName, "")
            Next
            FileClose(FileBTCName)
        End If
        FileOpen(FileBTCName, filepath, OpenMode.Input)
        For index = 0 To 9
            frmHome.BTCHighScoreName(index + 1) = LineInput(FileBTCName)
        Next
        FileClose(FileBTCName)
    End Sub
    Public Sub WriteHighScoresFile(ByVal GameMode As Integer)
        If GameMode = 0 Then
            Dim FileClassic As Integer = FreeFile()
            filepath = FolderPath & "ClassicHighScores.txt"
            FileOpen(FileClassic, filepath, OpenMode.Output)
            For index = 0 To 9
                PrintLine(FileClassic, frmHome.ClassicHighScore(index + 1))
            Next
            FileClose(FileClassic)
            filepath = FolderPath & "ClassicHighScoresName.txt" 'process repeats for other arrays
            Dim FileClassicName As Integer = FreeFile()
            FileOpen(FileClassicName, filepath, OpenMode.Output)
            For index = 0 To 9
                PrintLine(FileClassicName, frmHome.ClassicHighScoreName(index + 1))
            Next
            FileClose(FileClassicName)
        Else
            filepath = FolderPath & "BTCHighScores.txt" 'process repeats for other arrays
            Dim FileBTC As Integer = FreeFile()
            FileOpen(FileBTC, filepath, OpenMode.Output)
            For index = 0 To 9
                PrintLine(FileBTC, frmHome.BTCHighScore(index + 1))
            Next
            FileClose(FileBTC)
            filepath = FolderPath & "BTCHighScoresName.txt" 'process repeats for other arrays
            Dim FileBTCName As Integer = FreeFile()
            FileOpen(FileBTCName, filepath, OpenMode.Output)
            For index = 0 To 9
                PrintLine(FileBTCName, frmHome.BTCHighScoreName(index + 1))
            Next
            FileClose(FileBTCName)
        End If
    End Sub
End Module
