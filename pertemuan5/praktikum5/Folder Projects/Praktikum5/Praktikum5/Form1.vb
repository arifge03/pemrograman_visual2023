Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtTotalBelanja.Text) >= 100000) Then
            txtKeterangan.Text = "Selamat, Anda dapat hadiah!"
        Else
            txtKeterangan.Text = "Terima kasih sudah berbelanja"
        End If
    End Sub
End Class
