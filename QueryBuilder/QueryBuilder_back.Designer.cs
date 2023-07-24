namespace QueryBuildersSample
{
    partial class QueryBuilder_back
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTables = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.btnGetDatabaseSchema = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.txtSelectedTable = new System.Windows.Forms.TextBox();
            this.dgSelectedFields = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.lblScript = new System.Windows.Forms.Label();
            this.txtTableAlise = new System.Windows.Forms.TextBox();
            this.chkJoin = new System.Windows.Forms.CheckBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedFields)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunScript
            // 
            this.btnRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScript.Location = new System.Drawing.Point(784, 525);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(87, 35);
            this.btnRunScript.TabIndex = 0;
            this.btnRunScript.Text = "Run";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnRunScript, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConnectionString, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGetDatabaseSchema, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 572);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnectionString.Location = new System.Drawing.Point(3, 517);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(775, 52);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "Password=ffc-pr-02;Persist Security Info=True;User ID=sa;Initial Catalog=SRU;Data" +
    " Source=192.168.100.196";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblTables, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTables, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFields, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbFields, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAddTable, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddField, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedTable, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSelectedTable, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dgSelectedFields, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtScript, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblScript, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtTableAlise, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkJoin, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnJoin, 5, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(961, 508);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTables.Location = new System.Drawing.Point(3, 0);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(82, 29);
            this.lblTables.TabIndex = 0;
            this.lblTables.Text = "DbTables:";
            this.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTables
            // 
            this.cmbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(91, 4);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(476, 21);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFields.Location = new System.Drawing.Point(3, 29);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(82, 29);
            this.lblFields.TabIndex = 2;
            this.lblFields.Text = "Fields:";
            this.lblFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFields
            // 
            this.cmbFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(91, 33);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(476, 21);
            this.cmbFields.TabIndex = 1;
            // 
            // btnGetDatabaseSchema
            // 
            this.btnGetDatabaseSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDatabaseSchema.Location = new System.Drawing.Point(877, 525);
            this.btnGetDatabaseSchema.Name = "btnGetDatabaseSchema";
            this.btnGetDatabaseSchema.Size = new System.Drawing.Size(87, 35);
            this.btnGetDatabaseSchema.TabIndex = 0;
            this.btnGetDatabaseSchema.Text = "Get db Schema";
            this.btnGetDatabaseSchema.UseVisualStyleBackColor = true;
            this.btnGetDatabaseSchema.Click += new System.EventHandler(this.btnGetDatabaseSchema_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Location = new System.Drawing.Point(573, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(39, 23);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = " +";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddField.Location = new System.Drawing.Point(573, 32);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(39, 23);
            this.btnAddField.TabIndex = 3;
            this.btnAddField.Text = " +";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedTable.Location = new System.Drawing.Point(3, 58);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(82, 26);
            this.lblSelectedTable.TabIndex = 4;
            this.lblSelectedTable.Text = "Selected table:";
            this.lblSelectedTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSelectedTable
            // 
            this.txtSelectedTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedTable.Location = new System.Drawing.Point(91, 61);
            this.txtSelectedTable.Name = "txtSelectedTable";
            this.txtSelectedTable.Size = new System.Drawing.Size(476, 20);
            this.txtSelectedTable.TabIndex = 5;
            // 
            // dgSelectedFields
            // 
            this.dgSelectedFields.AllowUserToAddRows = false;
            this.dgSelectedFields.AllowUserToDeleteRows = false;
            this.dgSelectedFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectedFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.btnRemove});
            this.dgSelectedFields.Location = new System.Drawing.Point(91, 87);
            this.dgSelectedFields.Name = "dgSelectedFields";
            this.dgSelectedFields.ReadOnly = true;
            this.dgSelectedFields.Size = new System.Drawing.Size(476, 150);
            this.dgSelectedFields.TabIndex = 6;
            this.dgSelectedFields.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectedFields_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected Fields:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // btnRemove
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            this.btnRemove.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.HeaderText = "";
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ReadOnly = true;
            this.btnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnRemove.Text = "remove";
            this.btnRemove.Width = 60;
            // 
            // txtScript
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtScript, 3);
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScript.Location = new System.Drawing.Point(91, 243);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(582, 95);
            this.txtScript.TabIndex = 8;
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScript.Location = new System.Drawing.Point(3, 245);
            this.lblScript.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(82, 13);
            this.lblScript.TabIndex = 9;
            this.lblScript.Text = "Script:";
            this.lblScript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTableAlise
            // 
            this.txtTableAlise.Location = new System.Drawing.Point(573, 61);
            this.txtTableAlise.Name = "txtTableAlise";
            this.txtTableAlise.Size = new System.Drawing.Size(100, 20);
            this.txtTableAlise.TabIndex = 10;
            // 
            // chkJoin
            // 
            this.chkJoin.AutoSize = true;
            this.chkJoin.Location = new System.Drawing.Point(91, 344);
            this.chkJoin.Name = "chkJoin";
            this.chkJoin.Size = new System.Drawing.Size(45, 17);
            this.chkJoin.TabIndex = 11;
            this.chkJoin.Text = "Join";
            this.chkJoin.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(679, 61);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(60, 20);
            this.btnJoin.TabIndex = 12;
            this.btnJoin.Text = "join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // QueryBuilder_back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QueryBuilder_back";
            this.Size = new System.Drawing.Size(967, 572);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Button btnGetDatabaseSchema;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.TextBox txtSelectedTable;
        private System.Windows.Forms.DataGridView dgSelectedFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemove;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Label lblScript;
        private System.Windows.Forms.TextBox txtTableAlise;
        private System.Windows.Forms.CheckBox chkJoin;
        private System.Windows.Forms.Button btnJoin;
    }
}
