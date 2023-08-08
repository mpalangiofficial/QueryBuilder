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
        public event EventHandler Changed;
        public ToolTip ToolTipName { get; set; }
        public List<DbTableModel> DbTables { get; set; }

        public NameAlias Table { get; private set; } = new NameAlias();
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
                btnAddAlias.Visible = lblAlias.Visible = btnSelectedTable.Visible = true;
                btnStartTable.Visible = false;

                this.ToolTipName?.SetToolTip(this.btnSelectedTable, popupForm.SelectedTable.Name);
                this.Table.Name = popupForm.SelectedTable.Name;
                 btnSelectedTable.Text = popupForm.SelectedTable.Name.Substring(0, Math.Min(popupForm.SelectedTable.Name.Length, 12));
                btnSelectedTable.Tag = popupForm.SelectedTable;
                
                this.Changed?.Invoke(this, e);
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
