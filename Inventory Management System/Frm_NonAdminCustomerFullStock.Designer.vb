<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NonAdminCustomerFullStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Clm_CatagoryC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lst_VenueD = New System.Windows.Forms.ListView()
        Me.Clm_ProductsD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductsIDD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tb_VenueA = New System.Windows.Forms.TabPage()
        Me.Lst_VenueA = New System.Windows.Forms.ListView()
        Me.Clm_ProductA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductIDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_BarcodeA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_StockA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_Use = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_Maintenance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_Notes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueB = New System.Windows.Forms.TabPage()
        Me.Lst_VenueB = New System.Windows.Forms.ListView()
        Me.Clm_ProductB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_IDB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueC = New System.Windows.Forms.TabPage()
        Me.Lst_VenueC = New System.Windows.Forms.ListView()
        Me.Clm_ProductC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductIDC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueD = New System.Windows.Forms.TabPage()
        Me.Btn_Home = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Supplier = New System.Windows.Forms.Button()
        Me.Btn_Customer = New System.Windows.Forms.Button()
        Me.Btn_LookUp = New System.Windows.Forms.Button()
        Me.Grp_Menu = New System.Windows.Forms.GroupBox()
        Me.Btn_AddNew = New System.Windows.Forms.Button()
        Me.Btn_FullStock = New System.Windows.Forms.Button()
        Me.Grb_ViewTable = New System.Windows.Forms.GroupBox()
        Me.Grb_AddNew = New System.Windows.Forms.GroupBox()
        Me.Btn_SavetoDB = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_Status = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cb_Cat = New System.Windows.Forms.ComboBox()
        Me.Cb_Customer = New System.Windows.Forms.ComboBox()
        Me.Tbx_Name = New System.Windows.Forms.TextBox()
        Me.Txb_ProductID = New System.Windows.Forms.TextBox()
        Me.Txb_Notes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TabControl1.SuspendLayout()
        Me.Tb_VenueA.SuspendLayout()
        Me.Tb_VenueB.SuspendLayout()
        Me.Tb_VenueC.SuspendLayout()
        Me.Tb_VenueD.SuspendLayout()
        Me.Grp_Menu.SuspendLayout()
        Me.Grb_ViewTable.SuspendLayout()
        Me.Grb_AddNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'Clm_CatagoryC
        '
        Me.Clm_CatagoryC.Text = "Catagory"
        '
        'Clm_ReportsC
        '
        Me.Clm_ReportsC.Text = "Reports"
        '
        'Lst_VenueD
        '
        Me.Lst_VenueD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductsD, Me.Clm_ProductsIDD, Me.Clm_CatagoryD, Me.Clm_ServiceDatesD, Me.Clm_ReportsD})
        Me.Lst_VenueD.GridLines = True
        Me.Lst_VenueD.Location = New System.Drawing.Point(6, 6)
        Me.Lst_VenueD.Name = "Lst_VenueD"
        Me.Lst_VenueD.Size = New System.Drawing.Size(385, 264)
        Me.Lst_VenueD.TabIndex = 4
        Me.Lst_VenueD.UseCompatibleStateImageBehavior = False
        Me.Lst_VenueD.View = System.Windows.Forms.View.Details
        '
        'Clm_ProductsD
        '
        Me.Clm_ProductsD.Text = "Product"
        Me.Clm_ProductsD.Width = 100
        '
        'Clm_ProductsIDD
        '
        Me.Clm_ProductsIDD.Text = "ID"
        '
        'Clm_CatagoryD
        '
        Me.Clm_CatagoryD.Text = "Catagory"
        '
        'Clm_ServiceDatesD
        '
        Me.Clm_ServiceDatesD.Text = "Sevice Dates"
        Me.Clm_ServiceDatesD.Width = 100
        '
        'Clm_ReportsD
        '
        Me.Clm_ReportsD.Text = "Reports"
        '
        'Clm_ServiceDatesC
        '
        Me.Clm_ServiceDatesC.Text = "Sevice Dates"
        Me.Clm_ServiceDatesC.Width = 100
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tb_VenueA)
        Me.TabControl1.Controls.Add(Me.Tb_VenueB)
        Me.TabControl1.Controls.Add(Me.Tb_VenueC)
        Me.TabControl1.Controls.Add(Me.Tb_VenueD)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 341)
        Me.TabControl1.TabIndex = 8
        '
        'Tb_VenueA
        '
        Me.Tb_VenueA.Controls.Add(Me.Lst_VenueA)
        Me.Tb_VenueA.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueA.Name = "Tb_VenueA"
        Me.Tb_VenueA.Padding = New System.Windows.Forms.Padding(3)
        Me.Tb_VenueA.Size = New System.Drawing.Size(851, 315)
        Me.Tb_VenueA.TabIndex = 0
        Me.Tb_VenueA.Text = "Venue A"
        Me.Tb_VenueA.UseVisualStyleBackColor = True
        '
        'Lst_VenueA
        '
        Me.Lst_VenueA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductA, Me.Clm_ProductIDA, Me.Clm_BarcodeA, Me.Clm_StockA, Me.Clm_Use, Me.Clm_Maintenance, Me.Clm_Notes})
        Me.Lst_VenueA.GridLines = True
        Me.Lst_VenueA.Location = New System.Drawing.Point(3, 3)
        Me.Lst_VenueA.Name = "Lst_VenueA"
        Me.Lst_VenueA.Size = New System.Drawing.Size(844, 264)
        Me.Lst_VenueA.TabIndex = 2
        Me.Lst_VenueA.UseCompatibleStateImageBehavior = False
        Me.Lst_VenueA.View = System.Windows.Forms.View.Details
        '
        'Clm_ProductA
        '
        Me.Clm_ProductA.Text = "Product"
        Me.Clm_ProductA.Width = 100
        '
        'Clm_ProductIDA
        '
        Me.Clm_ProductIDA.Text = "ID"
        Me.Clm_ProductIDA.Width = 100
        '
        'Clm_BarcodeA
        '
        Me.Clm_BarcodeA.Text = "Item Barcode"
        Me.Clm_BarcodeA.Width = 100
        '
        'Clm_StockA
        '
        Me.Clm_StockA.Text = "Total Stock"
        Me.Clm_StockA.Width = 100
        '
        'Clm_Use
        '
        Me.Clm_Use.Text = "In Use"
        Me.Clm_Use.Width = 100
        '
        'Clm_Maintenance
        '
        Me.Clm_Maintenance.Text = "In Maintenance"
        Me.Clm_Maintenance.Width = 100
        '
        'Clm_Notes
        '
        Me.Clm_Notes.Text = "Notes"
        Me.Clm_Notes.Width = 200
        '
        'Tb_VenueB
        '
        Me.Tb_VenueB.Controls.Add(Me.Lst_VenueB)
        Me.Tb_VenueB.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueB.Name = "Tb_VenueB"
        Me.Tb_VenueB.Padding = New System.Windows.Forms.Padding(3)
        Me.Tb_VenueB.Size = New System.Drawing.Size(851, 315)
        Me.Tb_VenueB.TabIndex = 1
        Me.Tb_VenueB.Text = "Venue B"
        Me.Tb_VenueB.UseVisualStyleBackColor = True
        '
        'Lst_VenueB
        '
        Me.Lst_VenueB.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductB, Me.Clm_IDB, Me.Clm_CatagoryB, Me.Clm_ServiceDatesB, Me.Clm_ReportsB})
        Me.Lst_VenueB.GridLines = True
        Me.Lst_VenueB.Location = New System.Drawing.Point(6, 6)
        Me.Lst_VenueB.Name = "Lst_VenueB"
        Me.Lst_VenueB.Size = New System.Drawing.Size(384, 264)
        Me.Lst_VenueB.TabIndex = 3
        Me.Lst_VenueB.UseCompatibleStateImageBehavior = False
        Me.Lst_VenueB.View = System.Windows.Forms.View.Details
        '
        'Clm_ProductB
        '
        Me.Clm_ProductB.Text = "Product"
        Me.Clm_ProductB.Width = 100
        '
        'Clm_IDB
        '
        Me.Clm_IDB.Text = "ID"
        '
        'Clm_CatagoryB
        '
        Me.Clm_CatagoryB.Text = "Catagory"
        '
        'Clm_ServiceDatesB
        '
        Me.Clm_ServiceDatesB.Text = "Sevice Dates"
        Me.Clm_ServiceDatesB.Width = 100
        '
        'Clm_ReportsB
        '
        Me.Clm_ReportsB.Text = "Reports"
        '
        'Tb_VenueC
        '
        Me.Tb_VenueC.Controls.Add(Me.Lst_VenueC)
        Me.Tb_VenueC.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueC.Name = "Tb_VenueC"
        Me.Tb_VenueC.Size = New System.Drawing.Size(851, 315)
        Me.Tb_VenueC.TabIndex = 2
        Me.Tb_VenueC.Text = "Venue C"
        Me.Tb_VenueC.UseVisualStyleBackColor = True
        '
        'Lst_VenueC
        '
        Me.Lst_VenueC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductC, Me.Clm_ProductIDC, Me.Clm_CatagoryC, Me.Clm_ServiceDatesC, Me.Clm_ReportsC})
        Me.Lst_VenueC.GridLines = True
        Me.Lst_VenueC.Location = New System.Drawing.Point(6, 6)
        Me.Lst_VenueC.Name = "Lst_VenueC"
        Me.Lst_VenueC.Size = New System.Drawing.Size(384, 264)
        Me.Lst_VenueC.TabIndex = 3
        Me.Lst_VenueC.UseCompatibleStateImageBehavior = False
        Me.Lst_VenueC.View = System.Windows.Forms.View.Details
        '
        'Clm_ProductC
        '
        Me.Clm_ProductC.Text = "Product"
        Me.Clm_ProductC.Width = 100
        '
        'Clm_ProductIDC
        '
        Me.Clm_ProductIDC.Text = "ID"
        '
        'Tb_VenueD
        '
        Me.Tb_VenueD.Controls.Add(Me.Lst_VenueD)
        Me.Tb_VenueD.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueD.Name = "Tb_VenueD"
        Me.Tb_VenueD.Size = New System.Drawing.Size(851, 315)
        Me.Tb_VenueD.TabIndex = 3
        Me.Tb_VenueD.Text = "Venue D"
        Me.Tb_VenueD.UseVisualStyleBackColor = True
        '
        'Btn_Home
        '
        Me.Btn_Home.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Home.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Home.Location = New System.Drawing.Point(368, 13)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Size = New System.Drawing.Size(65, 58)
        Me.Btn_Home.TabIndex = 5
        Me.Btn_Home.Text = "Home"
        Me.Btn_Home.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(297, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 58)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Btn_Supplier
        '
        Me.Btn_Supplier.Location = New System.Drawing.Point(226, 13)
        Me.Btn_Supplier.Name = "Btn_Supplier"
        Me.Btn_Supplier.Size = New System.Drawing.Size(65, 58)
        Me.Btn_Supplier.TabIndex = 3
        Me.Btn_Supplier.Text = "Supplier"
        Me.Btn_Supplier.UseVisualStyleBackColor = True
        '
        'Btn_Customer
        '
        Me.Btn_Customer.Location = New System.Drawing.Point(155, 13)
        Me.Btn_Customer.Name = "Btn_Customer"
        Me.Btn_Customer.Size = New System.Drawing.Size(65, 58)
        Me.Btn_Customer.TabIndex = 2
        Me.Btn_Customer.Text = "Customer"
        Me.Btn_Customer.UseVisualStyleBackColor = True
        '
        'Btn_LookUp
        '
        Me.Btn_LookUp.Location = New System.Drawing.Point(84, 13)
        Me.Btn_LookUp.Name = "Btn_LookUp"
        Me.Btn_LookUp.Size = New System.Drawing.Size(65, 58)
        Me.Btn_LookUp.TabIndex = 1
        Me.Btn_LookUp.Text = "Look Up"
        Me.Btn_LookUp.UseVisualStyleBackColor = True
        '
        'Grp_Menu
        '
        Me.Grp_Menu.Controls.Add(Me.Btn_AddNew)
        Me.Grp_Menu.Controls.Add(Me.Btn_Home)
        Me.Grp_Menu.Controls.Add(Me.Button5)
        Me.Grp_Menu.Controls.Add(Me.Btn_Supplier)
        Me.Grp_Menu.Controls.Add(Me.Btn_Customer)
        Me.Grp_Menu.Controls.Add(Me.Btn_LookUp)
        Me.Grp_Menu.Controls.Add(Me.Btn_FullStock)
        Me.Grp_Menu.Location = New System.Drawing.Point(1, 6)
        Me.Grp_Menu.Name = "Grp_Menu"
        Me.Grp_Menu.Size = New System.Drawing.Size(883, 77)
        Me.Grp_Menu.TabIndex = 7
        Me.Grp_Menu.TabStop = False
        Me.Grp_Menu.Text = "Menu"
        '
        'Btn_AddNew
        '
        Me.Btn_AddNew.Location = New System.Drawing.Point(802, 48)
        Me.Btn_AddNew.Name = "Btn_AddNew"
        Me.Btn_AddNew.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AddNew.TabIndex = 8
        Me.Btn_AddNew.Text = "Add New"
        Me.Btn_AddNew.UseVisualStyleBackColor = True
        '
        'Btn_FullStock
        '
        Me.Btn_FullStock.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_FullStock.Location = New System.Drawing.Point(13, 13)
        Me.Btn_FullStock.Name = "Btn_FullStock"
        Me.Btn_FullStock.Size = New System.Drawing.Size(65, 58)
        Me.Btn_FullStock.TabIndex = 0
        Me.Btn_FullStock.Text = "Full Stock"
        Me.Btn_FullStock.UseVisualStyleBackColor = False
        '
        'Grb_ViewTable
        '
        Me.Grb_ViewTable.Controls.Add(Me.TabControl1)
        Me.Grb_ViewTable.Location = New System.Drawing.Point(12, 89)
        Me.Grb_ViewTable.Name = "Grb_ViewTable"
        Me.Grb_ViewTable.Size = New System.Drawing.Size(871, 366)
        Me.Grb_ViewTable.TabIndex = 6
        Me.Grb_ViewTable.TabStop = False
        Me.Grb_ViewTable.Text = "Table"
        '
        'Grb_AddNew
        '
        Me.Grb_AddNew.Controls.Add(Me.Btn_SavetoDB)
        Me.Grb_AddNew.Controls.Add(Me.Label8)
        Me.Grb_AddNew.Controls.Add(Me.Cb_Status)
        Me.Grb_AddNew.Controls.Add(Me.Label7)
        Me.Grb_AddNew.Controls.Add(Me.Cb_Cat)
        Me.Grb_AddNew.Controls.Add(Me.Cb_Customer)
        Me.Grb_AddNew.Controls.Add(Me.Tbx_Name)
        Me.Grb_AddNew.Controls.Add(Me.Txb_ProductID)
        Me.Grb_AddNew.Controls.Add(Me.Txb_Notes)
        Me.Grb_AddNew.Controls.Add(Me.Label6)
        Me.Grb_AddNew.Controls.Add(Me.Label5)
        Me.Grb_AddNew.Controls.Add(Me.Label4)
        Me.Grb_AddNew.Controls.Add(Me.Label3)
        Me.Grb_AddNew.Controls.Add(Me.Label2)
        Me.Grb_AddNew.Controls.Add(Me.Label1)
        Me.Grb_AddNew.Controls.Add(Me.MonthCalendar1)
        Me.Grb_AddNew.Enabled = False
        Me.Grb_AddNew.Location = New System.Drawing.Point(12, 89)
        Me.Grb_AddNew.Name = "Grb_AddNew"
        Me.Grb_AddNew.Size = New System.Drawing.Size(871, 382)
        Me.Grb_AddNew.TabIndex = 26
        Me.Grb_AddNew.TabStop = False
        Me.Grb_AddNew.Text = "Add New"
        Me.Grb_AddNew.Visible = False
        '
        'Btn_SavetoDB
        '
        Me.Btn_SavetoDB.Location = New System.Drawing.Point(743, 353)
        Me.Btn_SavetoDB.Name = "Btn_SavetoDB"
        Me.Btn_SavetoDB.Size = New System.Drawing.Size(115, 23)
        Me.Btn_SavetoDB.TabIndex = 24
        Me.Btn_SavetoDB.Text = "Save to SQLDB"
        Me.Btn_SavetoDB.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(333, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Current Plan for form when inputting new products into the database. "
        '
        'Cb_Status
        '
        Me.Cb_Status.FormattingEnabled = True
        Me.Cb_Status.Items.AddRange(New Object() {"Functional", "Damaged but Functional (See Notes)", "Quarentiened for Repairs"})
        Me.Cb_Status.Location = New System.Drawing.Point(232, 78)
        Me.Cb_Status.Name = "Cb_Status"
        Me.Cb_Status.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Status.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Current Status"
        '
        'Cb_Cat
        '
        Me.Cb_Cat.FormattingEnabled = True
        Me.Cb_Cat.Location = New System.Drawing.Point(16, 76)
        Me.Cb_Cat.Name = "Cb_Cat"
        Me.Cb_Cat.Size = New System.Drawing.Size(100, 21)
        Me.Cb_Cat.TabIndex = 20
        '
        'Cb_Customer
        '
        Me.Cb_Customer.FormattingEnabled = True
        Me.Cb_Customer.Items.AddRange(New Object() {"Venue A", "Venue B ", "Venue C", "OOH"})
        Me.Cb_Customer.Location = New System.Drawing.Point(234, 38)
        Me.Cb_Customer.Name = "Cb_Customer"
        Me.Cb_Customer.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Customer.TabIndex = 19
        '
        'Tbx_Name
        '
        Me.Tbx_Name.Location = New System.Drawing.Point(16, 116)
        Me.Tbx_Name.Name = "Tbx_Name"
        Me.Tbx_Name.Size = New System.Drawing.Size(100, 20)
        Me.Tbx_Name.TabIndex = 16
        '
        'Txb_ProductID
        '
        Me.Txb_ProductID.Location = New System.Drawing.Point(16, 38)
        Me.Txb_ProductID.Name = "Txb_ProductID"
        Me.Txb_ProductID.Size = New System.Drawing.Size(100, 20)
        Me.Txb_ProductID.TabIndex = 15
        '
        'Txb_Notes
        '
        Me.Txb_Notes.Location = New System.Drawing.Point(524, 38)
        Me.Txb_Notes.Multiline = True
        Me.Txb_Notes.Name = "Txb_Notes"
        Me.Txb_Notes.Size = New System.Drawing.Size(200, 200)
        Me.Txb_Notes.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Catagory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Service Dates"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Notes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product ID"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(16, 161)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 18
        '
        'Frm_NonAdminCustomerFullStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 553)
        Me.Controls.Add(Me.Grb_AddNew)
        Me.Controls.Add(Me.Grp_Menu)
        Me.Controls.Add(Me.Grb_ViewTable)
        Me.Name = "Frm_NonAdminCustomerFullStock"
        Me.Text = "Frm_NonAdminCustomerFullStock"
        Me.TabControl1.ResumeLayout(False)
        Me.Tb_VenueA.ResumeLayout(False)
        Me.Tb_VenueB.ResumeLayout(False)
        Me.Tb_VenueC.ResumeLayout(False)
        Me.Tb_VenueD.ResumeLayout(False)
        Me.Grp_Menu.ResumeLayout(False)
        Me.Grb_ViewTable.ResumeLayout(False)
        Me.Grb_AddNew.ResumeLayout(False)
        Me.Grb_AddNew.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clm_CatagoryC As ColumnHeader
    Friend WithEvents Clm_ReportsC As ColumnHeader
    Friend WithEvents Lst_VenueD As ListView
    Friend WithEvents Clm_ProductsD As ColumnHeader
    Friend WithEvents Clm_ProductsIDD As ColumnHeader
    Friend WithEvents Clm_CatagoryD As ColumnHeader
    Friend WithEvents Clm_ServiceDatesD As ColumnHeader
    Friend WithEvents Clm_ReportsD As ColumnHeader
    Friend WithEvents Clm_ServiceDatesC As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tb_VenueA As TabPage
    Friend WithEvents Lst_VenueA As ListView
    Friend WithEvents Clm_ProductA As ColumnHeader
    Friend WithEvents Clm_ProductIDA As ColumnHeader
    Friend WithEvents Tb_VenueB As TabPage
    Friend WithEvents Lst_VenueB As ListView
    Friend WithEvents Clm_ProductB As ColumnHeader
    Friend WithEvents Clm_IDB As ColumnHeader
    Friend WithEvents Clm_CatagoryB As ColumnHeader
    Friend WithEvents Clm_ServiceDatesB As ColumnHeader
    Friend WithEvents Clm_ReportsB As ColumnHeader
    Friend WithEvents Tb_VenueC As TabPage
    Friend WithEvents Lst_VenueC As ListView
    Friend WithEvents Clm_ProductC As ColumnHeader
    Friend WithEvents Clm_ProductIDC As ColumnHeader
    Friend WithEvents Tb_VenueD As TabPage
    Friend WithEvents Btn_Home As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Btn_Supplier As Button
    Friend WithEvents Btn_Customer As Button
    Friend WithEvents Btn_LookUp As Button
    Friend WithEvents Grp_Menu As GroupBox
    Friend WithEvents Btn_FullStock As Button
    Friend WithEvents Clm_BarcodeA As ColumnHeader
    Friend WithEvents Clm_StockA As ColumnHeader
    Friend WithEvents Clm_Use As ColumnHeader
    Friend WithEvents Clm_Maintenance As ColumnHeader
    Friend WithEvents Clm_Notes As ColumnHeader
    Friend WithEvents Btn_AddNew As Button
    Friend WithEvents Grb_ViewTable As GroupBox
    Friend WithEvents Grb_AddNew As GroupBox
    Friend WithEvents Btn_SavetoDB As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_Status As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cb_Cat As ComboBox
    Friend WithEvents Cb_Customer As ComboBox
    Friend WithEvents Tbx_Name As TextBox
    Friend WithEvents Txb_ProductID As TextBox
    Friend WithEvents Txb_Notes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
