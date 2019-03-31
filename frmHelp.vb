Public Class frmHelp
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        btnGeneral.Enabled = True
        btnHowToPlay.Enabled = False
        btnScoring.Enabled = True
        PictureBox.Visible = True
        btnHowToPlay.Enabled = False
    End Sub

    Private Sub btnScoring_Click(sender As Object, e As EventArgs) Handles btnScoring.Click
        btnHowToPlay.Enabled = True
        btnGeneral.Enabled = True
        PictureBox.Visible = False
        btnScoring.Enabled = False
        'sets text
        lblHelp.Text = "Scoring:" & vbNewLine & "- 10 points per word" & vbNewLine & "- 1 extra point per letter" & vbNewLine & "- 1 extra point if A, E, I, O or U overlap between two words" & vbNewLine & "- 3 extra points if B, C, D, F, G or H overlap between two words" & vbNewLine & "- 5 extra points if J, K, L, M, N or P overlap between two words" & vbNewLine & "- 7 extra points if Q, R, S, T, V or W overlap between two words" & vbNewLine & "- 9 extra points if X, Y or Z overlap between two words"
    End Sub

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        PictureBox.Visible = False
        btnGeneral.Enabled = False
        btnHowToPlay.Enabled = True
        btnScoring.Enabled = True
        'sets text
        lblHelp.Text = "In 'Classic' you play until there is no more space to place words or you want to stop." & vbNewLine & "'Beat The Clock' provides the intensity of a time limit with the same game play." & vbNewLine & "For each gamemode you can select between an Animals and a Computing word list." & vbNewLine & "To end the game early in either game mode press quit. Don't worry you will still get your high score." & vbNewLine & "Click How To Play to learn the basics of game play or consult our user manual." & vbNewLine & "Enjoy!"
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGeneral.Enabled = False
        btnHowToPlay.Enabled = True
        btnScoring.Enabled = True
        lblHelp.Text = "In 'Classic' you play until there is no more space to place words or you want to stop." & vbNewLine & "'Beat The Clock' provides the intensity of a time limit with the same game play." & vbNewLine & "For each gamemode you can select between an Animals and a Computing word list." & vbNewLine & "To end the game early in either game mode press quit. Don't worry you will still get your high score." & vbNewLine & "Click How To Play to learn the basics of game play or consult our user manual." & vbNewLine & "Enjoy!"
    End Sub
End Class