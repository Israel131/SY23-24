Imports System.Security.Cryptography
Imports System.Xml.Schema

Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.InsertDollar()
        Total.Text = CS.Total
        Total.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.InsertQuarter()
        Total.Text = CS.Total
        Total.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.InsertDime()
        Total.Text = CS.Total
        Total.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.InsertNickel()
        Total.Text = CS.Total
        Total.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        Total.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, Dm As Integer, N As Integer) Handles CS.CoinReturnEvent
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If
        If q > 0 Then
            QuarterPictureBox.Visible = True
        Else
            QuarterPictureBox.Visible = False
        End If
        If Dm > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If
        If N > 0 Then
            NickelPictureBox.Visible = True
        Else
            NickelPictureBox.Visible = False
        End If


    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Select Case ID.Text
            Case ProductControl1.ProductID
                ProductControl1.Buy()
                CS.Buy(ProductControl1)
        End Select

        Select Case ID.Text
            Case ProductControl8.ProductID
                ProductControl8.Buy()
                CS.Buy(ProductControl8)
        End Select

        Select Case ID.Text
            Case ProductControl2.ProductID
                ProductControl2.Buy()
                CS.Buy(ProductControl2)
        End Select

        Select Case ID.Text
            Case ProductControl14.ProductID
                ProductControl14.Buy()
                CS.Buy(ProductControl14)
        End Select

        Select Case ID.Text
            Case ProductControl13.ProductID
                ProductControl13.Buy()
                CS.Buy(ProductControl13)
        End Select

        Select Case ID.Text
            Case ProductControl5.ProductID
                ProductControl5.Buy()
                CS.Buy(ProductControl5)
        End Select

        Select Case ID.Text
            Case ProductControl7.ProductID
                ProductControl7.Buy()
                CS.Buy(ProductControl7)
        End Select

        Select Case ID.Text
            Case ProductControl3.ProductID
                ProductControl3.Buy()
                CS.Buy(ProductControl3)
        End Select

        Select Case ID.Text
            Case ProductControl4.ProductID
                ProductControl4.Buy()
                CS.Buy(ProductControl4)
        End Select

        Select Case ID.Text
            Case ProductControl6.ProductID
                ProductControl6.Buy()
                CS.Buy(ProductControl6)
        End Select

        Select Case ID.Text
            Case ProductControl15.ProductID
                ProductControl15.Buy()
                CS.Buy(ProductControl15)
        End Select

        Select Case ID.Text
            Case ProductControl10.ProductID
                ProductControl10.Buy()
                CS.Buy(ProductControl10)
        End Select

        Select Case ID.Text
            Case ProductControl16.ProductID
                ProductControl16.Buy()
                CS.Buy(ProductControl16)
        End Select

        Select Case ID.Text
            Case ProductControl11.ProductID
                ProductControl11.Buy()
                CS.Buy(ProductControl11)
        End Select

        Select Case ID.Text
            Case ProductControl12.ProductID
                ProductControl12.Buy()
                CS.Buy(ProductControl12)
        End Select

        Select Case ID.Text
            Case ProductControl9.ProductID
                ProductControl9.Buy()
                CS.Buy(ProductControl9)
        End Select
        Total.Text = CS.Total.ToString("C2")

    End Sub


    Private Sub C2_Dispense(P As Image) Handles CS.Dispense
        ProductPictureBox.Image = P
    End Sub

    Private Sub ProductControl1_Load(sender As Object, e As EventArgs) Handles ProductControl1.Load

    End Sub
End Class

