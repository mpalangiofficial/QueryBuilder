namespace QueryBuilder
{
    partial class RuleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpRule = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtExpectedValue = new System.Windows.Forms.TextBox();
            this.cmbOperations = new System.Windows.Forms.ComboBox();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tlpRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tlpRule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 34);
            this.panel1.TabIndex = 0;
            // 
            // tlpRule
            // 
            this.tlpRule.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpRule.ColumnCount = 5;
            this.tlpRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRule.Controls.Add(this.btnDelete, 4, 0);
            this.tlpRule.Controls.Add(this.txtExpectedValue, 3, 0);
            this.tlpRule.Controls.Add(this.cmbOperations, 2, 0);
            this.tlpRule.Controls.Add(this.cmbTables, 0, 0);
            this.tlpRule.Controls.Add(this.cmbFields, 1, 0);
            this.tlpRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRule.Location = new System.Drawing.Point(0, 0);
            this.tlpRule.Name = "tlpRule";
            this.tlpRule.RowCount = 1;
            this.tlpRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRule.Size = new System.Drawing.Size(513, 32);
            this.tlpRule.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(484, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 25);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtExpectedValue
            // 
            this.txtExpectedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpectedValue.Location = new System.Drawing.Point(375, 6);
            this.txtExpectedValue.Name = "txtExpectedValue";
            this.txtExpectedValue.Size = new System.Drawing.Size(100, 20);
            this.txtExpectedValue.TabIndex = 2;
            this.txtExpectedValue.TextChanged += new System.EventHandler(this.txtExpectedValue_TextChanged);
            // 
            // cmbOperations
            // 
            this.cmbOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOperations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbOperations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Location = new System.Drawing.Point(251, 5);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.Size = new System.Drawing.Size(118, 21);
            this.cmbOperations.TabIndex = 1;
            this.cmbOperations.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbTables_DrawItem);
            this.cmbOperations.SelectedIndexChanged += new System.EventHandler(this.cmbOperations_SelectedIndexChanged);
            // 
            // cmbTables
            // 
            this.cmbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbTables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(3, 5);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(118, 21);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbTables_DrawItem);
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // cmbFields
            // 
            this.cmbFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbFields.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(127, 5);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(118, 21);
            this.cmbFields.TabIndex = 1;
            this.cmbFields.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbTables_DrawItem);
            this.cmbFields.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            // 
            // RuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "RuleControl";
            this.Size = new System.Drawing.Size(515, 34);
            this.Load += new System.EventHandler(this.RuleControl_Load);
            this.panel1.ResumeLayout(false);
            this.tlpRule.ResumeLayout(false);
            this.tlpRule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpRule;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.ComboBox cmbOperations;
        private System.Windows.Forms.TextBox txtExpectedValue;
        private System.Windows.Forms.ComboBox cmbFields;
    }
}
