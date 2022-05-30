<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.lbTenDangNhap = New System.Windows.Forms.Label()
        Me.lbMatKhau = New System.Windows.Forms.Label()
        Me.tbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.bDangNhap = New System.Windows.Forms.Button()
        Me.bThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTenDangNhap
        '
        Me.lbTenDangNhap.AutoSize = True
        Me.lbTenDangNhap.Location = New System.Drawing.Point(112, 87)
        Me.lbTenDangNhap.Name = "lbTenDangNhap"
        Me.lbTenDangNhap.Size = New System.Drawing.Size(107, 20)
        Me.lbTenDangNhap.TabIndex = 0
        Me.lbTenDangNhap.Text = "Ten dang nhap"
        '
        'lbMatKhau
        '
        Me.lbMatKhau.AutoSize = True
        Me.lbMatKhau.Location = New System.Drawing.Point(112, 152)
        Me.lbMatKhau.Name = "lbMatKhau"
        Me.lbMatKhau.Size = New System.Drawing.Size(70, 20)
        Me.lbMatKhau.TabIndex = 1
        Me.lbMatKhau.Text = "Mat khau"
        '
        'tbTenDangNhap
        '
        Me.tbTenDangNhap.Location = New System.Drawing.Point(224, 84)
        Me.tbTenDangNhap.Name = "tbTenDangNhap"
        Me.tbTenDangNhap.Size = New System.Drawing.Size(125, 27)
        Me.tbTenDangNhap.TabIndex = 2
        '
        'tbMatKhau
        '
        Me.tbMatKhau.Location = New System.Drawing.Point(224, 149)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMatKhau.Size = New System.Drawing.Size(125, 27)
        Me.tbMatKhau.TabIndex = 3
        '
        'bDangNhap
        '
        Me.bDangNhap.Location = New System.Drawing.Point(155, 242)
        Me.bDangNhap.Name = "bDangNhap"
        Me.bDangNhap.Size = New System.Drawing.Size(94, 29)
        Me.bDangNhap.TabIndex = 4
        Me.bDangNhap.Text = "Dang nhap"
        Me.bDangNhap.UseVisualStyleBackColor = True
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(336, 242)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(94, 29)
        Me.bThoat.TabIndex = 5
        Me.bThoat.Text = "Thoat"
        Me.bThoat.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bDangNhap)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.tbTenDangNhap)
        Me.Controls.Add(Me.lbMatKhau)
        Me.Controls.Add(Me.lbTenDangNhap)
        Me.Name = "frmDangNhap"
        Me.Text = "frmDangNhap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTenDangNhap As Label
    Friend WithEvents lbMatKhau As Label
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents bDangNhap As Button
    Friend WithEvents bThoat As Button
End Class
