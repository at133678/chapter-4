Public Class Form1

    Private Sub btnCalculateAvrage_Click(sender As Object, e As EventArgs) Handles btnCalculateAvrage.Click
        'Variable to hold scores and the average score'
        Dim Score1 As Double
        Dim Score2 As Double
        Dim Score3 As Double
        Dim Average As Double
        'Constants
        Const NUM_SCORES As Integer = 3
        Const HIGH_SCORE As Double = 95.0
        Try
            'Copy the TextBox scores into the variables.
            Score1 = CDbl(txtScore1.Text)
            Score2 = CDbl(txtScore2.Text)
            Score3 = CDbl(txtScore3.Text)

            'Calculate the average score.
            Average = (Score1 + Score2 + Score3) / NUM_SCORES
            'Display the average, rounded to 2 decimal places. 
            lblResult.Text = Average.ToString("n2")
            'If the score is high, comliment the student the student.
            If Average > HIGH_SCORE Then
                lblMessage.Text = "Congration! Great Job!"
            End If
        Catch ex As Exception
            'Display an error message.
            lblMessage.Text = "lblEnterThreeTestScores mst be numonic."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
