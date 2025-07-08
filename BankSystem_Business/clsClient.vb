Imports BankSystem_DataAccess
Public Class clsClient

    Public PersonID As Integer
    Public AccountNumber As String
    Public PinCode As String
    Public Balance As Double

    Public Sub New(AccountNumber As String, PersonID As Integer, PinCode As String, Balance As Double)
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.PersonID = PersonID
        Me.PinCode = PinCode
    End Sub

    Public Sub New()
        Me.AccountNumber = ""
        Me.Balance = 0
        Me.PersonID = -1
        Me.PinCode = ""
    End Sub


    Public Shared Function GetAllClients(DT As DataTable) As Boolean
        Return clsClientEntity.GetAll(DT)
    End Function


    Public Shared Function Find(ID As Integer) As clsClient
        Dim AccountNumber As String = ""
        Dim PersonID As Integer = 0
        Dim PinCode As String = ""
        Dim Balance As Double = 0.0

        If (clsClientEntity.Find(ID, PersonID, AccountNumber, PinCode, Balance)) Then

            Return New clsClient(AccountNumber, PersonID, PinCode, Balance)

        Else
            Return Nothing

        End If

    End Function

    Public Shared Function IsExists(ID As Integer) As Boolean
        Return clsClientEntity.IsExists(ID)
    End Function


    Public Shared Function Edit(ID As Integer, AccountNumber As String, PinCode As String, Balance As Double) As Boolean
        Return clsClientEntity.Eidt(ID, AccountNumber, PinCode, Balance)

    End Function

    Public Shared Function Add(PersonID As Integer, AccountNumber As String, PinCode As String, Balance As Double) As Boolean
        Return clsClientEntity.Add(PersonID, AccountNumber, PinCode, Balance) > 0

    End Function

    Public Shared Function Delete(ID As Integer) As Boolean
        Return clsClientEntity.Delete(ID)

    End Function

    Public Function Deposit(IDe As Integer, dBalance As Double) As Boolean
        If (dBalance > 0) Then

            Dim NewBalance As Double = Me.Balance + dBalance

            Return clsClientEntity.Deposit(IDe, NewBalance)
        Else
            Return False
        End If
    End Function

    Public Function WithDraw(IDe As Integer, wBalance As Double) As Boolean

        If (Me.Balance >= wBalance) Then

            Dim NewBalance As Double = Me.Balance - wBalance

            Return clsClientEntity.WithDraw(IDe, NewBalance)
        Else
            Return False
        End If
    End Function

End Class
