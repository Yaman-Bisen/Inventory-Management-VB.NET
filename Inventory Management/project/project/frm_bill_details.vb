Imports System.Data.OleDb
Public Class frm_bill_details
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
        If ComboBox1.Text = "(Select Customer By)" Then
            MessageBox.Show("Please select the customer", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Customer Id" Then
            ob.mycommand = New OleDbCommand("Select billno,custid,dates,amount from selling where custid='" + ComboBox2.Text + "' and dates='" + DateTimePicker1.Value.Date + "'", ob.myconnection)

            ob.dataA = New OleDbDataAdapter(ob.mycommand)
            ob.dataA.Fill(ob.dbset, "selling")
            DataGridView1.ReadOnly = True
            DataGridView1.DataSource = ob.dbset
            DataGridView1.DataMember = "selling"
            ob.mycommand = New OleDbCommand("select * from bill where custid='" + ComboBox2.Text + "' and dates='" + DateTimePicker1.Value.Date + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                Label3.Text = ob.myreader("amount")
                DataGridView1.Visible = True
                Panel1.Visible = True
            Else
                MessageBox.Show("There is no transaction available for selected customer at this date", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf ComboBox1.Text = "By Customer Name" Then
            ob.mycommand = New OleDbCommand("Select * from selling where custname='" + ComboBox3.Text + "' and dates='" + DateTimePicker1.Value.Date + "'", ob.myconnection)

            ob.dataA = New OleDbDataAdapter(ob.mycommand)
            ob.dataA.Fill(ob.dbset, "selling")
            DataGridView1.ReadOnly = True
            DataGridView1.DataSource = ob.dbset
            DataGridView1.DataMember = "selling"
            ob.mycommand = New OleDbCommand("select * from bill where custname='" + ComboBox3.Text + "' and dates='" + DateTimePicker1.Value.Date + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                Label3.Text = ob.myreader("amount")
                DataGridView1.Visible = True
                Panel1.Visible = True
            Else
                MessageBox.Show("There is no transaction available for selected customer at this date", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_search_item.Show()
    End Sub

  
End Class