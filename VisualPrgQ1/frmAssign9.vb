Public Class frmAssign9
    Dim sumScore, sumCredit As Integer
    Private Sub getCalNewGPA(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblAllScore.Text = "150"
        lblAllCredit.Text = "50"
        lblOldGPA.Text = "3.00"
    End Sub
    Private Function getCalNewGrade(ByVal score As Decimal) As String
        Dim Dgrade As String
        If score < 50 Then
            Dgrade = "F"
        ElseIf score < 55 Then
            Dgrade = "D"
        ElseIf score < 60 Then
            Dgrade = "D+"
        ElseIf score < 65 Then
            Dgrade = "C"
        ElseIf score < 70 Then
            Dgrade = "C+"
        ElseIf score < 75 Then
            Dgrade = "B"
        ElseIf score < 80 Then
            Dgrade = "B+"
        Else
            Dgrade = "A"
        End If
        Return Dgrade
    End Function
    Private Sub lstCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCourse.SelectedIndexChanged
        lstCredit.SelectedIndex = lstCourse.SelectedIndex
        lstGrade.SelectedIndex = lstCourse.SelectedIndex
        lstScore.SelectedIndex = lstCourse.SelectedIndex
    End Sub
    Private Sub lstScore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScore.SelectedIndexChanged
        lstCourse.SelectedIndex = lstScore.SelectedIndex
    End Sub
    Private Sub lstCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCredit.SelectedIndexChanged
        lstCourse.SelectedIndex = lstCredit.SelectedIndex
    End Sub
    Private Sub lstGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGrade.SelectedIndexChanged
        lstCourse.SelectedIndex = lstGrade.SelectedIndex
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim grade As String
        If txtCourse.Text.Trim() = "" Or txtScore.Text.Trim() = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "Error...", MessageBoxButtons.OK)
            txtCourse.Focus()
            Exit Sub
        Else
            lstCourse.Items.Add(txtCourse.Text.Trim())
            lstCredit.Items.Add(txtCredit.Text.Trim())
            grade = getCalNewGrade(CDec(txtScore.Text.Trim()))
            lstScore.Items.Add(txtScore.Text.Trim())
            lstGrade.Items.Add(grade)
            txtCredit.Clear()
            txtScore.Clear()
            txtCourse.Clear()
            txtCourse.Focus()
        End If
        lstCourse.SelectedIndex = lstCourse.Items.Count - 1
        Call proCalNewData()
    End Sub
    Private Sub proCalNewData()
        Dim i As Integer = 0
        Dim Grade, Credit, NewGrade As Decimal
        Do Until i > lstGrade.Items.Count - 1
            Select Case lstGrade.Items(i)
                Case "F" : Grade = 0
                Case "D" : Grade = 1
                Case "D+" : Grade = 1.5
                Case "C" : Grade = 2
                Case "C+" : Grade = 2.5
                Case "B" : Grade = 3
                Case "B+" : Grade = 3.5
                Case "A" : Grade = 4
            End Select
            NewGrade += Grade * lstCredit.Items(i)
            Credit += lstCredit.Items(i)
            i += 1
        Loop
        sumScore = 150 + NewGrade
        sumCredit = 50 + Credit
        lblNewGPA.Text = FormatNumber(sumScore / sumCredit, 2)
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        lstScore.Items.Clear()
        lstCourse.Items.Clear()
        lblNewGPA.Text = ""
        txtCredit.Clear()
        txtScore.Clear()
        txtCourse.Clear()
        Call getCalNewGPA(sender, e)
    End Sub

    Private Sub txtScore_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub
End Class

