<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe2
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
        Me.lblNJoueurs = New System.Windows.Forms.Label()
        Me.txtJoueur2 = New System.Windows.Forms.TextBox()
        Me.lblJoueur1 = New System.Windows.Forms.Label()
        Me.lblJoueur2 = New System.Windows.Forms.Label()
        Me.txtJoueur1 = New System.Windows.Forms.TextBox()
        Me.btnCommencer = New System.Windows.Forms.Button()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.lblNiveau = New System.Windows.Forms.Label()
        Me.cmbNiveau = New System.Windows.Forms.ComboBox()
        Me.chbFacile = New System.Windows.Forms.CheckBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.chbAssistant = New System.Windows.Forms.CheckBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNJoueurs
        '
        Me.lblNJoueurs.AutoSize = True
        Me.lblNJoueurs.Location = New System.Drawing.Point(152, 40)
        Me.lblNJoueurs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNJoueurs.Name = "lblNJoueurs"
        Me.lblNJoueurs.Size = New System.Drawing.Size(147, 20)
        Me.lblNJoueurs.TabIndex = 0
        Me.lblNJoueurs.Text = "Nombre de joueurs:"
        '
        'txtJoueur2
        '
        Me.txtJoueur2.Location = New System.Drawing.Point(238, 169)
        Me.txtJoueur2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJoueur2.Name = "txtJoueur2"
        Me.txtJoueur2.Size = New System.Drawing.Size(163, 26)
        Me.txtJoueur2.TabIndex = 4
        Me.txtJoueur2.Visible = False
        '
        'lblJoueur1
        '
        Me.lblJoueur1.AutoSize = True
        Me.lblJoueur1.Location = New System.Drawing.Point(92, 145)
        Me.lblJoueur1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueur1.Name = "lblJoueur1"
        Me.lblJoueur1.Size = New System.Drawing.Size(71, 20)
        Me.lblJoueur1.TabIndex = 5
        Me.lblJoueur1.Text = "Joueur 1"
        Me.lblJoueur1.Visible = False
        '
        'lblJoueur2
        '
        Me.lblJoueur2.AutoSize = True
        Me.lblJoueur2.Location = New System.Drawing.Point(279, 145)
        Me.lblJoueur2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueur2.Name = "lblJoueur2"
        Me.lblJoueur2.Size = New System.Drawing.Size(71, 20)
        Me.lblJoueur2.TabIndex = 6
        Me.lblJoueur2.Text = "Joueur 2"
        Me.lblJoueur2.Visible = False
        '
        'txtJoueur1
        '
        Me.txtJoueur1.Location = New System.Drawing.Point(50, 169)
        Me.txtJoueur1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJoueur1.Name = "txtJoueur1"
        Me.txtJoueur1.Size = New System.Drawing.Size(163, 26)
        Me.txtJoueur1.TabIndex = 7
        Me.txtJoueur1.Visible = False
        '
        'btnCommencer
        '
        Me.btnCommencer.Location = New System.Drawing.Point(262, 291)
        Me.btnCommencer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCommencer.Name = "btnCommencer"
        Me.btnCommencer.Size = New System.Drawing.Size(118, 49)
        Me.btnCommencer.TabIndex = 8
        Me.btnCommencer.Text = "Commencer"
        Me.btnCommencer.UseVisualStyleBackColor = True
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(80, 89)
        Me.chb1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(97, 24)
        Me.chb1.TabIndex = 9
        Me.chb1.Text = "1 Joueur"
        Me.chb1.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Location = New System.Drawing.Point(262, 89)
        Me.chb2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(105, 24)
        Me.chb2.TabIndex = 10
        Me.chb2.Text = "2 Joueurs"
        Me.chb2.UseVisualStyleBackColor = True
        '
        'lblNiveau
        '
        Me.lblNiveau.AutoSize = True
        Me.lblNiveau.Location = New System.Drawing.Point(110, 231)
        Me.lblNiveau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNiveau.Name = "lblNiveau"
        Me.lblNiveau.Size = New System.Drawing.Size(65, 20)
        Me.lblNiveau.TabIndex = 11
        Me.lblNiveau.Text = "Niveau :"
        Me.lblNiveau.Visible = False
        '
        'cmbNiveau
        '
        Me.cmbNiveau.FormattingEnabled = True
        Me.cmbNiveau.Items.AddRange(New Object() {"Facile", "Difficile"})
        Me.cmbNiveau.Location = New System.Drawing.Point(238, 231)
        Me.cmbNiveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbNiveau.Name = "cmbNiveau"
        Me.cmbNiveau.Size = New System.Drawing.Size(163, 28)
        Me.cmbNiveau.TabIndex = 12
        Me.cmbNiveau.Visible = False
        '
        'chbFacile
        '
        Me.chbFacile.AutoSize = True
        Me.chbFacile.Location = New System.Drawing.Point(68, 225)
        Me.chbFacile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chbFacile.Name = "chbFacile"
        Me.chbFacile.Size = New System.Drawing.Size(143, 24)
        Me.chbFacile.TabIndex = 13
        Me.chbFacile.Text = "Mode débutant"
        Me.chbFacile.UseVisualStyleBackColor = True
        Me.chbFacile.Visible = False
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(262, 231)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(118, 35)
        Me.btnInfo.TabIndex = 14
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        Me.btnInfo.Visible = False
        '
        'chbAssistant
        '
        Me.chbAssistant.AutoSize = True
        Me.chbAssistant.Location = New System.Drawing.Point(68, 262)
        Me.chbAssistant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chbAssistant.Name = "chbAssistant"
        Me.chbAssistant.Size = New System.Drawing.Size(101, 24)
        Me.chbAssistant.TabIndex = 15
        Me.chbAssistant.Text = "Assistant"
        Me.chbAssistant.UseVisualStyleBackColor = True
        Me.chbAssistant.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(96, 298)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 35)
        Me.btnMenu.TabIndex = 16
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'TicTacToe2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 366)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.chbAssistant)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.chbFacile)
        Me.Controls.Add(Me.cmbNiveau)
        Me.Controls.Add(Me.lblNiveau)
        Me.Controls.Add(Me.chb2)
        Me.Controls.Add(Me.chb1)
        Me.Controls.Add(Me.btnCommencer)
        Me.Controls.Add(Me.txtJoueur1)
        Me.Controls.Add(Me.lblJoueur2)
        Me.Controls.Add(Me.lblJoueur1)
        Me.Controls.Add(Me.txtJoueur2)
        Me.Controls.Add(Me.lblNJoueurs)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TicTacToe2"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNJoueurs As System.Windows.Forms.Label
    Friend WithEvents txtJoueur2 As System.Windows.Forms.TextBox
    Friend WithEvents lblJoueur1 As System.Windows.Forms.Label
    Friend WithEvents lblJoueur2 As System.Windows.Forms.Label
    Friend WithEvents txtJoueur1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCommencer As System.Windows.Forms.Button
    Friend WithEvents chb1 As System.Windows.Forms.CheckBox
    Friend WithEvents chb2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblNiveau As System.Windows.Forms.Label
    Friend WithEvents cmbNiveau As System.Windows.Forms.ComboBox
    Friend WithEvents chbFacile As System.Windows.Forms.CheckBox
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents chbAssistant As System.Windows.Forms.CheckBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
