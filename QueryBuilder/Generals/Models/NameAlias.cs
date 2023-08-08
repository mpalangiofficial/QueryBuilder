namespace QueryBuilder
{
    public class NameAlias:IClone<NameAlias>
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool HasAlias => !string.IsNullOrEmpty(Alias);
        public NameAlias ShallowCopy()=> new NameAlias() { Name = this.Name, Alias = this.Alias };

        public override string ToString() => string.IsNullOrEmpty(Alias) ? $"{Name}" : $"{Name} as {Alias}";
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as NameAlias;
            return eObj.Name == this.Name && eObj.Alias == this.Alias;
        }
    }
}