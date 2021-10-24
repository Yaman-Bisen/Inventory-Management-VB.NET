Imports System.Data.OleDb
Public Class frm_search_customer
    Dim ob As New connection
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        If ComboBox1.Text = "(Select)" Then
            MessageBox.Show("Please select the option to search item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Customer Id" Then
            Label2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = False
            TextBox2.Visible = False
            Label7.Visible = True
            TextBox6.Visible = True
            Label8.Visible = False
            TextBox7.Visible = False
        ElseIf ComboBox1.Text = "By Customer Name" Then
            Label2.Visible = False
            TextBox1.Visible = False
            Label3.Visible = True
            TextBox2.Visible = True
            Label7.Visible = False
            TextBox6.Visible = False
            Label8.Visible = True
            TextBox7.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "(Select)" Then
            MessageBox.Show("Please select the option to search item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Customer Id" Then
            ob.mycommand = New OleDbCommand("Select * from customermaster where custid='" + TextBox1.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                MessageBox.Show("Customer is registered", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Text = ob.myreader("mobno")
                TextBox4.Text = ob.myreader("email")
                TextBox5.Text = ob.myreader("address")
                TextBox6.Text = ob.myreader("custname")
            Else
                MessageBox.Show("There is no customer registered with customer id " + TextBox1.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.Text = "By Customer Name" Then
            ob.mycommand = New OleDbCommand("Select * from customermaster where custname='" + TextBox2.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                MessageBox.Show("customer is registered", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Text = ob.myreader("mobno")
                TextBox4.Text = ob.myreader("email")
                TextBox5.Text = ob.myreader("address")
                TextBox7.Text = ob.myreader("custid")
            Else
                MessageBox.Show("There is no item with item name " + TextBox2.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class