 'Chapter 4: Automobile Loan Calculator
    'Programmer: Byron Brooks
    'Date: 12/1/15
    'Purpose: to Calulate the monthly payments for a car loan


    Const maxLoanAmmountAllowed As Integer = 25000

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set max value of loan ammount Numeric up and down control
        NumUD1.Maximum = maxLoanAmmountAllowed
    End Sub


    Private Sub BtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalc.Click

        Dim int, adInt, pay, ammount, Loan, Loan2, Credit As Double
        Dim StrError As String

        'interest rate
        If rate.SelectedIndex = 0 Then
            Credit = (Convert.ToDouble(NumUD2.Value) / 100) / 12
        ElseIf rate.SelectedIndex = 1 Then
            Credit = (Convert.ToDouble(NumUD2.Value) / 100) / 12 * 1.1
        ElseIf rate.SelectedIndex = 2 Then
            Credit = (Convert.ToDouble(NumUD2.Value) / 100) / 12 * 1.15
        ElseIf rate.SelectedIndex = 3 Then
            Credit = (Convert.ToDouble(NumUD2.Value) / 100) / 12 * 1.17
        ElseIf rate.SelectedIndex = 4 Then
            Credit = (Convert.ToDouble(NumUD2.Value) / 100) / 12 * 1.25
            NumUD1.Maximum = 5000
        End If


        'Changing Value of pay based on which Button is checked
        If btn3.Checked = True Then
            pay = 36

        ElseIf btn5.Checked = True Then
            pay = 60

        ElseIf btn7.Checked = True Then
            pay = 84

        ElseIf btn10.Checked = True Then
            pay = 120
        End If
        'Tels emloyee to enter value into Credit Rating
        If rate.SelectedIndex = "" Then
            MessageBox.Show("Please enter the customer's credit rating in the credit rating box.", "No Credit Rating")
            rate.Focus()
        End If
        'Calculates Everythin
        ammount = Convert.ToDouble(NumUD1.Value)
        Loan = Pmt(Credit, pay, -ammount)
        txtPay.Text = Format$(Loan, "Currency")
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        'resets values to a default setting

        txtPay.Text = "0.00"
        rate.SelectedIndex = 0
        NumUD2.Value = 5.0
        NumUD1.Value = 0.0
        btn3.Checked = False
        btn5.Checked = False
        btn7.Checked = False
        btn10.Checked = False
    End Sub
