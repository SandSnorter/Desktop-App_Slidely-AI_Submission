Public Class Form1
    Private Sub ButtonCreateSubmission_Click(sender As Object, e As EventArgs) Handles ButtonCreateSubmission.Click
        CreateNewSubmissionForm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonViewSubmission_Click(sender As Object, e As EventArgs) Handles ButtonViewSubmission.Click
        ViewSubmissionsForm.Show()
        Me.Hide()
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Set KeyPreview to True
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if Ctrl+V is pressed for View Submissions
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ButtonViewSubmission.PerformClick()
        End If

        ' Check if Ctrl+N is pressed for Create Submission
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ButtonCreateSubmission.PerformClick()
        End If
    End Sub

End Class
