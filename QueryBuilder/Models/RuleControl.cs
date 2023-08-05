using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class RuleControl : UserControl
    {
        public Guid RuleId { get; set; }
        private List<DbTableModel> _dbTables;
        private BaseWhereExpression _whereExpression;
        public event EventHandler Changed;
        public event EventHandler Removed;
        private bool _loadInProgress = false;
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

        public BaseWhereExpression WhereExpression
        {
            get => _whereExpression;
            set => _whereExpression = value;

        }

        public RuleControl()
        {
            _loadInProgress = true;
            InitializeComponent();
            WhereOperation[] whereOperations = (WhereOperation[])Enum.GetValues(typeof(WhereOperation));
            whereOperations.ToList().ForEach(wo => cmbOperations.Items.Add(wo));
            cmbOperations.SelectedIndex = 0;
            WhereExpression = new SimpleWhereExpression();
            this.RuleId = Guid.NewGuid();
        }

        public RuleControl(SimpleWhereExpression whereExpression) : this()
        {
            RuleId = whereExpression.RuleId;
            WhereExpression = whereExpression;
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
            if (!_loadInProgress)
            {
                try
                {

                    WhereExpression = new SimpleWhereExpression()
                    {
                        RuleId = this.RuleId,
                        ExpectedValue = txtExpectedValue?.Text ?? String.Empty,
                        Table = (NameAlias)cmbTables.SelectedItem,
                        Field = new NameAlias() { Name = cmbFields?.SelectedItem?.ToString() ?? String.Empty },
                        Operation = (WhereOperation)cmbOperations.SelectedItem

                    };
                    this.Changed?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception exception)
                {
                    //todo fix and resolve
                }
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
            createWhere();
        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            createWhere();
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

            try
            {
                cmbTables.SelectedItem = whereExpression?.Table;
                cmbFields.SelectedItem = whereExpression?.Field?.Name;
                cmbOperations.SelectedItem = whereExpression?.Operation;
                txtExpectedValue.Text = whereExpression?.ExpectedValue?.ToString();
            }
            catch (Exception exception)
            {

            }
            _loadInProgress = false;
        }
    }
}
