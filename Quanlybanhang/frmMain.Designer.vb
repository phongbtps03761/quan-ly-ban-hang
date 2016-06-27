<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngHóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiHàngHóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtHàngHóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinhVươngM4UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txbDate = New System.Windows.Forms.TextBox()
        Me.txbTime = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LịchSửToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.HàngHóaToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.LịchSửToolStripMenuItem, Me.GameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'HàngHóaToolStripMenuItem
        '
        Me.HàngHóaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoạiHàngHóaToolStripMenuItem, Me.ChiTiếtHàngHóaToolStripMenuItem})
        Me.HàngHóaToolStripMenuItem.Name = "HàngHóaToolStripMenuItem"
        Me.HàngHóaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.HàngHóaToolStripMenuItem.Text = "Hàng hóa"
        '
        'LoạiHàngHóaToolStripMenuItem
        '
        Me.LoạiHàngHóaToolStripMenuItem.Name = "LoạiHàngHóaToolStripMenuItem"
        Me.LoạiHàngHóaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LoạiHàngHóaToolStripMenuItem.Text = "Loại hàng hóa"
        '
        'ChiTiếtHàngHóaToolStripMenuItem
        '
        Me.ChiTiếtHàngHóaToolStripMenuItem.Name = "ChiTiếtHàngHóaToolStripMenuItem"
        Me.ChiTiếtHàngHóaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ChiTiếtHàngHóaToolStripMenuItem.Text = "Chi tiết hàng hóa"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaroToolStripMenuItem, Me.MusicToolStripMenuItem, Me.PhimToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.GameToolStripMenuItem.Text = "Giải Trí"
        '
        'CaroToolStripMenuItem
        '
        Me.CaroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaroToolStripMenuItem1})
        Me.CaroToolStripMenuItem.Name = "CaroToolStripMenuItem"
        Me.CaroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CaroToolStripMenuItem.Text = "Game"
        '
        'CaroToolStripMenuItem1
        '
        Me.CaroToolStripMenuItem1.Name = "CaroToolStripMenuItem1"
        Me.CaroToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.CaroToolStripMenuItem1.Text = "Caro"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinhVươngM4UToolStripMenuItem})
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'MinhVươngM4UToolStripMenuItem
        '
        Me.MinhVươngM4UToolStripMenuItem.Name = "MinhVươngM4UToolStripMenuItem"
        Me.MinhVươngM4UToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MinhVươngM4UToolStripMenuItem.Text = "EDM"
        '
        'PhimToolStripMenuItem
        '
        Me.PhimToolStripMenuItem.Name = "PhimToolStripMenuItem"
        Me.PhimToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PhimToolStripMenuItem.Text = "Facebook"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Họ và tên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bùi Tuấn Phong"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MSSV:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PS03761"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(243, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Lớp:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "PT11101"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Info
        Me.Label8.Location = New System.Drawing.Point(236, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 29)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = " QUẢN LÝ BÁN HÀNG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 173)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sinh viên"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.frmKhachHang.My.Resources.Resources.ava
        Me.PictureBox2.Location = New System.Drawing.Point(57, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.frmKhachHang.My.Resources.Resources.Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txbDate
        '
        Me.txbDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txbDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.txbDate.Enabled = False
        Me.txbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txbDate.ForeColor = System.Drawing.Color.Blue
        Me.txbDate.Location = New System.Drawing.Point(259, 69)
        Me.txbDate.Name = "txbDate"
        Me.txbDate.ReadOnly = True
        Me.txbDate.Size = New System.Drawing.Size(244, 16)
        Me.txbDate.TabIndex = 5
        Me.txbDate.Text = "NGÀY"
        Me.txbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txbTime
        '
        Me.txbTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txbTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.txbTime.Enabled = False
        Me.txbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txbTime.ForeColor = System.Drawing.Color.Blue
        Me.txbTime.Location = New System.Drawing.Point(305, 91)
        Me.txbTime.Name = "txbTime"
        Me.txbTime.ReadOnly = True
        Me.txbTime.Size = New System.Drawing.Size(159, 16)
        Me.txbTime.TabIndex = 5
        Me.txbTime.Text = "GIỜ"
        Me.txbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LịchSửToolStripMenuItem
        '
        Me.LịchSửToolStripMenuItem.Name = "LịchSửToolStripMenuItem"
        Me.LịchSửToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.LịchSửToolStripMenuItem.Text = "Lịch sử"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 353)
        Me.Controls.Add(Me.txbTime)
        Me.Controls.Add(Me.txbDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Quản lý bán hàng"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HàngHóaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoạiHàngHóaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiTiếtHàngHóaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinhVươngM4UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txbDate As TextBox
    Friend WithEvents txbTime As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LịchSửToolStripMenuItem As ToolStripMenuItem
End Class
