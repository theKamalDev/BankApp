Imports System.Diagnostics.Eventing.Reader
Imports BankSystem_DataAccess
Public Class clsPerson

    Private ID As Integer
    Private Fname As String
    Private Lname As String
    Private Email As String
    Private Phone As String
    Private Gender As Char
    Private DateOfBirth As DateTime

    Public Sub New(Fname As String, Lname As String, Email As String, Phone As String, Gender As Char, DateOfBirth As DateTime)
        Me.Fname = Fname
        Me.Lname = Lname
        Me.Email = Email
        Me.Phone = Phone
        Me.Gender = Gender
        Me.DateOfBirth = DateOfBirth
    End Sub


    Public Shared Function GetAllPeople(DT As DataTable) As Boolean
        Return clsPersonEntity.GetAll(DT)
    End Function


    Public Shared Function Find(ID As Integer) As clsPerson

        Dim Fname As String = ""
        Dim Lname As String = ""
        Dim Email As String = ""
        Dim Phone As String = ""
        Dim Gender As Char = ""

        Dim DateOfBirth As DateTime = DateTime.Now

        If (clsPersonEntity.Find(ID, Fname, Lname, Email, Phone, Gender, DateOfBirth)) Then

            Return New clsPerson(Fname, Lname, Email, Phone, Gender, DateOfBirth)

        Else
            Return Nothing

        End If



    End Function


    Public Shared Function IsExists(ID As Integer) As Boolean
        Return clsPersonEntity.IsExists(ID)
    End Function

    Public Shared Function Add(Fname As String, Lname As String, Email As String, Phone As String, Gender As Char) As Boolean
        Return clsPersonEntity.Add(Fname, Lname, Email, Phone, Gender)
    End Function


End Class



