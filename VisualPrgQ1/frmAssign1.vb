Public Class frmAssign1

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShowHigth.Click

    End Sub

    Private Sub btnCalHigth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalHigth.Click
        lblShowName.Text = (
            txtMyName.Text)

        lblShowWeigth.Text = Val(txtMyWeigth.Text)
        lblShowHigth.Text = lblShowWeigth.Text + 110
    End Sub
End Class