﻿Namespace Partone
    Public Class Employee
        Public empId As Integer
        Public firstName As String
        Public lastName As String
        Public joinDate As DateTime
        Public basicSalary As Double

        Public Overrides Function ToString() As String
            Return $"Empid : {empId}, firstName : {firstName}, lastName : {lastName}, joinDate : {joinDate}, basicSalary : {basicSalary}"
        End Function
    End Class
End Namespace