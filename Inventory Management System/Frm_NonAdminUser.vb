Public Class Frm_NonAdminUser
    Private Sub Btn_Customer_Click_1(sender As Object, e As EventArgs) Handles Btn_Customer.Click

        Frm_NonAdminCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click


    End Sub

    Private Sub Btn_FullStock_Click(sender As Object, e As EventArgs) Handles Btn_FullStock.Click

        Frm_NonAdminCustomerFullStock.Show()
        Me.Visible = False

    End Sub

    Private Sub Btn_LookUp_Click(sender As Object, e As EventArgs) Handles Btn_LookUp.Click

        Frm_NonAdminUserLookUp.show()
        Me.Hide()

    End Sub

    Private Sub Btn_Supplier_Click(sender As Object, e As EventArgs) Handles Btn_Supplier.Click

        Frm_NonAdminUserSupplier.show()
        Me.Hide()

    End Sub

    Private Sub Frm_NonAdminUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class