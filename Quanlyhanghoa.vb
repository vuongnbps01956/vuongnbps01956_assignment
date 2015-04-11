Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanlyhanghoa
    'Private WithEvents reset As BindingManagerBase
    Dim tb As New DataTable
    Dim connect As String = "workstation id=DBvuongnbps01956.mssql.somee.com;packet size=4096;user id=Lab5login;pwd=@tata25010910;data source=DBvuongnbps01956.mssql.somee.com;persist security info=False;initial catalog=DBvuongnbps01956"
    Private Sub quanlysanphamfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tạo đối tượng kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connectstr
        Dim KetNoi As New SqlConnection(connect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', ChitietSP as 'Chi tiết sản phẩm', Loaisanpham_Maloai as 'Mã loại sản phẩm' from Sanpham", KetNoi)
        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        viewsanpham.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewsanpham.CellContentClick

        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = viewsanpham.CurrentCell.RowIndex
        txtmasanpham.Text = viewsanpham.Item(0, index).Value
        txttensanpham.Text = viewsanpham.Item(1, index).Value
        txtmaloaisanpham.Text = viewsanpham.Item(5, index).Value
        txtdongia.Text = viewsanpham.Item(2, index).Value
        txtsoluong.Text = viewsanpham.Item(3, index).Value
        txtchitiet.Text = viewsanpham.Item(4, index).Value
    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        End
    End Sub
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Sanpham SET TenSP = @TenSP,  Dongia = @Dongia, Soluong = @Soluong, ChitietSP = @Chitiet_SP, Loaisanpham_Maloai = @Loai_san_pham_Maloai where MaSP = @Ma_SP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SP", txtmasanpham.Text)
            com.Parameters.AddWithValue("@TenSP", txttensanpham.Text)
            com.Parameters.AddWithValue("@Dongia", txtdongia.Text)
            com.Parameters.AddWithValue("@Soluong", txtsoluong.Text)
            com.Parameters.AddWithValue("@Chitiet_SP", txtchitiet.Text)
            com.Parameters.AddWithValue("@Loai_san_pham_Maloai", txtmaloaisanpham.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Done")

        Catch ex As Exception
            MessageBox.Show("Fail!")
        End Try
        tb.Clear()
        viewsanpham.DataSource = tb
        viewsanpham.DataSource = Nothing
        xuat_lai_sql()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Sanpham where MaSP = @Ma_SP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SP", txtmasanpham.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Done")
        Catch ex As Exception
            MessageBox.Show("Fail")
        End Try
        tb.Clear()
        viewsanpham.DataSource = tb
        viewsanpham.DataSource = Nothing
        xuat_lai_sql()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into Sanpham (MaSP,TenSP,Dongia,Soluong,ChitietSP,Loaisanpham_Maloai) values('" & txtmasanpham.Text & "','" & txttensanpham.Text & "' ,'" & txtdongia.Text & "','" & txtsoluong.Text & "','" & txtchitiet.Text & "','" & txtmaloaisanpham.Text & "')"

        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Done")
        Catch ex As Exception
            MessageBox.Show("Fail")
        End Try
        tb.Clear()
        viewsanpham.DataSource = tb
        viewsanpham.DataSource = Nothing
        xuat_lai_sql()
    End Sub
    Private Sub xuat_lai_sql()

        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', ChitietSP as 'Chi tiết sản phẩm', Loaisanpham_Maloai as 'Mã loại sản phẩm' from Sanpham", KetNoi)

        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        viewsanpham.DataSource = tb
        KetNoi.Close()
    End Sub

   


End Class
