<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPart
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMasse = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.lblPossition = New System.Windows.Forms.Label()
        Me.btnTermine = New System.Windows.Forms.Button()
        Me.numMasse = New System.Windows.Forms.NumericUpDown()
        Me.numCharge = New System.Windows.Forms.NumericUpDown()
        Me.numPosX = New System.Windows.Forms.NumericUpDown()
        Me.numPosY = New System.Windows.Forms.NumericUpDown()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.numSize = New System.Windows.Forms.NumericUpDown()
        Me.chkFixed = New System.Windows.Forms.CheckBox()
        Me.lvlVitesseX = New System.Windows.Forms.Label()
        Me.numVx = New System.Windows.Forms.NumericUpDown()
        Me.lblVY = New System.Windows.Forms.Label()
        Me.numVy = New System.Windows.Forms.NumericUpDown()
        Me.lblForceX = New System.Windows.Forms.Label()
        Me.lblForceY = New System.Windows.Forms.Label()
        Me.lblFx = New System.Windows.Forms.Label()
        Me.lblFy = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblParticule = New System.Windows.Forms.Label()
        Me.numParticule = New System.Windows.Forms.NumericUpDown()
        CType(Me.numMasse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPosX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPosY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numVx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numVy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParticule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMasse
        '
        Me.lblMasse.AutoSize = True
        Me.lblMasse.Location = New System.Drawing.Point(119, 135)
        Me.lblMasse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasse.Name = "lblMasse"
        Me.lblMasse.Size = New System.Drawing.Size(106, 32)
        Me.lblMasse.TabIndex = 1
        Me.lblMasse.Text = "Masse:"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(119, 212)
        Me.lblCharge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(116, 32)
        Me.lblCharge.TabIndex = 2
        Me.lblCharge.Text = "Charge:"
        '
        'lblPossition
        '
        Me.lblPossition.AutoSize = True
        Me.lblPossition.Location = New System.Drawing.Point(119, 290)
        Me.lblPossition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPossition.Name = "lblPossition"
        Me.lblPossition.Size = New System.Drawing.Size(126, 32)
        Me.lblPossition.TabIndex = 4
        Me.lblPossition.Text = "Position:"
        '
        'btnTermine
        '
        Me.btnTermine.Location = New System.Drawing.Point(240, 479)
        Me.btnTermine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTermine.Name = "btnTermine"
        Me.btnTermine.Size = New System.Drawing.Size(241, 89)
        Me.btnTermine.TabIndex = 6
        Me.btnTermine.Text = "Terminé"
        Me.btnTermine.UseVisualStyleBackColor = True
        '
        'numMasse
        '
        Me.numMasse.Location = New System.Drawing.Point(281, 133)
        Me.numMasse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numMasse.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.numMasse.Name = "numMasse"
        Me.numMasse.Size = New System.Drawing.Size(227, 38)
        Me.numMasse.TabIndex = 7
        '
        'numCharge
        '
        Me.numCharge.Location = New System.Drawing.Point(281, 205)
        Me.numCharge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numCharge.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numCharge.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.numCharge.Name = "numCharge"
        Me.numCharge.Size = New System.Drawing.Size(160, 38)
        Me.numCharge.TabIndex = 8
        '
        'numPosX
        '
        Me.numPosX.Location = New System.Drawing.Point(281, 283)
        Me.numPosX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numPosX.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numPosX.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.numPosX.Name = "numPosX"
        Me.numPosX.Size = New System.Drawing.Size(115, 38)
        Me.numPosX.TabIndex = 9
        '
        'numPosY
        '
        Me.numPosY.Location = New System.Drawing.Point(404, 283)
        Me.numPosY.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numPosY.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numPosY.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.numPosY.Name = "numPosY"
        Me.numPosY.Size = New System.Drawing.Size(104, 38)
        Me.numPosY.TabIndex = 10
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(125, 367)
        Me.lblSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(143, 32)
        Me.lblSize.TabIndex = 11
        Me.lblSize.Text = "Grandeur:"
        '
        'numSize
        '
        Me.numSize.Location = New System.Drawing.Point(281, 360)
        Me.numSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numSize.Name = "numSize"
        Me.numSize.Size = New System.Drawing.Size(160, 38)
        Me.numSize.TabIndex = 12
        '
        'chkFixed
        '
        Me.chkFixed.AutoSize = True
        Me.chkFixed.Location = New System.Drawing.Point(624, 130)
        Me.chkFixed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkFixed.Name = "chkFixed"
        Me.chkFixed.Size = New System.Drawing.Size(123, 36)
        Me.chkFixed.TabIndex = 13
        Me.chkFixed.Text = "Fixed"
        Me.chkFixed.UseVisualStyleBackColor = True
        '
        'lvlVitesseX
        '
        Me.lvlVitesseX.AutoSize = True
        Me.lvlVitesseX.Location = New System.Drawing.Point(601, 205)
        Me.lvlVitesseX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lvlVitesseX.Name = "lvlVitesseX"
        Me.lvlVitesseX.Size = New System.Drawing.Size(143, 32)
        Me.lvlVitesseX.TabIndex = 14
        Me.lvlVitesseX.Text = "Vitesse X:"
        '
        'numVx
        '
        Me.numVx.Location = New System.Drawing.Point(767, 202)
        Me.numVx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numVx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numVx.Name = "numVx"
        Me.numVx.Size = New System.Drawing.Size(160, 38)
        Me.numVx.TabIndex = 15
        '
        'lblVY
        '
        Me.lblVY.AutoSize = True
        Me.lblVY.Location = New System.Drawing.Point(608, 288)
        Me.lblVY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVY.Name = "lblVY"
        Me.lblVY.Size = New System.Drawing.Size(143, 32)
        Me.lblVY.TabIndex = 16
        Me.lblVY.Text = "Vitesse Y:"
        '
        'numVy
        '
        Me.numVy.Location = New System.Drawing.Point(767, 288)
        Me.numVy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numVy.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numVy.Name = "numVy"
        Me.numVy.Size = New System.Drawing.Size(160, 38)
        Me.numVy.TabIndex = 17
        '
        'lblForceX
        '
        Me.lblForceX.AutoSize = True
        Me.lblForceX.Location = New System.Drawing.Point(615, 360)
        Me.lblForceX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForceX.Name = "lblForceX"
        Me.lblForceX.Size = New System.Drawing.Size(121, 32)
        Me.lblForceX.TabIndex = 18
        Me.lblForceX.Text = "Force X:"
        '
        'lblForceY
        '
        Me.lblForceY.AutoSize = True
        Me.lblForceY.Location = New System.Drawing.Point(615, 414)
        Me.lblForceY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForceY.Name = "lblForceY"
        Me.lblForceY.Size = New System.Drawing.Size(121, 32)
        Me.lblForceY.TabIndex = 19
        Me.lblForceY.Text = "Force Y:"
        '
        'lblFx
        '
        Me.lblFx.AutoSize = True
        Me.lblFx.Location = New System.Drawing.Point(748, 362)
        Me.lblFx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFx.Name = "lblFx"
        Me.lblFx.Size = New System.Drawing.Size(102, 32)
        Me.lblFx.TabIndex = 20
        Me.lblFx.Text = "Label1"
        '
        'lblFy
        '
        Me.lblFy.AutoSize = True
        Me.lblFy.Location = New System.Drawing.Point(748, 414)
        Me.lblFy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFy.Name = "lblFy"
        Me.lblFy.Size = New System.Drawing.Size(102, 32)
        Me.lblFy.TabIndex = 21
        Me.lblFy.Text = "Label1"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(615, 479)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(172, 81)
        Me.btnRemove.TabIndex = 22
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblParticule
        '
        Me.lblParticule.AutoSize = True
        Me.lblParticule.Location = New System.Drawing.Point(397, 53)
        Me.lblParticule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParticule.Name = "lblParticule"
        Me.lblParticule.Size = New System.Drawing.Size(135, 32)
        Me.lblParticule.TabIndex = 23
        Me.lblParticule.Text = "Particule:"
        '
        'numParticule
        '
        Me.numParticule.Location = New System.Drawing.Point(553, 53)
        Me.numParticule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numParticule.Name = "numParticule"
        Me.numParticule.Size = New System.Drawing.Size(160, 38)
        Me.numParticule.TabIndex = 24
        '
        'AddPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 641)
        Me.Controls.Add(Me.numParticule)
        Me.Controls.Add(Me.lblParticule)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblFy)
        Me.Controls.Add(Me.lblFx)
        Me.Controls.Add(Me.lblForceY)
        Me.Controls.Add(Me.lblForceX)
        Me.Controls.Add(Me.numVy)
        Me.Controls.Add(Me.lblVY)
        Me.Controls.Add(Me.numVx)
        Me.Controls.Add(Me.lvlVitesseX)
        Me.Controls.Add(Me.chkFixed)
        Me.Controls.Add(Me.numSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.numPosY)
        Me.Controls.Add(Me.numPosX)
        Me.Controls.Add(Me.numCharge)
        Me.Controls.Add(Me.numMasse)
        Me.Controls.Add(Me.btnTermine)
        Me.Controls.Add(Me.lblPossition)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.lblMasse)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddPart"
        Me.Text = "AddPart"
        CType(Me.numMasse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPosX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPosY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numVx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numVy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParticule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMasse As System.Windows.Forms.Label
    Friend WithEvents lblCharge As System.Windows.Forms.Label
    Friend WithEvents lblPossition As System.Windows.Forms.Label
    Friend WithEvents btnTermine As System.Windows.Forms.Button
    Friend WithEvents numMasse As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCharge As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPosX As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPosY As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents numSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkFixed As System.Windows.Forms.CheckBox
    Friend WithEvents lvlVitesseX As System.Windows.Forms.Label
    Friend WithEvents numVx As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblVY As System.Windows.Forms.Label
    Friend WithEvents numVy As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblForceX As System.Windows.Forms.Label
    Friend WithEvents lblForceY As System.Windows.Forms.Label
    Friend WithEvents lblFx As System.Windows.Forms.Label
    Friend WithEvents lblFy As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblParticule As System.Windows.Forms.Label
    Friend WithEvents numParticule As System.Windows.Forms.NumericUpDown
End Class
