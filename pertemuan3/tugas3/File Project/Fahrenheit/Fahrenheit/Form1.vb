Public Class Form1
    Private Function KonversiSuhu(fahrenheit As Integer) As Integer
        Dim reamur As Integer
        reamur = (fahrenheit - 32) * 0.44
        Return reamur
    End Function
    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim fahrenheit, reamur As Integer

        fahrenheit = Val(txtFahrenheit.Text)

        reamur = KonversiSuhu(fahrenheit)

        txtReamur.Text = Str(reamur)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtKeliling_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
