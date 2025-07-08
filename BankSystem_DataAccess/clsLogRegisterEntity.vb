Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class clsLogRegisterEntity



    Public Shared Function GetAll() As DataTable

        Dim DT As DataTable = New DataTable()

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("SELECT        LogRegister._ID, Users.Username, Users.Permissions, LogRegister.DateTime 
                                                       FROM            LogRegister INNER JOIN
                                                       Users ON LogRegister.UserID = Users._ID", sqlcon)

            sqlcon.Open()

            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.HasRows) Then
                DT.Load(SqlData)
            End If



        Catch ex As Exception


        End Try

        Return DT

    End Function



    Public Shared Function Find(ID As Integer, ByRef UserID As Integer, ByRef DateTime As DateTime) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From LogRegister Where LogRegister._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)
            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.HasRows) Then

                UserID = DirectCast(SqlData("UserID"), Integer)
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

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From LogRegister Where LogRegister._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)
            'Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()
            Dim ob As Object = sqlcom.ExecuteNonQuery()

            If (Integer.Parse(ob) > 0) Then

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check
    End Function


    Public Shared Function Edit() As Boolean

    End Function

    Public Shared Function Delete(_ID As Integer) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Delete From LogRegister Where LogRegister._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", _ID)
            'Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()
            Dim ob As Object = sqlcom.ExecuteNonQuery()

            If (Integer.Parse(ob) > 0) Then

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check
    End Function

    Public Shared Function Add(UserID As Integer) As Boolean


        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Insert into LogRegister (UserID)
                                                       Values
                                                       (@UserID) ;", sqlcon)
            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@UserID", UserID)
            Dim ob As Object = sqlcom.ExecuteNonQuery()

            If (Integer.Parse(ob) > 0) Then

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check

    End Function

End Class
