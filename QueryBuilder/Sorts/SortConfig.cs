using QueryBuilder.DatabaseSchema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class SortConfig : UserControl
    {
        public ToolTip ToolTip { get; set; }
        public List<DbTableModel> DbTables { get; set; }
        private List<NameAlias> _usedTables;
        private List<OrderByField> _orderByFields;

        public List<NameAlias> UsedTables
        {
            get => _usedTables;
            set
            {
                _usedTables = value;
                btnAddSort.Enabled = _usedTables?.Count > 0 ? true : false;
            }
        }
        public event EventHandler Changed;

        public List<OrderByField> OrderByFields
        {
            get => _orderByFields;
            private set
            {
                _orderByFields = value;
                txtSortFields.Text =value is null?string.Empty: string.Join("; ", value);
            }
        }

        public void SetOrderByFields(List<OrderByField> orderByFields,bool doRefresh=false)
        {
            this.OrderByFields = orderByFields;
            if(doRefresh) this.Changed?.Invoke(this, EventArgs.Empty);
        }

        public SortConfig()
        {
            InitializeComponent();
        }

        private void btnAddSort_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var screenCoordinates = button.PointToScreen(Point.Empty);

            SelectSortFieldForm selectSortFieldForm = new SelectSortFieldForm();
            selectSortFieldForm.DbTables = this.DbTables;
            selectSortFieldForm.UsedTables = this.UsedTables;
            selectSortFieldForm.OrderByFields = this.OrderByFields?.Select(obf=>obf.ShallowCopy()).ToList();
            selectSortFieldForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y-selectSortFieldForm.Height/2);
            if (selectSortFieldForm.ShowDialog(button) == DialogResult.OK)
            {
                this.OrderByFields = selectSortFieldForm.OrderByFields;
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
