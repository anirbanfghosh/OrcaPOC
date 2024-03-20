using System.Text.Json.Serialization;

namespace POC.Domain.Entities.Products
{
    public class Element
    {
        [JsonPropertyName("_t")]
        public required string _t { get; set; }

        [JsonPropertyName("Fee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Fee { get; set; }

        [JsonPropertyName("Price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Price { get; set; }
    }
}
