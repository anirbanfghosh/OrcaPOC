namespace POC.Domain.Entities.Products
{
    public class Product
    {
        public required Guid _id { get; set; }

        public required HashSet<Element> Elements { get; set; }
    }
}
