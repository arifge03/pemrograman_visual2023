Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Private Sub Reload()
        oMahasiswa.getAllData(DataGridView1)
    End Sub
    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIM.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMahasiswa.Carimahasiswa(txtNIM.Text)
            If (mahasiswa_baru = False) Then
                TampilMahasiswa()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub TampilMahasiswa()
        txtNIM.Text = oMahasiswa.nim
        txtNama.Text = oMahasiswa.nama
        txtJK.Text = oMahasiswa.jk
        txtProdi.Text = oMahasiswa.prodi
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub
    Private Sub ClearEntry()
        txtNIM.Clear()
        txtNama.Clear()
        txtJK.Clear()
        txtProdi.Clear()
    End Sub
End Class
