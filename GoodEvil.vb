 Dim R, L, U, D As Integer
    Dim Score As Integer
    Private Sub frmGoodEvil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        R = True
        L = False
        U = True
        D = False

       

        Me.BackColor = Color.Transparent


        LblGood.Width = 150
        LblGood.Height = 100
        LblGood.Text = ""
        LblGood.BackColor = Color.White

        LblEvil.Width = 200
        LblEvil.Height = 150
        LblEvil.Text = ""
        LblEvil.BackColor = Color.White

       


  

    End Sub

   

    Private Sub tmrMoveGood_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveGood.Tick
        LblGood.Left = CInt(Rnd() * frmGoodEvil.ActiveForm.Width)
        LblGood.Top = CInt(Rnd() * frmGoodEvil.ActiveForm.Height)
    End Sub

    Private Sub tmrMoveEvil_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveEvil.Tick
        LblEvil.Left = CInt(Rnd() * frmGoodEvil.ActiveForm.Width)
        LblEvil.Top = CInt(Rnd() * frmGoodEvil.ActiveForm.Height)
    End Sub

    Private Sub LblGood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblGood.Click
        Score = Score + 1
        LblScore.Text = "Score: " & Score

        If Score = 10 Then
            tmrMoveGood.Enabled = False
            tmrMoveGood.Enabled = False
            MsgBox("WINNER")
        End If
    End Sub

    Private Sub LblEvil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblEvil.Click
        Score = Score - 1
        LblScore.Text = "Score: " & Score

        If Score = -10 Then
            tmrMoveEvil.Enabled = False
            tmrMoveEvil.Enabled = False
            MsgBox("Loser")
        End If
    End Sub
