
Imports System.IO

Public Class Form1
    Dim records(50) As String
    Dim current As Integer
    Dim count As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        F1.Text = ""
        F2.Text = ""
        F3.Text = ""
        F4.Text = ""
        F5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("Data.txt")
        outFile.Write(F1.Text)
        outFile.Write("|")
        outFile.Write(F2.Text)
        outFile.Write("|")
        outFile.Write(F3.Text)
        outFile.Write("|")
        outFile.Write(F4.Text)
        outFile.Write("|")
        outFile.Write(F5.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog2.ShowDialog()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While Not inFile.EndOfStream
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            Showrecords(0)
        End If
    End Sub
    Sub Showrecords(index As Integer)
        If records(index) <> Nothing Then
            Dim Fields() As String
            Fields = records(index).Split("|")
            F1.Text = Fields(0)
            F2.Text = Fields(1)
            F3.Text = Fields(2)
            F4.Text = Fields(3)
            F5.Text = Fields(4)
            If File.Exists(Fields(5)) Then
                PictureBox1.Load(Fields(5))
            End If
        End If
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        current = 0
        Showrecords(current)
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        current = count - 1
        Showrecords(current)
    End Sub
    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        SaveToFile()
        If current > 0 Then
            current = current - 1
        End If
        ShowRecord(current)
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        SaveToFile()
        If current < count - 1 Then
            current = current + 1
        End If
        ShowRecord(current)
    End Sub
    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        SaveToFile()
        If count > 0 Then
            current = count - 1
            ShowRecord(current)
        End If
    End Sub
    Sub SaveToFile()
        Dim r As String
        r += F1.Text
        r += "|"
        r += F2.Text
        r += "|"
        r += F3.Text
        r += "|"
        r += F4.Text
        r += "|"
        r += F5.Text
        r += "|"
        r += PictureBox1.ImageLocation
        If count = 0 Then count = 1
        records(current) = r
    End Sub
    Public Sub ShowRecord(index As Integer)
        PictureBox1.Image = Nothing
        If records(index) <> Nothing Then
            Dim Fields() As String
            Fields = records(index).Split("|")
            F1.Text = Fields(0)
            F2.Text = Fields(1)
            F3.Text = Fields(2)
            F4.Text = Fields(3)
            F5.Text = Fields(4)
            If File.Exists(Fields(5)) Then
                PictureBox1.Load(Fields(5))
            End If
        End If
    End Sub
    Private Sub OpenFileDialog2_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        PictureBox1.Load(OpenFileDialog2.FileName)
    End Sub
End Class