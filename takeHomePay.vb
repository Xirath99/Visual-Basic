'Programer:Byron Brooks
    '5 November 2015
    'Take Home calculator
    'purpose: To tell the user their expected take  home salary after insurance and contribution%
   
    Private Sub calculateTakeHomePay()
        Dim dblSocial, dblFed, dblState, dblMedicare, dblWeeklyPay As Double
        Dim dblRetirement, dblInsurance, dblTakeHomePay As Double

        'Dividing the Yearly Summary to 52 Weeks
        dblWeeklyPay = Convert.ToDouble(NumericUpDown1.Value) / 52

        'Calculating Government Deductions
        dblSocial = dblWeeklyPay * 0.082
        dblFed = dblWeeklyPay * 0.18
        dblState = dblWeeklyPay * 0.05
        dblMedicare = dblWeeklyPay * 0.0145

        'Converting Track Bar Value to Percentage 
        dblRetirement = dblWeeklyPay * (TrackBar1.Value / 100)

        'Changing Value of dbInsurance based on which Button is checked
        If btnNone.Checked = True Then
            dblInsurance = 0

        ElseIf BtnIn.Checked = True Then
            dblInsurance = 20.0

        ElseIf BtnFam.Checked = True Then
            dblInsurance = 30.0

        End If

        'Subtract all to get Weely Take Home Pay Estimate
        dblTakeHomePay = dblWeeklyPay - dblSocial - dblFed - dblState - dblMedicare - dblRetirement - dblInsurance

        LblEarn.Text = Format(dblTakeHomePay, "Currency")

    End Sub

    Private Sub btnFamily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFam.CheckedChanged
        calculateTakeHomePay()
    End Sub
    Private Sub btnIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIn.CheckedChanged
        calculateTakeHomePay()
    End Sub
    Private Sub btnNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNone.CheckedChanged
        calculateTakeHomePay()
    End Sub

    Private Sub TrBrRetirement_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        calculateTakeHomePay()
    End Sub

    Private Sub NumYearlySalary_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        calculateTakeHomePay()
    End Sub
