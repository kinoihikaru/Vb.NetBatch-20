Module MathApp

    Sub OperationMatch()
        Dim y As Double
        y = 12 + (15 + 3) - 2 ^ 3 / 4 * 5
        Console.Writeline(y)
    End Sub

    Sub BagiSisa()
        Dim num1, num2, bagi, sisa As Integer
        Console.write("Enter Number 1 :")
        num1 = console.readline()
        console.write("Enter Number 2 :")
        num2 = console.readline()

        'result
        bagi = num1 \ num2
        sisa = num1 Mod num2

        console.writeline("Result Bagi : " & bagi & ", sisa : " & sisa)

    End Sub

End Module
