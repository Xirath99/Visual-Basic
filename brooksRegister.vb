Dim tax, subtotal, total As Decimal
    Dim taxRate As Decimal = 0.08

    'Class level Constants as Decimal Value
    Dim Burger As Decimal = 3.99
    Dim Ribs As Decimal = 4.99
    Dim Pizza As Decimal = 2.99
    Dim Anonymous As Decimal = 5.99
    Dim peporoni As Decimal = 0.88
    Dim Bacon As Decimal = 0.88
    Dim Spinach As Decimal = 0.88
    Dim HAxorsauce As Decimal = 0.0
    Dim Islan As Decimal = 0.0
    Dim ketchip As Decimal = 0.0
    Dim lemonade As Decimal = 1.99
    Dim Coke As Decimal = 1.99
    Dim Tea As Decimal = 1.99
    Dim fries As Decimal = 0.99
    Dim onionrings As Decimal = 0.99
    Dim Nuggets As Decimal = 0.99
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        initializeVariables()
        ClearTheCustomerSelections()
        ClearRecieipt()
    End Sub

    Private Sub initializeVariables()
        subtotal = 0
        tax = 0
        total = 0

    End Sub
    Private Sub ClearTheCustomerSelections()
        btnBurger.Checked = False
        btnRibs.Checked = False
        btnPizza.Checked = False
        btnAnonymous.Checked = False
        btnPepp.Checked = False
        btnBacon.Checked = False
        btnSpinach.Checked = False
        btnlemon.Checked = False
        btnCoke.Checked = False
        btnTea.Checked = False
        btnFries.Checked = False
        btnOnion.Checked = False
        btnTenPc.Checked = False
        btnHaxor.Checked = False
        btnIsland.Checked = False
        btnKetch.Checked = False
    End Sub
    Private Sub ClearRecieipt()
        ListBoxDisplay.Items.Clear()
        ListBoxTotal.Items.Clear()
    End Sub
   
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        initializeVariables()
        ClearTheCustomerSelections()
        ClearRecieipt()
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Me.Close()
    End Sub

    Private Sub computeCurrentSelection()
        If btnBurger.Checked Then
            subtotal += Burger
            Dim burgeritem As String = Burger.ToString("C") & "Da Burger"
            ListBoxDisplay.Items.Add(burgeritem)
        End If
        If btnRibs.Checked Then
            subtotal += Ribs
            Dim Ribsitem As String = Ribs.ToString("C") & "Baby Back Ribs"
            ListBoxDisplay.Items.Add(Ribsitem)
        End If
        If btnPizza.Checked Then
            subtotal += Pizza
            Dim Pizzaitem As String = Pizza.ToString("C") & "Chesse Pizza"
            ListBoxDisplay.Items.Add(Pizzaitem)
        End If
        If btnAnonymous.Checked Then
            subtotal += Anonymous
            Dim Anonitem As String = Anonymous.ToString("C") & "The Anonymous"
            ListBoxDisplay.Items.Add(Anonitem)
        End If
        If btnPepp.Checked Then
            subtotal += peporoni
            Dim peppritem As String = peporoni.ToString("C") & "Pepporoni"
            ListBoxDisplay.Items.Add(peppritem)
        End If
        If btnBacon.Checked Then
            subtotal += Bacon
            Dim baconitem As String = Bacon.ToString("C") & "Bacon"
            ListBoxDisplay.Items.Add(baconitem)
        End If
        If btnSpinach.Checked Then
            subtotal += Spinach
            Dim spinitem As String = Spinach.ToString("C") & "Spinach"
            ListBoxDisplay.Items.Add(spinitem)
        End If
        If btnHaxor.Checked Then
            subtotal += HAxorsauce
            Dim haxitem As String = HAxorsauce.ToString("C") & "Haxor Sauce"
            ListBoxDisplay.Items.Add(haxitem)
        End If
        If btnIsland.Checked Then
            subtotal += Islan
            Dim Isitem As String = Islan.ToString("C") & "Thousand Island"
            ListBoxDisplay.Items.Add(Isitem)
        End If
        If btnKetch.Checked Then
            subtotal += ketchip
            Dim Keitem As String = ketchip.ToString("C") & "ketchup"
            ListBoxDisplay.Items.Add(Keitem)
        End If
        If btnlemon.Checked Then
            subtotal += lemonade
            Dim Leitem As String = lemonade.ToString("C") & "lemonade"
            ListBoxDisplay.Items.Add(Leitem)
        End If
        If btnCoke.Checked Then
            subtotal += Coke
            Dim coitem As String = Coke.ToString("C") & "Coke"
            ListBoxDisplay.Items.Add(coitem)
        End If
        If btnTea.Checked Then
            subtotal += Tea
            Dim Titem As String = Tea.ToString("C") & "Nestle Tea"
            ListBoxDisplay.Items.Add(Titem)
        End If
        If btnFries.Checked Then
            subtotal += fries
            Dim fryitem As String = fries.ToString("C") & "Fries"
            ListBoxDisplay.Items.Add(fryitem)
        End If
        If btnOnion.Checked Then
            subtotal += onionrings
            Dim oniitem As String = onionrings.ToString("C") & "Onion Rings"
            ListBoxDisplay.Items.Add(oniitem)
        End If
        If btnTenPc.Checked Then
            subtotal += Nuggets
            Dim Nugitem As String = Nuggets.ToString("C") & "Da Burger"
            ListBoxDisplay.Items.Add(Nugitem)
        End If







    End Sub

    Private Sub UpdateTotal()
        ListBoxTotal.Items.Clear()
        ListBoxTotal.Items.Add("SUB TOTAL = " & subtotal.ToString("C"))

        tax = subtotal * taxRate
        ListBoxTotal.Items.Add("           Tax = " & tax.ToString("C"))

        total = subtotal + tax
        ListBoxTotal.Items.Add("          Total = " & total.ToString("C"))

        ListBoxDisplay.Items.Add("-----------------------")

    End Sub


    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click
        computeCurrentSelection()
        UpdateTotal()
        ClearTheCustomerSelections()
    End Sub
