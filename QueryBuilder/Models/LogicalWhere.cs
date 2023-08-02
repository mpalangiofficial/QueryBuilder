using System.Collections.Generic;
using SqlKata;

namespace QueryBuilder
{
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
}