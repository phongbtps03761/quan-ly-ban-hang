<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLichSu
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
        Me.dgvLichSu = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTu = New System.Windows.Forms.DateTimePicker()
        Me.dtpDen = New System.Windows.Forms.DateTimePicker()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMa = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.grbInfo = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvLichSu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLichSu
        '
        Me.dgvLichSu.AllowUserToAddRows = False
        Me.dgvLichSu.AllowUserToDeleteRows = False
        Me.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLichSu.Location = New System.Drawing.Point(4, 207)
        Me.dgvLichSu.MultiSelect = False
        Me.dgvLichSu.Name = "dgvLichSu"
        Me.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLichSu.Size = New System.Drawing.Size(819, 354)
        Me.dgvLichSu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(245, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Từ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(445, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Đến:"
        '
        'dtpTu
        '
        Me.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu.Location = New System.Drawing.Point(280, 89)
        Me.dtpTu.Name = "dtpTu"
        Me.dtpTu.Size = New System.Drawing.Size(97, 20)
        Me.dtpTu.TabIndex = 2
        '
        'dtpDen
        '
        Me.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen.Location = New System.Drawing.Point(489, 89)
        Me.dtpDen.Name = "dtpDen"
        Me.dtpDen.Size = New System.Drawing.Size(97, 20)
        Me.dtpDen.TabIndex = 2
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(604, 88)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 22)
        Me.btnXem.TabIndex = 3
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(23, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Chế độ:"
        '
        'cmbMode
        '
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"Hàng hóa", "Khách hàng"})
        Me.cmbMode.Location = New System.Drawing.Point(86, 88)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(133, 21)
        Me.cmbMode.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(622, 159)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 20)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "VNĐ"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(484, 159)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(59, 20)
        Me.lblType.TabIndex = 5
        Me.lblType.Text = "Tổng :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "LỊCH SỬ BÁN HÀNG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(29, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mã:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(156, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tên:"
        '
        'lblMa
        '
        Me.lblMa.AutoSize = True
        Me.lblMa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMa.Location = New System.Drawing.Point(92, 33)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(0, 17)
        Me.lblMa.TabIndex = 9
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTen.Location = New System.Drawing.Point(219, 33)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(0, 17)
        Me.lblTen.TabIndex = 9
        '
        'grbInfo
        '
        Me.grbInfo.Controls.Add(Me.Label4)
        Me.grbInfo.Controls.Add(Me.lblTen)
        Me.grbInfo.Controls.Add(Me.Label6)
        Me.grbInfo.Controls.Add(Me.lblMa)
        Me.grbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbInfo.Location = New System.Drawing.Point(26, 129)
        Me.grbInfo.Name = "grbInfo"
        Me.grbInfo.Size = New System.Drawing.Size(409, 61)
        Me.grbInfo.TabIndex = 10
        Me.grbInfo.TabStop = False
        Me.grbInfo.Text = "Thông tin"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(685, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Export EXCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLichSu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 573)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grbInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.dtpDen)
        Me.Controls.Add(Me.dtpTu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLichSu)
        Me.Name = "frmLichSu"
        Me.Text = "Lịch sử "
        CType(Me.dgvLichSu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbInfo.ResumeLayout(False)
        Me.grbInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLichSu As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTu As DateTimePicker
    Friend WithEvents dtpDen As DateTimePicker
    Friend WithEvents btnXem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMa As Label
    Friend WithEvents lblTen As Label
    Friend WithEvents grbInfo As GroupBox
    Friend WithEvents Button1 As Button
End Class
