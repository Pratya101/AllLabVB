Public Class frmPractice7

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If txtInput.Text.Trim() = " " Then
            MessageBox.Show("กรุณาป้อนข้อมูล")
        ElseIf Not IsNumeric(txtInput.Text) Then
            MessageBox.Show("กรุณาป้อนตัวเลข")
        Else
            lstValue.Items.Add(txtInput.Text)
            Call calculate()
        End If
        txtInput.Clear()
        txtInput.Focus()
    End Sub
    Private Sub Calculate()
        Dim i, total, max, min, Avg As Single
        max = lstValue.Items(0)
        min = lstValue.Items(0)
        For i = 0 To lstValue.Items.Count - 1
            total = total + Val(lstValue.Items(i))
            If max < Val(lstValue.Items(i)) Then
                max = Val(lstValue.Items(i))
            End If
            If min > Val(lstValue.Items(i)) Then
                min = Val(lstValue.Items(i))
            End If
        Next i
        Avg = total / lstValue.Items.Count
        lblTotal.Text = total
        lblMax.Text = max
        lblMin.Text = min
        lblAvg.Text = FormatNumber(Avg)
    End Sub
End Class