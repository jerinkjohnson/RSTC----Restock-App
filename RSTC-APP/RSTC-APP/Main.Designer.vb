<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StockAvailabilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RstcDataSet = New RSTC_APP.rstcDataSet()
        Me.RstcDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.PRODUCTTableAdapter()
        Me.PRODUCTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TShirtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TShirtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoodiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SweatshirtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToteBagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoodiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoAlertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDesignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfflineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bolgart Display", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(140, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory Management"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Bolgart Display", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockAvailabilityToolStripMenuItem, Me.DesignLibraryToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(124, 93)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StockAvailabilityToolStripMenuItem
        '
        Me.StockAvailabilityToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.StockAvailabilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TShirtToolStripMenuItem, Me.HoodiesToolStripMenuItem, Me.AutoAlertToolStripMenuItem})
        Me.StockAvailabilityToolStripMenuItem.Name = "StockAvailabilityToolStripMenuItem"
        Me.StockAvailabilityToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.StockAvailabilityToolStripMenuItem.Text = "Stock Availability"
        '
        'DesignLibraryToolStripMenuItem
        '
        Me.DesignLibraryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowDesignsToolStripMenuItem})
        Me.DesignLibraryToolStripMenuItem.Name = "DesignLibraryToolStripMenuItem"
        Me.DesignLibraryToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.DesignLibraryToolStripMenuItem.Text = "Design Library"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageOrdersToolStripMenuItem, Me.PlaceOrderToolStripMenuItem, Me.OrderHistoryToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(72, 26)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OfflineToolStripMenuItem, Me.OnlineToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(111, 26)
        Me.SalesToolStripMenuItem.Text = "Sales Status"
        '
        'RstcDataSet
        '
        Me.RstcDataSet.DataSetName = "rstcDataSet"
        Me.RstcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RstcDataSetBindingSource
        '
        Me.RstcDataSetBindingSource.DataSource = Me.RstcDataSet
        Me.RstcDataSetBindingSource.Position = 0
        '
        'PRODUCTBindingSource
        '
        Me.PRODUCTBindingSource.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource.DataSource = Me.RstcDataSet
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTBindingSource2
        '
        Me.PRODUCTBindingSource2.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource2.DataSource = Me.RstcDataSetBindingSource
        '
        'PRODUCTBindingSource1
        '
        Me.PRODUCTBindingSource1.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource1.DataSource = Me.RstcDataSetBindingSource
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "T - Shirt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sweatshirt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hoodie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tote Bags"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.Font = New System.Drawing.Font("Montserrat Subrayada", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(221, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 64)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "– Refresh Stock –"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat Subrayada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dashboard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(218, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "•"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(219, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "•"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(218, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "•"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Montserrat Subrayada", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(218, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "•"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Montserrat Subrayada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(368, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 24)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "֎"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'TShirtToolStripMenuItem
        '
        Me.TShirtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TShirtToolStripMenuItem1, Me.HoodiesToolStripMenuItem1, Me.SweatshirtToolStripMenuItem1, Me.ToteBagToolStripMenuItem})
        Me.TShirtToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_package_48
        Me.TShirtToolStripMenuItem.Name = "TShirtToolStripMenuItem"
        Me.TShirtToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TShirtToolStripMenuItem.Text = "Products"
        '
        'TShirtToolStripMenuItem1
        '
        Me.TShirtToolStripMenuItem1.Image = Global.RSTC_APP.My.Resources.Resources.icons8_t_shirt_64
        Me.TShirtToolStripMenuItem1.Name = "TShirtToolStripMenuItem1"
        Me.TShirtToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.TShirtToolStripMenuItem1.Text = "T Shirt"
        '
        'HoodiesToolStripMenuItem1
        '
        Me.HoodiesToolStripMenuItem1.Image = Global.RSTC_APP.My.Resources.Resources.sweater
        Me.HoodiesToolStripMenuItem1.Name = "HoodiesToolStripMenuItem1"
        Me.HoodiesToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.HoodiesToolStripMenuItem1.Text = "Hoodies"
        '
        'SweatshirtToolStripMenuItem1
        '
        Me.SweatshirtToolStripMenuItem1.Image = Global.RSTC_APP.My.Resources.Resources.hoodie
        Me.SweatshirtToolStripMenuItem1.Name = "SweatshirtToolStripMenuItem1"
        Me.SweatshirtToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.SweatshirtToolStripMenuItem1.Text = "Sweatshirt"
        '
        'ToteBagToolStripMenuItem
        '
        Me.ToteBagToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.tote_bag
        Me.ToteBagToolStripMenuItem.Name = "ToteBagToolStripMenuItem"
        Me.ToteBagToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ToteBagToolStripMenuItem.Text = "Tote Bag"
        '
        'HoodiesToolStripMenuItem
        '
        Me.HoodiesToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_add_product_48
        Me.HoodiesToolStripMenuItem.Name = "HoodiesToolStripMenuItem"
        Me.HoodiesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HoodiesToolStripMenuItem.Text = "Add Products"
        '
        'AutoAlertToolStripMenuItem
        '
        Me.AutoAlertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableToolStripMenuItem, Me.DisableToolStripMenuItem})
        Me.AutoAlertToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.alarm
        Me.AutoAlertToolStripMenuItem.Name = "AutoAlertToolStripMenuItem"
        Me.AutoAlertToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AutoAlertToolStripMenuItem.Text = "Auto Alert"
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_done_48
        Me.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_cross_mark_48
        Me.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'ShowDesignsToolStripMenuItem
        '
        Me.ShowDesignsToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_dribbble_64
        Me.ShowDesignsToolStripMenuItem.Name = "ShowDesignsToolStripMenuItem"
        Me.ShowDesignsToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.ShowDesignsToolStripMenuItem.Text = "Show Designs"
        '
        'ManageOrdersToolStripMenuItem
        '
        Me.ManageOrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ManageOrdersToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_purchase_order_48
        Me.ManageOrdersToolStripMenuItem.Name = "ManageOrdersToolStripMenuItem"
        Me.ManageOrdersToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManageOrdersToolStripMenuItem.Text = "Manage Orders"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_delete_document_48
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'PlaceOrderToolStripMenuItem
        '
        Me.PlaceOrderToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_create_order_48
        Me.PlaceOrderToolStripMenuItem.Name = "PlaceOrderToolStripMenuItem"
        Me.PlaceOrderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PlaceOrderToolStripMenuItem.Text = "Place Order"
        '
        'OrderHistoryToolStripMenuItem
        '
        Me.OrderHistoryToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_create_order_48__1_
        Me.OrderHistoryToolStripMenuItem.Name = "OrderHistoryToolStripMenuItem"
        Me.OrderHistoryToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OrderHistoryToolStripMenuItem.Text = "Order History"
        '
        'OfflineToolStripMenuItem
        '
        Me.OfflineToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_offline_26
        Me.OfflineToolStripMenuItem.Name = "OfflineToolStripMenuItem"
        Me.OfflineToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.OfflineToolStripMenuItem.Text = "Offline"
        '
        'OnlineToolStripMenuItem
        '
        Me.OnlineToolStripMenuItem.Image = Global.RSTC_APP.My.Resources.Resources.icons8_online_48
        Me.OnlineToolStripMenuItem.Name = "OnlineToolStripMenuItem"
        Me.OnlineToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.OnlineToolStripMenuItem.Text = "Online"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(426, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(426, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(426, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(426, 332)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Label15"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(710, 527)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSTC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StockAvailabilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TShirtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoodiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesignLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TShirtToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HoodiesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SweatshirtToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToteBagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowDesignsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RstcDataSetBindingSource As BindingSource
    Friend WithEvents RstcDataSet As rstcDataSet
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As rstcDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents PRODUCTBindingSource2 As BindingSource
    Friend WithEvents PRODUCTBindingSource1 As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PlaceOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoAlertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents EnableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OfflineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents OnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
