Public Class StringUtils
    Public Shared Sub loadingSubForm(ByVal frm As Form, ByVal panel As SplitterPanel)
        frm.TopLevel = False
        panel.Controls.Add(frm)
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Public Shared Sub lostFocus(ByVal textBox As TextBox, ByVal msg As String)
        If textBox.Text = "" Then
            textBox.Text = msg
            textBox.ForeColor = Color.DarkGray
        End If
    End Sub
    Public Shared Sub getFocus(ByVal textBox As TextBox)
        textBox.Text = ""
        textBox.Focus()
        textBox.ForeColor = Color.Black
    End Sub
End Class
