namespace QueryBuilder.DatabaseSchema
{
    public class DbFieldModel 
    {
        public string Name { get; set; }
        public string DatabaseType { get; set; }
        public string Type { get; set; }
        public string TableName { get; set; }
        public bool IsUnique { get; set; }
        public bool IsIdentity { get; set; }
        public DbFieldModel DeepCopy() => new DbFieldModel()
        {
            Name = this.Name,
            DatabaseType = this.DatabaseType,
            Type = this.Type,
            IsUnique = this.IsUnique,
            IsIdentity = this.IsIdentity,
            TableName = this.TableName
        };
        public override string ToString()
        {
            return $"[{TableName}].[{Name}]:{Type}";
        }
        public static DbFieldModel NoneField => new DbFieldModel() { Name = "select field", Type = null, TableName = null, IsUnique = false, DatabaseType = null, IsIdentity = false };
    }
}