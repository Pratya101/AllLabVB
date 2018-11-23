<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAction10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSaleData = New System.Windows.Forms.ListBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAllSaleA = New System.Windows.Forms.Label()
        Me.lblAllSaleB = New System.Windows.Forms.Label()
        Me.lblAllSaleC = New System.Windows.Forms.Label()
        Me.lblMaxName = New System.Windows.Forms.Label()
        Me.lblMaxSale = New System.Windows.Forms.Label()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณยอกขายจากอาเรย์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รายการข้อมูล"
        '
        'lstSaleData
        '
        Me.lstSaleData.FormattingEnabled = True
        Me.lstSaleData.Location = New System.Drawing.Point(81, 101)
        Me.lstSaleData.Name = "lstSaleData"
        Me.lstSaleData.Size = New System.Drawing.Size(134, 147)
        Me.lstSaleData.TabIndex = 2
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(81, 356)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(134, 20)
        Me.txtEmpName.TabIndex = 4
        '
        'txtSaleA
        '
        Me.txtSaleA.Location = New System.Drawing.Point(247, 357)
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(76, 20)
        Me.txtSaleA.TabIndex = 5
        '
        'txtSaleB
        '
        Me.txtSaleB.Location = New System.Drawing.Point(345, 357)
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(76, 20)
        Me.txtSaleB.TabIndex = 5
        '
        'txtSaleC
        '
        Me.txtSaleC.Location = New System.Drawing.Point(444, 357)
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(76, 20)
        Me.txtSaleC.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(553, 354)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "รวมยอกสินค้าA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "รวมยอกสินค้าB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "รวมยอกสินค้าC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ผู้ที่ทำยอดขายสูงสุด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "เป็นเงิน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ชื่อพนักวานขาย"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "พนักงานขายคนที่"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "สินค้าA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(342, 341)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "สินค้าB"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(441, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "สินค้าC"
        '
        'lblAllSaleA
        '
        Me.lblAllSaleA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllSaleA.Location = New System.Drawing.Point(494, 100)
        Me.lblAllSaleA.Name = "lblAllSaleA"
        Me.lblAllSaleA.Size = New System.Drawing.Size(100, 23)
        Me.lblAllSaleA.TabIndex = 7
        '
        'lblAllSaleB
        '
        Me.lblAllSaleB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllSaleB.Location = New System.Drawing.Point(494, 158)
        Me.lblAllSaleB.Name = "lblAllSaleB"
        Me.lblAllSaleB.Size = New System.Drawing.Size(100, 23)
        Me.lblAllSaleB.TabIndex = 7
        '
        'lblAllSaleC
        '
        Me.lblAllSaleC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllSaleC.Location = New System.Drawing.Point(494, 217)
        Me.lblAllSaleC.Name = "lblAllSaleC"
        Me.lblAllSaleC.Size = New System.Drawing.Size(100, 23)
        Me.lblAllSaleC.TabIndex = 7
        '
        'lblMaxName
        '
        Me.lblMaxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxName.Location = New System.Drawing.Point(494, 256)
        Me.lblMaxName.Name = "lblMaxName"
        Me.lblMaxName.Size = New System.Drawing.Size(100, 23)
        Me.lblMaxName.TabIndex = 7
        '
        'lblMaxSale
        '
        Me.lblMaxSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSale.Location = New System.Drawing.Point(494, 293)
        Me.lblMaxSale.Name = "lblMaxSale"
        Me.lblMaxSale.Size = New System.Drawing.Size(100, 23)
        Me.lblMaxSale.TabIndex = 7
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.ItemHeight = 13
        Me.cboIndex.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboIndex.Location = New System.Drawing.Point(81, 294)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(134, 21)
        Me.cboIndex.TabIndex = 8
        Me.cboIndex.TabStop = False
        '
        'frmAction10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 389)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lblMaxSale)
        Me.Controls.Add(Me.lblMaxName)
        Me.Controls.Add(Me.lblAllSaleC)
        Me.Controls.Add(Me.lblAllSaleB)
        Me.Controls.Add(Me.lblAllSaleA)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.lstSaleData)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAction10"
        Me.Text = "frmAction10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstSaleData As System.Windows.Forms.ListBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleA As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleB As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleC As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblAllSaleA As System.Windows.Forms.Label
    Friend WithEvents lblAllSaleB As System.Windows.Forms.Label
    Friend WithEvents lblAllSaleC As System.Windows.Forms.Label
    Friend WithEvents lblMaxName As System.Windows.Forms.Label
    Friend WithEvents lblMaxSale As System.Windows.Forms.Label
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
End Class
