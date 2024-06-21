Imports System.Reflection.Emit
Imports System.Diagnostics
Imports System.Net.Mail
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net.Http
Imports System.Text.Json

Public Class CreateNewSubmissionForm
    Dim stopwatch As New Stopwatch()
    Dim isRunning As Boolean = False
    Private Sub UpdateStopwatch()
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        LabelDisplayTimer.Text = String.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds)
    End Sub

    Private Sub ButtonToggle_Click(sender As Object, e As EventArgs) Handles ButtonToggle.Click
        If isRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        Else
            If stopwatch.ElapsedTicks > 0 Then
                stopwatch.Start()
                Timer1.Start()
            Else
                stopwatch.Reset()
                stopwatch.Start()
                Timer1.Start()
            End If
        End If

        isRunning = Not isRunning
        ButtonToggle.Text = If(isRunning, "TOGGLE STOPWATCH (CTRL + T)", "TOGGLE STOPWATCH (CTRL + T)")
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Set KeyPreview to True
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if Ctrl+T to toggle stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ButtonToggle.PerformClick()
        End If

        ' Check if Ctrl+S to submit the form
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ButtonSubmitCreateSubmission.PerformClick()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateStopwatch()
    End Sub

    Private Function ValidateInput() As Boolean
        Dim isValid As Boolean = True

        ' Check if Name is empty
        If String.IsNullOrWhiteSpace(TextBoxName.Text) Then
            MessageBox.Show("Please enter a valid Name.", "Error")
            isValid = False
        End If

        ' Check if Email is in a valid format
        If Not IsValidEmail(TextBoxEmail.Text) Then
            MessageBox.Show("Please enter a valid Email address.", "Error")
            isValid = False
        End If

        ' Check if Phone Number is in a valid format
        Dim phoneRegex As New Regex("^\d{10}$")
        If Not phoneRegex.IsMatch(TextBoxPhoneNum.Text) Then
            MessageBox.Show("Please enter a 10-digit Phone Number.", "Error")
            isValid = False
        End If

        ' Add any additional validation logic here

        Return isValid
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New MailAddress(email)
            Return True
        Catch ex As FormatException
            Return False
        End Try
    End Function

    Private Async Sub ButtonSubmitCreateSubmission_Click(sender As Object, e As EventArgs) Handles ButtonSubmitCreateSubmission.Click
        ' Get the values from the textboxes
        Dim name As String = TextBoxName.Text
        Dim email As String = TextBoxEmail.Text
        Dim phone As String = TextBoxPhoneNum.Text
        Dim github As String = TextBoxGithubLink.Text

        ' Create the JSON data to be sent to the server
        Dim jsonData As String = JsonSerializer.Serialize(New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github = github
        })

        ' Validate the input
        If ValidateInput() Then
            ' Send the data to the backend for processing
            Dim httpClient As New HttpClient()
            httpClient.BaseAddress = New Uri("http://localhost:3000") ' Update with your server address

            Dim content As New StringContent(jsonData, System.Text.Encoding.UTF8, "application/json")
            ' Send POST request to the server
            Dim response = Await httpClient.PostAsync("/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data submitted successfully!")
                TextBoxName.Text = ""
                TextBoxEmail.Text = ""
                TextBoxPhoneNum.Text = ""
                TextBoxGithubLink.Text = ""
            Else
                MessageBox.Show("Error submitting data to the server.")
            End If
        End If

    End Sub
End Class