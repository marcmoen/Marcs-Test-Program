Public Class Form1
    Private Sub MyButton_Click(sender As Object, e As EventArgs) Handles MyButton.Click
        Dim Text As String
        Text = "Blablabla"

        TextBox1.AppendText(Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()

    End Sub
End Class
