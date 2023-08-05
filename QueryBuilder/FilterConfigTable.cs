using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class FilterConfigTable : UserControl
    {
        public event EventHandler Changed;
        private List<NameAlias> _usedTables;
        public List<DbTableModel> DbTables { get; set; }

        public List<NameAlias> UsedTables
        {
            get => _usedTables;
            set
            {
                _usedTables = value;
                btnAddFilter.Enabled = !(_usedTables is null || _usedTables?.Count < 1);
            }
        }

        public BaseWhereExpression WhereExpression { get; set; }
        public FilterConfigTable()
        {
            InitializeComponent();
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            FilterForm filterForm = new FilterForm();
            filterForm.UsedTables = this.UsedTables;
            filterForm.DbTables = this.DbTables;
            var screenCoordinates = button.PointToScreen(Point.Empty);
            filterForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            filterForm.WhereExpression = this.WhereExpression;
            if (filterForm.ShowDialog(button) == DialogResult.OK)
            {
                this.WhereExpression = filterForm.WhereExpression;
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
