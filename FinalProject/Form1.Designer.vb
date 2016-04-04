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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatagoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatagoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatagoryToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkbxCatagory = New System.Windows.Forms.CheckBox()
        Me.chkbxDepartment = New System.Windows.Forms.CheckBox()
        Me.cboCatagorySelect = New System.Windows.Forms.ComboBox()
        Me.cboDepartmentSelect = New System.Windows.Forms.ComboBox()
        Me.UPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkupMarginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearEndTotalSalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimsCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatagoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleObjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDatabaseDataSet = New FinalProject.ProjectDatabaseDataSet()
        Me.SaleObjectTableAdapter = New FinalProject.ProjectDatabaseDataSetTableAdapters.SaleObjectTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleObjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1283, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem, Me.CatagoryToolStripMenuItem, Me.DepartmentToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AddToolStripMenuItem.Text = "Add..."
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'CatagoryToolStripMenuItem
        '
        Me.CatagoryToolStripMenuItem.Name = "CatagoryToolStripMenuItem"
        Me.CatagoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CatagoryToolStripMenuItem.Text = "Catagory"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem1, Me.CatagoryToolStripMenuItem1, Me.DepartmentToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.EditToolStripMenuItem.Text = "Edit..."
        '
        'ItemToolStripMenuItem1
        '
        Me.ItemToolStripMenuItem1.Name = "ItemToolStripMenuItem1"
        Me.ItemToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ItemToolStripMenuItem1.Text = "Item"
        '
        'CatagoryToolStripMenuItem1
        '
        Me.CatagoryToolStripMenuItem1.Name = "CatagoryToolStripMenuItem1"
        Me.CatagoryToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.CatagoryToolStripMenuItem1.Text = "Catagory"
        '
        'DepartmentToolStripMenuItem1
        '
        Me.DepartmentToolStripMenuItem1.Name = "DepartmentToolStripMenuItem1"
        Me.DepartmentToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.DepartmentToolStripMenuItem1.Text = "Department"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem2, Me.CatagoryToolStripMenuItem2, Me.DepartmentToolStripMenuItem2})
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RemoveToolStripMenuItem.Text = "Remove..."
        '
        'ItemToolStripMenuItem2
        '
        Me.ItemToolStripMenuItem2.Name = "ItemToolStripMenuItem2"
        Me.ItemToolStripMenuItem2.Size = New System.Drawing.Size(137, 22)
        Me.ItemToolStripMenuItem2.Text = "Item"
        '
        'CatagoryToolStripMenuItem2
        '
        Me.CatagoryToolStripMenuItem2.Name = "CatagoryToolStripMenuItem2"
        Me.CatagoryToolStripMenuItem2.Size = New System.Drawing.Size(137, 22)
        Me.CatagoryToolStripMenuItem2.Text = "Catagory"
        '
        'DepartmentToolStripMenuItem2
        '
        Me.DepartmentToolStripMenuItem2.Name = "DepartmentToolStripMenuItem2"
        Me.DepartmentToolStripMenuItem2.Size = New System.Drawing.Size(137, 22)
        Me.DepartmentToolStripMenuItem2.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Item:"
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoGenerateColumns = False
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPCDataGridViewTextBoxColumn, Me.InventoryCountDataGridViewTextBoxColumn, Me.PurchasePriceDataGridViewTextBoxColumn, Me.MarkupMarginDataGridViewTextBoxColumn, Me.YearEndTotalSalesDataGridViewTextBoxColumn, Me.ClaimsCountDataGridViewTextBoxColumn, Me.DepartmentIdDataGridViewTextBoxColumn, Me.CatagoryIdDataGridViewTextBoxColumn})
        Me.dgvItems.DataSource = Me.SaleObjectBindingSource
        Me.dgvItems.Location = New System.Drawing.Point(15, 60)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(954, 482)
        Me.dgvItems.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(990, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Filter By:"
        '
        'chkbxCatagory
        '
        Me.chkbxCatagory.AutoSize = True
        Me.chkbxCatagory.Location = New System.Drawing.Point(993, 60)
        Me.chkbxCatagory.Name = "chkbxCatagory"
        Me.chkbxCatagory.Size = New System.Drawing.Size(68, 17)
        Me.chkbxCatagory.TabIndex = 4
        Me.chkbxCatagory.Text = "Catagory"
        Me.chkbxCatagory.UseVisualStyleBackColor = True
        '
        'chkbxDepartment
        '
        Me.chkbxDepartment.AutoSize = True
        Me.chkbxDepartment.Location = New System.Drawing.Point(993, 84)
        Me.chkbxDepartment.Name = "chkbxDepartment"
        Me.chkbxDepartment.Size = New System.Drawing.Size(81, 17)
        Me.chkbxDepartment.TabIndex = 5
        Me.chkbxDepartment.Text = "Department"
        Me.chkbxDepartment.UseVisualStyleBackColor = True
        '
        'cboCatagorySelect
        '
        Me.cboCatagorySelect.FormattingEnabled = True
        Me.cboCatagorySelect.Location = New System.Drawing.Point(1089, 60)
        Me.cboCatagorySelect.Name = "cboCatagorySelect"
        Me.cboCatagorySelect.Size = New System.Drawing.Size(65, 21)
        Me.cboCatagorySelect.TabIndex = 6
        '
        'cboDepartmentSelect
        '
        Me.cboDepartmentSelect.FormattingEnabled = True
        Me.cboDepartmentSelect.Location = New System.Drawing.Point(1089, 84)
        Me.cboDepartmentSelect.Name = "cboDepartmentSelect"
        Me.cboDepartmentSelect.Size = New System.Drawing.Size(65, 21)
        Me.cboDepartmentSelect.TabIndex = 7
        '
        'UPCDataGridViewTextBoxColumn
        '
        Me.UPCDataGridViewTextBoxColumn.DataPropertyName = "UPC"
        Me.UPCDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.UPCDataGridViewTextBoxColumn.HeaderText = "UPC"
        Me.UPCDataGridViewTextBoxColumn.Name = "UPCDataGridViewTextBoxColumn"
        Me.UPCDataGridViewTextBoxColumn.ReadOnly = True
        Me.UPCDataGridViewTextBoxColumn.Width = 110
        '
        'InventoryCountDataGridViewTextBoxColumn
        '
        Me.InventoryCountDataGridViewTextBoxColumn.DataPropertyName = "InventoryCount"
        Me.InventoryCountDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.InventoryCountDataGridViewTextBoxColumn.HeaderText = "Inventory Count"
        Me.InventoryCountDataGridViewTextBoxColumn.Name = "InventoryCountDataGridViewTextBoxColumn"
        Me.InventoryCountDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryCountDataGridViewTextBoxColumn.Width = 110
        '
        'PurchasePriceDataGridViewTextBoxColumn
        '
        Me.PurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice"
        Me.PurchasePriceDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.PurchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price"
        Me.PurchasePriceDataGridViewTextBoxColumn.Name = "PurchasePriceDataGridViewTextBoxColumn"
        Me.PurchasePriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurchasePriceDataGridViewTextBoxColumn.Width = 110
        '
        'MarkupMarginDataGridViewTextBoxColumn
        '
        Me.MarkupMarginDataGridViewTextBoxColumn.DataPropertyName = "MarkupMargin"
        Me.MarkupMarginDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.MarkupMarginDataGridViewTextBoxColumn.HeaderText = "Mark-up Margin"
        Me.MarkupMarginDataGridViewTextBoxColumn.Name = "MarkupMarginDataGridViewTextBoxColumn"
        Me.MarkupMarginDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarkupMarginDataGridViewTextBoxColumn.Width = 110
        '
        'YearEndTotalSalesDataGridViewTextBoxColumn
        '
        Me.YearEndTotalSalesDataGridViewTextBoxColumn.DataPropertyName = "YearEndTotalSales"
        Me.YearEndTotalSalesDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.YearEndTotalSalesDataGridViewTextBoxColumn.HeaderText = "Year End Total Sales"
        Me.YearEndTotalSalesDataGridViewTextBoxColumn.Name = "YearEndTotalSalesDataGridViewTextBoxColumn"
        Me.YearEndTotalSalesDataGridViewTextBoxColumn.ReadOnly = True
        Me.YearEndTotalSalesDataGridViewTextBoxColumn.Width = 150
        '
        'ClaimsCountDataGridViewTextBoxColumn
        '
        Me.ClaimsCountDataGridViewTextBoxColumn.DataPropertyName = "ClaimsCount"
        Me.ClaimsCountDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.ClaimsCountDataGridViewTextBoxColumn.HeaderText = "Claims Count"
        Me.ClaimsCountDataGridViewTextBoxColumn.Name = "ClaimsCountDataGridViewTextBoxColumn"
        Me.ClaimsCountDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaimsCountDataGridViewTextBoxColumn.Width = 110
        '
        'DepartmentIdDataGridViewTextBoxColumn
        '
        Me.DepartmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId"
        Me.DepartmentIdDataGridViewTextBoxColumn.FillWeight = 110.0!
        Me.DepartmentIdDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentIdDataGridViewTextBoxColumn.Name = "DepartmentIdDataGridViewTextBoxColumn"
        Me.DepartmentIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentIdDataGridViewTextBoxColumn.Width = 110
        '
        'CatagoryIdDataGridViewTextBoxColumn
        '
        Me.CatagoryIdDataGridViewTextBoxColumn.DataPropertyName = "CatagoryId"
        Me.CatagoryIdDataGridViewTextBoxColumn.HeaderText = "Catagory"
        Me.CatagoryIdDataGridViewTextBoxColumn.Name = "CatagoryIdDataGridViewTextBoxColumn"
        Me.CatagoryIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleObjectBindingSource
        '
        Me.SaleObjectBindingSource.DataMember = "SaleObject"
        Me.SaleObjectBindingSource.DataSource = Me.ProjectDatabaseDataSet
        '
        'ProjectDatabaseDataSet
        '
        Me.ProjectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet"
        Me.ProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleObjectTableAdapter
        '
        Me.SaleObjectTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 593)
        Me.Controls.Add(Me.cboDepartmentSelect)
        Me.Controls.Add(Me.cboCatagorySelect)
        Me.Controls.Add(Me.chkbxDepartment)
        Me.Controls.Add(Me.chkbxCatagory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleObjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatagoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CatagoryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CatagoryToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents ProjectDatabaseDataSet As ProjectDatabaseDataSet
    Friend WithEvents SaleObjectBindingSource As BindingSource
    Friend WithEvents SaleObjectTableAdapter As ProjectDatabaseDataSetTableAdapters.SaleObjectTableAdapter
    Friend WithEvents UPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarkupMarginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearEndTotalSalesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaimsCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatagoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents chkbxCatagory As CheckBox
    Friend WithEvents chkbxDepartment As CheckBox
    Friend WithEvents cboCatagorySelect As ComboBox
    Friend WithEvents cboDepartmentSelect As ComboBox
End Class
