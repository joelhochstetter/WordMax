Public Class frmHighScores
    Private Sub frmHighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the boxes displaying highscores are list boxes and the following adds the name of the user followed by their score for highscores
        For index = 1 To 10
            listClassicHighScores.Items.Add(index & ". " & frmHome.ClassicHighScoreName(index) & " " & frmHome.ClassicHighScore(index))
            listBTCHighScores.Items.Add(index & ". " & frmHome.BTCHighScoreName(index) & " " & frmHome.BTCHighScore(index))
        Next
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmHome.Show()
    End Sub
End Class