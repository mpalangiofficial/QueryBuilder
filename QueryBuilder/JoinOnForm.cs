using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class JoinOnForm : Form
    {
        public List<NameAlias> UsedTables { get; set; }
        public DbTableModel RightTable
        {
            get => _rightTable;
            private set
            {
                _rightTable = value;
                lblRightTable.Text = _rightTable.Name;
                loadRightField();
            }
        }

        private IList<DbTableModel> _dbTables;
        private DbTableModel _rightTable;
        private readonly bool _isEdit;

        public JoinOn JoinOn { get; private set; }
        public IList<DbTableModel> DbTables
        {
            get => _dbTables;
            set
            {
                _dbTables = value;
                loadTables();
            }
        }

        public JoinOnForm(DbTableModel rightTable)
        {
            InitializeComponent();
            RightTable = rightTable;
            _isEdit = false;
            DialogResult = DialogResult.Cancel;
        }

        public JoinOnForm(JoinOn joinOn)
        {
            InitializeComponent();
            JoinOn = joinOn;
            _isEdit = true;

        }
        private void loadRightField()
        {
            cmbRightFields.ValueMember = nameof(DbFieldModel.Name);
            cmbRightFields.DisplayMember = nameof(DbFieldModel.Name);
            foreach (var field in RightTable.Fields)
            {
                cmbRightFields.Items.Add(field);
            }

            cmbRightFields.SelectedIndex = 0;
        }

        private void loadTables()
        {
            cmbLeftTables.DisplayMember = nameof(DbTableModel.Name);
            cmbLeftTables.ValueMember = nameof(DbTableModel.Name);
            if (this.UsedTables is null)
            {
                cmbLeftTables.Items.Clear();
                return;
            }

            foreach (var dbTableModel in DbTables.Where(table => UsedTables.Any(ut => ut.Name.ToLower() == table.Name.ToLower())))
            {
                cmbLeftTables.Items.Add(dbTableModel);
            }

            cmbLeftTables.SelectedIndex = 0;
        }

        private void cmbLeftTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            var leftTableSelectedItem = (DbTableModel)cmbLeftTables.SelectedItem;
            cmbLeftFields.ValueMember = nameof(DbFieldModel.Name);
            cmbLeftFields.DisplayMember = nameof(DbFieldModel.Name);
            cmbLeftFields.Items.Clear();

            foreach (var field in leftTableSelectedItem.Fields)
            {
                cmbLeftFields.Items.Add(field);
            }

            cmbLeftFields.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!validated())
            {
                MessageBox.Show("The type of join fields are not same");
            }
            else
            {
                this.JoinOn = new JoinOn();
                JoinOn.RightTable = new NameAlias() { Name = RightTable.Name, Alias = string.Empty };

                var rightField = (DbFieldModel)cmbRightFields.SelectedItem;
                JoinOn.RightField = new NameAlias() { Name = rightField.Name, Alias = string.Empty };

                var leftTable = (DbTableModel)cmbLeftTables.SelectedItem;
                JoinOn.LeftTable = new NameAlias() { Name = leftTable.Name, Alias = string.Empty };

                var leftField = (DbFieldModel)cmbLeftFields.SelectedItem;
                JoinOn.LeftField = new NameAlias() { Name = leftField.Name, Alias = string.Empty };

                DialogResult = DialogResult.OK;
            }
        }
        private bool validated()
        {
            var rightField = (DbFieldModel)cmbRightFields.SelectedItem;
            var leftField = (DbFieldModel)cmbLeftFields.SelectedItem;
            return rightField.DatabaseType == leftField.DatabaseType;
        }
        private void JoinOnForm_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                RightTable = DbTables.FirstOrDefault(t => t.Name.ToLower() == JoinOn.RightTable.Name.ToLower());
                cmbRightFields.SelectedItem =
                    RightTable.Fields.FirstOrDefault(f => f.Name.ToLower() == JoinOn.RightField.Name.ToLower());
                var leftTable = DbTables.FirstOrDefault(t => t.Name.ToLower() == JoinOn.LeftTable.Name.ToLower());
                cmbLeftTables.SelectedItem = leftTable;
                cmbLeftFields.SelectedItem =
                    leftTable.Fields.FirstOrDefault(f => f.Name.ToLower() == JoinOn.LeftField.Name.ToLower());
            }
        }
    }
}
