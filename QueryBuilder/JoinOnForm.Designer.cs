namespace QueryBuilder
{
    partial class JoinOnForm
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
            this.tlpJoinOn = new System.Windows.Forms.TableLayoutPanel();
            this.cmbLeftTables = new System.Windows.Forms.ComboBox();
            this.cmbLeftFields = new System.Windows.Forms.ComboBox();
            this.lblRightTable = new System.Windows.Forms.Label();
            this.cmbRightFields = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpJoinOn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpJoinOn
            // 
            this.tlpJoinOn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpJoinOn.ColumnCount = 2;
            this.tlpJoinOn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJoinOn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJoinOn.Controls.Add(this.cmbLeftTables, 0, 0);
            this.tlpJoinOn.Controls.Add(this.cmbLeftFields, 0, 1);
            this.tlpJoinOn.Controls.Add(this.lblRightTable, 1, 0);
            this.tlpJoinOn.Controls.Add(this.cmbRightFields, 1, 1);
            this.tlpJoinOn.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpJoinOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpJoinOn.Location = new System.Drawing.Point(0, 0);
            this.tlpJoinOn.Name = "tlpJoinOn";
            this.tlpJoinOn.RowCount = 3;
            this.tlpJoinOn.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpJoinOn.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpJoinOn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpJoinOn.Size = new System.Drawing.Size(412, 94);
            this.tlpJoinOn.TabIndex = 0;
            // 
            // cmbLeftTables
            // 
            this.cmbLeftTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLeftTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeftTables.FormattingEnabled = true;
            this.cmbLeftTables.Location = new System.Drawing.Point(3, 3);
            this.cmbLeftTables.Name = "cmbLeftTables";
            this.cmbLeftTables.Size = new System.Drawing.Size(200, 21);
            this.cmbLeftTables.TabIndex = 0;
            this.cmbLeftTables.SelectedIndexChanged += new System.EventHandler(this.cmbLeftTables_SelectedIndexChanged);
            // 
            // cmbLeftFields
            // 
            this.cmbLeftFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLeftFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeftFields.FormattingEnabled = true;
            this.cmbLeftFields.Location = new System.Drawing.Point(3, 30);
            this.cmbLeftFields.Name = "cmbLeftFields";
            this.cmbLeftFields.Size = new System.Drawing.Size(200, 21);
            this.cmbLeftFields.TabIndex = 1;
            // 
            // lblRightTable
            // 
            this.lblRightTable.AutoSize = true;
            this.lblRightTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRightTable.Location = new System.Drawing.Point(209, 0);
            this.lblRightTable.Name = "lblRightTable";
            this.lblRightTable.Size = new System.Drawing.Size(200, 27);
            this.lblRightTable.TabIndex = 2;
            // 
            // cmbRightFields
            // 
            this.cmbRightFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRightFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRightFields.FormattingEnabled = true;
            this.cmbRightFields.Location = new System.Drawing.Point(209, 30);
            this.cmbRightFields.Name = "cmbRightFields";
            this.cmbRightFields.Size = new System.Drawing.Size(200, 21);
            this.cmbRightFields.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpJoinOn.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 34);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(277, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(343, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // JoinOnForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(412, 94);
            this.Controls.Add(this.tlpJoinOn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinOnForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Join on";
            this.Load += new System.EventHandler(this.JoinOnForm_Load);
            this.tlpJoinOn.ResumeLayout(false);
            this.tlpJoinOn.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpJoinOn;
        private System.Windows.Forms.ComboBox cmbLeftTables;
        private System.Windows.Forms.ComboBox cmbLeftFields;
        private System.Windows.Forms.Label lblRightTable;
        private System.Windows.Forms.ComboBox cmbRightFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
