Public Class Form1
    Private Function HitungVolume(sisi As Integer) As Integer
        Dim volume As Integer
        volume = Math.Pow(sisi, 3)
        Return volume
    End Function
    Private Function HitungLuasPermukaan(sisi As Integer) As Integer
        Dim luas_permukaan As Integer
        luas_permukaan = 6 * Math.Pow(sisi, 2)
        Return luas_permukaan
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, volume, luas_permukaan As Integer

        sisi = Val(txtSisi.Text)

        volume = HitungVolume(sisi)
        luas_permukaan = HitungLuasPermukaan(sisi)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luas_permukaan)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs) Handles txtSisi.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtKeliling_TextChanged(sender As Object, e As EventArgs) Handles txtLuasPermukaan.TextChanged

    End Sub
End Class
