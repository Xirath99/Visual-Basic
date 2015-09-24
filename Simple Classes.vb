Module Module1

    Sub Main()

        'Dim myNewCar As Car = New Car
        Dim myNewCar As New Car
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
        Console.WriteLine()
        Console.ReadLine()

    End Sub
    'Function determinemarketValue(ByVal myCar As Car) As Double
    '    'Super Secret Formula
    '    Return 100.0
    'End Function

End Module









Public Class Car

    Public Make As String
    Public model As String
    Public Year As Integer
    Public Color As String


    Public Function determinemarketValue() As Double
        'Super Secret Formula
        Return 100.0
    End Function























