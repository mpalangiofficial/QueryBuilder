using System;
using SqlKata;

namespace QueryBuilder
{
    public abstract class BaseWhereExpression : IClone<BaseWhereExpression>
    {
        public Guid RuleId { get; set; } = Guid.NewGuid();
        public abstract Query FilterExpression(Query query);
        public abstract BaseWhereExpression ShallowCopy();
    }

    public interface IClone<out T> where T : class
    {
        T ShallowCopy();
    }
}