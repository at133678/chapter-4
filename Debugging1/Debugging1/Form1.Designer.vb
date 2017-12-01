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
        Me.Enteradecimal = New System.Windows.Forms.Label()
        Me.RomanNumaral = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Number = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Enteradecimal
        '
        Me.Enteradecimal.Location = New System.Drawing.Point(144, 92)
        Me.Enteradecimal.Name = "Enteradecimal"
        Me.Enteradecimal.Size = New System.Drawing.Size(118, 41)
        Me.Enteradecimal.TabIndex = 0
        Me.Enteradecimal.Text = "Enter a decimal integer in the range 1-10"
        '
        'RomanNumaral
        '
        Me.RomanNumaral.Location = New System.Drawing.Point(144, 195)
        Me.RomanNumaral.Name = "RomanNumaral"
        Me.RomanNumaral.Size = New System.Drawing.Size(150, 23)
        Me.RomanNumaral.TabIndex = 1
        Me.RomanNumaral.Text = "Equivalent Roman Numeral"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResult.Location = New System.Drawing.Point(481, 195)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(123, 23)
        Me.lblResult.TabIndex = 2
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(167, 415)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(484, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Number
        '
        Me.Number.Location = New System.Drawing.Point(484, 92)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(95, 20)
        Me.Number.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 543)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.RomanNumaral)
        Me.Controls.Add(Me.Enteradecimal)
        Me.Name = "Form1"
        Me.Text = "Romen Number Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Enteradecimal As System.Windows.Forms.Label
    Friend WithEvents RomanNumaral As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Number As System.Windows.Forms.TextBox

End Class
