<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_product
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
        Me.CATEGORYBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet = New RSTC_APP.rstcDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdName1 = New System.Windows.Forms.TextBox()
        Me.AddProButton = New System.Windows.Forms.Button()
        Me.Test1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SIZEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIZEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.COLORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet1 = New RSTC_APP.rstcDataSet()
        Me.COLORBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CATEGORYTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.CATEGORYTableAdapter()
        Me.SIZETableAdapter = New RSTC_APP.rstcDataSetTableAdapters.SIZETableAdapter()
        Me.COLORTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.COLORTableAdapter()
        Me.COLORBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderButton = New System.Windows.Forms.Button()
        CType(Me.CATEGORYBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIZEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIZEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.COLORBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CATEGORYBindingSource1
        '
        Me.CATEGORYBindingSource1.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource1.DataSource = Me.RstcDataSetBindingSource
        '
        'RstcDataSetBindingSource
        '
        Me.RstcDataSetBindingSource.DataSource = Me.RstcDataSet
        Me.RstcDataSetBindingSource.Position = 0
        '
        'RstcDataSet
        '
        Me.RstcDataSet.DataSetName = "rstcDataSet"
        Me.RstcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat Subrayada", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat Subrayada", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat Subrayada", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product Colour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat Subrayada", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Product Name"
        '
        'ProdName1
        '
        Me.ProdName1.Location = New System.Drawing.Point(349, 84)
        Me.ProdName1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProdName1.Name = "ProdName1"
        Me.ProdName1.Size = New System.Drawing.Size(172, 22)
        Me.ProdName1.TabIndex = 7
        '
        'AddProButton
        '
        Me.AddProButton.Font = New System.Drawing.Font("Bolgart Display", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProButton.Location = New System.Drawing.Point(282, 352)
        Me.AddProButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddProButton.Name = "AddProButton"
        Me.AddProButton.Size = New System.Drawing.Size(163, 50)
        Me.AddProButton.TabIndex = 11
        Me.AddProButton.Text = "Add Product"
        Me.AddProButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CATEGORYBindingSource, "CATEGORY_ID", True))
        Me.ComboBox1.DataSource = Me.CATEGORYBindingSource5
        Me.ComboBox1.DisplayMember = "CATEGORY_NAME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(349, 142)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 24)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "CATEGORY_ID"
        '
        'CATEGORYBindingSource
        '
        Me.CATEGORYBindingSource.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource.DataSource = Me.RstcDataSet
        '
        'CATEGORYBindingSource5
        '
        Me.CATEGORYBindingSource5.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource5.DataSource = Me.RstcDataSetBindingSource
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SIZEBindingSource, "SIZE_NO", True))
        Me.ComboBox2.DataSource = Me.SIZEBindingSource1
        Me.ComboBox2.DisplayMember = "SIZE_NAME"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(349, 210)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(172, 24)
        Me.ComboBox2.TabIndex = 13
        Me.ComboBox2.ValueMember = "SIZE_NO"
        '
        'SIZEBindingSource
        '
        Me.SIZEBindingSource.DataMember = "SIZE"
        Me.SIZEBindingSource.DataSource = Me.RstcDataSetBindingSource
        '
        'SIZEBindingSource1
        '
        Me.SIZEBindingSource1.DataMember = "SIZE"
        Me.SIZEBindingSource1.DataSource = Me.RstcDataSetBindingSource
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COLORBindingSource, "COLOR_CODE", True))
        Me.ComboBox3.DataSource = Me.COLORBindingSource2
        Me.ComboBox3.DisplayMember = "COLOR_NAME"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(349, 281)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(172, 24)
        Me.ComboBox3.TabIndex = 14
        Me.ComboBox3.ValueMember = "COLOR_CODE"
        '
        'COLORBindingSource
        '
        Me.COLORBindingSource.DataMember = "COLOR"
        Me.COLORBindingSource.DataSource = Me.RstcDataSet1BindingSource
        '
        'RstcDataSet1BindingSource
        '
        Me.RstcDataSet1BindingSource.DataSource = Me.RstcDataSet1
        Me.RstcDataSet1BindingSource.Position = 0
        '
        'RstcDataSet1
        '
        Me.RstcDataSet1.DataSetName = "rstcDataSet"
        Me.RstcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLORBindingSource2
        '
        Me.COLORBindingSource2.DataMember = "COLOR"
        Me.COLORBindingSource2.DataSource = Me.RstcDataSet1BindingSource
        '
        'CATEGORYBindingSource2
        '
        Me.CATEGORYBindingSource2.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource2.DataSource = Me.RstcDataSetBindingSource
        '
        'CATEGORYBindingSource3
        '
        Me.CATEGORYBindingSource3.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource3.DataSource = Me.RstcDataSetBindingSource
        '
        'CATEGORYBindingSource4
        '
        Me.CATEGORYBindingSource4.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource4.DataSource = Me.RstcDataSetBindingSource
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(800, 31)
        Me.FillByToolStrip.TabIndex = 15
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 28)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'CATEGORYTableAdapter
        '
        Me.CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'SIZETableAdapter
        '
        Me.SIZETableAdapter.ClearBeforeFill = True
        '
        'COLORTableAdapter
        '
        Me.COLORTableAdapter.ClearBeforeFill = True
        '
        'COLORBindingSource1
        '
        Me.COLORBindingSource1.DataMember = "COLOR"
        Me.COLORBindingSource1.DataSource = Me.RstcDataSetBindingSource
        '
        'OrderButton
        '
        Me.OrderButton.Font = New System.Drawing.Font("Bolgart Display", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.Location = New System.Drawing.Point(282, 352)
        Me.OrderButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(163, 50)
        Me.OrderButton.TabIndex = 16
        Me.OrderButton.Text = "Order Product"
        Me.OrderButton.UseVisualStyleBackColor = True
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RSTC_APP.My.Resources.Resources.RSTC_BG2
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AddProButton)
        Me.Controls.Add(Me.ProdName1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "add_product"
        Me.Text = "add_product"
        CType(Me.CATEGORYBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIZEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIZEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.COLORBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Test1DataSetBindingSource As BindingSource
    Friend WithEvents RstcDataSetBindingSource As BindingSource
    Friend WithEvents RstcDataSet As rstcDataSet
    Friend WithEvents CATEGORYBindingSource As BindingSource
    Friend WithEvents CATEGORYTableAdapter As rstcDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents CATEGORYBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProdName1 As TextBox
    Friend WithEvents AddProButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CATEGORYBindingSource2 As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents CATEGORYBindingSource3 As BindingSource
    Friend WithEvents CATEGORYBindingSource4 As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents CATEGORYBindingSource5 As BindingSource
    Friend WithEvents RstcDataSet1BindingSource As BindingSource
    Friend WithEvents RstcDataSet1 As rstcDataSet
    Friend WithEvents SIZEBindingSource As BindingSource
    Friend WithEvents SIZETableAdapter As rstcDataSetTableAdapters.SIZETableAdapter
    Friend WithEvents COLORBindingSource As BindingSource
    Friend WithEvents COLORTableAdapter As rstcDataSetTableAdapters.COLORTableAdapter
    Friend WithEvents SIZEBindingSource1 As BindingSource
    Friend WithEvents COLORBindingSource1 As BindingSource
    Friend WithEvents COLORBindingSource2 As BindingSource
    Friend WithEvents OrderButton As Button
End Class
