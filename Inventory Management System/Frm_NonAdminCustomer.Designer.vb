<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NonAdminCustomer
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
        Me.Clm_ProductB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueA = New System.Windows.Forms.TabPage()
        Me.Lst_VenueA = New System.Windows.Forms.ListView()
        Me.Clm_ProductA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductIDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueB = New System.Windows.Forms.TabPage()
        Me.Lst_VenueB = New System.Windows.Forms.ListView()
        Me.Clm_IDB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueC = New System.Windows.Forms.TabPage()
        Me.Lst_VenueC = New System.Windows.Forms.ListView()
        Me.Clm_ProductC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductIDC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lst_VenueD = New System.Windows.Forms.ListView()
        Me.Clm_ProductsD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductsIDD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tb_VenueD = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Btn_Home = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Supplier = New System.Windows.Forms.Button()
        Me.Btn_Customer = New System.Windows.Forms.Button()
        Me.Btn_LookUp = New System.Windows.Forms.Button()
        Me.Btn_FullStock = New System.Windows.Forms.Button()
        Me.Grp_Menu = New System.Windows.Forms.GroupBox()
        Me.Tbx_EnterName = New System.Windows.Forms.TextBox()
        Me.Lbl_EnterName = New System.Windows.Forms.Label()
        Me.Txb_CustomerNo = New System.Windows.Forms.TextBox()
        Me.Lbl_CustomerNo = New System.Windows.Forms.Label()
        Me.Txb_CustomerEmail = New System.Windows.Forms.TextBox()
        Me.Lbl_CustomerEmail = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rbt_InHouse = New System.Windows.Forms.RadioButton()
        Me.Rbt_OutOfHouse = New System.Windows.Forms.RadioButton()
        Me.Tb_NewCustomer = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_VenueA.SuspendLayout()
        Me.Tb_VenueB.SuspendLayout()
        Me.Tb_VenueC.SuspendLayout()
        Me.Tb_VenueD.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Grp_Menu.SuspendLayout()
        Me.Tb_NewCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Clm_ProductB
        '
        Me.Clm_ProductB.Text = "Product"
        Me.Clm_ProductB.Width = 100
        '
        'Tb_VenueA
        '
        Me.Tb_VenueA.Controls.Add(Me.Lst_VenueA)
        Me.Tb_VenueA.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueA.Name = "Tb_VenueA"
        Me.Tb_VenueA.Padding = New System.Windows.Forms.Padding(3)
        Me.Tb_VenueA.Size = New System.Drawing.Size(851, 340)
        Me.Tb_VenueA.TabIndex = 0
        Me.Tb_VenueA.Text = "Venue A"
        Me.Tb_VenueA.UseVisualStyleBackColor = True
        '
        'Lst_VenueA
        '
        Me.Lst_VenueA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductA, Me.Clm_ProductIDA, Me.Clm_CatagoryA, Me.Clm_ServiceDatesA, Me.Clm_ReportsA})
        Me.Lst_VenueA.GridLines = True
        Me.Lst_VenueA.Location = New System.Drawing.Point(6, 6)
        Me.Lst_VenueA.Name = "Lst_VenueA"
        Me.Lst_VenueA.Size = New System.Drawing.Size(385, 264)
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
        '
        'Clm_CatagoryA
        '
        Me.Clm_CatagoryA.Text = "Catagory"
        '
        'Clm_ServiceDatesA
        '
        Me.Clm_ServiceDatesA.Text = "Sevice Dates"
        Me.Clm_ServiceDatesA.Width = 100
        '
        'Clm_ReportsA
        '
        Me.Clm_ReportsA.Text = "Reports"
        '
        'Tb_VenueB
        '
        Me.Tb_VenueB.Controls.Add(Me.Lst_VenueB)
        Me.Tb_VenueB.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueB.Name = "Tb_VenueB"
        Me.Tb_VenueB.Padding = New System.Windows.Forms.Padding(3)
        Me.Tb_VenueB.Size = New System.Drawing.Size(851, 340)
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
        Me.Tb_VenueC.Size = New System.Drawing.Size(851, 340)
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
        'Clm_CatagoryC
        '
        Me.Clm_CatagoryC.Text = "Catagory"
        '
        'Clm_ServiceDatesC
        '
        Me.Clm_ServiceDatesC.Text = "Sevice Dates"
        Me.Clm_ServiceDatesC.Width = 100
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
        'Tb_VenueD
        '
        Me.Tb_VenueD.Controls.Add(Me.Lst_VenueD)
        Me.Tb_VenueD.Location = New System.Drawing.Point(4, 22)
        Me.Tb_VenueD.Name = "Tb_VenueD"
        Me.Tb_VenueD.Size = New System.Drawing.Size(851, 340)
        Me.Tb_VenueD.TabIndex = 3
        Me.Tb_VenueD.Text = "Venue D"
        Me.Tb_VenueD.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tb_NewCustomer)
        Me.TabControl1.Controls.Add(Me.Tb_VenueA)
        Me.TabControl1.Controls.Add(Me.Tb_VenueB)
        Me.TabControl1.Controls.Add(Me.Tb_VenueC)
        Me.TabControl1.Controls.Add(Me.Tb_VenueD)
        Me.TabControl1.Location = New System.Drawing.Point(14, 89)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 366)
        Me.TabControl1.TabIndex = 6
        '
        'Btn_Home
        '
        Me.Btn_Home.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Home.Location = New System.Drawing.Point(368, 13)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Size = New System.Drawing.Size(65, 58)
        Me.Btn_Home.TabIndex = 5
        Me.Btn_Home.Text = "Home"
        Me.Btn_Home.UseVisualStyleBackColor = True
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
        'Btn_FullStock
        '
        Me.Btn_FullStock.Location = New System.Drawing.Point(13, 13)
        Me.Btn_FullStock.Name = "Btn_FullStock"
        Me.Btn_FullStock.Size = New System.Drawing.Size(65, 58)
        Me.Btn_FullStock.TabIndex = 0
        Me.Btn_FullStock.Text = "Full Stock"
        Me.Btn_FullStock.UseVisualStyleBackColor = True
        '
        'Grp_Menu
        '
        Me.Grp_Menu.Controls.Add(Me.Btn_Home)
        Me.Grp_Menu.Controls.Add(Me.Button5)
        Me.Grp_Menu.Controls.Add(Me.Btn_Supplier)
        Me.Grp_Menu.Controls.Add(Me.Btn_Customer)
        Me.Grp_Menu.Controls.Add(Me.Btn_LookUp)
        Me.Grp_Menu.Controls.Add(Me.Btn_FullStock)
        Me.Grp_Menu.Location = New System.Drawing.Point(1, 6)
        Me.Grp_Menu.Name = "Grp_Menu"
        Me.Grp_Menu.Size = New System.Drawing.Size(883, 77)
        Me.Grp_Menu.TabIndex = 5
        Me.Grp_Menu.TabStop = False
        Me.Grp_Menu.Text = "Menu"
        '
        'Tbx_EnterName
        '
        Me.Tbx_EnterName.Location = New System.Drawing.Point(156, 24)
        Me.Tbx_EnterName.Name = "Tbx_EnterName"
        Me.Tbx_EnterName.Size = New System.Drawing.Size(189, 20)
        Me.Tbx_EnterName.TabIndex = 0
        '
        'Lbl_EnterName
        '
        Me.Lbl_EnterName.AutoSize = True
        Me.Lbl_EnterName.Location = New System.Drawing.Point(22, 26)
        Me.Lbl_EnterName.Name = "Lbl_EnterName"
        Me.Lbl_EnterName.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_EnterName.TabIndex = 1
        '
        'Txb_CustomerNo
        '
        Me.Txb_CustomerNo.Location = New System.Drawing.Point(156, 49)
        Me.Txb_CustomerNo.Name = "Txb_CustomerNo"
        Me.Txb_CustomerNo.Size = New System.Drawing.Size(189, 20)
        Me.Txb_CustomerNo.TabIndex = 2
        '
        'Lbl_CustomerNo
        '
        Me.Lbl_CustomerNo.AutoSize = True
        Me.Lbl_CustomerNo.Location = New System.Drawing.Point(22, 51)
        Me.Lbl_CustomerNo.Name = "Lbl_CustomerNo"
        Me.Lbl_CustomerNo.Size = New System.Drawing.Size(131, 13)
        Me.Lbl_CustomerNo.TabIndex = 3
        Me.Lbl_CustomerNo.Text = "Customer Contact Number"
        '
        'Txb_CustomerEmail
        '
        Me.Txb_CustomerEmail.Location = New System.Drawing.Point(156, 75)
        Me.Txb_CustomerEmail.Name = "Txb_CustomerEmail"
        Me.Txb_CustomerEmail.Size = New System.Drawing.Size(189, 20)
        Me.Txb_CustomerEmail.TabIndex = 4
        '
        'Lbl_CustomerEmail
        '
        Me.Lbl_CustomerEmail.AutoSize = True
        Me.Lbl_CustomerEmail.Location = New System.Drawing.Point(22, 77)
        Me.Lbl_CustomerEmail.Name = "Lbl_CustomerEmail"
        Me.Lbl_CustomerEmail.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_CustomerEmail.TabIndex = 5
        Me.Lbl_CustomerEmail.Text = "Enter Customer Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 8
        '
        'Rbt_InHouse
        '
        Me.Rbt_InHouse.AutoSize = True
        Me.Rbt_InHouse.Location = New System.Drawing.Point(421, 27)
        Me.Rbt_InHouse.Name = "Rbt_InHouse"
        Me.Rbt_InHouse.Size = New System.Drawing.Size(68, 17)
        Me.Rbt_InHouse.TabIndex = 9
        Me.Rbt_InHouse.Text = "In House"
        Me.Rbt_InHouse.UseVisualStyleBackColor = True
        '
        'Rbt_OutOfHouse
        '
        Me.Rbt_OutOfHouse.AutoSize = True
        Me.Rbt_OutOfHouse.Checked = True
        Me.Rbt_OutOfHouse.Location = New System.Drawing.Point(421, 50)
        Me.Rbt_OutOfHouse.Name = "Rbt_OutOfHouse"
        Me.Rbt_OutOfHouse.Size = New System.Drawing.Size(90, 17)
        Me.Rbt_OutOfHouse.TabIndex = 10
        Me.Rbt_OutOfHouse.TabStop = True
        Me.Rbt_OutOfHouse.Text = "Out Of House"
        Me.Rbt_OutOfHouse.UseVisualStyleBackColor = True
        '
        'Tb_NewCustomer
        '
        Me.Tb_NewCustomer.Controls.Add(Me.Label1)
        Me.Tb_NewCustomer.Controls.Add(Me.Rbt_OutOfHouse)
        Me.Tb_NewCustomer.Controls.Add(Me.Rbt_InHouse)
        Me.Tb_NewCustomer.Controls.Add(Me.Label4)
        Me.Tb_NewCustomer.Controls.Add(Me.Label3)
        Me.Tb_NewCustomer.Controls.Add(Me.Lbl_CustomerEmail)
        Me.Tb_NewCustomer.Controls.Add(Me.Txb_CustomerEmail)
        Me.Tb_NewCustomer.Controls.Add(Me.Lbl_CustomerNo)
        Me.Tb_NewCustomer.Controls.Add(Me.Txb_CustomerNo)
        Me.Tb_NewCustomer.Controls.Add(Me.Lbl_EnterName)
        Me.Tb_NewCustomer.Controls.Add(Me.Tbx_EnterName)
        Me.Tb_NewCustomer.Location = New System.Drawing.Point(4, 22)
        Me.Tb_NewCustomer.Name = "Tb_NewCustomer"
        Me.Tb_NewCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.Tb_NewCustomer.Size = New System.Drawing.Size(851, 340)
        Me.Tb_NewCustomer.TabIndex = 4
        Me.Tb_NewCustomer.Text = "New Customer"
        Me.Tb_NewCustomer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Customer Name"
        '
        'Frm_NonAdminCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Grp_Menu)
        Me.Name = "Frm_NonAdminCustomer"
        Me.Text = "Frm_NonAdminCustomer"
        Me.Tb_VenueA.ResumeLayout(False)
        Me.Tb_VenueB.ResumeLayout(False)
        Me.Tb_VenueC.ResumeLayout(False)
        Me.Tb_VenueD.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Grp_Menu.ResumeLayout(False)
        Me.Tb_NewCustomer.ResumeLayout(False)
        Me.Tb_NewCustomer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clm_ProductB As ColumnHeader
    Friend WithEvents Tb_VenueA As TabPage
    Friend WithEvents Lst_VenueA As ListView
    Friend WithEvents Clm_ProductA As ColumnHeader
    Friend WithEvents Clm_ProductIDA As ColumnHeader
    Friend WithEvents Clm_CatagoryA As ColumnHeader
    Friend WithEvents Clm_ServiceDatesA As ColumnHeader
    Friend WithEvents Clm_ReportsA As ColumnHeader
    Friend WithEvents Tb_VenueB As TabPage
    Friend WithEvents Lst_VenueB As ListView
    Friend WithEvents Clm_IDB As ColumnHeader
    Friend WithEvents Clm_CatagoryB As ColumnHeader
    Friend WithEvents Clm_ServiceDatesB As ColumnHeader
    Friend WithEvents Clm_ReportsB As ColumnHeader
    Friend WithEvents Tb_VenueC As TabPage
    Friend WithEvents Lst_VenueC As ListView
    Friend WithEvents Clm_ProductC As ColumnHeader
    Friend WithEvents Clm_ProductIDC As ColumnHeader
    Friend WithEvents Clm_CatagoryC As ColumnHeader
    Friend WithEvents Clm_ServiceDatesC As ColumnHeader
    Friend WithEvents Clm_ReportsC As ColumnHeader
    Friend WithEvents Lst_VenueD As ListView
    Friend WithEvents Clm_ProductsD As ColumnHeader
    Friend WithEvents Clm_ProductsIDD As ColumnHeader
    Friend WithEvents Clm_CatagoryD As ColumnHeader
    Friend WithEvents Clm_ServiceDatesD As ColumnHeader
    Friend WithEvents Clm_ReportsD As ColumnHeader
    Friend WithEvents Tb_VenueD As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Btn_Home As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Btn_Supplier As Button
    Friend WithEvents Btn_Customer As Button
    Friend WithEvents Btn_LookUp As Button
    Friend WithEvents Btn_FullStock As Button
    Friend WithEvents Grp_Menu As GroupBox
    Friend WithEvents Tb_NewCustomer As TabPage
    Friend WithEvents Rbt_OutOfHouse As RadioButton
    Friend WithEvents Rbt_InHouse As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_CustomerEmail As Label
    Friend WithEvents Txb_CustomerEmail As TextBox
    Friend WithEvents Lbl_CustomerNo As Label
    Friend WithEvents Txb_CustomerNo As TextBox
    Friend WithEvents Lbl_EnterName As Label
    Friend WithEvents Tbx_EnterName As TextBox
    Friend WithEvents Label1 As Label
End Class
