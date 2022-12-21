Module code10_parameterized_constructors

    Class rectangle
        Public length As Double
        Public width As Double

        Public Sub New(ByVal len As Double, ByVal w As Double)
            length = len
            width = w
        End Sub
    End Class

    Sub Main()
        Dim rec1 As New rectangle(15, 7)
        Dim rec2 As New rectangle(30, 15)
        Console.WriteLine("the rectangle1 length and width are initialized:" & rec1.length & " " & rec1.width)
        Console.WriteLine("the rectangle2 length and width are initialized:" & rec2.length & " " & rec2.width & vbCrLf)
    End Sub
End Module
