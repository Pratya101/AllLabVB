Public Class frmAssign6
    Dim A As DialogResult
    Dim Price As Integer
    Private Sub chkCarSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSale.Click
        If chkSale.Checked = False Then
            A = MessageBox.Show("ท่านต้องการยกเลิกการซื้อรถหรือไม่", "เตื่อน!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If A = Windows.Forms.DialogResult.Yes Then
                lblNetPrice.Text = ""
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
            Else
                chkSale.Checked = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
            End If
        Else
            Price = Val(lblCarPrice.Text)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblNetPrice.Text = 1150000 + 25000 + 15000 + 35000
            Exit Sub
        End If
    End Sub

    Private Sub chkOption1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOption1.CheckedChanged
        If chkOption1.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + 40000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - 40000
        End If

    End Sub

    Private Sub chkOption2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOption2.CheckedChanged
        If chkOption2.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + 50000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - 50000
        End If
    End Sub

    Private Sub chkOption3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOption3.CheckedChanged
        If chkOption3.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + 20000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - 20000
        End If
    End Sub

    Private Sub chkOption4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOption4.CheckedChanged
        If chkOption4.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + 30000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - 30000
        End If
    End Sub

    Private Sub chkInsurance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInsurance.CheckedChanged
        If chkInsurance.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) - 25000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) + 25000
        End If
    End Sub

    Private Sub chkRaw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRaw.CheckedChanged
        If chkRaw.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) - 15000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) + 15000
        End If
    End Sub

    Private Sub chkRegis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegis.CheckedChanged
        If chkRegis.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) - 35000
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) + 35000
        End If
    End Sub
    Private Sub frmAssign6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNetPrice.Text = ""

    End Sub
End Class