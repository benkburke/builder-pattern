using System.Collections.Generic;
using System.Linq;
using BuilderPattern.Domain;

namespace BuilderPattern.Util
{
    public static class DictionarySerialize
    {
        public static string Parts(Dictionary<Part, int> dict)
        {
            var parts = dict.Select(d => string.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));

            return "{" + string.Join(",", parts) + "}";
        }

        public static string Parts(Dictionary<Part, decimal> dict)
        {
            var parts = dict.Select(d => string.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));

            return "{" + string.Join(",", parts) + "}";
        }
    }
}
