<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        lblStopwatchTime = New Label()
        txtStopwatchTime = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(111, 38)
        lblName.Name = "lblName"
        lblName.Size = New Size(83, 32)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F)
        lblEmail.Location = New Point(111, 100)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(76, 32)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 12F)
        lblPhone.Location = New Point(111, 162)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(87, 32)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(111, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 32)
        Label4.TabIndex = 3
        Label4.Text = "GitHub:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F)
        txtName.Location = New Point(222, 38)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(277, 39)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(222, 100)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(277, 39)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 12F)
        txtPhone.Location = New Point(222, 162)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(277, 39)
        txtPhone.TabIndex = 6
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Font = New Font("Segoe UI", 12F)
        txtGitHub.Location = New Point(222, 219)
        txtGitHub.Margin = New Padding(3, 4, 3, 4)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(277, 39)
        txtGitHub.TabIndex = 7
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPrevious.FlatAppearance.BorderSize = 0
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(120, 320)
        btnPrevious.Margin = New Padding(3, 4, 3, 4)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(211, 52)
        btnPrevious.TabIndex = 8
        btnPrevious.Text = "Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(363, 322)
        btnNext.Margin = New Padding(3, 4, 3, 4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(163, 50)
        btnNext.TabIndex = 9
        btnNext.Text = "Next (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Font = New Font("Segoe UI", 12F)
        lblStopwatchTime.Location = New Point(111, 275)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(72, 32)
        lblStopwatchTime.TabIndex = 10
        lblStopwatchTime.Text = "Time:"
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Font = New Font("Segoe UI", 12F)
        txtStopwatchTime.Location = New Point(222, 275)
        txtStopwatchTime.Margin = New Padding(3, 4, 3, 4)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(277, 39)
        txtStopwatchTime.TabIndex = 11
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(581, 238)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(211, 52)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(581, 155)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(211, 52)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 389)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(txtStopwatchTime)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 5, 3, 5)
        Name = "ViewSubmissionsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGitHub As System.Windows.Forms.TextBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblStopwatchTime As System.Windows.Forms.Label
    Friend WithEvents txtStopwatchTime As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
