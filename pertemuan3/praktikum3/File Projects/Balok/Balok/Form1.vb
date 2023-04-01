Public Class Form1
    Private Function HitungVolume(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = panjang * lebar * tinggi
        Return volume
    End Function
    Private Function HitungLuasPermukaan(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi)
        Return luas_permukaan
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, tinggi, volume, luas_permukaan As Integer

        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)
        tinggi = Val(txtTinggi.Text)

        volume = HitungVolume(panjang, lebar, tinggi)
        luas_permukaan = HitungLuasPermukaan(panjang, lebar, tinggi)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luas_permukaan)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs) Handles txtPanjang.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtKeliling_TextChanged(sender As Object, e As EventArgs) Handles txtLuasPermukaan.TextChanged

    End Sub
End Class
