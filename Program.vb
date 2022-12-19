Imports System
Imports TutorialAppConsole.Partone
Imports TutorialAppConsole.PartTwo

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")

        'must call sub method
        'sayMyName()

        'call method from module
        'ModuleVariable.storeVariable()
        'ModuleVariable.swapVariable()
        'MathApp.OperationMatch()
        'DecesionModule.OddEventNumber()
        'DecesionModule.GradeCase()
        'DecesionModule.WhoIsTheGuess()
        'ModuleDateTime.ShowDate()
        'ModuleIteration.DoWhile(9)
        'ModuleIteration.DoWhileExit(9)
        'ModuleIteration.ForLoop()
        'ModuleIteration.cetakKotakBintang(5)
        ModulePartTwo.InitEmployee()


    End Sub

    Sub sayMyName()
        'declaration variable
        Dim myName As String
        Console.Write("Masukan Name Kamu : ?")
        myName = Console.ReadLine()

        'display result
        Console.WriteLine("Your Name :" & myName)

    End Sub
End Module
