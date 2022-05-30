Public Class frmDangNhap
    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bDangNhap_Click(sender As Object, e As EventArgs) Handles bDangNhap.Click
        Dim TenDangNhap As String = tbTenDangNhap.Text
        Dim MatKhau As String = tbMatKhau.Text

        Dim dsNguoiDung As DataTable = DuLieu.DocDuLieu("Select * from TaiKhoan where tk_ten_dang_nhap = '" + TenDangNhap + "'")
        If dsNguoiDung.Rows.Count = 1 Then
            If Util.getHash(MatKhau) = dsNguoiDung.Rows(0)("tk_mat_khau") Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Return
            End If
        End If
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bThoat_Click(sender As Object, e As EventArgs) Handles bThoat.Click

    End Sub
End Class