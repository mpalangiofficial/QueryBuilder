namespace QueryBuilder
{
    public class OrderByField:IClone<OrderByField>
    {
        public NameAlias TableName { get; set; }
        public string FieldName { get; set; }
        public OrderByType OrderByType { get; set; }
        public OrderByField ShallowCopy() => new OrderByField()
        {
            TableName = this.TableName.ShallowCopy(),
            FieldName = this.FieldName,
            OrderByType = this.OrderByType
        };
        

        public override string ToString() => $"{GetOrderByString()} {OrderByType.ToString()}";
        public string GetOrderByString()
        {
            var tableName = TableName.HasAlias ? TableName.Alias : TableName.Name;
            var result = $"{ tableName}.{FieldName}";
            return result;
        }
    }
}