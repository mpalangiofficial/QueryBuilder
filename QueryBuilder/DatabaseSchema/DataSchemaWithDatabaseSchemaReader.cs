using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DatabaseSchemaReader;
using DatabaseSchemaReader.DataSchema;
using Newtonsoft.Json;

namespace QueryBuilder.DatabaseSchema
{
    public class DataSchemaWithDatabaseSchemaReader : IDataSchema
    {
        public IList<DbTableModel> GetSchema(string connectionString, string provider)
        {
            IList<DbTableModel> result = null;
            try
            {
                SqlType sqlType = SqlType.SqlServer;
                switch (provider)
                {
                    case "MySql.Data.MySqlClient":
                        sqlType = SqlType.MySql;
                        break;
                }
                //todo remove and replace cache or fast solution
                var connectionStringSegments = GetStringSegmentHelper.GetKeyValueList(connectionString, ';', '=');
                string dbServerName =
                    connectionStringSegments.FirstOrDefault(x => x.Key.ToLower().Contains("data source"))?.Value ??
                    string.Empty;
                dbServerName = dbServerName == "." ? "localhost" : dbServerName;
                string databaseName =
                    connectionStringSegments.FirstOrDefault(x => x.Key.ToLower().Contains("initial catalog"))?.Value ??
                    string.Empty;

                string cacheFilePath = dbServerName == string.Empty ? $"{Application.StartupPath}\\cachefiles\\{connectionString.Replace(" ", "").Replace(";", "")}.json" : $"{Application.StartupPath}\\cachefiles\\{dbServerName}-{databaseName}.json";

                if (File.Exists(cacheFilePath))
                {
                    var jsonFromFile = File.ReadAllText(cacheFilePath);

                    result = JsonConvert.DeserializeObject<IList<DbTableModel>>(jsonFromFile);
                }
                else
                {

                    var databaseReader = new DatabaseReader(connectionString, sqlType);
                    databaseReader.CommandTimeout = 0;
                    //var databaseReader = new DatabaseReader(connectionString, provider);
                    DatabaseSchemaReader.DataSchema.DatabaseSchema schema = databaseReader.ReadAll();
                    result = schema.Map();

                    string cacheValue = JsonConvert.SerializeObject(result);
                    File.WriteAllText(cacheFilePath, cacheValue);
                }
            }
            catch (System.Exception exception)
            {
                //ErrorLogger.ErrorLog(string.Empty, 8100, exception.Message);
            }
            return result;
        }
    }
}