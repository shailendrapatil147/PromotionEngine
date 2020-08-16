using PromotionEngine.Contracts.Models;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Repository
{
    public class CartRepository : ICartRepository
    {
        IProductRepository ProductRepository { get; set; }
        public CartRepository()
        {
            ProductRepository = new ProductRepository();
        }

        public Cart CreateCart(List<Product> OrderedProducts)
        {
            List<Product> products = new List<Product>();
            var allProducts = ProductRepository.GetAllProducts();

            OrderedProducts.ForEach(product =>
            {
                var metaProduct = allProducts.Where(p => p.Name.Equals(product.Name)).FirstOrDefault();
                if (metaProduct != null)
                {
                    products.Add(new Product
                    {
                        Id = metaProduct.Id,
                        Name = metaProduct.Name,
                        PricePerUnit = metaProduct.PricePerUnit,
                        TotalUnit = product.TotalUnit,
                        TotalPrice = 0,
                    });
                }
            });
            
            Cart cart = new Cart() { Products = products };

            return cart;
        }
    }
}
