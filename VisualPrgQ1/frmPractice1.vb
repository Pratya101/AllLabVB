Public Class frmPractice1

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblFullName.Text = txtFirstName.Text & "  " & txtLastName.Text
    End Sub

    Private Sub lblMyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMyName.Click
        lblFullName.Text = txtLastName.Text + "  " + txtFirstName.Text
    End Sub
End Class
