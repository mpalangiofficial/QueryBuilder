﻿using QueryBuilder.DatabaseSchema;
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
        public List<SelectField> SelectedFields { get; set; }
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
            selectFieldsForm.SelectedFields = this.SelectedFields?.Select(sf=>sf.ShallowCopy()).ToList();
            selectFieldsForm.Location= new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (selectFieldsForm.ShowDialog(button) == DialogResult.OK)
            {
                this.SelectedFields = selectFieldsForm.SelectedFields;
                txtFields.Text = string.Join("; ", selectFieldsForm.SelectedFields.Where(s=>!s.IsTempField).ToList());
                this.Changed?.Invoke(this,EventArgs.Empty);
            }
        }
    }
}
