using System.Text.Json.Serialization;

namespace POC.Domain.Entities.Contracts
{
    public class Root
    {
        [JsonPropertyName("Contracts")]
        public required Contract Contracts { get; set; }
    }
}
