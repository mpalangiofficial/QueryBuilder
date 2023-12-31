﻿using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace QueryBuilder.Controls.Models
{
    public class QueryModel
    {
        public NameAlias StartTable { get; set; }
        public List<Join> Joins { get; set; }
        public BaseWhereExpression WhereExpression { get; set; }
        public List<SelectField> SelectFields { get; set; }
        public List<OrderByField> SortFields { get; set; }
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

            if (this.WhereExpression != null)
            {
                query.Where(this.WhereExpression.FilterExpression);
            }


            if (SelectFields?.Count > 0)
                query
                    .NoFormulaNoAggregateSelectedFieldsHandle(this.SelectFields)
                    .NoFormulaAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaNotUsedOtherFieldNoAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaUsedOtherFieldNoAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaNotUsedOtherFieldAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaUsedOtherFieldAggregateSelectedFieldsHandle(this.SelectFields)
                    .FormulaAggUsedOtherFieldAggregateSelectedFieldsHandle(this.SelectFields)
                    .GroupByHandler(this.SelectFields);

            if (this.SortFields?.Count > 0) { query.OrderByHandler(this.SortFields); }

            return query;
        }
    }
}
