using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace QueryBuilder
{
    partial class RuleGroupControl
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
            this.tlpRuleGroup = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.tlpCommandButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRuleGroup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.tlpRules = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpRuleGroup.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.tlpCommandButtons.SuspendLayout();
            this.pnlRules.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRuleGroup
            // 
            this.tlpRuleGroup.AutoSize = true;
            this.tlpRuleGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpRuleGroup.ColumnCount = 5;
            this.tlpRuleGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRuleGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRuleGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRuleGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRuleGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRuleGroup.Controls.Add(this.pnlOperations, 0, 0);
            this.tlpRuleGroup.Controls.Add(this.tlpCommandButtons, 2, 0);
            this.tlpRuleGroup.Controls.Add(this.pnlRules, 0, 1);
            this.tlpRuleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRuleGroup.Location = new System.Drawing.Point(0, 0);
            this.tlpRuleGroup.Name = "tlpRuleGroup";
            this.tlpRuleGroup.RowCount = 2;
            this.tlpRuleGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRuleGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRuleGroup.Size = new System.Drawing.Size(511, 98);
            this.tlpRuleGroup.TabIndex = 0;
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.btnOr);
            this.pnlOperations.Controls.Add(this.btnAnd);
            this.pnlOperations.Location = new System.Drawing.Point(3, 3);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(65, 28);
            this.pnlOperations.TabIndex = 2;
            // 
            // btnOr
            // 
            this.btnOr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOr.Location = new System.Drawing.Point(34, 3);
            this.btnOr.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(27, 23);
            this.btnOr.TabIndex = 1;
            this.btnOr.Text = "Or";
            this.btnOr.UseVisualStyleBackColor = false;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAnd.Location = new System.Drawing.Point(3, 3);
            this.btnAnd.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(35, 23);
            this.btnAnd.TabIndex = 1;
            this.btnAnd.Text = "and";
            this.btnAnd.UseVisualStyleBackColor = false;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // tlpCommandButtons
            // 
            this.tlpCommandButtons.ColumnCount = 4;
            this.tlpRuleGroup.SetColumnSpan(this.tlpCommandButtons, 3);
            this.tlpCommandButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommandButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCommandButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCommandButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCommandButtons.Controls.Add(this.btnAddRuleGroup, 2, 0);
            this.tlpCommandButtons.Controls.Add(this.btnDelete, 3, 0);
            this.tlpCommandButtons.Controls.Add(this.btnAddRule, 1, 0);
            this.tlpCommandButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommandButtons.Location = new System.Drawing.Point(207, 3);
            this.tlpCommandButtons.Name = "tlpCommandButtons";
            this.tlpCommandButtons.RowCount = 1;
            this.tlpCommandButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommandButtons.Size = new System.Drawing.Size(301, 30);
            this.tlpCommandButtons.TabIndex = 3;
            // 
            // btnAddRuleGroup
            // 
            this.btnAddRuleGroup.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddRuleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRuleGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRuleGroup.Location = new System.Drawing.Point(157, 3);
            this.btnAddRuleGroup.Name = "btnAddRuleGroup";
            this.btnAddRuleGroup.Size = new System.Drawing.Size(85, 24);
            this.btnAddRuleGroup.TabIndex = 1;
            this.btnAddRuleGroup.Text = "Add rule group";
            this.btnAddRuleGroup.UseVisualStyleBackColor = false;
            this.btnAddRuleGroup.Click += new System.EventHandler(this.btnAddRuleGroup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(248, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRule.Location = new System.Drawing.Point(97, 3);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(54, 24);
            this.btnAddRule.TabIndex = 0;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // pnlRules
            // 
            this.pnlRules.AutoSize = true;
            this.pnlRules.BackColor = System.Drawing.Color.Bisque;
            this.pnlRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpRuleGroup.SetColumnSpan(this.pnlRules, 5);
            this.pnlRules.Controls.Add(this.tlpRules);
            this.pnlRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRules.Location = new System.Drawing.Point(16, 39);
            this.pnlRules.Margin = new System.Windows.Forms.Padding(16, 3, 3, 5);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(492, 54);
            this.pnlRules.TabIndex = 4;
            // 
            // tlpRules
            // 
            this.tlpRules.AutoScroll = true;
            this.tlpRules.AutoSize = true;
            this.tlpRules.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpRules.ColumnCount = 1;
            this.tlpRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRules.Location = new System.Drawing.Point(0, 0);
            this.tlpRules.Name = "tlpRules";
            this.tlpRules.RowCount = 1;
            this.tlpRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRules.Size = new System.Drawing.Size(490, 52);
            this.tlpRules.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tlpRuleGroup);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(513, 100);
            this.pnlMain.TabIndex = 1;
            // 
            // RuleGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.pnlMain);
            this.Name = "RuleGroupControl";
            this.Size = new System.Drawing.Size(513, 100);
            this.Load += new System.EventHandler(this.RuleGroupControl_Load);
            this.tlpRuleGroup.ResumeLayout(false);
            this.tlpRuleGroup.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.tlpCommandButtons.ResumeLayout(false);
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRuleGroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.TableLayoutPanel tlpCommandButtons;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAddRuleGroup;
        private Panel pnlRules;
        private TableLayoutPanel tlpRules;
    }
}
