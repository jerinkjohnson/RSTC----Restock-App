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
        Me.CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet = New RSTC_APP.rstcDataSet()
        Me.CATEGORYBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.CATEGORYTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdName1 = New System.Windows.Forms.TextBox()
        Me.ProdCate1 = New System.Windows.Forms.TextBox()
        Me.ProdSize1 = New System.Windows.Forms.TextBox()
        Me.ProdCol1 = New System.Windows.Forms.TextBox()
        Me.AddProButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CATEGORYBindingSource
        '
        Me.CATEGORYBindingSource.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource.DataSource = Me.RstcDataSet
        '
        'RstcDataSet
        '
        Me.RstcDataSet.DataSetName = "rstcDataSet"
        Me.RstcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CATEGORYTableAdapter
        '
        Me.CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product Colour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Product Name"
        '
        'ProdName1
        '
        Me.ProdName1.Location = New System.Drawing.Point(349, 84)
        Me.ProdName1.Name = "ProdName1"
        Me.ProdName1.Size = New System.Drawing.Size(172, 22)
        Me.ProdName1.TabIndex = 7
        '
        'ProdCate1
        '
        Me.ProdCate1.Location = New System.Drawing.Point(353, 151)
        Me.ProdCate1.Name = "ProdCate1"
        Me.ProdCate1.Size = New System.Drawing.Size(172, 22)
        Me.ProdCate1.TabIndex = 8
        '
        'ProdSize1
        '
        Me.ProdSize1.Location = New System.Drawing.Point(349, 217)
        Me.ProdSize1.Name = "ProdSize1"
        Me.ProdSize1.Size = New System.Drawing.Size(172, 22)
        Me.ProdSize1.TabIndex = 9
        '
        'ProdCol1
        '
        Me.ProdCol1.Location = New System.Drawing.Point(349, 284)
        Me.ProdCol1.Name = "ProdCol1"
        Me.ProdCol1.Size = New System.Drawing.Size(172, 22)
        Me.ProdCol1.TabIndex = 10
        '
        'AddProButton
        '
        Me.AddProButton.Font = New System.Drawing.Font("Bolgart Display", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProButton.Location = New System.Drawing.Point(285, 360)
        Me.AddProButton.Name = "AddProButton"
        Me.AddProButton.Size = New System.Drawing.Size(163, 50)
        Me.AddProButton.TabIndex = 11
        Me.AddProButton.Text = "Add Product"
        Me.AddProButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(548, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AddProButton)
        Me.Controls.Add(Me.ProdCol1)
        Me.Controls.Add(Me.ProdSize1)
        Me.Controls.Add(Me.ProdCate1)
        Me.Controls.Add(Me.ProdName1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_product"
        Me.Text = "add_product"
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProdCate1 As TextBox
    Friend WithEvents ProdSize1 As TextBox
    Friend WithEvents ProdCol1 As TextBox
    Friend WithEvents AddProButton As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
