namespace QueryBuilder
{
    public class FunctionField
    {
        public string Function { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public override string ToString()
        {
            var segment = Name.Split('.');
            var name = $"[{segment[0]}].{segment[1]}";
            return string.IsNullOrEmpty(Alias) ? $"{Function}({name})" : $"{Function}({name}) as {Alias}";
        }

        public FunctionField DeepCopy() => new FunctionField()
        {
            Function = this.Function,
            Name = this.Name,
            Alias = this.Alias
        };
    }
}