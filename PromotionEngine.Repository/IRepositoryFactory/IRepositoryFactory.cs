namespace PromotionEngine.Repository.IFactory
{
    public interface IRepositoryFactory
    {
        IProductRepository ProductRepository { get; set;}
        IOfferRepository OfferRepository { get; set;}
        ICartRepository CartRepository { get; set; }
    }
}
