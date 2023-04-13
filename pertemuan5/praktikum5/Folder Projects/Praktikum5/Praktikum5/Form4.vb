Public Class Form4
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeNegara.Text
            Case "AE" : txtKeterangan.Text = "United Arab Emirates"

            Case "JP" : txtKeterangan.Text = "Japan"

            Case "ID" : txtKeterangan.Text = "Indonesia"

            Case "US" : txtKeterangan.Text = "United States"

            Case Else : txtKeterangan.Text = "Kode Negara tidak ditemukan"
        End Select
    End Sub
End Class