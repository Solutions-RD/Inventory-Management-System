Public Class Frm_NonAdminCustomer
    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click

        Frm_NonAdminUser.Show()
        Me.Visible = False
    End Sub
End Class