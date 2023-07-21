Public Class Form1
    Private Sub Admin1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Admin1ToolStripMenuItem.Click
        FormKamar.ShowDialog()
    End Sub

    Private Sub Dosen1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Dosen1ToolStripMenuItem.Click
        FormPenyewa.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatikanSemuaMenu()

    End Sub

    Private Sub MatikanSemuaMenu()
        MenuAdminBar.Visible = False
        MenuPenyewa.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        LoginForm.ShowDialog()

    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            MenuPenyewa.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah Penyewa
        If (Penyewa_role = True) Then
            MenuAdminBar.Visible = False
            MenuPenyewa.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub

    Private Sub MenuAdminBar_Click(sender As Object, e As EventArgs) Handles MenuAdminBar.Click

    End Sub

    Private Sub MenuDosenBar_Click(sender As Object, e As EventArgs) Handles MenuPenyewa.Click

    End Sub
End Class
