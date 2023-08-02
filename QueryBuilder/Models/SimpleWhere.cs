﻿using SqlKata;

namespace QueryBuilder
{
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
}