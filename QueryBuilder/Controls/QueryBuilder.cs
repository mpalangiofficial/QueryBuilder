﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.CSharp.RuntimeBinder;
using QueryBuilder.Controls.Models;
using QueryBuilder.DatabaseSchema;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace QueryBuilder.Controls
{
    public partial class QueryBuilder : UserControl
    {
        public QueryModel QueryModel { get; private set; } = new QueryModel() { Joins = new List<Join>() };
        public string ConnectionString { get; set; }
        private IList<DbTableModel> _dbTables;
        private string[] columnNames;
        private IEnumerable<dynamic> queryResult;
        public QueryBuilder()
        {
            InitializeComponent();
            dgResult.AutoGenerateColumns = false;


        }

        public void SetQueryModel(QueryModel queryModel)
        {
            this.QueryModel = queryModel;

            loadModel();
        }

        private void loadModel()
        {
            int stepCount = 1;

            this.startTableConfig.SetTable(QueryModel.StartTable);
           
            var joinTableConfigs = this.tlpQueryBuilderFlow.Controls.OfType<JoinTableConfig>().ToList();
            joinTableConfigs.ForEach(jtc =>
            {
                if (jtc.Join != null)
                {
                    joinTableConfig_RemovingJoin(jtc, EventArgs.Empty);
                }
            });
            if (QueryModel.Joins?.Count > 0)
            {
                QueryModel.Joins.ForEach(join =>
                {
                    var joinTableConfig = this.tlpQueryBuilderFlow.Controls.OfType<JoinTableConfig>()?.FirstOrDefault(jtc => jtc.Join == null);
                    joinTableConfig.SetJoin(join);
                    AddEmptyJoin(joinTableConfig);
                });

            }
           
            this.filterConfigTable.SetWhereExpression(this.QueryModel?.WhereExpression);
            this.selectFieldsConfig.SetSelectedFields(this.QueryModel.SelectFields);
            this.sortConfig.SetOrderByFields(this.QueryModel.SortFields);
            ApplyDBTablesAndUsedTables();
            Refresh();

        }

        private void QueryBuilder_Load(object sender, EventArgs e)
        {

            loadDbSchema();
            ApplyDBTablesAndUsedTables();
        }
        private void ApplyDBTablesAndUsedTables()
        {
            var usedTables = UsedTables();

            startTableConfig.DbTables = _dbTables.ToList();

            joinTableConfig.DbTables = _dbTables.ToList();
            joinTableConfig.UsedTables = usedTables;

            filterConfigTable.DbTables = _dbTables.ToList();
            filterConfigTable.UsedTables = usedTables;

            selectFieldsConfig.DbTables = _dbTables.ToList();
            selectFieldsConfig.UsedTables = usedTables;

            sortConfig.DbTables = _dbTables.ToList();
            sortConfig.UsedTables = usedTables;
        }
        private void loadDbSchema()
        {
            IDataSchema dataSchema = new DataSchemaWithDatabaseSchemaReader();
            _dbTables = dataSchema.GetSchema(ConnectionString, "");
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

            AddEmptyJoin(joinTableConfig);

            SetUsedTables();
            QueryModel.Joins.Add(joinTableConfig.Join);

            Refresh();
        }

        private void AddEmptyJoin(JoinTableConfig joinTableConfig)
        {
            var joinTableConfigIndex = tlpQueryBuilderFlow.GetRow(joinTableConfig);
            var rowStyle = new RowStyle(SizeType.Absolute, 55F);
            var joinObj = new JoinTableConfig();
            joinObj.AddedJoin += new EventHandler(joinTableConfig_AddedJoin);
            joinObj.RemovingJoin += new EventHandler(this.joinTableConfig_RemovingJoin);
            joinObj.UsedTables = this.UsedTables();
            joinObj.DbTables = this._dbTables.ToList();
            joinObj.ToolTip = this.toolTipName;
            tlpQueryBuilderFlow.RowStyles.Insert(2, rowStyle);
            ShiftDown(joinTableConfigIndex);
            tlpQueryBuilderFlow.Controls.Add(joinObj, 1, joinTableConfigIndex + 1);
            joinObj.Dock = DockStyle.Fill;
        }

        private void ShiftDown(int selectIndex)
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
            Refresh();
        }
        private void Refresh()
        {
            try
            {
                var query = QueryModel.GenerateQuery(new SqlConnection(ConnectionString), new FFSqlServerCompiler());

                txtScript.Text = new FFSqlServerCompiler().Compile(query).Sql;

                queryResult = query.Get();

                var d = queryResult.First();
                columnNames = ((IDictionary<string, object>)d).Keys.ToArray();
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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            LoadChart();
        }


        private void startTableConfig_Changed(object sender, EventArgs e)
        {
            var startTableConfig = (StartTableConfig)sender;
            this.QueryModel.StartTable = startTableConfig.Table;
            SetUsedTables();
            Refresh();
        }
        private void filterConfigTable_Changed(object sender, EventArgs e)
        {
            this.QueryModel.WhereExpression = filterConfigTable.WhereExpression;
            Refresh();
        }
        private void selectConfig_Changed(object sender, EventArgs e)
        {
            this.QueryModel.SelectFields = selectFieldsConfig.SelectedFields;
            Refresh();
        }
        private void SetUsedTables()
        {
            List<NameAlias> usedTables = UsedTables();
            foreach (var control in tlpQueryBuilderFlow.Controls)
            {
                if (control is JoinTableConfig config) config.UsedTables = usedTables;
            }

            sortConfig.UsedTables = usedTables;
            filterConfigTable.UsedTables = usedTables;
            selectFieldsConfig.UsedTables = usedTables;
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

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            refreshChart();
        }

        private void refreshChart()
        {
            return;
            try
            {
                List<ChartModel> data = new List<ChartModel>();

                foreach (var o in queryResult)
                {
                    var item = (IDictionary<string, object>)o;
                    data.Add(new ChartModel()
                    {
                        Title = item[cmbXValueMember.SelectedItem.ToString()]?.ToString() ?? String.Empty,
                        Value = Convert.ToInt32(item[cmbYValueMember.SelectedItem.ToString()])
                    });
                }

                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.ChartAreas.Add(new ChartArea());
                chart1.DataSource = data;
                chart1.Series.Add("Series1");
                chart1.Series["Series1"].XValueMember = nameof(ChartModel.Title);
                chart1.Series["Series1"].YValueMembers = nameof(ChartModel.Value);
                chart1.Series["Series1"].ChartType = (SeriesChartType)cmbChartTypes.SelectedItem;
                chart1.BackColor = Color.WhiteSmoke;
                chart1.Series["Series1"].Color = Color.DodgerBlue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void LoadChart()
        {
            if (cmbChartTypes.Items.Count < 1)
            {
                cmbChartTypes.Items.Add(SeriesChartType.Pie);
                cmbChartTypes.Items.Add(SeriesChartType.Bar);
                cmbChartTypes.SelectedIndex = 0;
            }
            cmbXValueMember.Items.Clear();
            cmbYValueMember.Items.Clear();
            foreach (var columnName in columnNames)
            {
                cmbXValueMember.Items.Add(columnName);
                cmbYValueMember.Items.Add(columnName);
            }

            cmbXValueMember.SelectedIndex = 0;
            cmbYValueMember.SelectedIndex = Math.Min(columnNames.Length - 1, 1);
            if (columnNames.Length >= 2)
            {
                refreshChart();
            }

        }

        private void sortConfig_Changed(object sender, EventArgs e)
        {
            this.QueryModel.SortFields = sortConfig.OrderByFields;
            Refresh();
        }


    }
}
