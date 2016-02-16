<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_all_loan
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.panel_content = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbl_grid_user = New System.Windows.Forms.DataGridView()
        Me.auto_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pay_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_brak_derm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_rate_money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_decreasing = New System.Windows.Forms.Label()
        Me.txt_decreasing = New System.Windows.Forms.TextBox()
        Me.txt_first_pay_back1 = New System.Windows.Forms.TextBox()
        Me.lbl_first_pay_back1 = New System.Windows.Forms.Label()
        Me.txt_open_date1 = New System.Windows.Forms.TextBox()
        Me.lbl_open_date1 = New System.Windows.Forms.Label()
        Me.txt_rate_money1 = New System.Windows.Forms.TextBox()
        Me.txt_loan_duration1 = New System.Windows.Forms.TextBox()
        Me.lbl_rate_money1 = New System.Windows.Forms.Label()
        Me.lbl_loan_duration1 = New System.Windows.Forms.Label()
        Me.txt_loan_amount1 = New System.Windows.Forms.TextBox()
        Me.lbl_loan_amount1 = New System.Windows.Forms.Label()
        Me.txt_shift = New System.Windows.Forms.TextBox()
        Me.lbl_accountid = New System.Windows.Forms.Label()
        Me.txt_rate_money = New System.Windows.Forms.TextBox()
        Me.lbl_shift = New System.Windows.Forms.Label()
        Me.txt_loan_duration = New System.Windows.Forms.TextBox()
        Me.lbl_rate_money = New System.Windows.Forms.Label()
        Me.txt_loan_amount = New System.Windows.Forms.TextBox()
        Me.lbl_loan_duration = New System.Windows.Forms.Label()
        Me.lbl_loan_amount = New System.Windows.Forms.Label()
        Me.txt_accountid = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.com_money_type = New System.Windows.Forms.ComboBox()
        Me.lbl_money_type = New System.Windows.Forms.Label()
        Me.txt_first_pay_back = New System.Windows.Forms.TextBox()
        Me.lbl_first_pay_back = New System.Windows.Forms.Label()
        Me.txt_open_date = New System.Windows.Forms.TextBox()
        Me.lbl_open_date = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.combo_loaner_name = New System.Windows.Forms.ComboBox()
        Me.lbl_loaner_name = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.panel_content.SuspendLayout()
        CType(Me.tbl_grid_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.SystemColors.HotTrack
        Me.panel_header.Controls.Add(Me.txt_search)
        Me.panel_header.Controls.Add(Me.Label4)
        Me.panel_header.Controls.Add(Me.Button1)
        Me.panel_header.Controls.Add(Me.Label1)
        Me.panel_header.Controls.Add(Me.lbl_logo)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1341, 100)
        Me.panel_header.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_search.Font = New System.Drawing.Font("Khmer OS Battambang", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_search.Location = New System.Drawing.Point(701, 38)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(429, 33)
        Me.txt_search.TabIndex = 239
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(1131, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.Label4.Size = New System.Drawing.Size(81, 33)
        Me.Label4.TabIndex = 239
        Me.Label4.Text = "ស្វែងរក"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Image = Global.VBLoan.My.Resources.Resources.XXXX
        Me.Button1.Location = New System.Drawing.Point(1318, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = Global.VBLoan.My.Resources.Resources.ការកម្ចីប្រាក់1
        Me.Label1.Location = New System.Drawing.Point(130, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(100, 40, 110, 40)
        Me.Label1.Size = New System.Drawing.Size(210, 93)
        Me.Label1.TabIndex = 1
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_logo.Image = Global.VBLoan.My.Resources.Resources._8_People
        Me.lbl_logo.Location = New System.Drawing.Point(4, 4)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Padding = New System.Windows.Forms.Padding(60, 40, 60, 40)
        Me.lbl_logo.Size = New System.Drawing.Size(120, 93)
        Me.lbl_logo.TabIndex = 0
        '
        'panel_content
        '
        Me.panel_content.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_content.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_content.Controls.Add(Me.btn_save)
        Me.panel_content.Controls.Add(Me.Label3)
        Me.panel_content.Controls.Add(Me.Label2)
        Me.panel_content.Controls.Add(Me.tbl_grid_user)
        Me.panel_content.Controls.Add(Me.lbl_decreasing)
        Me.panel_content.Controls.Add(Me.txt_decreasing)
        Me.panel_content.Controls.Add(Me.txt_first_pay_back1)
        Me.panel_content.Controls.Add(Me.lbl_first_pay_back1)
        Me.panel_content.Controls.Add(Me.txt_open_date1)
        Me.panel_content.Controls.Add(Me.lbl_open_date1)
        Me.panel_content.Controls.Add(Me.txt_rate_money1)
        Me.panel_content.Controls.Add(Me.txt_loan_duration1)
        Me.panel_content.Controls.Add(Me.lbl_rate_money1)
        Me.panel_content.Controls.Add(Me.lbl_loan_duration1)
        Me.panel_content.Controls.Add(Me.txt_loan_amount1)
        Me.panel_content.Controls.Add(Me.lbl_loan_amount1)
        Me.panel_content.Controls.Add(Me.txt_shift)
        Me.panel_content.Controls.Add(Me.lbl_accountid)
        Me.panel_content.Controls.Add(Me.txt_rate_money)
        Me.panel_content.Controls.Add(Me.lbl_shift)
        Me.panel_content.Controls.Add(Me.txt_loan_duration)
        Me.panel_content.Controls.Add(Me.lbl_rate_money)
        Me.panel_content.Controls.Add(Me.txt_loan_amount)
        Me.panel_content.Controls.Add(Me.lbl_loan_duration)
        Me.panel_content.Controls.Add(Me.lbl_loan_amount)
        Me.panel_content.Controls.Add(Me.txt_accountid)
        Me.panel_content.Controls.Add(Me.txt_address)
        Me.panel_content.Controls.Add(Me.lbl_address)
        Me.panel_content.Controls.Add(Me.com_money_type)
        Me.panel_content.Controls.Add(Me.lbl_money_type)
        Me.panel_content.Controls.Add(Me.txt_first_pay_back)
        Me.panel_content.Controls.Add(Me.lbl_first_pay_back)
        Me.panel_content.Controls.Add(Me.txt_open_date)
        Me.panel_content.Controls.Add(Me.lbl_open_date)
        Me.panel_content.Controls.Add(Me.txt_phone)
        Me.panel_content.Controls.Add(Me.lbl_phone)
        Me.panel_content.Controls.Add(Me.combo_loaner_name)
        Me.panel_content.Controls.Add(Me.lbl_loaner_name)
        Me.panel_content.Controls.Add(Me.txt_username)
        Me.panel_content.Controls.Add(Me.lbl_username)
        Me.panel_content.Location = New System.Drawing.Point(0, 100)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Size = New System.Drawing.Size(1341, 816)
        Me.panel_content.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_save.Location = New System.Drawing.Point(1057, 262)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btn_save.Size = New System.Drawing.Size(257, 37)
        Me.btn_save.TabIndex = 201
        Me.btn_save.Text = "បន្ថែម"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Image = Global.VBLoan.My.Resources.Resources.ico_list_all_loaner
        Me.Label3.Location = New System.Drawing.Point(2, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(40, 28, 40, 28)
        Me.Label3.Size = New System.Drawing.Size(80, 69)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Image = Global.VBLoan.My.Resources.Resources.ការកម្ចីប្រាក់2
        Me.Label2.Location = New System.Drawing.Point(85, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(100, 20, 110, 20)
        Me.Label2.Size = New System.Drawing.Size(210, 53)
        Me.Label2.TabIndex = 2
        '
        'tbl_grid_user
        '
        Me.tbl_grid_user.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbl_grid_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tbl_grid_user.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tbl_grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_grid_user.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.auto_num, Me.col_pay_date, Me.col_brak_derm, Me.col_rate_money})
        Me.tbl_grid_user.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tbl_grid_user.DefaultCellStyle = DataGridViewCellStyle2
        Me.tbl_grid_user.Location = New System.Drawing.Point(-1, 412)
        Me.tbl_grid_user.Name = "tbl_grid_user"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tbl_grid_user.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tbl_grid_user.Size = New System.Drawing.Size(1341, 403)
        Me.tbl_grid_user.TabIndex = 238
        '
        'auto_num
        '
        Me.auto_num.HeaderText = "ល.រ"
        Me.auto_num.Name = "auto_num"
        Me.auto_num.Width = 85
        '
        'col_pay_date
        '
        Me.col_pay_date.HeaderText = "ថ្ងៃ ខែ បង់ប្រាក់"
        Me.col_pay_date.Name = "col_pay_date"
        Me.col_pay_date.Width = 200
        '
        'col_brak_derm
        '
        Me.col_brak_derm.FillWeight = 200.0!
        Me.col_brak_derm.HeaderText = "ប្រាក់ដើម"
        Me.col_brak_derm.Name = "col_brak_derm"
        Me.col_brak_derm.Width = 150
        '
        'col_rate_money
        '
        Me.col_rate_money.HeaderText = "ការប្រាក់"
        Me.col_rate_money.Name = "col_rate_money"
        Me.col_rate_money.Width = 150
        '
        'lbl_decreasing
        '
        Me.lbl_decreasing.AutoSize = True
        Me.lbl_decreasing.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_decreasing.ForeColor = System.Drawing.Color.Navy
        Me.lbl_decreasing.Location = New System.Drawing.Point(910, 205)
        Me.lbl_decreasing.Name = "lbl_decreasing"
        Me.lbl_decreasing.Size = New System.Drawing.Size(144, 27)
        Me.lbl_decreasing.TabIndex = 235
        Me.lbl_decreasing.Text = "ការកំណត់ចំនួនឲ្យថយ"
        '
        'txt_decreasing
        '
        Me.txt_decreasing.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_decreasing.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_decreasing.Location = New System.Drawing.Point(1057, 203)
        Me.txt_decreasing.Multiline = True
        Me.txt_decreasing.Name = "txt_decreasing"
        Me.txt_decreasing.Size = New System.Drawing.Size(257, 30)
        Me.txt_decreasing.TabIndex = 236
        '
        'txt_first_pay_back1
        '
        Me.txt_first_pay_back1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_pay_back1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_first_pay_back1.Location = New System.Drawing.Point(1057, 166)
        Me.txt_first_pay_back1.Multiline = True
        Me.txt_first_pay_back1.Name = "txt_first_pay_back1"
        Me.txt_first_pay_back1.Size = New System.Drawing.Size(257, 30)
        Me.txt_first_pay_back1.TabIndex = 234
        '
        'lbl_first_pay_back1
        '
        Me.lbl_first_pay_back1.AutoSize = True
        Me.lbl_first_pay_back1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_pay_back1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_first_pay_back1.Location = New System.Drawing.Point(910, 168)
        Me.lbl_first_pay_back1.Name = "lbl_first_pay_back1"
        Me.lbl_first_pay_back1.Size = New System.Drawing.Size(112, 27)
        Me.lbl_first_pay_back1.TabIndex = 233
        Me.lbl_first_pay_back1.Text = "ថ្ងៃសង់ប្រាក់ដំបូង"
        '
        'txt_open_date1
        '
        Me.txt_open_date1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_open_date1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_open_date1.Location = New System.Drawing.Point(1057, 132)
        Me.txt_open_date1.Multiline = True
        Me.txt_open_date1.Name = "txt_open_date1"
        Me.txt_open_date1.Size = New System.Drawing.Size(257, 30)
        Me.txt_open_date1.TabIndex = 232
        '
        'lbl_open_date1
        '
        Me.lbl_open_date1.AutoSize = True
        Me.lbl_open_date1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_open_date1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_open_date1.Location = New System.Drawing.Point(910, 134)
        Me.lbl_open_date1.Name = "lbl_open_date1"
        Me.lbl_open_date1.Size = New System.Drawing.Size(82, 27)
        Me.lbl_open_date1.TabIndex = 231
        Me.lbl_open_date1.Text = "ថ្ងៃបើកប្រាក់"
        '
        'txt_rate_money1
        '
        Me.txt_rate_money1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate_money1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_rate_money1.Location = New System.Drawing.Point(1057, 98)
        Me.txt_rate_money1.Multiline = True
        Me.txt_rate_money1.Name = "txt_rate_money1"
        Me.txt_rate_money1.Size = New System.Drawing.Size(257, 30)
        Me.txt_rate_money1.TabIndex = 230
        '
        'txt_loan_duration1
        '
        Me.txt_loan_duration1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_duration1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_loan_duration1.Location = New System.Drawing.Point(1057, 64)
        Me.txt_loan_duration1.Multiline = True
        Me.txt_loan_duration1.Name = "txt_loan_duration1"
        Me.txt_loan_duration1.Size = New System.Drawing.Size(257, 30)
        Me.txt_loan_duration1.TabIndex = 229
        '
        'lbl_rate_money1
        '
        Me.lbl_rate_money1.AutoSize = True
        Me.lbl_rate_money1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rate_money1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rate_money1.Location = New System.Drawing.Point(910, 102)
        Me.lbl_rate_money1.Name = "lbl_rate_money1"
        Me.lbl_rate_money1.Size = New System.Drawing.Size(62, 27)
        Me.lbl_rate_money1.TabIndex = 228
        Me.lbl_rate_money1.Text = "ការប្រាក់"
        '
        'lbl_loan_duration1
        '
        Me.lbl_loan_duration1.AutoSize = True
        Me.lbl_loan_duration1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_duration1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_duration1.Location = New System.Drawing.Point(910, 69)
        Me.lbl_loan_duration1.Name = "lbl_loan_duration1"
        Me.lbl_loan_duration1.Size = New System.Drawing.Size(83, 27)
        Me.lbl_loan_duration1.TabIndex = 227
        Me.lbl_loan_duration1.Text = "រយះពេល ខ្ចី"
        '
        'txt_loan_amount1
        '
        Me.txt_loan_amount1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_amount1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_loan_amount1.Location = New System.Drawing.Point(1057, 30)
        Me.txt_loan_amount1.Multiline = True
        Me.txt_loan_amount1.Name = "txt_loan_amount1"
        Me.txt_loan_amount1.Size = New System.Drawing.Size(257, 30)
        Me.txt_loan_amount1.TabIndex = 226
        '
        'lbl_loan_amount1
        '
        Me.lbl_loan_amount1.AutoSize = True
        Me.lbl_loan_amount1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_amount1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_amount1.Location = New System.Drawing.Point(910, 32)
        Me.lbl_loan_amount1.Name = "lbl_loan_amount1"
        Me.lbl_loan_amount1.Size = New System.Drawing.Size(106, 27)
        Me.lbl_loan_amount1.TabIndex = 225
        Me.lbl_loan_amount1.Text = "ចំនួនទឹកប្រាក់ ខ្ចី"
        '
        'txt_shift
        '
        Me.txt_shift.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shift.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_shift.Location = New System.Drawing.Point(608, 169)
        Me.txt_shift.Multiline = True
        Me.txt_shift.Name = "txt_shift"
        Me.txt_shift.Size = New System.Drawing.Size(257, 30)
        Me.txt_shift.TabIndex = 224
        '
        'lbl_accountid
        '
        Me.lbl_accountid.AutoSize = True
        Me.lbl_accountid.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountid.ForeColor = System.Drawing.Color.Navy
        Me.lbl_accountid.Location = New System.Drawing.Point(495, 31)
        Me.lbl_accountid.Name = "lbl_accountid"
        Me.lbl_accountid.Size = New System.Drawing.Size(57, 27)
        Me.lbl_accountid.TabIndex = 215
        Me.lbl_accountid.Text = "A/C-ID"
        '
        'txt_rate_money
        '
        Me.txt_rate_money.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate_money.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_rate_money.Location = New System.Drawing.Point(608, 135)
        Me.txt_rate_money.Multiline = True
        Me.txt_rate_money.Name = "txt_rate_money"
        Me.txt_rate_money.Size = New System.Drawing.Size(257, 30)
        Me.txt_rate_money.TabIndex = 223
        '
        'lbl_shift
        '
        Me.lbl_shift.AutoSize = True
        Me.lbl_shift.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shift.ForeColor = System.Drawing.Color.Navy
        Me.lbl_shift.Location = New System.Drawing.Point(495, 169)
        Me.lbl_shift.Name = "lbl_shift"
        Me.lbl_shift.Size = New System.Drawing.Size(37, 27)
        Me.lbl_shift.TabIndex = 222
        Me.lbl_shift.Text = "វគ្គទី"
        '
        'txt_loan_duration
        '
        Me.txt_loan_duration.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_duration.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_loan_duration.Location = New System.Drawing.Point(608, 101)
        Me.txt_loan_duration.Multiline = True
        Me.txt_loan_duration.Name = "txt_loan_duration"
        Me.txt_loan_duration.Size = New System.Drawing.Size(257, 30)
        Me.txt_loan_duration.TabIndex = 221
        '
        'lbl_rate_money
        '
        Me.lbl_rate_money.AutoSize = True
        Me.lbl_rate_money.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rate_money.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rate_money.Location = New System.Drawing.Point(495, 135)
        Me.lbl_rate_money.Name = "lbl_rate_money"
        Me.lbl_rate_money.Size = New System.Drawing.Size(62, 27)
        Me.lbl_rate_money.TabIndex = 220
        Me.lbl_rate_money.Text = "ការប្រាក់"
        '
        'txt_loan_amount
        '
        Me.txt_loan_amount.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_amount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_loan_amount.Location = New System.Drawing.Point(608, 67)
        Me.txt_loan_amount.Multiline = True
        Me.txt_loan_amount.Name = "txt_loan_amount"
        Me.txt_loan_amount.Size = New System.Drawing.Size(257, 30)
        Me.txt_loan_amount.TabIndex = 219
        '
        'lbl_loan_duration
        '
        Me.lbl_loan_duration.AutoSize = True
        Me.lbl_loan_duration.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_duration.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_duration.Location = New System.Drawing.Point(495, 101)
        Me.lbl_loan_duration.Name = "lbl_loan_duration"
        Me.lbl_loan_duration.Size = New System.Drawing.Size(79, 27)
        Me.lbl_loan_duration.TabIndex = 218
        Me.lbl_loan_duration.Text = "រយះពេលខ្ចី"
        '
        'lbl_loan_amount
        '
        Me.lbl_loan_amount.AutoSize = True
        Me.lbl_loan_amount.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_amount.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_amount.Location = New System.Drawing.Point(495, 68)
        Me.lbl_loan_amount.Name = "lbl_loan_amount"
        Me.lbl_loan_amount.Size = New System.Drawing.Size(106, 27)
        Me.lbl_loan_amount.TabIndex = 217
        Me.lbl_loan_amount.Text = "ចំនួនទឹកប្រាក់ ខ្ចី"
        '
        'txt_accountid
        '
        Me.txt_accountid.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_accountid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_accountid.Location = New System.Drawing.Point(608, 33)
        Me.txt_accountid.Multiline = True
        Me.txt_accountid.Name = "txt_accountid"
        Me.txt_accountid.Size = New System.Drawing.Size(257, 30)
        Me.txt_accountid.TabIndex = 216
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_address.Location = New System.Drawing.Point(186, 259)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(462, 84)
        Me.txt_address.TabIndex = 214
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Navy
        Me.lbl_address.Location = New System.Drawing.Point(50, 262)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(82, 27)
        Me.lbl_address.TabIndex = 213
        Me.lbl_address.Text = "អាស័យដ្ឋាន"
        '
        'com_money_type
        '
        Me.com_money_type.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_money_type.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.com_money_type.FormattingEnabled = True
        Me.com_money_type.Location = New System.Drawing.Point(186, 218)
        Me.com_money_type.Name = "com_money_type"
        Me.com_money_type.Size = New System.Drawing.Size(257, 35)
        Me.com_money_type.TabIndex = 212
        '
        'lbl_money_type
        '
        Me.lbl_money_type.AutoSize = True
        Me.lbl_money_type.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_money_type.ForeColor = System.Drawing.Color.Navy
        Me.lbl_money_type.Location = New System.Drawing.Point(50, 217)
        Me.lbl_money_type.Name = "lbl_money_type"
        Me.lbl_money_type.Size = New System.Drawing.Size(82, 27)
        Me.lbl_money_type.TabIndex = 211
        Me.lbl_money_type.Text = "ប្រភេទប្រាក់"
        '
        'txt_first_pay_back
        '
        Me.txt_first_pay_back.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_pay_back.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_first_pay_back.Location = New System.Drawing.Point(186, 184)
        Me.txt_first_pay_back.Multiline = True
        Me.txt_first_pay_back.Name = "txt_first_pay_back"
        Me.txt_first_pay_back.Size = New System.Drawing.Size(257, 30)
        Me.txt_first_pay_back.TabIndex = 210
        '
        'lbl_first_pay_back
        '
        Me.lbl_first_pay_back.AutoSize = True
        Me.lbl_first_pay_back.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_pay_back.ForeColor = System.Drawing.Color.Navy
        Me.lbl_first_pay_back.Location = New System.Drawing.Point(51, 185)
        Me.lbl_first_pay_back.Name = "lbl_first_pay_back"
        Me.lbl_first_pay_back.Size = New System.Drawing.Size(112, 27)
        Me.lbl_first_pay_back.TabIndex = 209
        Me.lbl_first_pay_back.Text = "ថ្ងៃសង់ប្រាក់ដំបូង"
        '
        'txt_open_date
        '
        Me.txt_open_date.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_open_date.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_open_date.Location = New System.Drawing.Point(186, 150)
        Me.txt_open_date.Multiline = True
        Me.txt_open_date.Name = "txt_open_date"
        Me.txt_open_date.Size = New System.Drawing.Size(257, 30)
        Me.txt_open_date.TabIndex = 208
        '
        'lbl_open_date
        '
        Me.lbl_open_date.AutoSize = True
        Me.lbl_open_date.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_open_date.ForeColor = System.Drawing.Color.Navy
        Me.lbl_open_date.Location = New System.Drawing.Point(51, 151)
        Me.lbl_open_date.Name = "lbl_open_date"
        Me.lbl_open_date.Size = New System.Drawing.Size(82, 27)
        Me.lbl_open_date.TabIndex = 207
        Me.lbl_open_date.Text = "ថ្ងៃបើកប្រាក់"
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_phone.Location = New System.Drawing.Point(186, 116)
        Me.txt_phone.Multiline = True
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(257, 30)
        Me.txt_phone.TabIndex = 206
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.ForeColor = System.Drawing.Color.Navy
        Me.lbl_phone.Location = New System.Drawing.Point(51, 117)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(82, 27)
        Me.lbl_phone.TabIndex = 205
        Me.lbl_phone.Text = "លេខទូរស័ព្វ"
        '
        'combo_loaner_name
        '
        Me.combo_loaner_name.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_loaner_name.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.combo_loaner_name.FormattingEnabled = True
        Me.combo_loaner_name.Location = New System.Drawing.Point(186, 76)
        Me.combo_loaner_name.Name = "combo_loaner_name"
        Me.combo_loaner_name.Size = New System.Drawing.Size(257, 35)
        Me.combo_loaner_name.TabIndex = 204
        '
        'lbl_loaner_name
        '
        Me.lbl_loaner_name.AutoSize = True
        Me.lbl_loaner_name.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loaner_name.Location = New System.Drawing.Point(50, 71)
        Me.lbl_loaner_name.Name = "lbl_loaner_name"
        Me.lbl_loaner_name.Size = New System.Drawing.Size(80, 27)
        Me.lbl_loaner_name.TabIndex = 203
        Me.lbl_loaner_name.Text = "ឈ្មោះអ្នកខ្ចី"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_username.Location = New System.Drawing.Point(186, 33)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(257, 30)
        Me.txt_username.TabIndex = 202
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Navy
        Me.lbl_username.Location = New System.Drawing.Point(51, 34)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(124, 27)
        Me.lbl_username.TabIndex = 201
        Me.lbl_username.Text = "អ្នកប្រើប្រាស់(hide)"
        '
        'frm_all_loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 918)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.panel_content)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_all_loan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_content.ResumeLayout(False)
        Me.panel_content.PerformLayout()
        CType(Me.tbl_grid_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_header As System.Windows.Forms.Panel
    Friend WithEvents panel_content As System.Windows.Forms.Panel
    Friend WithEvents lbl_logo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lbl_decreasing As System.Windows.Forms.Label
    Private WithEvents txt_decreasing As System.Windows.Forms.TextBox
    Private WithEvents txt_first_pay_back1 As System.Windows.Forms.TextBox
    Private WithEvents lbl_first_pay_back1 As System.Windows.Forms.Label
    Private WithEvents txt_open_date1 As System.Windows.Forms.TextBox
    Private WithEvents lbl_open_date1 As System.Windows.Forms.Label
    Private WithEvents txt_rate_money1 As System.Windows.Forms.TextBox
    Private WithEvents txt_loan_duration1 As System.Windows.Forms.TextBox
    Private WithEvents lbl_rate_money1 As System.Windows.Forms.Label
    Private WithEvents lbl_loan_duration1 As System.Windows.Forms.Label
    Private WithEvents txt_loan_amount1 As System.Windows.Forms.TextBox
    Private WithEvents lbl_loan_amount1 As System.Windows.Forms.Label
    Private WithEvents txt_shift As System.Windows.Forms.TextBox
    Private WithEvents lbl_accountid As System.Windows.Forms.Label
    Private WithEvents txt_rate_money As System.Windows.Forms.TextBox
    Private WithEvents lbl_shift As System.Windows.Forms.Label
    Private WithEvents txt_loan_duration As System.Windows.Forms.TextBox
    Private WithEvents lbl_rate_money As System.Windows.Forms.Label
    Private WithEvents txt_loan_amount As System.Windows.Forms.TextBox
    Private WithEvents lbl_loan_duration As System.Windows.Forms.Label
    Private WithEvents lbl_loan_amount As System.Windows.Forms.Label
    Private WithEvents txt_accountid As System.Windows.Forms.TextBox
    Private WithEvents txt_address As System.Windows.Forms.TextBox
    Private WithEvents lbl_address As System.Windows.Forms.Label
    Private WithEvents com_money_type As System.Windows.Forms.ComboBox
    Private WithEvents lbl_money_type As System.Windows.Forms.Label
    Private WithEvents txt_first_pay_back As System.Windows.Forms.TextBox
    Private WithEvents lbl_first_pay_back As System.Windows.Forms.Label
    Private WithEvents txt_open_date As System.Windows.Forms.TextBox
    Private WithEvents lbl_open_date As System.Windows.Forms.Label
    Private WithEvents txt_phone As System.Windows.Forms.TextBox
    Private WithEvents lbl_phone As System.Windows.Forms.Label
    Private WithEvents combo_loaner_name As System.Windows.Forms.ComboBox
    Private WithEvents lbl_loaner_name As System.Windows.Forms.Label
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents lbl_username As System.Windows.Forms.Label
    Private WithEvents tbl_grid_user As System.Windows.Forms.DataGridView
    Private WithEvents auto_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_pay_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_brak_derm As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_rate_money As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents txt_search As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btn_save As System.Windows.Forms.Button
End Class
