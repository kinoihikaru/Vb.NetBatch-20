Namespace PartTwo
    Module ModulePartTwo
        Sub InitEmployee()
            'create object employee with encapsilation
            Dim emp1 As New Employee(1, "fadel", "ea", DateTime.Now(), 5_000)

            'display employee infoo
            Console.WriteLine(emp1.ToString)

            emp1.FirstName = "Kang"
            emp1.LastName = "Dian"
            emp1.BasicSalary = 6_000

            Console.WriteLine(emp1.ToString)

            Dim emp2 As New Employee("Eric", "son", DateTime.Now, 8_000)
            Console.WriteLine(emp2.ToString)

            'create object programmer
            Dim emp3 As New Programmer("widi", "Amalia", DateTime.Now, 5_600_000, 500_000)
            Console.WriteLine(emp3.ToString)

            emp3.FirstName = "Aman"
            emp3.BasicSalary = 5_000_000
            emp3.Transportasi = 400_000
            Console.WriteLine(emp3.ToString)
        End Sub

    End Module
End Namespace


