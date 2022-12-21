Module code9_parameterizedconstructors

    Class constr_class
        Private x As Integer
        Public Sub New(ByVal setValue As Integer)
            x = setValue
        End Sub

        Public Function display()
            Return x
        End Function
    End Class

    Sub Main()
        Dim obj1 As New constr_class(22)
        Console.Write("value of x as intialized to: ")
        Console.WriteLine(obj1.display() & vbCrLf)
    End Sub
End Module
