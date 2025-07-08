Imports System.Security
Imports BankSystem_DataAccess
Public Class clsUser


    Public _ID As Integer
    Public _Username As String
    Public _Password As String
    Public _Permissions As Byte

    Public Sub New(ID As Integer, Username As String, Password As String, Permissions As Byte)
        Me._ID = ID
        Me._Username = Username
        Me._Password = Password
        Me._Permissions = Permissions

    End Sub


    Public Sub New()
        Me._ID = -1
        Me._Username = ""
        Me._Password = ""
        Me._Permissions = 0
    End Sub


    Public Shared Function Find(ID As Integer) As clsUser
        Dim PersonID As Integer = 0
        Dim Username As String = ""
        Dim Password As String = " "
        Dim Permissions As Byte = 0

        If (clsUserEntity.Find(ID, PersonID, Username, Password, Permissions)) Then
            Return New clsUser(ID, Username, Password, Permissions)

        Else
            Return Nothing

        End If


    End Function

    Public Shared Function FindByUsernameAndPassword(Username As String, Password As String) As clsUser
        Dim _ID As Integer = -1
        Dim PersonID As Integer = 0
        Dim Permissions As Byte = 0

        If (clsUserEntity.FindByUsernameAndPassword(_ID, PersonID, Username, Password, Permissions)) Then
            Return New clsUser(_ID, Username, Password, Permissions)

        Else
            Return Nothing

        End If


    End Function

    <Flags>
    Public Enum enPermission As Integer
        eClients = 1
        eUsers = 2
        eTransfer = 4
        eLogRegister = 8
    End Enum


    Public Function CheckAccessPermissions(Permission As enPermission) As Boolean
        'If (Permission = enPermission.eAll) Then
        '    Return True
        'End If

        If ((Permission And Me._Permissions) = Permission) Then
            Return True

        Else
            Return False
        End If
    End Function


    Public Shared Function GetAllUsersd() As DataTable
        Return clsUserEntity.GetAll()
    End Function

    Public Shared Function IsExists(ID As Integer) As Boolean
        Return clsUserEntity.IsExists(ID)
    End Function

    Public Shared Function IsExists(Username As String, Password As String) As Boolean
        Return clsUserEntity.IsExists(Username, Password)
    End Function

    Public Shared Function Edit(ID As Integer, Username As String, Password As String, Permissions As Byte) As Boolean
        Return clsUserEntity.Edit(ID, Username, Password, Permissions)

    End Function

    Public Shared Function Add(PersonID As Integer, Username As String, Password As String, Permissions As Byte) As Boolean
        Return clsUserEntity.Add(PersonID, Username, Password, Permissions)
    End Function

    Public Shared Function Delete(ID As Integer) As Boolean
        Return clsUserEntity.Delete(ID)

    End Function

End Class
