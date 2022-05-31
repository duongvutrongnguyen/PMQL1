<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMHChinh
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThongTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NguoiDungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanLyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lThongTinNguoiDung = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Test1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThongTinToolStripMenuItem, Me.QuanLyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThongTinToolStripMenuItem
        '
        Me.ThongTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SanPhamToolStripMenuItem, Me.NguoiDungToolStripMenuItem})
        Me.ThongTinToolStripMenuItem.Name = "ThongTinToolStripMenuItem"
        Me.ThongTinToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ThongTinToolStripMenuItem.Text = "Quan ly"
        '
        'SanPhamToolStripMenuItem
        '
        Me.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem"
        Me.SanPhamToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.SanPhamToolStripMenuItem.Text = "San pham"
        '
        'NguoiDungToolStripMenuItem
        '
        Me.NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem"
        Me.NguoiDungToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.NguoiDungToolStripMenuItem.Text = "Nguoi dung"
        '
        'QuanLyToolStripMenuItem
        '
        Me.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem"
        Me.QuanLyToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.QuanLyToolStripMenuItem.Text = "Thong tin"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.lThongTinNguoiDung)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 34)
        Me.Panel1.TabIndex = 2
        '
        'lThongTinNguoiDung
        '
        Me.lThongTinNguoiDung.AutoSize = True
        Me.lThongTinNguoiDung.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lThongTinNguoiDung.Dock = System.Windows.Forms.DockStyle.Right
        Me.lThongTinNguoiDung.Location = New System.Drawing.Point(747, 0)
        Me.lThongTinNguoiDung.Name = "lThongTinNguoiDung"
        Me.lThongTinNguoiDung.Size = New System.Drawing.Size(53, 20)
        Me.lThongTinNguoiDung.TabIndex = 1
        Me.lThongTinNguoiDung.Text = "Label1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 28)
        '
        'Test1ToolStripMenuItem
        '
        Me.Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Me.Test1ToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.Test1ToolStripMenuItem.Text = "test 1"
        '
        'frmMHChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMHChinh"
        Me.Text = "Ung dung quan ly kho"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThongTinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuanLyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SanPhamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NguoiDungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lThongTinNguoiDung As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Test1ToolStripMenuItem As ToolStripMenuItem
End Class
