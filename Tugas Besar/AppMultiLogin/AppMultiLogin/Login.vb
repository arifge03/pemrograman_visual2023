Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Login
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Login()
    End Sub

    Private Sub Login()

        ' Set the data you want to send as key-value pairs
        Dim user As String = txtUsername.Text
        Dim passwd As String = txtPassword.Text


        Dim postData As String = $"username={user}&passwd={passwd}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(users_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)
            Dim responseObject As JObject = JObject.Parse(responseBody)
            ' Access the "status" property
            Dim status As String = responseObject("status").ToString()

            ' Access the "message" property
            Dim message As String = responseObject("message").ToString()
            ' Display the response
            MessageBox.Show(responseBody, "Response")
            'MessageBox.Show(status)
            'MessageBox.Show(message)
            If (message = "admin") Then
                admin_role = True
                penyewa_role = False
                login_valid = True
            ElseIf (message = "penyewa") Then
                admin_role = False
                penyewa_role = True
                login_valid = True
            Else
                admin_role = False
                penyewa_role = False
                MessageBox.Show("User tidak dikenal", "Error")
                login_valid = False
            End If
            If (login_valid = True) Then
                Me.Hide()

            End If

        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Registrasi_Click(sender As Object, e As EventArgs) 
        ' Tampilkan form registrasi (FormUser) sebagai dialog modal
        Dim formUser As New FormUser()
        formUser.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class