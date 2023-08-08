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
        public NameAlias RightTable
        {
            get => _rightTable;
            set
            {
                _rightTable = value;
                lblRightTable.Text = _rightTable.ToString();
                loadRightField();
            }
        }

        private IList<DbTableModel> _dbTables;
        private NameAlias _rightTable;
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

        public JoinOnForm()
        {
            InitializeComponent();
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
            var rightTable = DbTables.SingleOrDefault(t => t.Name.ToLower() == RightTable.Name.ToLower());
            foreach (var field in rightTable.Fields)
            {
                cmbRightFields.Items.Add(field);
            }

            cmbRightFields.SelectedIndex = 0;
        }

        private void loadTables()
        {
            if (this.UsedTables is null)
            {
                cmbLeftTables.Items.Clear();
            }
            else
            {
                cmbLeftTables.DataSource = null;
                cmbLeftTables.DataSource = UsedTables;
                cmbLeftTables.DisplayMember = nameof(NameAlias.ToString);
                cmbLeftTables.SelectedIndex = 0;
            }
        }

        private void cmbLeftTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            var leftTableSelectedItem = DbTables.SingleOrDefault(t => t.Name == ((NameAlias)cmbLeftTables.SelectedItem).Name);
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
                JoinOn.RightTable = RightTable;

                var rightField = (DbFieldModel)cmbRightFields.SelectedItem;
                JoinOn.RightField = new NameAlias() { Name = rightField.Name, Alias = string.Empty };

                JoinOn.LeftTable = (NameAlias)cmbLeftTables.SelectedItem;

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
                RightTable = JoinOn.RightTable;
                var rightTable = DbTables.SingleOrDefault(t => t.Name.ToLower() == RightTable.Name.ToLower());
                cmbRightFields.SelectedItem =
                    rightTable.Fields.FirstOrDefault(f => f.Name.ToLower() == JoinOn.RightField.Name.ToLower());
                var leftTable = DbTables.FirstOrDefault(t => t.Name.ToLower() == JoinOn.LeftTable.Name.ToLower());
                cmbLeftTables.SelectedItem = leftTable;
                cmbLeftFields.SelectedItem =
                    leftTable.Fields.FirstOrDefault(f => f.Name.ToLower() == JoinOn.LeftField.Name.ToLower());
            }
        }
    }
}
