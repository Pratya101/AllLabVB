<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice4
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
        Me.lblProId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProTotal = New System.Windows.Forms.Label()
        Me.lblProNet = New System.Windows.Forms.Label()
        Me.radProCash = New System.Windows.Forms.RadioButton()
        Me.radProCredit = New System.Windows.Forms.RadioButton()
        Me.txtProAMount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาต่อหน่วย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "การชำระเงิน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ยอดชำระ"
        '
        'lblProId
        '
        Me.lblProId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProId.Location = New System.Drawing.Point(216, 54)
        Me.lblProId.Name = "lblProId"
        Me.lblProId.Size = New System.Drawing.Size(158, 23)
        Me.lblProId.TabIndex = 1
        '
        'lblProName
        '
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProName.Location = New System.Drawing.Point(216, 89)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(158, 21)
        Me.lblProName.TabIndex = 1
        '
        'lblProPrice
        '
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProPrice.Location = New System.Drawing.Point(216, 141)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(158, 21)
        Me.lblProPrice.TabIndex = 1
        '
        'lblProTotal
        '
        Me.lblProTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProTotal.Location = New System.Drawing.Point(216, 238)
        Me.lblProTotal.Name = "lblProTotal"
        Me.lblProTotal.Size = New System.Drawing.Size(158, 21)
        Me.lblProTotal.TabIndex = 1
        '
        'lblProNet
        '
        Me.lblProNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProNet.Location = New System.Drawing.Point(216, 362)
        Me.lblProNet.Name = "lblProNet"
        Me.lblProNet.Size = New System.Drawing.Size(158, 21)
        Me.lblProNet.TabIndex = 1
        '
        'radProCash
        '
        Me.radProCash.AutoSize = True
        Me.radProCash.Location = New System.Drawing.Point(219, 282)
        Me.radProCash.Name = "radProCash"
        Me.radProCash.Size = New System.Drawing.Size(56, 17)
        Me.radProCash.TabIndex = 2
        Me.radProCash.TabStop = True
        Me.radProCash.Text = "เงินสด"
        Me.radProCash.UseVisualStyleBackColor = True
        '
        'radProCredit
        '
        Me.radProCredit.AutoSize = True
        Me.radProCredit.Location = New System.Drawing.Point(316, 282)
        Me.radProCredit.Name = "radProCredit"
        Me.radProCredit.Size = New System.Drawing.Size(61, 17)
        Me.radProCredit.TabIndex = 3
        Me.radProCredit.TabStop = True
        Me.radProCredit.Text = "เงินเชื่อ"
        Me.radProCredit.UseVisualStyleBackColor = True
        '
        'txtProAMount
        '
        Me.txtProAMount.Location = New System.Drawing.Point(216, 189)
        Me.txtProAMount.Name = "txtProAMount"
        Me.txtProAMount.Size = New System.Drawing.Size(158, 20)
        Me.txtProAMount.TabIndex = 1
        '
        'frmPractice4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 439)
        Me.Controls.Add(Me.txtProAMount)
        Me.Controls.Add(Me.radProCredit)
        Me.Controls.Add(Me.radProCash)
        Me.Controls.Add(Me.lblProNet)
        Me.Controls.Add(Me.lblProTotal)
        Me.Controls.Add(Me.lblProPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice4"
        Me.Text = "frmPractice4"
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
    Friend WithEvents lblProId As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents lblProPrice As System.Windows.Forms.Label
    Friend WithEvents lblProTotal As System.Windows.Forms.Label
    Friend WithEvents lblProNet As System.Windows.Forms.Label
    Friend WithEvents radProCash As System.Windows.Forms.RadioButton
    Friend WithEvents radProCredit As System.Windows.Forms.RadioButton
    Friend WithEvents txtProAMount As System.Windows.Forms.TextBox
End Class
