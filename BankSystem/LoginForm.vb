Imports System.Web.UI.WebControls
Imports BankSystem_Business
Imports BankSystem_DataAccess

Public Class LoginForm
    Dim DT As DataTable = clsUser.GetAllUsersd()


    Private Sub TestConnectingWithDB()

        ConnectionSettings.SetDefaultPassword()

        If Not (ConnectionSettings.FoundDB()) Then
            CheckConnection.ShowDialog()
        End If

    End Sub


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TestConnectingWithDB()
        txtPassword.UseSystemPasswordChar = True
        ComboBox1.DataSource = DT
        ComboBox1.DisplayMember = "Username"

        btnSignIn.Select()
        Me.AcceptButton = btnSignIn

    End Sub
    Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
    Private Sub btnSignIn_Click_1(sender As Object, e As EventArgs) Handles btnSignIn.Click
        ' 
        If (clsUser.IsExists(ComboBox1.SelectedItem("Username"), txtPassword.Text)) Then

            GlobalUesr.CurrentUser = clsUser.FindByUsernameAndPassword(ComboBox1.SelectedItem("Username"), txtPassword.Text)
            clsLogRegister.Add(GlobalUesr.CurrentUser._ID)

            Dim mainForm As MainForm = New MainForm()
            mainForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("خطأ في كلمة السر ")

        End If

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class