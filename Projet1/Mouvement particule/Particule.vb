Public Class Particule
    Public masse, charge, size, A(1), V(1), FT(1), pos(1) As Double
    'Pour les tableaux: 0 = x et 1 = y
    Public position As Point
    Public pic As System.Windows.Forms.PictureBox
    Public listIndex As Integer
    Public fixed, beingDragged As Boolean
    Public Fe As New List(Of Double())
    Public Fg As New List(Of Double())
    Public isColliding As New List(Of Double)

    Sub New(ByVal num As Integer)
        listIndex = num
        masse = 1
        charge = 0
        position = New Point(0, 24)
        pos(1) = 24
        V(0) = 0
        V(1) = 0
        A(0) = 0
        A(1) = 0
        size = 30
        pic = New System.Windows.Forms.PictureBox
    End Sub

    Sub setImage()
        If charge > 0 Then
            pic.Image = System.Drawing.Image.FromFile("ParticulePositive.ico")
        ElseIf charge < 0 Then
            pic.Image = System.Drawing.Image.FromFile("ParticuleNegative.png")
        Else
            pic.Image = System.Drawing.Image.FromFile("ParticuleNeutre.jpg")
        End If
    End Sub

    Sub calcFe(ByVal part2 As Particule)
        Dim F(1) As Double
        Dim r As Double = Math.Sqrt(Math.Pow(part2.position.X - position.X, 2) + Math.Pow(part2.position.Y - position.Y, 2))
        If r <> 0 Then
            'Calcule de Fex
            F(0) = (position.X - part2.position.X) * 9000000000.0 * charge * part2.charge / Math.Pow(r, 3)
            'Calcule de Fey
            F(1) = (part2.position.Y - position.Y) * 9000000000.0 * charge * part2.charge / Math.Pow(r, 3)
        End If
        Fe.Add(F)
    End Sub

    Sub calcFg(ByVal part2 As Particule)
        Dim F(1) As Double
        Dim r As Double = Math.Sqrt(Math.Pow(part2.position.X - position.X, 2) + Math.Pow(part2.position.Y - position.Y, 2))
        If r <> 0 Then
            'Note: la valeur utilisé pour G est plus grande.
            F(0) = (part2.position.X - position.X) * 0.00006674 * masse * part2.masse / Math.Pow(r, 3)
            F(1) = (position.Y - part2.position.Y) * 0.00006674 * masse * part2.masse / Math.Pow(r, 3)
        End If
        Fg.Add(F)
    End Sub

    Sub calcFx()
        Dim F As Double = 0

        For i = 0 To Fe.Count - 1
            If isColliding(i) = False Then
                F = F + Fe.Item(i)(0)
            End If
        Next

        For i = 0 To Fg.Count - 1
            If isColliding(i) = False Then
                F = F + Fg.Item(i)(0)
            End If
        Next

        FT(0) = F
    End Sub

    Sub calcFy()
        Dim F As Double = 0
        For i = 0 To Fe.Count - 1
            If isColliding(i) = False Then
                F = F + Fe.Item(i)(1)
            End If
        Next

        For i = 0 To Fg.Count - 1
            If isColliding(i) = False Then
                F = F + Fg.Item(i)(1)
            End If
        Next

        FT(1) = F
    End Sub

    Sub calcA()
        A(0) = FT(0) / (10 * masse)
        A(1) = FT(1) / (10 * masse)
        Fe.Clear()
        Fg.Clear()
    End Sub

    Sub calcV()
        V(0) = V(0) + A(0)
        V(1) = V(1) - A(1)
    End Sub

    Sub checkColision(ByVal part2 As Particule)
        If pic.Bounds.IntersectsWith(part2.pic.Bounds) Then
            'm1V1^2 + m2V2^2 = m1V1f^2 + m2V2f^2
            'V2f = sqrt((m1V1^2 + m2V2^2 - m1V1f^2)/m2)
            'm1V1 + m2V2 = m1V1f + m2V2f
            'm1V1 + m2V2 = m1V1f + m2sqrt((m1V1^2 + m2V2^2 - m1V1f^2)/m2)
            'For i = 0 To 1
            'If V(i) * part2.V(i) < 0 Then
            'V(i) = -V(i)
            'part2.V(i) = -part2.V(i)
            'End If

            '    Next
            If isColliding.Item(part2.listIndex) = False Then
                isColliding.Item(part2.listIndex) = True
                part2.isColliding.Item(listIndex) = True

                Dim angle1i, angle2i, VT1, VT2, VfT1, VfT2, dltV1T, deltaV1(1), deltaV2(1), deltaY, deltaX, signe1, signe2, angle As Double
                Dim useY As Boolean

                deltaY = position.Y - part2.position.Y
                deltaX = position.X - part2.position.X
                If deltaY = 0 Then
                    signe1 = 1
                Else
                    signe1 = deltaY / Math.Abs(deltaY)
                End If
                If deltaX = 0 Then
                    signe2 = 1
                Else
                    signe2 = deltaX / Math.Abs(deltaX)
                End If

                If V(0) = 0 Then
                    If V(1) > 0 Then
                        angle1i = Math.PI / 2
                    Else
                        angle1i = 3 * Math.PI / 2
                    End If
                Else
                    angle1i = V(1) / V(0)
                End If

                VT1 = Math.Sqrt(Math.Pow(V(0), 2) + Math.Pow(V(1), 2))
                VT2 = Math.Sqrt(Math.Pow(part2.V(0), 2) + Math.Pow(part2.V(1), 2))

                If V(0) * part2.V(0) < 0 Or V(1) * part2.V(1) < 0 Then
                    VT2 = -VT2
                Else
                    signe1 = -signe1
                    signe2 = -signe2
                End If

                dltV1T = 2 * part2.masse * (VT2 - part2.masse * VT1) / (masse + part2.masse * part2.masse)

                If Math.Abs(deltaX) > Math.Abs(deltaY) Then
                    angle = 0.5 * Math.PI * (2 - 4 * deltaY / (size + part2.size))
                    useY = True
                Else
                    angle = 0.5 * Math.PI * (2 - 4 * deltaX / (size + part2.size))
                    useY = False
                End If

                'deltaV1(0) = (VT1 + dltV1T) * Math.Cos(0.5 * Math.PI * signe1 * (2 - 4 * deltaY / (size + part2.size))) - V(0)
                'deltaV1(1) = Math.Sqrt(dltV1T * dltV1T - deltaV1(0) * deltaV1(0))
                'deltaV1(1) = (VT1 + dltV1T) * Math.Sin(0.5 * Math.PI * signe1 * (2 - 4 * deltaY / (size + part2.size))) - V(1)

                'If useY = True Then
                deltaV1(0) = (VT1 + dltV1T) * Math.Cos(angle - angle1i) - V(0)
                deltaV1(1) = (VT1 + dltV1T) * Math.Sin(angle - angle1i) - V(1)
                'Else
                'deltaV1(0) = (VT1 + dltV1T) * Math.Sin(angle - angle1i) - V(0)
                'deltaV1(1) = (VT1 + dltV1T) * Math.Cos(angle - angle1i) - V(1)
                'End If

                deltaV2(0) = -masse * deltaV1(0) / part2.masse
                deltaV2(1) = -masse * deltaV1(1) / part2.masse

                V(0) = Math.Round(V(0) + deltaV1(0))
                V(1) = Math.Round(V(1) + deltaV1(1))
                part2.V(0) = Math.Round(part2.V(0) + deltaV2(0))
                part2.V(1) = Math.Round(part2.V(1) + deltaV2(1))

                'VfT1 = VT1 + dltV1T
                'VfT2 = VT2 - masse * dltV1T / part2.masse



                If useY = True Then
                    'V(0) = VfT1 * Math.Cos(angle)
                    'V(1) = VfT1 * Math.Sin(angle)
                    'part2.V(0) = VfT2 * Math.Cos(angle)
                    'part2.V(1) = VfT2 * Math.Sin(angle)
                Else
                    'V(1) = VfT1 * Math.Cos(angle)
                    'V(0) = VfT1 * Math.Sin(angle)
                    'part2.V(1) = VfT2 * Math.Cos(angle)
                    'part2.V(0) = VfT2 * Math.Sin(angle)
                End If

                'position.X = position.X + V(0)
                'position.Y = position.Y + V(1)
                'part2.position.X = part2.position.X + part2.V(0)
                'part2.position.Y = part2.position.Y + part2.V(1)

            End If
        Else
            isColliding.Item(part2.listIndex) = False
            part2.isColliding.Item(listIndex) = False
        End If
    End Sub

End Class
