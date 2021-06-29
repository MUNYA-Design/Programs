Module Module1
    Sub PrintName(sname As String)
        'Instructions to add
        Console.WriteLine("Hi, " & sname)
    End Sub

    Function Add(number1 As Double, number2 As Double)
        'Instructions to add
        Return number1 + number2
    End Function

    Function Subtract(number1 As Double, number2 As Double)
        'Instructions to add
        Return number1 - number2
    End Function

    Function Multi(number1 As Double, number2 As Double)
        'Instructions to add
        Return number1 * number2
    End Function

    Function Div(number1 As Double, number2 As Double)
        'Instructions to add
        Return Math.Round(number1 / number2)
    End Function
    Sub Main()
        'Calculator
        ' - Adding, Subtracting, Mult, Div using 'Subprocedure' and 'Functions'

        'User input
        Dim inum1, inum2 As Double
        Dim sname1 As String

        Console.WriteLine("Enter your name")
        sname1 = Console.ReadLine()
        PrintName(sname1)

        Console.WriteLine("Enter 1st number. " & vbNewLine)
        inum1 = Console.ReadLine()
        Console.WriteLine("Enter 2nd number." & vbNewLine)
        inum2 = Console.ReadLine()

        'Display output
        Console.WriteLine(vbNewLine & inum1 & " + " & inum2 & " = " & Add(inum1, inum2))
        Console.WriteLine(vbNewLine & inum1 & " - " & inum2 & " = " & Subtract(inum1, inum2))
        Console.WriteLine(vbNewLine & inum1 & " * " & inum2 & " = " & Multi(inum1, inum2))
        Console.WriteLine(vbNewLine & inum1 & " / " & inum2 & " = " & Div(inum1, inum2))

        Console.ReadLine()
    End Sub

End Module
