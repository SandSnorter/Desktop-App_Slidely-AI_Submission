<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LabelFormsApp = New System.Windows.Forms.Label()
        Me.ButtonViewSubmission = New System.Windows.Forms.Button()
        Me.ButtonCreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelFormsApp
        '
        Me.LabelFormsApp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFormsApp.AutoSize = True
        Me.LabelFormsApp.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormsApp.Location = New System.Drawing.Point(114, 133)
        Me.LabelFormsApp.Name = "LabelFormsApp"
        Me.LabelFormsApp.Size = New System.Drawing.Size(503, 30)
        Me.LabelFormsApp.TabIndex = 0
        Me.LabelFormsApp.Text = "John Doe, Slidely Task 2 - Slidely Forms App"
        '
        'ButtonViewSubmission
        '
        Me.ButtonViewSubmission.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonViewSubmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonViewSubmission.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonViewSubmission.Location = New System.Drawing.Point(69, 217)
        Me.ButtonViewSubmission.Name = "ButtonViewSubmission"
        Me.ButtonViewSubmission.Size = New System.Drawing.Size(579, 56)
        Me.ButtonViewSubmission.TabIndex = 1
        Me.ButtonViewSubmission.Text = "VIEW SUBMISSION (CTRL + V)"
        Me.ButtonViewSubmission.UseVisualStyleBackColor = False
        '
        'ButtonCreateSubmission
        '
        Me.ButtonCreateSubmission.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCreateSubmission.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonCreateSubmission.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreateSubmission.Location = New System.Drawing.Point(69, 291)
        Me.ButtonCreateSubmission.Name = "ButtonCreateSubmission"
        Me.ButtonCreateSubmission.Size = New System.Drawing.Size(579, 60)
        Me.ButtonCreateSubmission.TabIndex = 2
        Me.ButtonCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.ButtonCreateSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 455)
        Me.Controls.Add(Me.ButtonCreateSubmission)
        Me.Controls.Add(Me.ButtonViewSubmission)
        Me.Controls.Add(Me.LabelFormsApp)
        Me.Name = "Form1"
        Me.Text = "Form Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelFormsApp As Label
    Friend WithEvents ButtonViewSubmission As Button
    Friend WithEvents ButtonCreateSubmission As Button
End Class
