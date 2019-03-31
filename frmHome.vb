Public Class frmHome
    Public Gamemode As Integer '0 is for classic. 1 is for beat the cloch
    Public WListAnimals(10, 15) As String
    Public WListComputing(10, 15) As String
    Public BTCHighScore(10) As Integer
    Public BTCHighScoreName(10) As String 'the index number corresponds with the score
    Public ClassicHighScore(10) As Integer
    Public ClassicHighScoreName(10) As String
    Public SelectedWordList As String
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        btnPlay.Hide()
        btnClassic.Show()
        btnBeatClock.Show()
    End Sub
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlay.Show()
        btnClassic.Hide()
        btnBeatClock.Hide()
        Call ReadHighScoresFile() 'updates the highscores in game to match what is stored in the file
        ' the following defines all the wordslists.
        For length = 7 To 10 'because there is not 15 words for each length
            For index = 4 To 15
                WListAnimals(length, index) = ""
                WListComputing(length, index) = ""
            Next
        Next
        WListAnimals(3, 1) = "APE"
        WListAnimals(3, 2) = "ASS"
        WListAnimals(3, 3) = "BAT"
        WListAnimals(3, 4) = "CAT"
        WListAnimals(3, 5) = "COW"
        WListAnimals(3, 6) = "DOG"
        WListAnimals(3, 7) = "EWE"
        WListAnimals(3, 8) = "FOX"
        WListAnimals(3, 9) = "MAN"
        WListAnimals(3, 10) = "PIG"
        WListAnimals(3, 11) = "RAM"
        WListAnimals(3, 12) = "YAK"
        WListAnimals(3, 13) = "RAT"
        WListAnimals(3, 14) = "TOD"
        WListAnimals(3, 15) = "SOW"
        WListAnimals(4, 1) = "BEAR"
        WListAnimals(4, 2) = "BOAR"
        WListAnimals(4, 3) = "BUCK"
        WListAnimals(4, 4) = "BULL"
        WListAnimals(4, 5) = "COLT"
        WListAnimals(4, 6) = "DEER"
        WListAnimals(4, 7) = "FAWN"
        WListAnimals(4, 8) = "GOAT"
        WListAnimals(4, 9) = "HARE"
        WListAnimals(4, 10) = "LION"
        WListAnimals(4, 11) = "MULE"
        WListAnimals(4, 12) = "MOLE"
        WListAnimals(4, 13) = "SEAL"
        WListAnimals(4, 14) = "PUMA"
        WListAnimals(4, 15) = "WOLF"
        WListAnimals(5, 1) = "BISON"
        WListAnimals(5, 2) = "CAMEL"
        WListAnimals(5, 3) = "DINGO"
        WListAnimals(5, 4) = "HIPPO"
        WListAnimals(5, 5) = "HYENA"
        WListAnimals(5, 6) = "KOALA"
        WListAnimals(5, 7) = "LEMUR"
        WListAnimals(5, 8) = "LLAMA"
        WListAnimals(5, 9) = "MOOSE"
        WListAnimals(5, 10) = "PANDA"
        WListAnimals(5, 11) = "RHINO"
        WListAnimals(5, 12) = "SHEEP"
        WListAnimals(5, 13) = "SLOTH"
        WListAnimals(5, 14) = "WHALE"
        WListAnimals(5, 15) = "ZEBRA"
        WListAnimals(6, 1) = "ALPACA"
        WListAnimals(6, 2) = "BABOON"
        WListAnimals(6, 3) = "BADGER"
        WListAnimals(6, 4) = "BEAVER"
        WListAnimals(6, 5) = "COUGAR"
        WListAnimals(6, 6) = "COYOTE"
        WListAnimals(6, 7) = "DONKEY"
        WListAnimals(6, 8) = "GIBBON"
        WListAnimals(6, 9) = "JAGUAR"
        WListAnimals(6, 10) = "MONKEY"
        WListAnimals(6, 11) = "POSSUM"
        WListAnimals(6, 12) = "RABBIT"
        WListAnimals(6, 13) = "TURTLE"
        WListAnimals(6, 14) = "WALRUS"
        WListAnimals(6, 15) = "WOMBAT"
        WListAnimals(7, 1) = "BANTENG"
        WListAnimals(7, 2) = "BUFFALO"
        WListAnimals(7, 3) = "CHEETAH"
        WListAnimals(7, 4) = "DOLPHIN"
        WListAnimals(7, 5) = "GAZELLE"
        WListAnimals(7, 6) = "GIRAFFE"
        WListAnimals(7, 7) = "GORILLA"
        WListAnimals(7, 8) = "LEOPARD"
        WListAnimals(7, 9) = "MAMMOTH"
        WListAnimals(7, 10) = "MEERKAT"
        WListAnimals(7, 11) = "PANTHER"
        WListAnimals(7, 12) = "RACCOON"
        WListAnimals(7, 13) = "WALLABY"
        WListAnimals(8, 1) = "AARDVARK"
        WListAnimals(8, 2) = "CHIPMUNK"
        WListAnimals(8, 3) = "ELEPHANT"
        WListAnimals(8, 4) = "KANGAROO"
        WListAnimals(8, 5) = "MONGOOSE"
        WListAnimals(8, 6) = "PLATYPUS"
        WListAnimals(8, 7) = "REINDEER"
        WListAnimals(8, 8) = "RINGTAIL"
        WListAnimals(8, 9) = "SQUIRREL"
        WListAnimals(9, 1) = "ARMADILLO"
        WListAnimals(9, 2) = "BANDICOOT"
        WListAnimals(9, 3) = "GUINEAPIG"
        WListAnimals(9, 4) = "ORANGUTAN"
        WListAnimals(9, 5) = "POLARBEAR"
        WListAnimals(9, 6) = "SPRINGBOK"
        WListAnimals(9, 7) = "WOLVERINE"
        WListAnimals(10, 1) = "CHIMPANZEE"
        WListAnimals(10, 2) = "RHINOCEROS"
        WListAnimals(10, 3) = "WILDEBEAST"
        WListComputing(3, 1) = "ALT"
        WListComputing(3, 2) = "BIT"
        WListComputing(3, 3) = "BUS"
        WListComputing(3, 4) = "CAD"
        WListComputing(3, 5) = "CPU"
        WListComputing(3, 6) = "DOS"
        WListComputing(3, 7) = "FTP"
        WListComputing(3, 8) = "GIF"
        WListComputing(3, 9) = "GUI"
        WListComputing(3, 10) = "ISP"
        WListComputing(3, 11) = "MAC"
        WListComputing(3, 12) = "RAM"
        WListComputing(3, 13) = "ROM"
        WListComputing(3, 14) = "SQL"
        WListComputing(3, 15) = "WEB"
        WListComputing(4, 1) = "BETA"
        WListComputing(4, 2) = "BYTE"
        WListComputing(4, 3) = "CHIP"
        WListComputing(4, 4) = "CODE"
        WListComputing(4, 5) = "DATA"
        WListComputing(4, 6) = "DISC"
        WListComputing(4, 7) = "FILE"
        WListComputing(4, 8) = "GATE"
        WListComputing(4, 9) = "ICON"
        WListComputing(4, 10) = "LINK"
        WListComputing(4, 11) = "LOOP"
        WListComputing(4, 12) = "MENU"
        WListComputing(4, 13) = "SAVE"
        WListComputing(4, 14) = "SORT"
        WListComputing(4, 15) = "WIFI"
        WListComputing(5, 1) = "ABORT"
        WListComputing(5, 2) = "ADDON"
        WListComputing(5, 3) = "ASCII"
        WListComputing(5, 4) = "BASIC"
        WListComputing(5, 5) = "CDROM"
        WListComputing(5, 6) = "CLICK"
        WListComputing(5, 7) = "CRASH"
        WListComputing(5, 8) = "DEBUG"
        WListComputing(5, 9) = "FIELD"
        WListComputing(5, 10) = "INPUT"
        WListComputing(5, 11) = "LOGIN"
        WListComputing(5, 12) = "PIXEL"
        WListComputing(5, 13) = "QUERY"
        WListComputing(5, 14) = "TABLE"
        WListComputing(5, 15) = "VIRUS"
        WListComputing(6, 1) = "BINARY"
        WListComputing(6, 2) = "DECODE"
        WListComputing(6, 3) = "EXPORT"
        WListComputing(6, 4) = "FORMAT"
        WListComputing(6, 5) = "GOOGLE"
        WListComputing(6, 6) = "LINKER"
        WListComputing(6, 7) = "LOGOFF"
        WListComputing(6, 8) = "MEMORY"
        WListComputing(6, 9) = "PACKET"
        WListComputing(6, 10) = "PASCAL"
        WListComputing(6, 11) = "PROLOG"
        WListComputing(6, 12) = "RECORD"
        WListComputing(6, 13) = "SEARCH"
        WListComputing(6, 14) = "SCROLL"
        WListComputing(6, 15) = "UPLOAD"
        WListComputing(7, 1) = "ARCHIVE"
        WListComputing(7, 2) = "BROWSER"
        WListComputing(7, 3) = "CIRCUIT"
        WListComputing(7, 4) = "COMMAND"
        WListComputing(7, 5) = "COMPILE"
        WListComputing(7, 6) = "DESKTOP"
        WListComputing(7, 7) = "INSTALL"
        WListComputing(7, 8) = "MALWARE"
        WListComputing(7, 9) = "PRINTER"
        WListComputing(7, 10) = "PROGRAM"
        WListComputing(7, 11) = "STORAGE"
        WListComputing(7, 12) = "WEBSITE"
        WListComputing(7, 13) = "WINDOWS"
        WListComputing(8, 1) = "ALIASING"
        WListComputing(8, 2) = "COMPILER"
        WListComputing(8, 3) = "DATABASE"
        WListComputing(8, 4) = "DOWNLOAD"
        WListComputing(8, 5) = "FREEWARE"
        WListComputing(8, 6) = "HARDWARE"
        WListComputing(8, 7) = "INTERNET"
        WListComputing(8, 8) = "REGISTRY"
        WListComputing(8, 9) = "SOFTWARE"
        WListComputing(9, 1) = "ALGORITHM"
        WListComputing(9, 2) = "CHARACTER"
        WListComputing(9, 3) = "DECOMPILE"
        WListComputing(9, 4) = "DEVELOPER"
        WListComputing(9, 5) = "HARDDRIVE"
        WListComputing(9, 6) = "INTERFACE"
        WListComputing(9, 7) = "PROCESSOR"
        WListComputing(10, 1) = "CONNECTION"
        WListComputing(10, 2) = "PROGRAMMER"
        WListComputing(10, 3) = "SOURCECODE"
    End Sub

    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        Gamemode = 0 'means that it is in classic mode
        frmPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnBeatClock_Click(sender As Object, e As EventArgs) Handles btnBeatClock.Click
        Gamemode = 1 'means that it is in beat the clock mode
        frmPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub
    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        frmHighScores.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
