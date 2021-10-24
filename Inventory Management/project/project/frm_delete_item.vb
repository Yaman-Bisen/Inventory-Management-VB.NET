Imports System.Data.OleDb
Public Class frm_delete_item
    Dim ob As New connection
    Public count As Integer = 0
    Public count1 As Integer = 0
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "(Select Item By)" Then
            MessageBox.Show("Please select the item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text = "By Item Code" Then
            ComboBox2.Visible = True
            Label2.Visible = True
            TextBox2.Visible = True
            Label1.Visible = False
            TextBox1.Visible = False
            ComboBox3.Visible = False
        ElseIf ComboBox1.Text = "By Item Name" Then
            ComboBox3.Visible = True
            Label1.Visible = True
            TextBox1.Visible = True
            Label2.Visible = False
            TextBox2.Visible = False
            ComboBox2.Visible = False
        End If
        If count < 1 Then
            If ComboBox1.Text = "By Item Code" Then
                count = count + 1
                ob.mycommand = New OleDbCommand("select * from itemmaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox2.Items.Add(ob.myreader("icode"))
                End While
            End If
        End If
        If count1 < 1 Then
            If ComboBox1.Text = "By Item Name" Then
                count1 = count1 + 1
                ob.mycommand = New OleDbCommand("select * from itemmaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox3.Items.Add(ob.myreader("iname"))
                End While
            End If
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from itemmaster where iname = '" + ComboBox3.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox1.Text = ob.myreader("icode")
            TextBox3.Text = ob.myreader("price")
            TextBox4.Text = ob.myreader("quantity")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from itemmaster where icode = '" + ComboBox2.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox2.Text = ob.myreader("iname")
            TextBox3.Text = ob.myreader("price")
            TextBox4.Text = ob.myreader("quantity")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "By Item Code" Then
            TextBox5.Text = ComboBox2.Text
        ElseIf ComboBox1.Text = "By Item Name" Then
            TextBox5.Text = TextBox1.Text
        End If
        Dim res As DialogResult = MessageBox.Show("Are you sure do delete the Item details", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            ob.mycommand = New OleDbCommand("Delete * from itemmaster where icode = '" + TextBox5.Text + "'", ob.myconnection)
            Dim a As Integer
            a = ob.mycommand.ExecuteNonQuery()
            If a > 0 Then
                MessageBox.Show("Item record deleted successfully", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            End If
        Else
            MessageBox.Show("You cancelled the operation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class