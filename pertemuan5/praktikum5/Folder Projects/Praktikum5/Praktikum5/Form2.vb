Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtUmur.Text) <= 10) Then
            txtKeterangan.Text = "Anak-anak"

        ElseIf (txtUmur.Text <= 18) Then
            txtKeterangan.Text = "Remaja"

        ElseIf (txtUmur.Text <= 35) Then
            txtKeterangan.Text = "Dewasa"

        Else
            txtKeterangan.Text = "Parubaya"
        End If
    End Sub
End Class