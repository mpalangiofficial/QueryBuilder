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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinTableConfig));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnJoinedTable = new System.Windows.Forms.Button();
            this.btnAddJoin = new System.Windows.Forms.Button();
            this.btnJoinCaption = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveJoin, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnJoinedTable
            // 
            this.btnJoinedTable.AutoSize = true;
            this.btnJoinedTable.BackColor = System.Drawing.Color.LightBlue;
            this.btnJoinedTable.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnJoinedTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinedTable.Location = new System.Drawing.Point(132, 8);
            this.btnJoinedTable.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
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
            this.btnAddJoin.Location = new System.Drawing.Point(88, 8);
            this.btnAddJoin.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnAddJoin.Name = "btnAddJoin";
            this.btnAddJoin.Size = new System.Drawing.Size(36, 36);
            this.btnAddJoin.TabIndex = 5;
            this.btnAddJoin.Text = "+";
            this.btnAddJoin.UseVisualStyleBackColor = false;
            this.btnAddJoin.Click += new System.EventHandler(this.btnAddJoin_Click);
            // 
            // btnJoinCaption
            // 
            this.btnJoinCaption.Location = new System.Drawing.Point(5, 8);
            this.btnJoinCaption.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnJoinCaption.Name = "btnJoinCaption";
            this.btnJoinCaption.Size = new System.Drawing.Size(75, 36);
            this.btnJoinCaption.TabIndex = 4;
            this.btnJoinCaption.Text = "Join";
            this.btnJoinCaption.UseVisualStyleBackColor = true;
            // 
            // btnRemoveJoin
            // 
            this.btnRemoveJoin.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveJoin.FlatAppearance.BorderSize = 0;
            this.btnRemoveJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveJoin.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveJoin.Image")));
            this.btnRemoveJoin.Location = new System.Drawing.Point(404, 8);
            this.btnRemoveJoin.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnRemoveJoin.Name = "btnRemoveJoin";
            this.btnRemoveJoin.Size = new System.Drawing.Size(23, 36);
            this.btnRemoveJoin.TabIndex = 9;
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
            this.Size = new System.Drawing.Size(430, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnJoinCaption;
        private System.Windows.Forms.Button btnAddJoin;
        private System.Windows.Forms.Button btnJoinedTable;
        private System.Windows.Forms.Button btnRemoveJoin;
    }
}
