Module DecesionModule
    Sub OddEventNumber()
        Dim num As Integer
        Console.Write("Enter Number : ")
        num = Console.ReadLine()

        If num Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If
    End Sub

    'Multiple If
    Sub Grade()
        Dim grade As Integer
        Console.Write("Enter a Number : ")
        grade = Console.ReadLine()

        If grade < 50 Then
            Console.WriteLine("F")
        ElseIf (grade >= 50) And (grade <= 60) Then
            Console.WriteLine("D")
        ElseIf (grade > 60) And (grade <= 80) Then
            Console.WriteLine("C")
        ElseIf (grade > 80) And (grade <= 90) Then
            Console.WriteLine("B")
        Else
            Console.WriteLine("Failed")
        End If
    End Sub

    Sub GradeCase()
        Dim grade As Integer
        Console.Write("Enter a Number : ")
        grade = Console.ReadLine()

        Select Case grade
            Case < 50
                Console.WriteLine("F")
            Case 50 To 60
                Console.WriteLine("D")
            Case 61 To 70
                Console.WriteLine("C")
            Case 71 To 80
                Console.WriteLine("B")
            Case Else
                Console.WriteLine("Failed")
        End Select

    End Sub

    'Random Number
    Sub WhoIsTheGuess()
        Dim num As Integer
        Dim rnd As New Random
        Dim TryAgain As Char
A:
        Console.Write("Enter Value Between (1-10) : ")
        num = Console.ReadLine()

        If (num > 10) Or (num < 0) Then
            Console.WriteLine("Out of Range")
        Else
            Dim guess As Integer = rnd.NextInt64(1, 11)
            Console.WriteLine("Your Input : " & num & vbCrLf & "Computer : " & guess)

            If (num > guess) Then
                Console.WriteLine("You Win")
            ElseIf num = guess Then
                Console.WriteLine("Draw")
            Else
                Console.WriteLine("You Lose")
            End If
        End If

        Console.Write("Try Again ? (Y/N) : ")
        TryAgain = Console.ReadLine()

        If (TryAgain = "Y") Or (TryAgain = "y") Then
            GoTo A
        End If
    End Sub
End Module
