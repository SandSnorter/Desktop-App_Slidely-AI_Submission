<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelCreateSubmission = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPhoneNum = New System.Windows.Forms.Label()
        Me.LabelGithubLink = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.TextBoxGithubLink = New System.Windows.Forms.TextBox()
        Me.ButtonToggle = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonSubmitCreateSubmission = New System.Windows.Forms.Button()
        Me.LabelDisplayTimer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelCreateSubmission
        '
        Me.LabelCreateSubmission.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCreateSubmission.AutoSize = True
        Me.LabelCreateSubmission.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCreateSubmission.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCreateSubmission.Location = New System.Drawing.Point(117, 23)
        Me.LabelCreateSubmission.Name = "LabelCreateSubmission"
        Me.LabelCreateSubmission.Size = New System.Drawing.Size(509, 30)
        Me.LabelCreateSubmission.TabIndex = 0
        Me.LabelCreateSubmission.Text = "John Doe, Slidely Task 2 - Create Submission"
        '
        'LabelName
        '
        Me.LabelName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(71, 101)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(62, 24)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Name"
        '
        'LabelEmail
        '
        Me.LabelEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(71, 154)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(57, 24)
        Me.LabelEmail.TabIndex = 2
        Me.LabelEmail.Text = "Email"
        '
        'LabelPhoneNum
        '
        Me.LabelPhoneNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPhoneNum.AutoSize = True
        Me.LabelPhoneNum.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhoneNum.Location = New System.Drawing.Point(36, 217)
        Me.LabelPhoneNum.Name = "LabelPhoneNum"
        Me.LabelPhoneNum.Size = New System.Drawing.Size(141, 24)
        Me.LabelPhoneNum.TabIndex = 3
        Me.LabelPhoneNum.Text = "Phone Number"
        '
        'LabelGithubLink
        '
        Me.LabelGithubLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelGithubLink.AutoSize = True
        Me.LabelGithubLink.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGithubLink.Location = New System.Drawing.Point(12, 276)
        Me.LabelGithubLink.Name = "LabelGithubLink"
        Me.LabelGithubLink.Size = New System.Drawing.Size(201, 24)
        Me.LabelGithubLink.TabIndex = 4
        Me.LabelGithubLink.Text = "Github Link For Task 2"
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(246, 94)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(414, 31)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(246, 152)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(414, 31)
        Me.TextBoxEmail.TabIndex = 6
        '
        'TextBoxPhoneNum
        '
        Me.TextBoxPhoneNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPhoneNum.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhoneNum.Location = New System.Drawing.Point(246, 215)
        Me.TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        Me.TextBoxPhoneNum.Size = New System.Drawing.Size(414, 31)
        Me.TextBoxPhoneNum.TabIndex = 7
        '
        'TextBoxGithubLink
        '
        Me.TextBoxGithubLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGithubLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxGithubLink.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGithubLink.Location = New System.Drawing.Point(246, 274)
        Me.TextBoxGithubLink.Name = "TextBoxGithubLink"
        Me.TextBoxGithubLink.Size = New System.Drawing.Size(414, 31)
        Me.TextBoxGithubLink.TabIndex = 8
        '
        'ButtonToggle
        '
        Me.ButtonToggle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonToggle.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonToggle.Location = New System.Drawing.Point(40, 341)
        Me.ButtonToggle.Name = "ButtonToggle"
        Me.ButtonToggle.Size = New System.Drawing.Size(425, 51)
        Me.ButtonToggle.TabIndex = 9
        Me.ButtonToggle.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.ButtonToggle.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ButtonSubmitCreateSubmission
        '
        Me.ButtonSubmitCreateSubmission.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSubmitCreateSubmission.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonSubmitCreateSubmission.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmitCreateSubmission.Location = New System.Drawing.Point(40, 406)
        Me.ButtonSubmitCreateSubmission.Name = "ButtonSubmitCreateSubmission"
        Me.ButtonSubmitCreateSubmission.Size = New System.Drawing.Size(631, 51)
        Me.ButtonSubmitCreateSubmission.TabIndex = 10
        Me.ButtonSubmitCreateSubmission.Text = "SUBMIT (CTRL + S)"
        Me.ButtonSubmitCreateSubmission.UseVisualStyleBackColor = False
        '
        'LabelDisplayTimer
        '
        Me.LabelDisplayTimer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDisplayTimer.AutoSize = True
        Me.LabelDisplayTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDisplayTimer.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplayTimer.Location = New System.Drawing.Point(525, 354)
        Me.LabelDisplayTimer.Name = "LabelDisplayTimer"
        Me.LabelDisplayTimer.Padding = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.LabelDisplayTimer.Size = New System.Drawing.Size(126, 36)
        Me.LabelDisplayTimer.TabIndex = 11
        Me.LabelDisplayTimer.Text = "00:00:00"
        '
        'CreateNewSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 469)
        Me.Controls.Add(Me.LabelDisplayTimer)
        Me.Controls.Add(Me.ButtonSubmitCreateSubmission)
        Me.Controls.Add(Me.ButtonToggle)
        Me.Controls.Add(Me.TextBoxGithubLink)
        Me.Controls.Add(Me.TextBoxPhoneNum)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelGithubLink)
        Me.Controls.Add(Me.LabelPhoneNum)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelCreateSubmission)
        Me.Name = "CreateNewSubmissionForm"
        Me.Text = "Create New Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCreateSubmission As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelGithubLink As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxGithubLink As TextBox
    Friend WithEvents ButtonToggle As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonSubmitCreateSubmission As Button
    Friend WithEvents LabelDisplayTimer As Label
End Class
