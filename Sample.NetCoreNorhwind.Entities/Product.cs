namespace Sample.NetCoreNorhwind.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal QuantityPerUnit { get; set; }
        public decimal UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string Product set; }
        public Category Category { get; set; }
    }
}