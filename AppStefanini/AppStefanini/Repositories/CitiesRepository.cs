using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using AppStefanini.Models;
using System.IO;
using Android.App;

namespace AppStefanini.Repository
{
    class CitiesRepository
    {
        public CityColection GetCities()
        {
            return JsonConvert.DeserializeObject<CityColection>(ReadJsonArchive());
            
        }

        private string ReadJsonArchive()
        {
            var json = String.Empty;
            var stream = Application.Context.Assets.Open("CityList.json");
            using (StreamReader streamReader = new StreamReader(stream)) {
                json = streamReader.ReadToEnd();
            };
            return json;
        }
    }

}
