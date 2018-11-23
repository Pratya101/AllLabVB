<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice7
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lstValue = New System.Windows.Forms.ListBox()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(31, 51)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(162, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(225, 51)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Add"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Location = New System.Drawing.Point(305, 113)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 2
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(305, 150)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(100, 21)
        Me.lblMin.TabIndex = 2
        '
        'lstValue
        '
        Me.lstValue.FormattingEnabled = True
        Me.lstValue.Location = New System.Drawing.Point(31, 113)
        Me.lstValue.Name = "lstValue"
        Me.lstValue.Size = New System.Drawing.Size(140, 134)
        Me.lstValue.TabIndex = 3
        '
        'lblMax
        '
        Me.lblMax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMax.Location = New System.Drawing.Point(305, 183)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(100, 21)
        Me.lblMax.TabIndex = 2
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAvg.Location = New System.Drawing.Point(305, 216)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(100, 21)
        Me.lblAvg.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Max"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Average"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Min"
        '
        'frmPractice7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 468)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstValue)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmPractice7"
        Me.Text = "frmPractice7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lstValue As System.Windows.Forms.ListBox
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblAvg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
