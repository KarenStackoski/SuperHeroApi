using System.Text.Json.Serialization;

namespace SuperHeroApi.Models
{
    public partial class SuperHeroModel
    {
        public class ImageModel
        {
            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }


    }
}
