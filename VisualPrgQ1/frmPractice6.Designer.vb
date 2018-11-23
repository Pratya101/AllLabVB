<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice6
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
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtLabScore = New System.Windows.Forms.TextBox()
        Me.txtMidtrem = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.lblSunScore = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณผลการเรียน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อนักศึกษา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "คะเเนนกลางภาค (30)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "คะเเนนปลายภาค (30)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "คะเเนนเก็บ (40)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "คะเเนนรวม (100)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "เกรดที่ได้"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(307, 122)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(166, 20)
        Me.txtStudentName.TabIndex = 0
        '
        'txtLabScore
        '
        Me.txtLabScore.Location = New System.Drawing.Point(307, 166)
        Me.txtLabScore.Name = "txtLabScore"
        Me.txtLabScore.Size = New System.Drawing.Size(166, 20)
        Me.txtLabScore.TabIndex = 1
        '
        'txtMidtrem
        '
        Me.txtMidtrem.Location = New System.Drawing.Point(307, 210)
        Me.txtMidtrem.Name = "txtMidtrem"
        Me.txtMidtrem.Size = New System.Drawing.Size(166, 20)
        Me.txtMidtrem.TabIndex = 2
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(307, 255)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(166, 20)
        Me.txtFinal.TabIndex = 3
        '
        'lblSunScore
        '
        Me.lblSunScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSunScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSunScore.Location = New System.Drawing.Point(358, 344)
        Me.lblSunScore.Name = "lblSunScore"
        Me.lblSunScore.Size = New System.Drawing.Size(163, 24)
        Me.lblSunScore.TabIndex = 5
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(358, 408)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(163, 24)
        Me.lblGrade.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(59, 344)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 88)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "คำนวณเกรด"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmPractice6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 509)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtMidtrem)
        Me.Controls.Add(Me.txtLabScore)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblSunScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice6"
        Me.Text = "frmPractice6"
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
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtLabScore As System.Windows.Forms.TextBox
    Friend WithEvents txtMidtrem As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents lblSunScore As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
