using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class JoinForm : Form
    {
        private NameAlias _rightTable;
        public List<DbTableModel> DbTables { get; set; }
        public List<NameAlias> UsedTables { get; set; }
        private NameAlias RightTable
        {
            get => _rightTable;
            set
            {
                if (_rightTable is null|| !_rightTable.Equals(value))
                {
                    _rightTable = value;
                    txtRightTableName.Text = _rightTable?.Name ?? string.Empty;
                    txtRightTableAlias.Text = _rightTable?.Alias ?? string.Empty;
                    dgJoinOns.DataSource = null;
                    Join.JoinOns.Clear();
                    ManageEnableControls();
                }
            }
        }
        public Join Join { get; set; }
        public JoinForm(FormStatus status, Join join)
        {
            Join = join;
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            dgJoinOns.AutoGenerateColumns = false;
            loadDgJoinOns();
            ManageEnableControls();
        }
        private void loadDgJoinOns()
        {
            dgJoinOns.DataSource = null;
            dgJoinOns.DataSource = Join.JoinOns.Select(x => new JoinOn()
            {
                RightTable = new NameAlias() { Name = x.RightTable.Name, Alias = x.RightTable.Alias },
                RightField = new NameAlias() { Name = x.RightField.Name, Alias = x.RightField.Alias },
                LeftField = new NameAlias() { Name = x.LeftField.Name, Alias = x.LeftField.Alias },
                LeftTable = new NameAlias() { Name = x.LeftTable.Name, Alias = x.LeftTable.Alias }
            }).ToList();

            dgJoinOns.Refresh();
        }
        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            var button = btnSelectTable;
            var selectTableForm = new SelectTableForm(DbTables);
            var screenCoordinates = button.PointToScreen(Point.Empty);
            selectTableForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);

            if (selectTableForm.ShowDialog(button) == DialogResult.OK)
            {
                this.RightTable = new NameAlias() { Name = selectTableForm.SelectedTable.Name, Alias = txtRightTableAlias.Text };
            }
        }
        private void btnAddJoinOn_Click(object sender, EventArgs e)
        {
            if (RightTable != null)
            {
                var button = (Button)sender;
                JoinOnForm joinOnForm = new JoinOnForm();
                var screenCoordinates = button.PointToScreen(Point.Empty);
                joinOnForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);

                joinOnForm.UsedTables = this.UsedTables;
                joinOnForm.DbTables = this.DbTables;
                joinOnForm.RightTable = RightTable;
                if (joinOnForm.ShowDialog(button) == DialogResult.OK)
                {
                    if (Join.JoinOns.Exists(jo => jo.Equals(joinOnForm.JoinOn)))
                    {
                        MessageBox.Show("this item exists.");
                    }
                    else
                    {
                        Join.JoinOns.Add(joinOnForm.JoinOn);
                    }

                    loadDgJoinOns();
                    ManageEnableControls();
                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validated())
            {
                this.Join.Table = RightTable;
                this.Join.JoinType = string.Empty;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void JoinForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void dgJoinOns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var item = (JoinOn)dgJoinOns.Rows[e.RowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Are you sure you want to remove this object?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var removeItem = Join.JoinOns.FirstOrDefault(j => j.Equals(item));
                    Join.JoinOns.Remove(removeItem);
                    loadDgJoinOns();
                    ManageEnableControls();
                }
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                var item = (JoinOn)dgJoinOns.Rows[e.RowIndex].DataBoundItem;
                var dataGrid = (DataGridView)sender;
                JoinOnForm joinOnForm = new JoinOnForm(item);
                var screenCoordinates = dataGrid.PointToScreen(Point.Empty);
                joinOnForm.Location = new Point(screenCoordinates.X + dataGrid.Width, screenCoordinates.Y);

                joinOnForm.UsedTables = this.UsedTables;
                joinOnForm.DbTables = this.DbTables;
                if (joinOnForm.ShowDialog(dataGrid) == DialogResult.OK)
                {
                    if (Join.JoinOns.Exists(jo => jo.Equals(joinOnForm.JoinOn)))
                    {
                        MessageBox.Show("this item exists.");
                    }
                    else
                    {
                        Join.JoinOns[e.RowIndex] = joinOnForm.JoinOn;
                    }
                    loadDgJoinOns();
                }
            }

        }
        private void txtAlias_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validated()
        {
            bool result = true;
            result &= !string.IsNullOrEmpty(RightTable?.Name);
            result &= Join.JoinOns.Count > 0;
            return result;
        }

        private void ManageEnableControls()
        {
            btnOk.Enabled = validated();
            btnAddJoinOn.Enabled = RightTable != null;
        }

        private void txtRightTableAlias_Leave(object sender, EventArgs e)
        {
            if (RightTable != null)
                RightTable = new NameAlias() { Name = RightTable.Name, Alias = txtRightTableAlias.Text };
            ManageEnableControls();
        }
    }
    public enum FormStatus
    {
        Add,
        Edit,
        Remove,
        Display
    }
}
