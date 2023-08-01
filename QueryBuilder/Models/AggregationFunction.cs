using System.Collections.Generic;

namespace QueryBuilder.Models
{
    public class AggregationFunction
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public static AggregationFunction Count => new AggregationFunction() { Name = "Count" };
        public static AggregationFunction Sum => new AggregationFunction() { Name = "Sum" };
        public static AggregationFunction Max => new AggregationFunction() { Name = "Max" };
        public static AggregationFunction Min => new AggregationFunction() { Name = "Min" };
        public static AggregationFunction Avg => new AggregationFunction() { Name = "Avg" };
        public static List<AggregationFunction> Functions => new List<AggregationFunction>() { Count, Sum, Max, Min, Avg };
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var eObj = obj as AggregationFunction;
            return this.Name.Equals(eObj.Name);
        }
    }
}