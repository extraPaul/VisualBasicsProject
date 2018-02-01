Public Class Calculatrice

    Public equation As String
    Dim num1, num2 As String
    Public calcule As Double
    Public answer As Integer

    Private Sub Calculatrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = opacite
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        num1 = txtEcrant.Text
        num2 = "1"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        num1 = txtEcrant.Text
        num2 = "2"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        num1 = txtEcrant.Text
        num2 = "3"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        num1 = txtEcrant.Text
        num2 = "4"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        num1 = txtEcrant.Text
        num2 = "5"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        num1 = txtEcrant.Text
        num2 = "6"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        num1 = txtEcrant.Text
        num2 = "7"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        num1 = txtEcrant.Text
        num2 = "8"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        num1 = txtEcrant.Text
        num2 = "9"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        num1 = txtEcrant.Text
        num2 = "0"
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        num1 = txtEcrant.Text
        num2 = " + "
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btnMoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoins.Click
        num1 = txtEcrant.Text
        num2 = " - "
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btnMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplication.Click
        num1 = txtEcrant.Text
        num2 = " * "
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        num1 = txtEcrant.Text
        num2 = " / "
        txtEcrant.Text = num1 & num2
    End Sub

    Private Sub btnEgale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEgale.Click
        equation = txtEcrant.Text
        calcule = equation
        answer = calcule
        txtEcrant.Text = answer

    End Sub

End Class