Public Class WeeklyPay
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lstTodaysSales As System.Windows.Forms.ListView
    Friend WithEvents BtnData As System.Windows.Forms.Button
    Friend WithEvents BtnClr As System.Windows.Forms.Button
    Friend WithEvents BtnTotal As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstTodaysSales = New System.Windows.Forms.ListView
        Me.BtnData = New System.Windows.Forms.Button
        Me.BtnTotal = New System.Windows.Forms.Button
        Me.BtnClr = New System.Windows.Forms.Button
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lstTodaysSales
        '
        Me.lstTodaysSales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstTodaysSales.Location = New System.Drawing.Point(8, 0)
        Me.lstTodaysSales.Name = "lstTodaysSales"
        Me.lstTodaysSales.Size = New System.Drawing.Size(552, 392)
        Me.lstTodaysSales.TabIndex = 0
        Me.lstTodaysSales.View = System.Windows.Forms.View.Details
        '
        'BtnData
        '
        Me.BtnData.Location = New System.Drawing.Point(568, 16)
        Me.BtnData.Name = "BtnData"
        Me.BtnData.Size = New System.Drawing.Size(136, 48)
        Me.BtnData.TabIndex = 1
        Me.BtnData.Text = "Enter Infromation"
        '
        'BtnTotal
        '
        Me.BtnTotal.Location = New System.Drawing.Point(568, 88)
        Me.BtnTotal.Name = "BtnTotal"
        Me.BtnTotal.Size = New System.Drawing.Size(144, 48)
        Me.BtnTotal.TabIndex = 2
        Me.BtnTotal.Text = "Check Totals"
        '
        'BtnClr
        '
        Me.BtnClr.Location = New System.Drawing.Point(568, 160)
        Me.BtnClr.Name = "BtnClr"
        Me.BtnClr.Size = New System.Drawing.Size(144, 56)
        Me.BtnClr.TabIndex = 3
        Me.BtnClr.Text = "Clear Data"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 174
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Hours"
        Me.ColumnHeader2.Width = 189
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Rate"
        Me.ColumnHeader3.Width = 185
        '
        'WeeklyPay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 402)
        Me.Controls.Add(Me.BtnClr)
        Me.Controls.Add(Me.BtnTotal)
        Me.Controls.Add(Me.BtnData)
        Me.Controls.Add(Me.lstTodaysSales)
        Me.Name = "WeeklyPay"
        Me.Text = "WeeklyPay"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub WeeklyPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim intColum0Width As Integer
        intColum0Width = Me.Width - lstTodaysSales.Columns(1).Width - lstTodaysSales.Columns(2).Width - 12
        If intColum0Width > 0 Then
            lstTodaysSales.Columns(0).Width = intColum0Width
        End If
    End Sub

    Private Sub BtnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnData.Click
        'Display dialog box for each entry
        'total todaty, Display diolog box until user enters a despription of entry
        Dim objAddItemForm As New AddEmpluye
        objAddItemForm.ShowDialog()
        Do Until objAddItemForm.txtName.Text = ""
            Dim LvlTodaysSales As New ListViewItem(objAddItemForm.txtName.Text)


            LvlTodaysSales.SubItems.Add((objAddItemForm.NudHour.Value))
            LvlTodaysSales.SubItems.Add(Format$(objAddItemForm.txtRate.Text, "Currency"))
            lstTodaysSales.Items.Add(LvlTodaysSales)
            objAddItemForm.ShowDialog()


        Loop




    End Sub
    Private Sub lstTodaysSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstTodaysSales.KeyDown
        If e.KeyCode = Keys.Delete And lstTodaysSales.SelectedIndices.Count > 0 Then
            lstTodaysSales.Items.RemoveAt(lstTodaysSales.SelectedIndices(0))

        End If
    End Sub

    Private Sub BtnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotal.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalSales As Single = 0
        Dim sngTotalWorkerPay As Single = 0
        Dim strPayRate As Single
        Dim sngHours As Single
        Dim strResults As String, strHours As String

        intListCount = Convert.ToInt32(lstTodaysSales.Items.Count)
        For intIndex = 0 To intListCount - 1
            strHours = lstTodaysSales.Items(intIndex).SubItems(1).Text
            strPayRate = lstTodaysSales.Items(intIndex).SubItems(2).Text
            strHours = strHours.Replace("$", "0")
            sngHours = Convert.ToString(strHours)
            sngTotalSales += sngHours
            sngTotalWorkerPay += sngHours * strPayRate
        Next
        strResults = "Total Hours Worked: " & (sngTotalSales) & ControlChars.NewLine
        strResults &= "Total  Pay: " & Format$(sngTotalWorkerPay, "Currency")
        MessageBox.Show(strResults, "Total Hours Paid")
    End Sub

    Private Sub BtnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClr.Click
        lstTodaysSales.Items.Clear()
    End Sub
End Class
