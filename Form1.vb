Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1
    Private Const BASE_URL As String = "http://localhost:3000"

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub


    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set keyboard shortcuts
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        End If
    End Sub

    Private Async Sub SubmitSubmissionAsync(submission As FormSubmission)
        Try
            Using client As New HttpClient()
                Dim jsonBody As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(jsonBody, Encoding.UTF8, "application/json")

                Dim response = Await client.PostAsync($"{BASE_URL}/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"Error saving submission: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
