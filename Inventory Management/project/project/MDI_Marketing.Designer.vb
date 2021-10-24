<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Marketing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateItemDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewItemTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.ItemToolStripMenuItem, Me.SellingToolStripMenuItem, Me.SearchToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ViewToolStripMenuItem, Me.CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCustomerToolStripMenuItem, Me.UpdateCustomerDetailsToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'AddNewCustomerToolStripMenuItem
        '
        Me.AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        Me.AddNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AddNewCustomerToolStripMenuItem.Text = "Add New Customer"
        '
        'UpdateCustomerDetailsToolStripMenuItem
        '
        Me.UpdateCustomerDetailsToolStripMenuItem.Name = "UpdateCustomerDetailsToolStripMenuItem"
        Me.UpdateCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.UpdateCustomerDetailsToolStripMenuItem.Text = "Update Customer Details"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewItemToolStripMenuItem, Me.UpdateItemDetailsToolStripMenuItem, Me.ViewItemTableToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'AddNewItemToolStripMenuItem
        '
        Me.AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem"
        Me.AddNewItemToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AddNewItemToolStripMenuItem.Text = "Add New Item"
        '
        'UpdateItemDetailsToolStripMenuItem
        '
        Me.UpdateItemDetailsToolStripMenuItem.Name = "UpdateItemDetailsToolStripMenuItem"
        Me.UpdateItemDetailsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.UpdateItemDetailsToolStripMenuItem.Text = "Update Item Quantity"
        '
        'ViewItemTableToolStripMenuItem
        '
        Me.ViewItemTableToolStripMenuItem.Name = "ViewItemTableToolStripMenuItem"
        Me.ViewItemTableToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ViewItemTableToolStripMenuItem.Text = "Update Item Price"
        '
        'SellingToolStripMenuItem
        '
        Me.SellingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem, Me.ViewTransactionDetailsToolStripMenuItem})
        Me.SellingToolStripMenuItem.Name = "SellingToolStripMenuItem"
        Me.SellingToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SellingToolStripMenuItem.Text = "Selling"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'ViewTransactionDetailsToolStripMenuItem
        '
        Me.ViewTransactionDetailsToolStripMenuItem.Name = "ViewTransactionDetailsToolStripMenuItem"
        Me.ViewTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ViewTransactionDetailsToolStripMenuItem.Text = "View Transaction Details"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchCustomerToolStripMenuItem, Me.SearchItemToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'SearchCustomerToolStripMenuItem
        '
        Me.SearchCustomerToolStripMenuItem.Name = "SearchCustomerToolStripMenuItem"
        Me.SearchCustomerToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SearchCustomerToolStripMenuItem.Text = "Search Customer"
        '
        'SearchItemToolStripMenuItem
        '
        Me.SearchItemToolStripMenuItem.Name = "SearchItemToolStripMenuItem"
        Me.SearchItemToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SearchItemToolStripMenuItem.Text = "Search Item"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.ItemToolStripMenuItem1})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'ItemToolStripMenuItem1
        '
        Me.ItemToolStripMenuItem1.Name = "ItemToolStripMenuItem1"
        Me.ItemToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.ItemToolStripMenuItem1.Text = "Item"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillDetailsToolStripMenuItem, Me.CustomerTableToolStripMenuItem, Me.ItemTableToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'BillDetailsToolStripMenuItem
        '
        Me.BillDetailsToolStripMenuItem.Name = "BillDetailsToolStripMenuItem"
        Me.BillDetailsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BillDetailsToolStripMenuItem.Text = "Bill Details"
        '
        'CustomerTableToolStripMenuItem
        '
        Me.CustomerTableToolStripMenuItem.Name = "CustomerTableToolStripMenuItem"
        Me.CustomerTableToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CustomerTableToolStripMenuItem.Text = "Customer Table"
        '
        'ItemTableToolStripMenuItem
        '
        Me.ItemTableToolStripMenuItem.Name = "ItemTableToolStripMenuItem"
        Me.ItemTableToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ItemTableToolStripMenuItem.Text = "Item Table"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HorizontalToolStripMenuItem, Me.VerticalToolStripMenuItem})
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.CToolStripMenuItem.Text = "Cascade"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'MDI_Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 482)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MDI_Marketing"
        Me.Text = "MDI_Marketing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateItemDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewItemTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SellingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
