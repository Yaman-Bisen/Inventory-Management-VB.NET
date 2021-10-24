Imports System.Data.OleDb
Public Class frm_delete_customer
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

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from customermaster where custname = '" + ComboBox3.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox9.Text = ob.myreader("custid")
            TextBox10.Text = ob.myreader("custname")
            TextBox8.Text = ob.myreader("mobno")
            TextBox7.Text = ob.myreader("email")
            TextBox6.Text = ob.myreader("address")
        End If
    End Sub

    
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from customermaster where custid = '" + ComboBox2.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox9.Text = ob.myreader("custid")
            TextBox10.Text = ob.myreader("custname")
            TextBox8.Text = ob.myreader("mobno")
            TextBox7.Text = ob.myreader("email")
            TextBox6.Text = ob.myreader("address")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "By Customer Id" Then
            TextBox1.Text = ComboBox2.Text()
        ElseIf ComboBox1.Text = "By Customer Name" Then
            TextBox1.Text = TextBox9.Text
        End If
        Dim res As DialogResult = MessageBox.Show("Are you sure do delete the customer details", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            ob.mycommand = New OleDbCommand("Delete * from customermaster where custid = '" + TextBox1.Text + "'", ob.myconnection)
            Dim a As Integer
            a = ob.mycommand.ExecuteNonQuery()
            If a > 0 Then
                MessageBox.Show("Customer record deleted successfully", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox9.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox10.Text = ""
            End If
        Else
            MessageBox.Show("You cancelled the operation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class