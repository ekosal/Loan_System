Public Class frm_user

    Dim userService As UserService = New UserServiceImpl

    Private Sub btn_SaveUser_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub txt_fullname_GotFocus(sender As Object, e As EventArgs) Handles txt_fullname.GotFocus
        StringUtils.getFocus(txt_fullname)
    End Sub

    Private Sub txt_fullname_LostFocus(sender As Object, e As EventArgs) Handles txt_fullname.LostFocus
        StringUtils.lostFocus(txt_fullname, "បញ្ចូលឈ្មោះពេញអ្នកប្រើប្រាស់......")
    End Sub

    Private Sub txt_phone_GotFocus(sender As Object, e As EventArgs) Handles txt_phone.GotFocus
        StringUtils.getFocus(txt_phone)
    End Sub

    Private Sub txt_phone_LostFocus(sender As Object, e As EventArgs) Handles txt_phone.LostFocus
        StringUtils.lostFocus(txt_phone, "បញ្ចូលលេខទូរស័ព្ទអ្នកប្រើប្រាស់......")
    End Sub

    Private Sub txt_username_GotFocus(sender As Object, e As EventArgs) Handles txt_username.GotFocus
        StringUtils.getFocus(txt_username)
    End Sub

    Private Sub txt_username_LostFocus(sender As Object, e As EventArgs) Handles txt_username.LostFocus
        StringUtils.lostFocus(txt_username, "បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់......")
    End Sub

    Private Sub txt_password_GotFocus(sender As Object, e As EventArgs) Handles txt_password.GotFocus
        StringUtils.getFocus(txt_password)
    End Sub

    Private Sub txt_password_LostFocus(sender As Object, e As EventArgs) Handles txt_password.LostFocus
        StringUtils.lostFocus(txt_password, "បញ្ចូលលេខសម្ងាត់អ្នកប្រើប្រាស់......")
    End Sub

    Private Sub txt_ComfirmPWD_GotFocus(sender As Object, e As EventArgs) Handles txt_ComfirmPWD.GotFocus
        StringUtils.getFocus(txt_ComfirmPWD)
    End Sub

    Private Sub txt_ComfirmPWD_LostFocus(sender As Object, e As EventArgs) Handles txt_ComfirmPWD.LostFocus
        StringUtils.lostFocus(txt_ComfirmPWD, "ផ្ទៀងផ្ទាត់លេខសម្ងាត់អ្នកប្រើប្រាស់......")
    End Sub

    Private Sub txt_address_GotFocus(sender As Object, e As EventArgs) Handles txt_address.GotFocus
        StringUtils.getFocus(txt_address)
    End Sub

    Private Sub txt_address_Layout(sender As Object, e As LayoutEventArgs) Handles txt_address.Layout
        StringUtils.lostFocus(txt_address, "បញ្ចូលអាស័ដ្ឋានអ្នកប្រើប្រាស់...... ")
    End Sub

    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim userDto As New UserDto
        If UserUtils.usertype <> "admin" Then
            btn_search.Enabled = False
            btn_SaveUser.Enabled = False
            btn_delete.Enabled = False
            dgv_User.Enabled = False
            btnCancel.Enabled = False
            txt_searchtext.Enabled = False

            userDto = userService.getUserInformationById(UserUtils.userId)
            txt_fullname.Text = userDto.FullName
            If userDto.Gender = "0" Then
                rdb_Male.Checked = True
            End If
            If userDto.Gender = "1" Then
                rdb_Female.Checked = True
            End If

            txt_username.Text = userDto.UserName
            txt_phone.Text = userDto.Phone
            txt_password.Text = userDto.Password
            txt_ComfirmPWD.Text = userDto.Password
            txt_address.Text = userDto.Address
            txt_userId.Text = userDto.Id


            txt_ComfirmPWD.ForeColor = Color.Black
            txt_fullname.ForeColor = Color.Black
            txt_phone.ForeColor = Color.Black
            txt_username.ForeColor = Color.Black
            txt_password.ForeColor = Color.Black
            txt_ComfirmPWD.ForeColor = Color.Black
            txt_address.ForeColor = Color.Black

        Else
            With dgv_User.ColumnHeadersDefaultCellStyle
                .Alignment = DataGridViewContentAlignment.MiddleLeft
                .BackColor = Color.DarkRed
                .ForeColor = Color.Gold
                .Font = New Font(.Font.FontFamily, .Font.Size, _
                .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            End With

            dgv_User.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
            dgv_User.BackgroundColor = Color.LightGray
            dgv_User.RowTemplate.Height = 35


            dgv_User.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            dgv_User.DefaultCellStyle.SelectionForeColor = Color.Black

            ' dgv_User.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            dgv_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv_User.AllowUserToResizeColumns = False

            'dgv_User.RowsDefaultCellStyle.BackColor = Color.Bisque
            'dgv_User.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige


            ds = userService.getListUserInformation
            Dim countRow As Integer = ds.Tables("listuser").Rows.Count
            If countRow < 1 Then
                dgv_User.Refresh()
            Else
                dgv_User.Rows.Add(countRow)
                For i As Integer = 0 To countRow - 1
                    With dgv_User
                        .Rows(i).Cells("no").Value = ds.Tables("listuser").Rows(i).Item("RNO")
                        .Rows(i).Cells("fullname").Value = ds.Tables("listuser").Rows(i).Item("fullname")
                        .Rows(i).Cells("gender").Value = ds.Tables("listuser").Rows(i).Item("gender")
                        .Rows(i).Cells("phone").Value = ds.Tables("listuser").Rows(i).Item("phone")
                        .Rows(i).Cells("address").Value = ds.Tables("listuser").Rows(i).Item("address")
                        .Rows(i).Cells("user_id").Value = ds.Tables("listuser").Rows(i).Item("user_id")
                    End With
                Next
            End If
            ds.Reset()
        End If

    End Sub

    Private Sub dgv_User_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_User.CellClick
        Dim userId = Me.dgv_User.CurrentRow.Cells("user_id").Value
    End Sub

    Private Sub btn_SaveUser_Click_1(sender As Object, e As EventArgs) Handles btn_SaveUser.Click
        Dim userDto As New UserDto
        Dim gender As String = ""
        If rdb_Female.Checked = True Then
            gender = "1"
        End If
        If rdb_Male.Checked = True Then
            gender = "0"
        End If

        checkinput()

        userDto.FullName = txt_fullname.Text
        userDto.Gender = gender
        userDto.Phone = txt_phone.Text
        userDto.Address = txt_address.Text
        userDto.UserName = txt_username.Text
        userDto.Password = txt_password.Text
        userDto.UserType = "user"
        userDto.CreateBy = UserUtils.userId
        If userService.insertUserInformation(userDto) = True Then
            MsgBox("successfull")
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim userdto As New UserDto
        Dim gender As String = "0"
        Dim mainfrm As New frm_main
        userdto.FullName = txt_fullname.Text
        userdto.UserName = txt_username.Text
        If rdb_Female.Checked = True Then
            gender = "1"
        End If
        If rdb_Male.Checked = True Then
            gender = "0"
        End If

        checkinput()

        userdto.Phone = txt_phone.Text
        userdto.Password = txt_password.Text
        userdto.Address = txt_address.Text
        userdto.CreateBy = txt_userId.Text
        userdto.Id = UserUtils.userId
        userdto.Gender = gender
        If userService.getUserUpdateInformation(userdto) Then
            If UserUtils.usertype <> "admin" Then
                Me.Close()
                Dim frmlogin As New frm_login
                frmlogin.Show()
            Else
                If userdto.CreateBy.Trim.Equals(CStr(userdto.Id)) Then
                    Me.Close()
                    Dim frmlogin As New frm_login
                    frmlogin.Show()
                End If
            End If
            clearControl()
        End If
        

    End Sub
    Sub clearControl()
        Me.txt_fullname.Clear()
        Me.txt_phone.Clear()
        Me.rdb_Female.Checked = False
        Me.rdb_Male.Checked = True
        Me.txt_username.Clear()
        Me.txt_password.Clear()
        Me.txt_ComfirmPWD.Clear()
        Me.txt_address.Clear()
    End Sub
    Sub checkinput()

        Dim frmMessage As New message_information
        If txt_fullname.Text.Trim.Equals("បញ្ចូលឈ្មោះពេញអ្នកប្រើប្រាស់......") Then
            frmMessage.btn_msg_ok.Focus()
            frmMessage.lbl_contentMessage.Text = "សូមបញ្ចូលឈោ្មះពេញអ្នកប្រើប្រាស!!!"
            frmMessage.ShowDialog()
            Me.txt_fullname.Focus()
            Return
        End If
        If txt_phone.Text.Trim.Equals("បញ្ចូលលេខទូរស័ព្ទអ្នកប្រើប្រាស់......") Or txt_phone.Text.Trim.Equals("") Then
            frmMessage.btn_msg_ok.Focus()
            frmMessage.lbl_contentMessage.Text = "សូមបញ្ចូលលេខទូរស័ព្ទរបស់អ្នកប្រើប្រាស់!!!"
            frmMessage.ShowDialog()
            Me.txt_phone.Focus()
            Return
        End If

        If txt_username.Text.Trim.Equals("បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់......") Or txt_username.Text.Trim.Equals("") Then
            frmMessage.btn_msg_ok.Focus()
            frmMessage.lbl_contentMessage.Text = "សូមបញ្ចូលឈោ្នះអ្នកចូលប្រើប្រាស់ប្រព័ន្ធ!!"
            frmMessage.ShowDialog()
            Me.txt_username.Focus()
        End If

        If txt_password.Text.Trim.Equals("បញ្ចូលលេខសម្ងាត់អ្នកប្រើប្រាស់......") Or txt_password.Text.Trim.Equals("") Then
            frmMessage.btn_msg_ok.Focus()
            frmMessage.lbl_contentMessage.Text = "សូមបញ្ចូលលេខសម្ងាត់របស់អ្នក!!!"
            frmMessage.ShowDialog()
            Me.txt_password.Focus()
        End If
        If txt_ComfirmPWD.Text.Trim.Equals("ផ្ទៀងផ្ទាត់លេខសម្ងាត់អ្នកប្រើប្រាស់......") Or txt_ComfirmPWD.Text.Trim.Equals("") Then
            frmMessage.btn_msg_ok.Focus()
            frmMessage.lbl_contentMessage.Text = "សូមធ្វើការផ្ទៀងផ្ទាត់លេខសម្ងាត់របស់អ្នកឡើងវិញ!!!"
            frmMessage.ShowDialog()
            Me.txt_ComfirmPWD.Focus()
        End If

        If txt_address.Text.Trim.Equals("បញ្ចូលអាស័ដ្ឋានអ្នកប្រើប្រាស់......") Or txt_address.Text.Trim.Equals("") Then
            frmMessage.btn_msg_ok.Focus()
            frmMessage.lbl_contentMessage.Text = "សូមបញ្ចូលអាស័យដ្ឋានរបស់អ្នក!!!"
            frmMessage.ShowDialog()
            Me.txt_address.Focus()
        End If

        

        If txt_password.Text.Equals(txt_ComfirmPWD.Text) = False Then
            MsgBox("លេខសម្ងាតផ្ទៀងផ្ទាត់មិនត្រូវគ្នាទេ!!!", MsgBoxStyle.Information, "ផ្ទៀងផ្ទាត់លេខសម្ងាត់")
            Return
        End If
    End Sub
End Class