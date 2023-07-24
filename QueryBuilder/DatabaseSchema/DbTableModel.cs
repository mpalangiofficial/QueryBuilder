using System.Collections.Generic;

namespace QueryBuilder.DatabaseSchema
{
    public class DbTableModel
    {
        public string Name { get; set; }
        public IList<DbFieldModel> Fields { get; set; }
    }
}