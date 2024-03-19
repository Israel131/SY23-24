Public Class CoinSlot
    Public Event Dispense(P As Image)
    Public Event CoinReturnEvent(d As Integer, q As Integer, Dm As Integer, N As Integer)
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.05
            Return _total
        End Get

    End Property
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Dimes, Nickels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickels = 0

    End Sub
    Public Sub InsertQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub InsertNickel()
        Nickels = Nickels + 1
    End Sub
    Public Sub InsertDime()
        Dimes = Dimes + 1
    End Sub
    Public Sub InsertDollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub Buy(p As ProductControl)
        If p.Count > 0 And Total > p.Price Then
            p.Buy()
            _total = _total - p.Price
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickels = _total / 0.05
            RaiseEvent Dispense(p.Picture)
        End If
    End Sub
End Class
