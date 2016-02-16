<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loaner_all_info
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title_user = New System.Windows.Forms.Label()
        Me.lbl_phone_num = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.tbl_grid_user = New System.Windows.Forms.DataGridView()
        Me.auto_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pay_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_brak_derm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_rate_money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pay_back_money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_brak_derm_owned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_date_payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_signature = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.txt_phone_num = New System.Windows.Forms.TextBox()
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
        Me.label24 = New System.Windows.Forms.Label()
        CType(Me.tbl_grid_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title_user
        '
        Me.lbl_title_user.AutoSize = True
        Me.lbl_title_user.Font = New System.Drawing.Font("Khmer OS Muol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title_user.ForeColor = System.Drawing.Color.Navy
        Me.lbl_title_user.Location = New System.Drawing.Point(126, 18)
        Me.lbl_title_user.Name = "lbl_title_user"
        Me.lbl_title_user.Size = New System.Drawing.Size(165, 55)
        Me.lbl_title_user.TabIndex = 202
        Me.lbl_title_user.Text = "ការខ្ចីប្រាក់"
        '
        'lbl_phone_num
        '
        Me.lbl_phone_num.AutoSize = True
        Me.lbl_phone_num.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_num.ForeColor = System.Drawing.Color.Navy
        Me.lbl_phone_num.Location = New System.Drawing.Point(27, 423)
        Me.lbl_phone_num.Name = "lbl_phone_num"
        Me.lbl_phone_num.Size = New System.Drawing.Size(82, 27)
        Me.lbl_phone_num.TabIndex = 201
        Me.lbl_phone_num.Text = "លេខទូរស័ព្វ"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(1027, 333)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(257, 32)
        Me.btn_save.TabIndex = 200
        Me.btn_save.Text = "បន្ថែម"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'tbl_grid_user
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tbl_grid_user.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tbl_grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_grid_user.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.auto_num, Me.col_pay_date, Me.col_brak_derm, Me.col_rate_money, Me.col_pay_back_money, Me.col_brak_derm_owned, Me.col_date_payment, Me.col_signature})
        Me.tbl_grid_user.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tbl_grid_user.DefaultCellStyle = DataGridViewCellStyle4
        Me.tbl_grid_user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl_grid_user.Location = New System.Drawing.Point(20, 460)
        Me.tbl_grid_user.Name = "tbl_grid_user"
        Me.tbl_grid_user.Size = New System.Drawing.Size(1278, 199)
        Me.tbl_grid_user.TabIndex = 199
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
        'col_pay_back_money
        '
        Me.col_pay_back_money.HeaderText = "ប្រាក់ត្រូវបង់"
        Me.col_pay_back_money.Name = "col_pay_back_money"
        Me.col_pay_back_money.Width = 150
        '
        'col_brak_derm_owned
        '
        Me.col_brak_derm_owned.HeaderText = "ប្រាក់ដើមជំពាក់"
        Me.col_brak_derm_owned.Name = "col_brak_derm_owned"
        Me.col_brak_derm_owned.Width = 150
        '
        'col_date_payment
        '
        Me.col_date_payment.HeaderText = "ថ្ងៃបង់ប្រាក់"
        Me.col_date_payment.Name = "col_date_payment"
        Me.col_date_payment.Width = 200
        '
        'col_signature
        '
        Me.col_signature.HeaderText = "ហត្ថលេខាអ្នកទទួល"
        Me.col_signature.Name = "col_signature"
        Me.col_signature.Width = 150
        '
        'lbl_decreasing
        '
        Me.lbl_decreasing.AutoSize = True
        Me.lbl_decreasing.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_decreasing.ForeColor = System.Drawing.Color.Navy
        Me.lbl_decreasing.Location = New System.Drawing.Point(886, 277)
        Me.lbl_decreasing.Name = "lbl_decreasing"
        Me.lbl_decreasing.Size = New System.Drawing.Size(142, 27)
        Me.lbl_decreasing.TabIndex = 197
        Me.lbl_decreasing.Text = "ការកំណត់ចំនួនឲ្យថយ"
        '
        'txt_decreasing
        '
        Me.txt_decreasing.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_decreasing.ForeColor = System.Drawing.Color.Navy
        Me.txt_decreasing.Location = New System.Drawing.Point(1033, 275)
        Me.txt_decreasing.Multiline = True
        Me.txt_decreasing.Name = "txt_decreasing"
        Me.txt_decreasing.Size = New System.Drawing.Size(257, 28)
        Me.txt_decreasing.TabIndex = 198
        '
        'txt_first_pay_back1
        '
        Me.txt_first_pay_back1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_pay_back1.ForeColor = System.Drawing.Color.Navy
        Me.txt_first_pay_back1.Location = New System.Drawing.Point(1033, 238)
        Me.txt_first_pay_back1.Multiline = True
        Me.txt_first_pay_back1.Name = "txt_first_pay_back1"
        Me.txt_first_pay_back1.Size = New System.Drawing.Size(257, 28)
        Me.txt_first_pay_back1.TabIndex = 196
        '
        'lbl_first_pay_back1
        '
        Me.lbl_first_pay_back1.AutoSize = True
        Me.lbl_first_pay_back1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_pay_back1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_first_pay_back1.Location = New System.Drawing.Point(886, 240)
        Me.lbl_first_pay_back1.Name = "lbl_first_pay_back1"
        Me.lbl_first_pay_back1.Size = New System.Drawing.Size(112, 27)
        Me.lbl_first_pay_back1.TabIndex = 195
        Me.lbl_first_pay_back1.Text = "ថ្ងៃសង់ប្រាក់ដំបូង"
        '
        'txt_open_date1
        '
        Me.txt_open_date1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_open_date1.ForeColor = System.Drawing.Color.Navy
        Me.txt_open_date1.Location = New System.Drawing.Point(1033, 204)
        Me.txt_open_date1.Multiline = True
        Me.txt_open_date1.Name = "txt_open_date1"
        Me.txt_open_date1.Size = New System.Drawing.Size(257, 28)
        Me.txt_open_date1.TabIndex = 194
        '
        'lbl_open_date1
        '
        Me.lbl_open_date1.AutoSize = True
        Me.lbl_open_date1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_open_date1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_open_date1.Location = New System.Drawing.Point(886, 206)
        Me.lbl_open_date1.Name = "lbl_open_date1"
        Me.lbl_open_date1.Size = New System.Drawing.Size(82, 27)
        Me.lbl_open_date1.TabIndex = 193
        Me.lbl_open_date1.Text = "ថ្ងៃបើកប្រាក់"
        '
        'txt_rate_money1
        '
        Me.txt_rate_money1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate_money1.ForeColor = System.Drawing.Color.Navy
        Me.txt_rate_money1.Location = New System.Drawing.Point(1033, 170)
        Me.txt_rate_money1.Multiline = True
        Me.txt_rate_money1.Name = "txt_rate_money1"
        Me.txt_rate_money1.Size = New System.Drawing.Size(257, 28)
        Me.txt_rate_money1.TabIndex = 192
        '
        'txt_loan_duration1
        '
        Me.txt_loan_duration1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_duration1.ForeColor = System.Drawing.Color.Navy
        Me.txt_loan_duration1.Location = New System.Drawing.Point(1033, 136)
        Me.txt_loan_duration1.Multiline = True
        Me.txt_loan_duration1.Name = "txt_loan_duration1"
        Me.txt_loan_duration1.Size = New System.Drawing.Size(257, 28)
        Me.txt_loan_duration1.TabIndex = 191
        '
        'lbl_rate_money1
        '
        Me.lbl_rate_money1.AutoSize = True
        Me.lbl_rate_money1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rate_money1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rate_money1.Location = New System.Drawing.Point(886, 174)
        Me.lbl_rate_money1.Name = "lbl_rate_money1"
        Me.lbl_rate_money1.Size = New System.Drawing.Size(62, 27)
        Me.lbl_rate_money1.TabIndex = 190
        Me.lbl_rate_money1.Text = "ការប្រាក់"
        '
        'lbl_loan_duration1
        '
        Me.lbl_loan_duration1.AutoSize = True
        Me.lbl_loan_duration1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_duration1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_duration1.Location = New System.Drawing.Point(886, 141)
        Me.lbl_loan_duration1.Name = "lbl_loan_duration1"
        Me.lbl_loan_duration1.Size = New System.Drawing.Size(83, 27)
        Me.lbl_loan_duration1.TabIndex = 189
        Me.lbl_loan_duration1.Text = "រយះពេល ខ្ចី"
        '
        'txt_loan_amount1
        '
        Me.txt_loan_amount1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_amount1.ForeColor = System.Drawing.Color.Navy
        Me.txt_loan_amount1.Location = New System.Drawing.Point(1033, 102)
        Me.txt_loan_amount1.Multiline = True
        Me.txt_loan_amount1.Name = "txt_loan_amount1"
        Me.txt_loan_amount1.Size = New System.Drawing.Size(257, 28)
        Me.txt_loan_amount1.TabIndex = 188
        '
        'lbl_loan_amount1
        '
        Me.lbl_loan_amount1.AutoSize = True
        Me.lbl_loan_amount1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_amount1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_amount1.Location = New System.Drawing.Point(886, 104)
        Me.lbl_loan_amount1.Name = "lbl_loan_amount1"
        Me.lbl_loan_amount1.Size = New System.Drawing.Size(106, 27)
        Me.lbl_loan_amount1.TabIndex = 187
        Me.lbl_loan_amount1.Text = "ចំនួនទឹកប្រាក់ ខ្ចី"
        '
        'txt_shift
        '
        Me.txt_shift.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shift.ForeColor = System.Drawing.Color.Navy
        Me.txt_shift.Location = New System.Drawing.Point(584, 241)
        Me.txt_shift.Multiline = True
        Me.txt_shift.Name = "txt_shift"
        Me.txt_shift.Size = New System.Drawing.Size(257, 28)
        Me.txt_shift.TabIndex = 186
        '
        'lbl_accountid
        '
        Me.lbl_accountid.AutoSize = True
        Me.lbl_accountid.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountid.ForeColor = System.Drawing.Color.Navy
        Me.lbl_accountid.Location = New System.Drawing.Point(471, 103)
        Me.lbl_accountid.Name = "lbl_accountid"
        Me.lbl_accountid.Size = New System.Drawing.Size(54, 27)
        Me.lbl_accountid.TabIndex = 177
        Me.lbl_accountid.Text = "A/C-ID"
        '
        'txt_phone_num
        '
        Me.txt_phone_num.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_num.ForeColor = System.Drawing.Color.Navy
        Me.txt_phone_num.Location = New System.Drawing.Point(161, 420)
        Me.txt_phone_num.Multiline = True
        Me.txt_phone_num.Name = "txt_phone_num"
        Me.txt_phone_num.Size = New System.Drawing.Size(463, 28)
        Me.txt_phone_num.TabIndex = 176
        '
        'txt_rate_money
        '
        Me.txt_rate_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate_money.ForeColor = System.Drawing.Color.Navy
        Me.txt_rate_money.Location = New System.Drawing.Point(584, 207)
        Me.txt_rate_money.Multiline = True
        Me.txt_rate_money.Name = "txt_rate_money"
        Me.txt_rate_money.Size = New System.Drawing.Size(257, 28)
        Me.txt_rate_money.TabIndex = 185
        '
        'lbl_shift
        '
        Me.lbl_shift.AutoSize = True
        Me.lbl_shift.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shift.ForeColor = System.Drawing.Color.Navy
        Me.lbl_shift.Location = New System.Drawing.Point(471, 241)
        Me.lbl_shift.Name = "lbl_shift"
        Me.lbl_shift.Size = New System.Drawing.Size(37, 27)
        Me.lbl_shift.TabIndex = 184
        Me.lbl_shift.Text = "វគ្គទី"
        '
        'txt_loan_duration
        '
        Me.txt_loan_duration.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_duration.ForeColor = System.Drawing.Color.Navy
        Me.txt_loan_duration.Location = New System.Drawing.Point(584, 173)
        Me.txt_loan_duration.Multiline = True
        Me.txt_loan_duration.Name = "txt_loan_duration"
        Me.txt_loan_duration.Size = New System.Drawing.Size(257, 28)
        Me.txt_loan_duration.TabIndex = 183
        '
        'lbl_rate_money
        '
        Me.lbl_rate_money.AutoSize = True
        Me.lbl_rate_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rate_money.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rate_money.Location = New System.Drawing.Point(471, 207)
        Me.lbl_rate_money.Name = "lbl_rate_money"
        Me.lbl_rate_money.Size = New System.Drawing.Size(62, 27)
        Me.lbl_rate_money.TabIndex = 182
        Me.lbl_rate_money.Text = "ការប្រាក់"
        '
        'txt_loan_amount
        '
        Me.txt_loan_amount.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_amount.ForeColor = System.Drawing.Color.Navy
        Me.txt_loan_amount.Location = New System.Drawing.Point(584, 139)
        Me.txt_loan_amount.Multiline = True
        Me.txt_loan_amount.Name = "txt_loan_amount"
        Me.txt_loan_amount.Size = New System.Drawing.Size(257, 28)
        Me.txt_loan_amount.TabIndex = 181
        '
        'lbl_loan_duration
        '
        Me.lbl_loan_duration.AutoSize = True
        Me.lbl_loan_duration.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_duration.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_duration.Location = New System.Drawing.Point(471, 173)
        Me.lbl_loan_duration.Name = "lbl_loan_duration"
        Me.lbl_loan_duration.Size = New System.Drawing.Size(79, 27)
        Me.lbl_loan_duration.TabIndex = 180
        Me.lbl_loan_duration.Text = "រយះពេលខ្ចី"
        '
        'lbl_loan_amount
        '
        Me.lbl_loan_amount.AutoSize = True
        Me.lbl_loan_amount.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_amount.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_amount.Location = New System.Drawing.Point(471, 140)
        Me.lbl_loan_amount.Name = "lbl_loan_amount"
        Me.lbl_loan_amount.Size = New System.Drawing.Size(106, 27)
        Me.lbl_loan_amount.TabIndex = 179
        Me.lbl_loan_amount.Text = "ចំនួនទឹកប្រាក់ ខ្ចី"
        '
        'txt_accountid
        '
        Me.txt_accountid.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_accountid.ForeColor = System.Drawing.Color.Navy
        Me.txt_accountid.Location = New System.Drawing.Point(584, 105)
        Me.txt_accountid.Multiline = True
        Me.txt_accountid.Name = "txt_accountid"
        Me.txt_accountid.Size = New System.Drawing.Size(257, 28)
        Me.txt_accountid.TabIndex = 178
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Navy
        Me.txt_address.Location = New System.Drawing.Point(162, 331)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(462, 84)
        Me.txt_address.TabIndex = 175
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Navy
        Me.lbl_address.Location = New System.Drawing.Point(26, 334)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(82, 27)
        Me.lbl_address.TabIndex = 174
        Me.lbl_address.Text = "អាស័យដ្ឋាន"
        '
        'com_money_type
        '
        Me.com_money_type.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_money_type.ForeColor = System.Drawing.Color.Navy
        Me.com_money_type.FormattingEnabled = True
        Me.com_money_type.Location = New System.Drawing.Point(162, 290)
        Me.com_money_type.Name = "com_money_type"
        Me.com_money_type.Size = New System.Drawing.Size(257, 35)
        Me.com_money_type.TabIndex = 173
        '
        'lbl_money_type
        '
        Me.lbl_money_type.AutoSize = True
        Me.lbl_money_type.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_money_type.ForeColor = System.Drawing.Color.Navy
        Me.lbl_money_type.Location = New System.Drawing.Point(26, 289)
        Me.lbl_money_type.Name = "lbl_money_type"
        Me.lbl_money_type.Size = New System.Drawing.Size(82, 27)
        Me.lbl_money_type.TabIndex = 172
        Me.lbl_money_type.Text = "ប្រភេទប្រាក់"
        '
        'txt_first_pay_back
        '
        Me.txt_first_pay_back.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_pay_back.ForeColor = System.Drawing.Color.Navy
        Me.txt_first_pay_back.Location = New System.Drawing.Point(162, 256)
        Me.txt_first_pay_back.Multiline = True
        Me.txt_first_pay_back.Name = "txt_first_pay_back"
        Me.txt_first_pay_back.Size = New System.Drawing.Size(257, 28)
        Me.txt_first_pay_back.TabIndex = 171
        '
        'lbl_first_pay_back
        '
        Me.lbl_first_pay_back.AutoSize = True
        Me.lbl_first_pay_back.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_pay_back.ForeColor = System.Drawing.Color.Navy
        Me.lbl_first_pay_back.Location = New System.Drawing.Point(27, 257)
        Me.lbl_first_pay_back.Name = "lbl_first_pay_back"
        Me.lbl_first_pay_back.Size = New System.Drawing.Size(112, 27)
        Me.lbl_first_pay_back.TabIndex = 170
        Me.lbl_first_pay_back.Text = "ថ្ងៃសង់ប្រាក់ដំបូង"
        '
        'txt_open_date
        '
        Me.txt_open_date.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_open_date.ForeColor = System.Drawing.Color.Navy
        Me.txt_open_date.Location = New System.Drawing.Point(162, 222)
        Me.txt_open_date.Multiline = True
        Me.txt_open_date.Name = "txt_open_date"
        Me.txt_open_date.Size = New System.Drawing.Size(257, 28)
        Me.txt_open_date.TabIndex = 169
        '
        'lbl_open_date
        '
        Me.lbl_open_date.AutoSize = True
        Me.lbl_open_date.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_open_date.ForeColor = System.Drawing.Color.Navy
        Me.lbl_open_date.Location = New System.Drawing.Point(27, 223)
        Me.lbl_open_date.Name = "lbl_open_date"
        Me.lbl_open_date.Size = New System.Drawing.Size(82, 27)
        Me.lbl_open_date.TabIndex = 168
        Me.lbl_open_date.Text = "ថ្ងៃបើកប្រាក់"
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.ForeColor = System.Drawing.Color.Navy
        Me.txt_phone.Location = New System.Drawing.Point(162, 188)
        Me.txt_phone.Multiline = True
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(257, 28)
        Me.txt_phone.TabIndex = 167
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.ForeColor = System.Drawing.Color.Navy
        Me.lbl_phone.Location = New System.Drawing.Point(27, 189)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(82, 27)
        Me.lbl_phone.TabIndex = 166
        Me.lbl_phone.Text = "លេខទូរស័ព្វ"
        '
        'combo_loaner_name
        '
        Me.combo_loaner_name.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.combo_loaner_name.FormattingEnabled = True
        Me.combo_loaner_name.Location = New System.Drawing.Point(162, 148)
        Me.combo_loaner_name.Name = "combo_loaner_name"
        Me.combo_loaner_name.Size = New System.Drawing.Size(257, 35)
        Me.combo_loaner_name.TabIndex = 165
        '
        'lbl_loaner_name
        '
        Me.lbl_loaner_name.AutoSize = True
        Me.lbl_loaner_name.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loaner_name.Location = New System.Drawing.Point(26, 143)
        Me.lbl_loaner_name.Name = "lbl_loaner_name"
        Me.lbl_loaner_name.Size = New System.Drawing.Size(78, 27)
        Me.lbl_loaner_name.TabIndex = 164
        Me.lbl_loaner_name.Text = "ឈ្មោះអ្នកខ្ចី"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Navy
        Me.txt_username.Location = New System.Drawing.Point(162, 105)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(257, 28)
        Me.txt_username.TabIndex = 163
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Navy
        Me.lbl_username.Location = New System.Drawing.Point(27, 106)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(131, 27)
        Me.lbl_username.TabIndex = 162
        Me.lbl_username.Text = "អ្នកប្រើប្រាស់(hide)"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label24.ForeColor = System.Drawing.Color.White
        Me.label24.Image = Global.VBLoan.My.Resources.Resources._8_People
        Me.label24.Location = New System.Drawing.Point(20, 4)
        Me.label24.Name = "label24"
        Me.label24.Padding = New System.Windows.Forms.Padding(50, 25, 50, 25)
        Me.label24.Size = New System.Drawing.Size(100, 74)
        Me.label24.TabIndex = 203
        '
        'frm_loaner_all_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 679)
        Me.Controls.Add(Me.label24)
        Me.Controls.Add(Me.lbl_title_user)
        Me.Controls.Add(Me.lbl_phone_num)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tbl_grid_user)
        Me.Controls.Add(Me.lbl_decreasing)
        Me.Controls.Add(Me.txt_decreasing)
        Me.Controls.Add(Me.txt_first_pay_back1)
        Me.Controls.Add(Me.lbl_first_pay_back1)
        Me.Controls.Add(Me.txt_open_date1)
        Me.Controls.Add(Me.lbl_open_date1)
        Me.Controls.Add(Me.txt_rate_money1)
        Me.Controls.Add(Me.txt_loan_duration1)
        Me.Controls.Add(Me.lbl_rate_money1)
        Me.Controls.Add(Me.lbl_loan_duration1)
        Me.Controls.Add(Me.txt_loan_amount1)
        Me.Controls.Add(Me.lbl_loan_amount1)
        Me.Controls.Add(Me.txt_shift)
        Me.Controls.Add(Me.lbl_accountid)
        Me.Controls.Add(Me.txt_phone_num)
        Me.Controls.Add(Me.txt_rate_money)
        Me.Controls.Add(Me.lbl_shift)
        Me.Controls.Add(Me.txt_loan_duration)
        Me.Controls.Add(Me.lbl_rate_money)
        Me.Controls.Add(Me.txt_loan_amount)
        Me.Controls.Add(Me.lbl_loan_duration)
        Me.Controls.Add(Me.lbl_loan_amount)
        Me.Controls.Add(Me.txt_accountid)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.com_money_type)
        Me.Controls.Add(Me.lbl_money_type)
        Me.Controls.Add(Me.txt_first_pay_back)
        Me.Controls.Add(Me.lbl_first_pay_back)
        Me.Controls.Add(Me.txt_open_date)
        Me.Controls.Add(Me.lbl_open_date)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.combo_loaner_name)
        Me.Controls.Add(Me.lbl_loaner_name)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_loaner_all_info"
        Me.Padding = New System.Windows.Forms.Padding(20, 460, 20, 20)
        CType(Me.tbl_grid_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label24 As System.Windows.Forms.Label
    Private WithEvents lbl_title_user As System.Windows.Forms.Label
    Private WithEvents lbl_phone_num As System.Windows.Forms.Label
    Private WithEvents btn_save As System.Windows.Forms.Button
    Private WithEvents tbl_grid_user As System.Windows.Forms.DataGridView
    Private WithEvents auto_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_pay_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_brak_derm As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_rate_money As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_pay_back_money As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_brak_derm_owned As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_date_payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents col_signature As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Private WithEvents txt_phone_num As System.Windows.Forms.TextBox
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
End Class
