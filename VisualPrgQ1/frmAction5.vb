Public Class frmAction5
    Dim decSumSale, decDiscount, decGrant, decCredit, dectotal As Decimal
    Private Sub txtProPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProPrice.TextChanged
        If IsNumeric(txtProPrice.Text) Or txtProPrice.Text = "" Then
            decSumSale = Val(txtProPrice.Text)
            lblSumSale.Text = decSumSale
        Else
            MessageBox.Show("ป้อนข้อมูลตัวเลข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProPrice.Clear()
            lblSumSale.Text = ""
            txtProPrice.Focus()
        End If
 

    End Sub
    Private Sub txtProAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProAmount.TextChanged
        If IsNumeric(txtProAmount.Text) Or txtProAmount.Text = "" Then
            dectotal = Val(txtProPrice.Text) * Val(txtProAmount.Text)
            lblSumSale.Text = FormatNumber(dectotal)
        Else
            MessageBox.Show("ป้อนข้อมูลตัวเลข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProAmount.Clear()
            lblSumSale.Text = decSumSale
            txtProAmount.Focus()
        End If
    End Sub
    Private Sub radNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNone.CheckedChanged
        gpbPaid.Enabled = False
        radCash.Checked = True
        radCredit.Checked = False
        lblDoscount.Text = ""
        lblCredit.Text = ""
        lblGrant.Text = ""

    End Sub
    Private Sub radCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCustomer.CheckedChanged
        gpbPaid.Enabled = True
        radCash.Checked = True
        radCredit.Checked = False
        lblDoscount.Text = ""
        lblCredit.Text = ""
        lblGrant.Text = ""
    End Sub
    Private Sub radCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCash.CheckedChanged
        lblDoscount.Text = ""
        lblCredit.Text = ""
        lblGrant.Text = ""
    End Sub
    Private Sub radCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCredit.CheckedChanged
        lblDoscount.Text = ""
        lblCredit.Text = ""
        lblGrant.Text = ""
    End Sub
    Private Sub btnCalulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalulate.Click
        dectotal = Val(txtProPrice.Text) * Val(txtProAmount.Text)

        txtProduct.Text = txtProduct.Text
        txtProAmount.Text = txtProAmount.Text
        txtProPrice.Text = txtProPrice.Text
        If (txtProduct.Text = "") Then
            MessageBox.Show("ป้อนข้อมูลไม่ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProduct.Focus()
            Exit Sub
        End If
        If IsNumeric(txtProduct.Text) Then
            MessageBox.Show("กรุณาป้อนเป้นตัวอักษร", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProduct.Clear()
            txtProduct.Focus()
            Exit Sub
        End If
        dectotal = Val(txtProPrice.Text) * Val(txtProAmount.Text)

        If dectotal < 2500 Then
            decDiscount = 0
        ElseIf dectotal < 10000 Then
            decDiscount = dectotal * 0.1
        ElseIf dectotal < 20000 Then
            decDiscount = dectotal * 0.15
        Else
            decDiscount = dectotal * 0.2
        End If
        lblDoscount.Text = FormatNumber(decDiscount)
        decGrant = dectotal - decDiscount
        lblGrant.Text = FormatNumber(decGrant)
        If radCash.Checked = True Then
            lblCredit.Text = 0
        ElseIf radCredit.Checked = True Then
            lblDoscount.Text = "ไม่ได้รับส่วนลด"
            lblGrant.Text = FormatNumber(dectotal)
            lblCredit.Text = FormatNumber(dectotal)
        End If

        If radNone.Checked = True Then
            lblDoscount.Text = "ไม่ได้รับส่วนลด"
            lblGrant.Text = lblSumSale.Text
        End If
    End Sub

    Private Sub frmAction5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class