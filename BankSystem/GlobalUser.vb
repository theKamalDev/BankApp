Imports BankSystem_Business
Imports System.Runtime.CompilerServices

Module GlobalUesr
    Public CurrentUser As clsUser = Nothing

    <Extension>
    Public Sub CheckIsMinusNumber(sender As Object, e As KeyPressEventArgs)

        If (Char.IsNumber(e.KeyChar) = False And Not e.KeyChar = Chr(Keys.Back)) Then
            e.KeyChar = Nothing
        End If

    End Sub


End Module
