namespace QueryBuilder
{
    partial class FilterConfigTable
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
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnFilterCaption = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnAddFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFilterCaption, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddFilter.FlatAppearance.BorderSize = 0;
            this.btnAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilter.Location = new System.Drawing.Point(88, 8);
            this.btnAddFilter.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(36, 36);
            this.btnAddFilter.TabIndex = 6;
            this.btnAddFilter.Text = "+";
            this.btnAddFilter.UseVisualStyleBackColor = false;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnFilterCaption
            // 
            this.btnFilterCaption.Location = new System.Drawing.Point(5, 8);
            this.btnFilterCaption.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnFilterCaption.Name = "btnFilterCaption";
            this.btnFilterCaption.Size = new System.Drawing.Size(75, 36);
            this.btnFilterCaption.TabIndex = 4;
            this.btnFilterCaption.Text = "Filter";
            this.btnFilterCaption.UseVisualStyleBackColor = true;
            // 
            // FilterConfigTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterConfigTable";
            this.Size = new System.Drawing.Size(430, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFilterCaption;
        private System.Windows.Forms.Button btnAddFilter;
    }
}
