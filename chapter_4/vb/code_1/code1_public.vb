Module code1_public

    Class Box
        Public length As Double
        Public breadth As Double
        Public height As Double

        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub

        Public Sub setBreadth(ByVal bre As Double)
            breadth = bre
        End Sub

        Public Sub setHeight(ByVal hei As Double)
            height = hei
        End Sub

        Public Function getVolume() As Double
            Return length * breadth * height
        End Function
    End Class

    Sub Main()
        Dim Box1 As New Box
        Dim Box2 As New Box
        Box1.setLength(9)
        Box1.setBreadth(5)
        Box1.setHeight(10)

        Box2.setLength(14)
        Box2.setBreadth(15)
        Box2.setHeight(12)

        Console.WriteLine("Volume of Box1 is " & Box1.getVolume)
        Console.WriteLine("Volume of Box2 is " & Box2.getVolume & vbCrLf)

    End Sub
End Module
