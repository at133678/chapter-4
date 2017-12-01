Public Class Password

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Correctpassword.Text = ("Andrew Talken") Then

        Else
            Correctpassword.Text = "Incorrect"

        End If
    End Sub
End Class
