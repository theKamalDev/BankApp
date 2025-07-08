Imports System.Data
Imports System.Data.SqlClient
Imports System.Security
Public Class clsPersonEntity



    Public Shared Function GetAll(DT As DataTable) As Boolean

        Dim Check As Boolean = False
        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)
        Try


            Dim sqlcom As SqlCommand = New SqlCommand("Select _ID , Fname , Lname , Email , Phone From People ;", sqlcon)

            sqlcon.Open()

            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.HasRows) Then
                DT.Load(SqlData)
            End If

            Check = True

        Catch ex As Exception

            Check = False

        End Try


        Return Check

    End Function



    Public Shared Function Find(ID As Integer, ByRef Fname As String, ByRef Lname As String,
                                ByRef Email As String, ByRef Phone As String, ByRef Gender As Char, ByRef DateTime As DateTime) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From People Where People._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)
            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.HasRows) Then

                Fname = DirectCast(SqlData("Fname"), String)
                Lname = DirectCast(SqlData("Lname"), String)
                Email = DirectCast(SqlData("Email"), String)
                Phone = DirectCast(SqlData("Phone"), String)
                Gender = DirectCast(SqlData("Gender"), Char)
                DateTime = DirectCast(SqlData("DateTime"), DateTime)

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check

    End Function


    Public Shared Function IsExists(ID As Integer) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From People Where People._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)
            'Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()
            Dim ob As Object = sqlcom.ExecuteScalar()

            If (Integer.Parse(ob) > 0) Then

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check
    End Function

    Public Shared Function Add(Fname As String, Lname As String, Email As String, Phone As String, Gender As Char) As Boolean
        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)
        Dim Check As Boolean = False

        Using sqlcom As SqlCommand = New SqlCommand("INSERT INTO People(Fname,Lname,Email,Phone,Gender)
                                                     Values
                                                     (@Fname , @Lname , @Email ,@Phone , @Gender ) ;", sqlcon)
            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@Fname", Fname)
            sqlcom.Parameters.AddWithValue("@Lname", Lname)
            sqlcom.Parameters.AddWithValue("@Email", Email)
            sqlcom.Parameters.AddWithValue("@Phone", Phone)
            sqlcom.Parameters.AddWithValue("@Gender", Gender)


            Dim ob As Object = sqlcom.ExecuteNonQuery()

            Check = Integer.Parse(ob) > 0

        End Using

        Return Check
    End Function


End Class
