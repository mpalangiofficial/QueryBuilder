using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class FilterForm : Form
    {
        public List<DbTableModel> DbTables { get; set; }
        public List<NameAlias> UsedTables { get; set; }

        private BaseWhereExpression _whereExpression;
        public BaseWhereExpression WhereExpression
        {
            get => _whereExpression;
            set
            {
                _whereExpression = value;

            }
        }

        private void loadRules()
        {
            this.rootRuleGroupControl.WhereExpression = this.WhereExpression as LogicalWhereExpression;
            this.rootRuleGroupControl.LoadRules();
        }

        public FilterForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }


        private void rootRuleGroupControl_Load(object sender, System.EventArgs e)
        {
            rootRuleGroupControl.UsedTables = this.UsedTables;
            rootRuleGroupControl.DbTables = this.DbTables;
            loadRules();
        }

        private void rootRuleGroupControl_Changed(object sender, System.EventArgs e)
        {
            this.WhereExpression = rootRuleGroupControl.WhereExpression.WhereRules.Count == 0
                ? rootRuleGroupControl.WhereExpression.WhereRules.FirstOrDefault()
                : rootRuleGroupControl.WhereExpression;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
