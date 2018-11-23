<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice10
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUpDate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณค่าเฉลี่ยอาเรย์"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(69, 104)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(120, 173)
        Me.lstData.TabIndex = 1
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(69, 307)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(120, 21)
        Me.cboIndex.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(299, 308)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 3
        '
        'btnUpDate
        '
        Me.btnUpDate.Location = New System.Drawing.Point(445, 305)
        Me.btnUpDate.Name = "btnUpDate"
        Me.btnUpDate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpDate.TabIndex = 4
        Me.btnUpDate.Text = "Update"
        Me.btnUpDate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ค่าเฉลี่ย"
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvg.Location = New System.Drawing.Point(241, 145)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(247, 132)
        Me.lblAvg.TabIndex = 6
        '
        'frmPractice10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 380)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpDate)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice10"
        Me.Text = "frmPractice10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnUpDate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAvg As System.Windows.Forms.Label
End Class
