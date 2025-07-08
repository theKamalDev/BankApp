Imports BankSystem_Business
Imports BankSystem_DataAccess

Public Class MainForm

    Private _main As Main
    Private _LastAdd As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _main = New Main(Me)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TestConnectingWithDB()

        If Not (ConnectionSettings.FoundDB()) Then

            ConnectionSettings.SetDefaultPassword()

            CheckConnection.ShowDialog()
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TestConnectingWithDB()
        btnClients.Select()
        lblUsername.Text = GlobalUesr.CurrentUser._Username
        If (CheckAccessRights(clsUser.enPermission.eClients)) Then
            Dim clients As ClientsControl = New ClientsControl()
            _main.LoadPage(clients)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If (BackUpAndRestoreDB.BackUpDataBase("BankSystem", "C:\BankSystem.bak")) Then
            MessageBox.Show("تم اخذ نسخة احتياطية بنجاح !")
        End If
    End Sub

    Private Function CheckAccessRights(Permissions As clsUser.enPermission) As Boolean

        If (GlobalUesr.CurrentUser.CheckAccessPermissions(Permissions)) Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        GlobalUesr.CurrentUser = Nothing
        Dim loginform As LoginForm = New LoginForm()
        loginform.Show()
        Me.Close()
    End Sub
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click


        If (CheckAccessRights(clsUser.enPermission.eUsers)) Then
            Dim users As UsersControl = New UsersControl()
            _main.LoadPage(users)

        Else

            MessageBox.Show("ليس لديك الصلاحية للوصول !")
        End If

    End Sub

    Private Sub btnLogRegisters_Click(sender As Object, e As EventArgs) Handles btnLogRegisters.Click

        If (CheckAccessRights(clsUser.enPermission.eLogRegister)) Then
            Dim logRegisters As LogRegistersControl = New LogRegistersControl()
            _main.LoadPage(logRegisters)

        Else

            MessageBox.Show("ليس لديك الصلاحية للوصول !")
        End If

    End Sub
    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click

        If (CheckAccessRights(clsUser.enPermission.eClients)) Then
            Dim clients As ClientsControl = New ClientsControl()
            _main.LoadPage(clients)

        Else

            MessageBox.Show("ليس لديك الصلاحية للوصول !")
        End If

    End Sub
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        If (CheckAccessRights(clsUser.enPermission.eTransfer)) Then
            Dim transfers As TransfersControl = New TransfersControl()
            _main.LoadPage(transfers)

        Else

            MessageBox.Show("ليس لديك الصلاحية للوصول !")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub
End Class
