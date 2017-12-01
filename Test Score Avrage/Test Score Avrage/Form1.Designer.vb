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
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.Avrage = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblEnterThreeTestScores = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.btnCalculateAvrage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScore1
        '
        Me.lblScore1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore1.Location = New System.Drawing.Point(53, 57)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(100, 23)
        Me.lblScore1.TabIndex = 0
        Me.lblScore1.Text = "Score 1"
        '
        'lblScore2
        '
        Me.lblScore2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore2.Location = New System.Drawing.Point(53, 129)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(100, 30)
        Me.lblScore2.TabIndex = 1
        Me.lblScore2.Text = "Score 2"
        '
        'lblScore3
        '
        Me.lblScore3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore3.Location = New System.Drawing.Point(53, 199)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(100, 28)
        Me.lblScore3.TabIndex = 2
        Me.lblScore3.Text = "Score 3"
        '
        'Avrage
        '
        Me.Avrage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Avrage.Location = New System.Drawing.Point(53, 260)
        Me.Avrage.Name = "Avrage"
        Me.Avrage.Size = New System.Drawing.Size(100, 31)
        Me.Avrage.TabIndex = 3
        Me.Avrage.Text = "Avrage"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(176, 240)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(139, 31)
        Me.lblResult.TabIndex = 4
        '
        'lblEnterThreeTestScores
        '
        Me.lblEnterThreeTestScores.AutoSize = True
        Me.lblEnterThreeTestScores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnterThreeTestScores.Location = New System.Drawing.Point(56, 20)
        Me.lblEnterThreeTestScores.Name = "lblEnterThreeTestScores"
        Me.lblEnterThreeTestScores.Size = New System.Drawing.Size(125, 15)
        Me.lblEnterThreeTestScores.TabIndex = 5
        Me.lblEnterThreeTestScores.Text = "Enter Three Test Scores"
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(176, 35)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(123, 20)
        Me.txtScore1.TabIndex = 6
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(176, 119)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(123, 20)
        Me.txtScore2.TabIndex = 7
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(176, 187)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(123, 20)
        Me.txtScore3.TabIndex = 8
        '
        'btnCalculateAvrage
        '
        Me.btnCalculateAvrage.Location = New System.Drawing.Point(76, 344)
        Me.btnCalculateAvrage.Name = "btnCalculateAvrage"
        Me.btnCalculateAvrage.Size = New System.Drawing.Size(77, 74)
        Me.btnCalculateAvrage.TabIndex = 9
        Me.btnCalculateAvrage.Text = "Calculate Average"
        Me.btnCalculateAvrage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(606, 344)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 45)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(606, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 50)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(245, 344)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(254, 41)
        Me.lblMessage.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtScore1)
        Me.GroupBox1.Controls.Add(Me.txtScore2)
        Me.GroupBox1.Controls.Add(Me.txtScore3)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 283)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateAvrage)
        Me.Controls.Add(Me.lblEnterThreeTestScores)
        Me.Controls.Add(Me.Avrage)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Name = "Form1"
        Me.Text = "TestScore Average"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents lblScore3 As System.Windows.Forms.Label
    Friend WithEvents Avrage As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblEnterThreeTestScores As System.Windows.Forms.Label
    Friend WithEvents txtScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateAvrage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
