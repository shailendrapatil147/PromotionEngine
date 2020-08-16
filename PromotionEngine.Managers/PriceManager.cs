using PromotionEngine.Contracts.Models;
using PromotionEngine.Repository.Factory;
using PromotionEngine.Repository.IFactory;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Managers
{
    public class PriceManager
    {
        private IRepositoryFactory RepositoryFactory { get; set; }

        public PriceManager()
        {
            RepositoryFactory = new RepositoryFactory();
        }
        public void CalculatePrice(List<Product> Products)
        {
            var offers = RepositoryFactory.OfferRepository.GetAllOffers();
            Products.ForEach(product =>
            {
                var singleOffer = offers.Where(o => !o.IsCombinedWithOtherProduct && o.ProductName.Equals(product.Name)).FirstOrDefault();
                var combinedOffer = offers.Where(o => o.IsCombinedWithOtherProduct && o.CombinedProductNames.Contains(product.Name)).FirstOrDefault();
                int quantity = product.TotalUnit - product.UnitCombined;
                double productPrice = 0;
                if (quantity > 0)
                {
                    if (singleOffer != null)
                    {
                        while (quantity >= singleOffer.Units)
                        {
                            productPrice += singleOffer.FinalPrice;
                            quantity -= singleOffer.Units;
                            product.UnitCombined += singleOffer.Units;
                        }
                    }

                    if (quantity > 0 && combinedOffer != null)
                    {
                        while (quantity > 0)
                        {
                            var combinedProducts = Products.Where(p => combinedOffer.CombinedProductNames.Contains(p.Name) && ((p.TotalUnit - p.UnitCombined) > 0));
                            if (combinedProducts == null || combinedProducts.Count() != combinedOffer.CombinedProductNames.Length)
                            {
                                break;
                            }

                            foreach(var prod in combinedProducts)
                            {
                                prod.UnitCombined++;
                            }
                            quantity--;
                            productPrice += combinedOffer.FinalPrice;
                        }
                    }
                    productPrice += quantity * product.PricePerUnit;
                    product.TotalPrice = productPrice;
                }
            });
        }

    }
}
