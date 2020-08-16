using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Contracts.Models
{
    public class Cart
    {
        public List<Product> Products { get; set; }

        public double CartPrice
        {
            get { return Products.Sum(p => p.TotalPrice); }
        }
    }
}
