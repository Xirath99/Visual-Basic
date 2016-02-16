Dim STudentNumber As Single = 0
    Private Sub studentscores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intColum0Width As Integer
        intColum0Width = Me.Width - haha.Columns(1).Width - haha.Columns(2).Width - 12
        If intColum0Width > 0 Then
            haha.Columns(0).Width = intColum0Width
        End If
    End Sub

    Private Sub BtnScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScores.Click
        'Display dialog box for each entry
        'total todaty, Display diolog box until user enters a despription of entry


        Dim objAddItemForm As New AddStudent
        objAddItemForm.ShowDialog()
        Do Until objAddItemForm.txtName.Text = ""
            Dim LvlTodaysSales As New ListViewItem(objAddItemForm.txtName.Text)

            STudentNumber = 1 + STudentNumber

            LvlTodaysSales.SubItems.Add(Format$(objAddItemForm.Scores.Text))
            haha.Items.Add(LvlTodaysSales)
            objAddItemForm.ShowDialog()


        Loop
    End Sub

    Private Sub BtnAvr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAvr.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalScore As Double = 0
        Dim sngScore As Double = 0
        Dim sngScoreAverage As Single
        Dim strResults As String, strScore As String

        intListCount = Convert.ToInt32(haha.Items.Count)
        For intIndex = 0 To intListCount - 1
            strScore = haha.Items(intIndex).SubItems(1).Text
            sngScore = Convert.ToString(strScore)
            sngTotalScore += strScore
            sngScoreAverage = (sngTotalScore / STudentNumber)

        Next
        strResults = "Total Students: " & (STudentNumber) & ControlChars.NewLine
        strResults &= "Total Average Score: " & Format$(sngScoreAverage) & ControlChars.NewLine
        MessageBox.Show(strResults, "Score Totals")
    End Sub

    Private Sub BtnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClr.Click
        haha.Items.Clear()
    End Sub

    Private Sub haha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles haha.KeyDown
        If e.KeyCode = Keys.Delete And haha.SelectedIndices.Count > 0 Then
            haha.Items.RemoveAt(haha.SelectedIndices(0))
        End If

    End Sub
