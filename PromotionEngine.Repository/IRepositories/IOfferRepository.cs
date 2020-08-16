using PromotionEngine.Contracts.Models;
using System.Collections.Generic;

namespace PromotionEngine.Repository
{
    public interface IOfferRepository
    {
        List<Offer> GetAllOffers();
    }
}
