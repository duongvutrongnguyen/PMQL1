<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNguoiDung
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
        Me.dgvDSNguoiDung = New System.Windows.Forms.DataGridView()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbNamSinh = New System.Windows.Forms.TextBox()
        Me.tbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.cbLoaiTaiKhoan = New System.Windows.Forms.ComboBox()
        Me.lbTen = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbNamSinh = New System.Windows.Forms.Label()
        Me.lbTenDangNhap = New System.Windows.Forms.Label()
        Me.lbMatKhau = New System.Windows.Forms.Label()
        Me.lbLoaiTaiKhoan = New System.Windows.Forms.Label()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.cbHienThiXoa = New System.Windows.Forms.CheckBox()
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDSNguoiDung
        '
        Me.dgvDSNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSNguoiDung.Location = New System.Drawing.Point(46, 27)
        Me.dgvDSNguoiDung.Name = "dgvDSNguoiDung"
        Me.dgvDSNguoiDung.RowHeadersWidth = 51
        Me.dgvDSNguoiDung.RowTemplate.Height = 29
        Me.dgvDSNguoiDung.Size = New System.Drawing.Size(643, 431)
        Me.dgvDSNguoiDung.TabIndex = 0
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(836, 53)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(125, 27)
        Me.tbTen.TabIndex = 1
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(836, 104)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(125, 27)
        Me.tbDiaChi.TabIndex = 1
        '
        'tbNamSinh
        '
        Me.tbNamSinh.Location = New System.Drawing.Point(836, 159)
        Me.tbNamSinh.Name = "tbNamSinh"
        Me.tbNamSinh.Size = New System.Drawing.Size(125, 27)
        Me.tbNamSinh.TabIndex = 1
        '
        'tbTenDangNhap
        '
        Me.tbTenDangNhap.Location = New System.Drawing.Point(836, 216)
        Me.tbTenDangNhap.Name = "tbTenDangNhap"
        Me.tbTenDangNhap.Size = New System.Drawing.Size(125, 27)
        Me.tbTenDangNhap.TabIndex = 1
        '
        'tbMatKhau
        '
        Me.tbMatKhau.Location = New System.Drawing.Point(836, 276)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMatKhau.Size = New System.Drawing.Size(125, 27)
        Me.tbMatKhau.TabIndex = 1
        '
        'cbLoaiTaiKhoan
        '
        Me.cbLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiTaiKhoan.FormattingEnabled = True
        Me.cbLoaiTaiKhoan.Location = New System.Drawing.Point(836, 328)
        Me.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan"
        Me.cbLoaiTaiKhoan.Size = New System.Drawing.Size(151, 28)
        Me.cbLoaiTaiKhoan.TabIndex = 2
        '
        'lbTen
        '
        Me.lbTen.AutoSize = True
        Me.lbTen.Location = New System.Drawing.Point(722, 54)
        Me.lbTen.Name = "lbTen"
        Me.lbTen.Size = New System.Drawing.Size(32, 20)
        Me.lbTen.TabIndex = 3
        Me.lbTen.Text = "Ten"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(722, 107)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(55, 20)
        Me.lbDiaChi.TabIndex = 3
        Me.lbDiaChi.Text = "Dia chi"
        '
        'lbNamSinh
        '
        Me.lbNamSinh.AutoSize = True
        Me.lbNamSinh.Location = New System.Drawing.Point(722, 162)
        Me.lbNamSinh.Name = "lbNamSinh"
        Me.lbNamSinh.Size = New System.Drawing.Size(71, 20)
        Me.lbNamSinh.TabIndex = 3
        Me.lbNamSinh.Text = "Nam sinh"
        '
        'lbTenDangNhap
        '
        Me.lbTenDangNhap.AutoSize = True
        Me.lbTenDangNhap.Location = New System.Drawing.Point(722, 219)
        Me.lbTenDangNhap.Name = "lbTenDangNhap"
        Me.lbTenDangNhap.Size = New System.Drawing.Size(107, 20)
        Me.lbTenDangNhap.TabIndex = 3
        Me.lbTenDangNhap.Text = "Ten dang nhap"
        '
        'lbMatKhau
        '
        Me.lbMatKhau.AutoSize = True
        Me.lbMatKhau.Location = New System.Drawing.Point(722, 279)
        Me.lbMatKhau.Name = "lbMatKhau"
        Me.lbMatKhau.Size = New System.Drawing.Size(70, 20)
        Me.lbMatKhau.TabIndex = 3
        Me.lbMatKhau.Text = "Mat khau"
        '
        'lbLoaiTaiKhoan
        '
        Me.lbLoaiTaiKhoan.AutoSize = True
        Me.lbLoaiTaiKhoan.Location = New System.Drawing.Point(722, 331)
        Me.lbLoaiTaiKhoan.Name = "lbLoaiTaiKhoan"
        Me.lbLoaiTaiKhoan.Size = New System.Drawing.Size(102, 20)
        Me.lbLoaiTaiKhoan.TabIndex = 3
        Me.lbLoaiTaiKhoan.Text = "Loai tai khoan"
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(743, 401)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(94, 29)
        Me.bThem.TabIndex = 4
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(867, 401)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 4
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(981, 401)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 4
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'cbHienThiXoa
        '
        Me.cbHienThiXoa.AutoSize = True
        Me.cbHienThiXoa.Location = New System.Drawing.Point(863, 18)
        Me.cbHienThiXoa.Name = "cbHienThiXoa"
        Me.cbHienThiXoa.Size = New System.Drawing.Size(159, 24)
        Me.cbHienThiXoa.TabIndex = 5
        Me.cbHienThiXoa.Text = "Nguoi dung da xoa"
        Me.cbHienThiXoa.UseVisualStyleBackColor = True
        '
        'frmNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 488)
        Me.Controls.Add(Me.cbHienThiXoa)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.lbLoaiTaiKhoan)
        Me.Controls.Add(Me.lbMatKhau)
        Me.Controls.Add(Me.lbTenDangNhap)
        Me.Controls.Add(Me.lbNamSinh)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbTen)
        Me.Controls.Add(Me.cbLoaiTaiKhoan)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.tbTenDangNhap)
        Me.Controls.Add(Me.tbNamSinh)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.dgvDSNguoiDung)
        Me.Name = "frmNguoiDung"
        Me.Text = "frmNguoiDung"
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDSNguoiDung As DataGridView
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbNamSinh As TextBox
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents cbLoaiTaiKhoan As ComboBox
    Friend WithEvents lbTen As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbNamSinh As Label
    Friend WithEvents lbTenDangNhap As Label
    Friend WithEvents lbMatKhau As Label
    Friend WithEvents lbLoaiTaiKhoan As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents cbHienThiXoa As CheckBox
End Class
