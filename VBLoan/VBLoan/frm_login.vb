Public Class frm_login
    Dim user As New UserServiceImpl()
    Dim userDto As New UserDto

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_password.PasswordChar = "*"
    End Sub

    Private Sub btnCloseLogin_Click(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Me.Close()
    End Sub

    Private Sub txt_username_GotFocus(sender As Object, e As EventArgs) Handles txt_username.GotFocus
        txt_username.Text = ""
        Me.txt_username.ForeColor = Color.Black
    End Sub


    Private Sub txt_username_LostFocus(sender As Object, e As EventArgs) Handles txt_username.LostFocus
        If txt_username.Text = "" Then
            txt_username.Text = "បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់......"
            txt_username.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txt_password_GotFocus(sender As Object, e As EventArgs) Handles txt_password.GotFocus
        txt_password.Text = ""
        Me.txt_password.ForeColor = Color.Black
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btn_login_Click(sender, e)
        End If
    End Sub

    Private Sub txt_password_LostFocus(sender As Object, e As EventArgs) Handles txt_password.LostFocus
        If txt_password.Text = "" Then
            txt_password.Text = "បញ្ចូលលេខសំងាត់អ្នកប្រើប្រាស់......"
            txt_password.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        userDto = user.getLoginUser(Me.txt_username.Text)
        If txt_username.Text.Trim.Equals("បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់......") Then
            MsgBox("សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស!", MsgBoxStyle.Information, "អ្នកចូលប្រើប្រាស់")
            Return
        End If

        If txt_password.Text.Trim.Equals("បញ្ចូលលេខសំងាត់អ្នកប្រើប្រាស់......") Then
            MsgBox("សូមបញ្ចូលលេខសម្ងាត់របស់អ្នក!", MsgBoxStyle.Information, "អ្នកចូលប្រើប្រាស់")
            Return
        End If

        If userDto.UserName = "" Then
            MsgBox("អ្នកប្រើប្រាស់មិនត្រឹមត្រូវទេ", MsgBoxStyle.Information, "អ្នកចូលប្រើប្រាស់")
            txt_username.Focus()
        Else
            If user.getLoginPassword(userDto.Password, txt_password.Text) = False Then
                MsgBox("លេខសំងាត់មិនត្រឹមត្រូវទេ", MsgBoxStyle.Information, "អ្នកចូលប្រើប្រាស់")
                txt_password.Focus()
            Else
                UserUtils.userId = userDto.Id
                UserUtils.username = userDto.UserName
                UserUtils.usertype = userDto.UserType
                Me.Hide()
                Dim frmMain As New frm_main
                frmMain.Show()
            End If
        End If
    End Sub
End Class