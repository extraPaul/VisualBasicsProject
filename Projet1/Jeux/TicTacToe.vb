Public Class TicTacToe
    Dim X, O As Image
    Dim a, b As Integer
    Dim TurnX As Boolean
    Dim Box(3, 3) As PictureBox
    Dim tictac(3, 3) As Integer
    Dim Points(2) As Integer
    Dim winner As Boolean
    Dim Draw As Boolean


    
    Private Sub TicTacToe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite
        Points(1) = 0
        Points(2) = 0
        X = System.Drawing.Image.FromFile("X.jpg")
        O = System.Drawing.Image.FromFile("O.jpg")
        lblNomJ1.Text = Joueur1
        lblNomJ2.Text = Joueur2
        TurnX = True
        Box(1, 1) = pbxCase1
        Box(1, 2) = pbxCase2
        Box(1, 3) = pbxCase3
        Box(2, 1) = pbxCase4
        Box(2, 2) = pbxCase5
        Box(2, 3) = pbxCase6
        Box(3, 1) = pbxCase7
        Box(3, 2) = pbxCase8
        Box(3, 3) = pbxCase9
        Start()
    End Sub

    Sub Start()
        winner = False
        Draw = False
        For g = 1 To 3
            For h = 1 To 3
                tictac(g, h) = 0
                Box(g, h).Image = Nothing
            Next
        Next
        lblPointsJ1.Text = Points(1)
        lblPointsJ2.Text = Points(2)
        If TurnX = True Then
            picTurn.Image = X
        Else
            picTurn.Image = O
        End If
        If TurnX = False And oneplayer = True Then
            Ordi()
            Image()
        End If
    End Sub

    Sub Turn()
        Image()
        Checkwinner()
        If oneplayer = True And winner = False And TurnX = False Then
            Ordi()
            Image()
            Checkwinner()
        End If
    End Sub

    Sub Image()
        If tictac(a, b) = 0 Then
            If TurnX = True Then
                Box(a, b).Image = X
                TurnX = False
                tictac(a, b) = 1
            Else
                Box(a, b).Image = O
                TurnX = True
                tictac(a, b) = -1
            End If
        End If
        If TurnX = True Then
            picTurn.Image = X
        Else
            picTurn.Image = O
        End If
    End Sub

    Sub Ordi()
        If NiveauFacile = True Then
            Do
                a = rand.Next(1, 4)
                b = rand.Next(1, 4)
            Loop Until tictac(a, b) = 0
        Else
            a = 0
            For num = 1 To 3
                If tictac(num, 1) + tictac(num, 2) + tictac(num, 3) = -2 Then
                    For i = 1 To 3
                        If tictac(num, i) = 0 Then
                            a = num
                            b = i
                            Exit Sub
                        End If
                    Next
                ElseIf tictac(1, num) + tictac(2, num) + tictac(3, num) = -2 Then
                    For i = 1 To 3
                        If tictac(i, num) = 0 Then
                            a = i
                            b = num
                            Exit Sub
                        End If
                    Next
                End If
            Next

            If a = 0 Then
                If tictac(1, 1) + tictac(2, 2) + tictac(3, 3) = 2 Or tictac(1, 1) + tictac(2, 2) + tictac(3, 3) = -2 Then
                    If tictac(1, 1) = 0 Then
                        a = 1
                        b = 1
                    ElseIf tictac(2, 2) = 0 Then
                        a = 2
                        b = 2
                    ElseIf tictac(3, 3) = 0 Then
                        a = 3
                        b = 3
                    End If
                ElseIf tictac(1, 3) + tictac(2, 2) + tictac(3, 1) = 2 Or tictac(1, 3) + tictac(2, 2) + tictac(3, 1) = -2 Then
                    If tictac(1, 3) = 0 Then
                        a = 1
                        b = 3
                    ElseIf tictac(2, 2) = 0 Then
                        a = 2
                        b = 2
                    ElseIf tictac(3, 1) = 0 Then
                        a = 3
                        b = 1
                    End If
                End If
            End If

            If a = 0 Then
                For num = 1 To 3
                    If tictac(num, 1) + tictac(num, 2) + tictac(num, 3) = 2 Then
                        For i = 1 To 3
                            If tictac(num, i) = 0 Then
                                a = num
                                b = i
                                Exit Sub
                            End If
                        Next
                    ElseIf tictac(1, num) + tictac(2, num) + tictac(3, num) = 2 Then
                        For i = 1 To 3
                            If tictac(i, num) = 0 Then
                                a = i
                                b = num
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            End If

            If a = 0 Then
                For num = 1 To 3
                    If tictac(num, 1) + tictac(num, 2) + tictac(num, 3) = -1 Then
                        For i = 1 To 3
                            If tictac(num, i) = 0 Then
                                a = num
                                b = i
                                Exit Sub
                            End If
                        Next
                    ElseIf tictac(1, num) + tictac(2, num) + tictac(3, num) = -1 Then
                        For i = 1 To 3
                            If tictac(i, num) = 0 Then
                                a = i
                                b = num
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            End If

            If a = 0 Then
                Do
                    a = rand.Next(1, 4)
                    b = rand.Next(1, 4)
                Loop Until tictac(a, b) = 0
            End If
            End If
    End Sub

    Sub Checkwinner()
        For num = 1 To 3
            If tictac(num, 1) + tictac(num, 2) + tictac(num, 3) = 3 Or tictac(1, num) + tictac(2, num) + tictac(3, num) = 3 Then
                Win()
            ElseIf tictac(num, 1) + tictac(num, 2) + tictac(num, 3) = -3 Or tictac(1, num) + tictac(2, num) + tictac(3, num) = -3 Then
                Win()
            End If
        Next

        If tictac(1, 1) + tictac(2, 2) + tictac(3, 3) = 3 Or tictac(1, 3) + tictac(2, 2) + tictac(3, 1) = 3 Then
            Win()
        ElseIf tictac(1, 1) + tictac(2, 2) + tictac(3, 3) = -3 Or tictac(1, 3) + tictac(2, 2) + tictac(3, 1) = -3 Then
            Win()
        End If

        If tictac(1, 1) <> 0 And tictac(1, 2) <> 0 And tictac(1, 3) <> 0 And tictac(2, 1) <> 0 And tictac(2, 2) <> 0 And tictac(2, 3) <> 0 And tictac(3, 1) <> 0 And tictac(3, 2) <> 0 And tictac(3, 3) <> 0 And winner = False Then
            Draw = True
            Win()
        End If
    End Sub

    Sub Win()
        Dim Result As String
        winner = True
        If Draw = True Then
            MsgBox("C'est une égalité.", MsgBoxStyle.Information, "Gagnant")
        Else
            If TurnX = True Then
                MsgBox("Bravo! Joueur 2 a gagné!", MsgBoxStyle.Information, "Gagnant")
                Points(2) += 1
                TurnX = False
            Else
                MsgBox("Bravo! Joueur 1 a gagné!", MsgBoxStyle.Information, "Gagnant")
                Points(1) += 1
                TurnX = True
            End If
        End If

        Result = MsgBox("Voulez-vous rejouer?", MsgBoxStyle.YesNo, "Rejouer?")
        If Result = MsgBoxResult.Yes Then
            Start()
        ElseIf Result = MsgBoxResult.No Then
            Menu1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pbxCase1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase1.Click
        a = 1
        b = 1
        Turn()
    End Sub

    Private Sub pbxCase2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase2.Click
        a = 1
        b = 2
        Turn()
    End Sub

    Private Sub pbxCase3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase3.Click
        a = 1
        b = 3
        Turn()
    End Sub

    Private Sub pbxCase4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase4.Click
        a = 2
        b = 1
        Turn()
    End Sub

    Private Sub pbxCase5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase5.Click
        a = 2
        b = 2
        Turn()
    End Sub

    Private Sub pbxCase6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase6.Click
        a = 2
        b = 3
        Turn()
    End Sub

    Private Sub pbxCase7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase7.Click
        a = 3
        b = 1
        Turn()
    End Sub

    Private Sub pbxCase8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase8.Click
        a = 3
        b = 2
        Turn()
    End Sub

    Private Sub pbxCase9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCase9.Click
        a = 3
        b = 3
        Turn()
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Dim Result As String
        Result = MsgBox("Etes-vous sure de vouloir quitter? Votre partie ne sera pas sauvegarder.", MsgBoxStyle.YesNo, "Menu")
        If Result = MsgBoxResult.Yes Then
            Menu1.Show()
            Me.Close()
        End If
    End Sub
End Class