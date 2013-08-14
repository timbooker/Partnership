using System.Collections.Generic;
using System.Linq;

namespace Partnership.Framework
{
    public class ItemParser
    {
        public IEnumerable<string> GetItems(string items)
        {
            var result = items.Split(',');

            return result.Select(item => item.Trim()).ToList();
        }
    }
}