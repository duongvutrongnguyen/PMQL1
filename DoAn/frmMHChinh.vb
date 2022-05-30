Public Class frmMHChinh
    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        Dim frm As frmSanPham = New frmSanPham()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NguoiDungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguoiDungToolStripMenuItem.Click
        Dim frm As frmNguoiDung = New frmNguoiDung()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub frmMHChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide()
        Dim frm As frmDangNhap = New frmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            Me.Show()
        Else
            Me.Close()
        End If

    End Sub
End Class
