Public Class Form1HiWorld

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtEntry.Text = ("password") Then
            MessageBox.Show("Hellow World")
        Else
            MessageBox.Show("Incorrect")
        End If
    End Sub
End Class
