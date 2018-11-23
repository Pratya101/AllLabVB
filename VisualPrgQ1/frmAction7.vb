Public Class frmAction7

    Private Sub btnAddData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddData.Click
        Dim n As Integer
        If Not IsNumeric(txtAddData.Text) Then
            MessageBox.Show("กรุณาใส่ตัวเลขเท่านั้น")
            txtAddData.Clear()
            txtAddData.Focus()
        End If
        If txtAddData.Text.Trim <> "" Then
            lstPrice.Items.Add(txtAddData.Text)
            n = lstPrice.Items.Count
            lstPrice.SelectedIndex = n - 1
            txtAddData.Clear()
            txtAddData.Focus()
        End If
    End Sub

    Private Sub txtAddData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddData.TextChanged
        If txtAddData.Text = "" Then
            btnAddData.Enabled = False
        Else
            btnAddData.Enabled = True
        End If

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim n, r As Integer
        If lstPrice.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูลที่ต้องการส่ง")
        Else
            r = 0
            n = lstPrice.Items.Count
            cboTarget.SelectedIndex = cboTarget.Items.Add(lstPrice.SelectedItem)
            r = lstPrice.SelectedIndex
            lstPrice.Items.RemoveAt(r)

            If r <> n - 1 Then
                lstPrice.SelectedIndex = r
            ElseIf r = n - 1 Then
                n = lstPrice.Items.Count
                lstPrice.SelectedIndex = n - 1
            End If

        End If
    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        Dim r, n, count As Integer
        If lstPrice.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูลที่ต้องการส่ง")
        Else
            count = 0
            n = lstPrice.Items.Count
            For count = 0 To n - 1
                cboTarget.Items.Add(lstPrice.Items(count))

            Next
            r = cboTarget.Items.Count
            cboTarget.SelectedIndex = r - 1
            lstPrice.Items.Clear()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim n, r As Integer
        If cboTarget.Text = "" Then

            MessageBox.Show("ไม่มีข้อมูลที่ต้องการส่ง")
        Else
            r = 0
            n = cboTarget.Items.Count
            lstPrice.SelectedIndex = lstPrice.Items.Add(cboTarget.SelectedItem)
            r = cboTarget.SelectedIndex
            cboTarget.Items.RemoveAt(cboTarget.SelectedIndex)

            If r <> n - 1 Then
                cboTarget.SelectedIndex = r
            ElseIf r = n - 1 Then
                n = cboTarget.Items.Count
                cboTarget.SelectedIndex = n - 1
            End If
        End If

    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        Dim r, n, count As Integer
        If cboTarget.Text = "" Then
            MessageBox.Show("ไม่มีข้อมูลที่ต้องการส่ง")
        Else
            count = 0
            n = cboTarget.Items.Count
            For count = 0 To n - 1
                lstPrice.Items.Add(cboTarget.Items(count))

            Next
            r = lstPrice.Items.Count
            lstPrice.SelectedIndex = r - 1
            cboTarget.Items.Clear()
            cboTarget.Text = ""
            lblTarget.Text = ""
        End If
    End Sub

    Private Sub cboTarget_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTarget.SelectedIndexChanged
        lblTarget.Text = cboTarget.Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cboTarget.Items.Clear()
        lstPrice.Items.Clear()
        txtAddData.Clear()
        lblTarget.Text = ""
        cboTarget.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAction7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class