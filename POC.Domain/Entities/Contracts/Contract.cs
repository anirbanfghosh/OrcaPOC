using System.Text.Json.Serialization;
using POC.Domain.Entities.Products;

namespace POC.Domain.Entities.Contracts
{
    public class Contract
    {
        [JsonPropertyName("_id")]
        public required Guid _id { get; set; }

        [JsonPropertyName("Name")]
        public required string Name { get; set; }

        [JsonPropertyName("CountryId")]
        public required int CountryId { get; set; }

        [JsonPropertyName("Products")]
        public required HashSet<Product> Products { get; set; }
    }
}
