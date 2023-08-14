using QueryBuilder.DatabaseSchema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class SelectFieldsConfig : UserControl
    {
        public ToolTip ToolTip { get; set; }
        public List<DbTableModel> DbTables { get; set; }
        private List<NameAlias> _usedTables;
        private List<SelectField> _selectedFields;

        public List<NameAlias> UsedTables
        {
            get => _usedTables;
            set
            {
                _usedTables = value;
                btnAddSelect.Enabled = _usedTables?.Count > 0;
            }
        }
        public event EventHandler Changed;

        public List<SelectField> SelectedFields
        {
            get => _selectedFields;
            private set
            {
                _selectedFields = value;
                txtFields.Text = value is null ? string.Empty : string.Join("; ", value.Where(s => !s.IsTempField)?.ToList());

            }
        }

        public void SetSelectedFields(List<SelectField> selectedFields, bool doRefresh = false)
        {
            this.SelectedFields = selectedFields;
            if (doRefresh) this.Changed?.Invoke(this, EventArgs.Empty);
        }

        public SelectFieldsConfig()
        {
            InitializeComponent();
        }

        private void btnAddSelect_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var screenCoordinates = button.PointToScreen(Point.Empty);

            SelectFieldsForm selectFieldsForm = new SelectFieldsForm();
            selectFieldsForm.DbTables = this.DbTables;
            selectFieldsForm.UsedTables = this.UsedTables;
            selectFieldsForm.SelectedFields = this.SelectedFields?.Select(sf => sf.ShallowCopy()).ToList();
            selectFieldsForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (selectFieldsForm.ShowDialog(button) == DialogResult.OK)
            {
                this.SelectedFields = selectFieldsForm.SelectedFields;
                this.Changed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
