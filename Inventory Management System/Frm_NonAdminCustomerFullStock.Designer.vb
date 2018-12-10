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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txb_Notes = New System.Windows.Forms.TextBox()
        Me.Txb_ProductID = New System.Windows.Forms.TextBox()
        Me.Tbx_Name = New System.Windows.Forms.TextBox()
        Me.Cb_Customer = New System.Windows.Forms.ComboBox()
        Me.Cb_Cat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cb_Status = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_SavetoDB = New System.Windows.Forms.Button()
        Me.Grb_AddNew = New System.Windows.Forms.GroupBox()
        Me.txt_Barcode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Lst_VenueD.Location = New System.Drawing.Point(14, 13)
        Me.Lst_VenueD.Margin = New System.Windows.Forms.Padding(7)
        Me.Lst_VenueD.Name = "Lst_VenueD"
        Me.Lst_VenueD.Size = New System.Drawing.Size(893, 584)
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
        Me.TabControl1.Location = New System.Drawing.Point(14, 42)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2004, 761)
        Me.TabControl1.TabIndex = 8
        '
        'Tb_VenueA
        '
        Me.Tb_VenueA.Controls.Add(Me.Lst_VenueA)
        Me.Tb_VenueA.Location = New System.Drawing.Point(10, 47)
        Me.Tb_VenueA.Margin = New System.Windows.Forms.Padding(7)
        Me.Tb_VenueA.Name = "Tb_VenueA"
        Me.Tb_VenueA.Padding = New System.Windows.Forms.Padding(7)
        Me.Tb_VenueA.Size = New System.Drawing.Size(1984, 704)
        Me.Tb_VenueA.TabIndex = 0
        Me.Tb_VenueA.Text = "Venue A"
        Me.Tb_VenueA.UseVisualStyleBackColor = True
        '
        'Lst_VenueA
        '
        Me.Lst_VenueA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductA, Me.Clm_ProductIDA, Me.Clm_BarcodeA, Me.Clm_StockA, Me.Clm_Use, Me.Clm_Maintenance, Me.Clm_Notes})
        Me.Lst_VenueA.GridLines = True
        Me.Lst_VenueA.Location = New System.Drawing.Point(7, 7)
        Me.Lst_VenueA.Margin = New System.Windows.Forms.Padding(7)
        Me.Lst_VenueA.Name = "Lst_VenueA"
        Me.Lst_VenueA.Size = New System.Drawing.Size(1964, 584)
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
        Me.Tb_VenueB.Location = New System.Drawing.Point(10, 47)
        Me.Tb_VenueB.Margin = New System.Windows.Forms.Padding(7)
        Me.Tb_VenueB.Name = "Tb_VenueB"
        Me.Tb_VenueB.Padding = New System.Windows.Forms.Padding(7)
        Me.Tb_VenueB.Size = New System.Drawing.Size(1984, 704)
        Me.Tb_VenueB.TabIndex = 1
        Me.Tb_VenueB.Text = "Venue B"
        Me.Tb_VenueB.UseVisualStyleBackColor = True
        '
        'Lst_VenueB
        '
        Me.Lst_VenueB.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductB, Me.Clm_IDB, Me.Clm_CatagoryB, Me.Clm_ServiceDatesB, Me.Clm_ReportsB})
        Me.Lst_VenueB.GridLines = True
        Me.Lst_VenueB.Location = New System.Drawing.Point(14, 13)
        Me.Lst_VenueB.Margin = New System.Windows.Forms.Padding(7)
        Me.Lst_VenueB.Name = "Lst_VenueB"
        Me.Lst_VenueB.Size = New System.Drawing.Size(891, 584)
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
        Me.Tb_VenueC.Location = New System.Drawing.Point(10, 47)
        Me.Tb_VenueC.Margin = New System.Windows.Forms.Padding(7)
        Me.Tb_VenueC.Name = "Tb_VenueC"
        Me.Tb_VenueC.Size = New System.Drawing.Size(1984, 704)
        Me.Tb_VenueC.TabIndex = 2
        Me.Tb_VenueC.Text = "Venue C"
        Me.Tb_VenueC.UseVisualStyleBackColor = True
        '
        'Lst_VenueC
        '
        Me.Lst_VenueC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductC, Me.Clm_ProductIDC, Me.Clm_CatagoryC, Me.Clm_ServiceDatesC, Me.Clm_ReportsC})
        Me.Lst_VenueC.GridLines = True
        Me.Lst_VenueC.Location = New System.Drawing.Point(14, 13)
        Me.Lst_VenueC.Margin = New System.Windows.Forms.Padding(7)
        Me.Lst_VenueC.Name = "Lst_VenueC"
        Me.Lst_VenueC.Size = New System.Drawing.Size(891, 584)
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
        Me.Tb_VenueD.Location = New System.Drawing.Point(10, 47)
        Me.Tb_VenueD.Margin = New System.Windows.Forms.Padding(7)
        Me.Tb_VenueD.Name = "Tb_VenueD"
        Me.Tb_VenueD.Size = New System.Drawing.Size(1984, 704)
        Me.Tb_VenueD.TabIndex = 3
        Me.Tb_VenueD.Text = "Venue D"
        Me.Tb_VenueD.UseVisualStyleBackColor = True
        '
        'Btn_Home
        '
        Me.Btn_Home.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Home.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Home.Location = New System.Drawing.Point(859, 29)
        Me.Btn_Home.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Size = New System.Drawing.Size(152, 129)
        Me.Btn_Home.TabIndex = 5
        Me.Btn_Home.Text = "Home"
        Me.Btn_Home.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(693, 29)
        Me.Button5.Margin = New System.Windows.Forms.Padding(7)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(152, 129)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Btn_Supplier
        '
        Me.Btn_Supplier.Location = New System.Drawing.Point(527, 29)
        Me.Btn_Supplier.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_Supplier.Name = "Btn_Supplier"
        Me.Btn_Supplier.Size = New System.Drawing.Size(152, 129)
        Me.Btn_Supplier.TabIndex = 3
        Me.Btn_Supplier.Text = "Supplier"
        Me.Btn_Supplier.UseVisualStyleBackColor = True
        '
        'Btn_Customer
        '
        Me.Btn_Customer.Location = New System.Drawing.Point(362, 29)
        Me.Btn_Customer.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_Customer.Name = "Btn_Customer"
        Me.Btn_Customer.Size = New System.Drawing.Size(152, 129)
        Me.Btn_Customer.TabIndex = 2
        Me.Btn_Customer.Text = "Customer"
        Me.Btn_Customer.UseVisualStyleBackColor = True
        '
        'Btn_LookUp
        '
        Me.Btn_LookUp.Location = New System.Drawing.Point(196, 29)
        Me.Btn_LookUp.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_LookUp.Name = "Btn_LookUp"
        Me.Btn_LookUp.Size = New System.Drawing.Size(152, 129)
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
        Me.Grp_Menu.Location = New System.Drawing.Point(2, 13)
        Me.Grp_Menu.Margin = New System.Windows.Forms.Padding(7)
        Me.Grp_Menu.Name = "Grp_Menu"
        Me.Grp_Menu.Padding = New System.Windows.Forms.Padding(7)
        Me.Grp_Menu.Size = New System.Drawing.Size(2060, 172)
        Me.Grp_Menu.TabIndex = 7
        Me.Grp_Menu.TabStop = False
        Me.Grp_Menu.Text = "Menu"
        '
        'Btn_AddNew
        '
        Me.Btn_AddNew.Location = New System.Drawing.Point(1871, 107)
        Me.Btn_AddNew.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_AddNew.Name = "Btn_AddNew"
        Me.Btn_AddNew.Size = New System.Drawing.Size(175, 51)
        Me.Btn_AddNew.TabIndex = 8
        Me.Btn_AddNew.Text = "Add New"
        Me.Btn_AddNew.UseVisualStyleBackColor = True
        '
        'Btn_FullStock
        '
        Me.Btn_FullStock.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_FullStock.Location = New System.Drawing.Point(30, 29)
        Me.Btn_FullStock.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_FullStock.Name = "Btn_FullStock"
        Me.Btn_FullStock.Size = New System.Drawing.Size(152, 129)
        Me.Btn_FullStock.TabIndex = 0
        Me.Btn_FullStock.Text = "Full Stock"
        Me.Btn_FullStock.UseVisualStyleBackColor = False
        '
        'Grb_ViewTable
        '
        Me.Grb_ViewTable.Controls.Add(Me.TabControl1)
        Me.Grb_ViewTable.Location = New System.Drawing.Point(28, 199)
        Me.Grb_ViewTable.Margin = New System.Windows.Forms.Padding(7)
        Me.Grb_ViewTable.Name = "Grb_ViewTable"
        Me.Grb_ViewTable.Padding = New System.Windows.Forms.Padding(7)
        Me.Grb_ViewTable.Size = New System.Drawing.Size(2032, 816)
        Me.Grb_ViewTable.TabIndex = 6
        Me.Grb_ViewTable.TabStop = False
        Me.Grb_ViewTable.Text = "Table"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(37, 359)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(21, 20, 21, 20)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1216, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Notes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(544, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 310)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Service Dates"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(544, 243)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Catagory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 29)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Name"
        '
        'Txb_Notes
        '
        Me.Txb_Notes.Location = New System.Drawing.Point(1223, 85)
        Me.Txb_Notes.Margin = New System.Windows.Forms.Padding(7)
        Me.Txb_Notes.Multiline = True
        Me.Txb_Notes.Name = "Txb_Notes"
        Me.Txb_Notes.Size = New System.Drawing.Size(461, 441)
        Me.Txb_Notes.TabIndex = 14
        '
        'Txb_ProductID
        '
        Me.Txb_ProductID.Location = New System.Drawing.Point(37, 85)
        Me.Txb_ProductID.Margin = New System.Windows.Forms.Padding(7)
        Me.Txb_ProductID.Name = "Txb_ProductID"
        Me.Txb_ProductID.Size = New System.Drawing.Size(228, 35)
        Me.Txb_ProductID.TabIndex = 15
        '
        'Tbx_Name
        '
        Me.Tbx_Name.Location = New System.Drawing.Point(37, 259)
        Me.Tbx_Name.Margin = New System.Windows.Forms.Padding(7)
        Me.Tbx_Name.Name = "Tbx_Name"
        Me.Tbx_Name.Size = New System.Drawing.Size(228, 35)
        Me.Tbx_Name.TabIndex = 16
        '
        'Cb_Customer
        '
        Me.Cb_Customer.FormattingEnabled = True
        Me.Cb_Customer.Items.AddRange(New Object() {"Venue A", "Venue B ", "Venue C", "OOH"})
        Me.Cb_Customer.Location = New System.Drawing.Point(546, 85)
        Me.Cb_Customer.Margin = New System.Windows.Forms.Padding(7)
        Me.Cb_Customer.Name = "Cb_Customer"
        Me.Cb_Customer.Size = New System.Drawing.Size(277, 37)
        Me.Cb_Customer.TabIndex = 19
        '
        'Cb_Cat
        '
        Me.Cb_Cat.FormattingEnabled = True
        Me.Cb_Cat.Location = New System.Drawing.Point(545, 277)
        Me.Cb_Cat.Margin = New System.Windows.Forms.Padding(7)
        Me.Cb_Cat.Name = "Cb_Cat"
        Me.Cb_Cat.Size = New System.Drawing.Size(278, 37)
        Me.Cb_Cat.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 138)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 29)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Current Status"
        '
        'Cb_Status
        '
        Me.Cb_Status.FormattingEnabled = True
        Me.Cb_Status.Items.AddRange(New Object() {"Functional", "Damaged but Functional (See Notes)", "Quarentiened for Repairs"})
        Me.Cb_Status.Location = New System.Drawing.Point(541, 174)
        Me.Cb_Status.Margin = New System.Windows.Forms.Padding(7)
        Me.Cb_Status.Name = "Cb_Status"
        Me.Cb_Status.Size = New System.Drawing.Size(277, 37)
        Me.Cb_Status.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(962, 687)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(746, 29)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Current Plan for form when inputting new products into the database. "
        '
        'Btn_SavetoDB
        '
        Me.Btn_SavetoDB.Location = New System.Drawing.Point(1734, 787)
        Me.Btn_SavetoDB.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_SavetoDB.Name = "Btn_SavetoDB"
        Me.Btn_SavetoDB.Size = New System.Drawing.Size(268, 51)
        Me.Btn_SavetoDB.TabIndex = 24
        Me.Btn_SavetoDB.Text = "Save"
        Me.Btn_SavetoDB.UseVisualStyleBackColor = True
        '
        'Grb_AddNew
        '
        Me.Grb_AddNew.Controls.Add(Me.txt_Barcode)
        Me.Grb_AddNew.Controls.Add(Me.Label9)
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
        Me.Grb_AddNew.Location = New System.Drawing.Point(28, 199)
        Me.Grb_AddNew.Margin = New System.Windows.Forms.Padding(7)
        Me.Grb_AddNew.Name = "Grb_AddNew"
        Me.Grb_AddNew.Padding = New System.Windows.Forms.Padding(7)
        Me.Grb_AddNew.Size = New System.Drawing.Size(2032, 852)
        Me.Grb_AddNew.TabIndex = 26
        Me.Grb_AddNew.TabStop = False
        Me.Grb_AddNew.Text = "Add New"
        Me.Grb_AddNew.Visible = False
        '
        'txt_Barcode
        '
        Me.txt_Barcode.Location = New System.Drawing.Point(37, 174)
        Me.txt_Barcode.Margin = New System.Windows.Forms.Padding(7)
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.Size = New System.Drawing.Size(228, 35)
        Me.txt_Barcode.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 138)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 29)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Product Barcode"
        '
        'Frm_NonAdminCustomerFullStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2464, 1234)
        Me.Controls.Add(Me.Grb_AddNew)
        Me.Controls.Add(Me.Grp_Menu)
        Me.Controls.Add(Me.Grb_ViewTable)
        Me.Margin = New System.Windows.Forms.Padding(7)
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
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txb_Notes As TextBox
    Friend WithEvents Txb_ProductID As TextBox
    Friend WithEvents Tbx_Name As TextBox
    Friend WithEvents Cb_Customer As ComboBox
    Friend WithEvents Cb_Cat As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cb_Status As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_SavetoDB As Button
    Friend WithEvents Grb_AddNew As GroupBox
    Friend WithEvents txt_Barcode As TextBox
    Friend WithEvents Label9 As Label
End Class
