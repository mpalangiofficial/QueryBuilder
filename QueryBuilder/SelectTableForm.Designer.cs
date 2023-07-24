namespace QueryBuilder
{
    partial class SelectTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgTables = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1, 1);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "closemenu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(1, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(451, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgTables
            // 
            this.dgTables.AllowUserToAddRows = false;
            this.dgTables.AllowUserToDeleteRows = false;
            this.dgTables.AllowUserToOrderColumns = true;
            this.dgTables.AllowUserToResizeColumns = false;
            this.dgTables.AllowUserToResizeRows = false;
            this.dgTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTables.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgTables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTables.ColumnHeadersVisible = false;
            this.dgTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelect,
            this.TableName});
            this.dgTables.Location = new System.Drawing.Point(0, 34);
            this.dgTables.MultiSelect = false;
            this.dgTables.Name = "dgTables";
            this.dgTables.ReadOnly = true;
            this.dgTables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgTables.RowHeadersVisible = false;
            this.dgTables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTables.Size = new System.Drawing.Size(455, 380);
            this.dgTables.TabIndex = 2;
            this.dgTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTables_CellContentClick);
            this.dgTables.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgTables_CellFormatting);
            // 
            // btnSelect
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSelect.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnSelect.HeaderText = "";
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ReadOnly = true;
            this.btnSelect.Text = "Select";
            this.btnSelect.Width = 20;
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "Name";
            this.TableName.HeaderText = "Table Name";
            this.TableName.MinimumWidth = 420;
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            this.TableName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TableName.Width = 420;
            // 
            // SelectTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(455, 414);
            this.Controls.Add(this.dgTables);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTableForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select table";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelectTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgTables;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
    }
}