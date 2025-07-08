Imports BankSystem_Business
Imports Bunifu.UI.WinForms

Public Class LogRegistersControl

    Dim DT As DataTable = clsLogRegister.GetAllRegisters()
    Private Sub LogRegistersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Panel1.Controls.Count > 0) Then
            Panel1.Controls.RemoveAt(0)
        End If

        Dim DGV As BunifuDataGridView = New BunifuDataGridView()


        If (DT.Rows.Count > 0) Then


            DGV.DataSource = DT




            DGV.AutoSize = True
            DGV.Dock = DockStyle.Fill
            DGV.ReadOnly = True
            Panel1.Controls.Add(DGV)

            DGV.Columns(0).HeaderText = "رقم السجل"
            DGV.Columns(1).HeaderText = "أسم المستخدم"
            DGV.Columns(2).HeaderText = "الصلاحيات"
            DGV.Columns(3).HeaderText = "تاريخ الدخول"
        End If


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
