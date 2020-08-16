using Newtonsoft.Json;
using PromotionEngine.Contracts.Models;
using System.Collections.Generic;
using System.IO;

namespace PromotionEngine.Repository
{
    public class OfferRepository: IOfferRepository
    {
        private const string OFFERMETADATA = "\\JsonDataFiles\\OfferMetaData.json";

        public List<Offer> GetAllOffers()
        {
            using (StreamReader file = File.OpenText($"{Directory.GetCurrentDirectory()}\\{OFFERMETADATA}"))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (List<Offer>)serializer.Deserialize(file, typeof(List<Offer>));
            }
        }
    }
}
