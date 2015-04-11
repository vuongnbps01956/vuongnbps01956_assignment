<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlyhanghoa
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
        Me.lbltensanpham = New System.Windows.Forms.Label()
        Me.lblmasanpham = New System.Windows.Forms.Label()
        Me.lblsoluong = New System.Windows.Forms.Label()
        Me.lbldongia = New System.Windows.Forms.Label()
        Me.lblchithiet = New System.Windows.Forms.Label()
        Me.txttensanpham = New System.Windows.Forms.TextBox()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtchitiet = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.viewsanpham = New System.Windows.Forms.DataGridView()
        Me.txtmaloaisanpham = New System.Windows.Forms.TextBox()
        Me.lblmaloaisanpham = New System.Windows.Forms.Label()
        CType(Me.viewsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltensanpham
        '
        Me.lbltensanpham.AutoSize = True
        Me.lbltensanpham.Location = New System.Drawing.Point(23, 35)
        Me.lbltensanpham.Name = "lbltensanpham"
        Me.lbltensanpham.Size = New System.Drawing.Size(75, 13)
        Me.lbltensanpham.TabIndex = 0
        Me.lbltensanpham.Text = "Tên sản phẩm"
        '
        'lblmasanpham
        '
        Me.lblmasanpham.AutoSize = True
        Me.lblmasanpham.Location = New System.Drawing.Point(27, 61)
        Me.lblmasanpham.Name = "lblmasanpham"
        Me.lblmasanpham.Size = New System.Drawing.Size(71, 13)
        Me.lblmasanpham.TabIndex = 1
        Me.lblmasanpham.Text = "Mã sản phẩm"
        '
        'lblsoluong
        '
        Me.lblsoluong.AutoSize = True
        Me.lblsoluong.Location = New System.Drawing.Point(49, 88)
        Me.lblsoluong.Name = "lblsoluong"
        Me.lblsoluong.Size = New System.Drawing.Size(49, 13)
        Me.lblsoluong.TabIndex = 2
        Me.lblsoluong.Text = "Số lượng"
        '
        'lbldongia
        '
        Me.lbldongia.AutoSize = True
        Me.lbldongia.Location = New System.Drawing.Point(54, 114)
        Me.lbldongia.Name = "lbldongia"
        Me.lbldongia.Size = New System.Drawing.Size(44, 13)
        Me.lbldongia.TabIndex = 3
        Me.lbldongia.Text = "Đơn giá"
        '
        'lblchithiet
        '
        Me.lblchithiet.AutoSize = True
        Me.lblchithiet.Location = New System.Drawing.Point(59, 140)
        Me.lblchithiet.Name = "lblchithiet"
        Me.lblchithiet.Size = New System.Drawing.Size(39, 13)
        Me.lblchithiet.TabIndex = 4
        Me.lblchithiet.Text = "Chi tiết"
        '
        'txttensanpham
        '
        Me.txttensanpham.Location = New System.Drawing.Point(104, 32)
        Me.txttensanpham.Name = "txttensanpham"
        Me.txttensanpham.Size = New System.Drawing.Size(273, 20)
        Me.txttensanpham.TabIndex = 7
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(104, 58)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(273, 20)
        Me.txtmasanpham.TabIndex = 8
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(104, 85)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(273, 20)
        Me.txtsoluong.TabIndex = 9
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(104, 111)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(273, 20)
        Me.txtdongia.TabIndex = 10
        '
        'txtchitiet
        '
        Me.txtchitiet.Location = New System.Drawing.Point(104, 137)
        Me.txtchitiet.Name = "txtchitiet"
        Me.txtchitiet.Size = New System.Drawing.Size(273, 20)
        Me.txtchitiet.TabIndex = 11
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(45, 189)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 12
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(126, 189)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 13
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(207, 189)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 14
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(288, 189)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 15
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'viewsanpham
        '
        Me.viewsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewsanpham.Location = New System.Drawing.Point(12, 218)
        Me.viewsanpham.Name = "viewsanpham"
        Me.viewsanpham.Size = New System.Drawing.Size(386, 249)
        Me.viewsanpham.TabIndex = 16
        '
        'txtmaloaisanpham
        '
        Me.txtmaloaisanpham.Location = New System.Drawing.Point(104, 163)
        Me.txtmaloaisanpham.Name = "txtmaloaisanpham"
        Me.txtmaloaisanpham.Size = New System.Drawing.Size(273, 20)
        Me.txtmaloaisanpham.TabIndex = 17
        '
        'lblmaloaisanpham
        '
        Me.lblmaloaisanpham.AutoSize = True
        Me.lblmaloaisanpham.Location = New System.Drawing.Point(8, 166)
        Me.lblmaloaisanpham.Name = "lblmaloaisanpham"
        Me.lblmaloaisanpham.Size = New System.Drawing.Size(90, 13)
        Me.lblmaloaisanpham.TabIndex = 18
        Me.lblmaloaisanpham.Text = "Mã loại sản phẩm"
        '
        'frmquanlyhanghoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 479)
        Me.Controls.Add(Me.lblmaloaisanpham)
        Me.Controls.Add(Me.txtmaloaisanpham)
        Me.Controls.Add(Me.viewsanpham)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtchitiet)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtmasanpham)
        Me.Controls.Add(Me.txttensanpham)
        Me.Controls.Add(Me.lblchithiet)
        Me.Controls.Add(Me.lbldongia)
        Me.Controls.Add(Me.lblsoluong)
        Me.Controls.Add(Me.lblmasanpham)
        Me.Controls.Add(Me.lbltensanpham)
        Me.Name = "frmquanlyhanghoa"
        Me.Text = "Quản lý hàng hóa"
        CType(Me.viewsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltensanpham As System.Windows.Forms.Label
    Friend WithEvents lblmasanpham As System.Windows.Forms.Label
    Friend WithEvents lblsoluong As System.Windows.Forms.Label
    Friend WithEvents lbldongia As System.Windows.Forms.Label
    Friend WithEvents lblchithiet As System.Windows.Forms.Label
    Friend WithEvents txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtchitiet As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents viewsanpham As System.Windows.Forms.DataGridView
    Friend WithEvents txtmaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblmaloaisanpham As System.Windows.Forms.Label
End Class
