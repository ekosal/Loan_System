<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loaner
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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txt_account_id = New System.Windows.Forms.TextBox()
        Me.lbl_account_id = New System.Windows.Forms.Label()
        Me.txt_loaner_name = New System.Windows.Forms.TextBox()
        Me.lbl_loaner_name = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Navy
        Me.btn_save.Location = New System.Drawing.Point(63, 379)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(272, 35)
        Me.btn_save.TabIndex = 48
        Me.btn_save.Text = "រក្សាទុក"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Navy
        Me.txt_username.Location = New System.Drawing.Point(63, 140)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(272, 28)
        Me.txt_username.TabIndex = 47
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Navy
        Me.txt_address.Location = New System.Drawing.Point(63, 335)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(272, 28)
        Me.txt_address.TabIndex = 46
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Navy
        Me.lbl_address.Location = New System.Drawing.Point(58, 303)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(82, 27)
        Me.lbl_address.TabIndex = 45
        Me.lbl_address.Text = "អាស័យដ្ថាន"
        '
        'txt_account_id
        '
        Me.txt_account_id.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_account_id.ForeColor = System.Drawing.Color.Navy
        Me.txt_account_id.Location = New System.Drawing.Point(63, 270)
        Me.txt_account_id.Multiline = True
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.Size = New System.Drawing.Size(272, 28)
        Me.txt_account_id.TabIndex = 44
        '
        'lbl_account_id
        '
        Me.lbl_account_id.AutoSize = True
        Me.lbl_account_id.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_id.ForeColor = System.Drawing.Color.Navy
        Me.lbl_account_id.Location = New System.Drawing.Point(58, 238)
        Me.lbl_account_id.Name = "lbl_account_id"
        Me.lbl_account_id.Size = New System.Drawing.Size(102, 27)
        Me.lbl_account_id.TabIndex = 43
        Me.lbl_account_id.Text = "លេចកូដគណនី"
        '
        'txt_loaner_name
        '
        Me.txt_loaner_name.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.txt_loaner_name.Location = New System.Drawing.Point(63, 205)
        Me.txt_loaner_name.Multiline = True
        Me.txt_loaner_name.Name = "txt_loaner_name"
        Me.txt_loaner_name.Size = New System.Drawing.Size(272, 28)
        Me.txt_loaner_name.TabIndex = 42
        '
        'lbl_loaner_name
        '
        Me.lbl_loaner_name.AutoSize = True
        Me.lbl_loaner_name.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loaner_name.ForeColor = System.Drawing.Color.Navy
        Me.lbl_loaner_name.Location = New System.Drawing.Point(58, 173)
        Me.lbl_loaner_name.Name = "lbl_loaner_name"
        Me.lbl_loaner_name.Size = New System.Drawing.Size(78, 27)
        Me.lbl_loaner_name.TabIndex = 41
        Me.lbl_loaner_name.Text = "ឈ្មោះអ្នកខ្ចី"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Navy
        Me.lbl_username.Location = New System.Drawing.Point(58, 104)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(131, 27)
        Me.lbl_username.TabIndex = 40
        Me.lbl_username.Text = "អ្នកប្រើប្រាស់(hide)"
        '
        'frm_loaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 464)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.txt_account_id)
        Me.Controls.Add(Me.lbl_account_id)
        Me.Controls.Add(Me.txt_loaner_name)
        Me.Controls.Add(Me.lbl_loaner_name)
        Me.Controls.Add(Me.lbl_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_loaner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btn_save As System.Windows.Forms.Button
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents txt_address As System.Windows.Forms.TextBox
    Private WithEvents lbl_address As System.Windows.Forms.Label
    Private WithEvents txt_account_id As System.Windows.Forms.TextBox
    Private WithEvents lbl_account_id As System.Windows.Forms.Label
    Private WithEvents txt_loaner_name As System.Windows.Forms.TextBox
    Private WithEvents lbl_loaner_name As System.Windows.Forms.Label
    Private WithEvents lbl_username As System.Windows.Forms.Label
End Class
