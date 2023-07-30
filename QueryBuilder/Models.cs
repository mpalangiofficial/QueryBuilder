
using SqlKata;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SqlKata.Execution;

namespace QueryBuilder
{
    public class ChartModel
    {
        public string Title { get; set; }
        public int Value { get; set; }
    }

    public abstract class BaseWhere
    {
        public Guid RuleId { get; set; }
        public abstract Query FilterExpression(Query query);
    }

    public class SimpleWhere : BaseWhere
    {
        public NameAlias Table { get; set; }
        public NameAlias Field { get; set; }
        public WhereOperation Operation { get; set; }
        public object ExpectedValue { get; set; }

        public override Query FilterExpression(Query query)
        {
            Query result = null;
            var tableName = string.IsNullOrEmpty(Table.Alias) ? Table.Name : Table.Alias;
            switch (Operation)
            {
                case WhereOperation.Equal:
                    result = query.Where($"{tableName}.{Field.Name}", "=", ExpectedValue);
                    break;
                case WhereOperation.Notequal:
                    result = query.Where($"{tableName}.{Field.Name}", "<>", ExpectedValue);
                    break;
                case WhereOperation.More:
                    result = query.Where($"{tableName}.{Field.Name}", ">", ExpectedValue);
                    break;
                case WhereOperation.Less:
                    result = query.Where($"{tableName}.{Field.Name}", "<", ExpectedValue);
                    break;
                case WhereOperation.MoreAndEqual:
                    result = query.Where($"{tableName}.{Field.Name}", ">=", ExpectedValue);
                    break;
                case WhereOperation.LessAndEqual:
                    result = query.Where($"{tableName}.{Field.Name}", "<=", ExpectedValue);
                    break;
                case WhereOperation.StartWith:
                    result = query.WhereLike($"{tableName}.{Field.Name}", $"{ExpectedValue}%");
                    break;
                case WhereOperation.EndWith:
                    result = query.WhereLike($"{tableName}.{Field.Name}", $"%{ExpectedValue}");
                    break;
                case WhereOperation.Contain:
                    result = query.WhereLike($"{tableName}.{Field.Name}", $"%{ExpectedValue}%");
                    break;
                case WhereOperation.IsNull:
                    result = query.WhereNull($"{tableName}.{Field.Name}");
                    break;
                case WhereOperation.IsNotNull:
                    result = query.WhereNotNull($"{tableName}.{Field.Name}");
                    break;

            }
            return result;
        }
    }
    public class LogicalWhere : BaseWhere
    {
        public List<BaseWhere> WhereRules { get; set; }
        public OperationLogical OperationLogical { get; set; }
        public override Query FilterExpression(Query query)
        {
            if (WhereRules?.Count > 0)
            {
                if (OperationLogical == OperationLogical.And)
                    WhereRules.ForEach(wc => query.Where(wc.FilterExpression));
                else
                    WhereRules.ForEach(wc => query.Or().Where(wc.FilterExpression));
            }
            return query;
        }
    }
    public enum OperationLogical
    {
        Or = 0,
        And = 1
    }
    public class NameAlias
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool HasAlias => !string.IsNullOrEmpty(Alias);
        public override string ToString() => string.IsNullOrEmpty(Alias) ? $"{Name}" : $"{Name} as {Alias}";
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as NameAlias;
            return eObj.Name == this.Name && eObj.Alias == this.Alias;
        }

        public NameAlias DeepCopy() => new NameAlias() { Name = this.Name, Alias = this.Alias };
    }
    public class Join
    {
        public NameAlias Table { get; set; }
        public List<JoinOn> JoinOns { get; set; }
        public string JoinType { get; set; }
        public static Join GetEmpty() => new Join() { JoinOns = new List<JoinOn>() };
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as Join;
            return eObj.Table == this.Table && eObj.JoinType == this.JoinType && eObj.JoinOns == this.JoinOns;
        }
    }
    public class JoinOn
    {
        public NameAlias LeftTable { get; set; }
        public NameAlias RightTable { get; set; }
        public NameAlias LeftField { get; set; }
        public NameAlias RightField { get; set; }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as JoinOn;
            return this.LeftTable.Equals(eObj.LeftTable) && this.LeftField.Equals(eObj.LeftField) &&
                   this.RightTable.Equals(eObj.RightTable) && this.RightField.Equals(eObj.RightField);
        }

    }
    public class FunctionField
    {
        public string Function { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public override string ToString()
        {
            var segment = Name.Split('.');
            var name = $"[{segment[0]}].{segment[1]}";
            return string.IsNullOrEmpty(Alias) ? $"{Function}({name})" : $"{Function}({name}) as {Alias}";
        }

        public FunctionField DeepCopy() => new FunctionField()
        {
            Function = this.Function,
            Name = this.Name,
            Alias = this.Alias
        };
    }

    public class AggregationFunction
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public static AggregationFunction Count => new AggregationFunction() { Name = "Count" };
        public static AggregationFunction Sum => new AggregationFunction() { Name = "Sum" };
        public static AggregationFunction Max => new AggregationFunction() { Name = "Max" };
        public static AggregationFunction Min => new AggregationFunction() { Name = "Min" };
        public static AggregationFunction Avg => new AggregationFunction() { Name = "Avg" };
        public static List< AggregationFunction> Functions => new List<AggregationFunction>() { Count,Sum,Max,Min,Avg };
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as AggregationFunction;
            return this.Name.Equals(eObj.Name);
        }
    }

    public class OrderByField
    {
        public string Field { get; set; }
        public OrderByType OrderByType { get; set; }
    }
    public enum OrderByType
    {
        Asc = 0,
        Desc = 1
    }

    public class SelectField
    {
        public NameAlias TableName { get; set; }
        public NameAlias FieldName { get; set; }
        public NameAlias OtherTableName { get; set; }
        public NameAlias OtherFieldName { get; set; }
        public bool HasFunction { get; set; }
        public AggregationFunction Function { get; set; }
        public bool IsTempField { get; set; }
        public bool UsedOtherField { get; set; }
        public SelectField OtherField { get; set; }
        public Operator Operator{ get; set; }
        public string Alias { get; set; }
        public override string ToString()
        {
            var result = string.Empty;
            if (this.HasFunction)
            {
            }
            else
            {
                string tableName = this.TableName.HasAlias ? this.TableName.Alias : this.TableName.Name;
                result = $"{tableName}.{this.FieldName.Name}";
            }

            return result;
        }
    }

    public class Operator
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public static Operator Sum => new Operator() { Name = "Sum", Symbol = "+" };
        public static Operator Mines => new Operator() { Name = "Mines", Symbol = "-" };
        public static Operator Multiple => new Operator() { Name = "Multiple", Symbol = "*" };
        public static Operator Divid => new Operator() { Name = "Divid", Symbol = "/" };
        public static List<Operator> Operators => new List<Operator>() { Multiple, Sum, Mines, Divid };
        public override string ToString() => Symbol;

    }

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

            if (this.SelectFields != null && this.SelectFields.Where(sf => !(sf.IsTempField || sf.HasFunction)).ToList().Count > 0)
            {
                
                var fields = this.SelectFields.Where(sf=>!(sf.IsTempField || sf.HasFunction)).Select(f => f.ToString()).ToArray();
                query.Select(fields);
            }

            if (this.SelectFields != null && this.SelectFields.Where(sf=>!sf.IsTempField && sf.HasFunction).ToList().Count > 0)
            {
                foreach (var selectedFunctionField in this.SelectFields.Where(sf => !sf.IsTempField && sf.HasFunction).ToList())
                {
                    string tableName = string.IsNullOrEmpty(selectedFunctionField.TableName.Alias)
                        ? selectedFunctionField.TableName.Name
                        : selectedFunctionField.TableName.Alias;
                    query.SelectRaw($"{selectedFunctionField.Function.ToString()}([{tableName}].[{selectedFunctionField.FieldName.Name}])");
                    //query.SelectRaw(selectedFunctionField.ToString());
                }
                if (this.SelectFields != null && this.SelectFields.Where(sf => !(sf.IsTempField || sf.HasFunction)).ToList().Count > 0)
                {
                    this.SelectFields.Where(sf => !(sf.IsTempField || sf.HasFunction)).ToList().ForEach(sf => query.GroupBy(sf.FieldName.Name));
                }
            }

            return query;
        }
    }
}
