using System.Net;
using System.Text.Json.Serialization;

namespace SuperHeroApi.Models
{
    public partial class SuperHeroModel
    {
        [JsonPropertyName("response")]
        public string? Response { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("powerstats")]
        public PowerstatsModel? Powerstats { get; set; }

        [JsonPropertyName("biography")]
        public BiographyModel? Biography { get; set; }

        [JsonPropertyName("appearance")]
        public AppearanceModel? Appearance { get; set; }

        [JsonPropertyName("work")]
        public WorkModel? Work { get; set; }

        [JsonPropertyName("connections")]
        public ConnectionsModel? Connections { get; set; }

        [JsonPropertyName("image")]
        public ImageModel? Image { get; set; }
        public HttpStatusCode HttpCode { get; internal set; }
    }
}
