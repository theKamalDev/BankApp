Imports System.ComponentModel.Design
Imports System.Data.SqlClient


Public Class BackUpAndRestoreDB

    Shared sqlcon As New SqlConnection(ConnectionSettings.ConnectionMasterString)

    Public Shared Function RestoreDataBase(DB_Name As String, DB_Path As String) As Boolean

        Dim Check As Boolean = False

        Try

            sqlcon.Open()
            Dim sqlCom As New SqlCommand("Restore DataBase @DB_Name From Disk = @DB_Path; ", sqlcon)

            sqlCom.Parameters.AddWithValue("@DB_Name", DB_Name)
            sqlCom.Parameters.AddWithValue("@DB_Path", DB_Path)

            sqlCom.ExecuteNonQuery()

            Check = True


        Catch ex As Exception


            Check = False

        End Try

        Return Check

    End Function


    Public Shared Function BackUpDataBase(DB_Name As String, DB_Path As String) As Boolean


        Dim Check As Boolean = False

        Try

            sqlcon.Open()
            Dim sqlCom As New SqlCommand("Backup DataBase @DB_Name To Disk = @DB_Path; ", sqlcon)

            sqlCom.Parameters.AddWithValue("@DB_Name", DB_Name)
            sqlCom.Parameters.AddWithValue("@DB_Path", DB_Path)

            sqlCom.ExecuteNonQuery()

            Check = True


        Catch ex As Exception


            Check = False

        End Try

        Return Check

    End Function

End Class
