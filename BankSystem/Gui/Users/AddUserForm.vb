
Imports BankSystem_Business

Public Class AddUserForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox1.SelectedIndex = 0
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Dim _DT As DataTable = New DataTable()

    Private Sub _RefereshDGV()


        _DT.Rows.Clear()
        clsPerson.GetAllPeople(_DT)

        If (_DT.Rows.Count > 0) Then

            DataGridView1.DataSource = _DT

            DataGridView1.Columns(0).HeaderText = "رقم الشخص"
            DataGridView1.Columns(1).HeaderText = "الاسم الاول"
            DataGridView1.Columns(2).HeaderText = "الاسم الاخير"
            DataGridView1.Columns(3).HeaderText = "البريد الالكتروني"
            DataGridView1.Columns(4).HeaderText = "رقم الهاتف"




        End If


    End Sub

    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _RefereshDGV()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim ColumnName As String = ""

        Select Case (ComboBox1.SelectedItem)
            Case "رقم الشخص" : ColumnName = "_ID"
            Case "الاسم الاول" : ColumnName = "Fname"
            Case "الاسم الاخير" : ColumnName = "Lname"
            Case "البريد الالكتروني" : ColumnName = "Email"
            Case "رقم الهاتف" : ColumnName = "Phone"
        End Select

        If (TextBox1.Text = "") Then
            _DT.DefaultView.RowFilter = ""
            Return

        End If

        If (ComboBox1.SelectedIndex = 0) Then

            If Not (IsNumeric(TextBox1.Text)) Then
                TextBox1.Text = ""
                Return

            End If

            _DT.DefaultView.RowFilter = "_ID = '" & TextBox1.Text & "'"
        Else

            Dim FilterString As String = ColumnName & " LIKE '" & TextBox1.Text.Trim() & "%'"
            _DT.DefaultView.RowFilter = FilterString

        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
        txtPersonID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Function GetTotalPemissions() As Byte
        ''transfer 4 TabControl1.TabPages(1).Controls(0).Tag.ToString()
        ''clients 1 TabControl1.TabPages(1).Controls(3).Tag.ToString()
        ''log     8 TabControl1.TabPages(1).Controls(1).Tag.ToString()
        ''TabControl1.TabPages(1).Controls(2).Tag.ToString()

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim PersonID As Integer = -1

        If (txtPersonID.Text = "") Then
            MessageBox.Show("يرجى كتابة رقم الشخص !")
            Return
        End If

        If (Integer.TryParse(txtPersonID.Text, PersonID)) Then

            Dim Username As String = txtUsername.Text
            Dim Password As String = txtPassword.Text
            Dim Permissions As Byte = GetTotalPemissions()

            If (txtUsername.Text <> "" And txtPassword.Text <> "" And PermissionChecked()) Then

                If (clsPerson.IsExists(PersonID)) Then

                    If (clsUser.Add(PersonID, Username, Password, Permissions)) Then
                        MessageBox.Show("تمت الاضافة بنجاح !")
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("الشخص غير موجود ")
                    Return
                End If
            Else
                MessageBox.Show("يرجى تعبئة كل الفراغات !")
                Return
            End If
        Else
            MessageBox.Show("يرجاء التأكد من تعبئة البيانات")

        End If

        MessageBox.Show(TabControl1.TabPages(1).Controls(2).Tag.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim addNewPerson As AddNewPerson = New AddNewPerson()
        addNewPerson.ShowDialog()

        _RefereshDGV()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
        ' TextBox1_TextChanged(sender, e)
    End Sub


    Private Sub txtPersonID_TextChanged(sender As Object, e As EventArgs) Handles txtPersonID.TextChanged

        If Not (IsNumeric(txtPersonID.Text)) Then
            txtPersonID.Text = ""
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        '  DataGridView1_cellMouse
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class