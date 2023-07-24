using System.Collections.Generic;
using System.Linq;
using DatabaseSchemaReader.DataSchema;

namespace QueryBuilder.DatabaseSchema
{
    public static class DbTableMappers
    {
        public static IList<DbTableModel> Map(this DatabaseSchemaReader.DataSchema.DatabaseSchema databaseSchema) =>
            databaseSchema.Tables.Select(Map).ToList();


        private static DbTableModel Map(this DatabaseTable table) => new DbTableModel()
        {
            Name = table.Name,
            Fields = table.Columns.Select(Map).ToList()
        };

        private static DbFieldModel Map(this DatabaseColumn column) => new DbFieldModel
        {
            DatabaseType = column.DbDataType,
            Type = column.DataType?.NetDataType,
            Name = column.Name,
            TableName = column.TableName,
            IsUnique = column.IsUniqueKey || column.IsPrimaryKey,
            IsIdentity = column.IsAutoNumber
        };

    }
}