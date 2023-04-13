Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Anda mendapat bonus berupa mobil"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Anda mendapat bonus motor"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Anda mendapat bonus sepeda"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat bonus parcel lebaran"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class