Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim BBQBurger As Double = 6.99
        Dim Onuion As Double = 1.0
        Dim Fried As Double = 1.5
        Dim Total As Double
        If radBBQBurger.Checked = True Then
            lblResult.Text = "You seleted BBQ Burger"
        ElseIf radChesseBuger.Checked = True Then
            lblResult.Text = "You selected Chesse Burger"

        End If


    End Sub
End Class
