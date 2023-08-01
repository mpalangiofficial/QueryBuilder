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
using QueryBuilder.Models;

namespace QueryBuilder
{
    public partial class SelectForm : Form
    {
        private List<NameAlias> _usedTables;
        private List<SelectField> _selectedFields = new List<SelectField>();
        public List<DbTableModel> DbTables { set; get; }

        public List<SelectField> SelectedFields
        {
            get => _selectedFields;
            set
            {
                if (value is null)
                    _selectedFields = new List<SelectField>();
                else
                    _selectedFields = value;

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

                    this.cmbFormulaTables.DataSource = value.Select(ut => ut.DeepCopy()).ToList();
                    cmbFormulaTables.DisplayMember = nameof(NameAlias.ToString);
                    cmbFormulaTables.SelectedIndex = 0;
                }
            }
            get => _usedTables;
        }


        public SelectForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            cmbFunction.DataSource = AggregationFunction.Functions;
            cmbFunction.DisplayMember = nameof(AggregationFunction.Name);
            cmbFunction.SelectedIndex = 0;
            dgFields.AutoGenerateColumns = false;
            var operators = Operator.Operators;
            cmbOperators.DisplayMember = nameof(Operator.Symbol);
            cmbOperators.DataSource = operators;
            cmbFormulaTables.Visible = cmbFormulaFields.Visible = cmbOperators.Visible = false;
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

            var selectField = new SelectField();
            selectField.TableName = table;
            selectField.FieldName = new NameAlias() { Name = cmbFields.SelectedItem.ToString() };
            selectField.Alias = txtAlias.Text;
            selectField.IsTempField = chkIsTempField.Checked;
            selectField.HasFunction = chkUsedFunction.Checked;
            selectField.Function = chkUsedFunction.Checked ? (AggregationFunction)cmbFunction.SelectedItem : null;
            selectField.UsedOtherField = chkFormula.Checked && chkUseOtherField.Checked;
            if (!(cmbOtherField.SelectedItem is null))
                selectField.OtherField = (SelectField)((FieldDto)cmbOtherField.SelectedItem).OrginalItem;
            selectField.IsFormulaField = chkFormula.Checked;
            selectField.Operator = (Operator)cmbOperators.SelectedItem;
            if (this.chkFormula.Checked)
            {
                if (false)
                {
                }
                else
                {
                    var OtherTable = (NameAlias)cmbFormulaTables.SelectedItem;
                    selectField.OtherTableName = OtherTable;
                    selectField.OtherFieldName = new NameAlias() { Name = cmbFormulaFields.SelectedItem.ToString() };
                }
            }

            SelectedFields.Add(selectField);
            refresh();
            resetForm();
        }

        private void resetForm()
        {
            cmbFunction.SelectedIndex = cmbFormulaTables.SelectedIndex = cmbOtherField.SelectedIndex = this.cmbTables.SelectedIndex = 0;

            chkUsedFunction.Checked = this.chkUseOtherField.Checked = this.chkIsTempField.Checked = this.chkFormula.Checked = false;
            txtAlias.Text = string.Empty;
            //MessageBox.Show("Reset form");
        }

        private void refresh()
        {
            dgFields.DataSource = null;
            //todo fix
            var source = SelectedFields?.Select(sf => new FieldDto(sf))?.ToList();
            dgFields.DataSource = source;

            cmbOtherField.DataSource = null;
            cmbOtherField.DataSource = source;
            cmbOtherField.DisplayMember = nameof(FieldDto.Name);
        }

        private void dgFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgFields.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType() == typeof(DataGridViewImageCell))
                {
                    var item = (FieldDto)dgFields.Rows[e.RowIndex].DataBoundItem;

                    SelectedFields.Remove((SelectField)item.OrginalItem);
                    refresh();
                }
            }
        }

        private void chkUsedFunction_CheckedChanged(object sender, EventArgs e)
        {
            cmbFunction.Visible = chkUsedFunction.Checked;
        }

        private void chkFormula_CheckedChanged(object sender, EventArgs e)
        {
            cmbOperators.Visible = chkUseOtherField.Visible = chkFormula.Checked;
            cmbFormulaTables.Visible = cmbFormulaFields.Visible = chkFormula.Checked && !chkUseOtherField.Checked;
            cmbOtherField.Visible = chkFormula.Checked && chkUseOtherField.Checked;
        }

        private void cmbFormulaTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTable =
                DbTables.SingleOrDefault(t => t.Name.ToLower() == ((NameAlias)cmbFormulaTables.SelectedItem).Name.ToLower());
            var fields = selectedTable?.Fields.Select(f => f.Name).ToList();
            fields.Insert(0, "*");
            cmbFormulaFields.DataSource = null;
            cmbFormulaFields.DataSource = fields;
        }

        private void chkUseOtherField_CheckedChanged(object sender, EventArgs e)
        {
            cmbFormulaTables.Visible = cmbFormulaFields.Visible = chkFormula.Checked && !chkUseOtherField.Checked;
            cmbOtherField.Visible = chkFormula.Checked && chkUseOtherField.Checked;
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
        public FieldDto(SelectField selectField)
        {
            this.OrginalItem = selectField;
            this.Name = selectField.ToString();
            this.Alias = selectField.Alias;
        }

    }
}
