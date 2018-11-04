Imports MySql.Data.MySqlClient

Public Class Frm_NonAdminCustomerFullStock

    Private Sub Btn_Customer_Click_1(sender As Object, e As EventArgs) Handles Btn_Customer.Click

        Frm_NonAdminCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click

        Frm_NonAdminUser.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_FullStock_Click(sender As Object, e As EventArgs) Handles Btn_FullStock.Click


    End Sub

    Private Sub Btn_LookUp_Click(sender As Object, e As EventArgs) Handles Btn_LookUp.Click

        Frm_NonAdminUserLookUp.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Supplier_Click(sender As Object, e As EventArgs) Handles Btn_Supplier.Click

        Frm_NonAdminUserSupplier.Show()
        Me.Hide()

    End Sub

    Private Sub RefreshListView()

        Dim Connection As New MySqlConnection(Frm_Login.ConnectionString)

        Dim Command As String = "SELECT items.itemID, ItemName, ItemBarcode, Stock, InUse, InMaintenance FROM items, itemstatus, stock WHERE items.itemID = itemstatus.itemID AND items.itemID = Stock.itemID;"
        Dim MyCommand As New MySqlCommand(Command, Connection)

        Connection.Open()
        Dim response As String = MyCommand.ExecuteScalar()
        Connection.Close()

        MsgBox(response.ToString)

    End Sub

    Private Sub Frm_NonAdminCustomerFullStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshListView()

    End Sub
End Class