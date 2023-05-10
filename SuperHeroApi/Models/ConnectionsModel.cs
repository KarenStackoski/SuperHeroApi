using System.Text.Json.Serialization;

namespace SuperHeroApi.Models
{
    public partial class SuperHeroModel
    {
        public class ConnectionsModel
        {
            [JsonPropertyName("group-affiliation")]
            public string? GroupAffiliation { get; set; }

            [JsonPropertyName("relatives")]
            public string? Relatives { get; set; }
        }


    }
}
