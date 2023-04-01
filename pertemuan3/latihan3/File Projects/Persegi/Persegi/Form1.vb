Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, luas, keliling As Integer

        sisi = Val(txtSisi.Text)

        luas = sisi * sisi
        keliling = sisi * 4

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtJari_TextChanged(sender As Object, e As EventArgs) Handles txtSisi.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
