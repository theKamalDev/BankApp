Imports System.Runtime.CompilerServices

Public Class Main

    Private mainform As MainForm

    Public Sub New(mainform As MainForm)
        Me.mainform = mainform
    End Sub

    Public Sub LoadPage(uc As UserControl)

        If (mainform.Panel3.Controls.Count > 0) Then
            mainform.Panel3.Controls.RemoveAt(0)
        End If

        uc.Dock = DockStyle.Fill
        mainform.Panel3.Controls.Add(uc)


    End Sub



End Class
