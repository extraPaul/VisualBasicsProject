<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opacité
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblOpacité = New System.Windows.Forms.Label()
        Me.lblplus = New System.Windows.Forms.Label()
        Me.lblmoins = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(54, 42)
        Me.TrackBar1.Minimum = 5
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(166, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 5
        '
        'lblOpacité
        '
        Me.lblOpacité.AutoSize = True
        Me.lblOpacité.Location = New System.Drawing.Point(116, 9)
        Me.lblOpacité.Name = "lblOpacité"
        Me.lblOpacité.Size = New System.Drawing.Size(44, 13)
        Me.lblOpacité.TabIndex = 1
        Me.lblOpacité.Text = "Opacité"
        '
        'lblplus
        '
        Me.lblplus.AutoSize = True
        Me.lblplus.Location = New System.Drawing.Point(207, 23)
        Me.lblplus.Name = "lblplus"
        Me.lblplus.Size = New System.Drawing.Size(13, 13)
        Me.lblplus.TabIndex = 2
        Me.lblplus.Text = "+"
        '
        'lblmoins
        '
        Me.lblmoins.AutoSize = True
        Me.lblmoins.Location = New System.Drawing.Point(54, 23)
        Me.lblmoins.Name = "lblmoins"
        Me.lblmoins.Size = New System.Drawing.Size(10, 13)
        Me.lblmoins.TabIndex = 3
        Me.lblmoins.Text = "-"
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(103, 93)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Opacité
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 146)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblmoins)
        Me.Controls.Add(Me.lblplus)
        Me.Controls.Add(Me.lblOpacité)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "Opacité"
        Me.Text = "Opacité"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents lblOpacité As System.Windows.Forms.Label
    Friend WithEvents lblplus As System.Windows.Forms.Label
    Friend WithEvents lblmoins As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
