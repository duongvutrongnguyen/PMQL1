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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.cbLoaiTaiKhoan = New System.Windows.Forms.ComboBox()
        Me.lbTen = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbNamSinh = New System.Windows.Forms.Label()
        Me.lbTenDangNhap = New System.Windows.Forms.Label()
        Me.lbMatKhau = New System.Windows.Forms.Label()
        Me.lbLoaiTaiKhoan = New System.Windows.Forms.Label()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.bSua = New System.Windows.Forms.Button()
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(836, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(836, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(836, 159)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 27)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(836, 216)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(125, 27)
        Me.TextBox4.TabIndex = 1
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(836, 276)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(125, 27)
        Me.TextBox5.TabIndex = 1
        '
        'cbLoaiTaiKhoan
        '
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
        'bSua
        '
        Me.bSua.Location = New System.Drawing.Point(981, 401)
        Me.bSua.Name = "bSua"
        Me.bSua.Size = New System.Drawing.Size(94, 29)
        Me.bSua.TabIndex = 4
        Me.bSua.Text = "Sua"
        Me.bSua.UseVisualStyleBackColor = True
        '
        'frmNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 488)
        Me.Controls.Add(Me.bSua)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.lbLoaiTaiKhoan)
        Me.Controls.Add(Me.lbMatKhau)
        Me.Controls.Add(Me.lbTenDangNhap)
        Me.Controls.Add(Me.lbNamSinh)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbTen)
        Me.Controls.Add(Me.cbLoaiTaiKhoan)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvDSNguoiDung)
        Me.Name = "frmNguoiDung"
        Me.Text = "frmNguoiDung"
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDSNguoiDung As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents cbLoaiTaiKhoan As ComboBox
    Friend WithEvents lbTen As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbNamSinh As Label
    Friend WithEvents lbTenDangNhap As Label
    Friend WithEvents lbMatKhau As Label
    Friend WithEvents lbLoaiTaiKhoan As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents bSua As Button
End Class
