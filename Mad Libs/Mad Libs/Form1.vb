Public Class MadLibs

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String 'Hold selected from list boxes

        If listColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a color.")
        ElseIf listEst.SelectedIndex = -1 Then
            MessageBox.Show("No word endingin EST was selected.")
        ElseIf listAnimal.SelectedIndex = -1 Then
            MessageBox.Show("Animals")
        ElseIf listBodyParts.SelectedIndex = -1 Then
            MessageBox.Show("Body Parts")
        ElseIf listNumber.SelectedIndex = -1 Then
            MessageBox.Show("Number")
        ElseIf listnoun.SelectedIndex = -1 Then
            MessageBox.Show("noun")
        ElseIf listPularNoun.SelectedIndex = -1 Then
            MessageBox.Show("Pular Noun")
        End If

        strInput = listColor.SelectedItem.ToString() & " Dragon is the " &
            listEst.SelectedItem.ToString() & " Dragon of all.It has " &
        listAnimal.SelectedItem.ToString() & " shaped like a " & listnoun.SelectedItem.ToString() &
        ". It loves to eat " & listPularNoun.SelectedItem.ToString() & ", although it will feast on nearly anything."

        MessageBox.Show(strInput)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
