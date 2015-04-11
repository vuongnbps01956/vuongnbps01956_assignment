Imports System.Data.SqlClient
Public Class dangnhap

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim chuoiketnoi As String = "workstation id=DBvuongnbps01956.mssql.somee.com;packet size=4096;user id=Lab5login;pwd=@tata25010910;data source=DBvuongnbps01956.mssql.somee.com;persist security info=False;initial catalog=DBvuongnbps01956"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from nhanvien where MaNV='" & txtuser.Text & "' and pass='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Welcome")
                frmmain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong: Username or password")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo) Then
            Me.Close()

        End If

    End Sub

   
    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class
