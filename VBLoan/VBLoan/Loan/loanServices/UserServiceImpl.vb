Public Class UserServiceImpl
    Implements UserService

    Public Function getLoginUser(userName As String) As UserDto Implements UserService.getLoginUser
        Dim userdto As New UserDto
        Dim sqlComm As New SqlClient.SqlCommand
        Dim ds As New DataSet
        Try
            LoanConnection.getConnection()
            If LoanConnection.Conn.State = ConnectionState.Closed Then
                LoanConnection.Conn.Open()
            End If

            With sqlComm
                .Connection = LoanConnection.Conn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getSelectLogin"
                .Parameters.Add("@username", SqlDbType.VarChar).Value = userName
            End With

            Dim adapter As New SqlClient.SqlDataAdapter(sqlComm)
            adapter.Fill(ds, "tbl_user")

            Dim UserRow As DataRow
            For Each UserRow In ds.Tables("tbl_user").Rows
                userdto.Id = UserRow("user_id").ToString
                userdto.FullName = UserRow("full_name").ToString
                userdto.Address = UserRow("address").ToString
                userdto.Gender = UserRow("gender").ToString
                userdto.Phone = UserRow("phone").ToString
                userdto.UserName = UserRow("username").ToString
                userdto.Password = UserRow("password").ToString
                userdto.CreateBy = UserRow("createby").ToString
                userdto.CreateDate = UserRow("createdate").ToString
                userdto.UserType = UserRow("usertype").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            LoanConnection.Conn.Close()
            sqlComm.Dispose()
        End Try
        Return userdto
    End Function

    Public Function getLoginPassword(OldPassword As String, NewPassword As String) As Boolean Implements UserService.getLoginPassword
        'Dim result As Boolean
        If OldPassword.Equals(NewPassword) Then
            Return True
        End If
        Return False
    End Function

    Public Function insertUserInformation(userDto As UserDto) As Boolean Implements UserService.insertUserInformation
        Dim sqlComm As New SqlClient.SqlCommand

        Try
            LoanConnection.getConnection()
            If LoanConnection.Conn.State = ConnectionState.Closed Then
                LoanConnection.Conn.Open()
            End If

            With sqlComm
                .Connection = LoanConnection.Conn
                .CommandText = "insertUserInformation"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@fullname", SqlDbType.VarChar).Value = userDto.FullName
                .Parameters.Add("@gender", SqlDbType.VarChar).Value = userDto.Gender
                .Parameters.Add("@phone", SqlDbType.VarChar).Value = userDto.Phone
                .Parameters.Add("@address", SqlDbType.VarChar).Value = userDto.Address
                .Parameters.Add("@username", SqlDbType.VarChar).Value = userDto.UserName
                .Parameters.Add("@password", SqlDbType.VarChar).Value = userDto.Password
            End With
            sqlComm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            LoanConnection.Conn.Close()
            sqlComm.Dispose()
        End Try
        Return False
    End Function

    Public Function getListUserInformation() As DataSet Implements UserService.getListUserInformation
        Dim ds As New DataSet
        Dim sqlComm As New SqlClient.SqlCommand
        Dim sqlAdapter As SqlClient.SqlDataAdapter

        Try
            LoanConnection.getConnection()
            If LoanConnection.Conn.State = ConnectionState.Closed Then
                LoanConnection.Conn.Open()
            End If

            With sqlComm
                .Connection = LoanConnection.Conn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getUserListInformation"
            End With

            sqlAdapter = New SqlClient.SqlDataAdapter(sqlComm)
            sqlAdapter.Fill(ds, "listuser")

        Catch ex As Exception
        Finally
            LoanConnection.Conn.Close()
            sqlComm.Dispose()
        End Try
        Return ds
    End Function

    Public Function getUserInformationById(userId As Integer) As UserDto Implements UserService.getUserInformationById
        Dim userDto As New UserDto
        Dim sqlComm As New SqlClient.SqlCommand
        Dim ds As New DataSet
        Try
            LoanConnection.getConnection()
            If LoanConnection.Conn.State = ConnectionState.Closed Then
                LoanConnection.Conn.Open()
            End If
            With sqlComm
                .CommandType = CommandType.StoredProcedure
                .Connection = LoanConnection.Conn
                .CommandText = "getUserById"
                .Parameters.Add("@userId", SqlDbType.Int).Value = userId
            End With

            Dim adapter As New SqlClient.SqlDataAdapter(sqlComm)
            adapter.Fill(ds, "tbl_user")

            Dim UserRow As DataRow
            For Each UserRow In ds.Tables("tbl_user").Rows
                userDto.Id = UserRow("user_id").ToString
                userDto.FullName = UserRow("full_name").ToString
                userDto.Address = UserRow("address").ToString
                userDto.Gender = UserRow("gender").ToString
                userDto.Phone = UserRow("phone").ToString
                userDto.UserName = UserRow("username").ToString
                userDto.Password = UserRow("password").ToString
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return userDto
    End Function

    Public Function getUserUpdateInformation(userDto As UserDto) As Boolean Implements UserService.getUserUpdateInformation
        Dim sqlComm As New SqlClient.SqlCommand

        Try
            LoanConnection.getConnection()
            If LoanConnection.Conn.State = ConnectionState.Closed Then
                LoanConnection.Conn.Open()
            End If

            With sqlComm
                .Connection = LoanConnection.Conn
                .CommandText = "getupdateUserbyId"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@userid", SqlDbType.Int).Value = userDto.Id
                .Parameters.Add("@fullname", SqlDbType.VarChar).Value = userDto.FullName.Trim
                .Parameters.Add("@username", SqlDbType.VarChar).Value = userDto.UserName.Trim
                .Parameters.Add("@gender", SqlDbType.VarChar).Value = userDto.Gender.Trim
                .Parameters.Add("@phone", SqlDbType.VarChar).Value = userDto.Phone.Trim
                .Parameters.Add("@password", SqlDbType.VarChar).Value = userDto.Password.Trim
                .Parameters.Add("@address", SqlDbType.VarChar).Value = userDto.Address.Trim
                .Parameters.Add("@createby", SqlDbType.VarChar).Value = userDto.CreateBy.Trim
            End With
            sqlComm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            LoanConnection.Conn.Close()
            sqlComm.Dispose()
        End Try
        Return False

    End Function
End Class
