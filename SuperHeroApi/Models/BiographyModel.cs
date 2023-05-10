using System.Text.Json.Serialization;

namespace SuperHeroApi.Models
{
    public partial class SuperHeroModel
    {
        public class BiographyModel
        {
            [JsonPropertyName("full-name")]
            public string? FullName { get; set; }

            [JsonPropertyName("alter-egos")]
            public string? AlterEgos { get; set; }

            [JsonPropertyName("aliases")]
            public List<string>? Aliases { get; set; }

            [JsonPropertyName("place-of-birth")]
            public string? PlaceOfBirth { get; set; }

            [JsonPropertyName("first-appearance")]
            public string? FirstAppearance { get; set; }

            [JsonPropertyName("publisher")]
            public string? Publisher { get; set; }

            [JsonPropertyName("alignment")]
            public string? Alignment { get; set; }
        }


    }
}
