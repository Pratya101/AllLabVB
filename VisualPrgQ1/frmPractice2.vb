Public Class frmPractice2
    Private Sub radUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUs.Click
        lblResult.Text = Val(txtBaht.Text) / 39
    End Sub

    Private Sub radFrench_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.Click
        lblResult.Text = Val(txtBaht.Text) / 37
    End Sub

    Private Sub radKorea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radKorea.Click
        lblResult.Text = Val(txtBaht.Text) / 30
    End Sub

    Private Sub radLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLock.Click
        txtBaht.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub radUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUnLock.Click
        txtBaht.Enabled = True
        radUs.Enabled = True
        radFrench.Enabled = True
        radKorea.Enabled = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class