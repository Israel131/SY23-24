Public Class coinslot

    Public Event Dispense(P As Image)
    Public Event CoinReturnEvent(d As Integer, q As Integer)
    Public Property Quarters As Integer
    Public Property Dollars As Integer
        Dim _total As Decimal
        Public ReadOnly Property Total As Decimal
            Get
            _total = Dollars + Quarters * 0.25
            Return _total
            End Get

        End Property
        Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters)
        Dollars = 0
            Quarters = 0


    End Sub
    Public Sub InsertQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub InsertDollar()
            Dollars = Dollars + 1
        End Sub

End Class
