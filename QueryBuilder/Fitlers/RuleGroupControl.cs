using System;
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
            set => _whereExpression = value ?? new LogicalWhereExpression() { WhereRules = new List<BaseWhereExpression>(), OperationLogical = OperationLogical.And };
        }

        public void LoadRules()
        {
            tlpRules.Controls.Clear();
            tlpRules.RowStyles.Clear();
            this.OperationLogicalQuery = _whereExpression.OperationLogical;
            _whereExpression?.WhereRules?.ToList()?.ForEach(wr =>
            {
                if (wr is SimpleWhereExpression expression)
                {
                    var rowStyle = new RowStyle(SizeType.Absolute, 50F);
                    var cnt = tlpRules.RowStyles.Count;
                    tlpRules.RowStyles.Insert(cnt, rowStyle);

                    RuleControl ruleControl = new RuleControl(expression);
                    ruleControl.UsedTables = this.UsedTables;
                    ruleControl.DbTables = this.DbTables;
                    ruleControl.Removed += rule_removed;
                    ruleControl.Changed += rule_changed;

                    tlpRules.Controls.Add(ruleControl, 0, cnt);
                    ruleControl.Dock = DockStyle.Top;
                }
                else if (wr is LogicalWhereExpression logicalWhereExpression)
                {
                    var rowStyle = new RowStyle(SizeType.Percent, 100F);
                    var cnt = tlpRules.RowStyles.Count;
                    tlpRules.RowStyles.Insert(cnt, rowStyle);
                    RuleGroupControl ruleGroupControl = new RuleGroupControl();
                    ruleGroupControl.WhereExpression = logicalWhereExpression;
                    ruleGroupControl.UsedTables = this.UsedTables;
                    ruleGroupControl.DbTables = this.DbTables;
                    ruleGroupControl.Removed += ruleGroup_removed;
                    ruleGroupControl.Changed += ruleGroup_changed;
                    tlpRules.Controls.Add(ruleGroupControl, 0, cnt);
                    ruleGroupControl.Dock = DockStyle.Fill;
                    ruleGroupControl.LoadRules();
                }
            });
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
            var rule = new SimpleWhereExpression();
            addRule(rule);
        }

        private void btnAddRuleGroup_Click(object sender, EventArgs e)
        {
            var rule = new LogicalWhereExpression();
            addRule(rule);
        }

        private void addRule(BaseWhereExpression rule)
        {
            if (this.WhereExpression.WhereRules == null)
                this.WhereExpression.WhereRules = new List<BaseWhereExpression>();
            this.WhereExpression.WhereRules.Add(rule);
            LoadRules();
        }

        private void rule_removed(object sender, EventArgs e)
        {
            RuleControl ruleControl = (RuleControl)sender;
            var rowIndex = tlpRules.GetRow(ruleControl);
            WhereExpression?.WhereRules?.Remove(ruleControl.WhereExpression);
            tlpRules.RowStyles.RemoveAt(rowIndex);
            LoadRules();
            this.Changed?.Invoke(this, EventArgs.Empty);
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
            var rowIndex = tlpRules.GetRow(ruleGroupControl);
            WhereExpression?.WhereRules?.Remove(ruleGroupControl.WhereExpression);
            tlpRules.RowStyles.RemoveAt(rowIndex);
            LoadRules();
            this.Changed?.Invoke(this, EventArgs.Empty);
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
