Imports System.Data.OleDb

Public Class MDI_Marketing

    
    Private Sub AddNewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCustomerToolStripMenuItem.Click
        frm_customer_detail.MdiParent = Me
        frm_customer_detail.Show()
        AddNewCustomerToolStripMenuItem.Checked = True
        UpdateCustomerDetailsToolStripMenuItem.Checked = False
    End Sub

    Private Sub UpdateCustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCustomerDetailsToolStripMenuItem.Click
        frm_update_customer.MdiParent = Me
        frm_update_customer.Show()
        UpdateCustomerDetailsToolStripMenuItem.Checked = True
        AddNewCustomerToolStripMenuItem.Checked = False
    End Sub
    Private Sub AddNewItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewItemToolStripMenuItem.Click
        frm_item_details.MdiParent = Me
        frm_item_details.Show()
        AddNewItemToolStripMenuItem.Checked = True
        UpdateItemDetailsToolStripMenuItem.Checked = False
        ViewItemTableToolStripMenuItem.Checked = False
    End Sub

    Private Sub UpdateItemDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateItemDetailsToolStripMenuItem.Click
        frm_update_item_quantity.MdiParent = Me
        frm_update_item_quantity.Show()
        UpdateItemDetailsToolStripMenuItem.Checked = True
        AddNewItemToolStripMenuItem.Checked = False
        ViewItemTableToolStripMenuItem.Checked = False
    End Sub

    Private Sub ViewItemTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewItemTableToolStripMenuItem.Click
        frm_update_price.MdiParent = Me
        frm_update_price.Show()
        ViewItemTableToolStripMenuItem.Checked = True
        AddNewItemToolStripMenuItem.Checked = False
        UpdateItemDetailsToolStripMenuItem.Checked = False
    End Sub
    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        new_transaction.MdiParent = Me
        new_transaction.Show()
        TransactionToolStripMenuItem.Checked = True
        ViewTransactionDetailsToolStripMenuItem.Checked = False
    End Sub

    Private Sub ViewTransactionDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTransactionDetailsToolStripMenuItem.Click
        frm_bill_details.MdiParent = Me
        frm_bill_details.Show()
        ViewTransactionDetailsToolStripMenuItem.Checked = True
        TransactionToolStripMenuItem.Checked = False
    End Sub

    Private Sub SearchCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCustomerToolStripMenuItem.Click
        frm_search_customer.MdiParent = Me
        frm_search_customer.Show()
        SearchCustomerToolStripMenuItem.Checked = True
        SearchItemToolStripMenuItem.Checked = True
    End Sub

    Private Sub SearchItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchItemToolStripMenuItem.Click
        frm_search_item.MdiParent = Me
        frm_search_item.Show()
        SearchCustomerToolStripMenuItem.Checked = False
        SearchItemToolStripMenuItem.Checked = True

    End Sub
    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        frm_delete_customer.MdiParent = Me
        frm_delete_customer.Show()
        CustomerToolStripMenuItem1.Checked = True
        ItemToolStripMenuItem1.Checked = False
    End Sub

    Private Sub ItemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemToolStripMenuItem1.Click
        frm_delete_item.MdiParent = Me
        frm_delete_item.Show()
        CustomerToolStripMenuItem1.Checked = False
        ItemToolStripMenuItem1.Checked = True

    End Sub

    Private Sub BillDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillDetailsToolStripMenuItem.Click
        frm_bill_details.MdiParent = Me
        frm_bill_details.Show()
        BillDetailsToolStripMenuItem.Checked = True
        CustomerTableToolStripMenuItem.Checked = False
        ItemTableToolStripMenuItem.Checked = False
    End Sub

    Private Sub ItemTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemTableToolStripMenuItem.Click
        frm_whole_item_details.MdiParent = Me
        frm_whole_item_details.Show()
        BillDetailsToolStripMenuItem.Checked = False
        CustomerTableToolStripMenuItem.Checked = False
        ItemTableToolStripMenuItem.Checked = True
    End Sub

    Private Sub CustomerTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerTableToolStripMenuItem.Click
        frm_whole_cust_details.MdiParent = Me
        frm_whole_cust_details.Show()
        BillDetailsToolStripMenuItem.Checked = False
        CustomerTableToolStripMenuItem.Checked = True
        ItemTableToolStripMenuItem.Checked = False
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
        VerticalToolStripMenuItem.Checked = False
        HorizontalToolStripMenuItem.Checked = True
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
        VerticalToolStripMenuItem.Checked = True
        HorizontalToolStripMenuItem.Checked = False
    End Sub
End Class
