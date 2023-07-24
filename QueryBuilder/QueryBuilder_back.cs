using QueryBuilder.DatabaseSchema;
using SqlKata;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using SqlKata.Compilers;

namespace QueryBuildersSample
{
    public partial class QueryBuilder_back : UserControl, ISource
    {
        public string DbType { get; set; }
        public string ConnectionString { get; set; }
        private IList<DbTableModel> tables;
        List<string> _selectedFields = new List<string>();
        public Query Query { get; set; }
        public QueryBuilder_back()
        {
            InitializeComponent();
        }

        public List<string> Fields { get; set; }
        public List<object> RecordSet { get; set; }
        public event EventHandler RecordSetFilled;

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            this.RecordSetFilled?.Invoke(sender, e);
        }

        private void btnGetDatabaseSchema_Click(object sender, EventArgs e)
        {
            IDataSchema dataSchema = new DataSchemaWithDatabaseSchemaReader();
            tables = dataSchema.GetSchema(txtConnectionString.Text, null);
            cmbTables.Items.Clear();
            foreach (var tableName in tables?.Select(t => t.Name))
            {
                cmbTables.Items.Add(tableName);
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFields.Items.Clear();
            foreach (var field in tables.Where(table => table.Name == cmbTables.SelectedItem.ToString())?.FirstOrDefault()?.Fields)
            {
                cmbFields.Items.Add(field.Name);
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            txtSelectedTable.Text = cmbTables.SelectedItem.ToString();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            _selectedFields.Add(cmbFields.SelectedItem.ToString());
            dgSelectedFields.Rows.Add(cmbFields.SelectedItem.ToString());
            renderScript();
        }

        private void dgSelectedFields_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgSelectedFields.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                _selectedFields.RemoveAt(e.RowIndex - 1);
                dgSelectedFields.Rows.RemoveAt(e.RowIndex);
            }

            renderScript();
        }

        private void renderScript()
        {

            var factory = new QueryFactory(new SqlConnection(txtConnectionString.Text), new FFSqlServerCompiler());
            //var Query = factory.Query(txtSelectedTable.Text).As(txtTableAlise.Text)
            //    .Select(_selectedFields);
            string tableName = txtSelectedTable.Text;
            if (!string.IsNullOrEmpty(txtTableAlise.Text)) tableName = $"{tableName} as {txtTableAlise.Text}";
            Query = factory.Query($"{tableName}");
            if (chkJoin.Checked)
            {
                //Query.Join()
                Query = Query.Join("table", join =>
                {
                    join.On("asd", "asd");
                    return join;
                });
                Query = Query.Join("Events", $"{tableName}.RuleId", "Events.RuleId");
            }
            Query = Query.Select(_selectedFields);
            // Query = Query.Select();
            try
            {
                // txtScript.Text = Query.ToString();
                txtScript.Text = new FFSqlServerCompiler().Compile(Query).Sql;
            }
            catch (Exception)
            {
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
