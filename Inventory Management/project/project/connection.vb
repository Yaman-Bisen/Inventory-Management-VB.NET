Imports System.Data.OleDb
Public Class connection
    Public myconnection = New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=F:\Programms\VB.NET Project\yaman bisen vb.net\Database1.mdb")
    'F:\Programms\VB.NET Project\yaman bisen vb.net
    Public myreader As OleDbDataReader
    Public mycommand As New OleDbCommand
    Public dataA As New OleDbDataAdapter
    Public dbset As New DataSet

    Public Sub New()
        myconnection.open()
    End Sub
End Class
