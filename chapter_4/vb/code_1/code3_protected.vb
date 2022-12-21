Module code3_protected
    Public Class Employee
        Public empName As String
        Public empID As Integer = 100
        Protected carPay As Single
        Protected empAge As Integer
        Protected Shared companyName As String

        Sub m()
            carPay = 678
            Console.WriteLine(carPay)
        End Sub
    End Class

    Class manager
        Inherits Employee
        Sub n()
            Console.WriteLine(empAge & vbCrLf)
        End Sub


    End Class


    Sub Main()
        Dim objEmp As New Employee
        Dim objMan As New manager
        objEmp.m()
        objMan.n()
    End Sub
End Module
