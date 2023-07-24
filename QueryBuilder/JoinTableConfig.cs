﻿using QueryBuilder.DatabaseSchema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class JoinTableConfig : UserControl
    {
        private List<NameAlias> _usedTables;
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
                btnAddJoin.Enabled=!( _usedTables is null || _usedTables?.Count <1);
            }
        }

        public Join Join { get; private set; }
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

                btnAddJoin.Visible = false;
                btnRemoveJoin.Visible = btnAddAlias.Visible = lblAlias.Visible = btnJoinedTable.Visible = true;

                this.ToolTip?.SetToolTip(this.btnJoinedTable, joinForm.Join.Table.Name);


                btnJoinedTable.Text = joinForm.Join.Table.Name.Substring(0, Math.Min(joinForm.Join.Table.Name.Length, 12)); ;
                AddedJoin?.Invoke(this, e);

            }

        }

        private void btnRemoveJoin_Click(object sender, EventArgs e)
        {
            RemovingJoin?.Invoke(this, e);
        }
    }
}
