<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnLogRegisters = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnTransfer)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnClients)
        Me.Panel2.Controls.Add(Me.btnLogRegisters)
        Me.Panel2.Controls.Add(Me.btnUsers)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 1004)
        Me.Panel2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.BankSystem.My.Resources.Resources.icons8_exit_64__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.Location = New System.Drawing.Point(0, 770)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 76)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "الخروج"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 846)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 82)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "نسخ احتياطي"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Image = Global.BankSystem.My.Resources.Resources.icons8_transactions_96
        Me.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransfer.Location = New System.Drawing.Point(9, 331)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(214, 112)
        Me.btnTransfer.TabIndex = 13
        Me.btnTransfer.Text = "التحويلات"
        Me.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(95, 111)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUsername.Size = New System.Drawing.Size(124, 32)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "___________"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BankSystem.My.Resources.Resources.icons8_male_user_100
        Me.PictureBox1.Location = New System.Drawing.Point(76, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 96)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnClients
        '
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClients.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.Image = Global.BankSystem.My.Resources.Resources.icons8_group_96__3_1
        Me.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClients.Location = New System.Drawing.Point(9, 213)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(214, 112)
        Me.btnClients.TabIndex = 9
        Me.btnClients.Text = "العملاء"
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClients.UseVisualStyleBackColor = True
        '
        'btnLogRegisters
        '
        Me.btnLogRegisters.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogRegisters.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogRegisters.Image = Global.BankSystem.My.Resources.Resources.icons8_log_961
        Me.btnLogRegisters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogRegisters.Location = New System.Drawing.Point(9, 449)
        Me.btnLogRegisters.Name = "btnLogRegisters"
        Me.btnLogRegisters.Size = New System.Drawing.Size(214, 112)
        Me.btnLogRegisters.TabIndex = 8
        Me.btnLogRegisters.Text = "السجلات"
        Me.btnLogRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogRegisters.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Image = Global.BankSystem.My.Resources.Resources.icons8_group_96__2_1
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(9, 567)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(214, 109)
        Me.btnUsers.TabIndex = 5
        Me.btnUsers.Text = "المستخدمين"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.BankSystem.My.Resources.Resources.icons8_exit_64__1_
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnClose.Location = New System.Drawing.Point(0, 928)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(232, 76)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "تسجيل الخروج"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(232, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1501, 1004)
        Me.Panel3.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1733, 1004)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogRegisters As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnClients As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Button2 As Button
End Class
