Module code2_private
    Class person
        Public intAge As Integer
        Private strName As String

        Public Sub setName(ByVal name)
            strName = name
        End Sub

        Public Function getName() As String
            Return strName
        End Function

        Public Sub displayData()
            Console.WriteLine("age= " & intAge)
            Console.WriteLine("name= " & strName & vbCrLf)
        End Sub
    End Class

    Sub Main()
        Dim objPerson As New person

        objPerson.intAge = 23
        objPerson.setName("Mahmoud")
        objPerson.displayData()

    End Sub

End Module
