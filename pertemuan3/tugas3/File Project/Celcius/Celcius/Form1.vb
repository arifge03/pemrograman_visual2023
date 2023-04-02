Public Class Form1
    Private Function KonversiSuhu(celcius As Integer) As Integer
        Dim Fahrenheit As Integer
        Fahrenheit = celcius * 1.8 + 32
        Return Fahrenheit
    End Function
    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim celcius, fahrenheit As Integer

        celcius = Val(txtCelcius.Text)

        fahrenheit = KonversiSuhu(celcius)

        txtFahrenheit.Text = Str(fahrenheit)

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
