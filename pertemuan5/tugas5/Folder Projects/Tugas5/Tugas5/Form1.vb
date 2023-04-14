Public Class Form1
    Private Function HitungNilaiAkhir(khd As Integer, tgs As Integer, uts As Integer, uas As Integer) As Integer
        Dim nilaiAkhir As Integer
        nilaiAkhir = (25 / 100 * khd) + (35 / 100 * tgs) + (20 / 100 * uts) + (20 / 100 * uas)
        Return nilaiAkhir
    End Function
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim nim, khd, tgs, uts, uas, nilaiAkhir As Integer
        Dim nama, prodi As String

        nim = Val(txtNIM.Text)
        nama = Val(txtNama.Text)
        prodi = Val(txtProdi.Text)
        khd = Val(txtNilaiKehadiran.Text)
        tgs = Val(txtTugas.Text)
        uts = Val(txtUTS.Text)
        uas = Val(txtUAS.Text)

        nilaiAkhir = HitungNilaiAkhir(khd, tgs, uts, uas)

        txtNIMOutput.Text = Str(nim)
        txtNamaOutput.Text = txtNama.Text
        txtProdiOutput.Text = txtProdi.Text

        txtNilaiAkhir.Text = Str(nilaiAkhir)
        If (nilaiAkhir >= 85) Then
            txtNilaiMutu.Text = "A"

        ElseIf (nilaiAkhir >= 75) Then
            txtNilaiMutu.Text = "B"

        ElseIf (nilaiAkhir >= 55) Then
            txtNilaiMutu.Text = "C"

        ElseIf (nilaiAkhir >= 30) Then
            txtNilaiMutu.Text = "D"

        Else
            txtNilaiMutu.Text = "E"
        End If
    End Sub
End Class

