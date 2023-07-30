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
        private List<NameAlias> _selectedFields = new List<NameAlias>();
        private List<FunctionField> _selectedFunctionFields = new List<FunctionField>();
        public List<DbTableModel> DbTables { set; get; }

        public List<NameAlias> SelectedFields
        {
            get => _selectedFields;
            set
            {
                if (value is null)
                    _selectedFields = new List<NameAlias>();
                else
                    _selectedFields = value;

                refresh();
            }
        }

        public List<FunctionField> SelectedFunctionFields
        {
            get => _selectedFunctionFields;
            set
            {
                if (value is null)
                    _selectedFunctionFields = new List<FunctionField>();
                else
                    _selectedFunctionFields = value;
                refresh();
            }

        }

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
            var functions = new string[] { "Count", "Sum","Max","Min" ,"Avg"};
            cmbFunction.DataSource = functions;
            cmbFunction.SelectedIndex = 0;
            dgFields.AutoGenerateColumns = false;
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
            if (chkUsedFunction.Checked)
            {
                if (string.IsNullOrEmpty(txtAlias.Text) || cmbFields.SelectedIndex == 0)
                {
                    MessageBox.Show("please, select a field, or set alias for function field");
                }
                else
                {
                    var functionField = new FunctionField()
                    {
                        Name = $"{tableName}.{cmbFields.SelectedItem.ToString()}", Alias = txtAlias.Text,
                        Function = cmbFunction.SelectedItem.ToString()
                    };
                    SelectedFunctionFields.Add(functionField);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtAlias.Text) && cmbFields.SelectedIndex == 0)
                {
                    MessageBox.Show("you can't set alias for set of field");
                }
                else

                {
                    var field = new NameAlias()
                        { Name = $"{tableName}.{cmbFields.SelectedItem.ToString()}", Alias = txtAlias.Text };
                    SelectedFields.Add(field);
                }
            }
            refresh();
        }

        private void refresh()
        {
            dgFields.DataSource = null;
            var source = SelectedFields.Select(sf => new FieldDto(sf)).Concat(SelectedFunctionFields.Select(ff => new FieldDto(ff))
                .ToList());
            dgFields.DataSource = source.ToList();
        }

        private void dgFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgFields.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType() == typeof(DataGridViewImageCell))
                {
                    var item = (FieldDto)dgFields.Rows[e.RowIndex].DataBoundItem;
                    if (item.OrginalItem.GetType() == typeof(NameAlias))
                    {
                        SelectedFields.Remove((NameAlias)item.OrginalItem);
                    }
                    else if (item.OrginalItem.GetType() == typeof(FunctionField))
                    {
                        SelectedFunctionFields.Remove((FunctionField)item.OrginalItem);
                    }

                    refresh();
                }
            }
        }

        private void chkUsedFunction_CheckedChanged(object sender, EventArgs e)
        {
            cmbFunction.Visible = chkUsedFunction.Checked;
        }
    }
    internal class FieldDto
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public object OrginalItem { get; set; }

        public FieldDto(NameAlias nameAlias)
        {
            this.OrginalItem = nameAlias;
            this.Name = nameAlias.Name;
            this.Alias = nameAlias.Alias;
        }
        public FieldDto(FunctionField functionField)
        {
            this.OrginalItem = functionField;
            this.Name = $"{functionField.Function}({functionField.Name})";
            this.Alias = functionField.Alias;
        }
    }
}
