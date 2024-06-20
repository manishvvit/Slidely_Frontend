Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private Const baseUrl As String = "http://localhost:3000" ' Base URL for API

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await FetchSubmission(currentIndex)
    End Sub

    ' Fetch a specific submission based on the index
    Private Async Function FetchSubmission(index As Integer) As Task
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync($"{baseUrl}/read?index={index}")
                response.EnsureSuccessStatusCode()

                Dim submissionJson = Await response.Content.ReadAsStringAsync()
                Dim submissionData As JObject = JObject.Parse(submissionJson)

                If submissionData.ContainsKey("name") Then
                    txtName.Text = submissionData("name").ToString()
                    txtEmail.Text = submissionData("email").ToString()
                    txtPhone.Text = submissionData("phone").ToString()
                    txtGitHub.Text = submissionData("github").ToString()
                    txtStopwatchTime.Text = submissionData("stopwatchTime").ToString()

                    ' Update button states
                    btnPrevious.Enabled = currentIndex > 0
                    btnNext.Enabled = True ' We'll enable Next and handle its click event
                Else
                    MessageBox.Show("Submission not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnNext.Enabled = False
                End If
            End Using
        Catch ex As Exception
            ' Handle no submissions available for the given index
            If ex.Message.Contains("404") Then
                If currentIndex = 0 Then
                    MessageBox.Show("No submissions available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No more submissions available in this direction.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                btnNext.Enabled = False
            Else
                ' General error handling
                MessageBox.Show($"Error fetching submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await FetchSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await FetchSubmission(currentIndex)
    End Sub

    ' Handle keyboard shortcuts for navigation
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            btnPrevious.PerformClick()
        ElseIf e.KeyCode = Keys.Right Then
            btnNext.PerformClick()
        End If
    End Sub

    ' Function to fetch total number of submissions
    Private Async Function FetchTotalSubmissionsCount() As Task(Of Integer)
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync($"{baseUrl}/count")
                response.EnsureSuccessStatusCode()

                Dim countJson = Await response.Content.ReadAsStringAsync()
                Dim countData As JObject = JObject.Parse(countJson)

                ' Assuming countData is an object with a property "count"
                If countData.ContainsKey("count") Then
                    Return Integer.Parse(countData("count").ToString())
                Else
                    Return 0 ' If count property is not found, return 0 or handle accordingly
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching total submissions count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
End Class
