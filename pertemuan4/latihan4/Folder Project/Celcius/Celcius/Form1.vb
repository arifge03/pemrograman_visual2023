﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim C, F, R, K As Decimal
        C = CDec(txtCelcius.Text)
        F = ToFahrenheit(C)
        R = ToReamur(C)
        K = ToKelvin(C)

        txtFahrenheit.Text = Str(F)
        txtReamur.Text = Str(R)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToFahrenheit(suhu As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 5) * suhu + 32
        Return F
    End Function

    Private Function ToReamur(suhu As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 5 * suhu
        Return R
    End Function

    Private Function ToKelvin(suhu As Decimal) As Decimal
        Dim K As Decimal
        K = suhu + 273
        Return K
    End Function

End Class
