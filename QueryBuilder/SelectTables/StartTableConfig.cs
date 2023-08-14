using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class StartTableConfig : UserControl
    {
        private NameAlias _table = new NameAlias();
        public event EventHandler Changed;
        public ToolTip ToolTipName { get; set; }
        public List<DbTableModel> DbTables { get; set; }

        public NameAlias Table
        {
            get => _table;
            private set
            {
                _table = value ?? new NameAlias();
                btnAddAlias.Visible = lblAlias.Visible = btnSelectedTable.Visible = true;
                btnStartTable.Visible = false;

                this.ToolTipName?.SetToolTip(this.btnSelectedTable, _table.Name);
                btnSelectedTable.Text = _table.Name?.Substring(0, Math.Min(_table.Name.Length, 12));
                btnSelectedTable.Tag = _table;

                lblAlias.Text = _table.Alias;

            }
        }

        public void SetTable(NameAlias table,bool doRefresh=false)
        {
            this.Table = table ?? new NameAlias();
            if(doRefresh) this.Changed?.Invoke(this, EventArgs.Empty);
        }

        public StartTableConfig()
        {
            InitializeComponent();
        }

        private void btnSelectTable_Click(object sender, EventArgs e)
        {

            var button = (Button)sender;
            SelectTableForm popupForm = new SelectTableForm(DbTables);
            var screenCoordinates = button.PointToScreen(Point.Empty);
            popupForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (popupForm.ShowDialog(button) == DialogResult.OK)
            {
                this.Table = new NameAlias() { Name = popupForm.SelectedTable.Name, Alias = Table.Alias };
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnAddAlias_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            GetAliasForm popupForm = new GetAliasForm(lblAlias.Text);
            var screenCoordinates = button.PointToScreen(Point.Empty);
            popupForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (popupForm.ShowDialog(button) == DialogResult.OK)
            {
                this.Table.Alias = lblAlias.Text = popupForm.Alias.Trim();
                this.Changed?.Invoke(this, e);
            }
        }
    }
}
