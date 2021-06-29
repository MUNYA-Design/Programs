' GuessingGame

' Coded by
'   __  __        _   _        _  _       __   __       ___
'  |  \/  |      | | | |      | \| |      \ \ / /      /   \
'  | |\/| |      | |_| |      | .  |       \   /       | - |
'  |_|  |_|       \___/       |_|\_|        |_|        |_|_|
'  MUNYA

Public Class GuessingGame

    Dim dBalance As Double = 1000

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        If (Len(txtGuess.Text) <> 0) Then
            If (dBalance > 0) And Not (dBalance >= 2500) Then
                ' Program generates random number
                Dim iRandom As Integer = Int((10 * Rnd()) + 1)

                ' Ask for an input (guess)
                Dim iUserGuess As Integer = txtGuess.Text

                ' Check if its correct or not | Return, do calculations
                If (iRandom = iUserGuess) Then
                    lblGuess.Text = "Your guess was right"
                    dBalance += 100
                    lblStart.Text = "You have " & dBalance
                ElseIf Not (iRandom = iUserGuess) Then
                    lblGuess.Text = "Your guess was wrong"
                    dBalance -= 100
                    lblStart.Text = "You have " & dBalance
                End If
            ElseIf (dBalance = 0) Then 'If the balance is zero
                lblStart.Text = "Go home, your money is finish. R00.00"
                lblGuess.Text = "Click 'Restart' to play again."
            ElseIf (dBalance >= 2500) Then 'If the balance is maxed 
                lblStart.Text = "Go home, your blance is maxed. R" & dBalance
                lblGuess.Text = "Click 'Restart' to play again."
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        dBalance = 1000
        txtGuess.Clear()
        lblStart.Text = "You have " & dBalance
        lblGuess.Text = "Your guess..."
    End Sub


End Class
