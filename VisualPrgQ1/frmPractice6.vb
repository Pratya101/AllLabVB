Public Class frmPractice6

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intSumScore As Integer
        Dim strGrade As String
        Dim deResult As DialogResult
        txtStudentName.Text = txtStudentName.Text.Trim()
        If txtStudentName.Text.Length = 0 Then
            MessageBox.Show("ท่านไม่ได้ป้อนชื่อนักศึกษากรุณาป้อนให้เรียบร้อย", "Invalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Not (IsNumeric(txtLabScore.Text) And IsNumeric(txtMidtrem.Enabled) And IsNumeric(txtFinal.Text)) Then
            MessageBox.Show("ท่านป้อนรายการบางรายการไม่เป็นตัวเลข", "Invalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Val(txtLabScore.Text) < 0 Or Val(txtLabScore.Text) > 40 Or Val(txtMidtrem.Text) < 0 Or Val(txtMidtrem.Text) > 30 Or Val(txtFinal.Text) < 0 Or Val(txtFinal.Text) > 30 Then

            MessageBox.Show("ท่านป้อนคพเนนต่ำหรือสูงเกินไปจากเกณฑ์ที่กำหนด", "Invalid Data", MessageBoxButtons.OK)
            Exit Sub
        Else
            intSumScore = Val(txtLabScore.Text) + Val(txtMidtrem.Text) + Val(txtFinal.Text)
            If intSumScore < 50 Then
                If (40 + Val(txtMidtrem.Text) + Val(txtFinal.Text)) >= 50 Then
                    deResult = MessageBox.Show("ระดับคะเเนนคุณอยู่ในเกณฑ์ช่าวยได้ หากปรับคะเเนนเก็บเพิ่มขึ้น" + vbNewLine + "หากท่านต้องการติด I ไว้ก่อนหรือไม่", "สอบถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If deResult = Windows.Forms.DialogResult.Yes Then
                        strGrade = "I"
                    Else
                        strGrade = "F"
                    End If
                Else
                    strGrade = "F"
                End If
            Else
                Select Case intSumScore
                    Case Is < 55 : strGrade = "D"
                    Case Is < 60 : strGrade = "D+"
                    Case Is < 65 : strGrade = "C"
                    Case Is < 70 : strGrade = "C+"
                    Case Is < 75 : strGrade = "B"
                    Case Is < 80 : strGrade = "B+"
                    Case Else : strGrade = "A"
                End Select
            End If
        End If
        lblSunScore.Text = intSumScore
        lblGrade.Text = strGrade

    End Sub

    Private Sub frmPractice6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class