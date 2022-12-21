Module code8_defaultconstructors

    Class addition
        Public x, y As Integer

        Public Sub New()
            x = 30
            y = 7
        End Sub

    End Class

    Sub Main()
        Dim objAdd As New addition
        Console.WriteLine(objAdd.x)
        Console.WriteLine(objAdd.y & vbCrLf)
    End Sub
End Module
