<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loaner_payment
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
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_rate_money = New System.Windows.Forms.TextBox()
        Me.lbl_rate_money = New System.Windows.Forms.Label()
        Me.txt_original_money = New System.Windows.Forms.TextBox()
        Me.lbl_original_money = New System.Windows.Forms.Label()
        Me.txt_orignal_money_owned = New System.Windows.Forms.TextBox()
        Me.lbl_orignal_money_owned = New System.Windows.Forms.Label()
        Me.txt_pay_money = New System.Windows.Forms.TextBox()
        Me.lbl_pay_money = New System.Windows.Forms.Label()
        Me.txt_pay_date = New System.Windows.Forms.TextBox()
        Me.lbl_pay_date = New System.Windows.Forms.Label()
        Me.combo_loaner_name = New System.Windows.Forms.ComboBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_loan_date = New System.Windows.Forms.TextBox()
        Me.lbl_loan_date = New System.Windows.Forms.Label()
        Me.lbl_loaner_name = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_title_user = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Navy
        Me.btn_save.Location = New System.Drawing.Point(373, 387)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(272, 35)
        Me.btn_save.TabIndex = 111
        Me.btn_save.Text = "រក្សាទុក"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_rate_money
        '
        Me.txt_rate_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate_money.ForeColor = System.Drawing.Color.Navy
        Me.txt_rate_money.Location = New System.Drawing.Point(373, 269)
        Me.txt_rate_money.Multiline = True
        Me.txt_rate_money.Name = "txt_rate_money"
        Me.txt_rate_money.Size = New System.Drawing.Size(272, 28)
        Me.txt_rate_money.TabIndex = 110
        '
        'lbl_rate_money
        '
        Me.lbl_rate_money.AutoSize = True
        Me.lbl_rate_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rate_money.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rate_money.Location = New System.Drawing.Point(368, 237)
        Me.lbl_rate_money.Name = "lbl_rate_money"
        Me.lbl_rate_money.Size = New System.Drawing.Size(62, 27)
        Me.lbl_rate_money.TabIndex = 109
        Me.lbl_rate_money.Text = "ការប្រាក់"
        '
        'txt_original_money
        '
        Me.txt_original_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_original_money.ForeColor = System.Drawing.Color.Navy
        Me.txt_original_money.Location = New System.Drawing.Point(58, 270)
        Me.txt_original_money.Multiline = True
        Me.txt_original_money.Name = "txt_original_money"
        Me.txt_original_money.Size = New System.Drawing.Size(289, 28)
        Me.txt_original_money.TabIndex = 108
        '
        'lbl_original_money
        '
        Me.lbl_original_money.AutoSize = True
        Me.lbl_original_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_original_money.ForeColor = System.Drawing.Color.Navy
        Me.lbl_original_money.Location = New System.Drawing.Point(53, 237)
        Me.lbl_original_money.Name = "lbl_original_money"
        Me.lbl_original_money.Size = New System.Drawing.Size(67, 27)
        Me.lbl_original_money.TabIndex = 107
        Me.lbl_original_money.Text = "ប្រាក់ដើម"
        '
        'txt_orignal_money_owned
        '
        Me.txt_orignal_money_owned.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orignal_money_owned.ForeColor = System.Drawing.Color.Navy
        Me.txt_orignal_money_owned.Location = New System.Drawing.Point(373, 338)
        Me.txt_orignal_money_owned.Multiline = True
        Me.txt_orignal_money_owned.Name = "txt_orignal_money_owned"
        Me.txt_orignal_money_owned.Size = New System.Drawing.Size(272, 28)
        Me.txt_orignal_money_owned.TabIndex = 106
        '
        'lbl_orignal_money_owned
        '
        Me.lbl_orignal_money_owned.AutoSize = True
        Me.lbl_orignal_money_owned.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orignal_money_owned.ForeColor = System.Drawing.Color.Navy
        Me.lbl_orignal_money_owned.Location = New System.Drawing.Point(368, 304)
        Me.lbl_orignal_money_owned.Name = "lbl_orignal_money_owned"
        Me.lbl_orignal_money_owned.Size = New System.Drawing.Size(152, 27)
        Me.lbl_orignal_money_owned.TabIndex = 105
        Me.lbl_orignal_money_owned.Text = "ចំនួនប្រាក់ដើមនៅជំពាក់"
        '
        'txt_pay_money
        '
        Me.txt_pay_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pay_money.ForeColor = System.Drawing.Color.Navy
        Me.txt_pay_money.Location = New System.Drawing.Point(58, 337)
        Me.txt_pay_money.Multiline = True
        Me.txt_pay_money.Name = "txt_pay_money"
        Me.txt_pay_money.Size = New System.Drawing.Size(289, 28)
        Me.txt_pay_money.TabIndex = 104
        '
        'lbl_pay_money
        '
        Me.lbl_pay_money.AutoSize = True
        Me.lbl_pay_money.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_money.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pay_money.Location = New System.Drawing.Point(53, 305)
        Me.lbl_pay_money.Name = "lbl_pay_money"
        Me.lbl_pay_money.Size = New System.Drawing.Size(97, 27)
        Me.lbl_pay_money.TabIndex = 103
        Me.lbl_pay_money.Text = "ចំនួនប្រាក់សង"
        '
        'txt_pay_date
        '
        Me.txt_pay_date.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pay_date.ForeColor = System.Drawing.Color.Navy
        Me.txt_pay_date.Location = New System.Drawing.Point(373, 204)
        Me.txt_pay_date.Multiline = True
        Me.txt_pay_date.Name = "txt_pay_date"
        Me.txt_pay_date.Size = New System.Drawing.Size(272, 28)
        Me.txt_pay_date.TabIndex = 102
        '
        'lbl_pay_date
        '
        Me.lbl_pay_date.AutoSize = True
        Me.lbl_pay_date.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_date.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pay_date.Location = New System.Drawing.Point(368, 172)
        Me.lbl_pay_date.Name = "lbl_pay_date"
        Me.lbl_pay_date.Size = New System.Drawing.Size(141, 27)
        Me.lbl_pay_date.TabIndex = 101
        Me.lbl_pay_date.Text = "កាលបរិច្ឆេទ សងប្រាក់"
        '
        'combo_loaner_name
        '
        Me.combo_loaner_name.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.combo_loaner_name.FormattingEnabled = True
        Me.combo_loaner_name.Location = New System.Drawing.Point(373, 134)
        Me.combo_loaner_name.Name = "combo_loaner_name"
        Me.combo_loaner_name.Size = New System.Drawing.Size(272, 35)
        Me.combo_loaner_name.TabIndex = 100
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Navy
        Me.txt_username.Location = New System.Drawing.Point(58, 134)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(289, 28)
        Me.txt_username.TabIndex = 99
        '
        'txt_loan_date
        '
        Me.txt_loan_date.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loan_date.ForeColor = System.Drawing.Color.Navy
        Me.txt_loan_date.Location = New System.Drawing.Point(58, 200)
        Me.txt_loan_date.Multiline = True
        Me.txt_loan_date.Name = "txt_loan_date"
        Me.txt_loan_date.Size = New System.Drawing.Size(289, 28)
        Me.txt_loan_date.TabIndex = 98
        '
        'lbl_loan_date
        '
        Me.lbl_loan_date.AutoSize = True
        Me.lbl_loan_date.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loan_date.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loan_date.Location = New System.Drawing.Point(53, 168)
        Me.lbl_loan_date.Name = "lbl_loan_date"
        Me.lbl_loan_date.Size = New System.Drawing.Size(126, 27)
        Me.lbl_loan_date.TabIndex = 97
        Me.lbl_loan_date.Text = "កាលបរិច្ឆេទ ខ្ចីប្រាក់"
        '
        'lbl_loaner_name
        '
        Me.lbl_loaner_name.AutoSize = True
        Me.lbl_loaner_name.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loaner_name.Location = New System.Drawing.Point(368, 102)
        Me.lbl_loaner_name.Name = "lbl_loaner_name"
        Me.lbl_loaner_name.Size = New System.Drawing.Size(78, 27)
        Me.lbl_loaner_name.TabIndex = 96
        Me.lbl_loaner_name.Text = "ឈ្មោះអ្នកខ្ចី"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Navy
        Me.lbl_username.Location = New System.Drawing.Point(53, 98)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(131, 27)
        Me.lbl_username.TabIndex = 95
        Me.lbl_username.Text = "អ្នកប្រើប្រាស់(hide)"
        '
        'lbl_title_user
        '
        Me.lbl_title_user.AutoSize = True
        Me.lbl_title_user.Font = New System.Drawing.Font("Khmer OS Muol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title_user.ForeColor = System.Drawing.Color.Navy
        Me.lbl_title_user.Location = New System.Drawing.Point(59, 23)
        Me.lbl_title_user.Name = "lbl_title_user"
        Me.lbl_title_user.Size = New System.Drawing.Size(152, 55)
        Me.lbl_title_user.TabIndex = 203
        Me.lbl_title_user.Text = "សងប្រាក់"
        '
        'frm_loaner_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 468)
        Me.Controls.Add(Me.lbl_title_user)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_rate_money)
        Me.Controls.Add(Me.lbl_rate_money)
        Me.Controls.Add(Me.txt_original_money)
        Me.Controls.Add(Me.lbl_original_money)
        Me.Controls.Add(Me.txt_orignal_money_owned)
        Me.Controls.Add(Me.lbl_orignal_money_owned)
        Me.Controls.Add(Me.txt_pay_money)
        Me.Controls.Add(Me.lbl_pay_money)
        Me.Controls.Add(Me.txt_pay_date)
        Me.Controls.Add(Me.lbl_pay_date)
        Me.Controls.Add(Me.combo_loaner_name)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_loan_date)
        Me.Controls.Add(Me.lbl_loan_date)
        Me.Controls.Add(Me.lbl_loaner_name)
        Me.Controls.Add(Me.lbl_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_loaner_payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btn_save As System.Windows.Forms.Button
    Private WithEvents txt_rate_money As System.Windows.Forms.TextBox
    Private WithEvents lbl_rate_money As System.Windows.Forms.Label
    Private WithEvents txt_original_money As System.Windows.Forms.TextBox
    Private WithEvents lbl_original_money As System.Windows.Forms.Label
    Private WithEvents txt_orignal_money_owned As System.Windows.Forms.TextBox
    Private WithEvents lbl_orignal_money_owned As System.Windows.Forms.Label
    Private WithEvents txt_pay_money As System.Windows.Forms.TextBox
    Private WithEvents lbl_pay_money As System.Windows.Forms.Label
    Private WithEvents txt_pay_date As System.Windows.Forms.TextBox
    Private WithEvents lbl_pay_date As System.Windows.Forms.Label
    Private WithEvents combo_loaner_name As System.Windows.Forms.ComboBox
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents txt_loan_date As System.Windows.Forms.TextBox
    Private WithEvents lbl_loan_date As System.Windows.Forms.Label
    Private WithEvents lbl_loaner_name As System.Windows.Forms.Label
    Private WithEvents lbl_username As System.Windows.Forms.Label
    Private WithEvents lbl_title_user As System.Windows.Forms.Label
End Class
