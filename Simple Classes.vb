Module Module1

    Sub Main()

        'Dim myNewCar As Car = New Car
        Dim myNewCar As New Car
        'Dim myNewCar As Car

        Dim myOtherCar As New Car("BMW", 2005, 30000)
        CarLot.AddToInventory(myNewCar)


        myNewCar.Make = "OldMobile"
        myNewCar.model = "cutlass Supreme"
        myNewCar.Year = 1986
        myNewCar.Color = "silver"


        'With myNewCar
        '    .Make = "Olds"
        '    .model = "cutlass"
        '    .Year = 1986
        '    .Color = "silver"
        'End With
        'Console.WriteLine("{0} - {1} - {2}", myNewCar.Model, myNewCar.make, myNewCar.Year.ToString())
        'Console.WriteLine(determinemarketValue(myNewCar))
        'Console.WriteLine(myNewCar.determinemarketValue())
        Console.WriteLine("Before: " & myNewCar.Make)
        doByValue(myNewCar)
        Console.WriteLine("After By Value: " & myNewCar.Make)

        doByReference(myNewCar)
        Console.WriteLine("After By Reference:" & myNewCar.Make)
        Console.ReadLine()

    End Sub
    'Function determinemarketValue(ByVal myCar As Car) As Double
    '    'Super Secret Formula
    '    Return 100.0
    'End Function


    Sub doByValue(ByVal myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub

    Sub doByReference(ByRef myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub

End Module











Public Class Car

    Public Make As String
    Public model As String
    Public Year As Integer
    Public Color As String
    Public Amount As Double
    Public SurCharge As Double
    Public Sub New()

    End Sub

    Public Sub New(ByVal _make As String, ByVal _year As Integer, ByVal _amount As Double)
        Me.Make = _make
        Me.Year = _year
        Me.Amount = _amount
        Me.SurCharge = _amount * 1.025

    End Sub


    Public Sub myMethod(ByVal myParameter As String)

    End Sub
    Public Sub myMethod(ByVal another version As String,ByVal myParameter As String)

    End Sub


Public Sub myMethod(ByVa myParameter As Integer)

    End Sub



















    Public Function determinemarketValue() As Double
        'Super Secret Formula
        Return 100.0
    End Function


End Class



Public Class CarLot
    Public Shared Sub AddtToInventory(ByVal newCar As Car)

    End Sub
End Class









