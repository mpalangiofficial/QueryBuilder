using QueryBuilder.DatabaseSchema;
using QueryBuilder.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class SelectFieldsForm : Form
    {
        private List<NameAlias> _usedTables;
        private List<SelectField> _selectedFields = new List<SelectField>();
        public List<DbTableModel> DbTables { set; get; }
        public List<SelectField> SelectedFields
        {
            get => _selectedFields;
            set
            {
                _selectedFields = value ?? new List<SelectField>();
                refresh();
            }
        }
        public List<NameAlias> UsedTables
        {
            set
            {
                _usedTables = value;
                cmbTables.DataSource = null;
                if (DbTables != null && DbTables.Count > 0 && UsedTables.Count > 0)
                {
                    this.cmbTables.DataSource = value;
                    cmbTables.DisplayMember = nameof(NameAlias.ToString);
                    cmbTables.SelectedIndex = 0;

                    this.cmbFormulaTables.DataSource = value.Select(ut => ut.ShallowCopy()).ToList();
                    cmbFormulaTables.DisplayMember = nameof(NameAlias.ToString);
                    cmbFormulaTables.SelectedIndex = 0;
                }
            }
            get => _usedTables;
        }

        public SelectFieldsForm()
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTable =
                DbTables.SingleOrDefault(t => t.Name.ToLower() == ((NameAlias)cmbTables.SelectedItem).Name.ToLower());
            var fields = selectedTable?.Fields.Select(f => f.Name).ToList();
            if (fields != null)
            {
                fields.Insert(0, "*");
                cmbFields.DataSource = null;
                cmbFields.DataSource = fields;
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var table = (NameAlias)cmbTables.SelectedItem;

                var selectField = new SelectField();
                selectField.TableName = table;
                selectField.FieldName = new NameAlias() { Name = cmbFields.SelectedItem.ToString() };
                selectField.Alias = txtAlias.Text;
                selectField.IsTempField = chkIsTempField.Checked;

                selectField.HasFunction = chkUsedFunction.Checked;
                selectField.Function = chkUsedFunction.Checked ? (AggregationFunction)cmbFunction.SelectedItem : null;

                selectField.IsFormulaField = chkFormula.Checked;
                if (selectField.IsFormulaField)
                {
                    selectField.Operator = (Operator)cmbOperators.SelectedItem;
                    selectField.UsedOtherField = chkUseOtherField.Checked;
                    if (selectField.UsedOtherField)
                    {
                        selectField.OtherField = !(cmbOtherField.SelectedItem is null)
                            ? (SelectField)((FieldDto)cmbOtherField.SelectedItem).OrginalItem
                            : null;
                    }
                    else
                    {
                        var OtherTable = (NameAlias)cmbFormulaTables.SelectedItem;
                        selectField.OtherTableName = OtherTable;
                        selectField.OtherFieldName = new NameAlias()
                        { Name = cmbFormulaFields.SelectedItem.ToString() };
                    }
                }

                SelectedFields.Add(selectField);
                refresh();
                resetForm();
            }
            else
            {
                MessageBox.Show(this, "Not validate!");
            }
        }

        private bool validate()
        {
            bool result = true;
            if (chkFormula.Checked || chkUsedFunction.Checked) result &= !string.IsNullOrEmpty(txtAlias.Text.Trim());
            if (cmbFields.SelectedIndex == 0) result &= string.IsNullOrEmpty(txtAlias.Text.Trim());
            if (chkFormula.Checked && !chkUseOtherField.Checked) result &= cmbFormulaFields.SelectedIndex != 0;

            return result;
        }

        private void resetForm()
        {
            cmbFunction.SelectedIndex = cmbFormulaTables.SelectedIndex = cmbOtherField.SelectedIndex = this.cmbTables.SelectedIndex = 0;

            chkUsedFunction.Checked = this.chkUseOtherField.Checked = this.chkIsTempField.Checked = this.chkFormula.Checked = false;

            txtAlias.Text = string.Empty;
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
        public FieldDto(SelectField selectField)
        {
            this.OrginalItem = selectField;
            this.Name = selectField.ToString();
            this.Alias = selectField.Alias;
        }

    }
}
