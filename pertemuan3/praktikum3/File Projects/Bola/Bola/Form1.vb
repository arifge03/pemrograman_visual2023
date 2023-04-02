Public Class Form1
    Private Function HitungVolume(jari As Integer) As Integer
        Dim volume As Integer
        volume = 4 / 3 * Math.PI * Math.Pow(jari, 3)
        Return volume
    End Function
    Private Function HitungLuasPermukaan(jari As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 4 * Math.PI * Math.Pow(jari, 2)
        Return luas_permukaan
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, volume, luas_permukaan As Integer

        jari = Val(txtJari.Text)

        volume = HitungVolume(jari)
        luas_permukaan = HitungLuasPermukaan(jari)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luas_permukaan)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtKeliling_TextChanged(sender As Object, e As EventArgs) Handles txtLuasPermukaan.TextChanged

    End Sub
End Class
