Public Interface UserService
    Function getLoginUser(ByVal userName As String) As UserDto
    Function getLoginPassword(ByVal OldPassword As String, ByVal NewPassword As String) As Boolean
    Function insertUserInformation(ByVal userDto As UserDto) As Boolean
    Function getListUserInformation() As DataSet
    Function getUserInformationById(ByVal userId As Integer) As UserDto
    Function getUserUpdateInformation(ByVal userDto As UserDto) As Boolean
End Interface
