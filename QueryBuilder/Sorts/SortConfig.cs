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
        public List<OrderByField> OrderByFields { get; set; }
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
                txtSortFields.Text = string.Join("; ", selectSortFieldForm.OrderByFields) ;
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
