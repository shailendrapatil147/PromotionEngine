using Newtonsoft.Json;
using PromotionEngine.Contracts.Models;
using System.Collections.Generic;
using System.IO;

namespace PromotionEngine.Repository
{
    public class ProductRepository: IProductRepository
    {
        private const string PRODUCTMETADATA = "\\JsonDataFiles\\ProductMetaData.json";

        public List<Product> GetAllProducts()
        {
            using (StreamReader file = File.OpenText($"{Directory.GetCurrentDirectory()}\\{PRODUCTMETADATA}"))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (List<Product>)serializer.Deserialize(file, typeof(List<Product>));
            }
        }
    }
}
