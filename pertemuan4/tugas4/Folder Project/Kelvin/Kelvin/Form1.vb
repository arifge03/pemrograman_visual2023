Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim C, F, R, K As Decimal
        K = CDec(txtKelvin.Text)
        C = ToCelcius(K)
        F = ToFahrenheit(K)
        R = ToReamur(K)

        txtCelcius.Text = Str(C)
        txtFahrenheit.Text = Str(F)
        txtReamur.Text = Str(R)
    End Sub

    Private Function ToCelcius(suhu As Decimal) As Decimal
        Dim C As Decimal
        C = suhu - 273
        Return C
    End Function

    Private Function ToFahrenheit(suhu As Decimal) As Decimal
        Dim F As Decimal
        F = 4 / 5 * (suhu - 273)
        Return F
    End Function

    Private Function ToReamur(suhu As Decimal) As Decimal
        Dim K As Decimal
        K = 9 / 5 * (suhu - 273) + 32
        Return K
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
