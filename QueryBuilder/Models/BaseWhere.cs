using System;
using SqlKata;

namespace QueryBuilder
{
    public abstract class BaseWhere
    {
        public Guid RuleId { get; set; }
        public abstract Query FilterExpression(Query query);
    }
}