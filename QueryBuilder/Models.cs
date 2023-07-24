using System;
using System.Collections.Generic;
using SqlKata;

namespace QueryBuilder
{
    public abstract class BaseWhere
    {
        public Guid RuleId { get; set; }
        public abstract Query FilterExpression(Query query);
    }

    public class SimpleWhere : BaseWhere
    {
        public NameAlias Field { get; set; }
        public string Operation { get; set; }
        public object ExpectedValue { get; set; }

        public override Query FilterExpression(Query query)
        {
            return query.Where(Field.Name, Operation, ExpectedValue);
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
    public class Models
    {
    }
    public class NameAlias
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public override string ToString() => string.IsNullOrEmpty(Alias) ? $"{Name}" : $"{Name} as {Alias}";
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as NameAlias;
            return eObj.Name == this.Name && eObj.Alias == this.Alias;
        }
    }
    public class StartTable
    {
        public NameAlias Table { get; set; }
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


        //void asdf()
        //{
        //    var query = new Query("table1")
        //        .Join("table2", join =>
        //        {
        //            join.On("table1.field1", "table2.field1");
        //            join.On("table1.field2", "table2.field2");
        //            return join;
        //        })
        //        .Select("table1.*", "table2.*");
        //}
    }
    public class QueryModel
    {
        public NameAlias StartTable { get; set; }
        public List<Join> Joins { get; set; }
        public BaseWhere Where { get; set; }
    }
}
