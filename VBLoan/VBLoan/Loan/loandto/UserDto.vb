Public Class UserDto
    Private _id As Integer
    Private _fullname As String
    Private _gender As String
    Private _address As String
    Private _phone As String
    Private _userName As String
    Private _password As String
    Private _usertype As String
    Private _createdate As String
    Private _createby As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property FullName As String
        Get
            Return _fullname
        End Get
        Set(value As String)
            _fullname = value
        End Set
    End Property
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property UserType() As String
        Get
            Return _usertype
        End Get
        Set(value As String)
            _usertype = value
        End Set
    End Property
    Public Property CreateBy() As String
        Get
            Return _createby
        End Get
        Set(value As String)
            _createby = value
        End Set
    End Property

    Public Property CreateDate() As String
        Get
            Return _createdate
        End Get
        Set(value As String)
            _createdate = value
        End Set
    End Property

End Class
