Imports System.Globalization 'Funngsi mengimport Format Currency'

Public Class Form1
    Private Sub btnTotalHarga_Click(sender As Object, e As EventArgs) Handles btnTotalHarga.Click
        Dim gbTiketMasuk As Decimal
        Dim gbMember As Decimal
        Dim Total As Decimal

        If rbAnak.Checked = True Then
            gbTiketMasuk = 20000
        ElseIf rbDewasa.Checked = True Then
            gbTiketMasuk = 40000
        End If

        If cbBukanMember.Checked = True Then
            gbMember = 0
        End If

        If cbMember.Checked = True Then
            gbMember = (gbTiketMasuk * 10 / 100)
        End If

        Total = gbTiketMasuk - gbMember

        txtTotal.Text = Total.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) 'Fungsi menampilkan output currency dalam format Rupuah atau Rp'
    End Sub
End Class
