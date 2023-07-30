namespace QueryBuilder
{
    partial class SortConfig
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
            this.btnSortCaption = new System.Windows.Forms.Button();
            this.tlpSelectFields = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSort = new System.Windows.Forms.Button();
            this.txtSortFields = new System.Windows.Forms.TextBox();
            this.tlpSelectFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSortCaption
            // 
            this.btnSortCaption.Location = new System.Drawing.Point(5, 8);
            this.btnSortCaption.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnSortCaption.Name = "btnSortCaption";
            this.btnSortCaption.Size = new System.Drawing.Size(75, 36);
            this.btnSortCaption.TabIndex = 4;
            this.btnSortCaption.Text = "Sort";
            this.btnSortCaption.UseVisualStyleBackColor = true;
            // 
            // tlpSelectFields
            // 
            this.tlpSelectFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpSelectFields.ColumnCount = 3;
            this.tlpSelectFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectFields.Controls.Add(this.btnAddSort, 0, 0);
            this.tlpSelectFields.Controls.Add(this.btnSortCaption, 0, 0);
            this.tlpSelectFields.Controls.Add(this.txtSortFields, 2, 0);
            this.tlpSelectFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelectFields.Location = new System.Drawing.Point(0, 0);
            this.tlpSelectFields.Name = "tlpSelectFields";
            this.tlpSelectFields.RowCount = 1;
            this.tlpSelectFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectFields.Size = new System.Drawing.Size(350, 55);
            this.tlpSelectFields.TabIndex = 2;
            // 
            // btnAddSort
            // 
            this.btnAddSort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddSort.Enabled = false;
            this.btnAddSort.FlatAppearance.BorderSize = 0;
            this.btnAddSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSort.Location = new System.Drawing.Point(88, 8);
            this.btnAddSort.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnAddSort.Name = "btnAddSort";
            this.btnAddSort.Size = new System.Drawing.Size(36, 36);
            this.btnAddSort.TabIndex = 5;
            this.btnAddSort.Text = "+";
            this.btnAddSort.UseVisualStyleBackColor = false;
            this.btnAddSort.Click += new System.EventHandler(this.btnAddSort_Click);
            // 
            // txtSortFields
            // 
            this.txtSortFields.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSortFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSortFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSortFields.Location = new System.Drawing.Point(130, 3);
            this.txtSortFields.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtSortFields.Multiline = true;
            this.txtSortFields.Name = "txtSortFields";
            this.txtSortFields.ReadOnly = true;
            this.txtSortFields.Size = new System.Drawing.Size(210, 49);
            this.txtSortFields.TabIndex = 6;
            // 
            // SortConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSelectFields);
            this.Name = "SortConfig";
            this.Size = new System.Drawing.Size(350, 55);
            this.tlpSelectFields.ResumeLayout(false);
            this.tlpSelectFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortCaption;
        private System.Windows.Forms.TableLayoutPanel tlpSelectFields;
        private System.Windows.Forms.Button btnAddSort;
        private System.Windows.Forms.TextBox txtSortFields;
    }
}
