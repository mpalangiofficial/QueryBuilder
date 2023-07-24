using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class RuleControl : UserControl
    {
        public Guid RuleId { get; set; }
        private List<DbTableModel> _dbTables;
        public event EventHandler Changed;
        public event EventHandler Removed;

        public List<DbTableModel> DbTables
        {
            get => _dbTables;
            set
            {
                _dbTables = value;
                cmbTables.DataSource = null;
                cmbTables.DataSource = UsedTables;
                cmbTables.DisplayMember = nameof(NameAlias.ToString);
                cmbTables.SelectedIndex = 0;
            }
        }

        public List<NameAlias> UsedTables { get; set; }
        public BaseWhere Where { get; set; }
        public RuleControl()
        {
            InitializeComponent();
            Where = new SimpleWhere();
            WhereOperation[] whereOperations = (WhereOperation[])Enum.GetValues(typeof(WhereOperation));
            whereOperations.ToList().ForEach(wo => cmbOperations.Items.Add(wo));
            cmbOperations.SelectedIndex = 0;
            this.RuleId = Guid.NewGuid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, e);
        }

        private void txtExpectedValue_TextChanged(object sender, EventArgs e)
        {
            createWhere();
        }

        private void createWhere()
        {
            try
            {
                Where = new SimpleWhere()
                {
                    RuleId = this.RuleId,
                    ExpectedValue = txtExpectedValue?.Text??String.Empty,
                    Table = (NameAlias)cmbTables.SelectedItem,
                    Field = new NameAlias() { Name = ((DbFieldModel)cmbFields?.SelectedItem)?.Name??String.Empty },
                    Operation = "="
                    
                };
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                //todo fix and resolve
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFields.Items.Clear();
            cmbFields.ValueMember = nameof(DbFieldModel.Name);
            cmbFields.DisplayMember = nameof(DbFieldModel.Name);
            var selectedTable = DbTables.SingleOrDefault(t=>t.Name== ((NameAlias)cmbTables.SelectedItem).Name);
            selectedTable.Fields.ToList().ForEach(field => cmbFields.Items.Add(field));
            cmbFields.SelectedIndex = 0;
        }

        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            createWhere();
        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            createWhere();
        }
    }

    public enum WhereOperation
    {
        equal,
        more,
        less
    }
}
