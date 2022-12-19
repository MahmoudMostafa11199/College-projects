Public Class Form3
    Public Shared l1 As Label
    Public Shared l2 As Label
    Public Shared l3 As Label
    Public Shared l4 As Label
    Public Shared l5 As Label
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DesktopLocation = New Point(20, 10)

        l1 = Label1
        l2 = Label4
        l3 = Label5
        l4 = Label6
        l5 = Label7
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Hide()
        Me.Hide()
        Form1.Show()
    End Sub
End Class