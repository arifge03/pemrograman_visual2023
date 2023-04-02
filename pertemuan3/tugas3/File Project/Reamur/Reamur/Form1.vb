Public Class Form1
    Private Function KonversiSuhu(reamur As Integer) As Integer
        Dim kelvin As Integer
        kelvin = reamur / 0.8 + 273.15
        Return kelvin
    End Function
    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim reamur, kelvin As Integer

        reamur = Val(txtReamur.Text)

        kelvin = KonversiSuhu(reamur)

        txtKelvin.Text = Str(kelvin)

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
