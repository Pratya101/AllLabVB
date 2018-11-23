<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign1
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
        Me.txtMyName = New System.Windows.Forms.TextBox()
        Me.txtMyWeigth = New System.Windows.Forms.TextBox()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblShowWeigth = New System.Windows.Forms.Label()
        Me.lblShowHigth = New System.Windows.Forms.Label()
        Me.btnCalHigth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณความเหมาะสมของร่างกาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชือ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "น้ำหนัก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "สวัสดีคุณ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "น้ำหนัก"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ความสูงที่สัมพัทธ์กัน"
        '
        'txtMyName
        '
        Me.txtMyName.Location = New System.Drawing.Point(190, 58)
        Me.txtMyName.Name = "txtMyName"
        Me.txtMyName.Size = New System.Drawing.Size(165, 20)
        Me.txtMyName.TabIndex = 1
        '
        'txtMyWeigth
        '
        Me.txtMyWeigth.Location = New System.Drawing.Point(190, 98)
        Me.txtMyWeigth.Name = "txtMyWeigth"
        Me.txtMyWeigth.Size = New System.Drawing.Size(165, 20)
        Me.txtMyWeigth.TabIndex = 2
        '
        'lblShowName
        '
        Me.lblShowName.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowName.Location = New System.Drawing.Point(187, 163)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(168, 23)
        Me.lblShowName.TabIndex = 0
        '
        'lblShowWeigth
        '
        Me.lblShowWeigth.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblShowWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowWeigth.Location = New System.Drawing.Point(187, 206)
        Me.lblShowWeigth.Name = "lblShowWeigth"
        Me.lblShowWeigth.Size = New System.Drawing.Size(168, 23)
        Me.lblShowWeigth.TabIndex = 0
        '
        'lblShowHigth
        '
        Me.lblShowHigth.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblShowHigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowHigth.Location = New System.Drawing.Point(187, 244)
        Me.lblShowHigth.Name = "lblShowHigth"
        Me.lblShowHigth.Size = New System.Drawing.Size(168, 23)
        Me.lblShowHigth.TabIndex = 0
        '
        'btnCalHigth
        '
        Me.btnCalHigth.Location = New System.Drawing.Point(206, 292)
        Me.btnCalHigth.Name = "btnCalHigth"
        Me.btnCalHigth.Size = New System.Drawing.Size(123, 42)
        Me.btnCalHigth.TabIndex = 3
        Me.btnCalHigth.Text = "คำนวณ"
        Me.btnCalHigth.UseVisualStyleBackColor = True
        '
        'frmAssign1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 370)
        Me.Controls.Add(Me.btnCalHigth)
        Me.Controls.Add(Me.txtMyWeigth)
        Me.Controls.Add(Me.txtMyName)
        Me.Controls.Add(Me.lblShowHigth)
        Me.Controls.Add(Me.lblShowWeigth)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAssign1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMyName As System.Windows.Forms.TextBox
    Friend WithEvents txtMyWeigth As System.Windows.Forms.TextBox
    Friend WithEvents lblShowName As System.Windows.Forms.Label
    Friend WithEvents lblShowWeigth As System.Windows.Forms.Label
    Friend WithEvents lblShowHigth As System.Windows.Forms.Label
    Friend WithEvents btnCalHigth As System.Windows.Forms.Button
End Class
