﻿Public Class Frm_NonAdminUserSupplier
    Private Sub Btn_Customer_Click_1(sender As Object, e As EventArgs) Handles Btn_Customer.Click

        Frm_NonAdminCustomer.Show()
        Me.Hide()
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

    End Sub
End Class