 Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtEuros.Text = (NumEuros.Text * TxtUs.Text)
        TxtPounds.Text = (NumPounds.Text * TxtUs.Text)
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        TxtUs.Text = "0"
        NumEuros.Value = 0
        NumPounds.Value = 0
        TxtEuros.Text = "0"
        TxtPounds.Text = "0"
    End Sub
