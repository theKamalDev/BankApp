Imports BankSystem_Business

Public Class ClientCardControl


    Dim _Mode As Integer = New Integer()
    Dim _ID As Integer = New Integer()


    Public Sub New(Mode As Integer, ID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me._Mode = Mode
        Me._ID = ID

    End Sub

    Private Sub ClientCardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtID.Enabled = False
        If (_Mode = -1) Then
            txtAccountNumber.Enabled = False
            txtBalance.Enabled = False
            txtPinCode.Enabled = False
            btnSave.Text = "حذف"
            lblMode.Text = "حذف عميل"
        Else

            btnSave.Text = "تعديل"
            lblMode.Text = "تعديل بيانات العميل"

        End If

        Dim clsclient As clsClient = clsClient.Find(_ID)

        txtID.Text = _ID
        txtAccountNumber.Text = clsclient.AccountNumber
        txtPinCode.Text = clsclient.PinCode
        txtBalance.Text = clsclient.Balance

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If (_Mode = -1) Then

            Dim result As DialogResult

            result = MessageBox.Show("هل انت متأكد تريد الحذف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)

            If result = DialogResult.Yes Then
                If (clsClient.Delete(Integer.Parse(txtID.Text))) Then
                    MessageBox.Show("تم الحذف بنجاح !")
                End If


            ElseIf result = DialogResult.No Then
                Return
            End If

        Else



            Dim result As DialogResult

            result = MessageBox.Show("هل انت متأكد تريد التعديل؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)

            If result = DialogResult.Yes And txtAccountNumber.Text <> "" And txtPinCode.Text <> "" And txtBalance.Text <> "" Then
                If (clsClient.Edit(Integer.Parse(txtID.Text), txtAccountNumber.Text, txtPinCode.Text, txtBalance.Text)) Then
                    MessageBox.Show("تم التعديل بنجاح !")

                End If

            Else
                MessageBox.Show("يوجد خطأ نظرا لعدم تعبئة كل الفراغات !")
            End If

            If result = DialogResult.No Then
                Return
            End If

        End If



        Me.ParentForm.Close()

    End Sub

    Private Sub txtBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalance.KeyPress

        CheckIsMinusNumber(e)

    End Sub
End Class
