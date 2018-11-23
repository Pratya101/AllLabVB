<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAction5
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radCustomer = New System.Windows.Forms.RadioButton()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtProPrice = New System.Windows.Forms.TextBox()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.btnCalulate = New System.Windows.Forms.Button()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblGrant = New System.Windows.Forms.Label()
        Me.lblSumSale = New System.Windows.Forms.Label()
        Me.lblDoscount = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "จำนวนเงินต้องชำระ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radNone)
        Me.GroupBox1.Controls.Add(Me.radCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 67)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กลุ่มลูกค้า"
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(97, 28)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(65, 17)
        Me.radNone.TabIndex = 1
        Me.radNone.TabStop = True
        Me.radNone.Text = "ภายนอก"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radCustomer
        '
        Me.radCustomer.AutoSize = True
        Me.radCustomer.Location = New System.Drawing.Point(17, 28)
        Me.radCustomer.Name = "radCustomer"
        Me.radCustomer.Size = New System.Drawing.Size(58, 17)
        Me.radCustomer.TabIndex = 0
        Me.radCustomer.TabStop = True
        Me.radCustomer.Text = "ภายใน"
        Me.radCustomer.UseVisualStyleBackColor = True
        '
        'gpbPaid
        '
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radCash)
        Me.gpbPaid.Location = New System.Drawing.Point(259, 174)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(200, 67)
        Me.gpbPaid.TabIndex = 2
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(106, 28)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(57, 17)
        Me.radCredit.TabIndex = 1
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เครดิต"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(20, 28)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(38, 17)
        Me.radCash.TabIndex = 0
        Me.radCash.TabStop = True
        Me.radCash.Text = "สด"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(173, 71)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(217, 20)
        Me.txtProduct.TabIndex = 3
        '
        'txtProPrice
        '
        Me.txtProPrice.Location = New System.Drawing.Point(173, 97)
        Me.txtProPrice.Name = "txtProPrice"
        Me.txtProPrice.Size = New System.Drawing.Size(217, 20)
        Me.txtProPrice.TabIndex = 4
        '
        'txtProAmount
        '
        Me.txtProAmount.Location = New System.Drawing.Point(173, 122)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(217, 20)
        Me.txtProAmount.TabIndex = 5
        '
        'btnCalulate
        '
        Me.btnCalulate.Location = New System.Drawing.Point(211, 351)
        Me.btnCalulate.Name = "btnCalulate"
        Me.btnCalulate.Size = New System.Drawing.Size(138, 34)
        Me.btnCalulate.TabIndex = 10
        Me.btnCalulate.Text = "คำนวณ"
        Me.btnCalulate.UseVisualStyleBackColor = True
        '
        'lblCredit
        '
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredit.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(168, 313)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(222, 26)
        Me.lblCredit.TabIndex = 0
        '
        'lblGrant
        '
        Me.lblGrant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrant.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGrant.Location = New System.Drawing.Point(168, 277)
        Me.lblGrant.Name = "lblGrant"
        Me.lblGrant.Size = New System.Drawing.Size(222, 26)
        Me.lblGrant.TabIndex = 0
        '
        'lblSumSale
        '
        Me.lblSumSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSumSale.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumSale.Location = New System.Drawing.Point(173, 145)
        Me.lblSumSale.Name = "lblSumSale"
        Me.lblSumSale.Size = New System.Drawing.Size(217, 26)
        Me.lblSumSale.TabIndex = 0
        '
        'lblDoscount
        '
        Me.lblDoscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDoscount.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDoscount.Location = New System.Drawing.Point(168, 244)
        Me.lblDoscount.Name = "lblDoscount"
        Me.lblDoscount.Size = New System.Drawing.Size(222, 26)
        Me.lblDoscount.TabIndex = 0
        '
        'frmAction5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 397)
        Me.Controls.Add(Me.btnCalulate)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.txtProPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSumSale)
        Me.Controls.Add(Me.lblDoscount)
        Me.Controls.Add(Me.lblGrant)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAction5"
        Me.Text = "Week5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents radCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents gpbPaid As System.Windows.Forms.GroupBox
    Friend WithEvents radCredit As System.Windows.Forms.RadioButton
    Friend WithEvents radCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtProPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnCalulate As System.Windows.Forms.Button
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblGrant As System.Windows.Forms.Label
    Friend WithEvents lblSumSale As System.Windows.Forms.Label
    Friend WithEvents lblDoscount As System.Windows.Forms.Label
End Class
