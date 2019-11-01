using Newtonsoft.Json;
using System;

namespace AppStefanini.Models
{
    public class City : ICity
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zoom")]
        public long Zoom { get; set; }
    }
}