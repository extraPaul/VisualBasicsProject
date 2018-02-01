Public Class Poker
    Dim HandBox(5, 1) As PictureBox
    Dim HandX(5, 1) As Integer
    Dim HandY(5, 1) As Integer
    Dim CardsM(4) As PictureBox
    Dim MidX(4) As Integer
    Dim MidY(4) As Integer
    Dim CARDS(3, 12) As Image
    Dim CardBack As Image
    Dim CardUsed(3, 12) As Boolean
    Dim CallBtn(5) As Button
    Dim FoldBtn(5) As Button
    Dim RaiseBtn(5) As Button
    Dim ShowBtn(5) As Button
    Dim HideBtn(5) As Button
    Dim MoneyLb(5) As Label
    Dim NameLb(5) As Label
    Dim Money(5) As Integer
    Dim PlayerTurn As Integer
    Dim RoundNumber As Integer
    Dim PlayerIn(5) As Boolean
    Dim Pot As Integer
    Dim RaiseCall As Integer
    Dim PlayerCalled(5) As Boolean
    Dim AllPlayersCalled As Boolean

    Private Sub Poker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite

        CardsM(0) = picCardM1
        CardsM(1) = picCardM2
        CardsM(2) = picCardM3
        CardsM(3) = picCardM4
        CardsM(4) = PicCardM5
        HandBox(0, 0) = picCard11
        HandBox(0, 1) = picCard12
        HandBox(1, 0) = picCard21
        HandBox(1, 1) = picCard22
        HandBox(2, 0) = picCard31
        HandBox(2, 1) = picCard32
        HandBox(3, 0) = picCard41
        HandBox(3, 1) = picCard42
        HandBox(4, 0) = picCard51
        HandBox(4, 1) = picCard52
        HandBox(5, 0) = picCard61
        HandBox(5, 1) = picCard62

        CallBtn(0) = btnCall1
        CallBtn(1) = btnCall2
        CallBtn(2) = btnCall3
        CallBtn(3) = btnCall4
        CallBtn(4) = btnCall5
        CallBtn(5) = btnCall6
        FoldBtn(0) = btnFold1
        FoldBtn(1) = btnFold2
        FoldBtn(2) = btnFold3
        FoldBtn(3) = btnFold4
        FoldBtn(4) = btnFold5
        FoldBtn(5) = btnFold6
        RaiseBtn(0) = btnRaise1
        RaiseBtn(1) = btnRaise2
        RaiseBtn(2) = btnRaise3
        RaiseBtn(3) = btnRaise4
        RaiseBtn(4) = btnRaise5
        RaiseBtn(5) = btnRaise6
        ShowBtn(0) = btnShow1
        ShowBtn(1) = btnShow2
        ShowBtn(2) = btnShow3
        ShowBtn(3) = BtnShow4
        ShowBtn(4) = btnShow5
        ShowBtn(5) = btnShow6
        HideBtn(0) = btnHide1
        HideBtn(1) = btnHide2
        HideBtn(2) = btnHide3
        HideBtn(3) = btnHide4
        HideBtn(4) = btnHide5
        HideBtn(5) = btnHide6

        NameLb(0) = lblPlayer1
        NameLb(1) = lblPlayer2
        NameLb(2) = lblPlayer3
        NameLb(3) = lblPlayer4
        NameLb(4) = lblPlayer5
        NameLb(5) = lblPlayer6
        MoneyLb(0) = lblMoney1
        MoneyLb(1) = lblMoney2
        MoneyLb(2) = lblMoney3
        MoneyLb(3) = lblMoney4
        MoneyLb(4) = lblMoney5
        MoneyLb(5) = lblMoney6

        CardBack = System.Drawing.Image.FromFile("b2fv.png")

        CARDS(0, 0) = System.Drawing.Image.FromFile("1.png")
        CARDS(1, 0) = System.Drawing.Image.FromFile("2.png")
        CARDS(2, 0) = System.Drawing.Image.FromFile("3.png")
        CARDS(3, 0) = System.Drawing.Image.FromFile("4.png")
        CARDS(0, 12) = System.Drawing.Image.FromFile("5.png")
        CARDS(1, 12) = System.Drawing.Image.FromFile("6.png")
        CARDS(2, 12) = System.Drawing.Image.FromFile("7.png")
        CARDS(3, 12) = System.Drawing.Image.FromFile("8.png")
        CARDS(0, 11) = System.Drawing.Image.FromFile("9.png")
        CARDS(1, 11) = System.Drawing.Image.FromFile("10.png")
        CARDS(2, 11) = System.Drawing.Image.FromFile("11.png")
        CARDS(3, 11) = System.Drawing.Image.FromFile("12.png")
        CARDS(0, 10) = System.Drawing.Image.FromFile("13.png")
        CARDS(1, 10) = System.Drawing.Image.FromFile("14.png")
        CARDS(2, 10) = System.Drawing.Image.FromFile("15.png")
        CARDS(3, 10) = System.Drawing.Image.FromFile("16.png")
        CARDS(0, 9) = System.Drawing.Image.FromFile("17.png")
        CARDS(1, 9) = System.Drawing.Image.FromFile("18.png")
        CARDS(2, 9) = System.Drawing.Image.FromFile("19.png")
        CARDS(3, 9) = System.Drawing.Image.FromFile("20.png")
        CARDS(0, 8) = System.Drawing.Image.FromFile("21.png")
        CARDS(1, 8) = System.Drawing.Image.FromFile("22.png")
        CARDS(2, 8) = System.Drawing.Image.FromFile("23.png")
        CARDS(3, 8) = System.Drawing.Image.FromFile("24.png")
        CARDS(0, 7) = System.Drawing.Image.FromFile("25.png")
        CARDS(1, 7) = System.Drawing.Image.FromFile("26.png")
        CARDS(2, 7) = System.Drawing.Image.FromFile("27.png")
        CARDS(3, 7) = System.Drawing.Image.FromFile("28.png")
        CARDS(0, 6) = System.Drawing.Image.FromFile("29.png")
        CARDS(1, 6) = System.Drawing.Image.FromFile("30.png")
        CARDS(2, 6) = System.Drawing.Image.FromFile("31.png")
        CARDS(3, 6) = System.Drawing.Image.FromFile("32.png")
        CARDS(0, 5) = System.Drawing.Image.FromFile("33.png")
        CARDS(1, 5) = System.Drawing.Image.FromFile("34.png")
        CARDS(2, 5) = System.Drawing.Image.FromFile("35.png")
        CARDS(3, 5) = System.Drawing.Image.FromFile("36.png")
        CARDS(0, 4) = System.Drawing.Image.FromFile("37.png")
        CARDS(1, 4) = System.Drawing.Image.FromFile("38.png")
        CARDS(2, 4) = System.Drawing.Image.FromFile("39.png")
        CARDS(3, 4) = System.Drawing.Image.FromFile("40.png")
        CARDS(0, 3) = System.Drawing.Image.FromFile("41.png")
        CARDS(1, 3) = System.Drawing.Image.FromFile("42.png")
        CARDS(2, 3) = System.Drawing.Image.FromFile("43.png")
        CARDS(3, 3) = System.Drawing.Image.FromFile("44.png")
        CARDS(0, 2) = System.Drawing.Image.FromFile("45.png")
        CARDS(1, 2) = System.Drawing.Image.FromFile("46.png")
        CARDS(2, 2) = System.Drawing.Image.FromFile("47.png")
        CARDS(3, 2) = System.Drawing.Image.FromFile("48.png")
        CARDS(0, 1) = System.Drawing.Image.FromFile("49.png")
        CARDS(1, 1) = System.Drawing.Image.FromFile("50.png")
        CARDS(2, 1) = System.Drawing.Image.FromFile("51.png")
        CARDS(3, 1) = System.Drawing.Image.FromFile("52.png")

        For h = 0 To 5
            If NmbJoueurs > h Then
                ShowBtn(h).Visible = True
                HandBox(h, 0).Visible = True
                HandBox(h, 1).Visible = True
                NameLb(h).Visible = True
                NameLb(h).Text = Joueur(h)
                MoneyLb(h).Visible = True
                Money(h) = StartMoney
                MoneyLb(h).Text = StartMoney.ToString + " $"
            End If
        Next

        StartGame()

    End Sub

    Sub StartGame()
        PlayerTurn = 0
        RoundNumber = 0
        Pot = 0
        lblPotValue.Text = Pot.ToString + " $"
        For h = 0 To 3
            For i = 0 To 12
                CardUsed(h, i) = False
            Next
        Next

        For h = 0 To NmbJoueurs - 1
            PlayerIn(h) = True
            PlayerCalled(h) = False
            For i = 0 To 1
                Do
                    HandX(h, i) = rand.Next(0, 4)
                    HandY(h, i) = rand.Next(0, 13)
                Loop Until CardUsed(HandX(h, i), HandY(h, i)) = False
                CardUsed(HandX(h, i), HandY(h, i)) = True
                HandBox(h, i).Image = CardBack
            Next
        Next

        For i = 0 To 4
            Do
                MidX(i) = rand.Next(0, 4)
                MidY(i) = rand.Next(0, 13)
            Loop Until CardUsed(MidX(i), MidY(i)) = False
            CardUsed(MidX(i), MidY(i)) = True
            CardsM(i).Image = CARDS(MidX(i), MidY(i))
            CardsM(i).Visible = False
        Next
        RaiseCall = Blinds
        Turn(PlayerTurn)
    End Sub

    Sub Turn(ByVal X As Integer)
        If PlayerIn(X) = True Then
            CallBtn(X).Visible = True
            FoldBtn(X).Visible = True
            RaiseBtn(X).Visible = True
            If RaiseCall > 0 Then
                lblCall.Visible = True
                lblCallAmound.Visible = True
                lblCallAmound.Text = RaiseCall.ToString + " $"
            Else
                lblCall.Visible = False
                lblCallAmound.Visible = False
            End If
        Else
            PlayerCalled(X) = True
            PlayerTurn += 1
            Turn(PlayerTurn)
        End If
    End Sub

    Sub ChangeTurn(ByVal X As Integer)
        PlayerCalled(X) = True
        CallBtn(X).Visible = False
        FoldBtn(X).Visible = False
        RaiseBtn(X).Visible = False
        lblCall.Visible = False
        lblCallAmound.Visible = False
        If PlayerIn(X) = True Then
            Money(X) -= RaiseCall
            MoneyLb(X).Text = Money(X).ToString + " $"
            Pot += RaiseCall
            lblPotValue.Text = Pot.ToString + " $"
        End If

        If PlayerTurn = NmbJoueurs - 1 Then
            PlayerTurn = 0
            Turn(PlayerTurn)
        Else
            PlayerTurn += 1
            Turn(PlayerTurn)
        End If

        AllPlayersCalled = True
        For i = 0 To NmbJoueurs - 1
            If PlayerCalled(i) = False Then
                AllPlayersCalled = False
            End If
        Next
        If AllPlayersCalled = True Then
            RoundNumber += 1
            ChangeRounds()
        End If
    End Sub

    Sub ChangeRounds()
        RaiseCall = 0
        PlayerTurn = 0
        For i = 0 To 4
            If RoundNumber + 1 > i Then
                CardsM(i).Visible = True
            End If
        Next
        For i = 0 To NmbJoueurs - 1
            PlayerCalled(i) = False
        Next
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Dim Result As String
        Result = MsgBox("Etes-vous sure de vouloir quitter? Votre partie ne sera pas sauvegarder.", MsgBoxStyle.YesNo, "Menu")
        If Result = MsgBoxResult.Yes Then
            Menu1.Show()
            Me.Close()
        End If
    End Sub

    Sub ShowCards(ByVal X As Integer)
        HandBox(X, 0).Image = CARDS(HandX(X, 0), HandY(X, 0))
        HandBox(X, 1).Image = CARDS(HandX(X, 1), HandY(X, 1))
        HideBtn(X).Visible = True
        ShowBtn(X).Visible = False
    End Sub

    Sub HideCards(ByVal X As Integer)
        HandBox(X, 0).Image = CardBack
        HandBox(X, 1).Image = CardBack
        HideBtn(X).Visible = False
        ShowBtn(X).Visible = True
    End Sub

    Sub CallPass(ByVal X As Integer)
        ChangeTurn(X)
    End Sub

    Sub Raise(ByVal X As Integer)
        lblRaise.Visible = True
        btnRaiseConfirm.Visible = True
        btnCancel.Visible = True
        TrackRaise.Visible = True
        TrackRaise.Maximum = Money(X)
        TrackRaise.Minimum = Blinds
        lblRaise.Text = "Raise: " + TrackRaise.Value.ToString + " $"
    End Sub

    Sub Fold(ByVal X As Integer)
        PlayerIn(X) = False
        ChangeTurn(X)
    End Sub

    Private Sub btnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow1.Click
        ShowCards(0)
    End Sub

    Private Sub btnShow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow2.Click
        ShowCards(1)
    End Sub

    Private Sub btnShow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow3.Click
        ShowCards(2)
    End Sub

    Private Sub BtnShow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow4.Click
        ShowCards(3)
    End Sub

    Private Sub btnShow5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow5.Click
        ShowCards(4)
    End Sub

    Private Sub btnShow6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow6.Click
        ShowCards(5)
    End Sub

    Private Sub btnHide1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide1.Click
        HideCards(0)
    End Sub

    Private Sub btnHide2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide2.Click
        HideCards(1)
    End Sub

    Private Sub btnHide3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide3.Click
        HideCards(2)
    End Sub

    Private Sub btnHide4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide4.Click
        HideCards(3)
    End Sub

    Private Sub btnHide5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide5.Click
        HideCards(4)
    End Sub

    Private Sub btnHide6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide6.Click
        HideCards(5)
    End Sub

    Private Sub btnCall1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall1.Click
        CallPass(0)
    End Sub

    Private Sub btnCall2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall2.Click
        CallPass(1)
    End Sub

    Private Sub btnCall3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall3.Click
        CallPass(2)
    End Sub

    Private Sub btnCall4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall4.Click
        CallPass(3)
    End Sub

    Private Sub btnCall5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall5.Click
        CallPass(4)
    End Sub

    Private Sub btnCall6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall6.Click
        CallPass(5)
    End Sub

    Private Sub btnFold1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFold1.Click
        Fold(0)
    End Sub

    Private Sub btnFold2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFold2.Click
        Fold(1)
    End Sub

    Private Sub btnFold3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFold3.Click
        Fold(2)
    End Sub

    Private Sub btnFold4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFold4.Click
        Fold(3)
    End Sub

    Private Sub btnFold5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFold5.Click
        Fold(4)
    End Sub

    Private Sub btnFold6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFold6.Click
        Fold(5)
    End Sub

    Private Sub btnRaise1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaise1.Click
        Raise(0)
    End Sub

    Private Sub btnRaise2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaise2.Click
        Raise(1)
    End Sub

    Private Sub btnRaise3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaise3.Click
        Raise(2)
    End Sub

    Private Sub btnRaise4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaise4.Click
        Raise(3)
    End Sub

    Private Sub btnRaise5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaise5.Click
        Raise(4)
    End Sub

    Private Sub btnRaise6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaise6.Click
        Raise(5)
    End Sub

    Private Sub TrackRaise_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackRaise.Scroll
        lblRaise.Text = "Raise: " + TrackRaise.Value.ToString + " $"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblRaise.Visible = False
        btnRaiseConfirm.Visible = False
        btnCancel.Visible = False
        TrackRaise.Visible = False
    End Sub

    Private Sub btnRaiseConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaiseConfirm.Click
        RaiseCall += TrackRaise.Value
        lblRaise.Visible = False
        btnRaiseConfirm.Visible = False
        btnCancel.Visible = False
        TrackRaise.Visible = False
        For i = 0 To NmbJoueurs - 1
            PlayerCalled(i) = False
        Next
        ChangeTurn(PlayerTurn)
    End Sub
End Class