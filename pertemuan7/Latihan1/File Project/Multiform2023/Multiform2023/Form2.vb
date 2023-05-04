Public Class Form2
    Private Sub F1(sender As Object, e As EventArgs) Handles Form1.Click
        Dim F1 As New Form2
        F1.ShowDialog()
    End Sub
    Private Sub F3(sender As Object, e As EventArgs) Handles Form3.Click
        Dim F3 As New Form3
        F3.ShowDialog()
    End Sub
    Private Sub F4(sender As Object, e As EventArgs) Handles Form4.Click
        Dim F4 As New Form4
        F4.ShowDialog()
    End Sub
    Private Sub F5(sender As Object, e As EventArgs) Handles Form5.Click
        Dim F5 As New Form5
        F5.ShowDialog()
    End Sub
End Class