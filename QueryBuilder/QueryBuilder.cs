using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace QueryBuilder
{
    public partial class QueryBuilder : UserControl
    {
        public QueryModel QueryModel { get; private set; } = new QueryModel() { Joins = new List<Join>() };
        public string ConnectionString { get; set; } = "Password=ffc-pr-02;Persist Security Info=True;User ID=sa;Initial Catalog=northwind;Data Source=.";
        private IList<DbTableModel> _dbTables;
        public QueryBuilder()
        {
            InitializeComponent();
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.FlatAppearance.BorderColor = Color.LightGray;
            btnRun.FlatAppearance.BorderSize = 1;
            btnRun.ForeColor = Color.DarkGray;

            IDataSchema dataSchema = new DataSchemaWithDatabaseSchemaReader();
            _dbTables = dataSchema.GetSchema(ConnectionString, "");

            var usedTables = UsedTables();

            joinTableConfig.DbTables = _dbTables.ToList();
            joinTableConfig.UsedTables = usedTables;

            filterConfigTable.DbTables = _dbTables.ToList();
            filterConfigTable.UsedTables = usedTables;

            selectConfig.DbTables = _dbTables.ToList();
            selectConfig.UsedTables = usedTables;
        }
        private void tlpQueryBuilder_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

            int borderWidth = 1;
            Color borderColor = Color.LightGray; // Change this to the desired color

            var tableLayout = (TableLayoutPanel)sender;
            var cellRectangle = e.CellBounds;
            var graphics = e.Graphics;

            using (var pen = new Pen(borderColor, borderWidth))
            {
                if (e.Row == 0) graphics.DrawLine(pen, cellRectangle.Left, cellRectangle.Top, cellRectangle.Right, cellRectangle.Top);
                if (e.Row == tableLayout.RowCount - 1) graphics.DrawLine(pen, cellRectangle.Left, cellRectangle.Bottom, cellRectangle.Right, cellRectangle.Bottom);
                if (e.Column == tableLayout.ColumnCount - 1) graphics.DrawLine(pen, cellRectangle.Right, cellRectangle.Top, cellRectangle.Right, cellRectangle.Bottom);

                graphics.DrawLine(pen, cellRectangle.Left, cellRectangle.Top, cellRectangle.Left, cellRectangle.Bottom);
            }
        }
        private void tlpQueryBuilderFlow_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int borderWidth = 2;
            Color borderColor = Color.DarkBlue;

            var tableLayout = (TableLayoutPanel)sender;
            var cellRectangle = e.CellBounds;
            var graphics = e.Graphics;

            using (var pen = new Pen(borderColor, borderWidth))
            {
                graphics.DrawLine(pen, cellRectangle.Left, cellRectangle.Top, cellRectangle.Left, cellRectangle.Bottom);
                graphics.DrawLine(pen, cellRectangle.Right, cellRectangle.Top, cellRectangle.Right, cellRectangle.Bottom);
                graphics.DrawLine(pen, cellRectangle.Left, cellRectangle.Top, cellRectangle.Right, cellRectangle.Top);
                graphics.DrawLine(pen, cellRectangle.Left, cellRectangle.Bottom, cellRectangle.Right, cellRectangle.Bottom);

            }
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }
        private void joinTableConfig_AddedJoin(object sender, EventArgs e)
        {
            JoinTableConfig joinTableConfig = (JoinTableConfig)sender;
            QueryModel.Joins.Add(joinTableConfig.Join);
            var joinTableConfigIndex = tlpQueryBuilderFlow.GetRow(joinTableConfig);
            Shiftdown(joinTableConfigIndex);

            var rowStyle = new RowStyle(SizeType.Absolute, 70F);
            var joinObj = new JoinTableConfig();
            joinObj.AddedJoin += new EventHandler(joinTableConfig_AddedJoin);
            joinObj.RemovingJoin += new EventHandler(this.joinTableConfig_RemovingJoin);
            joinObj.UsedTables = this.UsedTables();
            joinObj.DbTables = this._dbTables.ToList();
            joinObj.ToolTip = this.toolTipName;
            tlpQueryBuilderFlow.RowStyles.Insert(2, rowStyle);
            tlpQueryBuilderFlow.Controls.Add(joinObj, 1, joinTableConfigIndex + 1);
            SetUsedTables();
            refresh();
        }
        private void Shiftdown(int selectIndex)
        {
            for (int i = tlpQueryBuilderFlow.RowCount - 1; i > selectIndex; i--)
            {
                for (int j = 1; j < tlpQueryBuilderFlow.ColumnCount; j++)
                {
                    Control control = tlpQueryBuilderFlow.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        tlpQueryBuilderFlow.SetRow(control, i + 1);
                    }
                }
            }
        }
        private void ShiftAbove(int selectIndex)
        {

            for (int i = selectIndex + 1; i < tlpQueryBuilderFlow.RowCount; i++)
            {
                for (int j = 1; j < tlpQueryBuilderFlow.ColumnCount; j++)
                {
                    Control control = tlpQueryBuilderFlow.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        tlpQueryBuilderFlow.SetRow(control, i - 1);
                    }
                }
            }
        }
        private void joinTableConfig_RemovingJoin(object sender, EventArgs e)
        {
            JoinTableConfig joinTableConfig = (JoinTableConfig)sender;

            var joinTableConfigIndex = tlpQueryBuilderFlow.GetRow(joinTableConfig);
            QueryModel.Joins.Remove(joinTableConfig.Join);
            tlpQueryBuilderFlow.Controls.Remove(joinTableConfig);
            tlpQueryBuilderFlow.RowStyles.RemoveAt(joinTableConfigIndex);
            ShiftAbove(joinTableConfigIndex);
            SetUsedTables();
            refresh();
        }
        private void refresh()
        {
            try
            {
                var query = QueryModel.GenerateQuery(new SqlConnection(ConnectionString), new FFSqlServerCompiler());
                #region trashy
                //var factory = new QueryFactory(new SqlConnection(ConnectionString), new FFSqlServerCompiler());
                //Query query = factory.Query(QueryModel.StartTable.ToString());

                //if (QueryModel.Joins.Count > 0)
                //{
                //    foreach (var join in QueryModel.Joins)
                //    {
                //        SqlKata.Join joinQuery = new SqlKata.Join();
                //        foreach (var joinOn in join.JoinOns)
                //        {
                //            joinQuery.On($"{joinOn.LeftTable.Name}.{joinOn.LeftField.Name}", $"{joinOn.RightTable.Name}.{joinOn.RightField.Name}", op: "=");
                //        }
                //        query = query.Join(join.Table.Name, j => joinQuery);
                //    }
                //}

                //if (QueryModel.Where != null)
                //{
                //    query.Where(QueryModel.Where.FilterExpression);
                //}
                //BaseWhere orderIdNotZero = new SimpleWhere() { Field = new NameAlias() { Name = "orderId" }, Operation = "!=", ExpectedValue = 0 };
                //BaseWhere customerIdVINET = new SimpleWhere() { Field = new NameAlias() { Name = "OrderId.CustomerId" }, Operation = "=", ExpectedValue = "VINET" };
                //LogicalWhere orTest = new LogicalWhere()
                //{ OperationLogical = OperationLogical.Or, WhereRules = new List<BaseWhere>() { orderIdNotZero, customerIdVINET } };

                //BaseWhere OrderIdMore10250 = new SimpleWhere() { Field = new NameAlias() { Name = "orderId" }, Operation = ">", ExpectedValue =10250 };

                //QueryModel.Where = new LogicalWhere()
                //{
                //    OperationLogical = OperationLogical.And, WhereRules = new List<BaseWhere>() { OrderIdMore10250, orTest }
                //};
                //query.Where(QueryModel.Where.FilterExpression);
                //Func<Query, Query> w = q => q.Where("orderId", "!=", 0).OrWhere("CustomerId", "VINET");
                //Func<Query, Query> w_1 = q => q.Where("OrderId", ">", 10250);

                //query = query.Where(w).Where(w_1);
                //query = query.Where(q => q.Where("orderId", "!=", 0).OrWhere("CustomerId","VINET")).Where("OrderId",">",10250); 
                #endregion

                var dbdd = query.Get();
                dgResult.DataSource = null;
                dgResult.DataSource = dbdd.ToList();
                txtScript.Text = new FFSqlServerCompiler().Compile(query).Sql;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            MessageBox.Show("query model changed!");
        }
        private void startTableConfig_Changed(object sender, EventArgs e)
        {
            var startTableConfig = (StartTableConfig)sender;
            this.QueryModel.StartTable = startTableConfig.Table;
            SetUsedTables();
            refresh();
        }

        private void SetUsedTables()
        {
            List<NameAlias> usedTables = UsedTables();
            foreach (var control in tlpQueryBuilderFlow.Controls)
            {
                if (control is JoinTableConfig) ((JoinTableConfig)control).UsedTables = usedTables;
            }

            filterConfigTable.UsedTables = usedTables;
            selectConfig.UsedTables = usedTables;
        }

        private List<NameAlias> UsedTables()
        {
            var result = new List<NameAlias>();
            if (QueryModel.StartTable != null) result.Add(QueryModel.StartTable);
            if (QueryModel?.Joins?.Count > 0)
            {
                QueryModel.Joins.ForEach(join => result.Add(join.Table));
            }

            return result;
        }

        private void filterConfigTable_Changed(object sender, EventArgs e)
        {
            this.QueryModel.Where = filterConfigTable.Where;
            refresh();
        }

        private void selectConfig_Changed(object sender, EventArgs e)
        {
            this.QueryModel.SelectFields = selectConfig.SelectedFields;
            refresh(); 
        }
    }
}
