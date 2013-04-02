<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Northwind_2007DataSet = New Northwind_Customers_DataGridView.Northwind_2007DataSet()
        Me.CustomerQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerQueryTableAdapter = New Northwind_Customers_DataGridView.Northwind_2007DataSetTableAdapters.CustomerQueryTableAdapter()
        Me.CompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Northwind_2007DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.JobTitleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerQueryBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(361, 510)
        Me.DataGridView1.TabIndex = 0
        '
        'Northwind_2007DataSet
        '
        Me.Northwind_2007DataSet.DataSetName = "Northwind_2007DataSet"
        Me.Northwind_2007DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerQueryBindingSource
        '
        Me.CustomerQueryBindingSource.DataMember = "CustomerQuery"
        Me.CustomerQueryBindingSource.DataSource = Me.Northwind_2007DataSet
        '
        'CustomerQueryTableAdapter
        '
        Me.CustomerQueryTableAdapter.ClearBeforeFill = True
        '
        'CompanyDataGridViewTextBoxColumn
        '
        Me.CompanyDataGridViewTextBoxColumn.DataPropertyName = "Company"
        Me.CompanyDataGridViewTextBoxColumn.HeaderText = "Company"
        Me.CompanyDataGridViewTextBoxColumn.Name = "CompanyDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'JobTitleDataGridViewTextBoxColumn
        '
        Me.JobTitleDataGridViewTextBoxColumn.DataPropertyName = "Job Title"
        Me.JobTitleDataGridViewTextBoxColumn.HeaderText = "Job Title"
        Me.JobTitleDataGridViewTextBoxColumn.Name = "JobTitleDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 510)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Northwind_2007DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Northwind_2007DataSet As Northwind_Customers_DataGridView.Northwind_2007DataSet
    Friend WithEvents CustomerQueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerQueryTableAdapter As Northwind_Customers_DataGridView.Northwind_2007DataSetTableAdapters.CustomerQueryTableAdapter
    Friend WithEvents CompanyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
