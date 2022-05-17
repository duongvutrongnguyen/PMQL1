Public Class frmNguoiDung
    Dim dsNguoiDung As DataTable
    Dim dsNguoiDungView As DataView
    Dim dsLoaiTaiKhoan As DataTable
    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsLoaiTaiKhoan = DuLieu.DocDuLieu("select * from LoaiTaiKhoan where ltk_xoa = false")
        cbLoaiTaiKhoan.DataSource = dsLoaiTaiKhoan
        cbLoaiTaiKhoan.DisplayMember = "ltk_ten"
        cbLoaiTaiKhoan.ValueMember = "ltk_ma"

        Dim sql = "select nd_ma, tk_ten_dang_nhap, ltk_ten, nd_ho_ten, nd_dia_chi, nd_nam_sinh, tk_ma, tk_mat_khau, tk_ma_loai, ltk_ma, nd_ma_tai_khoan, nd_xoa
                from NguoiDung, TaiKhoan, LoaiTaiKhoan
                where nd_xoa = false and nd_ma_tai_khoan = tk_ma and tk_ma_loai = ltk_ma"
    End Sub
End Class