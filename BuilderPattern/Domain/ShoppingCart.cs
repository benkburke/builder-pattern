using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.Domain
{
    public class ShoppingCart
    {
        // List of parts and their cost
        public Dictionary<Part, decimal> Parts = new Dictionary<Part, decimal>();

        public decimal TotalPrice => Parts.Sum(x => x.Value);
    }
}
