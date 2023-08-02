using System.Collections.Generic;

namespace QueryBuilder
{
    public class Join
    {
        public NameAlias Table { get; set; }
        public List<JoinOn> JoinOns { get; set; }
        public string JoinType { get; set; }
        public static Join GetEmpty() => new Join() { JoinOns = new List<JoinOn>() };
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as Join;
            return eObj.Table == this.Table && eObj.JoinType == this.JoinType && eObj.JoinOns == this.JoinOns;
        }
    }
}