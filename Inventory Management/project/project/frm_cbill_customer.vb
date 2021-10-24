Imports System.Data.OleDb
Public Class frm_cbill_customer
    Dim ob As New connection
    Public cust As String
    Public da As String
    Public custname As String
    Public amount As String
    Public count As Integer = 0
    Public Sub New(ByVal custid As String, ByVal dates As String, ByVal amt As String, ByVal cuname As String)
        InitializeComponent()
        cust = custid
        da = dates
        amount = amt
        custname = cuname
    End Sub


    Private Sub frm_bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ob.mycommand = New OleDbCommand("select * from sample2'", ob.myconnection)
        ob.myreader = ob.mycommand.ExecuteReader()
        While ob.myreader.Read()
            Label9.Text = ob.myreader("billno")
        End While
        Dim a As String
        a = Val(Label9.Text) + 1
        Label8.Text = "B" + a


        Label4.Text = cust
        Label5.Text = da
        Label6.Text = amount
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If count = 0 Then
            ob.mycommand = New OleDbCommand("insert into bill values('" + Label8.Text + "','" + Label4.Text + "','" + custname + "','" + Label5.Text + "','" + Label6.Text + "')", ob.myconnection)
            Dim a As Integer
            a = ob.mycommand.ExecuteNonQuery()
            If a > 0 Then
                MessageBox.Show("Bill payed successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            count += 1
            Dim b As String
            b = Val(Label9.Text) + 1
            ob.mycommand = New OleDbCommand("insert into sample2 values('" + b + "')", ob.myconnection)
            ob.mycommand.ExecuteNonQuery()
            Me.Close()
        Else
            MessageBox.Show("Bill already paid", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub
End Class