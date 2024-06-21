Imports System.Net.Http
Imports System.Text.Json
'Imports Newtonsoft.Json.Linq
Public Class ViewSubmissionsForm
    ' Define classes for deserialization
    Public Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github As String
    End Class

    Public Class SubmissionsResponse
        Public Property submissions As List(Of Submission)
    End Class

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = -1 ' Index to keep track of current submission

    Private Async Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create HttpClient instance
        Dim httpClient As New HttpClient()

        ' Specify the base URL of the server
        httpClient.BaseAddress = New Uri("http://localhost:3000") ' Update with your server address

        Try
            ' Make GET request to the server
            Dim response As HttpResponseMessage = Await httpClient.GetAsync("/read")

            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize JSON to object
                Dim submissionsResponse As SubmissionsResponse = JsonSerializer.Deserialize(Of SubmissionsResponse)(responseContent)

                ' Assign submissions list
                submissions = submissionsResponse.submissions

                ' Initialize to display the first submission
                ShowSubmission(currentIndex + 1) ' Start with the first submission (+1 because currentIndex starts from -1)
            Else
                MessageBox.Show("Failed to retrieve data from the server. StatusCode: " & response.StatusCode)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Set KeyPreview to True
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if Ctrl+N to go to next submission
        If e.Control AndAlso e.KeyCode = Keys.N Then
            NextButton.PerformClick()
        End If

        ' Check if Ctrl+P to go to previous submission
        If e.Control AndAlso e.KeyCode = Keys.P Then
            PreviousButton.PerformClick()
        End If
    End Sub
    Private Sub ShowSubmission(index As Integer)
        ' Display submission details in textboxes
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            TextBoxName.Text = submission.name
            TextBoxEmail.Text = submission.email
            TextBoxPhoneNum.Text = submission.phone
            TextBoxGithubLink.Text = submission.github
        End If
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' Display the next submission
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        ' Display the previous submission
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub
End Class