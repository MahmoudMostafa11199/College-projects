Module code12_parameterized_constructors

    Public Class student
        Public firstName As String
        Public lastName As String
        Public studentID As Integer
        Sub New()
            Console.WriteLine("Parameter not set yet")
        End Sub

        Sub New(ByVal id As Integer)
            studentID = id
            Console.WriteLine("ID= " & studentID)
        End Sub

        Sub New(ByVal fn As String, Optional ByVal ln As String = "Mostafa")
            firstName = fn
            lastName = ln
            Console.WriteLine("The first name is " & firstName & " and the last name is " & lastName)
        End Sub
    End Class

    Sub Main()
        Dim std1 As New student()
        Dim std2 As New student(22)
        Dim std3 As New student("Mahmoud")
        Console.WriteLine()
    End Sub

End Module
