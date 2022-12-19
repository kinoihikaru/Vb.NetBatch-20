Module ModuleIteration
    'doWhile
    Sub DoWhile(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            i += 1
        Loop
    End Sub

    Sub DoWhileExit(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            If (i = 8) Then
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub


    'forLoop
    Sub ForLoop()
        For index = 1 To 10
            Console.Write("* ")
        Next
    End Sub

    Sub cetakKotakBintang(nums As Integer)
        For i = 1 To nums
            'cetak horizontal
            For j = i To nums
                Console.Write("* ")
            Next
            'pindah baris
            Console.WriteLine()
        Next
    End Sub
End Module
