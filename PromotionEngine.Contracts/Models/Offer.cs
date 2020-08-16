namespace PromotionEngine.Contracts.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public int Units { get; set; }
        public double FinalPrice { get; set; }
        public bool IsCombinedWithOtherProduct { get; set; }
        public string ProductName { get; set; }
        public string[] CombinedProductNames { get; set; }
    }
}
