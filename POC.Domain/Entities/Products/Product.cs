using System.Text.Json.Serialization;

namespace POC.Domain.Entities.Products
{
    public class Product
    {
        [JsonPropertyName("_id")]
        public required Guid _id { get; set; }

        [JsonPropertyName("Elements")]
        public required HashSet<Element> Elements { get; set; }
    }
}
