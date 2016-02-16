<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_title_user = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCloseLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_password.Font = New System.Drawing.Font("Khmer OS Bokor", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_password.Location = New System.Drawing.Point(295, 275)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(285, 40)
        Me.txt_password.TabIndex = 2
        Me.txt_password.Text = "បញ្ចូលលេខសំងាត់អ្នកប្រើប្រាស់......"
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Yellow
        Me.btn_login.Image = Global.VBLoan.My.Resources.Resources._0001
        Me.btn_login.Location = New System.Drawing.Point(295, 324)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(285, 45)
        Me.btn_login.TabIndex = 3
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'txt_username
        '
        Me.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Bokor", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_username.Location = New System.Drawing.Point(295, 231)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(285, 40)
        Me.txt_username.TabIndex = 1
        Me.txt_username.Text = "បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់......"
        '
        'lbl_title_user
        '
        Me.lbl_title_user.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title_user.Font = New System.Drawing.Font("Khmer OS Muol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title_user.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_title_user.Image = Global.VBLoan.My.Resources.Resources.Layer_2
        Me.lbl_title_user.Location = New System.Drawing.Point(367, 80)
        Me.lbl_title_user.Name = "lbl_title_user"
        Me.lbl_title_user.Size = New System.Drawing.Size(142, 84)
        Me.lbl_title_user.TabIndex = 203
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Image = Global.VBLoan.My.Resources.Resources.Admin_ចូលទៅកាន់គណនីរបស់អ្នក
        Me.Label1.Location = New System.Drawing.Point(281, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 84)
        Me.Label1.TabIndex = 204
        '
        'btnCloseLogin
        '
        Me.btnCloseLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseLogin.Image = Global.VBLoan.My.Resources.Resources.XXXX
        Me.btnCloseLogin.Location = New System.Drawing.Point(791, 3)
        Me.btnCloseLogin.Name = "btnCloseLogin"
        Me.btnCloseLogin.Size = New System.Drawing.Size(38, 23)
        Me.btnCloseLogin.TabIndex = 205
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VBLoan.My.Resources.Resources._0000_외화송금_어드민_초기화면_151218
        Me.ClientSize = New System.Drawing.Size(830, 528)
        Me.Controls.Add(Me.btnCloseLogin)
        Me.Controls.Add(Me.lbl_title_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txt_password As System.Windows.Forms.TextBox
    Private WithEvents btn_login As System.Windows.Forms.Button
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents lbl_title_user As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCloseLogin As System.Windows.Forms.Label
End Class
