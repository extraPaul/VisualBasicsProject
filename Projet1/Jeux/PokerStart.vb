Public Class PokerStart

    Private Sub PokerStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite

    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Menu1.Show()
        Me.Close()
    End Sub

    Private Sub cmbNJoueurs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNJoueurs.SelectedIndexChanged
        NmbJoueurs = cmbNJoueurs.SelectedItem
        lblJoueur1.Visible = True
        txtJoueur1.Visible = True
        lblJoueur2.Visible = True
        txtJoueur2.Visible = True

        If NmbJoueurs > 2 Then
            lblJ3.Visible = True
            txtJ3.Visible = True
        Else
            lblJ3.Visible = False
            txtJ3.Visible = False
        End If

        If NmbJoueurs > 3 Then
            lblJ4.Visible = True
            txtJ4.Visible = True
        Else
            lblJ4.Visible = False
            txtJ4.Visible = False
        End If

        If NmbJoueurs > 4 Then
            lblJ5.Visible = True
            txtJ5.Visible = True
        Else
            lblJ5.Visible = False
            txtJ5.Visible = False
        End If

        If NmbJoueurs > 5 Then
            lblJ6.Visible = True
            txtJ6.Visible = True
        Else
            lblJ6.Visible = False
            txtJ6.Visible = False
        End If

        btnCommencer.Visible = True
    End Sub

    Private Sub btnCommencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommencer.Click
        If txtJoueur1.Text = "" Then
            Joueur(0) = "Joueur 1"
        Else
            Joueur(0) = txtJoueur1.Text
        End If

        If txtJoueur2.Text = "" Then
            Joueur(1) = "Joueur 2"
        Else
            Joueur(1) = txtJoueur2.Text
        End If

        If txtJ3.Text = "" Then
            Joueur(2) = "Joueur 3"
        Else
            Joueur(2) = txtJ3.Text
        End If

        If txtJ4.Text = "" Then
            Joueur(3) = "Joueur 4"
        Else
            Joueur(3) = txtJ4.Text
        End If

        If txtJ5.Text = "" Then
            Joueur(4) = "Joueur 5"
        Else
            Joueur(4) = txtJ5.Text
        End If

        If txtJ6.Text = "" Then
            Joueur(5) = "Joueur 6"
        Else
            Joueur(5) = txtJ6.Text
        End If

        StartMoney = NumStarting.Value
        Blinds = NumBlinds.Value

        Poker.Show()
        Me.Close()
    End Sub

    Private Sub NumBlinds_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumBlinds.ValueChanged
        NumBlinds.Maximum = NumStarting.Value
    End Sub

    Private Sub NumStarting_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumStarting.ValueChanged
        NumBlinds.Maximum = NumStarting.Value
    End Sub
End Class