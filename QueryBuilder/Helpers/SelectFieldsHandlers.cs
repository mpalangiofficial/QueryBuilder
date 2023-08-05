using System.Collections.Generic;
using System.Linq;
using SqlKata;

namespace QueryBuilder
{
    public static class SelectFieldsHandlers
    {
        public static Query NoFormulaNoAggregateSelectedFieldsHandle(this Query query, List<SelectField> selectFields)
        {
            var notTempNotFormulaNotAggFields = selectFields?.Where(sf =>
                !sf.IsFormulaField &&
                !sf.IsTempField &&
                !sf.HasFunction)?.ToList();
            if (notTempNotFormulaNotAggFields?.Count > 0)
            {
                var fields = notTempNotFormulaNotAggFields.Select(f => f.Name.ToString()).ToArray();
                query.Select(fields);
            }
            return query;
        }
        public static Query NoFormulaAggregateSelectedFieldsHandle(this Query query, List<SelectField> selectFields)
        {
            var fields = selectFields?.Where(sf =>
                !sf.IsFormulaField &&
                !sf.IsTempField &&
                sf.HasFunction)?.ToList();

            if (selectFields != null && fields.Count > 0)
            {
                foreach (var selectedFunctionField in fields)
                {
                    string tableName = selectedFunctionField.TableName.HasAlias
                        ? selectedFunctionField.TableName.Alias
                        : selectedFunctionField.TableName.Name;
                    query.SelectRaw($"{selectedFunctionField.Function.ToString()}([{tableName}].[{selectedFunctionField.FieldName.Name}]) as {selectedFunctionField.Alias}");
                }

            }
            return query;
        }
        public static Query FormulaNotUsedOtherFieldNoAggregateSelectedFieldsHandle(this Query query,
            List<SelectField> selectFields)
        {
            var fields = selectFields?.Where(sf =>
                                                    !sf.IsTempField &&
                                                    sf.IsFormulaField &&
                                                    !sf.UsedOtherField &&
                                                    !sf.HasFunction)?.ToList();
            if (fields?.Count > 0)
            {
                fields.ForEach(
                    sf =>
                    {
                        string tableName = sf.TableName.HasAlias
                            ? sf.TableName.Alias
                            : sf.TableName.Name;
                        string otherTableName = sf.OtherTableName.HasAlias
                            ? sf.OtherTableName.Alias
                            : sf.OtherTableName.Name;
                        query.SelectRaw($"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} [{otherTableName}].[{sf.OtherFieldName.Name}]) as {sf.Alias}");
                    });
            }

            return query;
        }
        public static Query FormulaUsedOtherFieldNoAggregateSelectedFieldsHandle(this Query query,
            List<SelectField> selectFields)
        {
            var fields = selectFields?.Where(sf =>
                                                    !sf.IsTempField &&
                                                    sf.IsFormulaField &&
                                                    sf.UsedOtherField &&
                                                    !sf.HasFunction)?.ToList();
            if (fields?.Count > 0)
            {
                fields.ForEach(
                    sf =>
                    {
                        string tableName = sf.TableName.HasAlias
                            ? sf.TableName.Alias
                            : sf.TableName.Name;

                        query.SelectRaw($"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} ({sf.OtherField.GetFieldRaw()})) as {sf.Alias}");
                    });
            }

            return query;
        }
        public static Query FormulaNotUsedOtherFieldAggregateSelectedFieldsHandle(this Query query,
            List<SelectField> selectFields)
        {
            var formulaFunctionFields = selectFields?.Where(sf =>
                !sf.IsTempField &&
                sf.IsFormulaField &&
                !sf.UsedOtherField &&
                sf.HasFunction).ToList();
            if (formulaFunctionFields?.Count > 0)
            {
                formulaFunctionFields.ForEach(sf =>
                {
                    string tableName = sf.TableName.HasAlias
                        ? sf.TableName.Alias
                        : sf.TableName.Name;
                    string otherTableName = sf.OtherTableName.HasAlias
                        ? sf.OtherTableName.Alias
                        : sf.OtherTableName.Name;
                    query.SelectRaw($"{sf.Function.ToString()}([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} [{otherTableName}].[{sf.OtherFieldName.Name}]) as {sf.Alias}");
                });
            }

            return query;
        }
        public static Query FormulaUsedOtherFieldAggregateSelectedFieldsHandle(this Query query,
            List<SelectField> selectFields)
        {
            var formulaFunctionFields = selectFields?.Where(sf =>
                !sf.IsTempField &&
                sf.IsFormulaField &&
                sf.UsedOtherField &&
                !sf.OtherField.HasFunction &&
                sf.HasFunction).ToList();
            if (formulaFunctionFields?.Count > 0)
            {
                formulaFunctionFields.ForEach(sf =>
                {
                    string tableName = sf.TableName.HasAlias
                        ? sf.TableName.Alias
                        : sf.TableName.Name;
                    query.SelectRaw($"{sf.Function.ToString()}([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} {sf.OtherField.GetFieldRaw()}) as {sf.Alias}");
                });
            }

            return query;
        }
        public static Query FormulaAggUsedOtherFieldAggregateSelectedFieldsHandle(this Query query,
            List<SelectField> selectFields)
        {
            var formulaFunctionFields = selectFields?.Where(sf =>
                !sf.IsTempField &&
                sf.IsFormulaField &&
                sf.UsedOtherField &&
                sf.OtherField.HasFunction &&
                sf.HasFunction).ToList();
            if (formulaFunctionFields?.Count > 0)
            {
                formulaFunctionFields.ForEach(sf =>
                {
                    string tableName = sf.TableName.HasAlias
                        ? sf.TableName.Alias
                        : sf.TableName.Name;
                    string leftOperand = $"{sf.Function.ToString()}([{tableName}].[{sf.FieldName.Name}])";
                    string rightOperand = $"{sf.OtherField.Function.ToString()}({sf.OtherField.GetFieldRaw()}) ";
                    if (sf.Operator.IsReverse)
                    { query.SelectRaw($"({rightOperand} {sf.Operator.ToString()} {leftOperand})as {sf.Alias} "); }
                    else
                    { query.SelectRaw($"({leftOperand} {sf.Operator.ToString()} {rightOperand})as {sf.Alias} "); }
                });
            }

            return query;
        }
    }

    public static class GroupByHandlers
    {
        public static Query GroupByHandler(this Query query,
            List<SelectField> selectFields)
        {
            bool hasGroupBy = selectFields?.Any(sf => sf.HasFunction) ?? false;
            var groupByFields = selectFields?.Where(sf =>
                !sf.HasFunction &&
                !sf.IsTempField).ToList();
            if (hasGroupBy && groupByFields?.Count > 0)
            {
                foreach (var sf in groupByFields)
                {
                    string tableName = sf.TableName.HasAlias
                        ? sf.TableName.Alias
                        : sf.TableName.Name;
                    if (sf.IsFormulaField)
                    {
                        string otherTableName;
                        if (sf.UsedOtherField)
                        {
                            if (sf.OtherField.IsFormulaField)
                            {
                                query.GroupByRaw(
                                    $"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} ({sf.OtherField.GetFieldRaw()})) ");
                            }
                            else
                            {
                                otherTableName = sf.OtherField.TableName.HasAlias
                                    ? sf.OtherField.TableName.Alias
                                    : sf.OtherField.TableName.Name;
                                query.GroupByRaw(
                                    $"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} [{otherTableName}].[{sf.OtherField.FieldName.Name}]) ");
                            }
                        }
                        else
                        {
                            otherTableName = sf.OtherTableName.HasAlias
                                ? sf.OtherTableName.Alias
                                : sf.OtherTableName.Name;
                            query.GroupByRaw(
                                $"([{tableName}].[{sf.FieldName.Name}] {sf.Operator.ToString()} [{otherTableName}].[{sf.OtherFieldName.Name}]) ");
                        }
                    }
                    else
                    {
                        query.GroupBy($"{tableName}.{sf.FieldName.Name}");
                    }
                }

            }

            return query;
        }
    }

    public static class OrderByHandlers
    {
        public static Query OrderByHandler(this Query query, List<OrderByField> orderByFields)
        {
            foreach (var orderByField in orderByFields)
            {
                if (orderByField.OrderByType == OrderByType.Asc)
                {
                    query.OrderBy(orderByField.GetOrderByString());
                }
                else if (orderByField.OrderByType == OrderByType.Desc)
                {
                    query.OrderByDesc(orderByField.GetOrderByString());
                }
            }
            return query;
        }
    }
}