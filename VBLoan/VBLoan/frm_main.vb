Public Class frm_main


    Private Sub lbl_userLoand_Click(sender As Object, e As EventArgs) Handles lbl_userLoand.Click
        StringUtils.loadingSubForm(frm_user, Me.splitContainer1.Panel2)
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        Dim frm As New frm_loaner
        frm.Show()
    End Sub
End Class
