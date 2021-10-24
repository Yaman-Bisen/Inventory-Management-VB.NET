Imports System.Data.OleDb
Public Class frm_update_customer
    Dim ob As New connection
    Public count As Integer = 0
    Public count1 As Integer = 0
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "(Select Customer By)" Then
            MessageBox.Show("Please select the customer", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Customer Id" Then
            ComboBox2.Visible = True
            ComboBox3.Visible = False
        ElseIf ComboBox1.Text = "By Customer Name" Then
            ComboBox3.Visible = True
            ComboBox2.Visible = False
        End If
        If count < 1 Then
            If ComboBox1.Text = "By Customer Id" Then
                count = count + 1
                ob.mycommand = New OleDbCommand("select * from customermaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox2.Items.Add(ob.myreader("custid"))
                End While
            End If
        End If
        If count1 < 1 Then
            If ComboBox1.Text = "By Customer Name" Then
                count1 = count1 + 1
                ob.mycommand = New OleDbCommand("select * from customermaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox3.Items.Add(ob.myreader("custname"))
                End While
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "By Customer Id" Then
            Label6.Text = ComboBox2.Text
        ElseIf ComboBox1.Text = "By Customer Name" Then
            Label6.Text = TextBox1.Text
        End If
           
        ob.mycommand = New OleDbCommand("Update customermaster set custname = '" + TextBox2.Text + "',mobno= '" + TextBox3.Text + "',email= '" + TextBox4.Text + "',address='" + TextBox5.Text + "',dates='" + DateTimePicker1.Value.Date + "'  where custid = '" + Label6.Text + "'", ob.myconnection)
        Dim a As New Integer
        a = ob.mycommand.ExecuteNonQuery()
        If a > 0 Then
            MessageBox.Show("Customer details updated successfully", "successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from customermaster where custid = '" + ComboBox2.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox9.Text = ob.myreader("custid")
            TextBox1.Text = ob.myreader("custid")
            TextBox10.Text = ob.myreader("custname")
            TextBox8.Text = ob.myreader("mobno")
            TextBox7.Text = ob.myreader("email")
            TextBox6.Text = ob.myreader("address")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from customermaster where custname = '" + ComboBox3.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox9.Text = ob.myreader("custid")
            TextBox1.Text = ob.myreader("custid")
            TextBox10.Text = ob.myreader("custname")
            TextBox8.Text = ob.myreader("mobno")
            TextBox7.Text = ob.myreader("email")
            TextBox6.Text = ob.myreader("address")
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        TextBox2.Text = TextBox10.Text
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        TextBox3.Text = TextBox8.Text
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        TextBox4.Text = TextBox7.Text
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        TextBox5.Text = TextBox6.Text
    End Sub
End Class