namespace QueryBuilder
{
    partial class JoinTableConfig
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
            this.btnJoinedTable = new System.Windows.Forms.Button();
            this.btnAddJoin = new System.Windows.Forms.Button();
            this.btnJoinCaption = new System.Windows.Forms.Button();
            this.btnAddAlias = new System.Windows.Forms.Button();
            this.lblAlias = new System.Windows.Forms.Label();
            this.btnRemoveJoin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnJoinedTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddJoin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnJoinCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAlias, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAlias, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveJoin, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnJoinedTable
            // 
            this.btnJoinedTable.AutoSize = true;
            this.btnJoinedTable.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnJoinedTable.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnJoinedTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinedTable.Location = new System.Drawing.Point(132, 15);
            this.btnJoinedTable.Margin = new System.Windows.Forms.Padding(5, 15, 3, 3);
            this.btnJoinedTable.Name = "btnJoinedTable";
            this.btnJoinedTable.Size = new System.Drawing.Size(12, 36);
            this.btnJoinedTable.TabIndex = 6;
            this.btnJoinedTable.UseVisualStyleBackColor = false;
            this.btnJoinedTable.Visible = false;
            // 
            // btnAddJoin
            // 
            this.btnAddJoin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddJoin.FlatAppearance.BorderSize = 0;
            this.btnAddJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJoin.Location = new System.Drawing.Point(88, 15);
            this.btnAddJoin.Margin = new System.Windows.Forms.Padding(5, 15, 3, 3);
            this.btnAddJoin.Name = "btnAddJoin";
            this.btnAddJoin.Size = new System.Drawing.Size(36, 36);
            this.btnAddJoin.TabIndex = 5;
            this.btnAddJoin.Text = "+";
            this.btnAddJoin.UseVisualStyleBackColor = false;
            this.btnAddJoin.Click += new System.EventHandler(this.btnAddJoin_Click);
            // 
            // btnJoinCaption
            // 
            this.btnJoinCaption.Location = new System.Drawing.Point(5, 15);
            this.btnJoinCaption.Margin = new System.Windows.Forms.Padding(5, 15, 3, 3);
            this.btnJoinCaption.Name = "btnJoinCaption";
            this.btnJoinCaption.Size = new System.Drawing.Size(75, 36);
            this.btnJoinCaption.TabIndex = 4;
            this.btnJoinCaption.Text = "Join";
            this.btnJoinCaption.UseVisualStyleBackColor = true;
            // 
            // btnAddAlias
            // 
            this.btnAddAlias.AutoSize = true;
            this.btnAddAlias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAlias.FlatAppearance.BorderSize = 0;
            this.btnAddAlias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlias.Location = new System.Drawing.Point(152, 19);
            this.btnAddAlias.Margin = new System.Windows.Forms.Padding(5, 19, 3, 3);
            this.btnAddAlias.Name = "btnAddAlias";
            this.btnAddAlias.Size = new System.Drawing.Size(29, 26);
            this.btnAddAlias.TabIndex = 7;
            this.btnAddAlias.Text = "As";
            this.btnAddAlias.UseVisualStyleBackColor = false;
            this.btnAddAlias.Visible = false;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAlias.Location = new System.Drawing.Point(187, 19);
            this.lblAlias.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAlias.Size = new System.Drawing.Size(10, 19);
            this.lblAlias.TabIndex = 8;
            this.lblAlias.Text = " ";
            this.lblAlias.Visible = false;
            // 
            // btnRemoveJoin
            // 
            this.btnRemoveJoin.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveJoin.FlatAppearance.BorderSize = 0;
            this.btnRemoveJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveJoin.Location = new System.Drawing.Point(404, 15);
            this.btnRemoveJoin.Margin = new System.Windows.Forms.Padding(5, 15, 3, 3);
            this.btnRemoveJoin.Name = "btnRemoveJoin";
            this.btnRemoveJoin.Size = new System.Drawing.Size(23, 36);
            this.btnRemoveJoin.TabIndex = 9;
            this.btnRemoveJoin.Text = "-";
            this.btnRemoveJoin.UseVisualStyleBackColor = false;
            this.btnRemoveJoin.Visible = false;
            this.btnRemoveJoin.Click += new System.EventHandler(this.btnRemoveJoin_Click);
            // 
            // JoinTableConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JoinTableConfig";
            this.Size = new System.Drawing.Size(430, 70);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnJoinCaption;
        private System.Windows.Forms.Button btnAddJoin;
        private System.Windows.Forms.Button btnJoinedTable;
        private System.Windows.Forms.Button btnAddAlias;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Button btnRemoveJoin;
    }
}
