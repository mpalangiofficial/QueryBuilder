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
using Syncfusion.Windows.Forms.Chart;

namespace QueryBuilder
{
    public partial class SelectSortFieldForm : Form
    {
        private List<SelectSortFieldDto> _dgSource = new List<SelectSortFieldDto>();
        private List<NameAlias> _usedTables;
        private List<OrderByField> _orderByFields = new List<OrderByField>();
        public List<DbTableModel> DbTables { set; get; }

        public List<OrderByField> OrderByFields
        {
            get => _orderByFields;
            set
            {
                if (value is null)
                    _orderByFields = new List<OrderByField>();
                else
                    _orderByFields = value;
                refresh();
            }
        }

        private void refresh()
        {
            dgOrderByFields.DataSource = null;
            _dgSource = OrderByFields.Select(field => SelectSortFieldDto.FromOrderByField(field)).ToList();
            dgOrderByFields.DataSource = _dgSource;
        }

        public List<NameAlias> UsedTables
        {
            set
            {
                _usedTables = value;
                this.cmbTables.DataSource = _usedTables;
                cmbTables.DisplayMember = nameof(NameAlias.ToString);

            }
            get => _usedTables;
        }

        public SelectSortFieldForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            this.dgOrderByFields.AutoGenerateColumns = false;
            cmbOrderByType.DataSource = Enum.GetValues(typeof(OrderByType));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tableName = (NameAlias)cmbTables.SelectedItem;
            OrderByFields.Add(new OrderByField() { FieldName = cmbFields.SelectedItem.ToString(), TableName = tableName, OrderByType = (OrderByType)cmbOrderByType.SelectedItem });
            refresh();
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tableName = (NameAlias)cmbTables.SelectedItem;
            var table = DbTables.FirstOrDefault(t => t.Name == tableName.Name);
            cmbFields.Items.Clear();
            foreach (var field in table.Fields)
            {
                cmbFields.Items.Add(field.Name);
            }

            cmbFields.SelectedIndex = 0;
        }

        private void dgOrderByFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                var removeItem = ((SelectSortFieldDto)dgOrderByFields?.Rows[e.RowIndex]?.DataBoundItem).OrginalItem;
                this.OrderByFields.Remove(removeItem);
                refresh();
            }

        }
    }

    internal class SelectSortFieldDto
    {
        public string Table { get; set; }
        public string FieldName { get; set; }
        public OrderByType OrderByType { get; set; }
        public OrderByField OrginalItem { get; set; }
        public static SelectSortFieldDto FromOrderByField(OrderByField orderByField) => new SelectSortFieldDto() { Table = orderByField.TableName.ToString(), FieldName = orderByField.FieldName, OrderByType = orderByField.OrderByType, OrginalItem = orderByField };
    }
}
