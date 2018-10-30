Public Class Frm_NonAdminCustomer
    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click

        Frm_NonAdminUser.Show()
        Me.Visible = False
    End Sub


    Private Sub Rbt_InHouse_CheckedChanged_1(sender As Object, e As EventArgs) Handles Rbt_InHouse.CheckedChanged

        If Rbt_InHouse.Checked = True Then
            Lbl_CustomerEmail.Visible = False
            Lbl_CustomerNo.Visible = False
            Txb_CustomerEmail.Visible = False
            Txb_CustomerEmail.Text = ("")
            Txb_CustomerNo.Visible = False
            Txb_CustomerNo.Text = ("")

        Else
            Lbl_CustomerEmail.Visible = True
            Lbl_CustomerNo.Visible = True
            Txb_CustomerEmail.Visible = True
            Txb_CustomerEmail.Text = ("")
            Txb_CustomerNo.Visible = True
            Txb_CustomerNo.Text = ("")


        End If

    End Sub

    Private Sub Btn_SaveCustomer_Click(sender As Object, e As EventArgs) Handles Btn_SaveCustomer.Click



        TabControl1.TabPages.Add("")

    End Sub
End Class