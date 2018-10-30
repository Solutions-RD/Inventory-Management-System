Public Class Frm_NonAdminCustomer
    Private Sub Btn_Customer_Click_1(sender As Object, e As EventArgs) Handles Btn_Customer.Click

    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click

        Frm_NonAdminUser.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_FullStock_Click(sender As Object, e As EventArgs) Handles Btn_FullStock.Click

        Frm_NonAdminCustomerFullStock.Show()
        Me.Visible = False

    End Sub

    Private Sub Btn_LookUp_Click(sender As Object, e As EventArgs) Handles Btn_LookUp.Click

        Frm_NonAdminUserLookUp.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Supplier_Click(sender As Object, e As EventArgs) Handles Btn_Supplier.Click

        Frm_NonAdminUserSupplier.Show()
        Me.Hide()

    End Sub


    Private Sub Rbt_InHouse_CheckedChanged_1(sender As Object, e As EventArgs) Handles Rbt_InHouse.CheckedChanged

        If Rbt_InHouse.Checked = True Then
            Lbl_CustomerEmail.Visible = False
            Lbl_CustomerNo.Visible = False
            Txb_CustomerEmail.Visible = False
            Txb_CustomerEmail.Text = ("")
            Txb_CustomerNo.Visible = False
            Txb_CustomerNo.Text = ("")

        End If

    End Sub

    Private Sub Btn_SaveCustomer_Click(sender As Object, e As EventArgs) Handles Btn_SaveCustomer.Click



        TabControl1.TabPages.Add("")

    End Sub

    Private Sub Btn_Customer_Click(sender As Object, e As EventArgs) Handles Btn_Customer.Click

    End Sub
End Class