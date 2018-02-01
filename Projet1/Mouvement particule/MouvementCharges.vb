Public Class MouvementCharges

    Private Sub MouvementCharges_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite
        nP = 0
        Timer1.Interval = 10
    End Sub

    Private Sub AjouterChargeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterChargeToolStripMenuItem.Click
        Particules.Add(New Particule(nP))
        Particules.Item(nP).pic.Visible = True
        Particules.Item(nP).pic.SizeMode = PictureBoxSizeMode.StretchImage
        Particules.Item(nP).setImage()
        Controls.Add(Particules.Item(nP).pic)
        AddHandler Particules.Item(nP).pic.Click, AddressOf ClickParticule
        AddHandler Particules.Item(nP).pic.MouseDown, AddressOf DragAndDropStart
        AddHandler Particules.Item(nP).pic.MouseUp, AddressOf DragStop

        editP = nP
        AddPart.Show()

        Timer1.Enabled = True
        nP = nP + 1

        For i = 0 To Particules.Count - 1
            Particules.Item(nP - 1).isColliding.Add(New Boolean)
        Next
        If nP > 1 Then
            For i = 0 To Particules.Count - 2
                Particules.Item(i).isColliding.Add(New Boolean)
            Next
        End If
    End Sub

    Sub DrawPart(ByVal num As Integer)
        Particules.Item(num).pic.Size = New System.Drawing.Size(Particules.Item(num).size, Particules.Item(num).size)

        Particules.Item(num).pic.Location = Particules.Item(num).position
    End Sub

    Sub CheckWindowBounds(ByVal num As Integer)
        If Particules.Item(num).pic.Right > Me.ClientRectangle.Right Or Particules.Item(num).pic.Left < Me.ClientRectangle.Left Then
            Particules.Item(num).V(0) = -Particules.Item(num).V(0)
            Particules.Item(num).pos(0) = Particules.Item(num).pos(0) + Particules.Item(num).V(0)
        End If
        If Particules.Item(num).pic.Bottom > Me.ClientRectangle.Bottom Or Particules.Item(num).pic.Top < Me.ClientRectangle.Top + 24 Then
            Particules.Item(num).V(1) = -Particules.Item(num).V(1)
            Particules.Item(num).pos(1) = Particules.Item(num).pos(1) + Particules.Item(num).V(1)
        End If
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Particules.Count = 0 Then
            Timer1.Enabled = False
        End If
        For i = 0 To Particules.Count - 1
            DrawPart(i)
            For j = 0 To Particules.Count - 1
                If i <> j Then
                    Particules.Item(i).calcFe(Particules.Item(j))
                    Particules.Item(i).calcFg(Particules.Item(j))
                    If i < j Then
                        Particules.Item(i).checkColision(Particules.Item(j))
                    End If
                End If
            Next
            CheckWindowBounds(i)
            Particules.Item(i).calcFx()
            Particules.Item(i).calcFy()
            Particules.Item(i).calcA()
            Particules.Item(i).calcV()
            If Particules.Item(i).fixed = False Then
                Particules.Item(i).pos(0) = Particules.Item(i).pos(0) + Particules.Item(i).V(0) / 5
                Particules.Item(i).pos(1) = Particules.Item(i).pos(1) + Particules.Item(i).V(1) / 5
            End If
            Particules.Item(i).position = New System.Drawing.Point(Particules.Item(i).pos(0), Particules.Item(i).pos(1))
            If Particules.Item(i).beingDragged = True Then
                Particules.Item(i).pos(0) = Control.MousePosition.X - Me.Location.X
                Particules.Item(i).pos(1) = Control.MousePosition.Y - Me.Location.Y
            End If
        Next
    End Sub

    Private Sub ClickParticule(sender As System.Object, e As System.EventArgs)
        Dim part1 As PictureBox = DirectCast(sender, PictureBox)
        For i = 0 To Particules.Count - 1
            If Particules.Item(i).pic.Equals(part1) Then
                editP = i
                AddPart.Show()
            End If
        Next
    End Sub

    Private Sub DragAndDropStart(sender As System.Object, e As System.EventArgs)
        Dim part1 As PictureBox = DirectCast(sender, PictureBox)
        For i = 0 To Particules.Count - 1
            If Particules.Item(i).pic.Equals(part1) Then
                Particules.Item(i).beingDragged = True
            End If
        Next
    End Sub

    Private Sub DragStop(sender As System.Object, e As System.EventArgs)
        Dim part1 As PictureBox = DirectCast(sender, PictureBox)
        For i = 0 To Particules.Count - 1
            If Particules.Item(i).pic.Equals(part1) Then
                Particules.Item(i).beingDragged = False
            End If
        Next
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        Timer1.Enabled = True
    End Sub

    Private Sub PauseToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PauseToolStripMenuItem1.Click
        Timer1.Enabled = False
    End Sub
End Class