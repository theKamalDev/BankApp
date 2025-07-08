Imports BankSystem_DataAccess
Imports BankSystem
Imports System.Runtime.CompilerServices

Public Class CheckConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectRestore.Click

        OpenFileDialog1.Filter = ".bak |*.bak"
        OpenFileDialog1.Title = "اختر ملف النسخة الاحتياطية (.bak)"

        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            txtDB_PathRestore.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDB_NameRestore.Text = "BankSystem"
        txtDB_NameRestore.Enabled = False
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)

    '    If (txtDB_PathBackup.Text <> "" And txtDB_NameBackup.Text <> "") Then
    '        If (BackUpAndRestoreDB.BackUpDataBase(txtDB_NameBackup.Text, txtDB_PathBackup.Text)) Then
    '            MessageBox.Show("تم النسخ الاحتياطي بنجاح !")
    '        End If
    '    End If
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSaveRestore.Click

        If (txtDB_NameRestore.Text <> "" And txtDB_PathRestore.Text <> "") Then
            If (BackUpAndRestoreDB.RestoreDataBase(txtDB_NameRestore.Text, txtDB_PathRestore.Text)) Then
                MessageBox.Show("تمت استعادة البيانات بنجاح ! قم بأعادة فتح البرنامج ")
                Application.Exit()
                Me.Close()
            Else
                MessageBox.Show("يوجد خطأ !")
            End If


        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        MainForm.Show()

        Me.Close()

    End Sub

    Private Sub txtDB_NameRestore_TextChanged(sender As Object, e As EventArgs) Handles txtDB_NameRestore.TextChanged

    End Sub



    'Private Sub Button4_Click(sender As Object, e As EventArgs)



    '    If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
    '        txtDB_PathBackup.Text = SaveFileDialog1.FileName



    '    End If
    'End Sub



End Class
