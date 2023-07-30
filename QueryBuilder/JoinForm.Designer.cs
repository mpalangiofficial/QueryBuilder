namespace QueryBuilder
{
    partial class JoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpJoin = new System.Windows.Forms.TableLayoutPanel();
            this.dgJoinOns = new System.Windows.Forms.DataGridView();
            this.LeftTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftFieldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightFieldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRightTableAlias = new System.Windows.Forms.TextBox();
            this.tlpCommandButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddJoinOn = new System.Windows.Forms.Button();
            this.txtRightTableName = new System.Windows.Forms.TextBox();
            this.lblRightTableName = new System.Windows.Forms.Label();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.tlpJoin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJoinOns)).BeginInit();
            this.tlpCommandButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpJoin
            // 
            this.tlpJoin.ColumnCount = 3;
            this.tlpJoin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpJoin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpJoin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpJoin.Controls.Add(this.dgJoinOns, 0, 3);
            this.tlpJoin.Controls.Add(this.label1, 0, 1);
            this.tlpJoin.Controls.Add(this.txtRightTableAlias, 1, 1);
            this.tlpJoin.Controls.Add(this.tlpCommandButton, 0, 4);
            this.tlpJoin.Controls.Add(this.btnAddJoinOn, 0, 2);
            this.tlpJoin.Controls.Add(this.txtRightTableName, 1, 0);
            this.tlpJoin.Controls.Add(this.lblRightTableName, 0, 0);
            this.tlpJoin.Controls.Add(this.btnSelectTable, 2, 0);
            this.tlpJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpJoin.Location = new System.Drawing.Point(0, 0);
            this.tlpJoin.Name = "tlpJoin";
            this.tlpJoin.RowCount = 5;
            this.tlpJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpJoin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpJoin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpJoin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpJoin.Size = new System.Drawing.Size(488, 330);
            this.tlpJoin.TabIndex = 1;
            // 
            // dgJoinOns
            // 
            this.dgJoinOns.AllowUserToAddRows = false;
            this.dgJoinOns.AllowUserToDeleteRows = false;
            this.dgJoinOns.AllowUserToResizeRows = false;
            this.dgJoinOns.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgJoinOns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgJoinOns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJoinOns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftTableColumn,
            this.LeftFieldColumn,
            this.RightTableColumn,
            this.RightFieldColumn,
            this.edit,
            this.Remove});
            this.tlpJoin.SetColumnSpan(this.dgJoinOns, 3);
            this.dgJoinOns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgJoinOns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgJoinOns.Location = new System.Drawing.Point(3, 82);
            this.dgJoinOns.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dgJoinOns.Name = "dgJoinOns";
            this.dgJoinOns.ReadOnly = true;
            this.dgJoinOns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgJoinOns.RowHeadersVisible = false;
            this.dgJoinOns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgJoinOns.ShowRowErrors = false;
            this.dgJoinOns.Size = new System.Drawing.Size(482, 205);
            this.dgJoinOns.TabIndex = 3;
            this.dgJoinOns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJoinOns_CellContentClick);
            // 
            // LeftTableColumn
            // 
            this.LeftTableColumn.DataPropertyName = "LeftTable";
            this.LeftTableColumn.HeaderText = "Left Table";
            this.LeftTableColumn.Name = "LeftTableColumn";
            this.LeftTableColumn.ReadOnly = true;
            // 
            // LeftFieldColumn
            // 
            this.LeftFieldColumn.DataPropertyName = "LeftField";
            this.LeftFieldColumn.HeaderText = "Left Field";
            this.LeftFieldColumn.Name = "LeftFieldColumn";
            this.LeftFieldColumn.ReadOnly = true;
            // 
            // RightTableColumn
            // 
            this.RightTableColumn.DataPropertyName = "RightTable";
            this.RightTableColumn.HeaderText = "Right Table";
            this.RightTableColumn.Name = "RightTableColumn";
            this.RightTableColumn.ReadOnly = true;
            // 
            // RightFieldColumn
            // 
            this.RightFieldColumn.DataPropertyName = "RightField";
            this.RightFieldColumn.HeaderText = "Right Field";
            this.RightFieldColumn.Name = "RightFieldColumn";
            this.RightFieldColumn.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 40;
            // 
            // Remove
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.NullValue = null;
            this.Remove.DefaultCellStyle = dataGridViewCellStyle1;
            this.Remove.HeaderText = "";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "alias:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRightTableAlias
            // 
            this.txtRightTableAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRightTableAlias.Location = new System.Drawing.Point(83, 29);
            this.txtRightTableAlias.Name = "txtRightTableAlias";
            this.txtRightTableAlias.Size = new System.Drawing.Size(321, 20);
            this.txtRightTableAlias.TabIndex = 5;
            this.txtRightTableAlias.TextChanged += new System.EventHandler(this.txtAlias_TextChanged);
            this.txtRightTableAlias.Leave += new System.EventHandler(this.txtRightTableAlias_Leave);
            // 
            // tlpCommandButton
            // 
            this.tlpCommandButton.ColumnCount = 3;
            this.tlpJoin.SetColumnSpan(this.tlpCommandButton, 3);
            this.tlpCommandButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommandButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCommandButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCommandButton.Controls.Add(this.btnOk, 1, 0);
            this.tlpCommandButton.Controls.Add(this.btnCancel, 2, 0);
            this.tlpCommandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommandButton.Location = new System.Drawing.Point(3, 293);
            this.tlpCommandButton.Name = "tlpCommandButton";
            this.tlpCommandButton.RowCount = 1;
            this.tlpCommandButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommandButton.Size = new System.Drawing.Size(482, 34);
            this.tlpCommandButton.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(353, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 25);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(419, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddJoinOn
            // 
            this.tlpJoin.SetColumnSpan(this.btnAddJoinOn, 2);
            this.btnAddJoinOn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddJoinOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJoinOn.Location = new System.Drawing.Point(3, 57);
            this.btnAddJoinOn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.btnAddJoinOn.Name = "btnAddJoinOn";
            this.btnAddJoinOn.Size = new System.Drawing.Size(112, 25);
            this.btnAddJoinOn.TabIndex = 2;
            this.btnAddJoinOn.Text = "Add JoinOn";
            this.btnAddJoinOn.UseVisualStyleBackColor = true;
            this.btnAddJoinOn.Click += new System.EventHandler(this.btnAddJoinOn_Click);
            // 
            // txtRightTableName
            // 
            this.txtRightTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRightTableName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRightTableName.Location = new System.Drawing.Point(83, 3);
            this.txtRightTableName.Name = "txtRightTableName";
            this.txtRightTableName.ReadOnly = true;
            this.txtRightTableName.Size = new System.Drawing.Size(321, 20);
            this.txtRightTableName.TabIndex = 0;
            this.txtRightTableName.DoubleClick += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // lblRightTableName
            // 
            this.lblRightTableName.AutoSize = true;
            this.lblRightTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightTableName.Location = new System.Drawing.Point(3, 0);
            this.lblRightTableName.Name = "lblRightTableName";
            this.lblRightTableName.Size = new System.Drawing.Size(74, 26);
            this.lblRightTableName.TabIndex = 7;
            this.lblRightTableName.Text = "Name:";
            this.lblRightTableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTable.Location = new System.Drawing.Point(410, 3);
            this.btnSelectTable.Name = "btnSelectTable";
            this.tlpJoin.SetRowSpan(this.btnSelectTable, 2);
            this.btnSelectTable.Size = new System.Drawing.Size(75, 46);
            this.btnSelectTable.TabIndex = 1;
            this.btnSelectTable.Text = "Select Table";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // JoinForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(488, 330);
            this.Controls.Add(this.tlpJoin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Join Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JoinForm_FormClosing);
            this.tlpJoin.ResumeLayout(false);
            this.tlpJoin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJoinOns)).EndInit();
            this.tlpCommandButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpJoin;
        private System.Windows.Forms.TextBox txtRightTableName;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.Button btnAddJoinOn;
        private System.Windows.Forms.DataGridView dgJoinOns;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftFieldColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightFieldColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRightTableAlias;
        private System.Windows.Forms.TableLayoutPanel tlpCommandButton;
        private System.Windows.Forms.Label lblRightTableName;
    }
}