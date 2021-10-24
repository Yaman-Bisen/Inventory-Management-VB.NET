Imports System.Data.OleDb
Public Class frm_login
    Public ob As New connection()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please enter information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("Select * from login where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                ProgressBar1.Visible = True
                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = 700
                Timer1.Enabled = True
                Timer2.Enabled = True
                Me.Cursor = Cursors.WaitCursor
            Else
                MessageBox.Show("Invalid user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_signup.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frm_change_password.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 700 Then
            ProgressBar1.Value = ProgressBar1.Value + 20
        Else
            ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        ProgressBar1.Visible = False
        Label3.Text = Now
        Timer3.Enabled = True
        Dim a As String = Now.Hour.ToString
        Dim b As String = Now.Minute.ToString
        Dim c As String = Now.Second.ToString
        Label4.Text = a + ":" + b + ":" + c
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        MDI_Marketing.Show()
        Me.Hide()
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim a As String = Now.Hour.ToString
        Dim b As String = Now.Minute.ToString
        Dim c As String = Now.Second.ToString
        c += 1
        Label4.Text = a + ":" + b + ":" + c
    End Sub
End Class
