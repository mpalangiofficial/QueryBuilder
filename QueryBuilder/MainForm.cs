using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QueryBuilder;
using QueryBuilder.Controls.Models;

namespace QueryBuildersSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void queryBuilder1_DataFetched(object sender, EventArgs e)
        {
            MessageBox.Show("data fetched");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.queryBuilder.SetQueryModel(new QueryModel() { Joins = new List<Join>() });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var json = JsonConvert.SerializeObject(queryBuilder.QueryModel);
            File.WriteAllText("d:/querymodel.json", json);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText("d:/querymodel.json");
            var queryModel = JsonConvert.DeserializeObject<QueryModel>(json, new WhereExpressionConverter());
            this.queryBuilder.SetQueryModel(queryModel);
        }
    }

    public class WhereExpressionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(BaseWhereExpression);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            JObject jsonObject = JObject.Load(reader);
            BaseWhereExpression whereExpression;
            string type = jsonObject["Type"].ToObject<string>();
            switch (type)
            {
                case "SimpleWhereExpression":
                    whereExpression = new SimpleWhereExpression();
                    break;
                case "LogicalWhereExpression":
                    whereExpression = new LogicalWhereExpression();
                    break;
                default:
                    throw new Exception("Unknown whereExpression type");
            }

            serializer.Populate(jsonObject.CreateReader(), whereExpression);
            return whereExpression;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
