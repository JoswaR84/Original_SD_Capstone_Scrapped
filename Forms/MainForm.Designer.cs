namespace C898_Capstone
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inventoryDBDataSet = new C898_Capstone.InventoryDBDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new C898_Capstone.InventoryDBDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new C898_Capstone.InventoryDBDataSetTableAdapters.TableAdapterManager();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.outOfStock = new System.Windows.Forms.Button();
            this.lowItems = new System.Windows.Forms.Button();
            this.expiredItems = new System.Windows.Forms.Button();
            this.reportsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = C898_Capstone.InventoryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.AllowUserToResizeRows = false;
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inventoryDataGridView.Location = new System.Drawing.Point(12, 49);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.ShowCellErrors = false;
            this.inventoryDataGridView.ShowCellToolTips = false;
            this.inventoryDataGridView.ShowEditingIcon = false;
            this.inventoryDataGridView.ShowRowErrors = false;
            this.inventoryDataGridView.Size = new System.Drawing.Size(746, 311);
            this.inventoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Expiration Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Expiration Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Record Modified";
            this.dataGridViewTextBoxColumn7.HeaderText = "Record Modified";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(12, 13);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(565, 20);
            this.searchInput.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(583, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(175, 20);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 366);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 20);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(264, 366);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(244, 20);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(514, 366);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(244, 20);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // outOfStock
            // 
            this.outOfStock.Location = new System.Drawing.Point(13, 456);
            this.outOfStock.Name = "outOfStock";
            this.outOfStock.Size = new System.Drawing.Size(244, 23);
            this.outOfStock.TabIndex = 7;
            this.outOfStock.Text = "Out of Stock";
            this.outOfStock.UseVisualStyleBackColor = true;
            // 
            // lowItems
            // 
            this.lowItems.Location = new System.Drawing.Point(264, 456);
            this.lowItems.Name = "lowItems";
            this.lowItems.Size = new System.Drawing.Size(244, 23);
            this.lowItems.TabIndex = 8;
            this.lowItems.Text = "Low Items";
            this.lowItems.UseVisualStyleBackColor = true;
            // 
            // expiredItems
            // 
            this.expiredItems.Location = new System.Drawing.Point(514, 456);
            this.expiredItems.Name = "expiredItems";
            this.expiredItems.Size = new System.Drawing.Size(244, 23);
            this.expiredItems.TabIndex = 9;
            this.expiredItems.Text = "Expired Items";
            this.expiredItems.UseVisualStyleBackColor = true;
            // 
            // reportsLabel
            // 
            this.reportsLabel.AutoSize = true;
            this.reportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLabel.Location = new System.Drawing.Point(331, 416);
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(117, 31);
            this.reportsLabel.TabIndex = 10;
            this.reportsLabel.Text = "Reports";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.reportsLabel);
            this.Controls.Add(this.expiredItems);
            this.Controls.Add(this.lowItems);
            this.Controls.Add(this.outOfStock);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.inventoryDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private InventoryDBDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private InventoryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button outOfStock;
        private System.Windows.Forms.Button lowItems;
        private System.Windows.Forms.Button expiredItems;
        private System.Windows.Forms.Label reportsLabel;
    }
}

