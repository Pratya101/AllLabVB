<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice1
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
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblMyName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชือ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "สกุล"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(127, 103)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(127, 61)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShow.Location = New System.Drawing.Point(127, 151)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(84, 28)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "เเสดงชือ"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Cornsilk
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(52, 235)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(206, 29)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMyName
        '
        Me.lblMyName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMyName.Location = New System.Drawing.Point(127, 185)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(84, 28)
        Me.lblMyName.TabIndex = 2
        Me.lblMyName.Text = "เปลี่ยน"
        Me.lblMyName.UseVisualStyleBackColor = True
        '
        'frmPractice1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 305)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แบบฝึกปฏิบบัติสัปดาห์ที่1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblMyName As System.Windows.Forms.Button

End Class
