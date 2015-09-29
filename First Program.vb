Module Module1

    Sub Main()

        Dim username As String
        Dim UserValue1 As Double
        Dim UserValue2 As Double
        Dim Answer As Double

        Console.Write("Hello It is nice to meet you My name is nero and yours?: ")


        username = Console.ReadLine()
        Console.WriteLine("So your name is " & username & " Well then, " & username & " Welcome to your First VideoBasic Program " & vbCrLf)
        Console.WriteLine("Could you pick two numbers that will be added,Subbtracted,multiplied and divided")

        Console.Write("What is your first number: ")
        UserValue1 = Console.ReadLine()

        Console.Write("What is your second number: ")
        UserValue2 = Console.ReadLine()

        Answer = UserValue1 + UserValue2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(UserValue1 & " added with " & UserValue2 & " = " & Answer)

        Answer = UserValue1 - UserValue2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(UserValue1 & "subtracted by  " & UserValue2 & " = " & Answer)

        Answer = UserValue1 * UserValue2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(UserValue1 & " multiplied by " & UserValue2 & " = " & Answer)

        Answer = UserValue1 / UserValue2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(UserValue1 & " divided by " & UserValue2 & " = " & Answer)


        Console.ReadLine()


    End Sub

End Module
