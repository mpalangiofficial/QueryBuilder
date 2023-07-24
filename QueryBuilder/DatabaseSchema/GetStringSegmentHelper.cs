using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryBuilder.DatabaseSchema
{
    public static class GetStringSegmentHelper
    {
        public static IList<KeyValueModel> GetKeyValueList(string text, char segmentSeparator, char keyValueSeparator)
        {
            IList<KeyValueModel> result = new List<KeyValueModel>();
            try
            {
                foreach (string s in GetStringSegment(text, segmentSeparator))
                {
                    var keyVaule = s.Split(keyValueSeparator);
                    if (keyVaule is null || string.IsNullOrEmpty(keyVaule[0]) || string.IsNullOrEmpty(keyVaule[1])) break;
                    result.Add(new KeyValueModel(keyVaule[0], keyVaule[1] ?? ""));
                }
            }
            catch (Exception)
            {
                // todo fix error
                // throw;
            }
            return result;
        }

        private static IList<string> GetStringSegment(string text, char segmentSeparator)
        {
            return text.Split(segmentSeparator).ToList<string>();
        }
    }
}