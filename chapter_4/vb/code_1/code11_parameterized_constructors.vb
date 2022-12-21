Module code11_parameterized_constructors

    Class human
        Dim name As String
        Dim age As Integer

        Sub New(ByVal n As String, ByVal a As Integer)
            name = n
            age = a
        End Sub

        Sub New(ByVal a As Integer)
            age = a
        End Sub

        Sub New(ByVal n As String)
            name = n
        End Sub

        Sub New()
            Console.WriteLine("Parameter not set yet")
        End Sub

        Sub printdata()
            Console.WriteLine("My name " & name)
            Console.WriteLine("My age " & age)
        End Sub

    End Class

    Sub Main()
        Dim h1 As New human("Mahmoud", 23)
        Dim h2 As New human("Mahmoud")
        Dim h3 As New human(23)
        h1.printdata()
        Console.WriteLine("-------")
        h2.printdata()
        Console.WriteLine("-------")
        h3.printdata()
        Console.WriteLine("-------")
        Dim h4 As New human()
        h4.printdata()
        Console.WriteLine()
    End Sub
End Module
