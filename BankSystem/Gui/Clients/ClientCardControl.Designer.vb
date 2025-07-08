<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientCardControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtPinCode = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblMode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 45)
        Me.Panel1.TabIndex = 0
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(794, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMode.Size = New System.Drawing.Size(110, 28)
        Me.lblMode.TabIndex = 9
        Me.lblMode.Text = "حذف عميل "
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNumber.Location = New System.Drawing.Point(261, 174)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(212, 34)
        Me.txtAccountNumber.TabIndex = 1
        '
        'txtPinCode
        '
        Me.txtPinCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPinCode.Location = New System.Drawing.Point(609, 300)
        Me.txtPinCode.Name = "txtPinCode"
        Me.txtPinCode.Size = New System.Drawing.Size(203, 34)
        Me.txtPinCode.TabIndex = 2
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(270, 300)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(203, 34)
        Me.txtBalance.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(121, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "رقم الحساب :"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(701, 269)
        Me.label11.Name = "label11"
        Me.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label11.Size = New System.Drawing.Size(116, 28)
        Me.label11.TabIndex = 6
        Me.label11.Text = "كلمة المرور :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "الرصيد :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 34)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Button1"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(701, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(113, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "رقم العميل :"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(609, 174)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(203, 34)
        Me.txtID.TabIndex = 9
        '
        'ClientCardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtPinCode)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClientCardControl"
        Me.Size = New System.Drawing.Size(1044, 560)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtPinCode As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblMode As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
End Class
