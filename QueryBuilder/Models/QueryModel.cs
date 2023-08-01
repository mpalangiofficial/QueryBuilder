
using SqlKata;
using SqlKata.Compilers;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using SqlKata.Execution;

namespace QueryBuilder
{
    public class QueryModel
    {
        public NameAlias StartTable { get; set; }
        public List<Join> Joins { get; set; }
        public BaseWhere Where { get; set; }
        public List<SelectField> SelectFields { get; set; }
        public Query GenerateQuery(IDbConnection connection, Compiler compiler)
        {
            var factory = new QueryFactory(connection, compiler);
            Query query = factory.Query(this.StartTable.ToString());

            if (this.Joins.Count > 0)
            {
                foreach (var join in this.Joins)
                {
                    SqlKata.Join joinQuery = new SqlKata.Join();
                    foreach (var joinOn in join.JoinOns)
                    {
                        var leftTableNameOrAlias = string.IsNullOrEmpty(joinOn.LeftTable.Alias)
                            ? joinOn.LeftTable.Name
                            : joinOn.LeftTable.Alias;
                        var rightTableNameOrAlias = string.IsNullOrEmpty(joinOn.RightTable.Alias)
                            ? joinOn.RightTable.Name
                            : joinOn.RightTable.Alias;
                        joinQuery.On($"{leftTableNameOrAlias}.{joinOn.LeftField.Name}", $"{rightTableNameOrAlias}.{joinOn.RightField.Name}", op: "=");
                    }
                    query = query.Join(join.Table.ToString(), j => joinQuery);
                }
            }

            if (this.Where != null)
            {
                query.Where(this.Where.FilterExpression);
            }


            if (SelectFields?.Count > 0)
                query
                    .NoFormulaNoAggregateSelectedFieldsHandle(this.SelectFields)
                    .NoFormulaAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaNotUsedOtherFieldNoAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaUsedOtherFieldNoAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaNotUsedOtherFieldAggregateSelectedFieldsHandle(this.SelectFields);




            bool hasGroupBy = SelectFields?.Any(sf => sf.HasFunction) ?? false;
            var groupByFields = SelectFields?.Where(sf => hasGroupBy && !sf.HasFunction).ToList();
            if (groupByFields != null && groupByFields.Count > 0)
            {
                foreach (var sf in groupByFields)
                {
                    string tableName = sf.TableName.HasAlias
                        ? sf.TableName.Alias
                        : sf.TableName.Name;
                    if (sf.IsFormulaField)
                    {
                        string otherTableName;
                        if (sf.UsedOtherField)
                        {
                            if (sf.OtherField.IsFormulaField)
                            {
                            }
                            else
                            {
                                otherTableName = sf.OtherField.TableName.HasAlias
                                    ? sf.OtherField.TableName.Alias
                                    : sf.OtherField.TableName.Name;
                                query.GroupByRaw(
                                    $"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} [{otherTableName}].[{sf.OtherField.FieldName.Name}]) ");
                            }
                        }
                        else
                        {
                            otherTableName = sf.OtherTableName.HasAlias
                                ? sf.OtherTableName.Alias
                                : sf.OtherTableName.Name;
                            query.GroupByRaw(
                                $"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} [{otherTableName}].[{sf.OtherFieldName.Name}]) ");
                        }
                    }
                    else
                    {
                        query.GroupBy($"{tableName}.{sf.FieldName.Name}");
                    }
                }

            }
            return query;
        }
    }
}
