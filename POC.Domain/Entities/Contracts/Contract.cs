using POC.Domain.Entities.Products;

namespace POC.Domain.Entities.Contracts
{
    public class Contract
    {
        public required Guid _id { get; set; }

        public required string Name { get; set; }

        public required int CountryId { get; set; }

        public required HashSet<Product> Products { get; set; }
    }
}
