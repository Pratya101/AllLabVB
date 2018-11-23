Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmAction11
    Dim conNB As New SqlConnection
    Dim myDa As New SqlDataAdapter
    Dim myDS As DataSet
    Dim strSQL As String
    Dim strConn As String = ConfigurationManager.ConnectionStrings("VisualPrgQ1.My.MySettings.myCon").ConnectionString

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conNB.State = ConnectionState.Open Then
            conNB.Close()
        End If
        conNB.ConnectionString = strConn
        conNB.Open()
    End Sub

    Private Sub btnResult1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResult1.Click
        strSQL = "select * from product where product like '%c'"
        myDa = New SqlDataAdapter(strSQL, strConn)
        myDS.Tables.Clear()
        myDa.Fill(myDS, "tbPro")
        dgvResult.DataSource = myDS.Tables("tbPro")
        dgvResult.Columns(0).Width = 70
        dgvResult.Columns(1).Width = 150
        dgvResult.Columns(2).Width = 70
        dgvResult.Columns(3).Width = 70
        dgvResult.Columns(4).Width = 100
        dgvResult.Columns(5).Width = 70
        dgvResult.Columns(6).Width = 70
        dgvResult.Columns(7).Width = 70
        dgvResult.Columns(8).Width = 70
        dgvResult.Columns(9).Width = 70
        dgvResult.Columns(0).HeaderText = "รหัสสินค้า"
        dgvResult.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvResult.Columns(2).HeaderText = "รหัสผู้ผลิต"
        dgvResult.Columns(3).HeaderText = "รหัสประเภท"
        dgvResult.Columns(4).HeaderText = "จำนวนต่อหน่วย"
        dgvResult.Columns(5).HeaderText = "ราคาต่อหน่วย"
        dgvResult.Columns(6).HeaderText = "จำนวนคงเหลือ"
        dgvResult.Columns(7).HeaderText = "จำนวนที่สั่งซื้อ"
        dgvResult.Columns(8).HeaderText = "ระดับการสั่งซื้อใหม่"
        dgvResult.Columns(9).HeaderText = "ยกเลิก"
        dgvResult.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvResult.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvResult.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvResult.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        conNB.Close()
    End Sub
End Class