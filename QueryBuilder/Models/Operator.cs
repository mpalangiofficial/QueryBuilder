using System.Collections.Generic;

namespace QueryBuilder
{
    public class Operator
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public static Operator Sum => new Operator() { Name = "Sum", Symbol = "+" };
        public static Operator Mines => new Operator() { Name = "Mines", Symbol = "-" };
        public static Operator Multiple => new Operator() { Name = "Multiple", Symbol = "*" };
        public static Operator Divid => new Operator() { Name = "Divid", Symbol = "/" };
        public static List<Operator> Operators => new List<Operator>() { Multiple, Sum, Mines, Divid };
        public override string ToString() => Symbol;

    }
}