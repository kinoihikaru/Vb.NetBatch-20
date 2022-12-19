Module ModuleVariable
    'Declaration

    Sub storeVariable()
        Dim number As Integer = 200
        Dim myName As String = "Bootcamp .Net"
        Console.WriteLine("Number : " & number & ", And MyName : " & myName)
        myName = "Code ID"
        Console.WriteLine("MyName : " & myName)
    End Sub

    'store Constant Variable
    Sub storeConstant()
        Const PHI = 3.14

        Console.WriteLine("Phi :" & PHI)
    End Sub

    'variable = a,b,c
    'a=1,b=2,c=3
    Sub swapVariable()
        Dim a, b, c As Integer
        Console.Write("Value A: ")
        a = Console.ReadLine()

        Console.Write("Value B: ")
        b = Console.ReadLine()


        Console.WriteLine("Before : a = " & a & " b = " & b)

        c = a
        a = b
        b = c
        Console.WriteLine("After : a = " & a & " b = " & b)
    End Sub

End Module
