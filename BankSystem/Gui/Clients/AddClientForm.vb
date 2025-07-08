
Imports BankSystem_Business

Public Class AddClientForm

    Dim _DT As DataTable = New DataTable()

    Private Sub _RefereshDGV()


        _DT.Rows.Clear()
        'DataGridView1.Rows.Clear()
        clsPerson.GetAllPeople(_DT)
        DataGridView1.DataSource = _DT

        DataGridView1.Columns(0).HeaderText = "رقم الشخص"
        DataGridView1.Columns(1).HeaderText = "الاسم الاول"
        DataGridView1.Columns(2).HeaderText = "الاسم الاخير"
        DataGridView1.Columns(3).HeaderText = "البريد الالكتروني"
        DataGridView1.Columns(4).HeaderText = "رقم الهاتف"



        ComboBox1.SelectedIndex = 0

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

            If (IsNumeric(TextBox1.Text)) Then
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim PersonID As Integer = -1
        Dim Balance As Double = New Double()

        If (Integer.TryParse(txtPersonID.Text, PersonID)) Then

            If (txtAccountNumber.Text = "" And txtPinCode.Text = "") Then

                If (Double.TryParse(TabControl1.TabPages(1).Controls(0).Text, Balance) And TabControl1.TabPages(1).Controls(2).Text <> "" And TabControl1.TabPages(1).Controls(1).Text <> "") Then

                    Dim AccountNumber As String = TabControl1.TabPages(1).Controls(2).Text
                    Dim PinCode As String = TabControl1.TabPages(1).Controls(1).Text

                    If (clsPerson.IsExists(PersonID)) Then

                        If (clsClient.Add(PersonID, AccountNumber, PinCode, Balance)) Then
                            MessageBox.Show("تمت الاضافة بنجاح !")
                            Me.Close()
                        End If

                    Else

                        MessageBox.Show("الشخص غير موجود ")
                        Return

                    End If

                Else
                    MessageBox.Show("يرجى ادخال قيمة")
                End If





            Else

                    MessageBox.Show("! يرجي ادخال رقم صحيح")
                Return
            End If
        Else
            MessageBox.Show("يرجى ادخال رقم شخص !")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim addNewPerson As AddNewPerson = New AddNewPerson()
        addNewPerson.ShowDialog()

        _RefereshDGV()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

        If Not (IsNumeric(txtBalance)) Then
            txtBalance.Text = ""
        End If

    End Sub

    Private Sub AddClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _RefereshDGV()
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub txtBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalance.KeyPress

        'If (Char.IsNumber(e.KeyChar) = False And Not e.KeyChar = Chr(Keys.Back)) Then
        '    e.KeyChar = Nothing
        'End If

        CheckIsMinusNumber(e)

    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged

    End Sub
End Class