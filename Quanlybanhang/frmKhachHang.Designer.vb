<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbTen = New System.Windows.Forms.TextBox()
        Me.txbDiachi = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbMaKH = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbTim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTim = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKH
        '
        Me.dgvKH.AllowUserToAddRows = False
        Me.dgvKH.AllowUserToDeleteRows = False
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(421, 97)
        Me.dgvKH.MultiSelect = False
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.ReadOnly = True
        Me.dgvKH.RowHeadersVisible = False
        Me.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKH.Size = New System.Drawing.Size(508, 285)
        Me.dgvKH.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbTen)
        Me.GroupBox1.Controls.Add(Me.txbDiachi)
        Me.GroupBox1.Controls.Add(Me.txbEmail)
        Me.GroupBox1.Controls.Add(Me.txbMaKH)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 125)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'txbTen
        '
        Me.txbTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTen.Location = New System.Drawing.Point(252, 38)
        Me.txbTen.Name = "txbTen"
        Me.txbTen.Size = New System.Drawing.Size(139, 20)
        Me.txbTen.TabIndex = 2
        '
        'txbDiachi
        '
        Me.txbDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDiachi.Location = New System.Drawing.Point(252, 80)
        Me.txbDiachi.Name = "txbDiachi"
        Me.txbDiachi.Size = New System.Drawing.Size(139, 20)
        Me.txbDiachi.TabIndex = 4
        '
        'txbEmail
        '
        Me.txbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEmail.Location = New System.Drawing.Point(57, 80)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(136, 20)
        Me.txbEmail.TabIndex = 3
        '
        'txbMaKH
        '
        Me.txbMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMaKH.Location = New System.Drawing.Point(57, 38)
        Me.txbMaKH.Name = "txbMaKH"
        Me.txbMaKH.Size = New System.Drawing.Size(136, 20)
        Me.txbMaKH.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(207, 41)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Họ tên:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(207, 83)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 13)
        Me.label5.TabIndex = 3
        Me.label5.Text = "Địa chỉ"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(12, 83)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(35, 13)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã KH:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbTim)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbTim)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 115)
        Me.GroupBox2.TabIndex = 13
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
        Me.cmbTim.Items.AddRange(New Object() {"Mã khách hàng", "Tên khách hàng"})
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
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.MenuToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 30)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "QUẢN LÝ KHÁCH HÀNG"
        '
        'btnXoa
        '
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnXoa.Image = Global.frmKhachHang.My.Resources.Resources.DeleteRed
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(267, 228)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(93, 33)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSua.Image = Global.frmKhachHang.My.Resources.Resources.edit
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(168, 228)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(93, 33)
        Me.btnSua.TabIndex = 7
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThem.Image = Global.frmKhachHang.My.Resources.Resources.btn_add_dark
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(69, 228)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(93, 33)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(941, 406)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý khách hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbTen As TextBox
    Friend WithEvents txbDiachi As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbMaKH As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbTim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTim As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label3 As Label
End Class
