Public Class Form1
    Dim C As New Clicker
    Dim C2 As New Clicker
    Dim C3 As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C.increment = NumericUpDown1.Value
        C.click()
        TextBox1.Text = C.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C.reset()
        TextBox1.Text = C.count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        C2.increment = NumericUpDown2.Value
        C2.click()
        TextBox3.Text = C2.count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        C2.reset()
        TextBox3.Text = C2.count
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        C3.increment = NumericUpDown3.Value
        C3.click()
        TextBox2.Text = C3.count

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        C3.reset()
        TextBox2.Text = C3.count
    End Sub
End Class
