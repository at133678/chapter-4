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
        Me.Sides = New System.Windows.Forms.GroupBox()
        Me.sideCornontheCob = New System.Windows.Forms.RadioButton()
        Me.sideFriedApples = New System.Windows.Forms.RadioButton()
        Me.sideSald = New System.Windows.Forms.RadioButton()
        Me.sideOnuionRings = New System.Windows.Forms.RadioButton()
        Me.radToppings = New System.Windows.Forms.GroupBox()
        Me.OnuionRing = New System.Windows.Forms.CheckBox()
        Me.Lettuce = New System.Windows.Forms.CheckBox()
        Me.Tomato = New System.Windows.Forms.CheckBox()
        Me.Onuion = New System.Windows.Forms.CheckBox()
        Me.SelectYourMeal = New System.Windows.Forms.GroupBox()
        Me.radChesseBuger = New System.Windows.Forms.RadioButton()
        Me.radChicken = New System.Windows.Forms.RadioButton()
        Me.radChickenBurger = New System.Windows.Forms.RadioButton()
        Me.radBBQBurger = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Sides.SuspendLayout()
        Me.radToppings.SuspendLayout()
        Me.SelectYourMeal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sides
        '
        Me.Sides.Controls.Add(Me.sideCornontheCob)
        Me.Sides.Controls.Add(Me.sideFriedApples)
        Me.Sides.Controls.Add(Me.sideSald)
        Me.Sides.Controls.Add(Me.sideOnuionRings)
        Me.Sides.Location = New System.Drawing.Point(495, 283)
        Me.Sides.Name = "Sides"
        Me.Sides.Size = New System.Drawing.Size(267, 172)
        Me.Sides.TabIndex = 11
        Me.Sides.TabStop = False
        Me.Sides.Text = "Sides"
        '
        'sideCornontheCob
        '
        Me.sideCornontheCob.AutoSize = True
        Me.sideCornontheCob.Location = New System.Drawing.Point(131, 118)
        Me.sideCornontheCob.Name = "sideCornontheCob"
        Me.sideCornontheCob.Size = New System.Drawing.Size(102, 17)
        Me.sideCornontheCob.TabIndex = 3
        Me.sideCornontheCob.TabStop = True
        Me.sideCornontheCob.Text = "Cornon the Cob "
        Me.sideCornontheCob.UseVisualStyleBackColor = True
        '
        'sideFriedApples
        '
        Me.sideFriedApples.AutoSize = True
        Me.sideFriedApples.Location = New System.Drawing.Point(144, 38)
        Me.sideFriedApples.Name = "sideFriedApples"
        Me.sideFriedApples.Size = New System.Drawing.Size(83, 17)
        Me.sideFriedApples.TabIndex = 2
        Me.sideFriedApples.TabStop = True
        Me.sideFriedApples.Text = "Fried Apples"
        Me.sideFriedApples.UseVisualStyleBackColor = True
        '
        'sideSald
        '
        Me.sideSald.AutoSize = True
        Me.sideSald.Location = New System.Drawing.Point(19, 118)
        Me.sideSald.Name = "sideSald"
        Me.sideSald.Size = New System.Drawing.Size(48, 17)
        Me.sideSald.TabIndex = 1
        Me.sideSald.TabStop = True
        Me.sideSald.Text = "Salid"
        Me.sideSald.UseVisualStyleBackColor = True
        '
        'sideOnuionRings
        '
        Me.sideOnuionRings.AutoSize = True
        Me.sideOnuionRings.Location = New System.Drawing.Point(19, 30)
        Me.sideOnuionRings.Name = "sideOnuionRings"
        Me.sideOnuionRings.Size = New System.Drawing.Size(89, 17)
        Me.sideOnuionRings.TabIndex = 0
        Me.sideOnuionRings.TabStop = True
        Me.sideOnuionRings.Text = "Onuion Rings"
        Me.sideOnuionRings.UseVisualStyleBackColor = True
        '
        'radToppings
        '
        Me.radToppings.Controls.Add(Me.OnuionRing)
        Me.radToppings.Controls.Add(Me.Lettuce)
        Me.radToppings.Controls.Add(Me.Tomato)
        Me.radToppings.Controls.Add(Me.Onuion)
        Me.radToppings.Location = New System.Drawing.Point(495, 53)
        Me.radToppings.Name = "radToppings"
        Me.radToppings.Size = New System.Drawing.Size(221, 224)
        Me.radToppings.TabIndex = 10
        Me.radToppings.TabStop = False
        Me.radToppings.Text = "Toppings"
        '
        'OnuionRing
        '
        Me.OnuionRing.AutoSize = True
        Me.OnuionRing.Location = New System.Drawing.Point(70, 191)
        Me.OnuionRing.Name = "OnuionRing"
        Me.OnuionRing.Size = New System.Drawing.Size(85, 17)
        Me.OnuionRing.TabIndex = 3
        Me.OnuionRing.Text = "Onuion Ring"
        Me.OnuionRing.UseVisualStyleBackColor = True
        '
        'Lettuce
        '
        Me.Lettuce.AutoSize = True
        Me.Lettuce.Location = New System.Drawing.Point(70, 144)
        Me.Lettuce.Name = "Lettuce"
        Me.Lettuce.Size = New System.Drawing.Size(62, 17)
        Me.Lettuce.TabIndex = 2
        Me.Lettuce.Text = "Lettuce"
        Me.Lettuce.UseVisualStyleBackColor = True
        '
        'Tomato
        '
        Me.Tomato.AutoSize = True
        Me.Tomato.Location = New System.Drawing.Point(70, 89)
        Me.Tomato.Name = "Tomato"
        Me.Tomato.Size = New System.Drawing.Size(62, 17)
        Me.Tomato.TabIndex = 1
        Me.Tomato.Text = "Tomato"
        Me.Tomato.UseVisualStyleBackColor = True
        '
        'Onuion
        '
        Me.Onuion.AutoSize = True
        Me.Onuion.Location = New System.Drawing.Point(70, 48)
        Me.Onuion.Name = "Onuion"
        Me.Onuion.Size = New System.Drawing.Size(60, 17)
        Me.Onuion.TabIndex = 0
        Me.Onuion.Text = "Onuion"
        Me.Onuion.UseVisualStyleBackColor = True
        '
        'SelectYourMeal
        '
        Me.SelectYourMeal.Controls.Add(Me.radChesseBuger)
        Me.SelectYourMeal.Controls.Add(Me.radChicken)
        Me.SelectYourMeal.Controls.Add(Me.radChickenBurger)
        Me.SelectYourMeal.Controls.Add(Me.radBBQBurger)
        Me.SelectYourMeal.Controls.Add(Me.GroupBox2)
        Me.SelectYourMeal.Location = New System.Drawing.Point(73, 53)
        Me.SelectYourMeal.Name = "SelectYourMeal"
        Me.SelectYourMeal.Size = New System.Drawing.Size(200, 224)
        Me.SelectYourMeal.TabIndex = 9
        Me.SelectYourMeal.TabStop = False
        Me.SelectYourMeal.Text = "Select Your Meal"
        '
        'radChesseBuger
        '
        Me.radChesseBuger.AutoSize = True
        Me.radChesseBuger.Location = New System.Drawing.Point(33, 88)
        Me.radChesseBuger.Name = "radChesseBuger"
        Me.radChesseBuger.Size = New System.Drawing.Size(94, 17)
        Me.radChesseBuger.TabIndex = 9
        Me.radChesseBuger.TabStop = True
        Me.radChesseBuger.Text = "Chesse Burger"
        Me.radChesseBuger.UseVisualStyleBackColor = True
        '
        'radChicken
        '
        Me.radChicken.AutoSize = True
        Me.radChicken.Location = New System.Drawing.Point(33, 190)
        Me.radChicken.Name = "radChicken"
        Me.radChicken.Size = New System.Drawing.Size(64, 17)
        Me.radChicken.TabIndex = 8
        Me.radChicken.TabStop = True
        Me.radChicken.Text = "Chicken"
        Me.radChicken.UseVisualStyleBackColor = True
        '
        'radChickenBurger
        '
        Me.radChickenBurger.AutoSize = True
        Me.radChickenBurger.Location = New System.Drawing.Point(33, 143)
        Me.radChickenBurger.Name = "radChickenBurger"
        Me.radChickenBurger.Size = New System.Drawing.Size(98, 17)
        Me.radChickenBurger.TabIndex = 7
        Me.radChickenBurger.TabStop = True
        Me.radChickenBurger.Text = "Chicken Burger"
        Me.radChickenBurger.UseVisualStyleBackColor = True
        '
        'radBBQBurger
        '
        Me.radBBQBurger.Location = New System.Drawing.Point(33, 48)
        Me.radBBQBurger.Name = "radBBQBurger"
        Me.radBBQBurger.Size = New System.Drawing.Size(104, 24)
        Me.radBBQBurger.TabIndex = 5
        Me.radBBQBurger.TabStop = True
        Me.radBBQBurger.Text = "BBQ Buger"
        Me.radBBQBurger.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(323, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 84)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResult.Location = New System.Drawing.Point(83, 313)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(201, 44)
        Me.lblResult.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(230, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(83, 389)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 509)
        Me.Controls.Add(Me.Sides)
        Me.Controls.Add(Me.radToppings)
        Me.Controls.Add(Me.SelectYourMeal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Sides.ResumeLayout(False)
        Me.Sides.PerformLayout()
        Me.radToppings.ResumeLayout(False)
        Me.radToppings.PerformLayout()
        Me.SelectYourMeal.ResumeLayout(False)
        Me.SelectYourMeal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sides As System.Windows.Forms.GroupBox
    Friend WithEvents sideCornontheCob As System.Windows.Forms.RadioButton
    Friend WithEvents sideFriedApples As System.Windows.Forms.RadioButton
    Friend WithEvents sideSald As System.Windows.Forms.RadioButton
    Friend WithEvents sideOnuionRings As System.Windows.Forms.RadioButton
    Friend WithEvents radToppings As System.Windows.Forms.GroupBox
    Friend WithEvents OnuionRing As System.Windows.Forms.CheckBox
    Friend WithEvents Lettuce As System.Windows.Forms.CheckBox
    Friend WithEvents Tomato As System.Windows.Forms.CheckBox
    Friend WithEvents Onuion As System.Windows.Forms.CheckBox
    Friend WithEvents SelectYourMeal As System.Windows.Forms.GroupBox
    Friend WithEvents radChesseBuger As System.Windows.Forms.RadioButton
    Friend WithEvents radChicken As System.Windows.Forms.RadioButton
    Friend WithEvents radChickenBurger As System.Windows.Forms.RadioButton
    Friend WithEvents radBBQBurger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button

End Class
