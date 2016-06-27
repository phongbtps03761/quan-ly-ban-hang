<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoaiSP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbTenLoai = New System.Windows.Forms.TextBox()
        Me.txbMaLoai = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvLoaiSP = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvLoaiSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "CÁC LOẠI SẢN PHẨM"
        '
        'txbTenLoai
        '
        Me.txbTenLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTenLoai.Location = New System.Drawing.Point(64, 96)
        Me.txbTenLoai.Name = "txbTenLoai"
        Me.txbTenLoai.Size = New System.Drawing.Size(136, 20)
        Me.txbTenLoai.TabIndex = 2
        '
        'txbMaLoai
        '
        Me.txbMaLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMaLoai.Location = New System.Drawing.Point(64, 70)
        Me.txbMaLoai.Name = "txbMaLoai"
        Me.txbMaLoai.Size = New System.Drawing.Size(136, 20)
        Me.txbMaLoai.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(16, 99)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Tên loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã loại:"
        '
        'btnXoa
        '
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnXoa.Image = Global.frmKhachHang.My.Resources.Resources.DeleteRed
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(64, 220)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(136, 33)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSua.Image = Global.frmKhachHang.My.Resources.Resources.edit
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(64, 181)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(136, 33)
        Me.btnSua.TabIndex = 18
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThem.Image = Global.frmKhachHang.My.Resources.Resources.btn_add_dark
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(64, 142)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(136, 33)
        Me.btnThem.TabIndex = 16
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvLoaiSP
        '
        Me.dgvLoaiSP.AllowUserToAddRows = False
        Me.dgvLoaiSP.AllowUserToDeleteRows = False
        Me.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoaiSP.Location = New System.Drawing.Point(207, 70)
        Me.dgvLoaiSP.MultiSelect = False
        Me.dgvLoaiSP.Name = "dgvLoaiSP"
        Me.dgvLoaiSP.ReadOnly = True
        Me.dgvLoaiSP.RowHeadersVisible = False
        Me.dgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoaiSP.Size = New System.Drawing.Size(271, 183)
        Me.dgvLoaiSP.TabIndex = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.MenuToolStripMenuItem.Text = "Exit"
        '
        'frmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 270)
        Me.Controls.Add(Me.dgvLoaiSP)
        Me.Controls.Add(Me.txbTenLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbMaLoai)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLoaiSP"
        Me.Text = "Loại sản phẩm"
        CType(Me.dgvLoaiSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txbTenLoai As TextBox
    Friend WithEvents txbMaLoai As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvLoaiSP As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
End Class
