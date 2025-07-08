Imports System.Diagnostics.Eventing.Reader
Imports BankSystem_Business

Public Class UserCardControl



    Dim _Mode As Integer = New Integer()
    Dim _ID As Integer = New Integer()


    Public Sub New(Mode As Integer, ID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me._Mode = Mode
        Me._ID = ID

    End Sub

    Private Sub UserCardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtID.Enabled = False


        If (_Mode = -1) Then
            txtPassword.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = False
            CheckBox3.Enabled = False
            txtUsername.Enabled = False
            btnSave.Text = "حذف"
            lblMode.Text = "حذف مستخدم"
        Else

            btnSave.Text = "تعديل"
            lblMode.Text = "تعديل بيانات المستخدم"


        End If

        Dim clsuser As clsUser = clsUser.Find(_ID)

        txtID.Text = _ID
        txtPassword.Text = clsuser._Password
        txtUsername.Text = clsuser._Username

        If (CheckBox1.Tag And clsuser._Permissions) = CheckBox1.Tag Then
            CheckBox1.Checked = True
        End If

        If (CheckBox2.Tag And clsuser._Permissions) = CheckBox2.Tag Then
            CheckBox2.Checked = True
        End If

        If (CheckBox3.Tag And clsuser._Permissions) = CheckBox3.Tag Then
            CheckBox3.Checked = True
        End If

        If (CheckBox4.Tag And clsuser._Permissions) = CheckBox4.Tag Then
            CheckBox4.Checked = True
        End If

    End Sub

    Private Function GetTotalPemissions() As Byte

        Dim TotalPermissions As Byte = 0

        If (CheckBox1.Checked) Then
            TotalPermissions += CheckBox1.Tag
        End If

        If (CheckBox2.Checked) Then
            TotalPermissions += CheckBox2.Tag
        End If

        If (CheckBox3.Checked) Then
            TotalPermissions += CheckBox3.Tag
        End If

        If (CheckBox4.Checked) Then
            TotalPermissions += CheckBox4.Tag
        End If

        Return TotalPermissions

    End Function

    Public Function PermissionChecked() As Boolean

        If (CheckBox1.Checked) Then
            Return True
        ElseIf (CheckBox2.Checked) Then
            Return True
        ElseIf (CheckBox3.Checked) Then
            Return True
        ElseIf (CheckBox4.Checked) Then
            Return True
        Else
            Return False
        End If


    End Function



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If (_Mode = -1) Then

            Dim result As DialogResult

            result = MessageBox.Show("هل انت متأكد تريد الحذف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)

            If result = DialogResult.Yes Then

                If (clsUser.Delete(Integer.Parse(txtID.Text))) Then

                    MessageBox.Show("تم الحذف بنجاح !")

                End If

            ElseIf result = DialogResult.No Then

                Return
            End If

        Else



            Dim result As DialogResult

            result = MessageBox.Show("هل انت متأكد تريد التعديل؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)

            If result = DialogResult.Yes And txtPassword.Text <> "" And txtUsername.Text <> "" And PermissionChecked() Then

                If (clsUser.Edit(Integer.Parse(txtID.Text), txtUsername.Text, txtPassword.Text, GetTotalPemissions())) Then
                    MessageBox.Show("تم التعديل بنجاح !")
                    GlobalUesr.CurrentUser = clsUser.FindByUsernameAndPassword(txtUsername.Text, txtPassword.Text)
                End If
            Else
                MessageBox.Show("يرجى تعبئة كل الفراغات !")
            End If

            If result = DialogResult.No Then
                Return


            End If
        End If



        Me.ParentForm.Close()

    End Sub

End Class
