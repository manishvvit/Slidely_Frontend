<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithub = New Label()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        lblStopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(253, 73)
        txtName.Name = "txtName"
        txtName.Size = New Size(272, 35)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(253, 126)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(272, 35)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(253, 179)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(272, 35)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithub
        ' 
        txtGithub.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGithub.Location = New Point(253, 231)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(272, 35)
        txtGithub.TabIndex = 3
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(151, 76)
        lblName.Name = "lblName"
        lblName.Size = New Size(82, 27)
        lblName.TabIndex = 4
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(151, 129)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(79, 27)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(151, 183)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(89, 27)
        lblPhone.TabIndex = 6
        lblPhone.Text = "Phone:"
        ' 
        ' lblGithub
        ' 
        lblGithub.AutoSize = True
        lblGithub.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGithub.Location = New Point(151, 234)
        lblGithub.Name = "lblGithub"
        lblGithub.Size = New Size(92, 27)
        lblGithub.TabIndex = 7
        lblGithub.Text = "Github:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(339, 350)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(131, 42)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.YellowGreen
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.Font = New Font("Arial", 8.0F)
        btnToggleStopwatch.ForeColor = Color.Black
        btnToggleStopwatch.Location = New Point(28, 286)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(285, 35)
        btnToggleStopwatch.TabIndex = 9
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BorderStyle = BorderStyle.FixedSingle
        lblStopwatch.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStopwatch.ForeColor = Color.FloralWhite
        lblStopwatch.Location = New Point(329, 286)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.ReadOnly = True
        lblStopwatch.Size = New Size(196, 35)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00.00.00"
        lblStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 24.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(650, 429)
        Controls.Add(lblStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(lblGithub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Font = New Font("Arial", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "CreateSubmissionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatch As TextBox

End Class
