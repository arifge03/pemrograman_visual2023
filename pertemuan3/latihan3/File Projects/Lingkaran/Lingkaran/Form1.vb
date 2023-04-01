Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, luas, keliling As Integer

        jari = Val(txtJari.Text)

        luas = Math.PI * jari * jari
        keliling = Math.PI * jari * 2

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs) Handles txtJari.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
