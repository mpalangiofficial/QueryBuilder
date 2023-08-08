namespace QueryBuilder
{
    partial class SelectFieldsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFieldsForm));
            this.tlpSelectForm = new System.Windows.Forms.TableLayoutPanel();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.btnAddField = new System.Windows.Forms.Button();
            this.dgFields = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkUsedFunction = new System.Windows.Forms.CheckBox();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.chkFormula = new System.Windows.Forms.CheckBox();
            this.cmbOperators = new System.Windows.Forms.ComboBox();
            this.cmbFormulaTables = new System.Windows.Forms.ComboBox();
            this.cmbFormulaFields = new System.Windows.Forms.ComboBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.chkUseOtherField = new System.Windows.Forms.CheckBox();
            this.cmbOtherField = new System.Windows.Forms.ComboBox();
            this.chkIsTempField = new System.Windows.Forms.CheckBox();
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
            this.tlpSelectForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpSelectForm.Controls.Add(this.cmbTables, 1, 0);
            this.tlpSelectForm.Controls.Add(this.lblFields, 0, 0);
            this.tlpSelectForm.Controls.Add(this.cmbFields, 3, 0);
            this.tlpSelectForm.Controls.Add(this.lblAs, 0, 4);
            this.tlpSelectForm.Controls.Add(this.btnAddField, 4, 3);
            this.tlpSelectForm.Controls.Add(this.dgFields, 0, 5);
            this.tlpSelectForm.Controls.Add(this.tableLayoutPanel1, 0, 6);
            this.tlpSelectForm.Controls.Add(this.chkUsedFunction, 0, 3);
            this.tlpSelectForm.Controls.Add(this.cmbFunction, 1, 3);
            this.tlpSelectForm.Controls.Add(this.chkFormula, 0, 1);
            this.tlpSelectForm.Controls.Add(this.cmbOperators, 4, 0);
            this.tlpSelectForm.Controls.Add(this.cmbFormulaTables, 1, 1);
            this.tlpSelectForm.Controls.Add(this.cmbFormulaFields, 3, 1);
            this.tlpSelectForm.Controls.Add(this.txtAlias, 1, 4);
            this.tlpSelectForm.Controls.Add(this.chkUseOtherField, 1, 2);
            this.tlpSelectForm.Controls.Add(this.cmbOtherField, 2, 2);
            this.tlpSelectForm.Controls.Add(this.chkIsTempField, 3, 4);
            this.tlpSelectForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelectForm.Location = new System.Drawing.Point(0, 0);
            this.tlpSelectForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSelectForm.Name = "tlpSelectForm";
            this.tlpSelectForm.RowCount = 7;
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSelectForm.Size = new System.Drawing.Size(463, 450);
            this.tlpSelectForm.TabIndex = 0;
            // 
            // cmbTables
            // 
            this.cmbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectForm.SetColumnSpan(this.cmbTables, 2);
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(94, 6);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(205, 21);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFields.Location = new System.Drawing.Point(3, 0);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(85, 34);
            this.lblFields.TabIndex = 2;
            this.lblFields.Text = "Fields:";
            this.lblFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFields
            // 
            this.cmbFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(305, 6);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(112, 21);
            this.cmbFields.TabIndex = 3;
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAs.Location = new System.Drawing.Point(3, 115);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(85, 26);
            this.lblAs.TabIndex = 4;
            this.lblAs.Text = "Alias:";
            this.lblAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddField.Location = new System.Drawing.Point(423, 108);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(3, 10, 6, 3);
            this.btnAddField.Name = "btnAddField";
            this.tlpSelectForm.SetRowSpan(this.btnAddField, 2);
            this.btnAddField.Size = new System.Drawing.Size(34, 30);
            this.btnAddField.TabIndex = 6;
            this.btnAddField.Text = "+";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // dgFields
            // 
            this.dgFields.AllowUserToAddRows = false;
            this.dgFields.AllowUserToDeleteRows = false;
            this.dgFields.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFields.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Alias,
            this.remove});
            this.tlpSelectForm.SetColumnSpan(this.dgFields, 5);
            this.dgFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgFields.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgFields.Location = new System.Drawing.Point(3, 144);
            this.dgFields.MultiSelect = false;
            this.dgFields.Name = "dgFields";
            this.dgFields.ReadOnly = true;
            this.dgFields.RowHeadersVisible = false;
            this.dgFields.Size = new System.Drawing.Size(457, 263);
            this.dgFields.TabIndex = 7;
            this.dgFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFields_CellContentClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.Frozen = true;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 100;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 250;
            // 
            // Alias
            // 
            this.Alias.DataPropertyName = "Alias";
            this.Alias.Frozen = true;
            this.Alias.HeaderText = "alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            this.Alias.Width = 150;
            // 
            // remove
            // 
            this.remove.Frozen = true;
            this.remove.HeaderText = "";
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Width = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpSelectForm.SetColumnSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(404, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(348, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Apply";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkUsedFunction
            // 
            this.chkUsedFunction.AutoSize = true;
            this.chkUsedFunction.Location = new System.Drawing.Point(3, 91);
            this.chkUsedFunction.Name = "chkUsedFunction";
            this.chkUsedFunction.Size = new System.Drawing.Size(84, 17);
            this.chkUsedFunction.TabIndex = 9;
            this.chkUsedFunction.Text = "use function";
            this.chkUsedFunction.UseVisualStyleBackColor = true;
            this.chkUsedFunction.CheckedChanged += new System.EventHandler(this.chkUsedFunction_CheckedChanged);
            // 
            // cmbFunction
            // 
            this.tlpSelectForm.SetColumnSpan(this.cmbFunction, 2);
            this.cmbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.Location = new System.Drawing.Point(94, 91);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(118, 21);
            this.cmbFunction.TabIndex = 10;
            this.cmbFunction.Visible = false;
            // 
            // chkFormula
            // 
            this.chkFormula.AutoSize = true;
            this.chkFormula.Location = new System.Drawing.Point(3, 37);
            this.chkFormula.Name = "chkFormula";
            this.chkFormula.Size = new System.Drawing.Size(85, 17);
            this.chkFormula.TabIndex = 9;
            this.chkFormula.Text = "Add Formula";
            this.chkFormula.UseVisualStyleBackColor = true;
            this.chkFormula.CheckedChanged += new System.EventHandler(this.chkFormula_CheckedChanged);
            // 
            // cmbOperators
            // 
            this.cmbOperators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperators.Location = new System.Drawing.Point(423, 3);
            this.cmbOperators.Name = "cmbOperators";
            this.cmbOperators.Size = new System.Drawing.Size(37, 28);
            this.cmbOperators.TabIndex = 0;
            // 
            // cmbFormulaTables
            // 
            this.cmbFormulaTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectForm.SetColumnSpan(this.cmbFormulaTables, 2);
            this.cmbFormulaTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormulaTables.FormattingEnabled = true;
            this.cmbFormulaTables.Location = new System.Drawing.Point(94, 37);
            this.cmbFormulaTables.Name = "cmbFormulaTables";
            this.cmbFormulaTables.Size = new System.Drawing.Size(205, 21);
            this.cmbFormulaTables.TabIndex = 1;
            this.cmbFormulaTables.SelectedIndexChanged += new System.EventHandler(this.cmbFormulaTables_SelectedIndexChanged);
            // 
            // cmbFormulaFields
            // 
            this.cmbFormulaFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormulaFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormulaFields.FormattingEnabled = true;
            this.cmbFormulaFields.Location = new System.Drawing.Point(305, 37);
            this.cmbFormulaFields.Name = "cmbFormulaFields";
            this.cmbFormulaFields.Size = new System.Drawing.Size(112, 21);
            this.cmbFormulaFields.TabIndex = 3;
            // 
            // txtAlias
            // 
            this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectForm.SetColumnSpan(this.txtAlias, 2);
            this.txtAlias.Location = new System.Drawing.Point(94, 118);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(205, 20);
            this.txtAlias.TabIndex = 5;
            // 
            // chkUseOtherField
            // 
            this.chkUseOtherField.AutoSize = true;
            this.chkUseOtherField.Location = new System.Drawing.Point(94, 64);
            this.chkUseOtherField.Name = "chkUseOtherField";
            this.chkUseOtherField.Size = new System.Drawing.Size(100, 17);
            this.chkUseOtherField.TabIndex = 9;
            this.chkUseOtherField.Text = "Used other field";
            this.chkUseOtherField.UseVisualStyleBackColor = true;
            this.chkUseOtherField.Visible = false;
            this.chkUseOtherField.CheckedChanged += new System.EventHandler(this.chkUseOtherField_CheckedChanged);
            // 
            // cmbOtherField
            // 
            this.cmbOtherField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectForm.SetColumnSpan(this.cmbOtherField, 2);
            this.cmbOtherField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtherField.FormattingEnabled = true;
            this.cmbOtherField.Location = new System.Drawing.Point(212, 64);
            this.cmbOtherField.Name = "cmbOtherField";
            this.cmbOtherField.Size = new System.Drawing.Size(205, 21);
            this.cmbOtherField.TabIndex = 11;
            this.cmbOtherField.Visible = false;
            // 
            // chkIsTempField
            // 
            this.chkIsTempField.AutoSize = true;
            this.chkIsTempField.Location = new System.Drawing.Point(305, 118);
            this.chkIsTempField.Name = "chkIsTempField";
            this.chkIsTempField.Size = new System.Drawing.Size(89, 17);
            this.chkIsTempField.TabIndex = 9;
            this.chkIsTempField.Text = "Is Temp Field";
            this.chkIsTempField.UseVisualStyleBackColor = true;
            this.chkIsTempField.CheckedChanged += new System.EventHandler(this.chkUsedFunction_CheckedChanged);
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
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select Fields Form";
            this.tlpSelectForm.ResumeLayout(false);
            this.tlpSelectForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFields)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSelectForm;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.DataGridView dgFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkUsedFunction;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.CheckBox chkFormula;
        private System.Windows.Forms.ComboBox cmbOperators;
        private System.Windows.Forms.ComboBox cmbFormulaTables;
        private System.Windows.Forms.ComboBox cmbFormulaFields;
        private System.Windows.Forms.CheckBox chkUseOtherField;
        private System.Windows.Forms.ComboBox cmbOtherField;
        private System.Windows.Forms.CheckBox chkIsTempField;
    }
}