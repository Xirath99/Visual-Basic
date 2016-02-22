Public Class Form1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NudMonez As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnClr As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnClr = New System.Windows.Forms.Button
        Me.NudMonez = New System.Windows.Forms.NumericUpDown
        CType(Me.NudMonez, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter amount "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Make Change"
        '
        'BtnClr
        '
        Me.BtnClr.Location = New System.Drawing.Point(216, 64)
        Me.BtnClr.Name = "BtnClr"
        Me.BtnClr.Size = New System.Drawing.Size(104, 40)
        Me.BtnClr.TabIndex = 3
        Me.BtnClr.Text = "Clear"
        '
        'NudMonez
        '
        Me.NudMonez.Location = New System.Drawing.Point(144, 8)
        Me.NudMonez.Name = "NudMonez"
        Me.NudMonez.Size = New System.Drawing.Size(128, 20)
        Me.NudMonez.TabIndex = 4
        Me.NudMonez.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 138)
        Me.Controls.Add(Me.NudMonez)
        Me.Controls.Add(Me.BtnClr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NudMonez, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Penny As Integer
    Dim Dime As Integer
    Dim Nickel As Integer
    Dim Quarter As Integer
    Dim HalfDollar As Integer
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strResults As String
        Do Until NudMonez.Value = 0
            If NudMonez.Value >= 50 Then
                NudMonez.Value = NudMonez.Value - 50
                HalfDollar = HalfDollar + 1
            ElseIf NudMonez.Value >= 25 Then
                NudMonez.Value = NudMonez.Value - 25
                Quarter = Quarter + 1

            ElseIf NudMonez.Value >= 10 Then
                NudMonez.Value = NudMonez.Value - 10
                Dime = Dime + 1
            ElseIf NudMonez.Value >= 5 Then
                NudMonez.Value = NudMonez.Value - 5
                Nickel = Nickel + 1
            ElseIf NudMonez.Value >= 1 Then
                NudMonez.Value = NudMonez.Value - 1
                Penny = Penny + 1
            End If



        Loop
        strResults = "Half Dollars: " & HalfDollar & ControlChars.NewLine
        strResults &= "Quarters: " & Quarter & ControlChars.NewLine
        strResults &= "Dimes: " & Dime & ControlChars.NewLine
        strResults &= "Nickels: " & Nickel & ControlChars.NewLine
        strResults &= "Pennies: " & Penny & ControlChars.NewLine
        MessageBox.Show(strResults, "Change")

    End Sub
    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClr.Click
        Penny = 0
        Nickel = 0
        Dime = 0
        Quarter = 0
        HalfDollar = 0
        NudMonez.Value = 0
    End Sub

  
