<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelVIewSubmissions = New System.Windows.Forms.Label()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPhoneNum = New System.Windows.Forms.Label()
        Me.LabelGithubLink = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.TextBoxGithubLink = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelVIewSubmissions
        '
        Me.LabelVIewSubmissions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVIewSubmissions.AutoSize = True
        Me.LabelVIewSubmissions.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVIewSubmissions.Location = New System.Drawing.Point(154, 9)
        Me.LabelVIewSubmissions.Name = "LabelVIewSubmissions"
        Me.LabelVIewSubmissions.Size = New System.Drawing.Size(501, 30)
        Me.LabelVIewSubmissions.TabIndex = 0
        Me.LabelVIewSubmissions.Text = "John Doe, Slidely Task 2 - View Submissions"
        '
        'PreviousButton
        '
        Me.PreviousButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviousButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PreviousButton.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousButton.Location = New System.Drawing.Point(100, 363)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(248, 47)
        Me.PreviousButton.TabIndex = 1
        Me.PreviousButton.Text = "PREVIOUS (CTRL + P)"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NextButton.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(424, 363)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(248, 47)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "NEXT (CTRL + N)"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(67, 83)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(62, 24)
        Me.LabelName.TabIndex = 3
        Me.LabelName.Text = "Name"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(72, 150)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(57, 24)
        Me.LabelEmail.TabIndex = 4
        Me.LabelEmail.Text = "Email"
        '
        'LabelPhoneNum
        '
        Me.LabelPhoneNum.AutoSize = True
        Me.LabelPhoneNum.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoneNum.Location = New System.Drawing.Point(39, 219)
        Me.LabelPhoneNum.Name = "LabelPhoneNum"
        Me.LabelPhoneNum.Size = New System.Drawing.Size(141, 24)
        Me.LabelPhoneNum.TabIndex = 5
        Me.LabelPhoneNum.Text = "Phone Number"
        '
        'LabelGithubLink
        '
        Me.LabelGithubLink.AutoSize = True
        Me.LabelGithubLink.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGithubLink.Location = New System.Drawing.Point(12, 289)
        Me.LabelGithubLink.Name = "LabelGithubLink"
        Me.LabelGithubLink.Size = New System.Drawing.Size(201, 24)
        Me.LabelGithubLink.TabIndex = 6
        Me.LabelGithubLink.Text = "Github Link For Task 2"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(235, 80)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(490, 31)
        Me.TextBoxName.TabIndex = 7
        '
        'TextBoxPhoneNum
        '
        Me.TextBoxPhoneNum.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhoneNum.Location = New System.Drawing.Point(235, 219)
        Me.TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        Me.TextBoxPhoneNum.ReadOnly = True
        Me.TextBoxPhoneNum.Size = New System.Drawing.Size(490, 31)
        Me.TextBoxPhoneNum.TabIndex = 8
        '
        'TextBoxGithubLink
        '
        Me.TextBoxGithubLink.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGithubLink.Location = New System.Drawing.Point(235, 286)
        Me.TextBoxGithubLink.Name = "TextBoxGithubLink"
        Me.TextBoxGithubLink.ReadOnly = True
        Me.TextBoxGithubLink.Size = New System.Drawing.Size(490, 31)
        Me.TextBoxGithubLink.TabIndex = 9
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(235, 147)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.ReadOnly = True
        Me.TextBoxEmail.Size = New System.Drawing.Size(490, 31)
        Me.TextBoxEmail.TabIndex = 10
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxGithubLink)
        Me.Controls.Add(Me.TextBoxPhoneNum)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelGithubLink)
        Me.Controls.Add(Me.LabelPhoneNum)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.LabelVIewSubmissions)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVIewSubmissions As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelGithubLink As Label
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxGithubLink As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxName As TextBox
End Class
