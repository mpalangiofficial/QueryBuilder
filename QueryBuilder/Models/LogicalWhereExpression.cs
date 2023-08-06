using System.Collections.Generic;
using System.Linq;
using SqlKata;

namespace QueryBuilder
{
    public class LogicalWhereExpression : BaseWhereExpression
    {
        public List<BaseWhereExpression> WhereRules { get; set; }
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

        public override BaseWhereExpression ShallowCopy() => new LogicalWhereExpression()
        {
            OperationLogical = this.OperationLogical,
            WhereRules = this.WhereRules?.Select(wr=>wr.ShallowCopy()).ToList()
        };

    }
}