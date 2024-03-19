Public Class Form1
    Dim moveSpeed As Integer = -15
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()

        End Select
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()

        End Select
    End Sub
    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        PicPlayer.Left += moveSpeed
    End Sub
End Class
