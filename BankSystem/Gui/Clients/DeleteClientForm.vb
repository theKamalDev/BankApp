Imports BankSystem_Business

Public Class DeleteClientForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("يرجى ادخال رقم عميل !")
            If (Panel2.Controls.Count > 0) Then
                Panel2.Controls.RemoveAt(0)

            End If
            Return
        End If



        If (clsClient.IsExists(Integer.Parse(TextBox1.Text))) Then
            Dim clientCardControl As ClientCardControl = New ClientCardControl(-1, Integer.Parse(TextBox1.Text))
            clientCardControl.Dock = DockStyle.Fill

            If (Panel2.Controls.Count > 0) Then
                Panel2.Controls.RemoveAt(0)

            End If

            Panel2.Controls.Add(clientCardControl)
        Else
            MessageBox.Show("الشخص غير موجود !")

            If (Panel2.Controls.Count > 0) Then
                Panel2.Controls.RemoveAt(0)

            End If

        End If

    End Sub

    Private Sub DeleteClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub
End Class