Imports System.Data.SqlClient

Public Class ConnectionSettings

    Public Shared ConnectionString As String = "Data Source = . ; Initial Catalog = BankSystem ; Integrated Security= true ;"

    Public Shared ConnectionMasterString As String = "Server=.;Database=master;User Id=sa;Password=1234566; Trusted_Connection = true"

    Public Shared DB_Name As String = "BankSystem"

    Public Shared Function SetDefaultPassword() As Boolean

        Dim sqlcon As New SqlConnection(ConnectionSettings.ConnectionMasterString)
        Dim Check As Boolean = False

        Try

            sqlcon.Open()

            Dim sqlCom As New SqlCommand("ALTER LOGIN [sa] WITH PASSWORD = '1234566';", sqlcon)

            sqlCom.ExecuteNonQuery()

            Check = True


        Catch ex As Exception


            Check = False

        End Try

        Return Check
    End Function

    Public Shared Function FoundDB() As Boolean

        Dim sqlcon As New SqlConnection(ConnectionSettings.ConnectionMasterString)
        Dim Check As Boolean = False

        Try

            sqlcon.Open()

            Dim sqlCom As New SqlCommand("Use BankSystem;", sqlcon)

            sqlCom.ExecuteNonQuery()

            Check = True


        Catch ex As Exception


            Check = False

        End Try

        Return Check

    End Function


End Class
