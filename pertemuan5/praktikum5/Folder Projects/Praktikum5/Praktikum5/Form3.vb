Public Class Form3
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeGelar.Text
            Case "Dr" : txtKeterangan.Text = "Doktor, merupakan gelar S3"

            Case "M" : txtKeterangan.Text = "Magister, merupakan gelar S2"

            Case Else : txtKeterangan.Text = "Sarjana, merupakan gelar S1"
        End Select
    End Sub
End Class