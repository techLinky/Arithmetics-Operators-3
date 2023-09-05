Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declaration of variables and their datatypes
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iNumber3 As Decimal

        'taking inputs from the user
        iNumber1 = txtFirstNumber.Text
        iNumber2 = txtSecondNumber.Text

        'for addition
        iNumber3 = iNumber1 + iNumber2
        MsgBox(iNumber1 & " + " & iNumber2 & " = " & iNumber3)

        'for the substraction
        iNumber3 = iNumber1 - iNumber2
        MsgBox(iNumber1 & " - " & iNumber2 & " = " & iNumber3)

        'for multiplication
        iNumber3 = iNumber1 * iNumber2
        MsgBox(iNumber1 & " * " & iNumber2 & " = " & iNumber3)

        'for division
        iNumber3 = iNumber1 / iNumber2
        MsgBox(iNumber1 & " / " & iNumber2 & " = " & iNumber3)

        'the following operators are not soo popular
        'for the power operator
        iNumber3 = iNumber1 ^ iNumber2
        MsgBox(iNumber1 & " to the power of " & iNumber2 & " = " & iNumber3)

        'for DIV integer division
        iNumber3 = iNumber1 \ iNumber2
        MsgBox(iNumber1 & " \ " & iNumber2 & " = " & iNumber3)
    End Sub

    Private Sub txtFirstNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNumber.TextChanged

    End Sub
End Class
