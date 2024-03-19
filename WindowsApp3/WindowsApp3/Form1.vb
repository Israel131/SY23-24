Public Class Form1
    Dim Cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled


    End Sub
    Public Sub spin()
        'generate a  random number
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        Label1.Text = r

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DollarB.Click
        Cs.InsertDollar()
        Label2.Text = Cs.Total
        Label2.Text = Cs.Total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles QuarterB.Click
        Cs.InsertQuarter()
        Label2.Text = Cs.Total
        Label2.Text = Cs.Total.ToString("C2")
    End Sub
End Class
