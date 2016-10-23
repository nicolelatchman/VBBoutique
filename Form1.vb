Public Class frmBoutique
    Dim totalCost As Double
    Dim item As String
    Dim color As String
    Dim quantity As Integer
    Dim shippingCost As Double

    'If "Add To Cart and Continue" is Clicked
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If (radCrochted.Checked) Then

            If lstColors.Text = "" Then
                MessageBox.Show("Please select a color.")
                Return
            End If

            If numQuantity.Value = 0 Then
                MessageBox.Show("Please select a quantity.")
                Return
            End If

            If (radHats.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim hatCost As Double = 10 * quantity
                totalCost += hatCost
                item = "Hat | " & color & " | " & "Quantity: 1"

            ElseIf (radGlove.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim gloveCost As Double = 12 * quantity
                totalCost += gloveCost
                item = "Glove | " & color & " | " & "Quantity: 1"

            ElseIf (radScarf.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim scarfCost As Double = 12 * quantity
                totalCost += scarfCost
                item = "Scarf | " & color & " | " & "Quantity: 1"

            ElseIf (radWrap.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim wrapCost As Double = 25 * quantity
                totalCost += wrapCost
                item = "Wrap | " & color & " | " & "Quantity: 1"

            Else
                MessageBox.Show("Error: No Item Selected.")
            End If

            Dim counter As Integer
            For counter = 1 To quantity
                lstCart.Items.Add(item)
            Next

            txtSubtotal.Text = totalCost.ToString("C")

        ElseIf radCharm.Checked Then
            lstColors.ClearSelected()
            numQuantity.Value = 0
            item = "Charm: "
            totalCost += 10

            If chkCat.Checked Then
                totalCost += 2
                item += "| Cat "
            End If

            If chkDog.Checked Then
                totalCost += 2
                item += "| Dog "
            End If

            If chkFlower.Checked Then
                totalCost += 2
                item += "| Flower "
            End If

            If chkRabbit.Checked Then
                totalCost += 2
                item += "| Rabbit "
            End If

            If chkSnowflake.Checked Then
                totalCost += 2
                item += "| Snowflake "
            End If

            If chkStar.Checked Then
                totalCost += 2
                item += "| Star "
            End If

            item += "| Quantity: 1"

            lstCart.Items.Add(item)
            txtSubtotal.Text = totalCost.ToString("C")
        Else
            MessageBox.Show("Please select an item.")
        End If

        numQuantity.Value = 0
        radHats.Checked = False
        radGlove.Checked = False
        radScarf.Checked = False
        radWrap.Checked = False
        chkCat.Checked = False
        chkDog.Checked = False
        chkFlower.Checked = False
        chkRabbit.Checked = False
        chkSnowflake.Checked = False
        chkStar.Checked = False
        radCrochted.Checked = False
        radCharm.Checked = False
        lstColors.ClearSelected()

    End Sub

    'If "Delete" is clicked
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstCart.Text.Contains("Charm") Then
            totalCost -= 10

            If lstCart.Text.Contains("Cat") Then
                totalCost -= 2
            End If

            If lstCart.Text.Contains("Dog") Then
                totalCost -= 2
            End If

            If lstCart.Text.Contains("Flower") Then
                totalCost -= 2
            End If

            If lstCart.Text.Contains("Rabbit") Then
                totalCost -= 2
            End If

            If lstCart.Text.Contains("Snowflake") Then
                totalCost -= 2
            End If

            If lstCart.Text.Contains("Star") Then
                totalCost -= 2
            End If
        End If

        If lstCart.Text.Contains("Hat") Then
            totalCost -= 10
        End If

        If lstCart.Text.Contains("Glove") Then
            totalCost -= 12
        End If

        If lstCart.Text.Contains("Scarf") Then
            totalCost -= 12
        End If

        If lstCart.Text.Contains("Wrap") Then
            totalCost -= 25
        End If

        txtSubtotal.Text = totalCost.ToString("C")
        lstCart.Items.Remove(lstCart.Text)
    End Sub


    Private Sub btnCheckoutOnly_Click(sender As Object, e As EventArgs) Handles btnCheckoutOnly.Click
        If lstCart.Items.Count = 0 Then
            MessageBox.Show("Error: Your cart is empty.")
            Return
        End If

        grpShipping.Visible = True
        radStandard.Visible = True
        radPriority.Visible = True
        radNextDay.Visible = True
        btnCancel.Visible = True
        btnTotal.Visible = True
        lstFinal.Visible = True
        btnSubmit.Visible = True
        btnBack.Visible = True
        btnCheckout.Visible = False
        btnCheckoutOnly.Visible = False
        btnDelete.Visible = False
        btnContinue.Visible = False
        grpSelectItem.Visible = False
    End Sub

    'If "Add To Cart and Checkout" is clicked
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        If (radCrochted.Checked) Then

            If lstColors.Text = "" Then
                MessageBox.Show("Please select a color.")
                Return
            End If

            If numQuantity.Value = 0 Then
                MessageBox.Show("Please select a quantity.")
                Return
            End If

            If (radHats.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim hatCost As Double = 10 * quantity
                totalCost += hatCost
                item = "Hat | " & color & " | " & "Quantity: 1"

            ElseIf (radGlove.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim gloveCost As Double = 12 * quantity
                totalCost += gloveCost
                item = "Glove | " & color & " | " & "Quantity: 1"

            ElseIf (radScarf.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim scarfCost As Double = 12 * quantity
                totalCost += scarfCost
                item = "Scarf | " & color & " | " & "Quantity: 1"

            ElseIf (radWrap.Checked) Then
                color = lstColors.Text
                quantity = CInt(numQuantity.Text)
                Dim wrapCost As Double = 25 * quantity
                totalCost += wrapCost
                item = "Wrap | " & color & " | " & "Quantity: 1"

            Else
                MessageBox.Show("Error: No Item Selected.")
                Return
            End If

            Dim counter As Integer
            For counter = 1 To quantity
                lstCart.Items.Add(item)
            Next

            txtSubtotal.Text = totalCost.ToString("C")
            'End If

        ElseIf radCharm.Checked Then
            lstColors.ClearSelected()
            numQuantity.Value = 0
            item = "Charm: "
            totalCost += 10

            If chkCat.Checked Then
                totalCost += 2
                item += "| Cat "
            End If

            If chkDog.Checked Then
                totalCost += 2
                item += "| Dog "
            End If

            If chkFlower.Checked Then
                totalCost += 2
                item += "| Flower "
            End If

            If chkRabbit.Checked Then
                totalCost += 2
                item += "| Rabbit "
            End If

            If chkSnowflake.Checked Then
                totalCost += 2
                item += "| Snowflake "
            End If

            If chkStar.Checked Then
                totalCost += 2
                item += "| Star "
            End If

            item += "| Quantity: 1"

            lstCart.Items.Add(item)
            txtSubtotal.Text = totalCost.ToString("C")

        Else
            MessageBox.Show("Error: No items to add.")
            Return
        End If

        grpShipping.Visible = True
        radStandard.Visible = True
        radPriority.Visible = True
        radNextDay.Visible = True
        btnCancel.Visible = True
        btnTotal.Visible = True
        lstFinal.Visible = True
        btnSubmit.Visible = True
        btnBack.Visible = True
        btnCheckout.Visible = False
        btnCheckoutOnly.Visible = False
        btnDelete.Visible = False
        btnContinue.Visible = False
        grpSelectItem.Visible = False
    End Sub

    'If "Total Cost" is clicked
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        lstFinal.Items.Clear()
        Dim subTotal As Double = totalCost
        Dim finalTotal As Double = totalCost
        Dim tax As Double = (totalCost * 0.085)

        If radStandard.Checked Then
            shippingCost = 2.95
            finalTotal += 2.95

        ElseIf radPriority.Checked Then
            shippingCost = 9.95
            finalTotal += 9.95

        ElseIf radNextDay.Checked Then
            shippingCost = 14.95
            finalTotal += 14.95

        Else
            MessageBox.Show("You must pick a shipping option.")
            Return
        End If

        finalTotal += tax
        lstFinal.Items.AddRange(lstCart.Items)
        lstFinal.Items.Add("Subtotal: " & subTotal.ToString("C"))
        lstFinal.Items.Add("Tax: " & tax.ToString("C"))
        lstFinal.Items.Add("Shipping: " & shippingCost.ToString("C"))
        lstFinal.Items.Add("")
        lstFinal.Items.Add("Total Cost: " & finalTotal.ToString("C"))

    End Sub

    'If "Submit" is clicked
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (shippingCost = 0) Then
            MessageBox.Show("You must pick a shipping option.")
            Return
        End If
        MessageBox.Show("Success! Your order has been placed!")
        Close()
    End Sub

    'If "Cancel" is clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MessageBox.Show("Your order has been cancelled.")
        Close()
    End Sub

    'If "Back" is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        lstFinal.Items.Clear()
        grpShipping.Visible = False
        radPriority.Visible = False
        radStandard.Visible = False
        radNextDay.Visible = False
        btnCancel.Visible = False
        btnTotal.Visible = False
        lstFinal.Visible = False
        btnSubmit.Visible = False
        btnBack.Visible = False
        btnCheckout.Visible = True
        btnCheckoutOnly.Visible = True
        btnDelete.Visible = True
        btnContinue.Visible = True
        grpSelectItem.Visible = True
    End Sub

    Private Sub radCrochted_Enter(sender As Object, e As EventArgs) Handles radCrochted.Enter
        grpCharm.Visible = False
        grpCrocheted.Visible = True
        lblColors.Visible = True
        lstColors.Visible = True
        numQuantity.Visible = True
        lblQuantity.Visible = True
    End Sub

    Private Sub radCharm_Enter(sender As Object, e As EventArgs) Handles radCharm.Enter
        grpCharm.Visible = True
        grpCrocheted.Visible = False
        lblColors.Visible = False
        lstColors.Visible = False
        numQuantity.Visible = False
        lblQuantity.Visible = False
    End Sub

End Class
