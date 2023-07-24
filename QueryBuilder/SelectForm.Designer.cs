namespace QueryBuilder
{
    partial class SelectForm
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
            this.tlpSelectForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblTables = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.btnAddField = new System.Windows.Forms.Button();
            this.dgFields = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tlpSelectForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFields)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSelectForm
            // 
            this.tlpSelectForm.ColumnCount = 5;
            this.tlpSelectForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSelectForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSelectForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSelectForm.Controls.Add(this.lblTables, 0, 0);
            this.tlpSelectForm.Controls.Add(this.cmbTables, 1, 0);
            this.tlpSelectForm.Controls.Add(this.lblFields, 0, 1);
            this.tlpSelectForm.Controls.Add(this.cmbFields, 1, 1);
            this.tlpSelectForm.Controls.Add(this.lblAs, 2, 1);
            this.tlpSelectForm.Controls.Add(this.txtAlias, 3, 1);
            this.tlpSelectForm.Controls.Add(this.btnAddField, 4, 1);
            this.tlpSelectForm.Controls.Add(this.dgFields, 0, 2);
            this.tlpSelectForm.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tlpSelectForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelectForm.Location = new System.Drawing.Point(0, 0);
            this.tlpSelectForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSelectForm.Name = "tlpSelectForm";
            this.tlpSelectForm.RowCount = 4;
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSelectForm.Size = new System.Drawing.Size(463, 450);
            this.tlpSelectForm.TabIndex = 0;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTables.Location = new System.Drawing.Point(3, 0);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(37, 27);
            this.lblTables.TabIndex = 0;
            this.lblTables.Text = "Table:";
            this.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTables
            // 
            this.cmbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectForm.SetColumnSpan(this.cmbTables, 4);
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(46, 3);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(414, 21);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFields.Location = new System.Drawing.Point(3, 27);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(37, 43);
            this.lblFields.TabIndex = 2;
            this.lblFields.Text = "SelectedFields:";
            this.lblFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFields
            // 
            this.cmbFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(46, 38);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(174, 21);
            this.cmbFields.TabIndex = 3;
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAs.Location = new System.Drawing.Point(226, 27);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(18, 43);
            this.lblAs.TabIndex = 4;
            this.lblAs.Text = "as";
            this.lblAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlias
            // 
            this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlias.Location = new System.Drawing.Point(250, 38);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(174, 20);
            this.txtAlias.TabIndex = 5;
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddField.Location = new System.Drawing.Point(430, 37);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(30, 30);
            this.btnAddField.TabIndex = 6;
            this.btnAddField.Text = "+";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // dgFields
            // 
            this.dgFields.AllowUserToAddRows = false;
            this.dgFields.AllowUserToDeleteRows = false;
            this.dgFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpSelectForm.SetColumnSpan(this.dgFields, 5);
            this.dgFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFields.Location = new System.Drawing.Point(3, 73);
            this.dgFields.Name = "dgFields";
            this.dgFields.ReadOnly = true;
            this.dgFields.Size = new System.Drawing.Size(457, 334);
            this.dgFields.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpSelectForm.SetColumnSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 413);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 34);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(348, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(404, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Apply";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SelectForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.tlpSelectForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select SelectedFields Form";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.tlpSelectForm.ResumeLayout(false);
            this.tlpSelectForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFields)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSelectForm;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.DataGridView dgFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}