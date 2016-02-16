<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_sex = New System.Windows.Forms.Label()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.txt_ComfirmPWD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_userId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_SaveUser = New System.Windows.Forms.Button()
        Me.rdb_Female = New System.Windows.Forms.RadioButton()
        Me.rdb_Male = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_User = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_searchtext = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_password.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_password.Location = New System.Drawing.Point(693, 79)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(328, 35)
        Me.txt_password.TabIndex = 41
        Me.txt_password.Text = "បញ្ចូលលេខសម្ងាត់អ្នកប្រើប្រាស់......"
        Me.txt_password.UseSystemPasswordChar = True
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(578, 33)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 27)
        Me.label4.TabIndex = 40
        Me.label4.Text = "លេខសម្ងាត់"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_username.Location = New System.Drawing.Point(250, 207)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(294, 35)
        Me.txt_username.TabIndex = 39
        Me.txt_username.Text = "បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់......"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Black
        Me.lbl_username.Location = New System.Drawing.Point(158, 208)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(87, 27)
        Me.lbl_username.TabIndex = 38
        Me.lbl_username.Text = "អ្នកប្រើប្រាស់"
        '
        'txt_address
        '
        Me.txt_address.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_address.Location = New System.Drawing.Point(693, 164)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(328, 91)
        Me.txt_address.TabIndex = 37
        Me.txt_address.Text = "បញ្ចូលអាស័ដ្ឋានអ្នកប្រើប្រាស់......"
        '
        'lbl_address
        '
        Me.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Black
        Me.lbl_address.Location = New System.Drawing.Point(577, 119)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(82, 27)
        Me.lbl_address.TabIndex = 36
        Me.lbl_address.Text = "អាស័យដ្ឋាន"
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_phone.Location = New System.Drawing.Point(250, 164)
        Me.txt_phone.Multiline = True
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(294, 35)
        Me.txt_phone.TabIndex = 35
        Me.txt_phone.Text = "បញ្ចូលលេខទូរស័ព្ទអ្នកប្រើប្រាស់......"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.ForeColor = System.Drawing.Color.Black
        Me.lbl_phone.Location = New System.Drawing.Point(161, 163)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(82, 27)
        Me.lbl_phone.TabIndex = 34
        Me.lbl_phone.Text = "លេខទូរស័ព្វ"
        '
        'lbl_sex
        '
        Me.lbl_sex.AutoSize = True
        Me.lbl_sex.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sex.ForeColor = System.Drawing.Color.Black
        Me.lbl_sex.Location = New System.Drawing.Point(200, 119)
        Me.lbl_sex.Name = "lbl_sex"
        Me.lbl_sex.Size = New System.Drawing.Size(37, 27)
        Me.lbl_sex.TabIndex = 32
        Me.lbl_sex.Text = "ភេទ"
        '
        'txt_fullname
        '
        Me.txt_fullname.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fullname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_fullname.Location = New System.Drawing.Point(250, 80)
        Me.txt_fullname.Multiline = True
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(294, 35)
        Me.txt_fullname.TabIndex = 31
        Me.txt_fullname.Text = "បញ្ចូលឈ្មោះពេញអ្នកប្រើប្រាស់......"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.Black
        Me.lbl_fullname.Location = New System.Drawing.Point(41, 80)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(198, 27)
        Me.lbl_fullname.TabIndex = 30
        Me.lbl_fullname.Text = "ឈ្មោះពេញ(គោត្តនាម និង នាម)"
        '
        'txt_ComfirmPWD
        '
        Me.txt_ComfirmPWD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComfirmPWD.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ComfirmPWD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_ComfirmPWD.Location = New System.Drawing.Point(693, 121)
        Me.txt_ComfirmPWD.Multiline = True
        Me.txt_ComfirmPWD.Name = "txt_ComfirmPWD"
        Me.txt_ComfirmPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ComfirmPWD.Size = New System.Drawing.Size(328, 35)
        Me.txt_ComfirmPWD.TabIndex = 44
        Me.txt_ComfirmPWD.Text = "ផ្ទៀងផ្ទាត់លេខសម្ងាត់អ្នកប្រើប្រាស់......"
        Me.txt_ComfirmPWD.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(526, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 27)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "ផ្ទៀងផ្ទាត់លេខសំងាត់"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_userId)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_SaveUser)
        Me.GroupBox1.Controls.Add(Me.rdb_Female)
        Me.GroupBox1.Controls.Add(Me.rdb_Male)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_address)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(27, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1011, 268)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ព័ត៍មានរបស់អ្នកប្រើប្រាស!!!"
        '
        'txt_userId
        '
        Me.txt_userId.Location = New System.Drawing.Point(223, 207)
        Me.txt_userId.Name = "txt_userId"
        Me.txt_userId.Size = New System.Drawing.Size(294, 37)
        Me.txt_userId.TabIndex = 55
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Bokor", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.VBLoan.My.Resources.Resources.group_error_icon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(884, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 38)
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "បោះបង់"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Font = New System.Drawing.Font("Khmer OS Bokor", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = Global.VBLoan.My.Resources.Resources.group_delete_icon
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(767, 220)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(111, 38)
        Me.btn_delete.TabIndex = 53
        Me.btn_delete.Text = "លុប"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.Font = New System.Drawing.Font("Khmer OS Bokor", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Image = Global.VBLoan.My.Resources.Resources.Edit_validated_icon
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(644, 220)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(111, 38)
        Me.btn_edit.TabIndex = 52
        Me.btn_edit.Text = "រក្សាទុក"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_SaveUser
        '
        Me.btn_SaveUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SaveUser.Font = New System.Drawing.Font("Khmer OS Bokor", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SaveUser.Image = Global.VBLoan.My.Resources.Resources.Male_user_add_icon
        Me.btn_SaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SaveUser.Location = New System.Drawing.Point(527, 221)
        Me.btn_SaveUser.Name = "btn_SaveUser"
        Me.btn_SaveUser.Size = New System.Drawing.Size(111, 38)
        Me.btn_SaveUser.TabIndex = 51
        Me.btn_SaveUser.Text = "រក្សាទុក"
        Me.btn_SaveUser.UseVisualStyleBackColor = True
        '
        'rdb_Female
        '
        Me.rdb_Female.AutoSize = True
        Me.rdb_Female.Location = New System.Drawing.Point(325, 80)
        Me.rdb_Female.Name = "rdb_Female"
        Me.rdb_Female.Size = New System.Drawing.Size(52, 33)
        Me.rdb_Female.TabIndex = 50
        Me.rdb_Female.TabStop = True
        Me.rdb_Female.Text = "ស្រី"
        Me.rdb_Female.UseVisualStyleBackColor = True
        '
        'rdb_Male
        '
        Me.rdb_Male.AutoSize = True
        Me.rdb_Male.Checked = True
        Me.rdb_Male.Location = New System.Drawing.Point(227, 81)
        Me.rdb_Male.Name = "rdb_Male"
        Me.rdb_Male.Size = New System.Drawing.Size(63, 33)
        Me.rdb_Male.TabIndex = 49
        Me.rdb_Male.TabStop = True
        Me.rdb_Male.Text = "ប្រុស"
        Me.rdb_Male.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgv_User)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 229)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'dgv_User
        '
        Me.dgv_User.AllowUserToAddRows = False
        Me.dgv_User.AllowUserToResizeColumns = False
        Me.dgv_User.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_User.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_User.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_User.ColumnHeadersHeight = 35
        Me.dgv_User.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.user_id, Me.fullname, Me.gender, Me.phone, Me.address})
        Me.dgv_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_User.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_User.Location = New System.Drawing.Point(0, 17)
        Me.dgv_User.Name = "dgv_User"
        Me.dgv_User.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_User.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_User.RowHeadersVisible = False
        Me.dgv_User.RowHeadersWidth = 60
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_User.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_User.Size = New System.Drawing.Size(1011, 212)
        Me.dgv_User.TabIndex = 47
        '
        'no
        '
        Me.no.HeaderText = "​ល.រ"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.ToolTipText = "RNO"
        '
        'user_id
        '
        Me.user_id.HeaderText = "user_id"
        Me.user_id.Name = "user_id"
        Me.user_id.ReadOnly = True
        Me.user_id.Visible = False
        '
        'fullname
        '
        Me.fullname.HeaderText = "ឈ្មោះអ្នកប្រើប្រាស់"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.ToolTipText = "User Name"
        '
        'gender
        '
        Me.gender.HeaderText = "ភេទ"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        Me.gender.ToolTipText = "Gender"
        '
        'phone
        '
        Me.phone.HeaderText = "លេខទូរស័ព្ទ"
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.ToolTipText = "Telephone"
        '
        'address
        '
        Me.address.HeaderText = "អាស័យដ្ឋាន"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.ToolTipText = "Address"
        '
        'txt_searchtext
        '
        Me.txt_searchtext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_searchtext.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchtext.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_searchtext.Location = New System.Drawing.Point(603, 12)
        Me.txt_searchtext.Multiline = True
        Me.txt_searchtext.Name = "txt_searchtext"
        Me.txt_searchtext.Size = New System.Drawing.Size(342, 35)
        Me.txt_searchtext.TabIndex = 49
        Me.txt_searchtext.Text = "បញ្ចូលឈ្មោះ,លេខទូរស័ព្ទ,អាស័ដ្ឋាន....."
        Me.txt_searchtext.UseSystemPasswordChar = True
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Font = New System.Drawing.Font("Khmer OS Bokor", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Image = Global.VBLoan.My.Resources.Resources.zoom_refresh_icon1
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_search.Location = New System.Drawing.Point(910, 12)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(111, 35)
        Me.btn_search.TabIndex = 55
        Me.btn_search.Text = "ស្វែងរក"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 562)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_searchtext)
        Me.Controls.Add(Me.txt_ComfirmPWD)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.lbl_sex)
        Me.Controls.Add(Me.txt_fullname)
        Me.Controls.Add(Me.lbl_fullname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_user"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txt_password As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents lbl_username As System.Windows.Forms.Label
    Private WithEvents txt_address As System.Windows.Forms.TextBox
    Private WithEvents lbl_address As System.Windows.Forms.Label
    Private WithEvents txt_phone As System.Windows.Forms.TextBox
    Private WithEvents lbl_phone As System.Windows.Forms.Label
    Private WithEvents lbl_sex As System.Windows.Forms.Label
    Private WithEvents txt_fullname As System.Windows.Forms.TextBox
    Private WithEvents lbl_fullname As System.Windows.Forms.Label
    Private WithEvents txt_ComfirmPWD As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_User As System.Windows.Forms.DataGridView
    Private WithEvents txt_searchtext As System.Windows.Forms.TextBox
    Friend WithEvents rdb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fullname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_SaveUser As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_userId As System.Windows.Forms.TextBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
