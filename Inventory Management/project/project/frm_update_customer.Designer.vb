﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_update_customer
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(414, 217)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(155, 26)
        Me.TextBox5.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(26, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 101)
        Me.Panel1.TabIndex = 12
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(24, 44)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(186, 27)
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.Text = "(By Customer Name)"
        Me.ComboBox3.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(32, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 27)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.Text = "(By Customer Id)"
        Me.ComboBox2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"By Customer Id", "By Customer Name"})
        Me.ComboBox1.Location = New System.Drawing.Point(24, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 27)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "(Select Customer By)"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(414, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(155, 26)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(414, 127)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(155, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(414, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 26)
        Me.TextBox1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 345)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(372, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = ">>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = ">>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = ">>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = ">>"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(201, 217)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(155, 26)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(201, 172)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(155, 26)
        Me.TextBox7.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(201, 127)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(155, 26)
        Me.TextBox8.TabIndex = 13
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(201, 42)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(155, 26)
        Me.TextBox9.TabIndex = 11
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(201, 87)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(155, 26)
        Me.TextBox10.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Id:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(414, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 26)
        Me.TextBox2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Update "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mobile No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(388, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 26)
        Me.DateTimePicker1.TabIndex = 16
        '
        'frm_update_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 504)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frm_update_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Customer Details :"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
