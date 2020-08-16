using PromotionEngine.Contracts.Models;
using System.Collections.Generic;

namespace PromotionEngine.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
