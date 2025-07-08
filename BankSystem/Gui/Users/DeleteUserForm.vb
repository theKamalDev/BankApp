Imports BankSystem_Business

Public Class DeleteUserForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "") Then
            MessageBox.Show("يرجي ادخال رقم  !")

            If (Panel2.Controls.Count > 0) Then
                Panel2.Controls.RemoveAt(0)

            End If
            Return
        End If

        If (clsUser.IsExists(Integer.Parse(TextBox1.Text))) Then
            Dim usercardcontrol As UserCardControl = New UserCardControl(-1, Integer.Parse(TextBox1.Text))
            usercardcontrol.Dock = DockStyle.Fill

            If (Panel2.Controls.Count > 0) Then
                Panel2.Controls.RemoveAt(0)

            End If

            Panel2.Controls.Add(usercardcontrol)
        Else
            MessageBox.Show("المستخدم غير موجود !")


            If (Panel2.Controls.Count > 0) Then
                Panel2.Controls.RemoveAt(0)

            End If
        End If

    End Sub

    Private Sub DeleteUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub
End Class