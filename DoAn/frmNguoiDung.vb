Public Class frmNguoiDung
    Dim dsTaiKhoan As DataTable
    Dim dsNguoiDung As DataTable
    Dim dsNguoiDungView As DataView
    Dim dsLoaiTaiKhoan As DataTable
    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsTaiKhoan = DuLieu.DocCauTruc("select * from TaiKhoan")

        dsLoaiTaiKhoan = DuLieu.DocDuLieu("select * from LoaiTaiKhoan where ltk_xoa = false")
        cbLoaiTaiKhoan.DataSource = dsLoaiTaiKhoan
        cbLoaiTaiKhoan.DisplayMember = "ltk_ten"
        cbLoaiTaiKhoan.ValueMember = "ltk_ma"

        DocDSNguoiDung(cbHienThiXoa.Checked)

    End Sub

    Sub DocDSNguoiDung(ByVal hien_thi_xoa As Boolean)
        Dim sql As String
        If hien_thi_xoa Then
            sql = "select nd_ma, tk_ten_dang_nhap, ltk_ten, nd_ho_ten, nd_dia_chi, nd_nam_sinh, tk_ma, tk_mat_khau, tk_ma_loai, ltk_ma, nd_ma_tai_khoan, nd_xoa
                from NguoiDung, TaiKhoan, LoaiTaiKhoan
                where nd_ma_tai_khoan = tk_ma and tk_ma_loai = ltk_ma"
        Else
            sql = "select nd_ma, tk_ten_dang_nhap, ltk_ten, nd_ho_ten, nd_dia_chi, nd_nam_sinh, tk_ma, tk_mat_khau, tk_ma_loai, ltk_ma, nd_ma_tai_khoan, nd_xoa
                from NguoiDung, TaiKhoan, LoaiTaiKhoan
                where nd_xoa = false and nd_ma_tai_khoan = tk_ma and tk_ma_loai = ltk_ma"
        End If
        dsNguoiDung = DuLieu.DocDuLieu(sql)
        dsNguoiDungView = New DataView(dsNguoiDung)
        dgvDSNguoiDung.DataSource = dsNguoiDungView
        dgvDSNguoiDung.Columns(7).Visible = True
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim tk As DataRow = dsTaiKhoan.NewRow()
        tk("tk_ten_dang_nhap") = tbTenDangNhap.Text
        tk("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
        tk("tk_ma_loai") = cbLoaiTaiKhoan.SelectedValue
        dsTaiKhoan.Rows.Add(tk)
        DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)

        Dim nd As DataRow = dsNguoiDung.NewRow()
        nd("tk_ten_dang_nhap") = tbTenDangNhap.Text
        nd("tk_mat_khau") = tk("tk_mat_khau")
        nd("tk_ma_loai") = cbLoaiTaiKhoan.SelectedValue

        nd("nd_ho_ten") = tbTen.Text
        nd("nd_dia_chi") = tbDiaChi.Text
        nd("nd_nam_sinh") = tbNamSinh.Text
        nd("nd_ma_tai_khoan") = tk("tk_ma")

        nd("ltk_ten") = cbLoaiTaiKhoan.SelectedItem("ltk_ten")
        nd("ltk_ma") = cbLoaiTaiKhoan.SelectedValue

        dsNguoiDung.Rows.Add(nd)
        DuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
        dsTaiKhoan.Rows.RemoveAt(0)

    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSNguoiDung.SelectedCells.Count = 0 Then
            Return
        End If

        Dim ndv As DataRowView = dgvDSNguoiDung.Rows(dgvDSNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
        Dim nd As DataRow = ndv.Row

        nd("nd_xoa") = True
        DuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
        If cbHienThiXoa.Checked = False Then
            dsNguoiDung.Rows.Remove(nd)
        End If
    End Sub

    Private Sub dgvDSNguoiDung_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDSNguoiDung.SelectionChanged
        If dgvDSNguoiDung.SelectedCells.Count = 0 Then
            Return
        End If

        Dim ndv As DataRowView = dgvDSNguoiDung.Rows(dgvDSNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
        Dim nd As DataRow = ndv.Row

        tbTen.Text = nd("nd_ho_ten")
        tbDiaChi.Text = nd("nd_dia_chi")
        tbTenDangNhap.Text = nd("tk_ten_dang_nhap")
        cbLoaiTaiKhoan.SelectedValue = nd("ltk_ma")
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDSNguoiDung.SelectedCells.Count = 0 Then
            Return
        End If

        Dim ndv As DataRowView = dgvDSNguoiDung.Rows(dgvDSNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
        Dim nd As DataRow = ndv.Row

        nd("tk_ten_dang_nhap") = tbTenDangNhap.Text
        nd("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
        nd("tk_ma_loai") = cbLoaiTaiKhoan.SelectedValue

        nd("nd_ho_ten") = tbTen.Text
        nd("nd_dia_chi") = tbDiaChi.Text
        nd("nd_nam_sinh") = tbNamSinh.Text


        nd("ltk_ten") = cbLoaiTaiKhoan.SelectedItem("ltk_ten")
        nd("ltk_ma") = cbLoaiTaiKhoan.SelectedValue
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        DocDSNguoiDung(cbHienThiXoa.Checked)
    End Sub
End Class