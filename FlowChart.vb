 Dim score As Integer = 0
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Text1.Text = " "
        score = 0
        LblScore.Text = " " 'Clears Score
        BtnY1.Checked = False 'This and all below clear the buttons checks
        BtnY2.Checked = False
        BtnY3.Checked = False
        BtnN1.Checked = False
        BtnN2.Checked = False
        BtnN3.Checked = False


    End Sub

    Private Sub BtnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheck.Click
        If Text1.Text < 20 Then
            score = score + 1
        ElseIf Text1.Text > 19 And Text1.Text < 30 Then
            score = score + 2
        Else
            score = score + 3
        End If

        LblScore.Text = CStr(score)

        If BtnY1.Checked = True Then
            score = score + 4
        End If
        LblScore.Text = CStr(score)
        If BtnY2.Checked = True Then
            score = score + 2
        End If
        LblScore.Text = CStr(score)
        If BtnY3.Checked = True Then
            score = score + 1
        End If
        LblScore.Text = CStr(score)
        


    End Sub
