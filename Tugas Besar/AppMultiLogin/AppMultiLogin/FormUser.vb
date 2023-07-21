Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Imports System.Security.Cryptography
Public Class FormUser
    Private selectedUserId As String = ""

    Private Function GetMd5Hash(input As String) As String
        ' Create a new instance of the MD5CryptoServiceProvider class
        Dim md5Hasher As New MD5CryptoServiceProvider()

        ' Convert the input string to a byte array and compute the hash
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))

        ' Create a new StringBuilder to collect the bytes
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data and format each one as a hexadecimal string
        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next

        ' Return the hexadecimal string
        Return sBuilder.ToString()
    End Function
    Private Sub TambahData()
        Dim username As String = txtUSERNAME.Text
        Dim passwd As String = GetMd5Hash(txtPSSWD.Text) ' Enkripsi password dengan MD5
        Dim rolename As String
        If rbAdmin.Checked Then
            rolename = "admin"
        ElseIf rbPenyewa.Checked Then
            rolename = "penyewa"
        Else
            MessageBox.Show("Please select a role.")
            Return
        End If

        Dim postData As String = $"username={username}&passwd={passwd}&rolename={rolename}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(user_api, "POST", byteArray)

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
        Dim username As String = txtUSERNAME.Text
        Dim passwd As String = GetMd5Hash(txtPSSWD.Text) ' Enkripsi password dengan MD5
        Dim rolename As String
        If rbAdmin.Checked Then
            rolename = "admin"
        ElseIf rbPenyewa.Checked Then
            rolename = "penyewa"
        Else
            MessageBox.Show("Please select a role.")
            Return
        End If

        Dim postData As String = $"username={username}&passwd={passwd}&rolename={rolename}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(user_api & "?username=" & txtUSERNAME.Text, "PUT", byteArray)

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
        Dim username As String = txtUSERNAME.Text
        Dim passwd As String = GetMd5Hash(txtPSSWD.Text) ' Enkripsi password dengan MD5
        Dim rolename As String
        If rbAdmin.Checked Then
            rolename = "admin"
        ElseIf rbPenyewa.Checked Then
            rolename = "penyewa"
        Else
            MessageBox.Show("Please select a role.")
            Return
        End If

        Dim postData As String = $"username={username}&passwd={passwd}&rolename={rolename}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(user_api & "?username=" & txtUSERNAME.Text, "DELETE", byteArray)

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
            Dim response As HttpResponseMessage = client.GetAsync(user_api & "?username=" & txtUSERNAME.Text).Result

            If response.IsSuccessStatusCode Then
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If jsonString = "[]" Then
                        user_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        user_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If user_baru = False Then
                        Dim data As List(Of Users) = JsonConvert.DeserializeObject(Of List(Of Users))(jsonString)

                        For Each mydata As Users In data
                            txtUSERNAME.Text = mydata.username
                            txtPSSWD.Text = mydata.passwd
                            If mydata.rolename = "admin" Then
                                rbAdmin.Checked = True
                            ElseIf mydata.rolename = "penyewa" Then
                                rbPenyewa.Checked = True
                            End If
                        Next
                    End If
                End Try
            Else
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")
            End If
        End Using
    End Sub

    Private Sub GetClear()
        txtUSERNAME.Clear()
        txtPSSWD.Clear()
        rbAdmin.Checked = False
        rbPenyewa.Checked = False
        Reloaded()
        txtUSERNAME.Focus()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (user_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (user_baru = False) Then
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
        Dim response As String = client.DownloadString(user_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Users) = JsonConvert.DeserializeObject(Of List(Of Users))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUSERNAME.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvData.Rows.Count Then
            selectedUserId = dgvData.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub rbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdmin.CheckedChanged

    End Sub
End Class