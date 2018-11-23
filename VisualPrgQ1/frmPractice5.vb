Public Class frmPractice5

    Private Sub txtPrice_textchanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decToal, decDiscount, decNet As Decimal
        decToal = Val(txtPrice.Text) * Val(txtUnit.Text)
        If decToal < 1000 Then
            decDiscount = 0
        ElseIf decToal < 5000 Then
            decDiscount = 300
        ElseIf decToal < 10000 Then
            decDiscount = 500
        Else
            decDiscount = 1000
        End If
        decNet = decToal - decDiscount
        lblTotal.Text = FormatNumber(decToal)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblNet.Text = FormatNumber(decNet)
    End Sub

    Private Sub txtUnit_textchanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub frmPractice5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class