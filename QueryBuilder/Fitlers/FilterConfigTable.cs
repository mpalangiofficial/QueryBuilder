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
        private BaseWhereExpression _whereExpression;
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

        public BaseWhereExpression WhereExpression
        {
            get => _whereExpression;
            private set
            {
                _whereExpression = value;
                this.btnAddFilter.BackColor = value == null ? SystemColors.ButtonHighlight : Color.DarkSeaGreen;
            }
        }

        public void SetWhereExpression(BaseWhereExpression whereExpression, bool doRefresh = false)
        {
            this.WhereExpression = whereExpression;
            if (doRefresh) this.Changed?.Invoke(this, EventArgs.Empty);
        }

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
            filterForm.WhereExpression = this.WhereExpression?.ShallowCopy();
            if (filterForm.ShowDialog(button) == DialogResult.OK)
            {
                this.WhereExpression = filterForm.WhereExpression;
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
