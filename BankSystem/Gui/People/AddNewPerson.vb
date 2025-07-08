Imports BankSystem_Business

Public Class AddNewPerson

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '


        'Revesion 
        ''Dim FilterString As String = ColumnName & " LIKE '" & TextBox1.Text.Trim() & "%'"
        'MessageBox.Show(txtEmail.Text & " LIKE '%@%.com%'")

        'If Not (txtEmail.Text = txtEmail.Text & " LIKE '%@%.com%'") Then
        '    MessageBox.Show("البريد الالكتروني غير صحيح ")
        '    Return
        'End If

        If Not (txtFname.Text = "" Or txtLname.Text = "" Or EmailPass.ForeColor = Color.Red Or PhonePass.ForeColor = Color.Red Or ComboBox1.SelectedItem = "") Then

            If (clsPerson.Add(txtFname.Text, txtLname.Text, txtEmail.Text, txtPhone.Text, ComboBox1.SelectedItem)) Then
                MessageBox.Show("تمت اضافة شخص جديد بنجاح")

                Me.Close()
            End If

        Else
            MessageBox.Show("خطأ في أدخال البيانات")
            Return

        End If


    End Sub

    Private Sub AddNewPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

        If Not (IsNumeric(txtPhone.Text)) Then
            txtPhone.Text = ""

        End If
        'If (Not txtPhone.Text.Length < 10 And Not txtPhone.Text.Length > 10) Then
        '    PhonePass.Visible = True
        '    PhonePass.Text = "رقم الهاتف صالح للاستخدام"
        '    PhonePass.ForeColor = Color.Green
        'Else
        '    PhonePass.Visible = True
        '    PhonePass.Text = "رقم الهاتف غير صالح للاستخدام"
        '    PhonePass.ForeColor = Color.Red
        'End If
    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If (IsNumeric(txtFname.Text)) Then
            txtFname.Text = ""
        End If
    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If (IsNumeric(txtLname.Text)) Then
            txtLname.Text = ""
        End If


    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If (txtEmail.Text.Contains("@") And txtEmail.Text.EndsWith(".com")) Then
            EmailPass.Visible = True
            EmailPass.Text = "البريد الالكتروني صالح للاستخدام"
            EmailPass.ForeColor = Color.Green

        Else
            EmailPass.Visible = True
            EmailPass.Text = "البريد الالكتروني غير صالح للاستخدام"
            EmailPass.ForeColor = Color.Red
        End If
    End Sub


End Class