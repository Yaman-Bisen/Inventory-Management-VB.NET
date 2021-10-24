Imports System.Data.OleDb
Public Class frm_item_details
    Dim ob As New connection()


    Private Sub frm_item_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Visible = False
        ob.mycommand = New OleDbCommand("Select * from sample1", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        While ob.myreader.Read()
            Label3.Text = ob.myreader("sampleitemid")
        End While
        Dim a As String
        a = Val(Label3.Text) + 1
        Label2.Text = "I" + a
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please Enter the complete information about the item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("select * from itemmaster where iname='" + TextBox1.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read Then
                MessageBox.Show("Item already registered with icode = " + ob.myreader("icode"), "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ob.mycommand = New OleDbCommand("insert into itemmaster values('" + Label2.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Value.Date + "')", ob.myconnection)
                Dim a As Integer
                a = ob.mycommand.ExecuteNonQuery()
                If a > 0 Then
                    MessageBox.Show("Item added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim b As Integer
                    b = Val(Label3.Text) + 1
                    ob.mycommand = New OleDbCommand("insert into sample1 values('" & b & "')", ob.myconnection)
                    ob.mycommand.ExecuteNonQuery()
                    ob.mycommand = New OleDbCommand("Select * from sample1", ob.myconnection)
                    ob.myreader = ob.mycommand.ExecuteReader()
                    While ob.myreader.Read()
                        Label3.Text = ob.myreader("sampleitemid")
                    End While
                    Dim m As String
                    m = Val(Label3.Text) + 1
                    Label2.Text = "I" + m
                End If
            End If
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub


End Class