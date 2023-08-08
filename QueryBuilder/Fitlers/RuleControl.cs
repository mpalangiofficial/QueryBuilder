using QueryBuilder.DatabaseSchema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class RuleControl : UserControl
    {
        public event EventHandler Changed;
        public event EventHandler Removed;
        private bool _loadInProgress = false;
        public List<DbTableModel> DbTables { get; set; }
        public List<NameAlias> UsedTables { get; set; }
        public BaseWhereExpression WhereExpression { get; set; }
        public RuleControl(SimpleWhereExpression whereExpression)
        {
            _loadInProgress = true;
            InitializeComponent();
            WhereOperation[] whereOperations = (WhereOperation[])Enum.GetValues(typeof(WhereOperation));
            whereOperations.ToList().ForEach(wo => cmbOperations.Items.Add(wo));
            cmbOperations.SelectedIndex = 0;

            WhereExpression = whereExpression;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, e);
        }

        private void txtExpectedValue_TextChanged(object sender, EventArgs e)
        {
            CreateWhere();
        }

        private void CreateWhere()
        {
            if (!_loadInProgress)
            {
                var whereExpression = WhereExpression as SimpleWhereExpression;
                if (whereExpression != null)
                {
                    whereExpression.RuleId = WhereExpression?.RuleId ?? Guid.NewGuid();
                    whereExpression.ExpectedValue = txtExpectedValue?.Text ?? String.Empty;
                    whereExpression.Table = (NameAlias)cmbTables.SelectedItem;
                    whereExpression.Field = new NameAlias()
                        { Name = cmbFields?.SelectedItem?.ToString() ?? String.Empty };
                    whereExpression.Operation = (WhereOperation)cmbOperations.SelectedItem;
                }

                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null)
            {
                var fields = DbTables.SingleOrDefault(t => t.Name == ((NameAlias)cmbTables.SelectedItem).Name)?.Fields.Select(f => f.Name).ToList();
                cmbFields.DataSource = null;
                cmbFields.DataSource = fields;
                cmbFields.SelectedIndex = 0;
            }
        }

        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateWhere();
        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateWhere();
        }

        private void cmbTables_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb == null) return;

            int index = e.Index >= 0 ? e.Index : -1;
            Brush brush = (e.State & DrawItemState.Selected) > 0 ? SystemBrushes.HighlightText : new SolidBrush(cmb.ForeColor);
            e.DrawBackground();

            if (index != -1)
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.DrawString(cmb.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }

            e.DrawFocusRectangle();
        }

        private void RuleControl_Load(object sender, EventArgs e)
        {
            var whereExpression = WhereExpression == null ? null : WhereExpression as SimpleWhereExpression;


            cmbTables.DataSource = null;
            cmbTables.DataSource = UsedTables;
            cmbTables.DisplayMember = nameof(NameAlias.ToString);
            cmbTables.SelectedIndex = 0;

            if (whereExpression?.Table == null) cmbTables.SelectedIndex = 0;
            else cmbTables.SelectedItem = whereExpression?.Table;

            if (whereExpression?.Field == null) cmbFields.SelectedIndex = 0;
            else cmbFields.SelectedItem = whereExpression?.Field?.Name;

            if (whereExpression?.Operation == null) cmbOperations.SelectedIndex = 0;
            else cmbOperations.SelectedItem = whereExpression?.Operation;

            txtExpectedValue.Text = whereExpression?.ExpectedValue?.ToString();

            _loadInProgress = false;
        }
    }
}
