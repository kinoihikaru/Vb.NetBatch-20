Namespace PartTwo
    Public Class Employee
        'encapsulation
        'penting ctrl + (.) untuk encapsulation dan constructor
        Private _empId As Integer
        Private _firstName As String
        Private _lastName As String
        Private _joinDate As DateTime
        Private _basicSalary As Double
        Private _totalSalary As Double
        Private _id As Integer = New Random().NextInt64(1, 10)

        'default data constructor
        Public Sub New()
        End Sub

        'create constructor 
        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double)
            _empId = empId
            _firstName = firstName
            _lastName = lastName
            _joinDate = joinDate
            _basicSalary = basicSalary
            TotalSalary = basicSalary
        End Sub

        'create overload constructor
        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double)
            _empId = New Random().NextInt64(1, 10) '_id
            _firstName = firstName
            _lastName = lastName
            _joinDate = joinDate
            _basicSalary = basicSalary
            TotalSalary = basicSalary
        End Sub

        'create encapsulation
        Public Property EmpId As Integer
            Get
                Return _empId
            End Get
            Set(value As Integer)
                _empId = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                _firstName = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property

        Public Property JoinDate As Date
            Get
                Return _joinDate
            End Get
            Set(value As Date)
                _joinDate = value
            End Set
        End Property

        Public Overridable Property BasicSalary As Double
            Get
                Return _basicSalary
            End Get
            Set(value As Double)
                _basicSalary = value
            End Set
        End Property

        Public Property TotalSalary As Double
            Get
                Return _totalSalary
            End Get
            Set(val As Double)
                _totalSalary = val
            End Set
        End Property

        Public Sub upSalary(nominal As Double)

        End Sub


        'overrides buat manipulasi data
        Public Overrides Function ToString() As String
            Return $"Empid : {Me.EmpId}, firstName : {Me.FirstName}, lastName : {Me.LastName}, joinDate : {Me.JoinDate}, basicSalary : {Me.BasicSalary}"
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Dim employee = TryCast(obj, Employee)
            Return employee IsNot Nothing AndAlso
                   _empId = employee._empId AndAlso
                   _firstName = employee._firstName AndAlso
                   _lastName = employee._lastName AndAlso
                   _joinDate = employee._joinDate AndAlso
                   _basicSalary = employee._basicSalary
        End Function
    End Class
End Namespace