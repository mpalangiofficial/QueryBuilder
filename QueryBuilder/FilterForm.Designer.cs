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
            this.SuspendLayout();
            // 
            // rootRuleGroupControl
            // 
            this.rootRuleGroupControl.AutoScroll = true;
            this.rootRuleGroupControl.AutoSize = true;
            this.rootRuleGroupControl.DbTables = null;
            this.rootRuleGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootRuleGroupControl.IsRootCondition = true;
            this.rootRuleGroupControl.Location = new System.Drawing.Point(0, 0);
            this.rootRuleGroupControl.Name = "rootRuleGroupControl";
            this.rootRuleGroupControl.OperationLogicalQuery = null;
            this.rootRuleGroupControl.RuleId = new System.Guid("840bf70b-cf50-43ee-9ec2-c29fd271ed78");
            this.rootRuleGroupControl.Size = new System.Drawing.Size(800, 450);
            this.rootRuleGroupControl.TabIndex = 0;
            this.rootRuleGroupControl.UsedTables = null;
            logicalWhere1.OperationLogical = OperationLogical.Or;
            logicalWhere1.RuleId = new System.Guid("00000000-0000-0000-0000-000000000000");
            logicalWhere1.WhereRules = null;
            this.rootRuleGroupControl.Where = logicalWhere1;
            this.rootRuleGroupControl.Changed += new System.EventHandler(this.rootRuleGroupControl_Changed);
            this.rootRuleGroupControl.Load += new System.EventHandler(this.rootRuleGroupControl_Load);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rootRuleGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filter Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RuleGroupControl rootRuleGroupControl;
    }
}