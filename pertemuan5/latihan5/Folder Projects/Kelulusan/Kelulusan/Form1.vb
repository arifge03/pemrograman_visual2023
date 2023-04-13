Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNilaiAKhir_TextChanged(sender As Object, e As EventArgs) Handles txtNilaiAKhir.TextChanged

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtNilaiAKhir.Text) >= 60) Then
            txtKeterangan.Text = "Anda Lulus"
        Else
            txtKeterangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub
End Class
