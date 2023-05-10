using System.Text.Json.Serialization;

namespace SuperHeroApi.Models
{
    public partial class SuperHeroModel
    {
        public class WorkModel
        {
            [JsonPropertyName("occupation")]
            public string? Occupation { get; set; }

            [JsonPropertyName("base")]
            public string? Base { get; set; }
        }


    }
}
