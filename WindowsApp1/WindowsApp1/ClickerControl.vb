Public Class ClickerControl
    Dim C As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C.click()
        TextBox1.Text = C.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C.reset()
        TextBox1.Text = C.count
    End Sub

End Class