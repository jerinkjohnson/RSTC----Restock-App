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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Test1DataSet = New RSTC_APP.test1DataSet()
        Me.Test1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet = New RSTC_APP.rstcDataSet()
        Me.RstcDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORYTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.CATEGORYTableAdapter()
        Me.CATEGORYBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Test1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CATEGORYBindingSource, "CATEGORY_NAME", True))
        Me.ComboBox1.DataSource = Me.CATEGORYBindingSource1
        Me.ComboBox1.DisplayMember = "CATEGORY_NAME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(350, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CATEGORY_NAME"
        '
        'Test1DataSet
        '
        Me.Test1DataSet.DataSetName = "test1DataSet"
        Me.Test1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Test1DataSetBindingSource
        '
        Me.Test1DataSetBindingSource.DataSource = Me.Test1DataSet
        Me.Test1DataSetBindingSource.Position = 0
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
        'CATEGORYBindingSource
        '
        Me.CATEGORYBindingSource.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource.DataSource = Me.RstcDataSet
        '
        'CATEGORYTableAdapter
        '
        Me.CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'CATEGORYBindingSource1
        '
        Me.CATEGORYBindingSource1.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource1.DataSource = Me.RstcDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Category:"
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "add_product"
        Me.Text = "add_product"
        CType(Me.Test1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Test1DataSetBindingSource As BindingSource
    Friend WithEvents Test1DataSet As test1DataSet
    Friend WithEvents RstcDataSetBindingSource As BindingSource
    Friend WithEvents RstcDataSet As rstcDataSet
    Friend WithEvents CATEGORYBindingSource As BindingSource
    Friend WithEvents CATEGORYTableAdapter As rstcDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents CATEGORYBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
End Class
