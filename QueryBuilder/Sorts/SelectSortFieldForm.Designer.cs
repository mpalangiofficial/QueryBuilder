namespace QueryBuilder
{
    partial class SelectSortFieldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSortFieldForm));
            this.tlpSortFields = new System.Windows.Forms.TableLayoutPanel();
            this.dgOrderByFields = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSortType = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.cmbOrderByType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.OrderByTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remvoe = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpSortFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderByFields)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSortFields
            // 
            this.tlpSortFields.ColumnCount = 3;
            this.tlpSortFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSortFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSortFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSortFields.Controls.Add(this.dgOrderByFields, 0, 3);
            this.tlpSortFields.Controls.Add(this.btnAdd, 2, 2);
            this.tlpSortFields.Controls.Add(this.lblSortType, 0, 2);
            this.tlpSortFields.Controls.Add(this.lblField, 0, 1);
            this.tlpSortFields.Controls.Add(this.lblTable, 0, 0);
            this.tlpSortFields.Controls.Add(this.cmbTables, 1, 0);
            this.tlpSortFields.Controls.Add(this.cmbFields, 1, 1);
            this.tlpSortFields.Controls.Add(this.cmbOrderByType, 1, 2);
            this.tlpSortFields.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tlpSortFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSortFields.Location = new System.Drawing.Point(0, 0);
            this.tlpSortFields.Name = "tlpSortFields";
            this.tlpSortFields.RowCount = 5;
            this.tlpSortFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSortFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSortFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSortFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSortFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpSortFields.Size = new System.Drawing.Size(420, 450);
            this.tlpSortFields.TabIndex = 0;
            // 
            // dgOrderByFields
            // 
            this.dgOrderByFields.AllowUserToAddRows = false;
            this.dgOrderByFields.AllowUserToDeleteRows = false;
            this.dgOrderByFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderByFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderByTypeCol,
            this.FieldNameCol,
            this.TableNameCol,
            this.remvoe});
            this.tlpSortFields.SetColumnSpan(this.dgOrderByFields, 3);
            this.dgOrderByFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderByFields.Location = new System.Drawing.Point(3, 93);
            this.dgOrderByFields.Name = "dgOrderByFields";
            this.dgOrderByFields.ReadOnly = true;
            this.dgOrderByFields.Size = new System.Drawing.Size(414, 319);
            this.dgOrderByFields.TabIndex = 2;
            this.dgOrderByFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderByFields_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(387, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSortType
            // 
            this.lblSortType.AutoSize = true;
            this.lblSortType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSortType.Location = new System.Drawing.Point(3, 54);
            this.lblSortType.Name = "lblSortType";
            this.lblSortType.Size = new System.Drawing.Size(56, 36);
            this.lblSortType.TabIndex = 4;
            this.lblSortType.Text = "Sort Type:";
            this.lblSortType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField.Location = new System.Drawing.Point(3, 27);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(56, 27);
            this.lblField.TabIndex = 5;
            this.lblField.Text = "Field:";
            this.lblField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable.Location = new System.Drawing.Point(3, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(56, 27);
            this.lblTable.TabIndex = 6;
            this.lblTable.Text = "Table:";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTables
            // 
            this.cmbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(65, 3);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(316, 21);
            this.cmbTables.TabIndex = 7;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // cmbFields
            // 
            this.cmbFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(65, 30);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(316, 21);
            this.cmbFields.TabIndex = 8;
            // 
            // cmbOrderByType
            // 
            this.cmbOrderByType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrderByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderByType.FormattingEnabled = true;
            this.cmbOrderByType.Location = new System.Drawing.Point(65, 61);
            this.cmbOrderByType.Name = "cmbOrderByType";
            this.cmbOrderByType.Size = new System.Drawing.Size(316, 21);
            this.cmbOrderByType.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpSortFields.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 418);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 29);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cabcel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(255, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // OrderByTypeCol
            // 
            this.OrderByTypeCol.DataPropertyName = "OrderByType";
            this.OrderByTypeCol.HeaderText = "Order by type";
            this.OrderByTypeCol.Name = "OrderByTypeCol";
            this.OrderByTypeCol.ReadOnly = true;
            // 
            // FieldNameCol
            // 
            this.FieldNameCol.DataPropertyName = "FieldName";
            this.FieldNameCol.HeaderText = "Field name";
            this.FieldNameCol.Name = "FieldNameCol";
            this.FieldNameCol.ReadOnly = true;
            // 
            // TableNameCol
            // 
            this.TableNameCol.DataPropertyName = "Table";
            this.TableNameCol.HeaderText = "Table name";
            this.TableNameCol.Name = "TableNameCol";
            this.TableNameCol.ReadOnly = true;
            // 
            // remvoe
            // 
            this.remvoe.HeaderText = "";
            this.remvoe.Image = ((System.Drawing.Image)(resources.GetObject("remvoe.Image")));
            this.remvoe.Name = "remvoe";
            this.remvoe.ReadOnly = true;
            this.remvoe.Width = 50;
            // 
            // SelectSortFieldForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.tlpSortFields);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSortFieldForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SelectSortFieldForm";
            this.tlpSortFields.ResumeLayout(false);
            this.tlpSortFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderByFields)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSortFields;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgOrderByFields;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSortType;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.ComboBox cmbOrderByType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderByTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNameCol;
        private System.Windows.Forms.DataGridViewImageColumn remvoe;
    }
}