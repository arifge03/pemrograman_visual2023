Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeJabatan.Text
            Case "MGR" : txtKeterangan.Text = "Manager"

            Case "SKR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub
End Class