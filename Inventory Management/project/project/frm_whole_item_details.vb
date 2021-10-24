Imports System.Data.OleDb
Public Class frm_whole_item_details
    Dim ob As New connection
    Private Sub frm_whole_item_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ob.mycommand = New OleDbCommand("Select * from itemmaster'", ob.myconnection)

        ob.dataA = New OleDbDataAdapter(ob.mycommand)
        ob.dataA.Fill(ob.dbset, "itemmaster")
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = ob.dbset
        DataGridView1.DataMember = "itemmaster"
    End Sub

    Private Sub frm_whole_item_details_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Height = Me.Height - 60
        DataGridView1.Width = Me.Width - 40
    End Sub
End Class