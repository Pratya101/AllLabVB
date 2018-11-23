<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAction7
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
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddData = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.cboTarget = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "โปรแกรมควบคุม ListBox-ComboBox"
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(98, 47)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(164, 199)
        Me.lstPrice.TabIndex = 31
        '
        'lblTarget
        '
        Me.lblTarget.BackColor = System.Drawing.Color.White
        Me.lblTarget.Location = New System.Drawing.Point(374, 316)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(100, 23)
        Me.lblTarget.TabIndex = 30
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "ปิดหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddData
        '
        Me.txtAddData.Location = New System.Drawing.Point(117, 319)
        Me.txtAddData.Name = "txtAddData"
        Me.txtAddData.Size = New System.Drawing.Size(98, 20)
        Me.txtAddData.TabIndex = 28
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(387, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddData
        '
        Me.btnAddData.Enabled = False
        Me.btnAddData.Location = New System.Drawing.Point(129, 279)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(75, 23)
        Me.btnAddData.TabIndex = 26
        Me.btnAddData.Text = "เพิ่ม"
        Me.btnAddData.UseVisualStyleBackColor = False
        '
        'btnBackAll
        '
        Me.btnBackAll.Location = New System.Drawing.Point(291, 182)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(51, 27)
        Me.btnBackAll.TabIndex = 23
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(291, 149)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 27)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnMoveAll
        '
        Me.btnMoveAll.Location = New System.Drawing.Point(291, 116)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(51, 27)
        Me.btnMoveAll.TabIndex = 25
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(291, 83)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(51, 27)
        Me.btnMove.TabIndex = 24
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'cboTarget
        '
        Me.cboTarget.FormattingEnabled = True
        Me.cboTarget.Location = New System.Drawing.Point(365, 47)
        Me.cboTarget.Name = "cboTarget"
        Me.cboTarget.Size = New System.Drawing.Size(121, 21)
        Me.cboTarget.TabIndex = 21
        '
        'frmAction7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 389)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtAddData)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.cboTarget)
        Me.Name = "frmAction7"
        Me.Text = "frmAction7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtAddData As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddData As System.Windows.Forms.Button
    Friend WithEvents btnBackAll As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents cboTarget As System.Windows.Forms.ComboBox
End Class
