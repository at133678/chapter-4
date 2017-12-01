<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MadLibs
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PularNoun = New System.Windows.Forms.Label()
        Me.noun = New System.Windows.Forms.Label()
        Me.Animal = New System.Windows.Forms.Label()
        Me.BodyPartsPural = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.Label()
        Me.listPularNoun = New System.Windows.Forms.ListBox()
        Me.listnoun = New System.Windows.Forms.ListBox()
        Me.listAnimal = New System.Windows.Forms.ListBox()
        Me.listBodyParts = New System.Windows.Forms.ListBox()
        Me.listNumber = New System.Windows.Forms.ListBox()
        Me.listEst = New System.Windows.Forms.ListBox()
        Me.worldsendingwithest = New System.Windows.Forms.Label()
        Me.Color = New System.Windows.Forms.Label()
        Me.listColor = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(474, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(315, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(315, 314)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 31
        Me.btnSubmit.Text = "Sublmint"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PularNoun
        '
        Me.PularNoun.AutoSize = True
        Me.PularNoun.Location = New System.Drawing.Point(81, 292)
        Me.PularNoun.Name = "PularNoun"
        Me.PularNoun.Size = New System.Drawing.Size(60, 13)
        Me.PularNoun.TabIndex = 30
        Me.PularNoun.Text = "Pular Noun"
        '
        'noun
        '
        Me.noun.AutoSize = True
        Me.noun.Location = New System.Drawing.Point(471, 149)
        Me.noun.Name = "noun"
        Me.noun.Size = New System.Drawing.Size(31, 13)
        Me.noun.TabIndex = 29
        Me.noun.Text = "noun"
        '
        'Animal
        '
        Me.Animal.AutoSize = True
        Me.Animal.Location = New System.Drawing.Point(275, 149)
        Me.Animal.Name = "Animal"
        Me.Animal.Size = New System.Drawing.Size(38, 13)
        Me.Animal.TabIndex = 28
        Me.Animal.Text = "Animal"
        '
        'BodyPartsPural
        '
        Me.BodyPartsPural.AutoSize = True
        Me.BodyPartsPural.Location = New System.Drawing.Point(70, 149)
        Me.BodyPartsPural.Name = "BodyPartsPural"
        Me.BodyPartsPural.Size = New System.Drawing.Size(87, 13)
        Me.BodyPartsPural.TabIndex = 27
        Me.BodyPartsPural.Text = "Body Parts Plural"
        '
        'Number
        '
        Me.Number.AutoSize = True
        Me.Number.Location = New System.Drawing.Point(471, 7)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(44, 13)
        Me.Number.TabIndex = 26
        Me.Number.Text = "Number"
        '
        'listPularNoun
        '
        Me.listPularNoun.FormattingEnabled = True
        Me.listPularNoun.Items.AddRange(New Object() {"men ", "women", "dogs", "cats", "birds", "computers", "workers"})
        Me.listPularNoun.Location = New System.Drawing.Point(73, 322)
        Me.listPularNoun.Name = "listPularNoun"
        Me.listPularNoun.Size = New System.Drawing.Size(120, 95)
        Me.listPularNoun.TabIndex = 25
        '
        'listnoun
        '
        Me.listnoun.FormattingEnabled = True
        Me.listnoun.Items.AddRange(New Object() {"boy ", "girl", "school", "house", "book", "mom", "dad"})
        Me.listnoun.Location = New System.Drawing.Point(474, 184)
        Me.listnoun.Name = "listnoun"
        Me.listnoun.Size = New System.Drawing.Size(120, 95)
        Me.listnoun.TabIndex = 24
        '
        'listAnimal
        '
        Me.listAnimal.FormattingEnabled = True
        Me.listAnimal.Items.AddRange(New Object() {"Dragon", "Dog", "Cat", "Bird ", "Tiger", "Lion", "Hippo", "Fish", "Horse", "Camel"})
        Me.listAnimal.Location = New System.Drawing.Point(278, 184)
        Me.listAnimal.Name = "listAnimal"
        Me.listAnimal.Size = New System.Drawing.Size(120, 95)
        Me.listAnimal.TabIndex = 23
        '
        'listBodyParts
        '
        Me.listBodyParts.FormattingEnabled = True
        Me.listBodyParts.Items.AddRange(New Object() {"Arm", "Hand", "Leg ", "Foot", "Nose ", "Mouth", "Eyes", "Brain", "Ear", "Skin", "Bone"})
        Me.listBodyParts.Location = New System.Drawing.Point(73, 184)
        Me.listBodyParts.Name = "listBodyParts"
        Me.listBodyParts.Size = New System.Drawing.Size(120, 95)
        Me.listBodyParts.TabIndex = 22
        '
        'listNumber
        '
        Me.listNumber.FormattingEnabled = True
        Me.listNumber.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "100", "200", "300", "400", "500"})
        Me.listNumber.Location = New System.Drawing.Point(474, 38)
        Me.listNumber.Name = "listNumber"
        Me.listNumber.Size = New System.Drawing.Size(120, 95)
        Me.listNumber.TabIndex = 21
        '
        'listEst
        '
        Me.listEst.FormattingEnabled = True
        Me.listEst.Items.AddRange(New Object() {"biggest ", "fatests", "uglyest", "smallest", "greatest ", "roundest", "fastest", "slowest"})
        Me.listEst.Location = New System.Drawing.Point(278, 38)
        Me.listEst.Name = "listEst"
        Me.listEst.Size = New System.Drawing.Size(120, 95)
        Me.listEst.TabIndex = 20
        '
        'worldsendingwithest
        '
        Me.worldsendingwithest.AutoSize = True
        Me.worldsendingwithest.Location = New System.Drawing.Point(275, 7)
        Me.worldsendingwithest.Name = "worldsendingwithest"
        Me.worldsendingwithest.Size = New System.Drawing.Size(109, 13)
        Me.worldsendingwithest.TabIndex = 19
        Me.worldsendingwithest.Text = "Words endingwith est"
        '
        'Color
        '
        Me.Color.AutoSize = True
        Me.Color.Location = New System.Drawing.Point(81, 7)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(31, 13)
        Me.Color.TabIndex = 18
        Me.Color.Text = "Color"
        '
        'listColor
        '
        Me.listColor.FormattingEnabled = True
        Me.listColor.Items.AddRange(New Object() {"Blue", "Red", "Yellow", "Green"})
        Me.listColor.Location = New System.Drawing.Point(73, 38)
        Me.listColor.Name = "listColor"
        Me.listColor.Size = New System.Drawing.Size(120, 95)
        Me.listColor.TabIndex = 17
        '
        'MadLibs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 437)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PularNoun)
        Me.Controls.Add(Me.noun)
        Me.Controls.Add(Me.Animal)
        Me.Controls.Add(Me.BodyPartsPural)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.listPularNoun)
        Me.Controls.Add(Me.listnoun)
        Me.Controls.Add(Me.listAnimal)
        Me.Controls.Add(Me.listBodyParts)
        Me.Controls.Add(Me.listNumber)
        Me.Controls.Add(Me.listEst)
        Me.Controls.Add(Me.worldsendingwithest)
        Me.Controls.Add(Me.Color)
        Me.Controls.Add(Me.listColor)
        Me.Name = "MadLibs"
        Me.Text = "Mad Libs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents PularNoun As System.Windows.Forms.Label
    Friend WithEvents noun As System.Windows.Forms.Label
    Friend WithEvents Animal As System.Windows.Forms.Label
    Friend WithEvents BodyPartsPural As System.Windows.Forms.Label
    Friend WithEvents Number As System.Windows.Forms.Label
    Friend WithEvents listPularNoun As System.Windows.Forms.ListBox
    Friend WithEvents listnoun As System.Windows.Forms.ListBox
    Friend WithEvents listAnimal As System.Windows.Forms.ListBox
    Friend WithEvents listBodyParts As System.Windows.Forms.ListBox
    Friend WithEvents listNumber As System.Windows.Forms.ListBox
    Friend WithEvents listEst As System.Windows.Forms.ListBox
    Friend WithEvents worldsendingwithest As System.Windows.Forms.Label
    Friend WithEvents Color As System.Windows.Forms.Label
    Friend WithEvents listColor As System.Windows.Forms.ListBox

End Class
