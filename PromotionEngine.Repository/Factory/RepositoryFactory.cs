using PromotionEngine.Repository.IFactory;

namespace PromotionEngine.Repository.Factory
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IProductRepository ProductRepository { get; set; }
        public IOfferRepository OfferRepository { get; set; }
        public ICartRepository CartRepository { get; set; }

        public RepositoryFactory()
        {
            ProductRepository = new ProductRepository();
            OfferRepository = new OfferRepository();
            CartRepository = new CartRepository();
        }
    }
}
