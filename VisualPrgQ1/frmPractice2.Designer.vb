<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice2
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
        Me.txtBaht = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radUs = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radKorea = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radUnLock = New System.Windows.Forms.RadioButton()
        Me.radLock = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBaht
        '
        Me.txtBaht.Location = New System.Drawing.Point(168, 56)
        Me.txtBaht.Name = "txtBaht"
        Me.txtBaht.Size = New System.Drawing.Size(293, 20)
        Me.txtBaht.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เงินไทย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เเลกได้"
        '
        'radUs
        '
        Me.radUs.AutoSize = True
        Me.radUs.Location = New System.Drawing.Point(203, 94)
        Me.radUs.Name = "radUs"
        Me.radUs.Size = New System.Drawing.Size(58, 17)
        Me.radUs.TabIndex = 2
        Me.radUs.TabStop = True
        Me.radUs.Text = "US(39)"
        Me.radUs.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(203, 155)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(76, 17)
        Me.radFrench.TabIndex = 3
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "Frence(37)"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radKorea
        '
        Me.radKorea.AutoSize = True
        Me.radKorea.Location = New System.Drawing.Point(203, 225)
        Me.radKorea.Name = "radKorea"
        Me.radKorea.Size = New System.Drawing.Size(71, 17)
        Me.radKorea.TabIndex = 4
        Me.radKorea.TabStop = True
        Me.radKorea.Text = "Korea(30)"
        Me.radKorea.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(165, 297)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(296, 136)
        Me.lblResult.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUnLock)
        Me.GroupBox1.Controls.Add(Me.radLock)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 101)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ควบคุม"
        '
        'radUnLock
        '
        Me.radUnLock.AutoSize = True
        Me.radUnLock.Location = New System.Drawing.Point(21, 71)
        Me.radUnLock.Name = "radUnLock"
        Me.radUnLock.Size = New System.Drawing.Size(63, 17)
        Me.radUnLock.TabIndex = 1
        Me.radUnLock.TabStop = True
        Me.radUnLock.Text = "UnLock"
        Me.radUnLock.UseVisualStyleBackColor = True
        '
        'radLock
        '
        Me.radLock.AutoSize = True
        Me.radLock.Location = New System.Drawing.Point(21, 31)
        Me.radLock.Name = "radLock"
        Me.radLock.Size = New System.Drawing.Size(49, 17)
        Me.radLock.TabIndex = 0
        Me.radLock.TabStop = True
        Me.radLock.Text = "Lock"
        Me.radLock.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(500, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 72)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPractice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 496)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.radKorea)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radUs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBaht)
        Me.Name = "frmPractice2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แบบฝึกปฏิบัติสัปดาห์ที่2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBaht As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radUs As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radKorea As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radUnLock As System.Windows.Forms.RadioButton
    Friend WithEvents radLock As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
