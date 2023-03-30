<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StockAvailabilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TShirtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TShirtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoodiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SweatshirtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToteBagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoodiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDesignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RstcDataSet = New RSTC_APP.rstcDataSet()
        Me.RstcDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.PRODUCTTableAdapter()
        Me.PRODUCTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Bolgart Display", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RSTC - APP"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Bolgart Display", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockAvailabilityToolStripMenuItem, Me.DesignLibraryToolStripMenuItem, Me.OrdersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(39, 88)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(504, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StockAvailabilityToolStripMenuItem
        '
        Me.StockAvailabilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TShirtToolStripMenuItem, Me.HoodiesToolStripMenuItem})
        Me.StockAvailabilityToolStripMenuItem.Name = "StockAvailabilityToolStripMenuItem"
        Me.StockAvailabilityToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.StockAvailabilityToolStripMenuItem.Text = "Stock Availability"
        '
        'TShirtToolStripMenuItem
        '
        Me.TShirtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TShirtToolStripMenuItem1, Me.HoodiesToolStripMenuItem1, Me.SweatshirtToolStripMenuItem1, Me.ToteBagToolStripMenuItem})
        Me.TShirtToolStripMenuItem.Name = "TShirtToolStripMenuItem"
        Me.TShirtToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.TShirtToolStripMenuItem.Text = "Products"
        '
        'TShirtToolStripMenuItem1
        '
        Me.TShirtToolStripMenuItem1.Name = "TShirtToolStripMenuItem1"
        Me.TShirtToolStripMenuItem1.Size = New System.Drawing.Size(169, 26)
        Me.TShirtToolStripMenuItem1.Text = "T Shirt"
        '
        'HoodiesToolStripMenuItem1
        '
        Me.HoodiesToolStripMenuItem1.Name = "HoodiesToolStripMenuItem1"
        Me.HoodiesToolStripMenuItem1.Size = New System.Drawing.Size(169, 26)
        Me.HoodiesToolStripMenuItem1.Text = "Hoodies"
        '
        'SweatshirtToolStripMenuItem1
        '
        Me.SweatshirtToolStripMenuItem1.Name = "SweatshirtToolStripMenuItem1"
        Me.SweatshirtToolStripMenuItem1.Size = New System.Drawing.Size(169, 26)
        Me.SweatshirtToolStripMenuItem1.Text = "Sweatshirt"
        '
        'ToteBagToolStripMenuItem
        '
        Me.ToteBagToolStripMenuItem.Name = "ToteBagToolStripMenuItem"
        Me.ToteBagToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.ToteBagToolStripMenuItem.Text = "Tote Bag"
        '
        'HoodiesToolStripMenuItem
        '
        Me.HoodiesToolStripMenuItem.Name = "HoodiesToolStripMenuItem"
        Me.HoodiesToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.HoodiesToolStripMenuItem.Text = "Add Products"
        '
        'DesignLibraryToolStripMenuItem
        '
        Me.DesignLibraryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowDesignsToolStripMenuItem})
        Me.DesignLibraryToolStripMenuItem.Name = "DesignLibraryToolStripMenuItem"
        Me.DesignLibraryToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.DesignLibraryToolStripMenuItem.Text = "Design Library"
        '
        'ShowDesignsToolStripMenuItem
        '
        Me.ShowDesignsToolStripMenuItem.Name = "ShowDesignsToolStripMenuItem"
        Me.ShowDesignsToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.ShowDesignsToolStripMenuItem.Text = "Show Designs"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderHistoryToolStripMenuItem, Me.ManageOrdersToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(72, 26)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'OrderHistoryToolStripMenuItem
        '
        Me.OrderHistoryToolStripMenuItem.Name = "OrderHistoryToolStripMenuItem"
        Me.OrderHistoryToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OrderHistoryToolStripMenuItem.Text = "Order History"
        '
        'ManageOrdersToolStripMenuItem
        '
        Me.ManageOrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ManageOrdersToolStripMenuItem.Name = "ManageOrdersToolStripMenuItem"
        Me.ManageOrdersToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManageOrdersToolStripMenuItem.Text = "Manage Orders"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
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
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(52, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(259, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.Location = New System.Drawing.Point(342, 156)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView3.Location = New System.Drawing.Point(342, 337)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 4
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView4.Location = New System.Drawing.Point(52, 337)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView4.TabIndex = 5
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(824, 512)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents OrderHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowDesignsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RstcDataSetBindingSource As BindingSource
    Friend WithEvents RstcDataSet As rstcDataSet
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As rstcDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents PRODUCTBindingSource2 As BindingSource
    Friend WithEvents PRODUCTBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
End Class
