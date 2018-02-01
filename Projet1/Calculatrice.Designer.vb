<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculatrice
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEcrant = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnEgale = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnMoins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEcrant
        '
        Me.txtEcrant.Location = New System.Drawing.Point(58, 31)
        Me.txtEcrant.Name = "txtEcrant"
        Me.txtEcrant.Size = New System.Drawing.Size(164, 20)
        Me.txtEcrant.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(24, 82)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 40)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(86, 82)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 40)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(152, 82)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 40)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(24, 251)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(40, 40)
        Me.btn0.TabIndex = 4
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(152, 140)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(40, 40)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(152, 196)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(40, 40)
        Me.btn9.TabIndex = 6
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(86, 196)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(40, 40)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(24, 196)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(40, 40)
        Me.btn7.TabIndex = 8
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(86, 140)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(40, 40)
        Me.btn5.TabIndex = 9
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(24, 140)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 40)
        Me.btn4.TabIndex = 10
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnEgale
        '
        Me.btnEgale.Location = New System.Drawing.Point(86, 251)
        Me.btnEgale.Name = "btnEgale"
        Me.btnEgale.Size = New System.Drawing.Size(106, 40)
        Me.btnEgale.TabIndex = 11
        Me.btnEgale.Text = "="
        Me.btnEgale.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(215, 82)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 40)
        Me.btnPlus.TabIndex = 12
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(215, 251)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(40, 40)
        Me.btnDivision.TabIndex = 13
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Location = New System.Drawing.Point(215, 196)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(40, 40)
        Me.btnMultiplication.TabIndex = 14
        Me.btnMultiplication.Text = "x"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnMoins
        '
        Me.btnMoins.Location = New System.Drawing.Point(215, 140)
        Me.btnMoins.Name = "btnMoins"
        Me.btnMoins.Size = New System.Drawing.Size(40, 40)
        Me.btnMoins.TabIndex = 15
        Me.btnMoins.Text = "-"
        Me.btnMoins.UseVisualStyleBackColor = True
        '
        'Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 341)
        Me.Controls.Add(Me.btnMoins)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnEgale)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtEcrant)
        Me.Name = "Calculatrice"
        Me.Text = "Calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEcrant As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btnEgale As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents btnMultiplication As System.Windows.Forms.Button
    Friend WithEvents btnMoins As System.Windows.Forms.Button
End Class
