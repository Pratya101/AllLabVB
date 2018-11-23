<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAction2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radHide = New System.Windows.Forms.RadioButton()
        Me.radDisplay = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radUnEnabled = New System.Windows.Forms.RadioButton()
        Me.radEnabled = New System.Windows.Forms.RadioButton()
        Me.grpOperator = New System.Windows.Forms.GroupBox()
        Me.radSocial = New System.Windows.Forms.RadioButton()
        Me.radAllMoney = New System.Windows.Forms.RadioButton()
        Me.radBonus = New System.Windows.Forms.RadioButton()
        Me.radTotal = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.bntRestart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpOperator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radHide)
        Me.GroupBox1.Controls.Add(Me.radDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การเเสดงผล"
        '
        'radHide
        '
        Me.radHide.AutoSize = True
        Me.radHide.Location = New System.Drawing.Point(13, 50)
        Me.radHide.Name = "radHide"
        Me.radHide.Size = New System.Drawing.Size(46, 17)
        Me.radHide.TabIndex = 1
        Me.radHide.TabStop = True
        Me.radHide.Text = "ซ่อน"
        Me.radHide.UseVisualStyleBackColor = True
        '
        'radDisplay
        '
        Me.radDisplay.AutoSize = True
        Me.radDisplay.Checked = True
        Me.radDisplay.Location = New System.Drawing.Point(13, 19)
        Me.radDisplay.Name = "radDisplay"
        Me.radDisplay.Size = New System.Drawing.Size(53, 17)
        Me.radDisplay.TabIndex = 0
        Me.radDisplay.TabStop = True
        Me.radDisplay.Text = "เเสดง"
        Me.radDisplay.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUnEnabled)
        Me.GroupBox2.Controls.Add(Me.radEnabled)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 84)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การใช้งาน"
        '
        'radUnEnabled
        '
        Me.radUnEnabled.AutoSize = True
        Me.radUnEnabled.Location = New System.Drawing.Point(21, 57)
        Me.radUnEnabled.Name = "radUnEnabled"
        Me.radUnEnabled.Size = New System.Drawing.Size(69, 17)
        Me.radUnEnabled.TabIndex = 1
        Me.radUnEnabled.TabStop = True
        Me.radUnEnabled.Text = "ไม่ใช้งาน"
        Me.radUnEnabled.UseVisualStyleBackColor = True
        '
        'radEnabled
        '
        Me.radEnabled.AutoSize = True
        Me.radEnabled.Checked = True
        Me.radEnabled.Location = New System.Drawing.Point(21, 28)
        Me.radEnabled.Name = "radEnabled"
        Me.radEnabled.Size = New System.Drawing.Size(69, 17)
        Me.radEnabled.TabIndex = 0
        Me.radEnabled.TabStop = True
        Me.radEnabled.Text = "ใช้งานได้"
        Me.radEnabled.UseVisualStyleBackColor = True
        '
        'grpOperator
        '
        Me.grpOperator.Controls.Add(Me.radSocial)
        Me.grpOperator.Controls.Add(Me.radAllMoney)
        Me.grpOperator.Controls.Add(Me.radBonus)
        Me.grpOperator.Controls.Add(Me.radTotal)
        Me.grpOperator.Location = New System.Drawing.Point(449, 146)
        Me.grpOperator.Name = "grpOperator"
        Me.grpOperator.Size = New System.Drawing.Size(246, 94)
        Me.grpOperator.TabIndex = 2
        Me.grpOperator.TabStop = False
        Me.grpOperator.Text = "การคำนวณ"
        '
        'radSocial
        '
        Me.radSocial.AutoSize = True
        Me.radSocial.Location = New System.Drawing.Point(133, 62)
        Me.radSocial.Name = "radSocial"
        Me.radSocial.Size = New System.Drawing.Size(83, 17)
        Me.radSocial.TabIndex = 3
        Me.radSocial.TabStop = True
        Me.radSocial.Text = "ประกันสังคม"
        Me.radSocial.UseVisualStyleBackColor = True
        '
        'radAllMoney
        '
        Me.radAllMoney.AutoSize = True
        Me.radAllMoney.Location = New System.Drawing.Point(15, 62)
        Me.radAllMoney.Name = "radAllMoney"
        Me.radAllMoney.Size = New System.Drawing.Size(87, 17)
        Me.radAllMoney.TabIndex = 2
        Me.radAllMoney.TabStop = True
        Me.radAllMoney.Text = "ค่าใช้จ่ายรวม"
        Me.radAllMoney.UseVisualStyleBackColor = True
        '
        'radBonus
        '
        Me.radBonus.AutoSize = True
        Me.radBonus.Location = New System.Drawing.Point(133, 26)
        Me.radBonus.Name = "radBonus"
        Me.radBonus.Size = New System.Drawing.Size(51, 17)
        Me.radBonus.TabIndex = 1
        Me.radBonus.TabStop = True
        Me.radBonus.Text = "โบนัส"
        Me.radBonus.UseVisualStyleBackColor = True
        '
        'radTotal
        '
        Me.radTotal.AutoSize = True
        Me.radTotal.Location = New System.Drawing.Point(15, 26)
        Me.radTotal.Name = "radTotal"
        Me.radTotal.Size = New System.Drawing.Size(72, 17)
        Me.radTotal.TabIndex = 0
        Me.radTotal.Text = "ค่าจ้างรวม"
        Me.radTotal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ค่าจ้าง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "จำนวนพนักงาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ผลลัพธ์"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.Cornsilk
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("AngsanaUPC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(449, 263)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(211, 45)
        Me.lblOutput.TabIndex = 3
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(454, 45)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(206, 20)
        Me.txtPay.TabIndex = 4
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(455, 101)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(205, 20)
        Me.txtEmployee.TabIndex = 5
        '
        'bntRestart
        '
        Me.bntRestart.Location = New System.Drawing.Point(26, 285)
        Me.bntRestart.Name = "bntRestart"
        Me.bntRestart.Size = New System.Drawing.Size(165, 45)
        Me.bntRestart.TabIndex = 6
        Me.bntRestart.Text = "Restart"
        Me.bntRestart.UseVisualStyleBackColor = True
        '
        'frmAction2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 370)
        Me.Controls.Add(Me.bntRestart)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpOperator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAction2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAction2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOperator.ResumeLayout(False)
        Me.grpOperator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radHide As System.Windows.Forms.RadioButton
    Friend WithEvents radDisplay As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radUnEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents radEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents grpOperator As System.Windows.Forms.GroupBox
    Friend WithEvents radSocial As System.Windows.Forms.RadioButton
    Friend WithEvents radAllMoney As System.Windows.Forms.RadioButton
    Friend WithEvents radBonus As System.Windows.Forms.RadioButton
    Friend WithEvents radTotal As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents bntRestart As System.Windows.Forms.Button
End Class
