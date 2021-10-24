Imports System.Data.OleDb
Public Class new_transaction
    Dim ob As New connection
    Public count As Integer = 0
    Public count1 As Integer = 0
    Public count2 As Integer = 0
    Public count3 As Integer = 0
    Public b As Integer

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ob.mycommand = New OleDbCommand("Select * from itemmaster where icode = '" + ComboBox2.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        If ob.myreader.Read() Then
            TextBox5.Text = ob.myreader("iname")
            TextBox7.Text = ob.myreader("price")
        End If
        Dim b As Integer
        b = Val(TextBox8.Text)
        ob.mycommand = New OleDbCommand("Select * from itemmaster where icode='" + ComboBox2.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        Dim c As Integer
        If ob.myreader.Read() Then
            c = ob.myreader("quantity")
            If c = 0 Then
                MessageBox.Show("Sorry ! , out of stock", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox7.Text = ""
                TextBox5.Text = ""
            End If
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "(Select Item by)" Then
            MessageBox.Show("please select the item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox4.Text = "By Item Code" Then
            ComboBox2.Visible = True
            Label2.Visible = True
            TextBox5.Visible = True
            Label7.Visible = False
            TextBox6.Visible = False
            ComboBox3.Visible = False
        ElseIf ComboBox4.Text = "By Item Name" Then
            ComboBox3.Visible = True
            Label2.Visible = False
            TextBox5.Visible = False
            Label7.Visible = True
            TextBox6.Visible = True
            ComboBox2.Visible = False
        End If
        If count < 1 Then
            If ComboBox4.Text = "By Item Code" Then
                count = count + 1
                ob.mycommand = New OleDbCommand("select * from itemmaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox2.Items.Add(ob.myreader("icode"))
                End While
            End If
        End If
        If count1 < 1 Then
            If ComboBox4.Text = "By Item Name" Then
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
            TextBox6.Text = ob.myreader("icode")
            TextBox7.Text = ob.myreader("price")
        End If
        Dim b As Integer
        b = Val(TextBox8.Text)
        ob.mycommand = New OleDbCommand("Select * from itemmaster where iname='" + ComboBox3.Text + "'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        Dim c As Integer
        If ob.myreader.Read() Then
            c = ob.myreader("quantity")
            If c = 0 Then
                MessageBox.Show("Sorry ! , out of stock", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        b = Val(TextBox8.Text)
        If ComboBox4.Text = "(Select Item by)" Then
            MessageBox.Show("Please Select the item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If TextBox7.Text = "" Then
            MessageBox.Show("Please select the item to purchase", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Please enter the quantity", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If ComboBox4.Text = "By Item Code" Then
                TextBox13.Text = TextBox5.Text
                TextBox11.Text = ComboBox2.Text
            ElseIf ComboBox4.Text = "By Item Name" Then
                TextBox13.Text = ComboBox3.Text
                TextBox11.Text = TextBox6.Text

            End If
            If ComboBox5.Text = "By Customer Id" Then
                TextBox10.Text = ComboBox7.Text
                TextBox14.Text = TextBox1.Text
            ElseIf ComboBox5.Text = "By Customer Name" Then
                TextBox10.Text = TextBox9.Text
                TextBox14.Text = ComboBox6.Text
            End If

            ob.mycommand = New OleDbCommand("select * from itemmaster where icode = '" + TextBox11.Text + "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                Dim k As Integer
                k = ob.myreader("quantity")
                If k <= 0 Then
                    MessageBox.Show("Sorry ! , out of stock", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TextBox7.Text = ""
                    TextBox5.Text = ""
                ElseIf k < TextBox8.Text Then
                    MessageBox.Show("Quantity is greater than the available stock = " & k, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim a As Integer
                    a = Val(TextBox7.Text) * Val(TextBox8.Text)
                    ListBox2.Items.Add(a)
                    ListBox4.Items.Add(TextBox8.Text)
                    ListBox3.Items.Add(TextBox11.Text)
                    ListBox1.Items.Add(TextBox13.Text)
                    TextBox12.Text = a
                    ob.mycommand = New OleDbCommand("insert into selling values('" + TextBox10.Text + "','" + TextBox14.Text + "','" + TextBox11.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox12.Text + "','" + DateTimePicker1.Value.Date + "')", ob.myconnection)
                    ob.mycommand.ExecuteNonQuery()


                    ob.mycommand = New OleDbCommand("Select * from itemmaster where icode='" + TextBox11.Text + "'", ob.myconnection)
                    ob.myreader = ob.mycommand.ExecuteReader()
                    Dim c As Integer
                    If ob.myreader.Read() Then
                        c = ob.myreader("quantity")
                        '    'If c < TextBox8.Text Then

                        '    MessageBox.Show("Quantity is greater than the available stock = " & k, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    TextBox7.Text = ""
                        '    TextBox5.Text = ""
                        'Else
                        Dim d As Integer
                        d = c - b
                        ob.mycommand = New OleDbCommand("Update itemmaster set quantity = '" & d & "' where icode = '" + TextBox11.Text + "'", ob.myconnection)
                        ob.mycommand.ExecuteNonQuery()
                    End If
                End If

            End If
            TextBox8.Text = ""
        End If
        'End If


        Dim amt As String = 0
        Dim count As Integer
        count = ListBox2.Items.Count()
        Dim i As Integer = 0
        While i < count
            amt += ListBox2.Items(i)
            i += 1
        End While
        Label12.Text = amt

    End Sub



    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.Text = "(Select Customer by)" Then
            MessageBox.Show("please select the Customer", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ComboBox5.Text = "By Customer Id" Then
            ComboBox7.Visible = True
            Label3.Visible = True
            TextBox1.Visible = True
            Label1.Visible = False
            TextBox9.Visible = False
            ComboBox6.Visible = False

        ElseIf ComboBox5.Text = "By Customer Name" Then
            ComboBox6.Visible = True
            Label3.Visible = False
            TextBox1.Visible = False
            Label1.Visible = True
            TextBox9.Visible = True
            ComboBox7.Visible = False
        End If
        If count2 < 1 Then
            If ComboBox5.Text = "By Customer Id" Then
                count2 = count2 + 1
                ob.mycommand = New OleDbCommand("select * from customermaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox7.Items.Add(ob.myreader("custid"))
                End While
            End If
        End If
        If count3 < 1 Then
            If ComboBox5.Text = "By Customer Name" Then
                count3 = count3 + 1
                ob.mycommand = New OleDbCommand("select * from customermaster '", ob.myconnection)
                ob.myreader = ob.mycommand.ExecuteReader()
                While ob.myreader.Read()
                    ComboBox6.Items.Add(ob.myreader("custname"))
                End While
            End If
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
       
        Dim a As Integer
        a = ListBox3.Items.Count()
        If ListBox3.Items.Count() > 0 Then
            MessageBox.Show("you can't change the customer untill the current transaction is completed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("select * from customermaster where custname='" & ComboBox6.Text & "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                TextBox9.Text = ob.myreader("custid")
                TextBox2.Text = ob.myreader("mobno")
                TextBox3.Text = ob.myreader("email")
                TextBox4.Text = ob.myreader("address")
            End If
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        Dim a As Integer
        a = ListBox3.Items.Count()
        If ListBox3.Items.Count() > 0 Then
            MessageBox.Show("you can't change the customer untill the current transaction is completed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ob.mycommand = New OleDbCommand("select * from customermaster where custid='" & ComboBox7.Text & "'", ob.myconnection)
            ob.myreader = ob.mycommand.ExecuteReader()
            If ob.myreader.Read() Then
                TextBox1.Text = ob.myreader("custname")
                TextBox2.Text = ob.myreader("mobno")
                TextBox3.Text = ob.myreader("email")
                TextBox4.Text = ob.myreader("address")
            End If
        End If
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox3.SelectedIndex() >= 0 Or ListBox1.SelectedIndex() >= 0 Then
            Dim res As DialogResult = MessageBox.Show("Are you sure for deleting selected item", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = DialogResult.Yes Then
                Dim m As Integer
                'Dim a As String
                'a = ListBox3.SelectedItem
                'MessageBox.Show(a)
                ob.mycommand = New OleDbCommand("Delete * from selling where icode='" & ListBox3.SelectedItem.ToString & "' and custid= '" + TextBox10.Text + "' and dates= '" + DateTimePicker1.Value.Date + "'", ob.myconnection)
                m = ob.mycommand.ExecuteNonQuery()
                If m > 0 Then
                    MessageBox.Show("Item deleted successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ob.mycommand = New OleDbCommand("Select * from itemmaster where icode='" + TextBox11.Text + "'", ob.myconnection)
                    ob.myreader = ob.mycommand.ExecuteReader()
                    Dim c As Integer
                    If ob.myreader.Read() Then
                        c = ob.myreader("quantity")
                        Dim d As Integer
                        d = c + b
                        ob.mycommand = New OleDbCommand("Update itemmaster set quantity = '" & d & "' where icode = '" + TextBox11.Text + "'", ob.myconnection)
                        ob.mycommand.ExecuteNonQuery()
                        If ListBox3.SelectedIndex >= 0 Then
                            Dim a As Integer = ListBox3.SelectedIndex
                            Label12.Text = Val(Label12.Text) - ListBox2.Items(a)
                            ListBox1.Items.RemoveAt(a)
                            ListBox2.Items.RemoveAt(a)
                            ListBox3.Items.RemoveAt(a)
                            ListBox4.Items.RemoveAt(a)
                        ElseIf ListBox1.SelectedIndex >= 0 Then
                            Dim a As Integer = ListBox3.SelectedIndex
                            Label12.Text = Val(Label12.Text) - ListBox2.Items(a)
                            ListBox1.Items.RemoveAt(a)
                            ListBox2.Items.RemoveAt(a)
                            ListBox3.Items.RemoveAt(a)
                            ListBox4.Items.RemoveAt(a)
                        Else
                            MessageBox.Show("Please select item to delete", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("You cancelled the deletion", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select the item to delete", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox3.Items.Count() > 0 Then
            Dim amt As String = 0
            Dim count As Integer
            count = ListBox2.Items.Count()
            Dim i As Integer = 0
            While i < count
                amt += ListBox2.Items(i)
                i += 1
            End While
            Dim frm As New frm_cbill_customer(TextBox10.Text, DateTimePicker1.Value.Date, amt.ToString, TextBox14.Text)
            frm.Show()
            ' Me.Close()
        Else
            MessageBox.Show("Please purchase some items to pay bill", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox3.Items.Count() <= 0 Then
            Me.Close()
        Else
            Dim res As DialogResult = MessageBox.Show("Do you want to cancel your purchasing", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If res = DialogResult.Yes Then
                Dim i As Integer = 0
                Dim count = ListBox3.Items.Count()
                Dim icode As String
                Dim qty As Integer
                Dim qty1 As Integer
                While i < count
                    icode = ListBox3.Items(i)
                    qty = ListBox4.Items(i)
                    ob.mycommand = New OleDbCommand("select * from itemmaster where icode = '" + icode + "'", ob.myconnection)
                    ob.myreader = ob.mycommand.ExecuteReader()
                    If ob.myreader.Read() Then
                        qty1 = ob.myreader("quantity")
                        Dim newqty As Integer
                        newqty = qty + qty1
                        ob.mycommand = New OleDbCommand("Update itemmaster set quantity = '" & newqty & "' where icode = '" + icode + "'", ob.myconnection)
                        ob.mycommand.ExecuteNonQuery()
                    End If
                    i += 1
                End While
                Me.Close()
            End If
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        ComboBox4.Enabled = True
    End Sub
End Class
