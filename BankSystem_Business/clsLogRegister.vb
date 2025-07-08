Imports BankSystem_DataAccess
Public Class clsLogRegister

    Private ID As Integer
    Private UserID As Integer
    Private DateOfBirth As DateTime

    Public Sub New(UserID As Integer, DateOfBirth As DateTime)
        Me.UserID = UserID
        Me.DateOfBirth = DateOfBirth
    End Sub


    Public Shared Function GetAllRegisters() As DataTable
        Return clsLogRegisterEntity.GetAll()
    End Function


    Public Shared Function Find(ID As Integer) As clsLogRegister

        Dim UserID As Integer = 0
        Dim DateOfBirth As DateTime = DateTime.Now

        If (clsLogRegisterEntity.Find(ID, UserID, DateOfBirth)) Then

            Return New clsLogRegister(UserID, DateOfBirth)

        Else
            Return Nothing

        End If



    End Function

    Public Shared Function Edit() As Boolean
        Return False

    End Function

    Public Shared Function Add(UserID As Integer) As Boolean

        Return clsLogRegisterEntity.Add(UserID)

    End Function

    Public Shared Function Delete(_ID As Integer) As Boolean
        Return clsLogRegisterEntity.Delete(_ID)

    End Function

End Class
