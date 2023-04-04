<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderHistoryForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ORDERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERHISTORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HISTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet1 = New RSTC_APP.rstcDataSet()
        Me.RstcDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RstcDataSet = New RSTC_APP.rstcDataSet()
        Me.HISTORYTableAdapter = New RSTC_APP.rstcDataSetTableAdapters.HISTORYTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDERIDDataGridViewTextBoxColumn, Me.ORDERHISTORYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HISTORYBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 692)
        Me.DataGridView1.TabIndex = 0
        '
        'ORDERIDDataGridViewTextBoxColumn
        '
        Me.ORDERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ORDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER_ID"
        Me.ORDERIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ORDERIDDataGridViewTextBoxColumn.Name = "ORDERIDDataGridViewTextBoxColumn"
        Me.ORDERIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ORDERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ORDERIDDataGridViewTextBoxColumn.Width = 108
        '
        'ORDERHISTORYDataGridViewTextBoxColumn
        '
        Me.ORDERHISTORYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ORDERHISTORYDataGridViewTextBoxColumn.DataPropertyName = "ORDER_HISTORY"
        Me.ORDERHISTORYDataGridViewTextBoxColumn.HeaderText = "ORDER_HISTORY"
        Me.ORDERHISTORYDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ORDERHISTORYDataGridViewTextBoxColumn.Name = "ORDERHISTORYDataGridViewTextBoxColumn"
        Me.ORDERHISTORYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HISTORYBindingSource
        '
        Me.HISTORYBindingSource.DataMember = "HISTORY"
        Me.HISTORYBindingSource.DataSource = Me.RstcDataSet1
        '
        'RstcDataSet1
        '
        Me.RstcDataSet1.DataSetName = "rstcDataSet"
        Me.RstcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'HISTORYTableAdapter
        '
        Me.HISTORYTableAdapter.ClearBeforeFill = True
        '
        'OrderHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 692)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OrderHistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrderHistoryForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RstcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RstcDataSetBindingSource As BindingSource
    Friend WithEvents RstcDataSet As rstcDataSet
    Friend WithEvents RstcDataSet1 As rstcDataSet
    Friend WithEvents HISTORYBindingSource As BindingSource
    Friend WithEvents HISTORYTableAdapter As rstcDataSetTableAdapters.HISTORYTableAdapter
    Friend WithEvents ORDERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ORDERHISTORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
