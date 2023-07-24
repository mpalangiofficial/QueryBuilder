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
        public BaseWhere Where { get; set; }
        public FilterForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void rootRuleGroupControl_Load(object sender, System.EventArgs e)
        {
            rootRuleGroupControl.UsedTables = this.UsedTables;
            rootRuleGroupControl.DbTables = this.DbTables;
        }

        private void rootRuleGroupControl_Changed(object sender, System.EventArgs e)
        {
            this.Where = rootRuleGroupControl.Where.WhereRules.Count == 0 
                ? rootRuleGroupControl.Where.WhereRules.FirstOrDefault() 
                : rootRuleGroupControl.Where;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
