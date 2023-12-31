﻿using QueryBuilder.DatabaseSchema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class SelectTableForm : Form
    {
        public List<DbTableModel> TableNames { get; private set; }
        public DbTableModel SelectedTable { get; private set; }
        public SelectTableForm(List<DbTableModel> tableNames)
        {
            TableNames = tableNames;
            InitializeComponent();
            dgTables.AutoGenerateColumns = false;
            dgTables.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgTables.Columns[0].Frozen = true;
            FilterdgTables();
        }

        private void FilterdgTables()
        {
            dgTables.DataSource = null;

            dgTables.DataSource = TableNames.Where(table => table.Name.ToLower().Contains(txtFilter.Text.ToLower())).ToList();
            dgTables.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgTables_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                dgTables.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void dgTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                SelectedTable = (DbTableModel)dgTables.Rows[e.RowIndex].DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterdgTables();
        }

        private void SelectTableForm_Load(object sender, EventArgs e)
        {
            this.txtFilter.Focus();
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgTables.SelectedRows?.Count > 0)
            {
                var index = dgTables.SelectedRows[0].Index;
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        if (index > 0) dgTables.Rows[index - 1].Selected = true;
                        break;
                    case Keys.Down:
                        if ((index + 1) < dgTables.Rows.Count) dgTables.Rows[index + 1].Selected = true;
                        break;
                    case Keys.Enter:
                        SelectedTable = (DbTableModel)dgTables.Rows[index].DataBoundItem;
                        this.DialogResult = DialogResult.OK;
                        break;
                }
            }
        }
    }
}
