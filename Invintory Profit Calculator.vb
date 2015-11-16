 Private Sub Calculate()
        Items = NumUD1.Value
        Unit = NumUD2.Value
        Cost = Items * Unit
        Margin = BtnMar.Value / 100
        SellPrice = NumUD2.Value / (1 - Margin)
        Value = SellPrice * Items
        Profit = Value - Cost
        TxtCost.Text = Format(Cost, "Currency")
        TxtValue.Text = Format(Value, "Currency")
        TxtSell.Text = Format(SellPrice, "Currency")
        TxtProfit.Text = Format(Profit, "Currency")
    End Sub

    Private Sub TrBrMargin_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMar.Scroll
        Margin = BtnMar.Value
        LblActual.Text = (Margin & "%")
        Calculate()
    End Sub

    Private Sub NumItems_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumUD1.ValueChanged
        Calculate()
    End Sub

    Private Sub NumUnit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumUD2.ValueChanged
        Calculate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnMar.Value = 30
        Margin = BtnMar.Value
        LblActual.Text = (Margin & "%")

    End Sub
