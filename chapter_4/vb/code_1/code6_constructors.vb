Module code6_constructors

    Public Class course
        Sub New(ByVal courseID As Integer)
            Console.WriteLine(courseID & vbCrLf)
        End Sub
    End Class

    Sub Main()
        Dim trainingCourse As New course(100)
    End Sub
End Module
