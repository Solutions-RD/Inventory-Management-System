Imports MySql.Data.MySqlClient

Public Class Frm_NonAdminCustomerFullStock

    Private Sub Btn_Customer_Click_1(sender As Object, e As EventArgs) Handles Btn_Customer.Click

        Frm_NonAdminCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        'This is a comment
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

        MonthCalendar1.MinDate = DateTime.Today()
        RefreshListView()

    End Sub

    Private Sub Grb_ViewTable_Enter(sender As Object, e As EventArgs) Handles Grb_ViewTable.Enter

    End Sub

    Private Sub Btn_AddNew_Click(sender As Object, e As EventArgs) Handles Btn_AddNew.Click
        Grb_AddNew.Visible = True
        Grb_AddNew.Enabled = True
        Grb_ViewTable.Enabled = False
        Grb_ViewTable.Visible = False

    End Sub

    Private Sub Btn_SavetoDB_Click(sender As Object, e As EventArgs) Handles Btn_SavetoDB.Click

        Dim Catagory, Name, Customer, CurrentStatus, Barcode As String

        Catagory = Cb_Cat.Text
        Name = Tbx_Name.Text
        Customer = Cb_Customer.Text
        CurrentStatus = Cb_Status.Text
        Barcode = txt_Barcode.Text

        Dim ErrorMessage As String = CheckValidInputs(Catagory, Name, Customer, CurrentStatus, Barcode)

        If Len(ErrorMessage) = 0 Then
            SaveSettings(Catagory, Name, Customer, CurrentStatus, Barcode)

            Grb_ViewTable.Enabled = True
            Grb_ViewTable.Visible = True
            Grb_AddNew.Visible = False
            Grb_AddNew.Enabled = False
        Else
            MsgBox("Invalid input with these errors:" & vbCrLf & vbCrLf & ErrorMessage)
        End If

    End Sub

    Function CheckValidInputs(ByVal Catagory As String, ByVal Name As String, ByVal Customer As String, ByVal CurrentStatus As String, ByVal Barcode As String)
        Dim ErrorMessage As String = ""

        If IsNumeric(Barcode) = False Or Len(Barcode) = 0 Then
            ErrorMessage = ErrorMessage + "Barcode must be numerical value!" & vbCrLf
        End If

        If Catagory = "" Then
            ErrorMessage = ErrorMessage + "Catagory must not be empty!" & vbCrLf
        End If

        If Name = "" Then
            ErrorMessage = ErrorMessage + "Name must not be empty!" & vbCrLf
        End If

        If Customer = "" Then
            ErrorMessage = ErrorMessage + "Customer must not be empty!" & vbCrLf
        End If

        If CurrentStatus = "" Then
            ErrorMessage = ErrorMessage + "Current Status must not be empty!" & vbCrLf
        End If

        Return ErrorMessage
    End Function

    Sub SaveSettings(ByVal Catagory As String, ByVal Name As String, ByVal Customer As String, ByVal CurrentStatus As String, ByVal Barcode As Integer)

        Dim Connection As New MySqlConnection(Frm_Login.ConnectionString)

        Dim Command As String = "INSERT INTO Items(ItemName, ItemBarcode) VALUES (@Name, @Barcode);" 'Creating the Item
        Dim MyCommand As New MySqlCommand(Command, Connection)

        With MyCommand
            .Parameters.Add("@Name", MySqlDbType.LongText).Value = Name
            .Parameters.Add("@Barcode", MySqlDbType.Int64).Value = Barcode
        End With

        Connection.Open()
        MyCommand.ExecuteReader()
        Connection.Close()


        Command = "SELECT ItemID FROM Items WHERE ItemName = @Name AND Barcode = @Barcode" 'Getting the Items auto assigned ID
        MyCommand = New MySqlCommand(Command, Connection)

        With MyCommand
            .Parameters.Add("@Name", MySqlDbType.LongText).Value = Name
            .Parameters.Add("@Barcode", MySqlDbType.Int64).Value = Barcode
        End With

        Connection.Open()
        Dim Response As String = MyCommand.ExecuteScalar
        Dim ItemID As String = Response(0)
        Connection.Close()

        MsgBox(ItemID)

    End Sub
End Class