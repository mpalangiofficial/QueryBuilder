namespace QueryBuilder
{
    partial class StartTableConfig
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.btnStartTable = new System.Windows.Forms.Button();
            this.btnSelectedTable = new System.Windows.Forms.Button();
            this.btnAddAlias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelectTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartTable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectedTable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAlias, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAlias, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Location = new System.Drawing.Point(5, 8);
            this.btnSelectTable.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(75, 36);
            this.btnSelectTable.TabIndex = 1;
            this.btnSelectTable.Text = "Start Table";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            // 
            // btnStartTable
            // 
            this.btnStartTable.BackColor = System.Drawing.Color.Transparent;
            this.btnStartTable.FlatAppearance.BorderSize = 0;
            this.btnStartTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTable.Location = new System.Drawing.Point(88, 8);
            this.btnStartTable.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnStartTable.Name = "btnStartTable";
            this.btnStartTable.Size = new System.Drawing.Size(23, 36);
            this.btnStartTable.TabIndex = 1;
            this.btnStartTable.Text = "+";
            this.btnStartTable.UseVisualStyleBackColor = false;
            this.btnStartTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // btnSelectedTable
            // 
            this.btnSelectedTable.AutoSize = true;
            this.btnSelectedTable.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSelectedTable.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSelectedTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedTable.Location = new System.Drawing.Point(119, 8);
            this.btnSelectedTable.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnSelectedTable.Name = "btnSelectedTable";
            this.btnSelectedTable.Size = new System.Drawing.Size(12, 36);
            this.btnSelectedTable.TabIndex = 1;
            this.btnSelectedTable.UseVisualStyleBackColor = false;
            this.btnSelectedTable.Visible = false;
            this.btnSelectedTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // btnAddAlias
            // 
            this.btnAddAlias.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAlias.FlatAppearance.BorderSize = 0;
            this.btnAddAlias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlias.Location = new System.Drawing.Point(134, 12);
            this.btnAddAlias.Margin = new System.Windows.Forms.Padding(0, 12, 0, 3);
            this.btnAddAlias.Name = "btnAddAlias";
            this.btnAddAlias.Size = new System.Drawing.Size(26, 26);
            this.btnAddAlias.TabIndex = 1;
            this.btnAddAlias.Text = "as";
            this.btnAddAlias.UseVisualStyleBackColor = false;
            this.btnAddAlias.Visible = false;
            this.btnAddAlias.Click += new System.EventHandler(this.btnAddAlias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(179, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(10, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = " ";
            this.label1.Visible = false;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAlias.Location = new System.Drawing.Point(163, 19);
            this.lblAlias.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAlias.Size = new System.Drawing.Size(10, 19);
            this.lblAlias.TabIndex = 2;
            this.lblAlias.Text = " ";
            this.lblAlias.Visible = false;
            // 
            // StartTableConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StartTableConfig";
            this.Size = new System.Drawing.Size(426, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.Button btnStartTable;
        private System.Windows.Forms.Button btnSelectedTable;
        private System.Windows.Forms.Button btnAddAlias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlias;
    }
}
