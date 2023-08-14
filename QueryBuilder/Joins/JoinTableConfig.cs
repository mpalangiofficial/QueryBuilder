using QueryBuilder.DatabaseSchema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class JoinTableConfig : UserControl
    {
        private List<NameAlias> _usedTables;
        private Join _join;
        public event EventHandler AddedJoin;
        public event EventHandler RemovingJoin;
        public event EventHandler Changed;
        public ToolTip ToolTip { get; set; }
        public List<DbTableModel> DbTables { get; set; }
        public List<NameAlias> UsedTables
        {
            get => _usedTables;
            set
            {
                _usedTables = value;
                btnAddJoin.Enabled = !(_usedTables is null || _usedTables?.Count < 1);
            }
        }

        public Join Join
        {
            get => _join;
            private set
            {
                _join = value;

                btnAddJoin.Visible = _join == null;
                btnRemoveJoin.Visible = btnJoinedTable.Visible = _join != null;

                if (_join != null)
                {
                    this.ToolTip?.SetToolTip(this.btnJoinedTable, _join?.Table?.Name);


                    if (string.IsNullOrEmpty(_join.Table.Alias))
                        btnJoinedTable.Text = _join?.Table?.Name.Substring(0, Math.Min(_join.Table.Name.Length, 12));
                    else
                        btnJoinedTable.Text =
                            $"{_join?.Table?.Name.Substring(0, Math.Min(_join.Table.Name.Length, 12))} as {_join.Table.Alias}";
                }
            }
        }

        public void SetJoin(Join join, bool doRefresh = false)
        {
            this.Join = join;
            if (doRefresh) AddedJoin?.Invoke(this, EventArgs.Empty);
        }

        public JoinTableConfig()
        {
            InitializeComponent();
        }
        private void btnAddJoin_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            JoinForm joinForm = new JoinForm(FormStatus.Add, Join.GetEmpty());
            var screenCoordinates = button.PointToScreen(Point.Empty);
            joinForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);

            joinForm.DbTables = this.DbTables;
            joinForm.UsedTables = this.UsedTables;
            if (joinForm.ShowDialog(button) == DialogResult.OK)
            {
                this.Join = joinForm.Join;
                AddedJoin?.Invoke(this, EventArgs.Empty);

            }

        }
        private void btnRemoveJoin_Click(object sender, EventArgs e)
        {
            RemovingJoin?.Invoke(this, e);
        }
    }
}
