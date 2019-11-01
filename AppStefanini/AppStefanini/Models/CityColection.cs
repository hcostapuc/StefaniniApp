using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStefanini.Models
{
    class CityColection
    {
        [JsonProperty("data")]
        public City[] Data { get; set; }
    }
}
