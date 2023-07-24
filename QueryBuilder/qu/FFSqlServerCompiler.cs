using System;
using System.Collections.Generic;
using System.Linq;

namespace SqlKata.Compilers
{
    public class FFSqlServerCompiler : SqlServerCompiler
    {


        public override string Wrap(string value)
        {
            if (value.ToLowerInvariant().Contains(" as "))
            {
                int length = value.ToLowerInvariant().IndexOf(" as ");
                string str1 = value.Substring(0, length);
                string str2 = value.Substring(length + 4);
                return this.Wrap(str1) + " " + this.ColumnAsKeyword + this.WrapValue(str2);
            }
            if (!value.Contains("."))
                return this.WrapValue(value);
            return string.Join(".", ((IEnumerable<string>)value.Split('.')).Select<string, string>((Func<string, int, string>)((x, index) => this.WrapValue(x))));
        }

        //public override string WrapValue(string value)
        //{
        //    if (value == "*")
        //        return value;
        //    string openingIdentifier = this.OpeningIdentifier;
        //    string closingIdentifier = this.ClosingIdentifier;
        //    string str1 = value.Replace(closingIdentifier, closingIdentifier + closingIdentifier);
        //    string str2 = closingIdentifier;
        //    return openingIdentifier + str1 + str2;
        //}
    }
}
