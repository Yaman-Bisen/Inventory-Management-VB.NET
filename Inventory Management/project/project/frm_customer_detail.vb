Imports System.Data.OleDb
Public Class frm_customer_detail
    Dim ob As New connection

    Private Sub frm_customer_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
        TextBox3.MaxLength = 10
        ob.mycommand = New OleDbCommand("select * from sample'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        While ob.myreader.Read()
            Label2.Text = ob.myreader("samplecustid")
        End While
        Dim a As String
        a = Val(Label2.Text) + 1
        Label8.Text = "C" + a
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please Enter all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("Select * from customermaster where custname='" + TextBox2.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                MessageBox.Show("Customer already rigistered with the cust id " + ob.myreader("custid"), "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ob.mycommand = New OleDbCommand("insert into customermaster values('" + Label8.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DateTimePicker1.Value.Date + "')", ob.myconnection)
                Dim a As Integer
                a = ob.mycommand.ExecuteNonQuery()
                If a > 0 Then
                    MessageBox.Show("Customer detail added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim b As Integer
                    b = Val(Label2.Text) + 1
                    ob.mycommand = New OleDbCommand("insert into sample values('" & b & "')", ob.myconnection)
                    ob.mycommand.ExecuteNonQuery()
                    ob.mycommand = New OleDbCommand("select * from sample'", ob.myconnection)
                    ob.myreader = ob.mycommand.ExecuteReader()
                    While ob.myreader.Read()
                        Label2.Text = ob.myreader("samplecustid")
                    End While
                    Dim k As String
                    k = Val(Label2.Text) + 1
                    Label8.Text = "C" + k
                End If
            End If 
        End If
    End Sub

End Class