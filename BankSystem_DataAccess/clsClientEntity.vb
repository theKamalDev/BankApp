Imports System.Data
Imports System.Data.SqlClient
Imports System.Security
Imports System.Security.Cryptography
Imports System.Xml

Public Class clsClientEntity

    Public Shared Function GetAll(DT As DataTable) As Boolean
        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("SELECT Clients._ID , Clients.AccountNumber, People.Fname, People.Lname, People.Gender,
                                                       Clients.PinCode, Clients.Balance, Clients.AddedDate 
                                                       FROM             Clients INNER JOIN
                                                       People ON Clients.PersonID = People._ID", sqlcon)

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

    Public Shared Function WithDraw(ID As Integer, wBalance As Double) As Boolean

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("Update Clients
                                                       Set 
                                                       Balance = @Balance
                                                        Where _ID = @ID", sqlcon)

            sqlcom.Parameters.AddWithValue("@ID", ID)
            sqlcom.Parameters.AddWithValue("@Balance", wBalance)

            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function

    Public Shared Function Deposit(ID As Integer, dBalance As Double) As Boolean

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("Update Clients
                                                       Set 
                                                       Balance = @Balance
                                                        Where _ID = @ID", sqlcon)

            sqlcom.Parameters.AddWithValue("@ID", ID)
            sqlcom.Parameters.AddWithValue("@Balance", dBalance)

            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected
    End Function


    Public Shared Function Find(ID As Integer, ByRef PersonID As Integer, ByRef AccountNumber As String, ByRef PinCode As String, ByRef Balance As Double) As Boolean

        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Clients Where Clients._ID = @ID ;", sqlcon)

            sqlcon.Open()

            sqlcom.Parameters.AddWithValue("@ID", ID)
            Dim SqlData As SqlDataReader = sqlcom.ExecuteReader()

            If (SqlData.Read()) Then

                AccountNumber = DirectCast(SqlData("AccountNumber"), String)
                PinCode = DirectCast(SqlData("PinCode"), String)
                Balance = DirectCast(SqlData("Balance"), Double)
                PersonID = DirectCast(SqlData("PersonID"), Integer)

                Check = True

            End If



        Catch ex As Exception

            Check = False

        End Try

        Return Check

        Return False
    End Function

    Public Shared Function IsExists(ID As Integer) As Boolean


        Dim Check As Boolean = False

        Try
            Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

            Dim sqlcom As SqlCommand = New SqlCommand("Select * From Clients Where Clients._ID = @ID ;", sqlcon)

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


    Public Shared Function Add(PersonID As Integer, AccountNumber As String, PinCode As String, Balance As Double) As Integer

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)
        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("INSERT INTO Clients (PersonID,AccountNumber,PinCode , Balance)
                                                       Values
                                                       (@PersonID , @AccountNumber , @PinCode ,@Balance) ", sqlcon)

            sqlcom.Parameters.AddWithValue("@PersonID", PersonID)
            sqlcom.Parameters.AddWithValue("@AccountNumber", AccountNumber)
            sqlcom.Parameters.AddWithValue("@PinCode", PinCode)
            sqlcom.Parameters.AddWithValue("@Balance", Balance)


            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function

    Public Shared Function Delete(_ID As Integer) As Integer


        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("Delete From Clients
                                                       Where _ID = @ID", sqlcon)

            sqlcom.Parameters.AddWithValue("@ID", _ID)

            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function

    Public Shared Function Eidt(_ID As Integer, AccountNumber As String, PinCode As String, Balance As Double) As Integer

        Dim sqlcon As SqlConnection = New SqlConnection(ConnectionSettings.ConnectionString)

        Dim RowAffected As Integer = 0

        Try
            sqlcon.Open()

            Dim sqlcom As SqlCommand = New SqlCommand("Update Clients
                                                       Set 
                                                       AccountNumber = @AccountNumber,
                                                       PinCode = @PinCode,
                                                       Balance = @Balance
                                                        Where _ID = @ID", sqlcon)

            sqlcom.Parameters.AddWithValue("@ID", _ID)
            sqlcom.Parameters.AddWithValue("@Balance", Balance)
            sqlcom.Parameters.AddWithValue("@PinCode", PinCode)
            sqlcom.Parameters.AddWithValue("@AccountNumber", AccountNumber)

            Dim ob As Object = sqlcom.ExecuteNonQuery()

            RowAffected = Integer.Parse(ob)

        Catch ex As Exception


        Finally
            sqlcon.Close()


        End Try

        Return RowAffected

    End Function



End Class
