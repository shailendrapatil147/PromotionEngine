using PromotionEngine.Contracts.Models;
using PromotionEngine.Repository.Factory;
using PromotionEngine.Repository.IFactory;
using System.Collections.Generic;

namespace PromotionEngine.Managers
{
    public class OrderManager
    {
        private IRepositoryFactory RepositoryFactory { get; set; }
        private PriceManager PriceManager { get; set; }

        public OrderManager()
        {
            RepositoryFactory = new RepositoryFactory();
            PriceManager = new PriceManager();
        }

        public double PlaceOrder(List<Product> OrderedProducts)
        {
            var cart = RepositoryFactory.CartRepository.CreateCart(OrderedProducts);
            PriceManager.CalculatePrice(cart.Products);

            return cart.CartPrice;
        }
    }
}
