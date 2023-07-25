using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Dapper;
using Microsoft.CSharp.RuntimeBinder;
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
            dgResult.AutoGenerateColumns = false;
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
                var queryResult = query.Get();

                var d = queryResult.First();
                var columnNames = ((IDictionary<string, object>)d).Keys.ToArray();
                dgResult.Columns.Clear();
                foreach (var columnName in columnNames)
                {
                    var column = new DataGridViewTextBoxColumn();
                    column.HeaderText = columnName;
                    //column.Name = columnName;
                    column.DataPropertyName = columnName;
                    dgResult.Columns.Add(column);
                }
                dgResult.DataSource = null;
                dgResult.DataSource = queryResult.ToList();


                txtScript.Text = new FFSqlServerCompiler().Compile(query).Sql;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            //MessageBox.Show("query model changed!");
        }
        public static object GetProperty(object o, string member)
        {
            if (o == null) throw new ArgumentNullException("o");
            if (member == null) throw new ArgumentNullException("member");
            Type scope = o.GetType();
            IDynamicMetaObjectProvider provider = o as IDynamicMetaObjectProvider;
            if (provider != null)
            {
                ParameterExpression param = Expression.Parameter(typeof(object));
                DynamicMetaObject mobj = provider.GetMetaObject(param);
                GetMemberBinder binder = (GetMemberBinder)Microsoft.CSharp.RuntimeBinder.Binder.GetMember(0, member, scope, new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(0, null) });
                DynamicMetaObject ret = mobj.BindGetMember(binder);
                BlockExpression final = Expression.Block(
                    Expression.Label(CallSiteBinder.UpdateLabel),
                    ret.Expression
                );
                LambdaExpression lambda = Expression.Lambda(final, param);
                Delegate del = lambda.Compile();
                return del.DynamicInvoke(o);
            }
            else
            {
                return o.GetType().GetProperty(member, BindingFlags.Public | BindingFlags.Instance).GetValue(o, null);
            }
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
                if (control is JoinTableConfig config) config.UsedTables = usedTables;
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
            this.QueryModel.SelectedFunctionFields = selectConfig.SelectedFunctionFields;
            refresh();
        }
    }
}
