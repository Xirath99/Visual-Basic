Dim user As Integer
    Dim UserCount As Integer = 0

   
    Private Sub btnUP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUP.Click

        UserCount = UserCount + 1
        LblCount.Text = UserCount

        user = Val(TxtBx.Text)
        If user = 75 Then

            LblPass.Visible = True

        ElseIf user > 0 And user <= 25 Then
            LblFail.Text = "you guess is way too low"
            LblFail.Visible = True
        ElseIf user > 75 And user <= 80 Then
            LblFail.Text = " Your Guess is too high but close"
            LblFail.Visible = True
        ElseIf user >= 25 And user <= 50 Then
            LblFail.Text = "Your Guess is to low"
            LblFail.Visible = True
        ElseIf user > 50 And user <= 75 Then
            LblFail.Text = "Your Guess is to low but close"
            LblFail.Visible = True
        ElseIf user > 80 And user < 101 Then
            LblFail.Text = " Your Guess is too high "
            LblFail.Visible = True
        End If
      

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBx.Text = ""
        LblPass.Visible = False
        LblFail.Visible = False
    End Sub

    Private Sub btnThink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThink.Click
        TxtBx.Text = ""
        LblPass.Visible = False
        LblFail.Visible = False
        If user = 75 Then
            LblCount.Text = 0
            UserCount = 0
        End If

       



    End Sub


End Class
