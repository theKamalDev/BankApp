Imports BankSystem_Business
Imports System.Security.Cryptography

Public Class TransactionForm

    Private _Mode As Integer = 0
    Dim _ID As Integer = -1
    Dim clsclient As clsClient = New clsClient()

    Public Sub New(Mode As Integer, ID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me._Mode = Mode
        Me._ID = ID

    End Sub

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (_Mode = -1) Then
            btnSave.Text = "سحب"
            txtBalanceMode.Text = "القيمة المراد سحبها "
        ElseIf (_Mode = 1) Then
            btnSave.Text = "ايداع"
            txtBalanceMode.Text = "القيمة المراد ايداعها"
        End If

        TextBox1.Enabled = False
        txtAccountNumber.Enabled = False
        txtBalance.Enabled = False

        clsclient = clsClient.Find(_ID)
        txtAccountNumber.Text = clsclient.AccountNumber
        txtBalance.Text = clsclient.Balance
        TextBox1.Text = _ID

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If (_Mode = -1) Then
            If (clsclient.WithDraw(_ID, Double.Parse(TextBox2.Text))) Then
                MessageBox.Show("تم السحب بنجاح")
                Me.Close()
            Else
                MessageBox.Show("الرصيد الموجود غير كافي ")
            End If
        End If

        If (_Mode = 1 AndAlso clsclient.Deposit(_ID, Double.Parse(TextBox2.Text))) Then
            MessageBox.Show("تم الايداع بنجاح")
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        If Not (IsNumeric(TextBox2.Text)) Then
            TextBox2.Text = ""
            Return
        Else
            If (Integer.Parse(TextBox2.Text) < 0) Then
                TextBox2.Text = ""
            End If
        End If


    End Sub

End Class