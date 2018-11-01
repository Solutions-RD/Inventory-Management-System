<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NonAdminCustomerFullStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Home = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Supplier = New System.Windows.Forms.Button()
        Me.Btn_Customer = New System.Windows.Forms.Button()
        Me.Btn_LookUp = New System.Windows.Forms.Button()
        Me.Grp_Menu = New System.Windows.Forms.GroupBox()
        Me.Btn_FullStock = New System.Windows.Forms.Button()
        Me.Lst_VenueA = New System.Windows.Forms.ListView()
        Me.Clm_ProductA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ProductIDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_CatagoryA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ServiceDatesA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_ReportsA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_Customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clm_Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Grp_Menu.SuspendLayout()
        Me.SuspendLayout()
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
        'Lst_VenueA
        '
        Me.Lst_VenueA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clm_ProductA, Me.Clm_ProductIDA, Me.Clm_Status, Me.Clm_Customer, Me.Clm_CatagoryA, Me.Clm_ServiceDatesA, Me.Clm_ReportsA})
        Me.Lst_VenueA.GridLines = True
        Me.Lst_VenueA.Location = New System.Drawing.Point(14, 110)
        Me.Lst_VenueA.Name = "Lst_VenueA"
        Me.Lst_VenueA.Size = New System.Drawing.Size(506, 264)
        Me.Lst_VenueA.TabIndex = 8
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
        Me.Clm_CatagoryA.DisplayIndex = 2
        Me.Clm_CatagoryA.Text = "Catagory"
        '
        'Clm_ServiceDatesA
        '
        Me.Clm_ServiceDatesA.DisplayIndex = 3
        Me.Clm_ServiceDatesA.Text = "Sevice Dates"
        Me.Clm_ServiceDatesA.Width = 100
        '
        'Clm_ReportsA
        '
        Me.Clm_ReportsA.DisplayIndex = 4
        Me.Clm_ReportsA.Text = "Reports"
        '
        'Clm_Customer
        '
        Me.Clm_Customer.DisplayIndex = 5
        Me.Clm_Customer.Text = "Customer"
        '
        'Clm_Status
        '
        Me.Clm_Status.DisplayIndex = 6
        Me.Clm_Status.Text = "Status"
        '
        'Frm_NonAdminCustomerFullStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.Lst_VenueA)
        Me.Controls.Add(Me.Grp_Menu)
        Me.Name = "Frm_NonAdminCustomerFullStock"
        Me.Text = "Frm_NonAdminCustomerFullStock"
        Me.Grp_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Home As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Btn_Supplier As Button
    Friend WithEvents Btn_Customer As Button
    Friend WithEvents Btn_LookUp As Button
    Friend WithEvents Grp_Menu As GroupBox
    Friend WithEvents Btn_FullStock As Button
    Friend WithEvents Lst_VenueA As ListView
    Friend WithEvents Clm_ProductA As ColumnHeader
    Friend WithEvents Clm_ProductIDA As ColumnHeader
    Friend WithEvents Clm_CatagoryA As ColumnHeader
    Friend WithEvents Clm_ServiceDatesA As ColumnHeader
    Friend WithEvents Clm_ReportsA As ColumnHeader
    Friend WithEvents Clm_Customer As ColumnHeader
    Friend WithEvents Clm_Status As ColumnHeader
End Class
