Imports MySql.Data.MySqlClient

Module MyMod
    Public myCommand As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter
    Public myData As New DataTable
    Public DR As MySqlDataReader
    Public SQL As String
    Public conn As New MySqlConnection

    Public mahasiswa_baru As Boolean
    Public oMahasiswa As New Mahasiswa

    Public Sub DBConnect()
        conn.ConnectionString = "server=localhost;" &
        "user id=root;" &
        "password=;" &
        "database=dbakademik"
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If (conn.State = ConnectionState.Open) Then
            Else
                MessageBox.Show("Sorry not connected.")
            End If
        End Try
    End Sub

    Public Sub DBDisconnect()

        If (conn.State = ConnectionState.Open) Then
            conn.Close()
            conn.Dispose()
        End If
    End Sub

End Module
