namespace QueryBuilder
{
    public class JoinOn
    {
        public NameAlias LeftTable { get; set; }
        public NameAlias RightTable { get; set; }
        public NameAlias LeftField { get; set; }
        public NameAlias RightField { get; set; }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as JoinOn;
            return this.LeftTable.Equals(eObj.LeftTable) && this.LeftField.Equals(eObj.LeftField) &&
                   this.RightTable.Equals(eObj.RightTable) && this.RightField.Equals(eObj.RightField);
        }

    }
}