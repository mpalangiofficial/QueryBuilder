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
using SqlKata;

namespace QueryBuilder
{
    public partial class SelectConfig : UserControl
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
                btnAddSelect.Enabled = _usedTables?.Count > 0 ? true : false;
            }
        }
        public event EventHandler Changed;
        public List<SelectField> SelectedFields { get; set; }
        public SelectConfig()
        {
            InitializeComponent();
        }

        private void btnAddSelect_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var screenCoordinates = button.PointToScreen(Point.Empty);

            SelectForm selectForm = new SelectForm();
            selectForm.DbTables = this.DbTables;
            selectForm.UsedTables = this.UsedTables;
            selectForm.SelectedFields = this.SelectedFields;
            selectForm.Location= new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (selectForm.ShowDialog(button) == DialogResult.OK)
            {
                this.SelectedFields = selectForm.SelectedFields;
                txtFields.Text = string.Join("; ", selectForm.SelectedFields.Where(s=>!s.IsTempField).ToList());
                this.Changed?.Invoke(this,EventArgs.Empty);
            }
        }
    }
}
