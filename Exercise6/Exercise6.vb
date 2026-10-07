' Exercise 6 - Paint Estimator
' Purpose: figure wall square footage for a room and how many gallons of paint to buy.

Public Class Exercise6

    Private Const COVERAGE As Double = 144   ' sq ft covered by one gallon (per assignment)

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblLength As Double
        Dim dblWidth As Double
        Dim dblHeight As Double
        Dim dblOpenings As Double
        Dim dblWallArea As Double
        Dim dblNetArea As Double
        Dim dblGallons As Double
        Dim intGallonsToBuy As Integer

        ' Get the input
        If Not Double.TryParse(txtLength.Text, dblLength) OrElse
           Not Double.TryParse(txtWidth.Text, dblWidth) OrElse
           Not Double.TryParse(txtHeight.Text, dblHeight) OrElse
           Not Double.TryParse(txtOpenings.Text, dblOpenings) Then
            MessageBox.Show("Please enter a number in every box.", "Input Error")
            Return
        End If

        ' Calculate
        dblWallArea = 2 * (dblLength + dblWidth) * dblHeight
        dblNetArea = dblWallArea - dblOpenings
        dblGallons = dblNetArea / COVERAGE
        intGallonsToBuy = CInt(Math.Ceiling(dblGallons))

        ' Display
        txtArea.Text = dblNetArea.ToString("N0") & " sq ft"
        txtGallons.Text = dblGallons.ToString("N2") & " gal"
        txtBuy.Text = intGallonsToBuy.ToString() & " gal"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLength.Clear()
        txtWidth.Clear()
        txtHeight.Clear()
        txtOpenings.Clear()
        txtArea.Clear()
        txtGallons.Clear()
        txtBuy.Clear()
        txtLength.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class