Imports System.Data.SqlClient
Imports System.Security
Imports System.Security.Cryptography
Imports Newtonsoft.Json.Linq

Public Class clsUserEntity

    Public Shared Function GetAll() As DataTable

        Dim Check As DataTable = New DataTable()

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Users ;", sqlcon)

            sqlcon.Open()

            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.HasRows) Then
                Check.Load(SqlData)
            End If


        Catch ex As Exception


        End Try

        Return Check

    End Function



    Public Shared Function Find(ID As Integer, ByRef PersonID As Integer, ByRef Username As String, ByRef Password As String, ByRef Permissions As Byte) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Users Where Users._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)

            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.Read()) Then
                Username = DirectCast(SqlData("Username"), String)
                Password = DirectCast(SqlData("Password"), String)
                PersonID = DirectCast(SqlData("PersonID"), Integer)
                Permissions = DirectCast(SqlData("Permissions"), Byte)

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check
    End Function

    Public Shared Function FindByUsernameAndPassword(ByRef _ID As Integer, ByRef PersonID As Integer, Username As String, Password As String, ByRef Permissions As Byte) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Users Where Users.Username = @Username And Users.Password = @Password ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@Username", Username)
            sqlcom.Parameters.AddWithValue("@Password", Password)

            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.Read()) Then

                _ID = DirectCast(SqlData("_ID"), Integer)
                PersonID = DirectCast(SqlData("PersonID"), Integer)
                Permissions = DirectCast(SqlData("Permissions"), Byte)

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check
    End Function

    Public Shared Function IsExists(Username As String, Password As String) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Users Where Users.Username = @Username and Users.Password = @Password ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@Username", Username)
            sqlcom.Parameters.AddWithValue("@Password", Password)

            Dim ob As Object = sqlcom.ExecuteScalar()

            If (Integer.Parse(ob) > 0) Then

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

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Users Where Users._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)
            Dim ob As Object = sqlcom.ExecuteScalar()

            If (Integer.Parse(ob) > 0) Then

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check
    End Function


    Public Shared Function Edit(ID As Integer, Username As String, Password As String, Permissions As Byte) As Boolean

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("Update Users
                                                       Set 
                                                       Username = @Username,
                                                       Password = @Password,
                                                       Permissions = @Permissions
                                                        Where _ID = @ID", sqlcon)

            sqlcom.Parameters.AddWithValue("@ID", ID)
            sqlcom.Parameters.AddWithValue("@Username", Username)
            sqlcom.Parameters.AddWithValue("@Password", Password)
            sqlcom.Parameters.AddWithValue("@Permissions", Permissions)


            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function

    Public Shared Function Delete(ID As Integer) As Boolean

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("Delete From Users
                                                       Where _ID = @ID", sqlcon)

            sqlcom.Parameters.AddWithValue("@ID", ID)

            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function

    Public Shared Function Add(PersonID As Integer, Username As String, Password As String, Permissions As Byte) As Boolean

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)
        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("INSERT INTO Users (PersonID, Username, Password, Permissions)
                                                       Values
                                                       (@PersonID,@Username,@Password,@Permissions) ", sqlcon)

            sqlcom.Parameters.AddWithValue("@PersonID", PersonID)
            sqlcom.Parameters.AddWithValue("@Username", Username)
            sqlcom.Parameters.AddWithValue("@Password", Password)
            sqlcom.Parameters.AddWithValue("@Permissions", Permissions)


            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function

End Class
