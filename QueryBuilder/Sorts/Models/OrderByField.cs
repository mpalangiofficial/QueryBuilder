namespace QueryBuilder
{
    public class OrderByField
    {
        public NameAlias TableName { get; set; }
        public string FieldName { get; set; }
        public OrderByType OrderByType { get; set; }
        public override string ToString() => $"{GetOrderByString()} {OrderByType.ToString()}";
        public string GetOrderByString()
        {
            var tableName = TableName.HasAlias ? TableName.Alias : TableName.Name;
            var result = $"{ tableName}.{FieldName}";
            return result;
        }
    }
}