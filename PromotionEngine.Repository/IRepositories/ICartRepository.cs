using PromotionEngine.Contracts.Models;
using System.Collections.Generic;

namespace PromotionEngine.Repository
{
    public interface ICartRepository
    {
        Cart CreateCart(List<Product> OrderedProducts);
    }
}
