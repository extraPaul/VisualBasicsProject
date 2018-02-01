Public Class AddPart

    Private Sub AddPart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite
        Timer1.Enabled = True
        Timer1.Interval = 500
        numMasse.Value = Particules.Item(editP).masse
        numSize.Value = Particules.Item(editP).size
        numMasse.Minimum = 1
        numSize.Minimum = 1
        numParticule.Maximum = Particules.Count - 1
        numParticule.Value = editP
        numPosX.Maximum = MouvementCharges.Width + 5
        numPosY.Maximum = MouvementCharges.Height + 5
    End Sub

    Private Sub numMasse_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numMasse.ValueChanged
        Particules.Item(editP).masse = numMasse.Value
    End Sub

    Private Sub numCharge_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numCharge.ValueChanged
        Particules.Item(editP).charge = numCharge.Value / 1000
        Particules.Item(editP).setImage()
    End Sub

    Private Sub numPosX_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numPosX.ValueChanged
        Particules.Item(editP).pos(0) = numPosX.Value
    End Sub

    Private Sub numPosY_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numPosY.ValueChanged
        Particules.Item(editP).pos(1) = numPosY.Value + 24
    End Sub

    Private Sub btnTermine_Click(sender As System.Object, e As System.EventArgs) Handles btnTermine.Click
        Me.Close()
    End Sub

    Private Sub numSize_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numSize.ValueChanged
        Particules.Item(editP).size = numSize.Value
    End Sub

    Private Sub chkFixed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFixed.CheckedChanged
        Particules.Item(editP).fixed = chkFixed.CheckState
    End Sub

    Private Sub numVx_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numVx.ValueChanged
        Particules.Item(editP).V(0) = numVx.Value
    End Sub

    Private Sub numVy_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numVy.ValueChanged
        Particules.Item(editP).V(1) = -numVy.Value
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        For i = 0 To Particules.Count - 1
            Particules.Item(i).isColliding.Remove(Particules.Item(i).isColliding.Item(editP))
            If i > editP Then
                Particules.Item(i).listIndex = Particules.Item(i).listIndex - 1
            End If
        Next
        Particules.Item(editP).pic.Visible = False
        Particules.Remove(Particules.Item(editP))
        nP = nP - 1

        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        numCharge.Value = Particules.Item(editP).charge * 1000
        numMasse.Value = Particules.Item(editP).masse
        numPosX.Value = Particules.Item(editP).position.X
        numPosY.Value = Particules.Item(editP).position.Y - 24
        numSize.Value = Particules.Item(editP).size
        chkFixed.Checked = Particules.Item(editP).fixed
        numVx.Value = Particules.Item(editP).V(0)
        numVy.Value = -Particules.Item(editP).V(1)
        lblFx.Text = Particules.Item(editP).FT(0).ToString()
        lblFy.Text = Particules.Item(editP).FT(1).ToString()
    End Sub

    Private Sub numParticule_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numParticule.ValueChanged
        editP = numParticule.Value
    End Sub
End Class