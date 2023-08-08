using QueryBuilder.Models;

namespace QueryBuilder
{
    public class SelectField
    {
        public NameAlias TableName { get; set; }
        public NameAlias FieldName { get; set; }
        public NameAlias OtherTableName { get; set; }
        public NameAlias OtherFieldName { get; set; }
        public bool IsFormulaField { get; set; }
        public bool HasFunction { get; set; }
        public AggregationFunction Function { get; set; }
        public bool IsTempField { get; set; }
        public bool UsedOtherField { get; set; }
        public SelectField OtherField { get; set; }
        public Operator Operator { get; set; }
        public string Alias { get; set; }
        public override string ToString()
        {
            var result = string.Empty;
            result = GetFieldRaw();

            if (this.HasFunction)
            {
                result = $"{this.Function.Name}({result})";
            }

            return result;
        }
        public string GetFieldRaw()
        {
            string result;
            string tableName = this.TableName.HasAlias ? this.TableName.Alias : this.TableName.Name;
            if (this.IsFormulaField)
            {
                if (this.UsedOtherField)
                {
                    result = $"[{tableName}].[{this.FieldName.Name}] {Operator.ToString()}( {this.OtherField.GetFieldRaw()}) ";
                }
                else
                {
                    string OtherTableName = this.OtherTableName.HasAlias ? this.OtherTableName.Alias : this.OtherTableName.Name;
                    result = $"[{tableName}].[{this.FieldName.Name}] {Operator.ToString()} [{OtherTableName}].[{OtherFieldName.Name}] ";
                }
            }
            else
            {
                result = $"{tableName}.{this.FieldName.Name}";
            }

            return result;
        }

        public NameAlias Name => new NameAlias() { Name = this.ToString(), Alias = this.Alias };
    }
}