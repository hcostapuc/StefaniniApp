using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStefanini.Models
{
   public class Coord : ICoord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}
