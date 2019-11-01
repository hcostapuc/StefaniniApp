using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStefanini.Models
{
    public interface ICoord
    {
        [JsonProperty("lon")]
        double Lon { get; set; }

        [JsonProperty("lat")]
        double Lat { get; set; }
    }
}
