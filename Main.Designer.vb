<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.Mnstrip = New System.Windows.Forms.MenuStrip()
        Me.itemhethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemdangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemthoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemquanlynhanvien = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemdanhsachnhanvien = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemquanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemquanlyhanghoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemdanhsachhanghoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemquanlyhanghoa1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemtrogiup = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemabout = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemupdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStripNBV = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Mnstrip.SuspendLayout()
        Me.StatusStripNBV.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mnstrip
        '
        Me.Mnstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemhethong, Me.itemquanlynhanvien, Me.itemquanlyhanghoa, Me.itemtrogiup})
        Me.Mnstrip.Location = New System.Drawing.Point(0, 0)
        Me.Mnstrip.Name = "Mnstrip"
        Me.Mnstrip.Size = New System.Drawing.Size(750, 24)
        Me.Mnstrip.TabIndex = 0
        Me.Mnstrip.Text = "MenuStrip1"
        '
        'itemhethong
        '
        Me.itemhethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemdangxuat, Me.itemthoat})
        Me.itemhethong.Name = "itemhethong"
        Me.itemhethong.Size = New System.Drawing.Size(69, 20)
        Me.itemhethong.Text = "Hệ thống"
        '
        'itemdangxuat
        '
        Me.itemdangxuat.Name = "itemdangxuat"
        Me.itemdangxuat.Size = New System.Drawing.Size(127, 22)
        Me.itemdangxuat.Text = "Đăng xuất"
        '
        'itemthoat
        '
        Me.itemthoat.Name = "itemthoat"
        Me.itemthoat.Size = New System.Drawing.Size(127, 22)
        Me.itemthoat.Text = "Thoát "
        '
        'itemquanlynhanvien
        '
        Me.itemquanlynhanvien.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemdanhsachnhanvien, Me.itemquanly})
        Me.itemquanlynhanvien.Name = "itemquanlynhanvien"
        Me.itemquanlynhanvien.Size = New System.Drawing.Size(115, 20)
        Me.itemquanlynhanvien.Text = "Quản lý nhân viên"
        '
        'itemdanhsachnhanvien
        '
        Me.itemdanhsachnhanvien.Name = "itemdanhsachnhanvien"
        Me.itemdanhsachnhanvien.Size = New System.Drawing.Size(184, 22)
        Me.itemdanhsachnhanvien.Text = "Danh sách nhân viên"
        '
        'itemquanly
        '
        Me.itemquanly.Name = "itemquanly"
        Me.itemquanly.Size = New System.Drawing.Size(184, 22)
        Me.itemquanly.Text = "Quản lý"
        '
        'itemquanlyhanghoa
        '
        Me.itemquanlyhanghoa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemdanhsachhanghoa, Me.itemquanlyhanghoa1})
        Me.itemquanlyhanghoa.Name = "itemquanlyhanghoa"
        Me.itemquanlyhanghoa.Size = New System.Drawing.Size(113, 20)
        Me.itemquanlyhanghoa.Text = "Quản lý hàng hóa"
        '
        'itemdanhsachhanghoa
        '
        Me.itemdanhsachhanghoa.Name = "itemdanhsachhanghoa"
        Me.itemdanhsachhanghoa.Size = New System.Drawing.Size(182, 22)
        Me.itemdanhsachhanghoa.Text = "Danh sách hàng hóa"
        '
        'itemquanlyhanghoa1
        '
        Me.itemquanlyhanghoa1.Name = "itemquanlyhanghoa1"
        Me.itemquanlyhanghoa1.Size = New System.Drawing.Size(182, 22)
        Me.itemquanlyhanghoa1.Text = "Quản lý"
        '
        'itemtrogiup
        '
        Me.itemtrogiup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemabout, Me.itemupdate})
        Me.itemtrogiup.Name = "itemtrogiup"
        Me.itemtrogiup.Size = New System.Drawing.Size(64, 20)
        Me.itemtrogiup.Text = "Trợ giúp"
        '
        'itemabout
        '
        Me.itemabout.Name = "itemabout"
        Me.itemabout.Size = New System.Drawing.Size(112, 22)
        Me.itemabout.Text = "About"
        '
        'itemupdate
        '
        Me.itemupdate.Name = "itemupdate"
        Me.itemupdate.Size = New System.Drawing.Size(112, 22)
        Me.itemupdate.Text = "Update"
        '
        'StatusStripNBV
        '
        Me.StatusStripNBV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStripNBV.Location = New System.Drawing.Point(0, 443)
        Me.StatusStripNBV.Name = "StatusStripNBV"
        Me.StatusStripNBV.Size = New System.Drawing.Size(750, 22)
        Me.StatusStripNBV.TabIndex = 1
        Me.StatusStripNBV.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(205, 17)
        Me.ToolStripStatusLabel1.Text = "Nguyễn Bắc Vương-Vuongnbps01956"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(753, 468)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(546, 91)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 465)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.StatusStripNBV)
        Me.Controls.Add(Me.Mnstrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.Mnstrip
        Me.Name = "frmmain"
        Me.Text = "Hệ thống"
        Me.Mnstrip.ResumeLayout(False)
        Me.Mnstrip.PerformLayout()
        Me.StatusStripNBV.ResumeLayout(False)
        Me.StatusStripNBV.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mnstrip As System.Windows.Forms.MenuStrip
    Friend WithEvents itemhethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemquanlynhanvien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemquanlyhanghoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemtrogiup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemdangxuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemthoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemdanhsachnhanvien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemquanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemdanhsachhanghoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemquanlyhanghoa1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemabout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemupdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStripNBV As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
