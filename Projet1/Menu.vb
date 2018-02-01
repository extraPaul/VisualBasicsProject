Public Class Menu1

    Dim lb1X As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If opchange = False Then
            opacite = 1
        End If

        Me.Opacity = opacite
        lb1X = Label1.Left
        Label1.Left = (Me.Width / 2 - Label1.Width / 2)
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        Label1.Font = New Font("Comic Sans sm", 15)
        Label1.Left = (Me.Width / 2 - Label1.Width / 2)
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.Font = DefaultFont
        Label1.Left = (Me.Width / 2 - Label1.Width / 2)
    End Sub

    Private Sub OpacitéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpacitéToolStripMenuItem.Click
        Opacité.Show()
        Me.Close()
    End Sub

    Private Sub TicTacToeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicTacToeToolStripMenuItem.Click
        Game = "Tic Tac Toe"
        TicTacToe2.Show()
        Me.Close()
    End Sub

    Private Sub CalculatriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatriceToolStripMenuItem.Click
        Calculatrice.Show()
        Me.Close()
    End Sub

    Private Sub DamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamesToolStripMenuItem.Click
        Game = "Dames"
        TicTacToe2.Show()
        Me.Close()
    End Sub

    Private Sub PokerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PokerToolStripMenuItem.Click
        PokerStart.Show()
        Me.Close()
    End Sub

    Private Sub MouvementParticulesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MouvementParticulesToolStripMenuItem.Click
        MouvementCharges.Show()
        Me.Close()
    End Sub
End Class
