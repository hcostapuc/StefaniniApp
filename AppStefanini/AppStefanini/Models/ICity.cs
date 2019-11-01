using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStefanini.Models
{
    interface ICity
    {
        [JsonProperty("id")]
        long Id { get; set; }

        [JsonProperty("coord")]
        Coord Coord { get; set; }

        [JsonProperty("country")]
        string Country { get; set; }

        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("zoom")]
        long Zoom { get; set; }
    }
}
