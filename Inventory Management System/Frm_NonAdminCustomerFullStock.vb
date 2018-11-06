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

        If Frm_Login.ConnectionStatus = True Then

            Dim Connection As New MySqlConnection(Frm_Login.ConnectionString)

            Dim Command As String = "SELECT Items.ItemID, ItemName, ItemBarcode, Stock, InUse, InMaintenance FROM Items, ItemStatus, Stock WHERE Items.ItemID = ItemStatus.ItemID AND Items.ItemID = Stock.ItemID;"
            Dim MyCommand As New MySqlCommand(Command, Connection)

            Connection.Open()
            Dim response As MySqlDataReader
            response = MyCommand.ExecuteReader()

            Lst_VenueA.Items.Clear()

            While response.Read()
                Dim C(6) As String
                Dim LvItem As New ListViewItem

                C(1) = response.GetString(1) 'ItemName
                C(2) = response.GetString(0) 'ItemID
                C(3) = response.GetString(2) 'ItemBarcode
                C(4) = response.GetString(3) 'Stock
                C(5) = response.GetString(4) 'InUse
                C(6) = response.GetString(5) 'InMaintenance

                LvItem = Lst_VenueA.Items.Add(C(1))
                LvItem.SubItems.AddRange(New String() {C(2), C(3), C(4), C(5), C(6)})

            End While

            Connection.Close()
            response.Close()
        Else
            MsgBox("Unable to load database as offline login was used")
        End If

    End Sub

    Private Sub Frm_NonAdminCustomerFullStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshListView()

    End Sub
End Class