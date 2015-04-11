Public Class frmmain

 
    Private Sub itemdanhsachhanghoa_Click(sender As Object, e As EventArgs) Handles itemdanhsachhanghoa.Click
        frmquanlyhanghoa.Show()
    End Sub

    Private Sub itemdangxuat_Click(sender As Object, e As EventArgs) Handles itemdangxuat.Click
        dangnhap.Show()
    End Sub

    Private Sub itemthoat_Click(sender As Object, e As EventArgs) Handles itemthoat.Click
        Me.Close()
    End Sub

End Class