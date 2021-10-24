Imports System.Data.OleDb
Public Class frm_whole_cust_details
    Dim ob As New connection
    Private Sub frm_whole_cust_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ob.mycommand = New OleDbCommand("Select * from customermaster'", ob.myconnection)

            ob.dataA = New OleDbDataAdapter(ob.mycommand)
            ob.dataA.Fill(ob.dbset, "customermaster")
            DataGridView1.ReadOnly = True
            DataGridView1.DataSource = ob.dbset
            DataGridView1.DataMember = "customermaster"

    End Sub

    Private Sub frm_whole_cust_details_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Height = Me.Height - 60
        DataGridView1.Width = Me.Width - 40
    End Sub
End Class