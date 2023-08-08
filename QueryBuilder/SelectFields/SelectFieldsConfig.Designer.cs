namespace QueryBuilder
{
    partial class SelectFieldsConfig
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
            this.tlpSelectFields = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.btnSelectCaption = new System.Windows.Forms.Button();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.tlpSelectFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSelectFields
            // 
            this.tlpSelectFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpSelectFields.ColumnCount = 3;
            this.tlpSelectFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectFields.Controls.Add(this.btnAddSelect, 0, 0);
            this.tlpSelectFields.Controls.Add(this.btnSelectCaption, 0, 0);
            this.tlpSelectFields.Controls.Add(this.txtFields, 2, 0);
            this.tlpSelectFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelectFields.Location = new System.Drawing.Point(0, 0);
            this.tlpSelectFields.Name = "tlpSelectFields";
            this.tlpSelectFields.RowCount = 1;
            this.tlpSelectFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectFields.Size = new System.Drawing.Size(426, 55);
            this.tlpSelectFields.TabIndex = 1;
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddSelect.FlatAppearance.BorderSize = 0;
            this.btnAddSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelect.Location = new System.Drawing.Point(88, 8);
            this.btnAddSelect.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(36, 36);
            this.btnAddSelect.TabIndex = 5;
            this.btnAddSelect.Text = "+";
            this.btnAddSelect.UseVisualStyleBackColor = false;
            this.btnAddSelect.Click += new System.EventHandler(this.btnAddSelect_Click);
            // 
            // btnSelectCaption
            // 
            this.btnSelectCaption.Location = new System.Drawing.Point(5, 8);
            this.btnSelectCaption.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.btnSelectCaption.Name = "btnSelectCaption";
            this.btnSelectCaption.Size = new System.Drawing.Size(75, 36);
            this.btnSelectCaption.TabIndex = 4;
            this.btnSelectCaption.Text = "Fields";
            this.btnSelectCaption.UseVisualStyleBackColor = true;
            // 
            // txtFields
            // 
            this.txtFields.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFields.Location = new System.Drawing.Point(130, 3);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.ReadOnly = true;
            this.txtFields.Size = new System.Drawing.Size(293, 49);
            this.txtFields.TabIndex = 6;
            // 
            // SelectConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSelectFields);
            this.Name = "SelectFieldsConfig";
            this.Size = new System.Drawing.Size(426, 55);
            this.tlpSelectFields.ResumeLayout(false);
            this.tlpSelectFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSelectFields;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.Button btnSelectCaption;
        private System.Windows.Forms.TextBox txtFields;
    }
}
