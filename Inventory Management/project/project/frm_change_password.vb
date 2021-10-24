Imports System.Data.OleDb
Public Class frm_change_password
    Dim ob As New connection()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ob.mycommand = New OleDbCommand("Select * from login where username = '" + TextBox1.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If Not ob.myreader.Read() Then
            MessageBox.Show("User not found ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("select * from login where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If Not ob.myreader.Read() Then
                MessageBox.Show("Please enter the old password correctly", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If TextBox3.Text = TextBox4.Text Then
                    ob.mycommand = New OleDbCommand("update login SET [password] = '" + TextBox3.Text + "' where [username] = '" + TextBox1.Text + "'", ob.myconnection)
                    Dim a As Integer
                    a = ob.mycommand.ExecuteNonQuery()
                    If a > 0 Then
                        MessageBox.Show("Password changed successful ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Error occured", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Entered password and re-entered password does not matched", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_login.Show()
        Me.Hide()
    End Sub
End Class