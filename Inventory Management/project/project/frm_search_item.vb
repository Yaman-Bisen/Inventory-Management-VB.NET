Imports System.Data.OleDb
Public Class frm_search_item
    Dim ob As New connection
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        If ComboBox1.Text = "(Select)" Then
            MessageBox.Show("Please select the option to search item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Item Code" Then
            Label2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = False
            TextBox2.Visible = False
            Label7.Visible = True
            TextBox6.Visible = True
            Label6.Visible = False
            TextBox5.Visible = False
        ElseIf ComboBox1.Text = "By Item Name" Then
            Label2.Visible = False
            TextBox1.Visible = False
            Label3.Visible = True
            TextBox2.Visible = True
            Label7.Visible = False
            TextBox6.Visible = False
            Label6.Visible = True
            TextBox5.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "(Select)" Then
            MessageBox.Show("Please select the option to search item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Item Code" Then
            ob.mycommand = New OleDbCommand("Select * from itemmaster where icode='" + TextBox1.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                MessageBox.Show("Item present in the inventory", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Text = ob.myreader("price")
                TextBox4.Text = ob.myreader("quantity")
                TextBox6.Text = ob.myreader("iname")
            Else
                MessageBox.Show("There is no item with item code " + TextBox1.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.Text = "By Item Name" Then
            ob.mycommand = New OleDbCommand("Select * from itemmaster where iname='" + TextBox2.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                MessageBox.Show("Item present in the inventory", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Text = ob.myreader("price")
                TextBox4.Text = ob.myreader("quantity")
                TextBox5.Text = ob.myreader("icode")
            Else
                MessageBox.Show("There is no item with item name " + TextBox2.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class