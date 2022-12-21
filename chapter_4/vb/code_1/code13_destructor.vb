Module code13_destructor

    Class class1
        Public Sub New(ByVal n As Integer)
            Console.WriteLine("The square of integer value {0} is: {1}", n, n ^ 2)
        End Sub

        Public Sub New(ByVal n As Double)
            Console.WriteLine("The square of integer value {0} is: {1}", n, n ^ 2)
        End Sub

        Protected Overrides Sub finalize()
            Console.WriteLine("GoodBye...!" & vbCrLf & "now !! object was terminated.")
        End Sub
    End Class

    Sub Main()
        dateils()
        GC.Collect()
    End Sub

    Sub dateils()
        Dim obj1 As New class1(10)
        Dim obj2 As New class1(2.5)
    End Sub
End Module
