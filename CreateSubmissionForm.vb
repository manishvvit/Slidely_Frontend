Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero
    Private stopwatchTimer As Timer
    Private Const BASE_URL As String = "http://localhost:3000"

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize stopwatch timer
        stopwatchTimer = New Timer()
        AddHandler stopwatchTimer.Tick, AddressOf UpdateStopwatch
        stopwatchTimer.Interval = 1000 ' 1 second

        ' Set the form's key preview to true to handle key events
        Me.KeyPreview = True
    End Sub

    ' Toggle the stopwatch on button click
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatchTimer.Stop()
            btnToggleStopwatch.Text = "Resume Stopwatch"
        Else
            stopwatchTimer.Start()
            btnToggleStopwatch.Text = "Pause Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    ' Update the stopwatch display
    Private Sub UpdateStopwatch()
        If stopwatchRunning Then
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
            lblStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    ' Handle the form submission
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
           String.IsNullOrWhiteSpace(txtGithub.Text) Then
            MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create submission object
        Dim submission As New FormSubmission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github = txtGithub.Text,
            .stopwatchTime = stopwatchTime.ToString("hh\:mm\:ss")
        }

        ' Submit the form data to the backend
        Await SubmitSubmissionAsync(submission)
    End Sub

    ' Asynchronous method to submit the form data to the backend
    Private Async Function SubmitSubmissionAsync(submission As FormSubmission) As Task
        Try
            ' Create a new HttpClient instance
            Using client As New HttpClient()
                ' Serialize the submission object to JSON
                Dim jsonBody As String = JsonConvert.SerializeObject(submission)
                ' Create a StringContent object to send the JSON data
                Dim content As New StringContent(jsonBody, Encoding.UTF8, "application/json")

                ' Send the POST request to the /submit endpoint
                Dim response = Await client.PostAsync($"{BASE_URL}/submit", content)

                ' Check the response status
                If response.IsSuccessStatusCode Then
                    Dim responseJson As String = Await response.Content.ReadAsStringAsync()
                    Dim responseData As SubmitResponse = JsonConvert.DeserializeObject(Of SubmitResponse)(responseJson)

                    MessageBox.Show($"Submission saved successfully! Submission ID: {responseData.submissionId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm() ' Clear the form after successful submission
                Else
                    Dim errorMsg = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Error saving submission: {response.StatusCode} - {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Show any errors that occur during the API call
            MessageBox.Show($"An error occurred during submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' Handle keyboard shortcuts for form submission
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    ' Clear all form fields
    Private Sub ClearForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithub.Text = ""
        lblStopwatch.Text = "00:00:00"
        stopwatchTime = TimeSpan.Zero
    End Sub
End Class

' Define the FormSubmission class used to hold the form data
Public Class FormSubmission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github As String
    Public Property stopwatchTime As String
End Class

' Define a class to deserialize the submission response
Public Class SubmitResponse
    Public Property submissionId As Integer ' Adjust the type based on your actual response structure
End Class
