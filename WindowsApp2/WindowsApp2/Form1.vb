Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Spin1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub spin()
        'generate a  random number
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        ID.Text = r

        'show a picture from picture list
        PictureBox1.Image = ImageList1.Images(r)
        'show a picture from picture list
        PictureBox2.Image = ImageList2.Images(r)
        'show a picture from picture list
        PictureBox3.Image = ImageList3.Images(r)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spin()
    End Sub



End Class
