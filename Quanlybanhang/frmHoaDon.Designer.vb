<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDon
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbTim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTim = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbTenKH = New System.Windows.Forms.TextBox()
        Me.txbDiachi = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbMaKH = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txbThanhTien = New System.Windows.Forms.TextBox()
        Me.nudSoluong = New System.Windows.Forms.NumericUpDown()
        Me.txbMaLoai = New System.Windows.Forms.TextBox()
        Me.txbTenSP = New System.Windows.Forms.TextBox()
        Me.txbGia = New System.Windows.Forms.TextBox()
        Me.txbMaSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvHD = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudSoluong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbTim)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbTim)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 115)
        Me.GroupBox2.TabIndex = 19
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search:"
        '
        'cmbTim
        '
        Me.cmbTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTim.FormattingEnabled = True
        Me.cmbTim.Items.AddRange(New Object() {"Mã khách hàng", "Tên khách hàng", "Mã sản phẩm", "Tên sản phẩm"})
        Me.cmbTim.Location = New System.Drawing.Point(136, 38)
        Me.cmbTim.Name = "cmbTim"
        Me.cmbTim.Size = New System.Drawing.Size(121, 21)
        Me.cmbTim.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbTenKH)
        Me.GroupBox1.Controls.Add(Me.txbDiachi)
        Me.GroupBox1.Controls.Add(Me.txbEmail)
        Me.GroupBox1.Controls.Add(Me.txbMaKH)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(551, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 230)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'txbTenKH
        '
        Me.txbTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTenKH.Location = New System.Drawing.Point(119, 136)
        Me.txbTenKH.Name = "txbTenKH"
        Me.txbTenKH.ReadOnly = True
        Me.txbTenKH.Size = New System.Drawing.Size(189, 20)
        Me.txbTenKH.TabIndex = 2
        '
        'txbDiachi
        '
        Me.txbDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDiachi.Location = New System.Drawing.Point(119, 178)
        Me.txbDiachi.Name = "txbDiachi"
        Me.txbDiachi.ReadOnly = True
        Me.txbDiachi.Size = New System.Drawing.Size(189, 20)
        Me.txbDiachi.TabIndex = 4
        '
        'txbEmail
        '
        Me.txbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEmail.Location = New System.Drawing.Point(119, 95)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.ReadOnly = True
        Me.txbEmail.Size = New System.Drawing.Size(189, 20)
        Me.txbEmail.TabIndex = 3
        '
        'txbMaKH
        '
        Me.txbMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMaKH.Location = New System.Drawing.Point(119, 53)
        Me.txbMaKH.Name = "txbMaKH"
        Me.txbMaKH.ReadOnly = True
        Me.txbMaKH.Size = New System.Drawing.Size(189, 20)
        Me.txbMaKH.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(69, 139)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Họ tên:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(69, 181)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(43, 13)
        Me.label5.TabIndex = 3
        Me.label5.Text = "Địa chỉ:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(69, 98)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(35, 13)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã KH:"
        '
        'dgvTotal
        '
        Me.dgvTotal.AllowUserToAddRows = False
        Me.dgvTotal.AllowUserToDeleteRows = False
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Location = New System.Drawing.Point(12, 178)
        Me.dgvTotal.MultiSelect = False
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.ReadOnly = True
        Me.dgvTotal.RowHeadersVisible = False
        Me.dgvTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotal.Size = New System.Drawing.Size(508, 457)
        Me.dgvTotal.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnThem)
        Me.GroupBox3.Controls.Add(Me.txbThanhTien)
        Me.GroupBox3.Controls.Add(Me.nudSoluong)
        Me.GroupBox3.Controls.Add(Me.txbMaLoai)
        Me.GroupBox3.Controls.Add(Me.txbTenSP)
        Me.GroupBox3.Controls.Add(Me.txbGia)
        Me.GroupBox3.Controls.Add(Me.txbMaSP)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(551, 306)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 329)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin sản phẩm"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(129, 273)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(99, 40)
        Me.btnThem.TabIndex = 23
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txbThanhTien
        '
        Me.txbThanhTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txbThanhTien.Location = New System.Drawing.Point(119, 244)
        Me.txbThanhTien.Name = "txbThanhTien"
        Me.txbThanhTien.Size = New System.Drawing.Size(189, 20)
        Me.txbThanhTien.TabIndex = 8
        '
        'nudSoluong
        '
        Me.nudSoluong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nudSoluong.Location = New System.Drawing.Point(119, 211)
        Me.nudSoluong.Name = "nudSoluong"
        Me.nudSoluong.Size = New System.Drawing.Size(99, 23)
        Me.nudSoluong.TabIndex = 7
        '
        'txbMaLoai
        '
        Me.txbMaLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txbMaLoai.Location = New System.Drawing.Point(119, 134)
        Me.txbMaLoai.Name = "txbMaLoai"
        Me.txbMaLoai.ReadOnly = True
        Me.txbMaLoai.Size = New System.Drawing.Size(189, 20)
        Me.txbMaLoai.TabIndex = 6
        '
        'txbTenSP
        '
        Me.txbTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTenSP.Location = New System.Drawing.Point(119, 101)
        Me.txbTenSP.Name = "txbTenSP"
        Me.txbTenSP.ReadOnly = True
        Me.txbTenSP.Size = New System.Drawing.Size(189, 20)
        Me.txbTenSP.TabIndex = 2
        '
        'txbGia
        '
        Me.txbGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbGia.Location = New System.Drawing.Point(119, 170)
        Me.txbGia.Name = "txbGia"
        Me.txbGia.ReadOnly = True
        Me.txbGia.Size = New System.Drawing.Size(189, 20)
        Me.txbGia.TabIndex = 3
        '
        'txbMaSP
        '
        Me.txbMaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMaSP.Location = New System.Drawing.Point(119, 59)
        Me.txbMaSP.Name = "txbMaSP"
        Me.txbMaSP.ReadOnly = True
        Me.txbMaSP.Size = New System.Drawing.Size(189, 20)
        Me.txbMaSP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên sản phẩm:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Giá:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Thành tiền"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Số lượng:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Mã loại sản phẩm:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Mã sản phẩm:"
        '
        'dgvHD
        '
        Me.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHD.Location = New System.Drawing.Point(875, 72)
        Me.dgvHD.Name = "dgvHD"
        Me.dgvHD.Size = New System.Drawing.Size(660, 563)
        Me.dgvHD.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(670, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 30)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "HÓA ĐƠN"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1547, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1547, 653)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvHD)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvTotal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa đơn"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudSoluong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbTim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTim As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbTenKH As TextBox
    Friend WithEvents txbDiachi As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbMaKH As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTotal As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txbMaLoai As TextBox
    Friend WithEvents txbTenSP As TextBox
    Friend WithEvents txbGia As TextBox
    Friend WithEvents txbMaSP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nudSoluong As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txbThanhTien As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvHD As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
