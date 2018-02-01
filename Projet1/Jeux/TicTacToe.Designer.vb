<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
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
        Me.pbxCase1 = New System.Windows.Forms.PictureBox()
        Me.pbxCase5 = New System.Windows.Forms.PictureBox()
        Me.pbxCase9 = New System.Windows.Forms.PictureBox()
        Me.pbxCase8 = New System.Windows.Forms.PictureBox()
        Me.pbxCase7 = New System.Windows.Forms.PictureBox()
        Me.pbxCase6 = New System.Windows.Forms.PictureBox()
        Me.pbxCase4 = New System.Windows.Forms.PictureBox()
        Me.pbxCase3 = New System.Windows.Forms.PictureBox()
        Me.pbxCase2 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblNomJ1 = New System.Windows.Forms.Label()
        Me.lblJoueur1 = New System.Windows.Forms.Label()
        Me.lblJoueur2 = New System.Windows.Forms.Label()
        Me.lblNomJ2 = New System.Windows.Forms.Label()
        Me.lblPointsJ1 = New System.Windows.Forms.Label()
        Me.lblPointsJ2 = New System.Windows.Forms.Label()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.picTurn = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        CType(Me.pbxCase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCase2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTurn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxCase1
        '
        Me.pbxCase1.Location = New System.Drawing.Point(200, 125)
        Me.pbxCase1.Name = "pbxCase1"
        Me.pbxCase1.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase1.TabIndex = 0
        Me.pbxCase1.TabStop = False
        '
        'pbxCase5
        '
        Me.pbxCase5.Location = New System.Drawing.Point(325, 250)
        Me.pbxCase5.Name = "pbxCase5"
        Me.pbxCase5.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase5.TabIndex = 1
        Me.pbxCase5.TabStop = False
        '
        'pbxCase9
        '
        Me.pbxCase9.Location = New System.Drawing.Point(450, 375)
        Me.pbxCase9.Name = "pbxCase9"
        Me.pbxCase9.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase9.TabIndex = 2
        Me.pbxCase9.TabStop = False
        '
        'pbxCase8
        '
        Me.pbxCase8.Location = New System.Drawing.Point(325, 375)
        Me.pbxCase8.Name = "pbxCase8"
        Me.pbxCase8.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase8.TabIndex = 3
        Me.pbxCase8.TabStop = False
        '
        'pbxCase7
        '
        Me.pbxCase7.Location = New System.Drawing.Point(200, 375)
        Me.pbxCase7.Name = "pbxCase7"
        Me.pbxCase7.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase7.TabIndex = 4
        Me.pbxCase7.TabStop = False
        '
        'pbxCase6
        '
        Me.pbxCase6.Location = New System.Drawing.Point(450, 250)
        Me.pbxCase6.Name = "pbxCase6"
        Me.pbxCase6.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase6.TabIndex = 5
        Me.pbxCase6.TabStop = False
        '
        'pbxCase4
        '
        Me.pbxCase4.Location = New System.Drawing.Point(200, 250)
        Me.pbxCase4.Name = "pbxCase4"
        Me.pbxCase4.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase4.TabIndex = 6
        Me.pbxCase4.TabStop = False
        '
        'pbxCase3
        '
        Me.pbxCase3.Location = New System.Drawing.Point(450, 125)
        Me.pbxCase3.Name = "pbxCase3"
        Me.pbxCase3.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase3.TabIndex = 7
        Me.pbxCase3.TabStop = False
        '
        'pbxCase2
        '
        Me.pbxCase2.Location = New System.Drawing.Point(325, 125)
        Me.pbxCase2.Name = "pbxCase2"
        Me.pbxCase2.Size = New System.Drawing.Size(100, 100)
        Me.pbxCase2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCase2.TabIndex = 8
        Me.pbxCase2.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(734, 562)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.FillColor = System.Drawing.Color.Black
        Me.RectangleShape5.Location = New System.Drawing.Point(200, 225)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(350, 25)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.FillColor = System.Drawing.Color.Black
        Me.RectangleShape4.Location = New System.Drawing.Point(200, 350)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(350, 25)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.FillColor = System.Drawing.Color.Black
        Me.RectangleShape2.Location = New System.Drawing.Point(425, 125)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(25, 350)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.FillColor = System.Drawing.Color.Black
        Me.RectangleShape1.Location = New System.Drawing.Point(300, 125)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(25, 350)
        '
        'lblNomJ1
        '
        Me.lblNomJ1.AutoSize = True
        Me.lblNomJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJ1.Location = New System.Drawing.Point(185, 50)
        Me.lblNomJ1.Name = "lblNomJ1"
        Me.lblNomJ1.Size = New System.Drawing.Size(164, 29)
        Me.lblNomJ1.TabIndex = 10
        Me.lblNomJ1.Text = "Nom Joueur 1"
        '
        'lblJoueur1
        '
        Me.lblJoueur1.AutoSize = True
        Me.lblJoueur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueur1.Location = New System.Drawing.Point(35, 50)
        Me.lblJoueur1.Name = "lblJoueur1"
        Me.lblJoueur1.Size = New System.Drawing.Size(119, 31)
        Me.lblJoueur1.TabIndex = 11
        Me.lblJoueur1.Text = "Joueur 1"
        '
        'lblJoueur2
        '
        Me.lblJoueur2.AutoSize = True
        Me.lblJoueur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueur2.Location = New System.Drawing.Point(35, 504)
        Me.lblJoueur2.Name = "lblJoueur2"
        Me.lblJoueur2.Size = New System.Drawing.Size(119, 31)
        Me.lblJoueur2.TabIndex = 12
        Me.lblJoueur2.Text = "Joueur 2"
        '
        'lblNomJ2
        '
        Me.lblNomJ2.AutoSize = True
        Me.lblNomJ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJ2.Location = New System.Drawing.Point(185, 507)
        Me.lblNomJ2.Name = "lblNomJ2"
        Me.lblNomJ2.Size = New System.Drawing.Size(164, 29)
        Me.lblNomJ2.TabIndex = 13
        Me.lblNomJ2.Text = "Nom Joueur 2"
        '
        'lblPointsJ1
        '
        Me.lblPointsJ1.AutoSize = True
        Me.lblPointsJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsJ1.Location = New System.Drawing.Point(50, 94)
        Me.lblPointsJ1.Name = "lblPointsJ1"
        Me.lblPointsJ1.Size = New System.Drawing.Size(77, 25)
        Me.lblPointsJ1.TabIndex = 14
        Me.lblPointsJ1.Text = "Points1"
        '
        'lblPointsJ2
        '
        Me.lblPointsJ2.AutoSize = True
        Me.lblPointsJ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsJ2.Location = New System.Drawing.Point(50, 463)
        Me.lblPointsJ2.Name = "lblPointsJ2"
        Me.lblPointsJ2.Size = New System.Drawing.Size(77, 25)
        Me.lblPointsJ2.TabIndex = 15
        Me.lblPointsJ2.Text = "Points2"
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Location = New System.Drawing.Point(63, 225)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(29, 13)
        Me.lblTurn.TabIndex = 16
        Me.lblTurn.Text = "Turn"
        '
        'picTurn
        '
        Me.picTurn.Location = New System.Drawing.Point(41, 250)
        Me.picTurn.Name = "picTurn"
        Me.picTurn.Size = New System.Drawing.Size(80, 80)
        Me.picTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTurn.TabIndex = 17
        Me.picTurn.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(602, 272)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(82, 40)
        Me.btnMenu.TabIndex = 18
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 562)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.picTurn)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.lblPointsJ2)
        Me.Controls.Add(Me.lblPointsJ1)
        Me.Controls.Add(Me.lblNomJ2)
        Me.Controls.Add(Me.lblJoueur2)
        Me.Controls.Add(Me.lblJoueur1)
        Me.Controls.Add(Me.lblNomJ1)
        Me.Controls.Add(Me.pbxCase2)
        Me.Controls.Add(Me.pbxCase3)
        Me.Controls.Add(Me.pbxCase4)
        Me.Controls.Add(Me.pbxCase6)
        Me.Controls.Add(Me.pbxCase7)
        Me.Controls.Add(Me.pbxCase8)
        Me.Controls.Add(Me.pbxCase9)
        Me.Controls.Add(Me.pbxCase5)
        Me.Controls.Add(Me.pbxCase1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "TicTacToe"
        Me.Text = "Tic Tac Toe"
        CType(Me.pbxCase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCase2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTurn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxCase1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase9 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCase2 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblNomJ1 As System.Windows.Forms.Label
    Friend WithEvents lblJoueur1 As System.Windows.Forms.Label
    Friend WithEvents lblJoueur2 As System.Windows.Forms.Label
    Friend WithEvents lblNomJ2 As System.Windows.Forms.Label
    Friend WithEvents lblPointsJ1 As System.Windows.Forms.Label
    Friend WithEvents lblPointsJ2 As System.Windows.Forms.Label
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents picTurn As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
