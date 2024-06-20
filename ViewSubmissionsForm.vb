Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Text

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
                    btnNext.Enabled = True
                    btnEdit.Enabled = True
                    btnDelete.Enabled = True
                Else
                    MessageBox.Show("Submission not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnNext.Enabled = False
                    btnEdit.Enabled = False
                    btnDelete.Enabled = False
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
                btnEdit.Enabled = False
                btnDelete.Enabled = False
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

    ' Edit the current submission
    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Using client As New HttpClient()
                Dim updatedSubmission As New JObject From {
                    {"name", txtName.Text},
                    {"email", txtEmail.Text},
                    {"phone", txtPhone.Text},
                    {"github", txtGitHub.Text},
                    {"stopwatchTime", txtStopwatchTime.Text}
                }

                ' Use System.Text.Encoding.UTF8 for encoding
                Dim content = New StringContent(updatedSubmission.ToString(), Encoding.UTF8, "application/json")
                Dim response = Await client.PutAsync($"{baseUrl}/edit?index={currentIndex}", content)
                response.EnsureSuccessStatusCode()

                MessageBox.Show("Submission updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete the current submission
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Using client As New HttpClient()
                Dim response = Await client.DeleteAsync($"{baseUrl}/delete?index={currentIndex}")
                response.EnsureSuccessStatusCode()

                MessageBox.Show("Submission deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' After deletion, try to fetch the next submission or previous if at the end
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await FetchSubmission(currentIndex)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
