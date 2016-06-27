<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSanPham
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
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txbMaSP = New System.Windows.Forms.TextBox()
        Me.txbGia = New System.Windows.Forms.TextBox()
        Me.txbTen = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMaLoai = New System.Windows.Forms.ComboBox()
        Me.txbTenSP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbTim = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTim = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSP
        '
        Me.dgvSP.AllowUserToAddRows = False
        Me.dgvSP.AllowUserToDeleteRows = False
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(471, 86)
        Me.dgvSP.MultiSelect = False
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.ReadOnly = True
        Me.dgvSP.RowHeadersVisible = False
        Me.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSP.Size = New System.Drawing.Size(493, 405)
        Me.dgvSP.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(63, 124)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(26, 13)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Giá:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(11, 83)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(78, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Tên sản phẩm:"
        '
        'txbMaSP
        '
        Me.txbMaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMaSP.Location = New System.Drawing.Point(92, 38)
        Me.txbMaSP.Name = "txbMaSP"
        Me.txbMaSP.Size = New System.Drawing.Size(81, 20)
        Me.txbMaSP.TabIndex = 1
        '
        'txbGia
        '
        Me.txbGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbGia.Location = New System.Drawing.Point(92, 121)
        Me.txbGia.Name = "txbGia"
        Me.txbGia.Size = New System.Drawing.Size(136, 20)
        Me.txbGia.TabIndex = 3
        '
        'txbTen
        '
        Me.txbTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTen.Location = New System.Drawing.Point(92, 80)
        Me.txbTen.Name = "txbTen"
        Me.txbTen.Size = New System.Drawing.Size(136, 20)
        Me.txbTen.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMaLoai)
        Me.GroupBox1.Controls.Add(Me.txbTen)
        Me.GroupBox1.Controls.Add(Me.txbGia)
        Me.GroupBox1.Controls.Add(Me.txbTenSP)
        Me.GroupBox1.Controls.Add(Me.txbMaSP)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 188)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sản phẩm"
        '
        'cmbMaLoai
        '
        Me.cmbMaLoai.FormattingEnabled = True
        Me.cmbMaLoai.Location = New System.Drawing.Point(348, 33)
        Me.cmbMaLoai.Name = "cmbMaLoai"
        Me.cmbMaLoai.Size = New System.Drawing.Size(74, 28)
        Me.cmbMaLoai.TabIndex = 6
        '
        'txbTenSP
        '
        Me.txbTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTenSP.Location = New System.Drawing.Point(252, 121)
        Me.txbTenSP.Name = "txbTenSP"
        Me.txbTenSP.ReadOnly = True
        Me.txbTenSP.Size = New System.Drawing.Size(170, 20)
        Me.txbTenSP.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tên loại sản phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã loại sản phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "THÔNG TIN SẢN PHẨM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbTim)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbTim)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(37, 376)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 115)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tìm "
        '
        'txbTim
        '
        Me.txbTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTim.Location = New System.Drawing.Point(136, 76)
        Me.txbTim.Name = "txbTim"
        Me.txbTim.Size = New System.Drawing.Size(195, 20)
        Me.txbTim.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Search:"
        '
        'cmbTim
        '
        Me.cmbTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTim.FormattingEnabled = True
        Me.cmbTim.Items.AddRange(New Object() {"Mã sản phẩm", "Tên sản phẩm"})
        Me.cmbTim.Location = New System.Drawing.Point(136, 38)
        Me.cmbTim.Name = "cmbTim"
        Me.cmbTim.Size = New System.Drawing.Size(121, 21)
        Me.cmbTim.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.MenuToolStripMenuItem.Text = "Exit"
        '
        'btnXoa
        '
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnXoa.Image = Global.frmKhachHang.My.Resources.Resources.DeleteRed
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(325, 300)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(109, 33)
        Me.btnXoa.TabIndex = 18
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSua.Image = Global.frmKhachHang.My.Resources.Resources.edit
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(185, 300)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(109, 33)
        Me.btnSua.TabIndex = 19
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThem.Image = Global.frmKhachHang.My.Resources.Resources.btn_add_dark
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(51, 300)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(109, 33)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 515)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSanPham"
        Me.Text = "Thông tin sản phảm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents dgvSP As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents label6 As Label
    Friend WithEvents txbMaSP As TextBox
    Friend WithEvents txbGia As TextBox
    Friend WithEvents txbTen As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbMaLoai As ComboBox
    Friend WithEvents txbTenSP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbTim As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTim As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
End Class
