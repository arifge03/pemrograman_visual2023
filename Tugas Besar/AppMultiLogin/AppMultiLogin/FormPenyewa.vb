Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class FormPenyewa

    Private selectedUserId As String = ""
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nama_penyewa As String = txtNMPENYEWA.Text
        Dim telepon As String = txtTELEPON.Text
        Dim id_kamar As String = txtIDKAMAR.Text
        Dim harga As String = txtHARGA.Text
        Dim tanggal_checkin As String = txtMASUK.Text
        Dim tanggal_checkout As String = txtKELUAR.Text
        Dim jumlah_malam As String = txtJUMBLAHMALAM.Text
        Dim total_biaya As String = txtTOTALBIAYA.Text

        Dim postData As String = $"nama_penyewa={nama_penyewa}&telepon={telepon}&id_kamar={id_kamar}&harga={harga}&tanggal_checkin={tanggal_checkin}&tanggal_checkout={tanggal_checkout}&jumlah_malam={jumlah_malam}&total_biaya={total_biaya}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(penyewa_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()
        ' Set the data you want to send as key-value pairs
        Dim nama_penyewa As String = txtNMPENYEWA.Text
        Dim telepon As String = txtTELEPON.Text
        Dim id_kamar As String = txtIDKAMAR.Text
        Dim harga As String = txtHARGA.Text
        Dim tanggal_checkin As String = txtMASUK.Text
        Dim tanggal_checkout As String = txtKELUAR.Text
        Dim jumlah_malam As String = txtJUMBLAHMALAM.Text
        Dim total_biaya As String = txtTOTALBIAYA.Text

        Dim postData As String = $"nama_penyewa={nama_penyewa}&telepon={telepon}&id_kamar={id_kamar}&harga={harga}&tanggal_checkin={tanggal_checkin}&tanggal_checkout={tanggal_checkout}&jumlah_malam={jumlah_malam}&total_biaya={total_biaya}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(penyewa_api & "?nama_penyewa=" & txtNMPENYEWA.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()
        ' Set the data you want to send as key-value pairs
        Dim nama_penyewa As String = txtNMPENYEWA.Text
        Dim telepon As String = txtTELEPON.Text
        Dim id_kamar As String = txtIDKAMAR.Text
        Dim harga As String = txtHARGA.Text
        Dim tanggal_checkin As String = txtMASUK.Text
        Dim tanggal_checkout As String = txtKELUAR.Text
        Dim jumlah_malam As String = txtJUMBLAHMALAM.Text
        Dim total_biaya As String = txtTOTALBIAYA.Text

        Dim postData As String = $"nama_penyewa={nama_penyewa}&telepon={telepon}&id_kamar={id_kamar}&harga={harga}&tanggal_checkin={tanggal_checkin}&tanggal_checkout={tanggal_checkout}&jumlah_malam={jumlah_malam}&total_biaya={total_biaya}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(penyewa_api & "?nama_penyewa=" & txtNMPENYEWA.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub txtJUMBLAHMALAM_TextChanged(sender As Object, e As EventArgs) Handles txtJUMBLAHMALAM.TextChanged
        CalculateTotalBiaya()
        CalculateDates()
    End Sub

    Private Sub txtHARGA_TextChanged(sender As Object, e As EventArgs) Handles txtHARGA.TextChanged
        CalculateTotalBiaya()
    End Sub

    Private Sub CalculateDates()
        ' Get the data from the textboxes
        Dim jumlah_malam As Integer

        If Integer.TryParse(txtJUMBLAHMALAM.Text, jumlah_malam) Then
            ' Calculate the tanggal_checkin and set it to txtMASUK.Text
            Dim tanggal_checkin As Date = Date.Now
            txtMASUK.Text = tanggal_checkin.ToString("yyyy-MM-dd")

            ' Calculate the tanggal_checkout and set it to txtKELUAR.Text
            Dim tanggal_checkout As Date = tanggal_checkin.AddDays(jumlah_malam)
            txtKELUAR.Text = tanggal_checkout.ToString("yyyy-MM-dd")
        End If
    End Sub

    Private Sub CalculateTotalBiaya()
        ' Get the data from the textboxes
        Dim harga As Integer
        Dim jumlah_malam As Integer

        If Integer.TryParse(txtHARGA.Text, harga) AndAlso Integer.TryParse(txtJUMBLAHMALAM.Text, jumlah_malam) Then
            ' Calculate the total_biaya
            Dim total_biaya As Integer = harga * jumlah_malam

            ' Display the calculated total_biaya in the txtTOTALBIAYA textbox
            txtTOTALBIAYA.Text = total_biaya.ToString()
        End If
    End Sub






    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(penyewa_api & "?nama_penyewa=" & txtNMPENYEWA.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        penyewa_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        penyewa_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (penyewa_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Penyewa) = JsonConvert.DeserializeObject(Of List(Of Penyewa))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Penyewa In data
                            txtNMPENYEWA.Text = mydata.nama_penyewa
                            txtTELEPON.Text = mydata.telepon
                            txtIDKAMAR.Text = mydata.id_kamar
                            txtHARGA.Text = mydata.harga
                            txtMASUK.Text = mydata.tanggal_checkin
                            txtKELUAR.Text = mydata.tanggal_checkout
                            txtJUMBLAHMALAM.Text = mydata.jumlah_malam
                            txtTOTALBIAYA.Text = mydata.total_biaya
                        Next
                    End If

                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub GetClear()
        txtNMPENYEWA.Clear()
        txtTELEPON.Clear()
        txtIDKAMAR.Clear()
        txtNMKAMAR.Clear()
        txtHARGA.Clear()
        txtIDKAMAR.Clear()
        txtMASUK.Clear()
        txtKELUAR.Clear()
        txtJUMBLAHMALAM.Clear()
        txtTOTALBIAYA.Clear()
        Reloaded()
        txtNMPENYEWA.Focus()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (penyewa_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (penyewa_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub txtIDKAMAR_TextChanged(sender As Object, e As EventArgs) Handles txtIDKAMAR.TextChanged
        ' Use the provided ID to search for the corresponding room (nama_kamar) and its price (harga)
        Dim id_kamar As String = txtIDKAMAR.Text
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(kamar_api & "?id_kamar=" & id_kamar).Result
            If response.IsSuccessStatusCode Then
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    Dim data As List(Of Kamar) = JsonConvert.DeserializeObject(Of List(Of Kamar))(jsonString)
                    If data.Count > 0 Then
                        ' Found a matching room based on the ID
                        Dim room As Kamar = data(0)
                        txtNMKAMAR.Text = room.nama_kamar
                        txtHARGA.Text = room.harga
                    Else
                        ' Room not found with the provided ID
                        txtNMKAMAR.Clear()
                        txtHARGA.Clear()
                    End If
                Catch ex As Exception
                    ' Handle any errors that occur during JSON deserialization
                    MessageBox.Show("An error occurred while processing the response.", "Error")
                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Error")
            End If
        End Using
    End Sub



    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(penyewa_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Penyewa) = JsonConvert.DeserializeObject(Of List(Of Penyewa))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNMPENYEWA.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub


    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvData.Rows.Count Then
            selectedUserId = dgvData.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
    End Sub
End Class