using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class SelectForm : Form
    {
        private List<NameAlias> _usedTables;
        public List<DbTableModel> DbTables { set; get; }
        public List<NameAlias> SelectedFields { get; set; } = new List<NameAlias>();

        public List<NameAlias> UsedTables
        {
            set
            {
                _usedTables = value;
                cmbTables.DataSource = null;
                if (DbTables.Count > 0 && UsedTables.Count > 0)
                {
                    this.cmbTables.DataSource = value;
                    cmbTables.DisplayMember = nameof(NameAlias.ToString);
                    cmbTables.SelectedIndex = 0;
                }
            }
            get => _usedTables;
        }


        public SelectForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTable =
                DbTables.SingleOrDefault(t => t.Name.ToLower() == ((NameAlias)cmbTables.SelectedItem).Name.ToLower());
            var fields = selectedTable?.Fields.Select(f => f.Name).ToList();
            fields.Insert(0, "*");
            cmbFields.DataSource = null;
            cmbFields.DataSource = fields;
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            var table = (NameAlias)cmbTables.SelectedItem;
            var tableName = string.IsNullOrEmpty(table.Alias) ? table.Name : table.Alias;
            var field = new NameAlias() { Name = $"{tableName}.{cmbFields.SelectedItem.ToString()}", Alias = txtAlias.Text };
            SelectedFields.Add(field);
            dgFields.DataSource = null;
            dgFields.DataSource = SelectedFields;
        }
    }
}
