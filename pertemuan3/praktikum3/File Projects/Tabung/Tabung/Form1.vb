Public Class Form1
    Private Function HitungVolume(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = Math.PI * Math.Pow(jari, 2) * tinggi
        Return volume
    End Function
    Private Function HitungLuasPermukaan(jari As Integer, tinggi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 2 * Math.PI * jari * (jari + tinggi)
        Return luas_permukaan
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, tinggi, volume, luas_permukaan As Integer

        jari = Val(txtJari.Text)
        tinggi = Val(txtTinggi.Text)

        volume = HitungVolume(jari, tinggi)
        luas_permukaan = HitungLuasPermukaan(jari, tinggi)

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
