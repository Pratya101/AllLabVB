Public Class frmAction2

    Dim total As Integer
    Dim pay As Double
    Dim bonus As Double
    Dim social As Double

    Private Sub radDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDisplay.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        lblOutput.Visible = True
        txtEmployee.Visible = True
        txtPay.Visible = True
        grpOperator.Visible = True
    End Sub

    Private Sub radHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHide.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        lblOutput.Visible = False
        txtEmployee.Visible = False
        txtPay.Visible = False
        grpOperator.Visible = False
    End Sub

    Private Sub radEnabled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEnabled.Click
        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        lblOutput.Enabled = True
        txtEmployee.Enabled = True
        txtPay.Enabled = True
        grpOperator.Enabled = True
    End Sub

    Private Sub radUnEnabled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUnEnabled.Click
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        lblOutput.Enabled = False
        txtEmployee.Enabled = False
        txtPay.Enabled = False
        grpOperator.Enabled = False
    End Sub

    Private Sub radTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTotal.Click
        lblOutput.Text = Val(txtPay.Text) * Val(txtEmployee.Text)
    End Sub

    Private Sub radBonus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBonus.Click
        lblOutput.Text = Val(txtEmployee.Text) * 2000
    End Sub

    Private Sub radAllMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAllMoney.Click
        lblOutput.Text = (Val(txtPay.Text) * Val(txtEmployee.Text)) + (Val(txtEmployee.Text) * 2000)
    End Sub

    Private Sub radSocial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSocial.Click
        lblOutput.Text = ((Val(txtPay.Text) * Val(txtEmployee.Text)) + (Val(txtEmployee.Text) * 2000)) * 0.05
    End Sub

    Private Sub bntRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntRestart.Click
        txtEmployee.Clear()
        txtPay.Clear()
        lblOutput.Text = ""
        radAllMoney.Checked = False
        radBonus.Checked = False
        radTotal.Checked = False
        radSocial.Checked = False
        radDisplay.Checked = False
        radEnabled.Checked = False
        radUnEnabled.Checked = False
        radHide.Checked = False
        txtEmployee.Enabled = True
        txtPay.Enabled = True
        lblOutput.Enabled = True
        grpOperator.Enabled = True
        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        txtEmployee.Visible = True
        txtPay.Visible = True
        lblOutput.Visible = True
        grpOperator.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
      
    End Sub

End Class