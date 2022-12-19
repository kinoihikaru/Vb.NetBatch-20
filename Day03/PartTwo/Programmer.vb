Namespace PartTwo
    Public Class Programmer
        Inherits Employee

        Private _transportasi As Double


        '(public class ctrl + (.) in nameClass) to generate
        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.TotalSalary + transportasi
        End Sub

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Transportasi
            End Set
        End Property

        Public Overloads Sub upSalary(nominal As Double, php As Double)

        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, tjTransport : {Transportasi}, totalSalary : {MyBase.TotalSalary}"
        End Function

        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = value + BasicSalary
            End Set
        End Property

    End Class
End Namespace


