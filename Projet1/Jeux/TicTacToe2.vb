Public Class TicTacToe2


    Private Sub TicTacToe2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite
        Me.Text = Game
        If Game = "Dames" Then
            chb2.Checked = True
            chb1.Enabled = False
            chbFacile.Visible = True
            chbFacile.Checked = True
            chbAssistant.Visible = True
            chbAssistant.Checked = True
            btnInfo.Visible = True
        End If
    End Sub

    Private Sub btnCommencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommencer.Click
        Joueur1 = txtJoueur1.Text
        Joueur2 = txtJoueur2.Text
        If chb1.Checked = True And cmbNiveau.SelectedItem = "" Or chb1.Checked = False And chb2.Checked = False Then
            MsgBox("Vous devez finir de remplir le formulaire.", MsgBoxStyle.Critical, "Attention")
        Else
            If Game = "Tic Tac Toe" Then
                TicTacToe.Show()
            ElseIf Game = "Dames" Then
                Dames.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub chb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb1.CheckedChanged
        If chb1.Checked = True Then
            chb2.Checked = False
            oneplayer = True
        End If
        lblJoueur1.Visible = True
        lblJoueur2.Visible = True
        txtJoueur1.Visible = True
        txtJoueur2.Visible = True
        txtJoueur2.ReadOnly = True
        txtJoueur2.Text = "Ordinateur"
        lblNiveau.Visible = True
        cmbNiveau.Visible = True
    End Sub

    Private Sub chb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb2.CheckedChanged
        If chb2.Checked = True Then
            chb1.Checked = False
            oneplayer = False
        End If
        lblJoueur1.Visible = True
        lblJoueur2.Visible = True
        txtJoueur1.Visible = True
        txtJoueur2.Visible = True
        txtJoueur2.ReadOnly = False
        txtJoueur2.Text = ""
        lblNiveau.Visible = False
        cmbNiveau.Visible = False
    End Sub

    Private Sub cmbNiveau_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNiveau.SelectedIndexChanged
        If cmbNiveau.SelectedItem = "Facile" Then
            NiveauFacile = True
        ElseIf cmbNiveau.SelectedItem = "Difficile" Then
            NiveauFacile = False
        End If
    End Sub

    Private Sub chbFacile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFacile.CheckedChanged
        If chbFacile.Checked = True Then
            NiveauFacile = True
        Else
            NiveauFacile = False
        End If
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        MsgBox("Lorsque le mode débutant est sélectionné, les joueurs ne sont pas forcés à manger lorsqu'ils le peuvent. Quand il n'est pas sélectionné, les règlements normaux s'appliquent et les joueurs doivent manger lorsqu'ils le peuvent. Quand l'assistant est allumé, les cases où une pièce peut bouger deviennent verte. Note : si une pièce mange une autre pièce et est encore active, c'est qu'elle est capable de manger une autre pièce.", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub chbAssistant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAssistant.CheckedChanged
        If chbAssistant.Checked = True Then
            Assistant = True
        Else
            Assistant = False
        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Menu1.Show()
        Me.Close()
    End Sub
End Class