Module code7_constructors

    Public Class Person
        Sub New()
            Console.WriteLine("my first constructor" & vbCrLf)
        End Sub

        Public Sub mysub()
            

        End Sub
    End Class

    Sub Main()
        Dim pr1 As New Person
        Dim pr2 As New Person
        Dim pr3 As New Person
    End Sub
End Module
