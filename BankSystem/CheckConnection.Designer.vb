<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckConnection
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
        Me.btnSelectRestore = New System.Windows.Forms.Button()
        Me.txtDB_NameRestore = New System.Windows.Forms.TextBox()
        Me.txtDB_PathRestore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSaveRestore = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectRestore
        '
        Me.btnSelectRestore.Location = New System.Drawing.Point(359, 289)
        Me.btnSelectRestore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelectRestore.Name = "btnSelectRestore"
        Me.btnSelectRestore.Size = New System.Drawing.Size(73, 34)
        Me.btnSelectRestore.TabIndex = 0
        Me.btnSelectRestore.Text = "اختر"
        Me.btnSelectRestore.UseVisualStyleBackColor = True
        '
        'txtDB_NameRestore
        '
        Me.txtDB_NameRestore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDB_NameRestore.Location = New System.Drawing.Point(359, 193)
        Me.txtDB_NameRestore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDB_NameRestore.Name = "txtDB_NameRestore"
        Me.txtDB_NameRestore.Size = New System.Drawing.Size(391, 34)
        Me.txtDB_NameRestore.TabIndex = 1
        '
        'txtDB_PathRestore
        '
        Me.txtDB_PathRestore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDB_PathRestore.Location = New System.Drawing.Point(437, 289)
        Me.txtDB_PathRestore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDB_PathRestore.Name = "txtDB_PathRestore"
        Me.txtDB_PathRestore.Size = New System.Drawing.Size(312, 34)
        Me.txtDB_PathRestore.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(581, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "أسم قواعد البيانات :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSaveRestore
        '
        Me.btnSaveRestore.Location = New System.Drawing.Point(466, 358)
        Me.btnSaveRestore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveRestore.Name = "btnSaveRestore"
        Me.btnSaveRestore.Size = New System.Drawing.Size(185, 74)
        Me.btnSaveRestore.TabIndex = 10
        Me.btnSaveRestore.Text = "حفظ الاعدادت"
        Me.btnSaveRestore.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSaveRestore)
        Me.Panel1.Controls.Add(Me.btnSelectRestore)
        Me.Panel1.Controls.Add(Me.txtDB_NameRestore)
        Me.Panel1.Controls.Add(Me.txtDB_PathRestore)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1113, 604)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(629, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "مسار النسخة :"
        '
        'CheckConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1113, 604)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CheckConnection"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اعدادات الاتصال بقواعد البيانات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectRestore As Button
    Friend WithEvents txtDB_NameRestore As TextBox
    Friend WithEvents txtDB_PathRestore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSaveRestore As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
