Imports System.Globalization 'Fungsi mengimport format currency'

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProdi.Items.Clear() 'Fungsi untuk menghapus item yang ada di dalam combobox ketika form dijalankan'
        cmbProdi.Items.Add("Teknik Informatika") 'Fungsi untuk menambah item di dalam combobox'
        cmbProdi.Items.Add("Teknik Industri")
        cmbProdi.Items.Add("Akuntansi")
    End Sub

    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        If cmbProdi.Text = "Teknik Informatika" Then 'Jika prodi dipilih Teknik Informatika'
            txtJenjang.Text = "S1 dan D3"
            txtBiaya.Text = "400000"
            txtBayar.Clear() 'Fungsi untuk menghapus isi kolom Bayar'
            txtKembalian.Clear()
        ElseIf cmbProdi.Text = "Teknik Industri" Then 'Jika prodi dipilih Teknik Informatika'
            txtJenjang.Text = "S1 dan D3"
            txtBiaya.Text = "450000"
            txtBayar.Clear() 'Fungsi untuk menghapus isi kolom Bayar'
            txtKembalian.Clear()
        ElseIf cmbProdi.Text = "Akuntansi" Then 'Jika prodi dipilih Teknik Informatika'
            txtJenjang.Text = "S1"
            txtBiaya.Text = "500000"
            txtBayar.Clear() 'Fungsi untuk menghapus isi kolom Bayar'
            txtKembalian.Clear()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Kembalian As Integer
        Kembalian = Val(txtBayar.Text) - Val(txtBiaya.Text) 'Fungsi Perhitungan Kembalian' 
        txtKembalian.Text = Kembalian.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) 'Fungsi menampilkan kembalian dalam format Rupiah atau Rp'
    End Sub
End Class
