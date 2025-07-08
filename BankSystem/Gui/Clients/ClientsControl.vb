Imports System.Web.Util
Imports BankSystem_Business
Imports Bunifu.UI.WinForms

Public Class ClientsControl

    Dim dgv As BunifuDataGridView = New BunifuDataGridView()
    Private Sub _Referesh()


        Dim DT As DataTable = New DataTable()

        If (Panel1.Controls.Count > 0) Then
            Panel1.Controls.RemoveAt(0)
        End If

        Panel1.Controls.Add(dgv)

        dgv.AutoSize = True
        dgv.Dock = DockStyle.Fill


        If (clsClient.GetAllClients(DT)) Then

            If (DT.Rows.Count > 0) Then

                dgv.DataSource = DT

                dgv.Columns(0).HeaderText = "رقم العميل"
                dgv.Columns(1).HeaderText = "رقم الحساب"
                dgv.Columns(2).HeaderText = "الاسم الاول"
                dgv.Columns(3).HeaderText = "الاسم الاخير"
                dgv.Columns(4).HeaderText = "الجنس"
                dgv.Columns(5).HeaderText = "الرقم السري"
                dgv.Columns(6).HeaderText = "الرصيد"
                dgv.Columns(7).HeaderText = "تاريخ الاضافة"

                dgv.ReadOnly = True

                dgv.ContextMenuStrip = Me.ContextMenuStrip1
            End If

        Else

        End If


    End Sub



    Private Sub ClientsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Referesh()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim addform As AddClientForm = New AddClientForm()
        addform.ShowDialog()

        _Referesh()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim deleteClientform As DeleteClientForm = New DeleteClientForm
        deleteClientform.ShowDialog()

        _Referesh()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim editclientform As EditClientForm = New EditClientForm()
        editclientform.ShowDialog()

        _Referesh()

    End Sub


    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub


    Private Sub Deposit_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        Dim ID As Integer = Integer.Parse(dgv.CurrentRow.Cells(0).Value)

        Dim transaction As TransactionForm = New TransactionForm(1, ID)
        transaction.ShowDialog()

        _Referesh()

        ' Dim s As Integer = dgv
    End Sub

    Private Sub WithDraw_Click(sender As Object, e As EventArgs) Handles WithDraw.Click

        Dim ID As Integer = Integer.Parse(dgv.CurrentRow.Cells(0).Value)
        Dim transaction As TransactionForm = New TransactionForm(-1, ID)
        transaction.ShowDialog()

        _Referesh()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
