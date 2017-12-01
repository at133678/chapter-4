Public Class AgeInsultGenerator

    Private Sub AgeInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Double

        Try
            intAge = txtUserAgeInput.Text

            If intAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf intAge <= 14 And intAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            ElseIf intAge <= 18 And intAge < 24 Then
                lblResult.Text = "You are getting older"

            ElseIf intAge <= 24 And intAge < 30 Then
                lblResult.Text = "You have a job that is good paying"
            ElseIf intAge <= 30 And intAge < 40 Then
                lblResult.Text = "You know how to do your job 100%"
            ElseIf intAge <= 40 And intAge <= 70 Then
                lblResult.Text = "You are walking away from Earth"
            ElseIf intAge <= 70 And intAge < 80 Then
                lblResult.Text = "In Death's yard and at Death's door"
            End If
        Catch ex As Exception

        End Try

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserAgeInput.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
