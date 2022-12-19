Public Class Form6

    Public Shared l1 As Label
    Public Shared l6 As Label
    Public Shared l7 As Label
    Public Shared l11 As Label
    Public Shared l18 As Label
    Public Shared l15 As Label
    Public Shared l16 As Label
    Public Shared l17 As Label

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DesktopLocation = New Point(15, 10)

        l1 = Label1
        l6 = Label8
        l7 = Label9
        l11 = Label11
        l18 = Label18
        l15 = Label15
        l16 = Label16
        l17 = Label17
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Form7.Hide()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
    End Sub
End Class