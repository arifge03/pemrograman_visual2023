Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class FormKamar

    Private selectedUserId As String = ""
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nama_kamar As String = txtNMKAMAR.Text
        Dim jenis_kamar As String = txtJENISKAMAR.Text
        Dim harga As String = txtHARGA.Text

        Dim postData As String = $"nama_kamar={nama_kamar}&jenis_kamar={jenis_kamar}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(kamar_api, "POST", byteArray)

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
        Dim nama_kamar As String = txtNMKAMAR.Text
        Dim jenis_kamar As String = txtJENISKAMAR.Text
        Dim harga As String = txtHARGA.Text

        Dim postData As String = $"nama_kamar={nama_kamar}&jenis_kamar={jenis_kamar}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(kamar_api & "?nama_kamar=" & txtNMKAMAR.Text, "PUT", byteArray)

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
        Dim nama_kamar As String = txtNMKAMAR.Text
        Dim jenis_kamar As String = txtJENISKAMAR.Text
        Dim harga As String = txtHARGA.Text

        Dim postData As String = $"nama_kamar={nama_kamar}&jenis_kamar={jenis_kamar}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(kamar_api & "?nama_kamar=" & txtNMKAMAR.Text, "DELETE", byteArray)

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

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(kamar_api & "?nama_kamar=" & txtNMKAMAR.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        kamar_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        kamar_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (kamar_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Kamar) = JsonConvert.DeserializeObject(Of List(Of Kamar))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Kamar In data
                            txtNMKAMAR.Text = mydata.nama_kamar
                            txtJENISKAMAR.Text = mydata.jenis_kamar
                            txtHARGA.Text = mydata.harga
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
        txtNMKAMAR.Clear()
        txtJENISKAMAR.Clear()
        txtHARGA.Clear()
        Reloaded()
        txtNMKAMAR.Focus()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (kamar_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (kamar_baru = False) Then
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

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(kamar_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Kamar) = JsonConvert.DeserializeObject(Of List(Of Kamar))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNMKAMAR.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvData.Rows.Count Then
            selectedUserId = dgvData.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class