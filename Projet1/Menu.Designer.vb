<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JeuxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicTacToeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpacitéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MouvementParticulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JeuxToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.PropriétésToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(580, 47)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JeuxToolStripMenuItem
        '
        Me.JeuxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicTacToeToolStripMenuItem, Me.DamesToolStripMenuItem, Me.PokerToolStripMenuItem})
        Me.JeuxToolStripMenuItem.Name = "JeuxToolStripMenuItem"
        Me.JeuxToolStripMenuItem.Size = New System.Drawing.Size(74, 39)
        Me.JeuxToolStripMenuItem.Text = "Jeux"
        '
        'TicTacToeToolStripMenuItem
        '
        Me.TicTacToeToolStripMenuItem.Name = "TicTacToeToolStripMenuItem"
        Me.TicTacToeToolStripMenuItem.Size = New System.Drawing.Size(214, 40)
        Me.TicTacToeToolStripMenuItem.Text = "Tic Tac Toe"
        '
        'DamesToolStripMenuItem
        '
        Me.DamesToolStripMenuItem.Name = "DamesToolStripMenuItem"
        Me.DamesToolStripMenuItem.Size = New System.Drawing.Size(214, 40)
        Me.DamesToolStripMenuItem.Text = "Dames"
        '
        'PokerToolStripMenuItem
        '
        Me.PokerToolStripMenuItem.Name = "PokerToolStripMenuItem"
        Me.PokerToolStripMenuItem.Size = New System.Drawing.Size(214, 40)
        Me.PokerToolStripMenuItem.Text = "Poker"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatriceToolStripMenuItem, Me.MouvementParticulesToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(91, 39)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'CalculatriceToolStripMenuItem
        '
        Me.CalculatriceToolStripMenuItem.Name = "CalculatriceToolStripMenuItem"
        Me.CalculatriceToolStripMenuItem.Size = New System.Drawing.Size(217, 40)
        Me.CalculatriceToolStripMenuItem.Text = "Calculatrice"
        '
        'PropriétésToolStripMenuItem
        '
        Me.PropriétésToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpacitéToolStripMenuItem})
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        Me.PropriétésToolStripMenuItem.Size = New System.Drawing.Size(140, 39)
        Me.PropriétésToolStripMenuItem.Text = "Propriétés"
        '
        'OpacitéToolStripMenuItem
        '
        Me.OpacitéToolStripMenuItem.Name = "OpacitéToolStripMenuItem"
        Me.OpacitéToolStripMenuItem.Size = New System.Drawing.Size(176, 40)
        Me.OpacitéToolStripMenuItem.Text = "Opacité"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bonjour, et bienvenue aux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "projets de Paul Laplante"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MouvementParticulesToolStripMenuItem
        '
        Me.MouvementParticulesToolStripMenuItem.Name = "MouvementParticulesToolStripMenuItem"
        Me.MouvementParticulesToolStripMenuItem.Size = New System.Drawing.Size(336, 40)
        Me.MouvementParticulesToolStripMenuItem.Text = "Mouvement Particules"
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 514)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Menu1"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents JeuxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PropriétésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpacitéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicTacToeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PokerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MouvementParticulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
