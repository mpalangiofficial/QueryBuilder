using System.Collections.Generic;

namespace QueryBuilder.DatabaseSchema
{
    public interface IDataSchema
    {
        IList<DbTableModel> GetSchema(string connectionString, string provider);
    }
}
