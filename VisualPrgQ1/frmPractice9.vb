Public Class frmPractice8

    Dim salTotal, commTotal As Decimal

    Private Function getCommission(ByVal yoursale As Decimal) As Decimal
        If yoursale <= 5000 Then
            Return 0
        ElseIf yoursale <= 10000 Then
            Return yoursale * 0.025
        ElseIf yoursale <= 50000 Then
            Return yoursale * 0.05
        Else
            Return yoursale * 0.1
        End If
    End Function

    Private Sub txtYourSale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYourSale.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            '0..9,dot/bkspace
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim commission As Decimal
        If txtName.Text.Trim() = "" Or txtYourSale.Text.Trim() = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "Error", MessageBoxButtons.OK)
            txtName.Focus()
            Exit Sub
        Else
            commission = getCommission(Val(txtYourSale.Text))
            salTotal += CDec(txtYourSale.Text)
            commTotal += commission
            lstData.Items.Add(txtName.Text & "," & txtYourSale.Text & "," & commission)
            lblSaleTotal.Text = salTotal
            lblCommTotal.Text = commTotal
            txtName.Clear()
            txtYourSale.Clear()
            txtName.Focus()
        End If
    End Sub

    Private Sub frmPractice8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class