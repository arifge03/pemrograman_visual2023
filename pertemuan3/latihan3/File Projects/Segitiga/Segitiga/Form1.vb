Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim alas, tinggi, sisia, sisib, sisic, luas, keliling As Integer

        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)
        sisia = Val(txtSisia.Text)
        sisib = Val(txtSisib.Text)
        sisic = Val(txtSisic.Text)

        luas = 1 / 2 * alas * tinggi
        keliling = sisia + sisib + sisic

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs) Handles txtSisia.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
