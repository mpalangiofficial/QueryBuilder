﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class RuleGroupControl : UserControl
    {
        public event EventHandler Changed;
        public event EventHandler Removed;
        public Guid RuleId { get; set; }
        public List<DbTableModel> DbTables { get; set; }
        public List<NameAlias> UsedTables { get; set; }

        private LogicalWhereExpression _whereExpression = new LogicalWhereExpression() { WhereRules = new List<BaseWhereExpression>(), OperationLogical = OperationLogical.And };
        public LogicalWhereExpression WhereExpression
        {
            get => _whereExpression;
            set
            {
                _whereExpression = value is null
                    ? new LogicalWhereExpression() { WhereRules = new List<BaseWhereExpression>(), OperationLogical = OperationLogical.And }
                    : value;
               }
        }

        public void LoadRules()
        {
            this.OperationLogicalQuery = _whereExpression.OperationLogical;
            _whereExpression?.WhereRules?.ForEach(wr =>
            {
                if (wr is SimpleWhereExpression)
                {
                    var rowStyle = new RowStyle(SizeType.Absolute, 50F);
                    var cnt = tlpRules.RowStyles.Count;
                    tlpRules.RowStyles.Insert(cnt - 1, rowStyle);

                    RuleControl ruleControl = new RuleControl(wr as SimpleWhereExpression);
                    ruleControl.UsedTables = this.UsedTables;
                    ruleControl.DbTables = this.DbTables;
                    ruleControl.Removed += new EventHandler(rule_removed);
                    ruleControl.Changed += new EventHandler(rule_changed);

                    tlpRules.Controls.Add(ruleControl, 0, cnt - 1);
                    ruleControl.Dock = DockStyle.Top;
                }
                else if (wr is LogicalWhereExpression)
                {

                }
            });

            MessageBox.Show("load rules");
        }

        public bool IsRootCondition { get; set; } = false;

        private OperationLogical? _operationLogical;

        public OperationLogical? OperationLogicalQuery
        {
            get => _operationLogical;
            set
            {
                _operationLogical = value;
                btnAnd.BackColor = btnOr.BackColor = Color.RoyalBlue;
                switch (value)
                {
                    case OperationLogical.And:
                        btnAnd.BackColor = Color.MidnightBlue;
                        this.WhereExpression.OperationLogical = OperationLogical.And;
                        break;
                    case OperationLogical.Or:
                        btnOr.BackColor = Color.MidnightBlue;
                        this.WhereExpression.OperationLogical = OperationLogical.Or;
                        break;
                }
            }
        }

        public RuleGroupControl()
        {
            InitializeComponent();

            OperationLogicalQuery = OperationLogical.And;
            RuleId = Guid.NewGuid();
        }

        public RuleGroupControl(LogicalWhereExpression whereExpression)
        {

        }
        private void btnAnd_Click(object sender, EventArgs e)
        {
            this.OperationLogicalQuery = OperationLogical.And;
        }
        private void btnOr_Click(object sender, EventArgs e)
        {
            this.OperationLogicalQuery = OperationLogical.Or;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, e);
        }

        private void RuleGroupControl_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = !IsRootCondition;
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            var rowStyle = new RowStyle(SizeType.Absolute, 50F);
            var cnt = tlpRules.RowStyles.Count;
            tlpRules.RowStyles.Insert(cnt - 1, rowStyle);

            RuleControl ruleControl = new RuleControl();
            ruleControl.UsedTables = this.UsedTables;
            ruleControl.DbTables = this.DbTables;
            ruleControl.Removed += new EventHandler(rule_removed);
            ruleControl.Changed += new EventHandler(rule_changed);

            tlpRules.Controls.Add(ruleControl, 0, cnt - 1);
            ruleControl.Dock = DockStyle.Top;
        }

        private void btnAddRuleGroup_Click(object sender, EventArgs e)
        {
            var rowStyle = new RowStyle(SizeType.Percent, 100F);
            var cnt = tlpRules.RowStyles.Count;
            tlpRules.RowStyles.Insert(cnt - 1, rowStyle);
            RuleGroupControl ruleGroupControl = new RuleGroupControl();
            ruleGroupControl.UsedTables = this.UsedTables;
            ruleGroupControl.DbTables = this.DbTables;
            ruleGroupControl.Removed += new EventHandler(ruleGroup_removed);
            ruleGroupControl.Changed += new EventHandler(ruleGroup_changed);
            tlpRules.Controls.Add(ruleGroupControl, 0, cnt - 1);
            ruleGroupControl.Dock = DockStyle.Fill;
        }

        private void rule_removed(object sender, EventArgs e)
        {
            RuleControl ruleControl = (RuleControl)sender;
            MessageBox.Show("Remove rule");
        }

        private void rule_changed(object sender, EventArgs e)
        {
            RuleControl ruleControl = (RuleControl)sender;
            if (WhereExpression?.WhereRules == null)
            {
                WhereExpression.WhereRules = new List<BaseWhereExpression>();
                this.WhereExpression.WhereRules.Add(ruleControl.WhereExpression);
            }
            else
            {
                var rule = WhereExpression.WhereRules.FirstOrDefault(w => w.RuleId == ruleControl.WhereExpression.RuleId);
                if (rule != null)
                {
                    this.WhereExpression.WhereRules.Remove(rule);
                }
                this.WhereExpression.WhereRules.Add(ruleControl.WhereExpression);
                if (this.WhereExpression.WhereRules.Count > 1 && this.OperationLogicalQuery is null)
                    this.OperationLogicalQuery = OperationLogical.And;
            }
            this.Changed?.Invoke(this, EventArgs.Empty);
        }
        private void ruleGroup_removed(object sender, EventArgs e)
        {
            RuleGroupControl ruleGroupControl = (RuleGroupControl)sender;
            if (WhereExpression?.WhereRules == null) WhereExpression.WhereRules = new List<BaseWhereExpression>();
            this.WhereExpression.WhereRules.Add(ruleGroupControl.WhereExpression);
            MessageBox.Show("Remove rule group");
        }

        private void ruleGroup_changed(object sender, EventArgs e)
        {
            RuleGroupControl ruleGroupControl = (RuleGroupControl)sender;
            if (WhereExpression?.WhereRules == null)
            {
                WhereExpression.WhereRules = new List<BaseWhereExpression>();
                this.WhereExpression.WhereRules.Add(ruleGroupControl.WhereExpression);
            }
            else
            {
                var rule = WhereExpression.WhereRules.FirstOrDefault(w => w.RuleId == ruleGroupControl.WhereExpression.RuleId);
                if (rule != null)
                    this.WhereExpression.WhereRules.Remove(rule);
                this.WhereExpression.WhereRules.Add(ruleGroupControl.WhereExpression);
            }
            this.Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}
