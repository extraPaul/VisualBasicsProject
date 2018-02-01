<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokerStart
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnCommencer = New System.Windows.Forms.Button()
        Me.txtJoueur1 = New System.Windows.Forms.TextBox()
        Me.lblJoueur2 = New System.Windows.Forms.Label()
        Me.lblJoueur1 = New System.Windows.Forms.Label()
        Me.txtJoueur2 = New System.Windows.Forms.TextBox()
        Me.lblNJoueurs = New System.Windows.Forms.Label()
        Me.cmbNJoueurs = New System.Windows.Forms.ComboBox()
        Me.txtJ3 = New System.Windows.Forms.TextBox()
        Me.lblJ4 = New System.Windows.Forms.Label()
        Me.lblJ3 = New System.Windows.Forms.Label()
        Me.txtJ4 = New System.Windows.Forms.TextBox()
        Me.txtJ5 = New System.Windows.Forms.TextBox()
        Me.lblJ6 = New System.Windows.Forms.Label()
        Me.lblJ5 = New System.Windows.Forms.Label()
        Me.txtJ6 = New System.Windows.Forms.TextBox()
        Me.NumStarting = New System.Windows.Forms.NumericUpDown()
        Me.lblStarting = New System.Windows.Forms.Label()
        Me.lblBlinds = New System.Windows.Forms.Label()
        Me.NumBlinds = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumStarting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBlinds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(174, 456)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 35)
        Me.btnMenu.TabIndex = 30
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnCommencer
        '
        Me.btnCommencer.Location = New System.Drawing.Point(339, 449)
        Me.btnCommencer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCommencer.Name = "btnCommencer"
        Me.btnCommencer.Size = New System.Drawing.Size(118, 49)
        Me.btnCommencer.TabIndex = 22
        Me.btnCommencer.Text = "Commencer"
        Me.btnCommencer.UseVisualStyleBackColor = True
        Me.btnCommencer.Visible = False
        '
        'txtJoueur1
        '
        Me.txtJoueur1.Location = New System.Drawing.Point(123, 127)
        Me.txtJoueur1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJoueur1.Name = "txtJoueur1"
        Me.txtJoueur1.Size = New System.Drawing.Size(163, 26)
        Me.txtJoueur1.TabIndex = 21
        Me.txtJoueur1.Visible = False
        '
        'lblJoueur2
        '
        Me.lblJoueur2.AutoSize = True
        Me.lblJoueur2.Location = New System.Drawing.Point(354, 102)
        Me.lblJoueur2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueur2.Name = "lblJoueur2"
        Me.lblJoueur2.Size = New System.Drawing.Size(71, 20)
        Me.lblJoueur2.TabIndex = 20
        Me.lblJoueur2.Text = "Joueur 2"
        Me.lblJoueur2.Visible = False
        '
        'lblJoueur1
        '
        Me.lblJoueur1.AutoSize = True
        Me.lblJoueur1.Location = New System.Drawing.Point(170, 102)
        Me.lblJoueur1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueur1.Name = "lblJoueur1"
        Me.lblJoueur1.Size = New System.Drawing.Size(71, 20)
        Me.lblJoueur1.TabIndex = 19
        Me.lblJoueur1.Text = "Joueur 1"
        Me.lblJoueur1.Visible = False
        '
        'txtJoueur2
        '
        Me.txtJoueur2.Location = New System.Drawing.Point(316, 127)
        Me.txtJoueur2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJoueur2.Name = "txtJoueur2"
        Me.txtJoueur2.Size = New System.Drawing.Size(163, 26)
        Me.txtJoueur2.TabIndex = 18
        Me.txtJoueur2.Visible = False
        '
        'lblNJoueurs
        '
        Me.lblNJoueurs.AutoSize = True
        Me.lblNJoueurs.Location = New System.Drawing.Point(124, 38)
        Me.lblNJoueurs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNJoueurs.Name = "lblNJoueurs"
        Me.lblNJoueurs.Size = New System.Drawing.Size(147, 20)
        Me.lblNJoueurs.TabIndex = 17
        Me.lblNJoueurs.Text = "Nombre de joueurs:"
        '
        'cmbNJoueurs
        '
        Me.cmbNJoueurs.FormattingEnabled = True
        Me.cmbNJoueurs.Items.AddRange(New Object() {"2", "3", "4", "5", "6"})
        Me.cmbNJoueurs.Location = New System.Drawing.Point(316, 38)
        Me.cmbNJoueurs.Name = "cmbNJoueurs"
        Me.cmbNJoueurs.Size = New System.Drawing.Size(143, 28)
        Me.cmbNJoueurs.TabIndex = 31
        '
        'txtJ3
        '
        Me.txtJ3.Location = New System.Drawing.Point(123, 210)
        Me.txtJ3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJ3.Name = "txtJ3"
        Me.txtJ3.Size = New System.Drawing.Size(163, 26)
        Me.txtJ3.TabIndex = 35
        Me.txtJ3.Visible = False
        '
        'lblJ4
        '
        Me.lblJ4.AutoSize = True
        Me.lblJ4.Location = New System.Drawing.Point(354, 185)
        Me.lblJ4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ4.Name = "lblJ4"
        Me.lblJ4.Size = New System.Drawing.Size(71, 20)
        Me.lblJ4.TabIndex = 34
        Me.lblJ4.Text = "Joueur 4"
        Me.lblJ4.Visible = False
        '
        'lblJ3
        '
        Me.lblJ3.AutoSize = True
        Me.lblJ3.Location = New System.Drawing.Point(170, 185)
        Me.lblJ3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ3.Name = "lblJ3"
        Me.lblJ3.Size = New System.Drawing.Size(71, 20)
        Me.lblJ3.TabIndex = 33
        Me.lblJ3.Text = "Joueur 3"
        Me.lblJ3.Visible = False
        '
        'txtJ4
        '
        Me.txtJ4.Location = New System.Drawing.Point(316, 210)
        Me.txtJ4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJ4.Name = "txtJ4"
        Me.txtJ4.Size = New System.Drawing.Size(163, 26)
        Me.txtJ4.TabIndex = 32
        Me.txtJ4.Visible = False
        '
        'txtJ5
        '
        Me.txtJ5.Location = New System.Drawing.Point(123, 285)
        Me.txtJ5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJ5.Name = "txtJ5"
        Me.txtJ5.Size = New System.Drawing.Size(163, 26)
        Me.txtJ5.TabIndex = 39
        Me.txtJ5.Visible = False
        '
        'lblJ6
        '
        Me.lblJ6.AutoSize = True
        Me.lblJ6.Location = New System.Drawing.Point(354, 260)
        Me.lblJ6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ6.Name = "lblJ6"
        Me.lblJ6.Size = New System.Drawing.Size(71, 20)
        Me.lblJ6.TabIndex = 38
        Me.lblJ6.Text = "Joueur 6"
        Me.lblJ6.Visible = False
        '
        'lblJ5
        '
        Me.lblJ5.AutoSize = True
        Me.lblJ5.Location = New System.Drawing.Point(170, 260)
        Me.lblJ5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJ5.Name = "lblJ5"
        Me.lblJ5.Size = New System.Drawing.Size(71, 20)
        Me.lblJ5.TabIndex = 37
        Me.lblJ5.Text = "Joueur 5"
        Me.lblJ5.Visible = False
        '
        'txtJ6
        '
        Me.txtJ6.Location = New System.Drawing.Point(316, 285)
        Me.txtJ6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJ6.Name = "txtJ6"
        Me.txtJ6.Size = New System.Drawing.Size(163, 26)
        Me.txtJ6.TabIndex = 36
        Me.txtJ6.Visible = False
        '
        'NumStarting
        '
        Me.NumStarting.Location = New System.Drawing.Point(129, 351)
        Me.NumStarting.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumStarting.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumStarting.Name = "NumStarting"
        Me.NumStarting.Size = New System.Drawing.Size(120, 26)
        Me.NumStarting.TabIndex = 40
        Me.NumStarting.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblStarting
        '
        Me.lblStarting.AutoSize = True
        Me.lblStarting.Location = New System.Drawing.Point(45, 357)
        Me.lblStarting.Name = "lblStarting"
        Me.lblStarting.Size = New System.Drawing.Size(78, 20)
        Me.lblStarting.TabIndex = 41
        Me.lblStarting.Text = "Starting $"
        '
        'lblBlinds
        '
        Me.lblBlinds.AutoSize = True
        Me.lblBlinds.Location = New System.Drawing.Point(312, 357)
        Me.lblBlinds.Name = "lblBlinds"
        Me.lblBlinds.Size = New System.Drawing.Size(52, 20)
        Me.lblBlinds.TabIndex = 42
        Me.lblBlinds.Text = "Blinds"
        '
        'NumBlinds
        '
        Me.NumBlinds.Location = New System.Drawing.Point(370, 355)
        Me.NumBlinds.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumBlinds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumBlinds.Name = "NumBlinds"
        Me.NumBlinds.Size = New System.Drawing.Size(120, 26)
        Me.NumBlinds.TabIndex = 43
        Me.NumBlinds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PokerStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 545)
        Me.Controls.Add(Me.NumBlinds)
        Me.Controls.Add(Me.lblBlinds)
        Me.Controls.Add(Me.lblStarting)
        Me.Controls.Add(Me.NumStarting)
        Me.Controls.Add(Me.txtJ5)
        Me.Controls.Add(Me.lblJ6)
        Me.Controls.Add(Me.lblJ5)
        Me.Controls.Add(Me.txtJ6)
        Me.Controls.Add(Me.txtJ3)
        Me.Controls.Add(Me.lblJ4)
        Me.Controls.Add(Me.lblJ3)
        Me.Controls.Add(Me.txtJ4)
        Me.Controls.Add(Me.cmbNJoueurs)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCommencer)
        Me.Controls.Add(Me.txtJoueur1)
        Me.Controls.Add(Me.lblJoueur2)
        Me.Controls.Add(Me.lblJoueur1)
        Me.Controls.Add(Me.txtJoueur2)
        Me.Controls.Add(Me.lblNJoueurs)
        Me.Name = "PokerStart"
        Me.Text = "PokerStart"
        CType(Me.NumStarting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBlinds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnCommencer As System.Windows.Forms.Button
    Friend WithEvents txtJoueur1 As System.Windows.Forms.TextBox
    Friend WithEvents lblJoueur2 As System.Windows.Forms.Label
    Friend WithEvents lblJoueur1 As System.Windows.Forms.Label
    Friend WithEvents txtJoueur2 As System.Windows.Forms.TextBox
    Friend WithEvents lblNJoueurs As System.Windows.Forms.Label
    Friend WithEvents cmbNJoueurs As System.Windows.Forms.ComboBox
    Friend WithEvents txtJ3 As System.Windows.Forms.TextBox
    Friend WithEvents lblJ4 As System.Windows.Forms.Label
    Friend WithEvents lblJ3 As System.Windows.Forms.Label
    Friend WithEvents txtJ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtJ5 As System.Windows.Forms.TextBox
    Friend WithEvents lblJ6 As System.Windows.Forms.Label
    Friend WithEvents lblJ5 As System.Windows.Forms.Label
    Friend WithEvents txtJ6 As System.Windows.Forms.TextBox
    Friend WithEvents NumStarting As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStarting As System.Windows.Forms.Label
    Friend WithEvents lblBlinds As System.Windows.Forms.Label
    Friend WithEvents NumBlinds As System.Windows.Forms.NumericUpDown
End Class
