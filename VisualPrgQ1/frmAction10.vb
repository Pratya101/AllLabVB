Public Class frmAction10
    Dim p1, p2, p3, p4, p5, p6, p7 As Integer
    Dim max As Integer
    Dim decSaleAmount(6, 2), intIndex, decMaxSale As Integer

    Dim strSaleName() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}



    Private Sub frmAction10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpName.Clear()
        p1 = 0
        p2 = 0
        p3 = 0
        p4 = 0
        p5 = 0
        p6 = 0
        p7 = 0
        max = 0
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        decSaleAmount(1, 1) = Val(cboIndex.SelectedIndex + 1)
        decSaleAmount(0, 0) = Val(txtSaleA.Text)
        decSaleAmount(1, 0) = Val(txtSaleB.Text)
        decSaleAmount(2, 0) = Val(txtSaleC.Text)

        showSaleData()

    End Sub

    Sub showSaleData()

        If IsNumeric(txtSaleA.Text) = False Or IsNumeric(txtSaleB.Text) = False Or IsNumeric(txtSaleC.Text) = False Then
            lstSaleData.Items.Add("0  , 0  , 0  , 0 ")

        Else
            lstSaleData.Items.Add(decSaleAmount(1, 1) & "  ,  " & decSaleAmount(0, 0) & "  ,  " & decSaleAmount(1, 0) & "  ,  " & decSaleAmount(2, 0))
            decSaleAmount(3, 0) = decSaleAmount(3, 0) + decSaleAmount(0, 0) ' รวมA
            decSaleAmount(4, 0) = decSaleAmount(4, 0) + decSaleAmount(1, 0) ' รวมB
            decSaleAmount(5, 0) = decSaleAmount(5, 0) + decSaleAmount(2, 0) ' รวมC

            lblAllSaleA.Text = decSaleAmount(3, 0)
            lblAllSaleB.Text = decSaleAmount(4, 0)
            lblAllSaleC.Text = decSaleAmount(5, 0)

            'lblMaxSale.Text = Val(lblAllSaleA.Text) + Val(lblAllSaleB.Text) + Val(lblAllSaleC.Text)

            If cboIndex.SelectedItem = 1 Then
                strSaleName(0) = strSaleName(0) + 1
            ElseIf cboIndex.SelectedItem = 2 Then
                strSaleName(1) = strSaleName(1) + 1
            ElseIf cboIndex.SelectedItem = 3 Then
                strSaleName(2) = strSaleName(2) + 1
            ElseIf cboIndex.SelectedItem = 4 Then
                strSaleName(3) = strSaleName(3) + 1
            ElseIf cboIndex.SelectedItem = 5 Then
                strSaleName(4) = strSaleName(4) + 1
            ElseIf cboIndex.SelectedItem = 6 Then
                strSaleName(5) = strSaleName(5) + 1
            ElseIf cboIndex.SelectedItem = 7 Then
                strSaleName(6) = strSaleName(6) + 1
            End If

            If cboIndex.Text = 1 Then
                p1 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p1

            ElseIf cboIndex.Text = 2 Then
                p2 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p2

            ElseIf cboIndex.Text = 3 Then
                p3 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p3

            ElseIf cboIndex.Text = 4 Then
                p4 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p4

            ElseIf cboIndex.Text = 5 Then
                p5 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p5

            ElseIf cboIndex.Text = 6 Then
                p6 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p6

            ElseIf cboIndex.Text = 7 Then
                p7 = Val(txtSaleA.Text) + Val(txtSaleB.Text) + Val(txtSaleC.Text) + p7
            End If
            If p1 > max Then
                max = p1
                lblMaxName.Text = "test1"
                lblMaxSale.Text = p1
            ElseIf p2 > max Then
                max = p2
                lblMaxName.Text = "test2"
                lblMaxSale.Text = p2
            ElseIf p3 > max Then
                max = p3
                lblMaxName.Text = "test3"
                lblMaxSale.Text = p3
            ElseIf p4 > max Then
                max = p4
                lblMaxName.Text = "test4"
                lblMaxSale.Text = p4
            ElseIf p5 > max Then
                max = p5
                lblMaxName.Text = "test5"
                lblMaxSale.Text = p5
            ElseIf p6 > max Then
                max = p6
                lblMaxName.Text = "test6"
                lblMaxSale.Text = p6
            ElseIf p7 > max Then
                max = p7
                lblMaxName.Text = "test7"
                lblMaxSale.Text = p7
            End If
        End If
    End Sub

    Private Sub cboIndex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIndex.SelectedIndexChanged
        If cboIndex.SelectedItem = 1 Then
            txtEmpName.Text = "test1"
        ElseIf cboIndex.SelectedItem = 2 Then
            txtEmpName.Text = "test2"
        ElseIf cboIndex.SelectedItem = 3 Then
            txtEmpName.Text = "test3"
        ElseIf cboIndex.SelectedItem = 4 Then
            txtEmpName.Text = "test4"
        ElseIf cboIndex.SelectedItem = 5 Then
            txtEmpName.Text = "test5"
        ElseIf cboIndex.SelectedItem = 6 Then
            txtEmpName.Text = "test6"
        ElseIf cboIndex.SelectedItem = 7 Then
            txtEmpName.Text = "test7"
        End If
    End Sub

    Private Sub lblMaxName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMaxName.Click

    End Sub
End Class