Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intStartIndex As Integer
        Dim intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txttoFind.Text.Length > 0 Then
                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txttoFind.Text, intStartIndex)
            End If
            If intFoundIndex = lblString.Text Then
            End If
        End If
    End Sub
End Class
