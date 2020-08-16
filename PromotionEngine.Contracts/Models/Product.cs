namespace PromotionEngine.Contracts.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int TotalUnit { get; set; }
        public double PricePerUnit { get; set; }
        public string Name { get; set; }
        public double TotalPrice { get; set; }
        public int UnitCombined { get; set; }
    }
}
