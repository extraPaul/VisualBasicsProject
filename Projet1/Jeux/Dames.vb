Public Class Dames
    Dim Pièces(1, 11), Cases(7, 3), PicClicked, LastClick As PictureBox
    Dim Clicked(1, 11), King(1, 11) As Boolean
    Dim a, b, c, d, f, g, j, k, v, w, x, y, Points(1), Occupied(7, 3), PieceCountRed, PieceCoundWhite As Integer
    'Points: 1 = rouge et 0 = blanc
    'Occupied: +1 = rouge et -1 = blanc
    Dim CercleRouge, CercleBlanc, KingCercleRouge, KingCercleBlanc As Image
    Dim Point1, Point2 As Point
    Dim TurnRed, Available(7, 3), EatAvailable(7, 3), EatPossible(7, 3), SomethingClicked, SomethingEaten, SomethingKinged, SomethingAvailable, SomethingAvailableEat, PossibleToEat, JustKinged As Boolean
    'EatAvailable = une case où une pièce peut aller et manger une autre pièce
    'EatPossible = une case où se trouve une pièce qui peut en manger une autre
    'JustKinged: si une pièce vient de devenir roi, cela empêchera qu'elle mange une autre pièce imédiatement.
    Dim CaseClicked As Object


    Private Sub Dames_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite

        lblNomJ1.Text = Joueur1
        lblNomJ2.Text = Joueur2

        CercleBlanc = System.Drawing.Image.FromFile("whitecircle.png")
        CercleRouge = System.Drawing.Image.FromFile("redcircle.png")
        KingCercleRouge = System.Drawing.Image.FromFile("kingredcircle.png")
        KingCercleBlanc = System.Drawing.Image.FromFile("kingwhitecircle.png")

        Cases(0, 0) = Pic2
        Cases(0, 1) = Pic4
        Cases(0, 2) = Pic6
        Cases(0, 3) = Pic8
        Cases(1, 0) = Pic9
        Cases(1, 1) = Pic11
        Cases(1, 2) = Pic13
        Cases(1, 3) = Pic15
        Cases(2, 0) = Pic18
        Cases(2, 1) = Pic20
        Cases(2, 2) = Pic22
        Cases(2, 3) = Pic24
        Cases(3, 0) = Pic25
        Cases(3, 1) = Pic27
        Cases(3, 2) = Pic29
        Cases(3, 3) = Pic31
        Cases(4, 0) = Pic34
        Cases(4, 1) = Pic36
        Cases(4, 2) = Pic38
        Cases(4, 3) = Pic40
        Cases(5, 0) = Pic41
        Cases(5, 1) = Pic43
        Cases(5, 2) = Pic45
        Cases(5, 3) = Pic47
        Cases(6, 0) = Pic50
        Cases(6, 1) = Pic52
        Cases(6, 2) = Pic54
        Cases(6, 3) = Pic56
        Cases(7, 0) = Pic57
        Cases(7, 1) = Pic59
        Cases(7, 2) = Pic61
        Cases(7, 3) = Pic63

        Pièces(0, 0) = Piece0
        Pièces(0, 1) = Piece1
        Pièces(0, 2) = Piece2
        Pièces(0, 3) = Piece3
        Pièces(0, 4) = Piece4
        Pièces(0, 5) = Piece5
        Pièces(0, 6) = Piece6
        Pièces(0, 7) = Piece7
        Pièces(0, 8) = Piece8
        Pièces(0, 9) = Piece9
        Pièces(0, 10) = Piece10
        Pièces(0, 11) = Piece11
        Pièces(1, 0) = Piece12
        Pièces(1, 1) = Piece13
        Pièces(1, 2) = Piece14
        Pièces(1, 3) = Piece15
        Pièces(1, 4) = Piece16
        Pièces(1, 5) = Piece17
        Pièces(1, 6) = Piece18
        Pièces(1, 7) = Piece19
        Pièces(1, 8) = Piece20
        Pièces(1, 9) = Piece21
        Pièces(1, 10) = Piece22
        Pièces(1, 11) = Piece23


        Start()
    End Sub

    Sub Start()
        TurnRed = True
        picTurn.BackColor = Color.Red
        PieceCountRed = 12
        PieceCoundWhite = 12
        lblPointsR.Text = Points(1)
        lblPointsB.Text = Points(0)
        lblPiecesB.Text = PieceCoundWhite
        lblPiecesR.Text = PieceCountRed
        For m = 0 To 7
            For n = 0 To 3
                Available(m, n) = False
                Cases(m, n).BackColor = Color.Black
                Occupied(m, n) = 0
            Next
        Next
        For i = 0 To 11
            For h = 0 To 1
                King(h, i) = False
                Clicked(h, i) = False
            Next
        Next
        SomethingClicked = False
        SomethingKinged = False
        SomethingEaten = False
        SomethingAvailable = False
        SomethingAvailableEat = False

        x = 0
        y = 0
        For i = 0 To 11
            Pièces(0, i).Size = New System.Drawing.Size(50, 50)
            Pièces(0, i).Location = New System.Drawing.Point(Cases(x, y).Location.X + 10, Cases(x, y).Location.Y + 10)
            Pièces(0, i).Image = CercleBlanc
            Pièces(0, i).BringToFront()
            Pièces(0, i).SizeMode = PictureBoxSizeMode.StretchImage
            Pièces(0, i).BackColor = Color.Black
            Pièces(0, i).Visible = True
            Occupied(x, y) = -1

            If y = 3 Then
                y = 0
                x += 1
            Else
                y += 1
            End If
        Next

        x = 7
        y = 0
        For i = 0 To 11
            Pièces(1, i).Size = New System.Drawing.Size(50, 50)
            Pièces(1, i).Location = New System.Drawing.Point(Cases(x, y).Location.X + 10, Cases(x, y).Location.Y + 10)
            Pièces(1, i).Image = CercleRouge
            Pièces(1, i).BringToFront()
            Pièces(1, i).SizeMode = PictureBoxSizeMode.StretchImage
            Pièces(1, i).BackColor = Color.Black
            Pièces(1, i).Visible = True
            Occupied(x, y) = 1

            If y = 3 Then
                y = 0
                x -= 1
            Else
                y += 1
            End If
        Next
    End Sub


    Sub Unclick()
        Pièces(x, y).BackColor = Color.Black
        Clicked(x, y) = False
        SomethingClicked = False
        SomethingKinged = False
        SomethingEaten = False
        SomethingAvailableEat = False
        SomethingAvailable = False
        For m = 0 To 7
            For n = 0 To 3
                Available(m, n) = False
                EatAvailable(m, n) = False
                Cases(m, n).BackColor = Color.Black
            Next
        Next
    End Sub

    Sub ChangeTurn()
        PossibleToEat = False
        JustKinged = False
        For h = 0 To 7
            For i = 0 To 3
                EatPossible(h, i) = False
            Next
        Next
        If TurnRed = True Then
            TurnRed = False
            picTurn.BackColor = Color.White
            x = 0
        Else
            TurnRed = True
            picTurn.BackColor = Color.Red
            x = 1
        End If
        If NiveauFacile = False Then
            For m = 0 To 7
                For n = 0 To 3
                    If Occupied(m, n) = 1 And TurnRed = True Or Occupied(m, n) = -1 And TurnRed = False Then
                        a = m
                        b = n
                        Possiblilities()
                        If SomethingAvailableEat = True Then
                            EatPossible(m, n) = True
                            PossibleToEat = True
                            SomethingAvailableEat = False
                        End If
                        For h = 0 To 7
                            For i = 0 To 3
                                Available(h, i) = False
                                EatAvailable(h, i) = False
                            Next
                        Next
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub Pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic2.Click, Pic4.Click, Pic6.Click, Pic8.Click, Pic9.Click, Pic11.Click, Pic13.Click, Pic15.Click, Pic18.Click, Pic20.Click, Pic22.Click, Pic24.Click, Pic25.Click, Pic27.Click, Pic29.Click, Pic31.Click, Pic34.Click, Pic36.Click, Pic38.Click, Pic40.Click, Pic41.Click, Pic43.Click, Pic45.Click, Pic47.Click, Pic50.Click, Pic52.Click, Pic54.Click, Pic56.Click, Pic57.Click, Pic59.Click, Pic61.Click, Pic63.Click
        CaseClicked = sender
            ClickSomething()
    End Sub

    Private Sub Piece0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Piece0.Click, Piece1.Click, Piece2.Click, Piece3.Click, Piece4.Click, Piece5.Click, Piece6.Click, Piece7.Click, Piece8.Click, Piece9.Click, Piece10.Click, Piece11.Click, Piece12.Click, Piece13.Click, Piece14.Click, Piece15.Click, Piece16.Click, Piece17.Click, Piece18.Click, Piece19.Click, Piece20.Click, Piece21.Click, Piece22.Click, Piece23.Click
        PicClicked = sender
        Point1 = New System.Drawing.Point(PicClicked.Location.X - 10, PicClicked.Location.Y - 10)
        For m = 0 To 7
            For n = 0 To 3
                If Cases(m, n).Location = Point1 Then
                    CaseClicked = Cases(m, n)
                End If
            Next
        Next
        ClickSomething()
    End Sub

    Sub ClickSomething()
        PicClicked = CaseClicked
        If SomethingClicked = False Then
            LastClick = CaseClicked
        End If
        For m = 0 To 7
            For n = 0 To 3
                If Cases(m, n).Location = PicClicked.Location Then
                    a = m
                    b = n
                End If
                If Cases(m, n).Location = LastClick.Location Then
                    c = m
                    d = n
                End If
            Next
        Next
        If Occupied(a, b) <> 0 Or SomethingClicked = True Then
            
            Point1 = New System.Drawing.Point(PicClicked.Location.X + 10, PicClicked.Location.Y + 10)

            If SomethingClicked = True Then
                If a = c And b = d Then
                    If SomethingEaten = True Then
                        Unclick()
                        ChangeTurn()
                    End If
                    Unclick()
                ElseIf Available(a, b) = False Then
                    If SomethingEaten = True Then
                        Unclick()
                        ChangeTurn()
                    End If
                    Unclick()
                Else
                    If Available(a, b) = True Then
                        For m = 0 To 7
                            For n = 0 To 3
                                Available(m, n) = False
                                EatAvailable(m, n) = False
                                Cases(m, n).BackColor = Color.Black
                            Next
                        Next
                        Pièces(x, y).Location = Point1
                        Occupied(c, d) = 0
                        Unclick()
                        If x = 0 Then
                            Occupied(a, b) = -1
                            If a = 7 Then
                                King(x, y) = True
                                Pièces(x, y).Image = KingCercleBlanc
                                JustKinged = True
                            End If
                        ElseIf x = 1 Then
                            Occupied(a, b) = 1
                            If a = 0 Then
                                King(x, y) = True
                                Pièces(x, y).Image = KingCercleRouge
                                JustKinged = True
                            End If
                        End If

                        If a - c = 2 Or a - c = -2 Then
                            SomethingEaten = True
                            If c Mod 2 = 0 Then
                                If b + 1 = d And a - 2 = c Then
                                    j = c + 1
                                    k = d
                                End If
                                If a - 2 = c And b - 1 = d Then
                                    j = c + 1
                                    k = d + 1
                                End If
                                If a + 2 = c And b + 1 = d Then
                                    j = c - 1
                                    k = d
                                End If
                                If a + 2 = c And b - 1 = d Then
                                    j = c - 1
                                    k = d + 1
                                End If
                                Point2 = New System.Drawing.Point(Cases(j, k).Location.X + 10, Cases(j, k).Location.Y + 10)
                            Else
                                If a - 2 = c And b - 1 = d Then
                                    j = c + 1
                                    k = d
                                End If
                                If a - 2 = c And b + 1 = d Then
                                    j = c + 1
                                    k = d - 1
                                End If
                                If a + 2 = c And b - 1 = d Then
                                    j = c - 1
                                    k = d
                                End If
                                If a + 2 = c And b + 1 = d Then
                                    j = c - 1
                                    k = d - 1
                                End If
                                Point2 = New System.Drawing.Point(Cases(j, k).Location.X + 10, Cases(j, k).Location.Y + 10)
                            End If
                            For m = 0 To 1
                                For n = 0 To 11
                                    If Pièces(m, n).Location = Point2 Then
                                        Pièces(m, n).Visible = False
                                        Pièces(m, n).Location = Pic1.Location
                                        Occupied(j, k) = 0
                                    End If
                                Next
                            Next
                            If TurnRed = True Then
                                PieceCoundWhite -= 1
                                lblPiecesB.Text = PieceCoundWhite
                            Else
                                PieceCountRed -= 1
                                lblPiecesR.Text = PieceCountRed
                            End If
                            If PieceCountRed = 0 Or PieceCoundWhite = 0 Then
                                Win()
                                Exit Sub
                            End If
                            DoubleJump()
                            Exit Sub
                        End If
                        ChangeTurn()
                    End If
                End If

            ElseIf SomethingClicked = False Then
                If PossibleToEat = False Or PossibleToEat = True And EatPossible(a, b) = True Or NiveauFacile = True Then
                    For h = 0 To 1
                        For i = 0 To 11
                            If Pièces(h, i).Location = Point1 Then
                                If h = 0 And TurnRed = False Or h = 1 And TurnRed = True Then
                                    Clicked(h, i) = True
                                    If King(h, i) = True Then
                                        SomethingKinged = True
                                    End If
                                    If SomethingKinged = True Then
                                        Pièces(h, i).BackColor = Color.Yellow
                                    Else
                                        Pièces(h, i).BackColor = Color.Green
                                    End If
                                End If
                            End If
                        Next
                    Next
                    For i = 0 To 11
                        For h = 0 To 1
                            If Clicked(h, i) = True Then
                                SomethingClicked = True
                                x = h
                                y = i
                            End If
                        Next
                    Next
                    If SomethingClicked = True Then
                        Possiblilities()
                    End If
                End If
            End If
        End If
    End Sub

    Sub DoubleJump()
        LastClick = Cases(a, b)
        If King(x, y) = True Then
            SomethingKinged = True
        End If
        SomethingClicked = True
        Possiblilities()
        If SomethingAvailableEat = True Then
            Clicked(x, y) = True
            If SomethingKinged = True Then
                Pièces(x, y).BackColor = Color.Yellow
            Else
                Pièces(x, y).BackColor = Color.Green
            End If
        Else
            Unclick()
            ChangeTurn()
        End If
    End Sub

    Sub Win()
        Dim Result As String
        If TurnRed = True Then
            MsgBox("Bravo! Joueur 1 a gagné!", MsgBoxStyle.Information, "Gagnant")
            Points(1) += 1
        Else
            MsgBox("Bravo! Joueur 2 a gagné!", MsgBoxStyle.Information, "Gagnant")
            Points(0) += 1
        End If

        Result = MsgBox("Voulez-vous rejouer?", MsgBoxStyle.YesNo, "Rejouer?")
        If Result = MsgBoxResult.Yes Then
            Start()
        ElseIf Result = MsgBoxResult.No Then
            Menu1.Show()
            Me.Close()
        End If
    End Sub

    Sub Possiblilities()
        If SomethingKinged = True Then
            For i = -1 To 1
                If x = 0 And i = 1 Or x = 1 And i = -1 Then
                    If a = 0 And b = 3 Then
                        Available(1, 3) = True
                        If Occupied(1, 3) = i And Occupied(2, 2) = 0 Then
                            EatAvailable(2, 2) = True
                        End If
                    ElseIf a = 7 And b = 0 Then
                        Available(6, 0) = True
                        If Occupied(6, 0) = i And Occupied(5, 1) = 0 Then
                            EatAvailable(5, 1) = True
                        End If
                    ElseIf a = 0 Then
                        If Occupied(a + 1, b) = 0 Then
                            Available(a + 1, b) = True
                        ElseIf b <> 0 Then
                            If Occupied(a + 1, b) = i And Occupied(a + 2, b - 1) = 0 Then
                                EatAvailable(a + 2, b - 1) = True
                            End If
                        End If
                        If Occupied(a + 1, b + 1) = 0 Then
                            Available(a + 1, b + 1) = True
                        ElseIf Occupied(a + 1, b + 1) = i And Occupied(a + 2, b + 1) = 0 Then
                            EatAvailable(a + 2, b + 1) = True
                        End If

                    ElseIf a = 7 Then
                        If Occupied(a - 1, b) = 0 Then
                            Available(a - 1, b) = True
                        ElseIf b <> 3 Then
                            If Occupied(a - 1, b) = i And Occupied(a - 2, b + 1) = 0 Then
                                EatAvailable(a - 2, b + 1) = True
                            End If
                        End If
                        If Occupied(a - 1, b - 1) = 0 Then
                            Available(a - 1, b - 1) = True
                        ElseIf Occupied(a - 1, b - 1) = i And Occupied(a - 2, b - 1) = 0 Then
                            Available(a - 2, b - 1) = True
                        End If
                    ElseIf b = 0 And a Mod 2 <> 0 Then
                        If Occupied(a + 1, b) = 0 Then
                            Available(a + 1, b) = True
                        ElseIf Occupied(a + 1, b) = i And Occupied(a + 2, b + 1) = 0 Then
                            EatAvailable(a + 2, b + 1) = True
                        End If

                        If Occupied(a - 1, b) = 0 Then
                            Available(a - 1, b) = True
                        ElseIf a <> 1 Then
                            If Occupied(a - 1, b) = i And Occupied(a - 2, b + 1) = 0 Then
                                EatAvailable(a - 2, b + 1) = True
                            End If
                        End If
                    ElseIf b = 3 And a Mod 2 = 0 Then
                        If Occupied(a + 1, b) = 0 Then
                            Available(a + 1, b) = True
                        ElseIf a <> 6 Then
                            If Occupied(a + 1, b) = i And Occupied(a + 2, b - 1) = 0 Then
                                EatAvailable(a + 2, b - 1) = True
                            End If
                        End If

                        If Occupied(a - 1, b) = 0 Then
                            Available(a - 1, b) = True
                        ElseIf Occupied(a - 1, b) = i And Occupied(a - 2, b - 1) = 0 Then
                            EatAvailable(a - 2, b - 1) = True
                        End If
                    Else

                        If a Mod 2 = 0 Then
                            If Occupied(a + 1, b) = 0 Then
                                Available(a + 1, b) = True
                            ElseIf a <> 6 And b <> 0 Then
                                If Occupied(a + 1, b) = i And Occupied(a + 2, b - 1) = 0 Then
                                    EatAvailable(a + 2, b - 1) = True
                                End If
                            End If

                            If Occupied(a + 1, b + 1) = 0 Then
                                Available(a + 1, b + 1) = True
                            ElseIf a <> 6 And b <> 3 Then
                                If Occupied(a + 1, b + 1) = i And Occupied(a + 2, b + 1) = 0 Then
                                    EatAvailable(a + 2, b + 1) = True
                                End If
                            End If

                            If Occupied(a - 1, b) = 0 Then
                                Available(a - 1, b) = True
                            ElseIf b <> 0 Then
                                If Occupied(a - 1, b) = i And Occupied(a - 2, b - 1) = 0 Then
                                    EatAvailable(a - 2, b - 1) = True
                                End If
                            End If

                            If Occupied(a - 1, b + 1) = 0 Then
                                Available(a - 1, b + 1) = True
                            ElseIf b <> 3 Then
                                If Occupied(a - 1, b + 1) = i And Occupied(a - 2, b + 1) = 0 Then
                                    EatAvailable(a - 2, b + 1) = True
                                End If
                            End If

                        Else

                            If Occupied(a + 1, b) = 0 Then
                                Available(a + 1, b) = True
                            ElseIf b <> 3 Then
                                If Occupied(a + 1, b) = i And Occupied(a + 2, b + 1) = 0 Then
                                    EatAvailable(a + 2, b + 1) = True
                                End If
                            End If

                            If Occupied(a + 1, b - 1) = 0 Then
                                Available(a + 1, b - 1) = True
                            ElseIf b <> 0 Then
                                If Occupied(a + 1, b - 1) = i And Occupied(a + 2, b - 1) = 0 Then
                                    EatAvailable(a + 2, b - 1) = True
                                End If
                            End If

                            If Occupied(a - 1, b) = 0 Then
                                Available(a - 1, b) = True
                            ElseIf a <> 1 And b <> 3 Then
                                If Occupied(a - 1, b) = i And Occupied(a - 2, b + 1) = 0 Then
                                    EatAvailable(a - 2, b + 1) = True
                                End If
                            End If

                            If Occupied(a - 1, b - 1) = 0 Then
                                Available(a - 1, b - 1) = True
                            ElseIf b <> 0 And a <> 1 Then
                                If Occupied(a - 1, b - 1) = i And Occupied(a - 2, b - 1) = 0 Then
                                    EatAvailable(a - 2, b - 1) = True
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        ElseIf x = 0 Then
            If a = 0 And b = 3 Then
                Available(1, 3) = True
                If Occupied(1, 3) = 1 And Occupied(2, 2) = 0 Then
                    EatAvailable(2, 2) = True
                End If
            ElseIf a = 0 Then
                If Occupied(a + 1, b) = 0 Then
                    Available(a + 1, b) = True
                ElseIf b <> 0 Then
                    If Occupied(a + 2, b - 1) = 0 And Occupied(a + 1, b) = 1 Then
                        EatAvailable(a + 2, b - 1) = True
                    End If
                End If
                If Occupied(a + 1, b + 1) = 0 Then
                    Available(a + 1, b + 1) = True
                ElseIf Occupied(a + 2, b + 1) = 0 And Occupied(a + 1, b + 1) = 1 Then
                    EatAvailable(a + 2, b + 1) = True
                End If
            ElseIf b = 0 And a Mod 2 <> 0 Then
                If Occupied(a + 1, b) = 0 Then
                    Available(a + 1, b) = True
                ElseIf a <> 7 Then
                    If Occupied(a + 2, b + 1) = 0 And Occupied(a + 1, b) = 1 Then
                        EatAvailable(a + 2, b + 1) = True
                    End If
                End If
            ElseIf b = 3 And a Mod 2 = 0 Then
                If Occupied(a + 1, b) = 0 Then
                    Available(a + 1, b) = True
                ElseIf a <> 6 Then
                    If Occupied(a + 2, b - 1) = 0 And Occupied(a + 1, b) = 1 Then
                        EatAvailable(a + 2, b - 1) = True
                    End If
                End If
            Else
                    If a Mod 2 = 0 Then
                        If Occupied(a + 1, b) = 0 Then
                            Available(a + 1, b) = True
                        ElseIf a <> 6 And b <> 0 Then
                            If Occupied(a + 2, b - 1) = 0 And Occupied(a + 1, b) = 1 Then
                                EatAvailable(a + 2, b - 1) = True
                            End If
                        End If

                        If Occupied(a + 1, b + 1) = 0 Then
                            Available(a + 1, b + 1) = True
                        ElseIf a <> 6 And b <> 3 Then
                            If Occupied(a + 2, b + 1) = 0 And Occupied(a + 1, b + 1) = 1 Then
                                EatAvailable(a + 2, b + 1) = True
                            End If
                        End If

                    Else
                    If a <> 7 Then
                        If Occupied(a + 1, b) = 0 Then
                            Available(a + 1, b) = True
                        ElseIf b <> 3 Then
                            If Occupied(a + 2, b + 1) = 0 And Occupied(a + 1, b) = 1 Then
                                EatAvailable(a + 2, b + 1) = True
                            End If
                        End If

                    If Occupied(a + 1, b - 1) = 0 Then
                        Available(a + 1, b - 1) = True
                    ElseIf b <> 0 Then
                        If Occupied(a + 2, b - 1) = 0 And Occupied(a + 1, b - 1) = 1 Then
                            EatAvailable(a + 2, b - 1) = True
                        End If
                    End If
                End If
            End If
            End If


        ElseIf x = 1 Then
            If a = 7 And b = 0 Then
                Available(6, 0) = True
                If Occupied(6, 0) = -1 And Occupied(5, 1) = 0 Then
                    EatAvailable(5, 1) = True
                End If
            ElseIf a = 7 Then
                If Occupied(a - 1, b) = 0 Then
                    Available(a - 1, b) = True
                ElseIf b <> 3 Then
                    If Occupied(a - 2, b + 1) = 0 And Occupied(a - 1, b) = -1 Then
                        EatAvailable(a - 2, b + 1) = True
                    End If
                End If
                If Occupied(a - 1, b - 1) = 0 Then
                    Available(a - 1, b - 1) = True
                ElseIf Occupied(a - 2, b - 1) = 0 And Occupied(a - 1, b - 1) = -1 Then
                    EatAvailable(a - 2, b - 1) = True
                End If
            ElseIf b = 0 And a Mod 2 <> 0 Then
                If Occupied(a - 1, b) = 0 Then
                    Available(a - 1, b) = True
                ElseIf a <> 1 Then
                    If Occupied(a - 2, b + 1) = 0 And Occupied(a - 1, b) = -1 Then
                        EatAvailable(a - 2, b + 1) = True
                    End If
                End If
            ElseIf b = 3 And a Mod 2 = 0 Then
                If Occupied(a - 1, b) = 0 Then
                    Available(a - 1, b) = True
                ElseIf Occupied(a - 2, b - 1) = 0 And Occupied(a - 1, b) = -1 Then
                    EatAvailable(a - 2, b - 1) = True
                End If
            Else

                If a Mod 2 = 0 Then
                    If a <> 0 Then
                        If Occupied(a - 1, b) = 0 Then
                            Available(a - 1, b) = True
                        ElseIf b <> 0 Then
                            If Occupied(a - 2, b - 1) = 0 And Occupied(a - 1, b) = -1 Then
                                EatAvailable(a - 2, b - 1) = True
                            End If
                        End If

                        If Occupied(a - 1, b + 1) = 0 Then
                            Available(a - 1, b + 1) = True
                        ElseIf b <> 3 Then
                            If Occupied(a - 2, b + 1) = 0 And Occupied(a - 1, b + 1) = -1 Then
                                EatAvailable(a - 2, b + 1) = True
                            End If
                        End If
                    End If

                Else

                If Occupied(a - 1, b) = 0 Then
                    Available(a - 1, b) = True
                ElseIf a <> 1 And b <> 3 Then
                    If Occupied(a - 2, b + 1) = 0 And Occupied(a - 1, b) = -1 Then
                        EatAvailable(a - 2, b + 1) = True
                    End If
                End If

                If Occupied(a - 1, b - 1) = 0 Then
                    Available(a - 1, b - 1) = True
                ElseIf b <> 0 And a <> 1 Then
                    If Occupied(a - 2, b - 1) = 0 And Occupied(a - 1, b - 1) = -1 Then
                        EatAvailable(a - 2, b - 1) = True
                    End If
                End If
                End If
            End If

        End If

        For m = 0 To 7
            For n = 0 To 3
                If EatAvailable(m, n) = True Then
                    SomethingAvailableEat = True
                    SomethingAvailable = True
                    Available(m, n) = True
                End If
            Next
        Next
        If SomethingAvailableEat = False Or NiveauFacile = True And SomethingEaten = False Then
            For m = 0 To 7
                For n = 0 To 3
                    If Available(m, n) = True Then
                        SomethingAvailable = True
                    End If
                Next
            Next
        Else
            For m = 0 To 7
                For n = 0 To 3
                    Available(m, n) = False
                Next
            Next
            For m = 0 To 7
                For n = 0 To 3
                    If EatAvailable(m, n) = True Then
                        Available(m, n) = True
                        EatAvailable(m, n) = False
                    End If
                Next
            Next
        End If
        If SomethingClicked = True And Assistant = True Then
            For m = 0 To 7
                For n = 0 To 3
                    If Available(m, n) = True Then
                        Cases(m, n).BackColor = Color.Green
                    End If
                Next
            Next
        End If
    End Sub


    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Dim Result As String
        Result = MsgBox("Êtes-vous sûr de vouloir quitter ? Votre partie sera perdue.", MsgBoxStyle.YesNo, "Menu")
        If Result = MsgBoxResult.Yes Then
            Menu1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnRecommencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecommencer.Click
        Start()
    End Sub
End Class