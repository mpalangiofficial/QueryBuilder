namespace QueryBuilder.DatabaseSchema
{
    public class KeyValueModel
    {
        public KeyValueModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public string Key { get; private set; }
        public string Value { get; private set; }
    }
}