<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnCreateSubmission = New Button()
        btnViewSubmissions = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.LightBlue
        btnCreateSubmission.FlatStyle = FlatStyle.Flat
        btnCreateSubmission.Font = New Font("Arial", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateSubmission.ForeColor = Color.Black
        btnCreateSubmission.Location = New Point(130, 180)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(611, 60)
        btnCreateSubmission.TabIndex = 0
        btnCreateSubmission.Text = "Create New Submission (CTRL + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.Font = New Font("Arial", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.ForeColor = Color.Black
        btnViewSubmissions.Location = New Point(130, 276)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(611, 60)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "View Submissions (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(561, 56)
        Label1.TabIndex = 2
        Label1.Text = "Welcome to Slidely App"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(895, 461)
        Controls.Add(Label1)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        Font = New Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Black
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Slidely Form App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents Label1 As Label

End Class
