using System.Collections.Generic;

namespace QueryBuilder
{
    public class Operator
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool IsReverse { get; set; }
        public static Operator Addition => new Operator() { Name = "Addition", Symbol = "+", IsReverse = false };
        public static Operator Subtraction => new Operator() { Name = "Subtraction", Symbol = "-", IsReverse = false };
        public static Operator Multiplication => new Operator() { Name = "Multiplication", Symbol = "*", IsReverse = false };
        public static Operator Division => new Operator() { Name = "Division", Symbol = "/", IsReverse = false };
        public static Operator ReverseSubtraction => new Operator() { Name = "ReverseSubtraction", Symbol = "!-", IsReverse = true };
        public static Operator ReverseDivision => new Operator() { Name = "ReverseDivision", Symbol = "!/",IsReverse = true};
        public static List<Operator> Operators => new List<Operator>() { Multiplication, Addition, Subtraction, Division,ReverseSubtraction,ReverseDivision };
        public override string ToString() => Symbol.Replace("!","");

    }
}