﻿Namespace Partone
    Module ModulePartOne
        Sub InitEmployee()
            'create object employee
            Dim emp1 As New Employee With {
                .empId = 1,
                .firstName = "Kang",
                .lastName = "Dian",
                .joinDate = #12/12/2002 08:00:00 AM#,
                .basicSalary = 5_000_000
            }


            'display employee infoo
            Console.WriteLine(emp1.ToString)

            emp1.basicSalary = 4_000_000
            Console.WriteLine(emp1.ToString)

        End Sub

    End Module
End Namespace


