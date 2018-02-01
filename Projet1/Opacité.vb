Public Class Opacité

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        opchange = True
        opacite = TrackBar1.Value / 10
        Me.Opacity = opacite
    End Sub

    Private Sub Opacité_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite
        TrackBar1.Value = opacite * 10
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Menu1.Show()
        Me.Close()
    End Sub
End Class