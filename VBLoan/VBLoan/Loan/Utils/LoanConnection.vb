Imports System.Data.SqlClient

Public Class LoanConnection
    Public Shared Conn As New SqlConnection()

    Public Shared Sub getConnection()
        Dim StrConn As String = "Data Source=EKOSAL;Initial Catalog=vbloan;User ID=sa;Password=ekosal"
        Conn = New SqlConnection(StrConn)
    End Sub

End Class
