Public Class frmAction3

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtNumber.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtNumber.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtNumber.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtNumber.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBlavk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlavk.Click
        txtNumber.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtNumber.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtNumber.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtNumber.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        txtNumber.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        txtNumber.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBRed.Click
        txtNumber.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlue.Click
        txtNumber.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGreen.Click
        txtNumber.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBViolet.Click
        txtNumber.BackColor = Color.Violet
    End Sub

    Private Sub lblBBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlack.Click
        txtNumber.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBOrange.Click
        txtNumber.BackColor = Color.Orange
    End Sub

    Private Sub lblBYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBYellow.Click
        txtNumber.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBrown.Click
        txtNumber.BackColor = Color.Brown
    End Sub

    Private Sub lblBWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBWhite.Click
        txtNumber.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBSky.Click
        txtNumber.BackColor = Color.SkyBlue
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        For a As Integer = 14 To 70 Step 1
            If ComboBox1.Text = a Then
                txtNumber.Font = New Font(txtNumber.Font.Name, a, FontStyle.Regular)
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Up As Integer = Val(txtNumber.Text)
        Up = Up + 5
        txtNumber.Text = Up
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Down As Integer = Val(txtNumber.Text)
        Down = Down - 5
        txtNumber.Text = Down
    End Sub

End Class