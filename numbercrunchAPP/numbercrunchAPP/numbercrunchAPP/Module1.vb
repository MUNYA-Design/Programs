
' Number Crunch App

' Coded by
'   __  __        _   _        _  _       __   __       ___
'  |  \/  |      | | | |      | \| |      \ \ / /      /   \
'  | |\/| |      | |_| |      | .  |       \   /       | - |
'  |_|  |_|       \___/       |_|\_|        |_|        |_|_|
'  MUNYA
'  

Module Module1
    Dim i, j As Integer
    Dim spadding As String = "     "

    Sub FindAverage()

        ' ====== Find the Average of 4 numbers. The 4 numbers must be from the user.

        Dim spadding As String = "     " '(I already have it as a global variable)

        'User prompt
        Console.WriteLine(spadding & "#FindAverage" & vbNewLine & vbNewLine & spadding & "Enter 4 numbers to find the average.")

        'Declare a variable to store the average
        Dim dAverage As Double = 0

        'Using a for-loop, get 4 numbers from the user and add them in the array
        For i = 1 To 4
            dAverage += Console.ReadLine()
        Next

        'Display the result, use Math.Round() when displaying the result
        Console.WriteLine(spadding & "The Average is = " & (Math.Round(dAverage / 4)))

    End Sub

    Sub OddOrEven()
        ' ====== Check if x is an Odd or Even number (x = userinput)

        'User prompt
        Console.WriteLine(spadding & "#OddOrEven" & vbNewLine & vbNewLine & spadding & "Enter any number.")

        'Declare a var (as Integer) && Ask the user to enter a number
        Dim inum As Integer = Console.ReadLine()

        'Using an if-statement, check if the number is an odd or even number and display the result
        If (((inum) Mod (2)) = 0) Then
            Console.WriteLine(spadding & inum & " is an even number.")
        Else
            Console.WriteLine(spadding & inum & " is an odd number.")
        End If

    End Sub

    Sub PrintFactors()

        ' ====== Print the factors of x (x = userinput)

        'User prompt
        Console.WriteLine(spadding & "#PrintFactors" & vbNewLine & vbNewLine & spadding & "Enter any number to find it's factors.")

        'Declare an array to store the number (as Integer) && Ask the user to enter a number
        Dim inum As Integer = Console.ReadLine()

        'Using a for-loop and an if-statement, determine and display the factors.
        Console.WriteLine(spadding & "The factors of " & inum & " are.")
        For i = 1 To inum - 1
            If ((inum Mod i) = 0) Then
                Console.WriteLine(spadding & "->  " & i & " and " & (inum / i))
            End If
        Next

    End Sub

    Sub PrintSum()

        ' ====== Print the sum of x numbers from the user (x, numbers = userinput)

        'User prompt
        Console.WriteLine(spadding & "#PrintSum" & vbNewLine & vbNewLine)

        'Ask the user how many numbers they want to insert
        Console.WriteLine(spadding & "How many numbers do you need to insert?")

        'Declare a variable (as Integer), Get input
        Dim icnt As Integer = Console.ReadLine

        'Ask the user to enter the numbers until icnt
        Console.WriteLine(spadding & "Enter the numbers.")

        'Declare a variable for the sum of the numbers
        Dim dsum As Double = 0

        'Using a for-loop, capture the numbers and add them
        For i = 0 To icnt - 1
            'dsum += Console.ReadLine()
            dsum = dsum + Console.ReadLine()
        Next

        'Diplay the result
        Console.WriteLine(spadding & "The sum is = " & dsum)

    End Sub

    Sub PrintPrimeNums()

        ' ====== Print the first x prime numbers (x = userinput)

        'User prompt
        Console.WriteLine(spadding & "#PrintPrimeNums" & vbNewLine & vbNewLine)

        'Ask the user how many numbers they want to insert
        Console.WriteLine(spadding & "Going to print prime numbers now. At which number should I stop?")

        'Get the input
        Dim MAXPrime As Integer = Console.ReadLine

        'Display the result
        Dim isprime As Boolean = True

        'Test if this is a prime or not
        For i = 2 To MAXPrime - 1
            ' i = primary number
            'Assume it is a prime
            isprime = True

            'Check against the properties of none prime (Prime' in all real positive integers > 0, but < MAXPrime) = {1,2,3,4,5,6,...,MAXPrime}
            For j = 2 To MAXPrime - 1
                ' j = secondary number

                'Getting a seq. of numbers to test against
                'BELOW! If we divide i by j and the remainder is = 0 AND (restrictions)
                If ((i Mod j) = 0) And (((i > j) And Not ((i = 1) And (j = 1) And (i = MAXPrime) And (j = MAXPrime) And (i = j)))) Then

                    'Then it not a prime number
                    isprime = False

                End If
            Next

            'If it was a isprime was NOT(false) then isprime = true, therefore...(our assumption was correct)
            If (isprime) Then
                Console.WriteLine(spadding & "--> " & i)
            End If

        Next

    End Sub

    Sub FindLargestNum()
        ' ====== Display the largest number from x numbers (user must enter the number of numbers the want to enter and enter the numbers as well - like in 'PrintSum()')

        'User prompt
        Console.WriteLine(spadding & "#FindLargestNum" & vbNewLine & vbNewLine)

        'Ask the user how many numbers they want to insert
        Console.WriteLine(spadding & "How many numbers do you need to insert?")

        'Get the input
        Dim icnt As Integer = Console.ReadLine

        'Ask the user to enter the numbers | Find the largest number
        Console.WriteLine(spadding & "Enter the numbers.")

        'The first input is the current max
        Dim max As Double = Console.ReadLine

        Dim iinput As Integer
        'Read the next input (note, started at index 1)
        For i = 1 To icnt

            'Get the user input
            iinput = Console.ReadLine

            'Check if the number is bigger than the current 'max' value
            If (iinput > max) Then
                max = iinput
            End If

        Next

        'Display the result 
        Console.WriteLine(spadding & "The largest number is = " & max)

    End Sub


    Sub Main()

        FindAverage()
        Console.WriteLine()
        OddOrEven()
        Console.WriteLine()
        PrintFactors()
        Console.WriteLine()
        PrintSum()
        Console.WriteLine()
        PrintPrimeNums()
        Console.WriteLine()
        FindLargestNum()

        Console.ReadLine()
    End Sub

End Module
