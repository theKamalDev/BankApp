Imports BankSystem_Business
Imports Bunifu.UI.WinForms

Public Class UsersControl

    Private Sub _Referesh()

        Dim dgv As BunifuDataGridView = New BunifuDataGridView()


        If (Panel1.Controls.Count > 0) Then
            Panel1.Controls.RemoveAt(0)
        End If

        Panel1.Controls.Add(dgv)

        dgv.AutoSize = True
        dgv.Dock = DockStyle.Fill

        Dim DT As DataTable = clsUser.GetAllUsersd()

        If (DT.Rows.Count > 0) Then

                DT = DT.DefaultView.ToTable(False, "_ID", "Username", "Password", "Permissions")

                dgv.DataSource = DT
                dgv.Columns(0).HeaderText = "رقم الشخص"
                dgv.Columns(1).HeaderText = "اسم المستخدم"
                dgv.Columns(2).HeaderText = "كلمة المرور"
                dgv.ReadOnly = True


                dgv.Columns(3).HeaderText = "الصلاحيات"




        Else
            CheckConnection.ShowDialog()
        End If

    End Sub
    Private Sub UsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Referesh()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim addform As AddUserForm = New AddUserForm()
        addform.ShowDialog()

        _Referesh()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim edituserform As EditUserForm = New EditUserForm()
        edituserform.ShowDialog()

        _Referesh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim deleteuserform As DeleteUserForm = New DeleteUserForm()
        deleteuserform.ShowDialog()

        _Referesh()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
