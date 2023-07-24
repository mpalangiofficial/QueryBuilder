using System.Windows.Forms;

namespace QueryBuilder
{
    partial class FilterForm
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
            LogicalWhere logicalWhere1 = new LogicalWhere();
            this.rootRuleGroupControl = new RuleGroupControl();
            this.tlpFilterForm = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpFilterForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootRuleGroupControl
            // 
            this.rootRuleGroupControl.AutoScroll = true;
            this.rootRuleGroupControl.AutoSize = true;
            this.tlpFilterForm.SetColumnSpan(this.rootRuleGroupControl, 3);
            this.rootRuleGroupControl.DbTables = null;
            this.rootRuleGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootRuleGroupControl.IsRootCondition = true;
            this.rootRuleGroupControl.Location = new System.Drawing.Point(3, 3);
            this.rootRuleGroupControl.Name = "rootRuleGroupControl";
            this.rootRuleGroupControl.OperationLogicalQuery = null;
            this.rootRuleGroupControl.RuleId = new System.Guid("840bf70b-cf50-43ee-9ec2-c29fd271ed78");
            this.rootRuleGroupControl.Size = new System.Drawing.Size(632, 518);
            this.rootRuleGroupControl.TabIndex = 0;
            this.rootRuleGroupControl.UsedTables = null;
            logicalWhere1.OperationLogical = OperationLogical.Or;
            logicalWhere1.RuleId = new System.Guid("00000000-0000-0000-0000-000000000000");
            logicalWhere1.WhereRules = null;
            this.rootRuleGroupControl.Where = logicalWhere1;
            this.rootRuleGroupControl.Changed += new System.EventHandler(this.rootRuleGroupControl_Changed);
            this.rootRuleGroupControl.Load += new System.EventHandler(this.rootRuleGroupControl_Load);
            // 
            // tlpFilterForm
            // 
            this.tlpFilterForm.ColumnCount = 3;
            this.tlpFilterForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilterForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilterForm.Controls.Add(this.rootRuleGroupControl, 0, 0);
            this.tlpFilterForm.Controls.Add(this.btnOk, 2, 1);
            this.tlpFilterForm.Controls.Add(this.btnCancel, 1, 1);
            this.tlpFilterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilterForm.Location = new System.Drawing.Point(0, 0);
            this.tlpFilterForm.Name = "tlpFilterForm";
            this.tlpFilterForm.RowCount = 2;
            this.tlpFilterForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilterForm.Size = new System.Drawing.Size(638, 555);
            this.tlpFilterForm.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(575, 527);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 25);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Apply";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(509, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(638, 555);
            this.Controls.Add(this.tlpFilterForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filter Form";
            this.tlpFilterForm.ResumeLayout(false);
            this.tlpFilterForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RuleGroupControl rootRuleGroupControl;
        private System.Windows.Forms.TableLayoutPanel tlpFilterForm;
        private Button btnOk;
        private Button btnCancel;
    }
}