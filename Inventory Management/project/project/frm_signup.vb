Imports System.Data.OleDb
Public Class frm_signup
    Dim ob As New connection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please enter the informatioin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("Select * from login where username = '" + TextBox1.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                MessageBox.Show("User already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If TextBox2.Text = TextBox3.Text Then
                    ob.mycommand = New OleDbCommand("insert into login values('" + TextBox1.Text + "','" + TextBox2.Text + "')", ob.myconnection)
                    'insert into login vallues('yaman','bisen')
                    Dim a As Integer
                    a = ob.mycommand.ExecuteNonQuery()
                    If a > 0 Then
                        MessageBox.Show("Signed up successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Error occured", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("password and re-entered password does not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        End If
    End Sub

   
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_login.Show()
        Me.Hide()
    End Sub

   
End Class